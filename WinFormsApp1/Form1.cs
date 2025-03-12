using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Вызываем UpdateListBox для выключения checkbox при запуске
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListCheckBox(lbSVBAuthors, cbSVBAuthors, 3, 5);
        }

        //
        // ------------------------- СЛОВАРЬ СОКРАЩЕНИЙ ----------------------------
        //
        Dictionary<string, string> abbreviations = new Dictionary<string, string>
        {
            { "автор", "авт." },
            { "автор и составитель", "авт. и сост." },
            { "автореферат", "автореф." },
            { "академия", "акад." },
            { "аналитический", "аналит." },
            { "английский", "англ." },
            { "аннотация", "аннот." },
            { "библиография", "библиогр." },
            { "бюллетень", "бюл." },
            { "[и другие]", "[и др.]" },
            { "издание 4-е, исправленное", "изд. 4-е, испр." },
            { "издательство", "изд-во" },
            { "институт", "ин-т" },
            { "информационный", "информ." },
            { "исторический", "ист." },
            { "кандидат", "канд." },
            { "конференция", "конф." },
            { "министерство", "м-во" },
            { "монография", "моногр." },
            { "научный", "науч." },
            { "немецкий", "нем." },
            { "областной", "обл." },
            { "ответственный", "отв." },
            { "ответственный редактор", "отв. ред." },
            { "официальный текст", "офиц. текст" },
            { "перевод", "пер." },
            { "перевод с английского", "пер. с англ." },
            { "переводчик", "пер." },
            { "переиздание", "переизд." },
            { "под редакцией", "под ред." },
            { "популярный", "попул." },
            { "посвященный", "посвящ." },
            { "приложение", "прил." },
            { "редактор", "ред." },
            { "редакционная коллегия", "редкол." },
            { "редакция", "ред." },
            { "русский", "рус." },
            { "сборник", "сб." },
            { "серия", "сер." },
            { "словарь", "слов." },
            { "собрание", "собр." },
            { "составитель", "сост." },
            { "справочник", "справ." },
            { "справочное пособие", "справ. пособие" },
            { "тематический", "темат." },
            { "том", "т." },
            { "университет", "ун-т" },
            { "утвержден", "утв." },
            { "учебное пособие", "учеб. пособие" },
            { "учебно-методическое пособие", "учеб.-метод. пособие" },
            { "федеральный закон", "федер. закон" },
            { "французский", "фр." },
            { "часть", "ч." },
            { "экономических", "экон." },
            { "энциклопедия", "энцикл." },
            { "язык", "яз." }
        };

        //
        // ------------------------- КОНТЕКСТНОЕ МЕНЮ И ЕГО ФУНКЦИОНАЛ ----------------------------
        //

        // Переменная для хранения текущего выбранного ListBox для удаления
        private ListBox _currentListBox = null;

        // Опредление ListBox и сохранение в переменной
        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Преобразуем отправителя события в ListBox
                _currentListBox = sender as ListBox;

                // Если нужно сразу выбрать элемент под курсором
                int index = _currentListBox.IndexFromPoint(e.Location);
                if (index >= 0)
                {
                    _currentListBox.SelectedIndex = index;
                }
            }
        }

        private void cmsListBox_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Если _currentListBox == null или ничего не выбрано — пользователь кликнул
            // в пустое место (или нет текущего списка).
            if (_currentListBox == null || _currentListBox.SelectedIndex < 0)
            {
                tsmiDeleteSelected.Visible = false;
                tsmiCopy.Visible = false;
            }
            else
            {
                tsmiDeleteSelected.Visible = true;
                tsmiCopy.Visible = true;
            }
        }

        // Кнопка "Удалить"
        private void tsmiDeleteSelected_Click(object sender, EventArgs e)
        {
            if (_currentListBox != null && _currentListBox.SelectedIndex >= 0)
            {
                _currentListBox.Items.RemoveAt(_currentListBox.SelectedIndex);
            }

            // Если удаляем автора из lbSVBAuthors — обновляем чекбокс
            if (_currentListBox.Name == "lbSVBAuthors")
            {
                UpdateListCheckBox(lbSVBAuthors, cbSVBAuthors, 3, 5);
            }
        }

        // Кнопка "Удалить все"
        private void tsmiDeleteAll_Click(object sender, EventArgs e)
        {
            if (_currentListBox != null)
            {
                _currentListBox.Items.Clear();
            }

            // Если удаляем автора из lbSVBAuthors — обновляем чекбокс
            if (_currentListBox.Name == "lbSVBAuthors")
            {
                UpdateListCheckBox(lbSVBAuthors, cbSVBAuthors, 3, 5);
            }
        }

        // Кнопка "Копировать"
        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            if (_currentListBox != null && _currentListBox.SelectedIndex >= 0)
            {
                string selectedItem = _currentListBox.Items[_currentListBox.SelectedIndex].ToString();
                Clipboard.SetText(selectedItem);
            }
        }

        //
        // ------------------------- ВСПОМОГАТЕЛЬНЫЕ ФУНКЦИИ ----------------------------
        //

        // Добавление строк в ListBox
        public void AddStringToListBox(TextBox sourceTextBox, ListBox targetListBox)
        {
            string input = sourceTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                // Если целевой ListBox — это список авторов, проверяем формат автора
                if (targetListBox.Name == "lbSVBAuthors")
                {
                    var regex = new System.Text.RegularExpressions.Regex(@"^(([А-ЯЁ]\.)\s*([А-ЯЁ]\.)?\s+([А-ЯЁ][а-яё]+))|(([А-ЯЁ][а-яё]+)\s+([А-ЯЁ]\.)(?:\s*([А-ЯЁ]\.))?)|(([А-ЯЁ][а-яё]+),\s*([А-ЯЁ]\.)(?:\s*([А-ЯЁ]\.))?)$");
                    if (!regex.IsMatch(input))
                    {
                        MessageBox.Show("Неверный формат автора. Используйте формат: Фамилия И. И. или И. И. Фамилия", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                targetListBox.Items.Add(input);
                sourceTextBox.Clear();
            }

            if (targetListBox.Name == "lbSVBAuthors")
            {
                UpdateListCheckBox(lbSVBAuthors, cbSVBAuthors, 3, 5);
            }
        }

        // Сбор строк из ListBox в список строк
        private List<string> GetStringsList(ListBox listBox)
        {
            List<string> strings = new List<string>();
            foreach (var item in listBox.Items)
            {
                string str = item.ToString().Trim();
                if (!string.IsNullOrEmpty(str))
                    strings.Add(str);
            }
            return strings;
        }

        static string NameFormatting(string author)
        {
            // Удаляем лишние запятые и пробелы
            string cleanedInput = Regex.Replace(author, @"\s*,\s*", " ").Trim(); // Убираем запятые
            cleanedInput = Regex.Replace(cleanedInput, @"\s+", " ");  // Убираем лишние пробелы

            // Шаблоны для различных форматов
            var pattern1 = new Regex(@"^([А-ЯЁ][а-яё]+)\s*([А-ЯЁ])\.?\s*([А-ЯЁ])\.?$");
            var pattern2 = new Regex(@"^([А-ЯЁ])\.?\s*([А-ЯЁ])\.?\s*([А-ЯЁ][а-яё]+)$");

            if (pattern1.IsMatch(cleanedInput))
            {
                var match = pattern1.Match(cleanedInput);
                return $"{match.Groups[1].Value} {match.Groups[2].Value}. {match.Groups[3].Value}.";
            }
            else if (pattern2.IsMatch(cleanedInput))
            {
                var match = pattern2.Match(cleanedInput);
                return $"{match.Groups[3].Value} {match.Groups[1].Value}. {match.Groups[2].Value}.";
            }
            else
            {
                return cleanedInput;
            }
        }

        // Принимает строку вида "Фамилия В. Н." (запятая опциональна)
        // и возвращает строку "В. Н. Фамилия", если строка соответствует шаблону.
        private string ReverseAuthorName(string author)
        {
            var regex = new System.Text.RegularExpressions.Regex(
                @"^(([А-ЯЁ]\.)\s*([А-ЯЁ]\.)?\s+([А-ЯЁ][а-яё]+))" +
                @"|(([А-ЯЁ][а-яё]+)\s+([А-ЯЁ]\.)(?:\s*([А-ЯЁ]\.))?)"
            );

            var match = regex.Match(author);

            if (!match.Success)
            {
                return author;
            }

            string surname = "";
            string init1 = "";
            string init2 = "";

            // Если фамилия оказалась в Group[4] ("И. И. Фамилия").
            if (!string.IsNullOrEmpty(match.Groups[4].Value))
            {
                init1 = match.Groups[2].Value;
                init2 = match.Groups[3].Value;
                surname = match.Groups[4].Value;
            }
            // Если фамилия оказалась в Group[6] ("Фамилия И. И.")
            else if (!string.IsNullOrEmpty(match.Groups[6].Value))
            {
                surname = match.Groups[6].Value;
                init1 = match.Groups[7].Value;
                init2 = match.Groups[8].Value;
            }

            // Склеиваем
            init1 = init1.Trim();
            init2 = init2.Trim();
            if (string.IsNullOrEmpty(init2))
                return $"{init1} {surname}".Trim();
            else
                return $"{init1} {init2} {surname}".Trim();
        }

        // Метод, который гарантирует, что после фамилии вставлена запятая,
        // если её нет во входной строке (например, преобразует "Дорман В. Н." в "Дорман, В. Н.").
        private string EnsureComma(string author)
        {
            var regex = new System.Text.RegularExpressions.Regex(
                @"^(([А-ЯЁ][а-яё]+)\s+([А-ЯЁ]\.)(?:\s*([А-ЯЁ]\.))?)"
            );

            var match = regex.Match(author);

            if (!match.Success)
            {
                return author;
            }

            string surname = match.Groups[2].Value;
            string init1 = match.Groups[3].Value;
            string init2 = match.Groups[4].Value;

            init1 = init1.Trim();
            init2 = init2.Trim();

            if (string.IsNullOrEmpty(init2))
                return $"{surname}, {init1}".Trim();
            else
                return $"{surname}, {init1} {init2}".Trim();
        }

        // Связь мест издания и издателей через ":"
        private string CombinePlacesAndPublishers(List<string> places, List<string> publishers)
        {
            // Объединяем по парам: places[i] : publishers[i]
            int count = Math.Min(places.Count, publishers.Count);
            List<string> combined = new List<string>();
            for (int i = 0; i < count; i++)
            {
                combined.Add($"{places[i]} : {publishers[i]}");
            }
            // Склеиваем через " ; "
            return string.Join(" ; ", combined);
        }

        // Универсальная функция для логики чек бокса авторов
        private void UpdateListCheckBox(ListBox listBox, CheckBox checkBox, int minCount, int maxCount)
        {
            int itemCount = listBox.Items.Count;

            if (itemCount >= maxCount)
            {
                checkBox.Checked = true;
                checkBox.Enabled = false;
            }
            else if (itemCount < minCount)
            {
                checkBox.Checked = false;
                checkBox.Enabled = false;
            }
            else
            {
                checkBox.Checked = false;
                checkBox.Enabled = true;
            }
        }








        // Единая функция для кнопки "Добавить", которая определяет активные вкладки
        // и вызывает функцию формирования записи для соответствующего типа источника.
        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if (tcCategories.SelectedTab == tpSingleVolume)
            {
                if (tcSVTypes.SelectedTab == tpSVBook)
                {
                    ProcessBook();
                }
                else if (tcSVTypes.SelectedTab == tpSVRegulatoryDocument)
                {
                    ProcessRegulatoryDocument();
                }
                else if (tcSVTypes.SelectedTab == tpSVDissertationAbstract)
                {
                    ProcessDissertationAbstract();
                }
                else if (tcSVTypes.SelectedTab == tpSVDissertation)
                {
                    ProcessDissertation();
                }
            }
            else if (tcCategories.SelectedTab == tpMultiVolume)
            {
                if (tcMVTypes.SelectedTab == tpMVWholeMultivolume)
                {
                    ProcessWholeMultivolume();
                }
                else if (tcMVTypes.SelectedTab == tpMVSeparateVolume)
                {
                    ProcessSeparateVolume();
                }
            }
            else if (tcCategories.SelectedTab == tpElectronicResources)
            {
                if (tcERTypes.SelectedTab == tpEREbook)
                {
                    ProcessEBook();
                }
                else if (tcERTypes.SelectedTab == tpERMultimediaEdition)
                {
                    ProcessMultimediaEdition();
                }
                else if (tcERTypes.SelectedTab == tpEREjournalArticle)
                {
                    ProcessEjournalArticle();
                }

                else if (tcERTypes.SelectedTab == tpERWebsite)
                {
                    ProcessWebsite();
                }
            }
            else if (tcCategories.SelectedTab == tpConstituentParts)
            {
                if (tcCPTypes.SelectedTab == tpCPBookArticle)
                {
                    ProcessBookArticle();
                }
                else if (tcCPTypes.SelectedTab == tpCPJournalArticle)
                {
                    ProcessJournalArticle();
                }
                else if (tcCPTypes.SelectedTab == tpCPNewspaperArticle)
                {
                    ProcessNewspaperArticle();
                }
                else if (tcCPTypes.SelectedTab == tpCPWebsiteArticle)
                {
                    ProcessWebsiteArticle();
                }
            }
        }



        //
        // ------------------------- КАТЕГОРИЯ "ОДНОЧАСТНЫЕ (ОДНОТОМНЫЕ) РЕСУРСЫ" ----------------------------
        //

        // ------------------------- ТИП "КНИГА" ----------------------------

        private void buttonSVBAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbSVBAuthors, lbSVBAuthors);
        }

        private void buttonSVBPublishingLocationAdd_Click(Object sender, EventArgs e)
        {
            AddStringToListBox(tbSVBPublishingLocation, lbSVBPublishingLocation);
        }

        private void buttonSVBPublisherAdd_Click(Object sender, EventArgs e)
        {
            AddStringToListBox(tbSVBPublisher, lbSVBPublisher);
        }

        private void buttonSVBEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbSVBEditor, lbSVBEditor);
        }

        // Функция обработки записи для "Книги"
        private void ProcessBook()
        {
            // Проверяем обязательные поля
            List<string> errors = new List<string>();
            List<string> authorsList = GetStringsList(lbSVBAuthors);
            List<string> publishingLocationsList = GetStringsList(lbSVBPublishingLocation);
            List<string> publishersList = GetStringsList(lbSVBPublisher);
            List<string> editorsList = GetStringsList(lbSVBEditor);

            if (authorsList.Count == 0)
                errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(tbSVBTitle.Text.Trim()))
                errors.Add("Не заполнено поле «Название»");
            if (publishingLocationsList.Count == 0)
                errors.Add("Не указано ни одно место издания");
            if (publishersList.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (string.IsNullOrEmpty(tbSVBPublishYear.Text.Trim()))
                errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(tbSVBPagesCount.Text.Trim()))
                errors.Add("Не заполнено поле «Количество страниц»");

            if (errors.Count > 0)
            {
                MessageBox.Show(
                    "Пожалуйста, заполните следующие обязательные поля:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            // Считываем поля
            string mainTitle = tbSVBTitle.Text.Trim();
            string parallelTitle = tbSVBParallelTitle.Text.Trim();
            string docType = tbSVBDocumentType.Text.Trim();
            string editionNum = tbSVBEditionNumber.Text.Trim();
            string year = tbSVBPublishYear.Text.Trim();
            string pages = tbSVBPagesCount.Text.Trim();
            string series = tbSVBSeries.Text.Trim();
            string isbn = tbSVBISBN.Text.Trim();
            string translator = tbSVBTranslator.Text.Trim();
            string organization = tbSVBOrganization.Text.Trim();
            string contentType = tbSVBContentType.Text.Trim();
            string editorType = cbSVBEditorType.SelectedItem?.ToString().Trim();

            // Формируем основное/параллельное заглавие
            string fullTitle = string.IsNullOrEmpty(parallelTitle)
                ? mainTitle
                : $"{mainTitle} = {parallelTitle}";

            // Форматируем авторов
            List<string> formattedAuthors = authorsList.Select(a => NameFormatting(a)).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(a => EnsureComma(a)).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(a => ReverseAuthorName(a)).ToList();

            string editorsJoined = string.Join(", ", editorsList);

            int countA = formattedAuthors.Count;

            string titleAndAuthorsBlock = "";
            if (cbSVBAuthors.Checked && countA >= 3)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                titleAndAuthorsBlock = !string.IsNullOrEmpty(docType)
                    ? $"{fullTitle} : {docType} / {firstThree} [и другие]"
                    : $"{fullTitle} / {firstThree} [и другие]";
            }
            else
            {
                if (countA == 1)
                {
                    string authorFmt = authorsWithComma[0];
                    string authorRev = reversedAuthors[0];
                    titleAndAuthorsBlock = !string.IsNullOrEmpty(docType)
                        ? $"{authorFmt} {fullTitle} : {docType} / {authorRev}"
                        : $"{authorFmt} {fullTitle} / {authorRev}";
                }
                else if (countA == 2 || countA == 3)
                {
                    string firstAuthorFmt = authorsWithComma[0];
                    string allRev = string.Join(", ", reversedAuthors);
                    titleAndAuthorsBlock = !string.IsNullOrEmpty(docType)
                        ? $"{firstAuthorFmt} {fullTitle} : {docType} / {allRev}"
                        : $"{firstAuthorFmt} {fullTitle} / {allRev}";
                }
                else if (countA == 4)
                {
                    string allRev = string.Join(", ", reversedAuthors);
                    titleAndAuthorsBlock = !string.IsNullOrEmpty(docType)
                        ? $"{fullTitle} : {docType} / {allRev}"
                        : $"{fullTitle} / {allRev}";
                }
                else if (countA >= 5)
                {
                    string firstThree = string.Join(", ", reversedAuthors.Take(3));
                    titleAndAuthorsBlock = !string.IsNullOrEmpty(docType)
                        ? $"{fullTitle} : {docType} / {firstThree} [и другие]"
                        : $"{fullTitle} / {firstThree} [и другие]";
                }
                else
                {
                    titleAndAuthorsBlock = fullTitle;
                }
            }

            string responsibilityBlock = "";
            bool hasEditors = !string.IsNullOrEmpty(editorsJoined);
            bool hasOrg = !string.IsNullOrEmpty(organization);

            if (hasEditors)
            {
                switch (editorType)
                {
                    case "Под редакцией":
                        responsibilityBlock = $"под редакцией {editorsJoined}";
                        break;
                    case "Под общей редакцией":
                        responsibilityBlock = $"под общей редакцией {editorsJoined}";
                        break;
                    case "Ответственный редактор":
                        responsibilityBlock = $"ответственный редактор {editorsJoined}";
                        break;
                    default:
                        responsibilityBlock = $"под редакцией {editorsJoined}";
                        break;
                }
            }

            // Добавляем организацию через ";"
            if (hasOrg)
            {
                responsibilityBlock = !string.IsNullOrEmpty(responsibilityBlock)
                    ? $"{responsibilityBlock} ; {organization}"
                    : organization;
            }

            // Соединяем
            string firstBlock = !string.IsNullOrEmpty(responsibilityBlock)
                ? $"{titleAndAuthorsBlock} ; {responsibilityBlock}"
                : titleAndAuthorsBlock;

            string editionTranslationBlock = "";
            bool hasEdition = !string.IsNullOrEmpty(editionNum);
            bool hasTranslator = !string.IsNullOrEmpty(translator);

            if (hasEdition && hasTranslator)
            {
                editionTranslationBlock = $"{editionNum} ; {translator}";
            }
            else if (hasEdition)
            {
                editionTranslationBlock = editionNum;
            }
            else if (hasTranslator)
            {
                editionTranslationBlock = translator;
            }

            string placesAndPubs = CombinePlacesAndPublishers(publishingLocationsList, publishersList);
            string imprintBlock = $"{placesAndPubs}, {year}";

            string pagesBlock = string.IsNullOrEmpty(pages) ? "" : $"{pages} с.";

            string seriesBlock = string.IsNullOrEmpty(series) ? "" : $"({series})";

            string isbnBlock = string.IsNullOrEmpty(isbn) ? "" : $"ISBN {isbn}";

            string translatorBlock = string.IsNullOrEmpty(translator)
                ? ""
                : $"переводчик с {translator}";

            string contentBlock = string.IsNullOrEmpty(contentType)
                ? "Текст : непосредственный"
                : contentType;

            List<string> blocks = new List<string>();
            if (!string.IsNullOrEmpty(firstBlock)) blocks.Add(firstBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(editionTranslationBlock)) blocks.Add(editionTranslationBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(imprintBlock)) blocks.Add(imprintBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(seriesBlock)) blocks.Add(seriesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(translatorBlock)) blocks.Add(translatorBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(contentBlock)) blocks.Add(contentBlock.TrimEnd('.'));


            // Склеиваем блоки ". - "
            string result = string.Join(". - ", blocks) + ".";

            // Очистка полей
            lbSVBAuthors.Items.Clear();
            lbSVBPublishingLocation.Items.Clear();
            lbSVBPublisher.Items.Clear();
            lbSVBEditor.Items.Clear();
            tbSVBTitle.Clear();
            tbSVBParallelTitle.Clear();
            tbSVBPublishYear.Clear();
            tbSVBPagesCount.Clear();
            tbSVBDocumentType.Clear();
            tbSVBEditor.Clear();
            tbSVBEditionNumber.Clear();
            tbSVBSeries.Clear();
            tbSVBISBN.Clear();
            tbSVBTranslator.Clear();
            tbSVBOrganization.Clear();
            tbSVBContentType.Clear();
            UpdateListCheckBox(lbSVBAuthors, cbSVBAuthors, 3, 5);

            lbResult.Items.Add(result);
        }































        // Заготовки для остальных типов (дополните по аналогии)
        private void ProcessRegulatoryDocument()
        {
            // Здесь реализуйте обработку полей для нормативного документа по ГОСТ
            MessageBox.Show("Обработка нормативного документа не реализована.");
        }

        private void ProcessDissertationAbstract()
        {
            // Здесь реализуйте обработку полей для автореферата диссертации по ГОСТ
            MessageBox.Show("Обработка автореферата диссертации не реализована.");
        }

        private void ProcessDissertation()
        {
            // Здесь реализуйте обработку полей для диссертации по ГОСТ
            MessageBox.Show("Обработка диссертации не реализована.");
        }

        // Заготовки для категории Многочастные ресурсы и электронные ресурсы
        private void ProcessWholeMultivolume()
        {
            MessageBox.Show("Обработка многотомного издания в целом не реализована.");
        }

        private void ProcessSeparateVolume()
        {
            MessageBox.Show("Обработка отдельного тома многотомного издания не реализована.");
        }

        private void ProcessEBook()
        {
            MessageBox.Show("Обработка электронной книги не реализована.");
        }

        private void ProcessEjournalArticle()
        {
            MessageBox.Show("Обработка статьи из электронного журнала не реализована.");
        }

        private void ProcessMultimediaEdition()
        {
            MessageBox.Show("Обработка мультимедийного издания не реализована.");
        }

        private void ProcessWebsite()
        {
            MessageBox.Show("Обработка веб-сайта не реализована.");
        }

        private void ProcessBookArticle()
        {
            MessageBox.Show("Обработка статьи/раздела из книги не реализована.");
        }

        private void ProcessJournalArticle()
        {
            MessageBox.Show("Обработка статьи из материалов конференции не реализована.");
        }

        private void ProcessNewspaperArticle()
        {
            MessageBox.Show("Обработка статьи из материалов конференции не реализована.");
        }

        private void ProcessWebsiteArticle()
        {
            MessageBox.Show("Обработка статьи из материалов конференции не реализована.");
        }








        private void buttonCopyResult_Click(object sender, EventArgs e)
        {
            string strCopy = "";
            foreach (var item in lbResult.Items)
            {
                string str = item.ToString().Trim();
                if (!string.IsNullOrEmpty(str))
                    strCopy += str + "\n";
            }
            Clipboard.SetText(strCopy);
        }
    }
}