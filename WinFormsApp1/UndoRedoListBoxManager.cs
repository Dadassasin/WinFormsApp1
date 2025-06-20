using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

internal sealed class UndoRedoListBoxManager
{
    // Для каждого ListBox храним два стека команд: Do/Undo
    private readonly Dictionary<ListBox, Stack<(Action Do, Action Undo)>> _undoStacks
        = new Dictionary<ListBox, Stack<(Action, Action)>>();
    private readonly Dictionary<ListBox, Stack<(Action Do, Action Undo)>> _redoStacks
        = new Dictionary<ListBox, Stack<(Action, Action)>>();

    /// <summary>
    /// Публичный метод для инициализации истории данного ListBox.
    /// </summary>
    public void Register(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        EnsureRegistered(lb);
    }

    /// <summary>
    /// Гарантирует, что для данного ListBox инициализированы стеки.
    /// </summary>
    private void EnsureRegistered(ListBox lb)
    {
        if (!_undoStacks.ContainsKey(lb))
        {
            _undoStacks[lb] = new Stack<(Action, Action)>();
            _redoStacks[lb] = new Stack<(Action, Action)>();
        }
    }

    /// <summary>
    /// Выполнить произвольную операцию и сохранить её в истории.
    /// </summary>
    public void Execute(ListBox lb, Action doAction, Action undoAction)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (doAction == null) throw new ArgumentNullException(nameof(doAction));
        if (undoAction == null) throw new ArgumentNullException(nameof(undoAction));

        EnsureRegistered(lb);
        doAction();
        _undoStacks[lb].Push((doAction, undoAction));
        _redoStacks[lb].Clear();
    }

    /// <summary>
    /// Удалить текущий выбранный элемент (Delete/Backspace) с поддержкой Undo.
    /// </summary>
    public void DeleteItem(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        int idx = lb.SelectedIndex;
        if (idx < 0) return;

        var item = lb.Items[idx];
        Execute(
            lb,
            // Do
            () => lb.Items.RemoveAt(idx),
            // Undo c безопасной вставкой
            () =>
            {
                int insertIndex = Math.Min(idx, lb.Items.Count);
                lb.Items.Insert(insertIndex, item);
            }
        );
    }

    /// <summary>
    /// Полностью очистить список с поддержкой Undo.
    /// </summary>
    public void ClearItems(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        var backup = lb.Items.Cast<object>().ToList();

        Execute(
            lb,
            () => lb.Items.Clear(),
            () =>
            {
                lb.Items.Clear();
                foreach (var it in backup)
                    lb.Items.Add(it);
            }
        );
    }

    public void AddItem(ListBox lb, object item)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (item == null) throw new ArgumentNullException(nameof(item));

        Execute(
            lb,
            // Do: добавить
            () => lb.Items.Add(item),
            // Undo: удалить
            () => lb.Items.Remove(item)
        );
    }

    /// <summary>Отменить последнюю операцию для данного ListBox.</summary>
    public void Undo(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (!_undoStacks.ContainsKey(lb) || _undoStacks[lb].Count == 0) return;

        var (doAction, undoAction) = _undoStacks[lb].Pop();
        undoAction();
        _redoStacks[lb].Push((doAction, undoAction));
    }

    /// <summary>Повторить последнюю отменённую операцию.</summary>
    public void Redo(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (!_redoStacks.ContainsKey(lb) || _redoStacks[lb].Count == 0) return;

        var (doAction, undoAction) = _redoStacks[lb].Pop();
        doAction();
        _undoStacks[lb].Push((doAction, undoAction));
    }

    /// <summary>Можно ли выполнить Undo для данного ListBox?</summary>
    public bool CanUndo(ListBox lb)
        => lb != null
           && _undoStacks.ContainsKey(lb)
           && _undoStacks[lb].Count > 0;

    /// <summary>Можно ли выполнить Redo для данного ListBox?</summary>
    public bool CanRedo(ListBox lb)
        => lb != null
           && _redoStacks.ContainsKey(lb)
           && _redoStacks[lb].Count > 0;

    /// <summary>Полностью очищает историю Undo/Redo для данного ListBox.</summary>
    public void ClearHistory(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (_undoStacks.ContainsKey(lb)) _undoStacks[lb].Clear();
        if (_redoStacks.ContainsKey(lb)) _redoStacks[lb].Clear();
    }
}
