namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Метки для обязательных полей
        private Label labelSVBAuthors;
        private Label labelSVBTitle;
        private Label labelSVBPublishingLocation;
        private Label labelSVBPublisher;
        private Label labelSVBPublishYear;
        private Label labelSVBPagesCount;

        // Новые элементы для поля "Автор(ы)"
        private TextBox textBoxAuthors;
        private Button buttonAddAuthor;
        private ListBox listBoxAuthors;

        // Метки для необязательных полей
        private Label labelSVBDocumentType;
        private Label labelSVBEditor;
        private Label labelSVBEditionNumber;
        private Label labelSVBSeries;
        private Label labelSVBISBN;
        private Label labelSVBTranslator;
        private Label labelSVBOrganization;

        // Другие элементы формы
        private SplitContainer splitContainer1;
        private TabControl tcSVTypes;
        private TabPage tpSVBook;
        private TabPage tpSVRegulatoryDocument;
        private GroupBox gpSVBookRequired;
        private GroupBox gpSVBookOptional;
        private TextBox textBoxTitle;
        private TextBox textBoxPublishingLocation;
        private TextBox textBoxPublisher;
        private TextBox textBoxYear;
        private TextBox textBoxPages;
        private TextBox textBoxDocumentType;
        private TextBox textBoxEditor;
        private TextBox textBoxEditionNumber;
        private TextBox textBoxSeries;
        private TextBox textBoxISBN;
        private TextBox textBoxTranslator;
        private TextBox textBoxOrganization;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label25 = new Label();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            panel1 = new Panel();
            buttonAddRecord = new Button();
            cbWordAbbreviation = new CheckBox();
            tcCategories = new TabControl();
            tpSingleVolume = new TabPage();
            tcSVTypes = new TabControl();
            tpSVBook = new TabPage();
            gpSVBookRequired = new GroupBox();
            labelSVBAuthors = new Label();
            textBoxAuthors = new TextBox();
            buttonAddAuthor = new Button();
            listBoxAuthors = new ListBox();
            labelSVBTitle = new Label();
            textBoxTitle = new TextBox();
            labelSVBPublishingLocation = new Label();
            textBoxPublishingLocation = new TextBox();
            labelSVBPublisher = new Label();
            textBoxPublisher = new TextBox();
            labelSVBPublishYear = new Label();
            textBoxYear = new TextBox();
            labelSVBPagesCount = new Label();
            textBoxPages = new TextBox();
            gpSVBookOptional = new GroupBox();
            panelSVBookOptional = new Panel();
            labelSVBDocumentType = new Label();
            textBoxOrganization = new TextBox();
            textBoxDocumentType = new TextBox();
            labelSVBOrganization = new Label();
            labelSVBEditor = new Label();
            textBoxTranslator = new TextBox();
            textBoxEditor = new TextBox();
            labelSVBTranslator = new Label();
            labelSVBEditionNumber = new Label();
            textBoxISBN = new TextBox();
            textBoxEditionNumber = new TextBox();
            labelSVBISBN = new Label();
            labelSVBSeries = new Label();
            textBoxSeries = new TextBox();
            tpSVRegulatoryDocument = new TabPage();
            gbSVRegulatoryDocumentRequired = new GroupBox();
            labelSVRDDocumentNumber = new Label();
            textBox1 = new TextBox();
            labelSVRDTitle = new Label();
            textBox2 = new TextBox();
            labelSVRDPublishingLocation = new Label();
            textBox3 = new TextBox();
            labelSVRDPublisher = new Label();
            textBox4 = new TextBox();
            labelSVRDPublishYear = new Label();
            textBox5 = new TextBox();
            gbSVRegulatoryDocumentOptional = new GroupBox();
            panelSVRegulatoryDocumentOptional = new Panel();
            labelSVRDCountry = new Label();
            labelSVRDDocumentType = new Label();
            textBox16 = new TextBox();
            textBox13 = new TextBox();
            labelSVRDAdditions = new Label();
            labelSVRDOfficialEdition = new Label();
            textBox15 = new TextBox();
            textBox12 = new TextBox();
            labelSVRDAbbreviation = new Label();
            labelSVRDTitleTranslation = new Label();
            textBox14 = new TextBox();
            textBox11 = new TextBox();
            labelSVRDPagesCount = new Label();
            labelSVRDISBN = new Label();
            textBox6 = new TextBox();
            textBox10 = new TextBox();
            labelSVRDDeveloper = new Label();
            textBox7 = new TextBox();
            textBox9 = new TextBox();
            labelSVRDApprovalDate = new Label();
            labelSVRDImplementDate = new Label();
            textBox8 = new TextBox();
            tpSVDissertationAbstract = new TabPage();
            gbSVDissertationAbstractRequired = new GroupBox();
            label24 = new Label();
            textBox24 = new TextBox();
            label23 = new Label();
            textBox23 = new TextBox();
            label22 = new Label();
            textBox22 = new TextBox();
            label17 = new Label();
            textBox17 = new TextBox();
            label18 = new Label();
            textBox18 = new TextBox();
            label19 = new Label();
            textBox19 = new TextBox();
            label20 = new Label();
            textBox20 = new TextBox();
            label21 = new Label();
            textBox21 = new TextBox();
            gbSVDissertationAbstractOptional = new GroupBox();
            label26 = new Label();
            textBox26 = new TextBox();
            label27 = new Label();
            textBox27 = new TextBox();
            label28 = new Label();
            textBox28 = new TextBox();
            label29 = new Label();
            textBox29 = new TextBox();
            tpSVDissertation = new TabPage();
            gbSVDissertationRequired = new GroupBox();
            label30 = new Label();
            textBox30 = new TextBox();
            label31 = new Label();
            textBox31 = new TextBox();
            label32 = new Label();
            textBox32 = new TextBox();
            label33 = new Label();
            textBox33 = new TextBox();
            label34 = new Label();
            textBox34 = new TextBox();
            label35 = new Label();
            textBox35 = new TextBox();
            label36 = new Label();
            textBox36 = new TextBox();
            gbSVDissertationOptional = new GroupBox();
            label37 = new Label();
            textBox37 = new TextBox();
            label38 = new Label();
            textBox38 = new TextBox();
            label39 = new Label();
            textBox39 = new TextBox();
            label40 = new Label();
            textBox40 = new TextBox();
            tpMultiVolume = new TabPage();
            tcMVTypes = new TabControl();
            tpMVWholeMultivolume = new TabPage();
            gbMVWholeMultivolumeRequired = new GroupBox();
            label53 = new Label();
            textBox52 = new TextBox();
            label41 = new Label();
            textBox25 = new TextBox();
            button4 = new Button();
            listBox2 = new ListBox();
            label42 = new Label();
            textBox41 = new TextBox();
            label43 = new Label();
            textBox42 = new TextBox();
            label44 = new Label();
            textBox43 = new TextBox();
            label45 = new Label();
            textBox44 = new TextBox();
            label46 = new Label();
            textBox45 = new TextBox();
            gbMVWholeMultivolumeOptional = new GroupBox();
            panelMVWholeMultivolumeOptional = new Panel();
            label47 = new Label();
            label48 = new Label();
            textBox46 = new TextBox();
            textBox51 = new TextBox();
            label52 = new Label();
            textBox47 = new TextBox();
            textBox50 = new TextBox();
            label49 = new Label();
            label51 = new Label();
            textBox48 = new TextBox();
            textBox49 = new TextBox();
            label50 = new Label();
            tpMVSeparateVolume = new TabPage();
            gbMVSeparateVolumeRequired = new GroupBox();
            label68 = new Label();
            textBox67 = new TextBox();
            label67 = new Label();
            textBox66 = new TextBox();
            label54 = new Label();
            textBox53 = new TextBox();
            label55 = new Label();
            textBox54 = new TextBox();
            button5 = new Button();
            listBox3 = new ListBox();
            label56 = new Label();
            textBox55 = new TextBox();
            label57 = new Label();
            textBox56 = new TextBox();
            label58 = new Label();
            textBox57 = new TextBox();
            label59 = new Label();
            textBox58 = new TextBox();
            label60 = new Label();
            textBox59 = new TextBox();
            gbMVSeparateVolumeOptional = new GroupBox();
            panelMVSeparateVolumeOptional = new Panel();
            label61 = new Label();
            textBox60 = new TextBox();
            textBox65 = new TextBox();
            label62 = new Label();
            label66 = new Label();
            textBox61 = new TextBox();
            textBox64 = new TextBox();
            label63 = new Label();
            label65 = new Label();
            textBox62 = new TextBox();
            textBox63 = new TextBox();
            label64 = new Label();
            tpElectronicResources = new TabPage();
            tcERTypes = new TabControl();
            tpEREbook = new TabPage();
            gbEREbookRequired = new GroupBox();
            label173 = new Label();
            textBox172 = new TextBox();
            label69 = new Label();
            textBox68 = new TextBox();
            button6 = new Button();
            listBox4 = new ListBox();
            label70 = new Label();
            textBox69 = new TextBox();
            label71 = new Label();
            textBox70 = new TextBox();
            label72 = new Label();
            textBox71 = new TextBox();
            label73 = new Label();
            textBox72 = new TextBox();
            label74 = new Label();
            textBox73 = new TextBox();
            gbEREbookOptional = new GroupBox();
            panelEREbookOptional = new Panel();
            label174 = new Label();
            label81 = new Label();
            textBox173 = new TextBox();
            textBox80 = new TextBox();
            label75 = new Label();
            textBox79 = new TextBox();
            textBox74 = new TextBox();
            label80 = new Label();
            label76 = new Label();
            textBox78 = new TextBox();
            textBox75 = new TextBox();
            label79 = new Label();
            label77 = new Label();
            textBox77 = new TextBox();
            textBox76 = new TextBox();
            label78 = new Label();
            tpERMultimediaEdition = new TabPage();
            gbERMultimediaEditionRequired = new GroupBox();
            label83 = new Label();
            textBox82 = new TextBox();
            button3 = new Button();
            listBox6 = new ListBox();
            label84 = new Label();
            textBox83 = new TextBox();
            label85 = new Label();
            textBox84 = new TextBox();
            label86 = new Label();
            textBox85 = new TextBox();
            label87 = new Label();
            textBox86 = new TextBox();
            label88 = new Label();
            textBox87 = new TextBox();
            gbERMultimediaEditionOptional = new GroupBox();
            panelERMultimediaEditionOptional = new Panel();
            label90 = new Label();
            textBox89 = new TextBox();
            textBox94 = new TextBox();
            label91 = new Label();
            label95 = new Label();
            textBox90 = new TextBox();
            textBox93 = new TextBox();
            label92 = new Label();
            label94 = new Label();
            textBox91 = new TextBox();
            textBox92 = new TextBox();
            label93 = new Label();
            tpEREjournalArticle = new TabPage();
            gbEREjournalArticleReqired = new GroupBox();
            label82 = new Label();
            textBox81 = new TextBox();
            label97 = new Label();
            textBox96 = new TextBox();
            label98 = new Label();
            textBox97 = new TextBox();
            button8 = new Button();
            listBox7 = new ListBox();
            label99 = new Label();
            textBox98 = new TextBox();
            label100 = new Label();
            textBox99 = new TextBox();
            label101 = new Label();
            textBox100 = new TextBox();
            label102 = new Label();
            textBox101 = new TextBox();
            label103 = new Label();
            textBox102 = new TextBox();
            gbEREjournalArticleOptional = new GroupBox();
            label105 = new Label();
            textBox104 = new TextBox();
            tpERWebsite = new TabPage();
            gbERWebsiteRequired = new GroupBox();
            label112 = new Label();
            textBox111 = new TextBox();
            label113 = new Label();
            textBox112 = new TextBox();
            label114 = new Label();
            textBox113 = new TextBox();
            gbERWebsiteOptional = new GroupBox();
            label89 = new Label();
            textBox88 = new TextBox();
            label117 = new Label();
            textBox116 = new TextBox();
            label118 = new Label();
            textBox117 = new TextBox();
            label119 = new Label();
            textBox118 = new TextBox();
            label120 = new Label();
            textBox119 = new TextBox();
            tpConstituentParts = new TabPage();
            tcCPTypes = new TabControl();
            tpCPBookArticle = new TabPage();
            gbCPBookArticleRequired = new GroupBox();
            label130 = new Label();
            textBox129 = new TextBox();
            label129 = new Label();
            textBox128 = new TextBox();
            label123 = new Label();
            textBox122 = new TextBox();
            button12 = new Button();
            listBox11 = new ListBox();
            label121 = new Label();
            textBox120 = new TextBox();
            button7 = new Button();
            listBox5 = new ListBox();
            label122 = new Label();
            textBox121 = new TextBox();
            label124 = new Label();
            textBox123 = new TextBox();
            label125 = new Label();
            textBox124 = new TextBox();
            label126 = new Label();
            textBox125 = new TextBox();
            gbCPBookArticleOptional = new GroupBox();
            label127 = new Label();
            textBox126 = new TextBox();
            label128 = new Label();
            textBox127 = new TextBox();
            tpCPJournalArticle = new TabPage();
            gbCPJournalArticleRequired = new GroupBox();
            label96 = new Label();
            textBox95 = new TextBox();
            button9 = new Button();
            listBox8 = new ListBox();
            label104 = new Label();
            textBox103 = new TextBox();
            label106 = new Label();
            textBox105 = new TextBox();
            label107 = new Label();
            textBox106 = new TextBox();
            label108 = new Label();
            textBox107 = new TextBox();
            label109 = new Label();
            textBox108 = new TextBox();
            gbCPJournalArticleOptional = new GroupBox();
            label110 = new Label();
            textBox109 = new TextBox();
            tpCPNewspaperArticle = new TabPage();
            gbCPNewspaperArticleReqired = new GroupBox();
            label137 = new Label();
            textBox136 = new TextBox();
            button10 = new Button();
            listBox9 = new ListBox();
            label138 = new Label();
            textBox137 = new TextBox();
            label139 = new Label();
            textBox138 = new TextBox();
            label140 = new Label();
            textBox139 = new TextBox();
            label141 = new Label();
            textBox140 = new TextBox();
            label142 = new Label();
            textBox141 = new TextBox();
            gbCPNewspaperArticleOptional = new GroupBox();
            label143 = new Label();
            textBox142 = new TextBox();
            label144 = new Label();
            textBox143 = new TextBox();
            tpCPWebsiteArticle = new TabPage();
            gbCPWebsiteArticleRequired = new GroupBox();
            label150 = new Label();
            textBox149 = new TextBox();
            button11 = new Button();
            listBox10 = new ListBox();
            label151 = new Label();
            textBox150 = new TextBox();
            label152 = new Label();
            textBox151 = new TextBox();
            label153 = new Label();
            textBox152 = new TextBox();
            label154 = new Label();
            textBox153 = new TextBox();
            gbCPWebsiteArticleOptional = new GroupBox();
            label156 = new Label();
            textBox155 = new TextBox();
            label157 = new Label();
            textBox156 = new TextBox();
            label158 = new Label();
            textBox157 = new TextBox();
            label159 = new Label();
            textBox158 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            tcCategories.SuspendLayout();
            tpSingleVolume.SuspendLayout();
            tcSVTypes.SuspendLayout();
            tpSVBook.SuspendLayout();
            gpSVBookRequired.SuspendLayout();
            gpSVBookOptional.SuspendLayout();
            panelSVBookOptional.SuspendLayout();
            tpSVRegulatoryDocument.SuspendLayout();
            gbSVRegulatoryDocumentRequired.SuspendLayout();
            gbSVRegulatoryDocumentOptional.SuspendLayout();
            panelSVRegulatoryDocumentOptional.SuspendLayout();
            tpSVDissertationAbstract.SuspendLayout();
            gbSVDissertationAbstractRequired.SuspendLayout();
            gbSVDissertationAbstractOptional.SuspendLayout();
            tpSVDissertation.SuspendLayout();
            gbSVDissertationRequired.SuspendLayout();
            gbSVDissertationOptional.SuspendLayout();
            tpMultiVolume.SuspendLayout();
            tcMVTypes.SuspendLayout();
            tpMVWholeMultivolume.SuspendLayout();
            gbMVWholeMultivolumeRequired.SuspendLayout();
            gbMVWholeMultivolumeOptional.SuspendLayout();
            panelMVWholeMultivolumeOptional.SuspendLayout();
            tpMVSeparateVolume.SuspendLayout();
            gbMVSeparateVolumeRequired.SuspendLayout();
            gbMVSeparateVolumeOptional.SuspendLayout();
            panelMVSeparateVolumeOptional.SuspendLayout();
            tpElectronicResources.SuspendLayout();
            tcERTypes.SuspendLayout();
            tpEREbook.SuspendLayout();
            gbEREbookRequired.SuspendLayout();
            gbEREbookOptional.SuspendLayout();
            panelEREbookOptional.SuspendLayout();
            tpERMultimediaEdition.SuspendLayout();
            gbERMultimediaEditionRequired.SuspendLayout();
            gbERMultimediaEditionOptional.SuspendLayout();
            panelERMultimediaEditionOptional.SuspendLayout();
            tpEREjournalArticle.SuspendLayout();
            gbEREjournalArticleReqired.SuspendLayout();
            gbEREjournalArticleOptional.SuspendLayout();
            tpERWebsite.SuspendLayout();
            gbERWebsiteRequired.SuspendLayout();
            gbERWebsiteOptional.SuspendLayout();
            tpConstituentParts.SuspendLayout();
            tcCPTypes.SuspendLayout();
            tpCPBookArticle.SuspendLayout();
            gbCPBookArticleRequired.SuspendLayout();
            gbCPBookArticleOptional.SuspendLayout();
            tpCPJournalArticle.SuspendLayout();
            gbCPJournalArticleRequired.SuspendLayout();
            gbCPJournalArticleOptional.SuspendLayout();
            tpCPNewspaperArticle.SuspendLayout();
            gbCPNewspaperArticleReqired.SuspendLayout();
            gbCPNewspaperArticleOptional.SuspendLayout();
            tpCPWebsiteArticle.SuspendLayout();
            gbCPWebsiteArticleRequired.SuspendLayout();
            gbCPWebsiteArticleOptional.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label25);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(listBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(tcCategories);
            splitContainer1.Size = new Size(831, 847);
            splitContainer1.SplitterDistance = 298;
            splitContainer1.TabIndex = 0;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(96, 29);
            label25.Name = "label25";
            label25.Size = new Size(96, 25);
            label25.TabIndex = 3;
            label25.Text = "Результат";
            // 
            // button2
            // 
            button2.Location = new Point(75, 762);
            button2.Name = "button2";
            button2.Size = new Size(166, 23);
            button2.TabIndex = 2;
            button2.Text = "Экспорт в Word";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(75, 733);
            button1.Name = "button1";
            button1.Size = new Size(154, 23);
            button1.TabIndex = 1;
            button1.Text = "Скопировать";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveBorder;
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(3, 57);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(290, 633);
            listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(buttonAddRecord);
            panel1.Controls.Add(cbWordAbbreviation);
            panel1.Location = new Point(10, 799);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 42);
            panel1.TabIndex = 2;
            // 
            // buttonAddRecord
            // 
            buttonAddRecord.BackColor = SystemColors.MenuHighlight;
            buttonAddRecord.FlatStyle = FlatStyle.Flat;
            buttonAddRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddRecord.Location = new Point(304, 4);
            buttonAddRecord.Name = "buttonAddRecord";
            buttonAddRecord.Size = new Size(196, 34);
            buttonAddRecord.TabIndex = 1;
            buttonAddRecord.Text = "Добавить";
            buttonAddRecord.UseVisualStyleBackColor = false;
            // 
            // cbWordAbbreviation
            // 
            cbWordAbbreviation.AutoSize = true;
            cbWordAbbreviation.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbWordAbbreviation.Location = new Point(7, 9);
            cbWordAbbreviation.Name = "cbWordAbbreviation";
            cbWordAbbreviation.Size = new Size(291, 24);
            cbWordAbbreviation.TabIndex = 0;
            cbWordAbbreviation.Text = "Включить сокращение слов по ГОСТУ";
            cbWordAbbreviation.UseVisualStyleBackColor = true;
            // 
            // tcCategories
            // 
            tcCategories.Controls.Add(tpSingleVolume);
            tcCategories.Controls.Add(tpMultiVolume);
            tcCategories.Controls.Add(tpElectronicResources);
            tcCategories.Controls.Add(tpConstituentParts);
            tcCategories.Location = new Point(3, 3);
            tcCategories.Name = "tcCategories";
            tcCategories.RightToLeft = RightToLeft.No;
            tcCategories.SelectedIndex = 0;
            tcCategories.Size = new Size(526, 790);
            tcCategories.TabIndex = 1;
            // 
            // tpSingleVolume
            // 
            tpSingleVolume.BackColor = SystemColors.Control;
            tpSingleVolume.Controls.Add(tcSVTypes);
            tpSingleVolume.Location = new Point(4, 24);
            tpSingleVolume.Name = "tpSingleVolume";
            tpSingleVolume.Padding = new Padding(3);
            tpSingleVolume.Size = new Size(518, 762);
            tpSingleVolume.TabIndex = 0;
            tpSingleVolume.Text = "Одночастные (однотомные) ресурсы";
            // 
            // tcSVTypes
            // 
            tcSVTypes.Controls.Add(tpSVBook);
            tcSVTypes.Controls.Add(tpSVRegulatoryDocument);
            tcSVTypes.Controls.Add(tpSVDissertationAbstract);
            tcSVTypes.Controls.Add(tpSVDissertation);
            tcSVTypes.ImeMode = ImeMode.NoControl;
            tcSVTypes.Location = new Point(3, 6);
            tcSVTypes.Name = "tcSVTypes";
            tcSVTypes.SelectedIndex = 0;
            tcSVTypes.Size = new Size(513, 752);
            tcSVTypes.TabIndex = 0;
            // 
            // tpSVBook
            // 
            tpSVBook.BackColor = SystemColors.Control;
            tpSVBook.Controls.Add(gpSVBookRequired);
            tpSVBook.Controls.Add(gpSVBookOptional);
            tpSVBook.Location = new Point(4, 24);
            tpSVBook.Name = "tpSVBook";
            tpSVBook.Padding = new Padding(3);
            tpSVBook.Size = new Size(505, 724);
            tpSVBook.TabIndex = 0;
            tpSVBook.Text = "Книга";
            // 
            // gpSVBookRequired
            // 
            gpSVBookRequired.Controls.Add(labelSVBAuthors);
            gpSVBookRequired.Controls.Add(textBoxAuthors);
            gpSVBookRequired.Controls.Add(buttonAddAuthor);
            gpSVBookRequired.Controls.Add(listBoxAuthors);
            gpSVBookRequired.Controls.Add(labelSVBTitle);
            gpSVBookRequired.Controls.Add(textBoxTitle);
            gpSVBookRequired.Controls.Add(labelSVBPublishingLocation);
            gpSVBookRequired.Controls.Add(textBoxPublishingLocation);
            gpSVBookRequired.Controls.Add(labelSVBPublisher);
            gpSVBookRequired.Controls.Add(textBoxPublisher);
            gpSVBookRequired.Controls.Add(labelSVBPublishYear);
            gpSVBookRequired.Controls.Add(textBoxYear);
            gpSVBookRequired.Controls.Add(labelSVBPagesCount);
            gpSVBookRequired.Controls.Add(textBoxPages);
            gpSVBookRequired.Location = new Point(10, 10);
            gpSVBookRequired.Name = "gpSVBookRequired";
            gpSVBookRequired.Size = new Size(488, 400);
            gpSVBookRequired.TabIndex = 0;
            gpSVBookRequired.TabStop = false;
            gpSVBookRequired.Text = "Обязательные поля";
            // 
            // labelSVBAuthors
            // 
            labelSVBAuthors.AutoSize = true;
            labelSVBAuthors.Location = new Point(10, 20);
            labelSVBAuthors.Name = "labelSVBAuthors";
            labelSVBAuthors.Size = new Size(57, 15);
            labelSVBAuthors.TabIndex = 0;
            labelSVBAuthors.Text = "Автор(ы)";
            // 
            // textBoxAuthors
            // 
            textBoxAuthors.Location = new Point(10, 40);
            textBoxAuthors.Name = "textBoxAuthors";
            textBoxAuthors.Size = new Size(350, 23);
            textBoxAuthors.TabIndex = 1;
            // 
            // buttonAddAuthor
            // 
            buttonAddAuthor.Location = new Point(370, 40);
            buttonAddAuthor.Name = "buttonAddAuthor";
            buttonAddAuthor.Size = new Size(90, 23);
            buttonAddAuthor.TabIndex = 2;
            buttonAddAuthor.Text = "Добавить";
            buttonAddAuthor.UseVisualStyleBackColor = true;
            buttonAddAuthor.Click += buttonAddAuthor_Click;
            // 
            // listBoxAuthors
            // 
            listBoxAuthors.ItemHeight = 15;
            listBoxAuthors.Location = new Point(10, 70);
            listBoxAuthors.Name = "listBoxAuthors";
            listBoxAuthors.Size = new Size(450, 64);
            listBoxAuthors.TabIndex = 3;
            // 
            // labelSVBTitle
            // 
            labelSVBTitle.AutoSize = true;
            labelSVBTitle.Location = new Point(10, 140);
            labelSVBTitle.Name = "labelSVBTitle";
            labelSVBTitle.Size = new Size(57, 15);
            labelSVBTitle.TabIndex = 4;
            labelSVBTitle.Text = "Заглавие";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(10, 160);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(450, 23);
            textBoxTitle.TabIndex = 5;
            // 
            // labelSVBPublishingLocation
            // 
            labelSVBPublishingLocation.AutoSize = true;
            labelSVBPublishingLocation.Location = new Point(10, 190);
            labelSVBPublishingLocation.Name = "labelSVBPublishingLocation";
            labelSVBPublishingLocation.Size = new Size(89, 15);
            labelSVBPublishingLocation.TabIndex = 6;
            labelSVBPublishingLocation.Text = "Место издания";
            // 
            // textBoxPublishingLocation
            // 
            textBoxPublishingLocation.Location = new Point(10, 210);
            textBoxPublishingLocation.Name = "textBoxPublishingLocation";
            textBoxPublishingLocation.Size = new Size(450, 23);
            textBoxPublishingLocation.TabIndex = 7;
            // 
            // labelSVBPublisher
            // 
            labelSVBPublisher.AutoSize = true;
            labelSVBPublisher.Location = new Point(10, 240);
            labelSVBPublisher.Name = "labelSVBPublisher";
            labelSVBPublisher.Size = new Size(81, 15);
            labelSVBPublisher.TabIndex = 8;
            labelSVBPublisher.Text = "Издательство";
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Location = new Point(10, 260);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(450, 23);
            textBoxPublisher.TabIndex = 9;
            // 
            // labelSVBPublishYear
            // 
            labelSVBPublishYear.AutoSize = true;
            labelSVBPublishYear.Location = new Point(10, 290);
            labelSVBPublishYear.Name = "labelSVBPublishYear";
            labelSVBPublishYear.Size = new Size(73, 15);
            labelSVBPublishYear.TabIndex = 10;
            labelSVBPublishYear.Text = "Год издания";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(10, 310);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(450, 23);
            textBoxYear.TabIndex = 11;
            // 
            // labelSVBPagesCount
            // 
            labelSVBPagesCount.AutoSize = true;
            labelSVBPagesCount.Location = new Point(10, 340);
            labelSVBPagesCount.Name = "labelSVBPagesCount";
            labelSVBPagesCount.Size = new Size(120, 15);
            labelSVBPagesCount.TabIndex = 12;
            labelSVBPagesCount.Text = "Количество страниц";
            // 
            // textBoxPages
            // 
            textBoxPages.Location = new Point(10, 360);
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new Size(450, 23);
            textBoxPages.TabIndex = 13;
            // 
            // gpSVBookOptional
            // 
            gpSVBookOptional.Controls.Add(panelSVBookOptional);
            gpSVBookOptional.Location = new Point(10, 416);
            gpSVBookOptional.Name = "gpSVBookOptional";
            gpSVBookOptional.Size = new Size(488, 302);
            gpSVBookOptional.TabIndex = 1;
            gpSVBookOptional.TabStop = false;
            gpSVBookOptional.Text = "Необязательные поля";
            // 
            // panelSVBookOptional
            // 
            panelSVBookOptional.AutoScroll = true;
            panelSVBookOptional.Controls.Add(labelSVBDocumentType);
            panelSVBookOptional.Controls.Add(textBoxOrganization);
            panelSVBookOptional.Controls.Add(textBoxDocumentType);
            panelSVBookOptional.Controls.Add(labelSVBOrganization);
            panelSVBookOptional.Controls.Add(labelSVBEditor);
            panelSVBookOptional.Controls.Add(textBoxTranslator);
            panelSVBookOptional.Controls.Add(textBoxEditor);
            panelSVBookOptional.Controls.Add(labelSVBTranslator);
            panelSVBookOptional.Controls.Add(labelSVBEditionNumber);
            panelSVBookOptional.Controls.Add(textBoxISBN);
            panelSVBookOptional.Controls.Add(textBoxEditionNumber);
            panelSVBookOptional.Controls.Add(labelSVBISBN);
            panelSVBookOptional.Controls.Add(labelSVBSeries);
            panelSVBookOptional.Controls.Add(textBoxSeries);
            panelSVBookOptional.Location = new Point(10, 22);
            panelSVBookOptional.Name = "panelSVBookOptional";
            panelSVBookOptional.Size = new Size(473, 274);
            panelSVBookOptional.TabIndex = 14;
            // 
            // labelSVBDocumentType
            // 
            labelSVBDocumentType.AutoSize = true;
            labelSVBDocumentType.Location = new Point(0, 0);
            labelSVBDocumentType.Name = "labelSVBDocumentType";
            labelSVBDocumentType.Size = new Size(88, 15);
            labelSVBDocumentType.TabIndex = 0;
            labelSVBDocumentType.Text = "Вид документа";
            // 
            // textBoxOrganization
            // 
            textBoxOrganization.Location = new Point(0, 320);
            textBoxOrganization.Name = "textBoxOrganization";
            textBoxOrganization.Size = new Size(450, 23);
            textBoxOrganization.TabIndex = 13;
            // 
            // textBoxDocumentType
            // 
            textBoxDocumentType.Location = new Point(0, 20);
            textBoxDocumentType.Name = "textBoxDocumentType";
            textBoxDocumentType.Size = new Size(450, 23);
            textBoxDocumentType.TabIndex = 1;
            // 
            // labelSVBOrganization
            // 
            labelSVBOrganization.AutoSize = true;
            labelSVBOrganization.Location = new Point(0, 300);
            labelSVBOrganization.Name = "labelSVBOrganization";
            labelSVBOrganization.Size = new Size(79, 15);
            labelSVBOrganization.TabIndex = 12;
            labelSVBOrganization.Text = "Организация";
            // 
            // labelSVBEditor
            // 
            labelSVBEditor.AutoSize = true;
            labelSVBEditor.Location = new Point(0, 50);
            labelSVBEditor.Name = "labelSVBEditor";
            labelSVBEditor.Size = new Size(57, 15);
            labelSVBEditor.TabIndex = 2;
            labelSVBEditor.Text = "Редактор";
            // 
            // textBoxTranslator
            // 
            textBoxTranslator.Location = new Point(0, 270);
            textBoxTranslator.Name = "textBoxTranslator";
            textBoxTranslator.Size = new Size(450, 23);
            textBoxTranslator.TabIndex = 11;
            // 
            // textBoxEditor
            // 
            textBoxEditor.Location = new Point(0, 70);
            textBoxEditor.Name = "textBoxEditor";
            textBoxEditor.Size = new Size(450, 23);
            textBoxEditor.TabIndex = 3;
            // 
            // labelSVBTranslator
            // 
            labelSVBTranslator.AutoSize = true;
            labelSVBTranslator.Location = new Point(0, 250);
            labelSVBTranslator.Name = "labelSVBTranslator";
            labelSVBTranslator.Size = new Size(74, 15);
            labelSVBTranslator.TabIndex = 10;
            labelSVBTranslator.Text = "Переводчик";
            // 
            // labelSVBEditionNumber
            // 
            labelSVBEditionNumber.AutoSize = true;
            labelSVBEditionNumber.Location = new Point(0, 100);
            labelSVBEditionNumber.Name = "labelSVBEditionNumber";
            labelSVBEditionNumber.Size = new Size(92, 15);
            labelSVBEditionNumber.TabIndex = 4;
            labelSVBEditionNumber.Text = "Номер издания";
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(0, 220);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(450, 23);
            textBoxISBN.TabIndex = 9;
            // 
            // textBoxEditionNumber
            // 
            textBoxEditionNumber.Location = new Point(0, 120);
            textBoxEditionNumber.Name = "textBoxEditionNumber";
            textBoxEditionNumber.Size = new Size(450, 23);
            textBoxEditionNumber.TabIndex = 5;
            // 
            // labelSVBISBN
            // 
            labelSVBISBN.AutoSize = true;
            labelSVBISBN.Location = new Point(0, 200);
            labelSVBISBN.Name = "labelSVBISBN";
            labelSVBISBN.Size = new Size(32, 15);
            labelSVBISBN.TabIndex = 8;
            labelSVBISBN.Text = "ISBN";
            // 
            // labelSVBSeries
            // 
            labelSVBSeries.AutoSize = true;
            labelSVBSeries.Location = new Point(0, 150);
            labelSVBSeries.Name = "labelSVBSeries";
            labelSVBSeries.Size = new Size(41, 15);
            labelSVBSeries.TabIndex = 6;
            labelSVBSeries.Text = "Серия";
            // 
            // textBoxSeries
            // 
            textBoxSeries.Location = new Point(0, 170);
            textBoxSeries.Name = "textBoxSeries";
            textBoxSeries.Size = new Size(450, 23);
            textBoxSeries.TabIndex = 7;
            // 
            // tpSVRegulatoryDocument
            // 
            tpSVRegulatoryDocument.BackColor = SystemColors.Control;
            tpSVRegulatoryDocument.Controls.Add(gbSVRegulatoryDocumentRequired);
            tpSVRegulatoryDocument.Controls.Add(gbSVRegulatoryDocumentOptional);
            tpSVRegulatoryDocument.Location = new Point(4, 24);
            tpSVRegulatoryDocument.Name = "tpSVRegulatoryDocument";
            tpSVRegulatoryDocument.Padding = new Padding(3);
            tpSVRegulatoryDocument.Size = new Size(505, 724);
            tpSVRegulatoryDocument.TabIndex = 1;
            tpSVRegulatoryDocument.Text = "Нормативный документ";
            // 
            // gbSVRegulatoryDocumentRequired
            // 
            gbSVRegulatoryDocumentRequired.Controls.Add(labelSVRDDocumentNumber);
            gbSVRegulatoryDocumentRequired.Controls.Add(textBox1);
            gbSVRegulatoryDocumentRequired.Controls.Add(labelSVRDTitle);
            gbSVRegulatoryDocumentRequired.Controls.Add(textBox2);
            gbSVRegulatoryDocumentRequired.Controls.Add(labelSVRDPublishingLocation);
            gbSVRegulatoryDocumentRequired.Controls.Add(textBox3);
            gbSVRegulatoryDocumentRequired.Controls.Add(labelSVRDPublisher);
            gbSVRegulatoryDocumentRequired.Controls.Add(textBox4);
            gbSVRegulatoryDocumentRequired.Controls.Add(labelSVRDPublishYear);
            gbSVRegulatoryDocumentRequired.Controls.Add(textBox5);
            gbSVRegulatoryDocumentRequired.Location = new Point(10, 10);
            gbSVRegulatoryDocumentRequired.Name = "gbSVRegulatoryDocumentRequired";
            gbSVRegulatoryDocumentRequired.Size = new Size(488, 263);
            gbSVRegulatoryDocumentRequired.TabIndex = 2;
            gbSVRegulatoryDocumentRequired.TabStop = false;
            gbSVRegulatoryDocumentRequired.Text = "Обязательные поля";
            // 
            // labelSVRDDocumentNumber
            // 
            labelSVRDDocumentNumber.AutoSize = true;
            labelSVRDDocumentNumber.Location = new Point(10, 67);
            labelSVRDDocumentNumber.Name = "labelSVRDDocumentNumber";
            labelSVRDDocumentNumber.Size = new Size(106, 15);
            labelSVRDDocumentNumber.TabIndex = 14;
            labelSVRDDocumentNumber.Text = "Номер документа";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 23);
            textBox1.TabIndex = 15;
            // 
            // labelSVRDTitle
            // 
            labelSVRDTitle.AutoSize = true;
            labelSVRDTitle.Location = new Point(10, 20);
            labelSVRDTitle.Name = "labelSVRDTitle";
            labelSVRDTitle.Size = new Size(57, 15);
            labelSVRDTitle.TabIndex = 4;
            labelSVRDTitle.Text = "Заглавие";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(450, 23);
            textBox2.TabIndex = 5;
            // 
            // labelSVRDPublishingLocation
            // 
            labelSVRDPublishingLocation.AutoSize = true;
            labelSVRDPublishingLocation.Location = new Point(10, 115);
            labelSVRDPublishingLocation.Name = "labelSVRDPublishingLocation";
            labelSVRDPublishingLocation.Size = new Size(89, 15);
            labelSVRDPublishingLocation.TabIndex = 6;
            labelSVRDPublishingLocation.Text = "Место издания";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(10, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(450, 23);
            textBox3.TabIndex = 7;
            // 
            // labelSVRDPublisher
            // 
            labelSVRDPublisher.AutoSize = true;
            labelSVRDPublisher.Location = new Point(10, 161);
            labelSVRDPublisher.Name = "labelSVRDPublisher";
            labelSVRDPublisher.Size = new Size(230, 15);
            labelSVRDPublisher.TabIndex = 8;
            labelSVRDPublisher.Text = "Издательство или источник публикации";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(10, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(450, 23);
            textBox4.TabIndex = 9;
            // 
            // labelSVRDPublishYear
            // 
            labelSVRDPublishYear.AutoSize = true;
            labelSVRDPublishYear.Location = new Point(10, 207);
            labelSVRDPublishYear.Name = "labelSVRDPublishYear";
            labelSVRDPublishYear.Size = new Size(73, 15);
            labelSVRDPublishYear.TabIndex = 10;
            labelSVRDPublishYear.Text = "Год издания";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(10, 227);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(450, 23);
            textBox5.TabIndex = 11;
            // 
            // gbSVRegulatoryDocumentOptional
            // 
            gbSVRegulatoryDocumentOptional.Controls.Add(panelSVRegulatoryDocumentOptional);
            gbSVRegulatoryDocumentOptional.Location = new Point(10, 279);
            gbSVRegulatoryDocumentOptional.Name = "gbSVRegulatoryDocumentOptional";
            gbSVRegulatoryDocumentOptional.Size = new Size(488, 439);
            gbSVRegulatoryDocumentOptional.TabIndex = 3;
            gbSVRegulatoryDocumentOptional.TabStop = false;
            gbSVRegulatoryDocumentOptional.Text = "Необязательные поля";
            // 
            // panelSVRegulatoryDocumentOptional
            // 
            panelSVRegulatoryDocumentOptional.AutoScroll = true;
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDCountry);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDDocumentType);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox16);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox13);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDAdditions);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDOfficialEdition);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox15);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox12);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDAbbreviation);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDTitleTranslation);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox14);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox11);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDPagesCount);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDISBN);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox6);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox10);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDDeveloper);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox7);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox9);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDApprovalDate);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDImplementDate);
            panelSVRegulatoryDocumentOptional.Controls.Add(textBox8);
            panelSVRegulatoryDocumentOptional.Location = new Point(10, 22);
            panelSVRegulatoryDocumentOptional.Name = "panelSVRegulatoryDocumentOptional";
            panelSVRegulatoryDocumentOptional.Size = new Size(473, 411);
            panelSVRegulatoryDocumentOptional.TabIndex = 22;
            // 
            // labelSVRDCountry
            // 
            labelSVRDCountry.AutoSize = true;
            labelSVRDCountry.Location = new Point(0, 473);
            labelSVRDCountry.Name = "labelSVRDCountry";
            labelSVRDCountry.Size = new Size(46, 15);
            labelSVRDCountry.TabIndex = 20;
            labelSVRDCountry.Text = "Страна";
            // 
            // labelSVRDDocumentType
            // 
            labelSVRDDocumentType.AutoSize = true;
            labelSVRDDocumentType.Location = new Point(0, 0);
            labelSVRDDocumentType.Name = "labelSVRDDocumentType";
            labelSVRDDocumentType.Size = new Size(88, 15);
            labelSVRDDocumentType.TabIndex = 0;
            labelSVRDDocumentType.Text = "Вид документа";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(0, 491);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(450, 23);
            textBox16.TabIndex = 21;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(0, 360);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(450, 23);
            textBox13.TabIndex = 13;
            // 
            // labelSVRDAdditions
            // 
            labelSVRDAdditions.AutoSize = true;
            labelSVRDAdditions.Location = new Point(0, 429);
            labelSVRDAdditions.Name = "labelSVRDAdditions";
            labelSVRDAdditions.Size = new Size(149, 15);
            labelSVRDAdditions.TabIndex = 18;
            labelSVRDAdditions.Text = "Дополнения и изменения";
            // 
            // labelSVRDOfficialEdition
            // 
            labelSVRDOfficialEdition.AutoSize = true;
            labelSVRDOfficialEdition.Location = new Point(0, 342);
            labelSVRDOfficialEdition.Name = "labelSVRDOfficialEdition";
            labelSVRDOfficialEdition.Size = new Size(132, 15);
            labelSVRDOfficialEdition.TabIndex = 12;
            labelSVRDOfficialEdition.Text = "Издание официальное";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(0, 447);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(450, 23);
            textBox15.TabIndex = 19;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(0, 312);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(450, 23);
            textBox12.TabIndex = 11;
            // 
            // labelSVRDAbbreviation
            // 
            labelSVRDAbbreviation.AutoSize = true;
            labelSVRDAbbreviation.Location = new Point(0, 386);
            labelSVRDAbbreviation.Name = "labelSVRDAbbreviation";
            labelSVRDAbbreviation.Size = new Size(78, 15);
            labelSVRDAbbreviation.TabIndex = 16;
            labelSVRDAbbreviation.Text = "Сокращение";
            // 
            // labelSVRDTitleTranslation
            // 
            labelSVRDTitleTranslation.AutoSize = true;
            labelSVRDTitleTranslation.Location = new Point(0, 292);
            labelSVRDTitleTranslation.Name = "labelSVRDTitleTranslation";
            labelSVRDTitleTranslation.Size = new Size(189, 15);
            labelSVRDTitleTranslation.TabIndex = 10;
            labelSVRDTitleTranslation.Text = "Перевод заглавия на английский";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(0, 404);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(450, 23);
            textBox14.TabIndex = 17;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(0, 262);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(450, 23);
            textBox11.TabIndex = 9;
            // 
            // labelSVRDPagesCount
            // 
            labelSVRDPagesCount.AutoSize = true;
            labelSVRDPagesCount.Location = new Point(0, 196);
            labelSVRDPagesCount.Name = "labelSVRDPagesCount";
            labelSVRDPagesCount.Size = new Size(120, 15);
            labelSVRDPagesCount.TabIndex = 14;
            labelSVRDPagesCount.Text = "Количество страниц";
            // 
            // labelSVRDISBN
            // 
            labelSVRDISBN.AutoSize = true;
            labelSVRDISBN.Location = new Point(0, 242);
            labelSVRDISBN.Name = "labelSVRDISBN";
            labelSVRDISBN.Size = new Size(32, 15);
            labelSVRDISBN.TabIndex = 8;
            labelSVRDISBN.Text = "ISBN";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(0, 216);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(450, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(0, 170);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(450, 23);
            textBox10.TabIndex = 7;
            // 
            // labelSVRDDeveloper
            // 
            labelSVRDDeveloper.AutoSize = true;
            labelSVRDDeveloper.Location = new Point(0, 150);
            labelSVRDDeveloper.Name = "labelSVRDDeveloper";
            labelSVRDDeveloper.Size = new Size(77, 15);
            labelSVRDDeveloper.TabIndex = 6;
            labelSVRDDeveloper.Text = "Разработчик";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(0, 20);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(450, 23);
            textBox7.TabIndex = 1;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(0, 120);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(450, 23);
            textBox9.TabIndex = 5;
            // 
            // labelSVRDApprovalDate
            // 
            labelSVRDApprovalDate.AutoSize = true;
            labelSVRDApprovalDate.Location = new Point(0, 50);
            labelSVRDApprovalDate.Name = "labelSVRDApprovalDate";
            labelSVRDApprovalDate.Size = new Size(163, 15);
            labelSVRDApprovalDate.TabIndex = 2;
            labelSVRDApprovalDate.Text = "Дата утверждения/принятия";
            // 
            // labelSVRDImplementDate
            // 
            labelSVRDImplementDate.AutoSize = true;
            labelSVRDImplementDate.Location = new Point(0, 100);
            labelSVRDImplementDate.Name = "labelSVRDImplementDate";
            labelSVRDImplementDate.Size = new Size(150, 15);
            labelSVRDImplementDate.TabIndex = 4;
            labelSVRDImplementDate.Text = "Дата введения/одобрения";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(0, 70);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(450, 23);
            textBox8.TabIndex = 3;
            // 
            // tpSVDissertationAbstract
            // 
            tpSVDissertationAbstract.BackColor = SystemColors.Control;
            tpSVDissertationAbstract.Controls.Add(gbSVDissertationAbstractRequired);
            tpSVDissertationAbstract.Controls.Add(gbSVDissertationAbstractOptional);
            tpSVDissertationAbstract.Location = new Point(4, 24);
            tpSVDissertationAbstract.Name = "tpSVDissertationAbstract";
            tpSVDissertationAbstract.Padding = new Padding(3);
            tpSVDissertationAbstract.Size = new Size(505, 724);
            tpSVDissertationAbstract.TabIndex = 2;
            tpSVDissertationAbstract.Text = "Автореферат диссертации";
            // 
            // gbSVDissertationAbstractRequired
            // 
            gbSVDissertationAbstractRequired.Controls.Add(label24);
            gbSVDissertationAbstractRequired.Controls.Add(textBox24);
            gbSVDissertationAbstractRequired.Controls.Add(label23);
            gbSVDissertationAbstractRequired.Controls.Add(textBox23);
            gbSVDissertationAbstractRequired.Controls.Add(label22);
            gbSVDissertationAbstractRequired.Controls.Add(textBox22);
            gbSVDissertationAbstractRequired.Controls.Add(label17);
            gbSVDissertationAbstractRequired.Controls.Add(textBox17);
            gbSVDissertationAbstractRequired.Controls.Add(label18);
            gbSVDissertationAbstractRequired.Controls.Add(textBox18);
            gbSVDissertationAbstractRequired.Controls.Add(label19);
            gbSVDissertationAbstractRequired.Controls.Add(textBox19);
            gbSVDissertationAbstractRequired.Controls.Add(label20);
            gbSVDissertationAbstractRequired.Controls.Add(textBox20);
            gbSVDissertationAbstractRequired.Controls.Add(label21);
            gbSVDissertationAbstractRequired.Controls.Add(textBox21);
            gbSVDissertationAbstractRequired.Location = new Point(10, 10);
            gbSVDissertationAbstractRequired.Name = "gbSVDissertationAbstractRequired";
            gbSVDissertationAbstractRequired.Size = new Size(488, 398);
            gbSVDissertationAbstractRequired.TabIndex = 4;
            gbSVDissertationAbstractRequired.TabStop = false;
            gbSVDissertationAbstractRequired.Text = "Обязательные поля";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(10, 346);
            label24.Name = "label24";
            label24.Size = new Size(88, 15);
            label24.TabIndex = 20;
            label24.Text = "Место защиты";
            // 
            // textBox24
            // 
            textBox24.Location = new Point(10, 366);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(450, 23);
            textBox24.TabIndex = 21;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(10, 301);
            label23.Name = "label23";
            label23.Size = new Size(120, 15);
            label23.TabIndex = 18;
            label23.Text = "Количество страниц";
            // 
            // textBox23
            // 
            textBox23.Location = new Point(10, 321);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(450, 23);
            textBox23.TabIndex = 19;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(10, 254);
            label22.Name = "label22";
            label22.Size = new Size(73, 15);
            label22.TabIndex = 16;
            label22.Text = "Год издания";
            // 
            // textBox22
            // 
            textBox22.Location = new Point(10, 274);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(450, 23);
            textBox22.TabIndex = 17;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 67);
            label17.Name = "label17";
            label17.Size = new Size(57, 15);
            label17.TabIndex = 14;
            label17.Text = "Заглавие";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(10, 87);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(450, 23);
            textBox17.TabIndex = 15;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(10, 20);
            label18.Name = "label18";
            label18.Size = new Size(40, 15);
            label18.TabIndex = 4;
            label18.Text = "Автор";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(10, 40);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(450, 23);
            textBox18.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(10, 115);
            label19.Name = "label19";
            label19.Size = new Size(185, 15);
            label19.TabIndex = 6;
            label19.Text = "Специальность (код и название)";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(10, 135);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(450, 23);
            textBox19.TabIndex = 7;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(10, 161);
            label20.Name = "label20";
            label20.Size = new Size(52, 15);
            label20.TabIndex = 8;
            label20.Text = "Степень";
            // 
            // textBox20
            // 
            textBox20.Location = new Point(10, 181);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(450, 23);
            textBox20.TabIndex = 9;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(10, 207);
            label21.Name = "label21";
            label21.Size = new Size(89, 15);
            label21.TabIndex = 10;
            label21.Text = "Место издания";
            // 
            // textBox21
            // 
            textBox21.Location = new Point(10, 227);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(450, 23);
            textBox21.TabIndex = 11;
            // 
            // gbSVDissertationAbstractOptional
            // 
            gbSVDissertationAbstractOptional.Controls.Add(label26);
            gbSVDissertationAbstractOptional.Controls.Add(textBox26);
            gbSVDissertationAbstractOptional.Controls.Add(label27);
            gbSVDissertationAbstractOptional.Controls.Add(textBox27);
            gbSVDissertationAbstractOptional.Controls.Add(label28);
            gbSVDissertationAbstractOptional.Controls.Add(textBox28);
            gbSVDissertationAbstractOptional.Controls.Add(label29);
            gbSVDissertationAbstractOptional.Controls.Add(textBox29);
            gbSVDissertationAbstractOptional.Location = new Point(10, 414);
            gbSVDissertationAbstractOptional.Name = "gbSVDissertationAbstractOptional";
            gbSVDissertationAbstractOptional.Size = new Size(488, 304);
            gbSVDissertationAbstractOptional.TabIndex = 5;
            gbSVDissertationAbstractOptional.TabStop = false;
            gbSVDissertationAbstractOptional.Text = "Необязательные поля";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(10, 28);
            label26.Name = "label26";
            label26.Size = new Size(88, 15);
            label26.TabIndex = 0;
            label26.Text = "Вид документа";
            // 
            // textBox26
            // 
            textBox26.Location = new Point(10, 48);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(450, 23);
            textBox26.TabIndex = 1;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(10, 78);
            label27.Name = "label27";
            label27.Size = new Size(115, 15);
            label27.TabIndex = 2;
            label27.Text = "Полное имя автора";
            // 
            // textBox27
            // 
            textBox27.Location = new Point(10, 98);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(450, 23);
            textBox27.TabIndex = 3;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(10, 128);
            label28.Name = "label28";
            label28.Size = new Size(79, 15);
            label28.TabIndex = 4;
            label28.Text = "Организация";
            // 
            // textBox28
            // 
            textBox28.Location = new Point(10, 148);
            textBox28.Name = "textBox28";
            textBox28.Size = new Size(450, 23);
            textBox28.TabIndex = 5;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(10, 178);
            label29.Name = "label29";
            label29.Size = new Size(199, 15);
            label29.TabIndex = 6;
            label29.Text = "Библиография (диапазон страниц)";
            // 
            // textBox29
            // 
            textBox29.Location = new Point(10, 198);
            textBox29.Name = "textBox29";
            textBox29.Size = new Size(450, 23);
            textBox29.TabIndex = 7;
            // 
            // tpSVDissertation
            // 
            tpSVDissertation.BackColor = SystemColors.Control;
            tpSVDissertation.Controls.Add(gbSVDissertationRequired);
            tpSVDissertation.Controls.Add(gbSVDissertationOptional);
            tpSVDissertation.Location = new Point(4, 24);
            tpSVDissertation.Name = "tpSVDissertation";
            tpSVDissertation.Padding = new Padding(3);
            tpSVDissertation.Size = new Size(505, 724);
            tpSVDissertation.TabIndex = 3;
            tpSVDissertation.Text = "Диссертация";
            // 
            // gbSVDissertationRequired
            // 
            gbSVDissertationRequired.Controls.Add(label30);
            gbSVDissertationRequired.Controls.Add(textBox30);
            gbSVDissertationRequired.Controls.Add(label31);
            gbSVDissertationRequired.Controls.Add(textBox31);
            gbSVDissertationRequired.Controls.Add(label32);
            gbSVDissertationRequired.Controls.Add(textBox32);
            gbSVDissertationRequired.Controls.Add(label33);
            gbSVDissertationRequired.Controls.Add(textBox33);
            gbSVDissertationRequired.Controls.Add(label34);
            gbSVDissertationRequired.Controls.Add(textBox34);
            gbSVDissertationRequired.Controls.Add(label35);
            gbSVDissertationRequired.Controls.Add(textBox35);
            gbSVDissertationRequired.Controls.Add(label36);
            gbSVDissertationRequired.Controls.Add(textBox36);
            gbSVDissertationRequired.Location = new Point(10, 10);
            gbSVDissertationRequired.Name = "gbSVDissertationRequired";
            gbSVDissertationRequired.Size = new Size(488, 355);
            gbSVDissertationRequired.TabIndex = 6;
            gbSVDissertationRequired.TabStop = false;
            gbSVDissertationRequired.Text = "Обязательные поля";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(10, 301);
            label30.Name = "label30";
            label30.Size = new Size(120, 15);
            label30.TabIndex = 18;
            label30.Text = "Количество страниц";
            // 
            // textBox30
            // 
            textBox30.Location = new Point(10, 321);
            textBox30.Name = "textBox30";
            textBox30.Size = new Size(450, 23);
            textBox30.TabIndex = 19;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(10, 254);
            label31.Name = "label31";
            label31.Size = new Size(73, 15);
            label31.TabIndex = 16;
            label31.Text = "Год издания";
            // 
            // textBox31
            // 
            textBox31.Location = new Point(10, 274);
            textBox31.Name = "textBox31";
            textBox31.Size = new Size(450, 23);
            textBox31.TabIndex = 17;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(10, 67);
            label32.Name = "label32";
            label32.Size = new Size(57, 15);
            label32.TabIndex = 14;
            label32.Text = "Заглавие";
            // 
            // textBox32
            // 
            textBox32.Location = new Point(10, 87);
            textBox32.Name = "textBox32";
            textBox32.Size = new Size(450, 23);
            textBox32.TabIndex = 15;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(10, 20);
            label33.Name = "label33";
            label33.Size = new Size(40, 15);
            label33.TabIndex = 4;
            label33.Text = "Автор";
            // 
            // textBox33
            // 
            textBox33.Location = new Point(10, 40);
            textBox33.Name = "textBox33";
            textBox33.Size = new Size(450, 23);
            textBox33.TabIndex = 5;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(10, 115);
            label34.Name = "label34";
            label34.Size = new Size(185, 15);
            label34.TabIndex = 6;
            label34.Text = "Специальность (код и название)";
            // 
            // textBox34
            // 
            textBox34.Location = new Point(10, 135);
            textBox34.Name = "textBox34";
            textBox34.Size = new Size(450, 23);
            textBox34.TabIndex = 7;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(10, 161);
            label35.Name = "label35";
            label35.Size = new Size(52, 15);
            label35.TabIndex = 8;
            label35.Text = "Степень";
            // 
            // textBox35
            // 
            textBox35.Location = new Point(10, 181);
            textBox35.Name = "textBox35";
            textBox35.Size = new Size(450, 23);
            textBox35.TabIndex = 9;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(10, 207);
            label36.Name = "label36";
            label36.Size = new Size(89, 15);
            label36.TabIndex = 10;
            label36.Text = "Место издания";
            // 
            // textBox36
            // 
            textBox36.Location = new Point(10, 227);
            textBox36.Name = "textBox36";
            textBox36.Size = new Size(450, 23);
            textBox36.TabIndex = 11;
            // 
            // gbSVDissertationOptional
            // 
            gbSVDissertationOptional.Controls.Add(label37);
            gbSVDissertationOptional.Controls.Add(textBox37);
            gbSVDissertationOptional.Controls.Add(label38);
            gbSVDissertationOptional.Controls.Add(textBox38);
            gbSVDissertationOptional.Controls.Add(label39);
            gbSVDissertationOptional.Controls.Add(textBox39);
            gbSVDissertationOptional.Controls.Add(label40);
            gbSVDissertationOptional.Controls.Add(textBox40);
            gbSVDissertationOptional.Location = new Point(10, 371);
            gbSVDissertationOptional.Name = "gbSVDissertationOptional";
            gbSVDissertationOptional.Size = new Size(488, 347);
            gbSVDissertationOptional.TabIndex = 7;
            gbSVDissertationOptional.TabStop = false;
            gbSVDissertationOptional.Text = "Необязательные поля";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(10, 28);
            label37.Name = "label37";
            label37.Size = new Size(88, 15);
            label37.TabIndex = 0;
            label37.Text = "Вид документа";
            // 
            // textBox37
            // 
            textBox37.Location = new Point(10, 48);
            textBox37.Name = "textBox37";
            textBox37.Size = new Size(450, 23);
            textBox37.TabIndex = 1;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(10, 78);
            label38.Name = "label38";
            label38.Size = new Size(115, 15);
            label38.TabIndex = 2;
            label38.Text = "Полное имя автора";
            // 
            // textBox38
            // 
            textBox38.Location = new Point(10, 98);
            textBox38.Name = "textBox38";
            textBox38.Size = new Size(450, 23);
            textBox38.TabIndex = 3;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(10, 128);
            label39.Name = "label39";
            label39.Size = new Size(79, 15);
            label39.TabIndex = 4;
            label39.Text = "Организация";
            // 
            // textBox39
            // 
            textBox39.Location = new Point(10, 148);
            textBox39.Name = "textBox39";
            textBox39.Size = new Size(450, 23);
            textBox39.TabIndex = 5;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(10, 178);
            label40.Name = "label40";
            label40.Size = new Size(199, 15);
            label40.TabIndex = 6;
            label40.Text = "Библиография (диапазон страниц)";
            // 
            // textBox40
            // 
            textBox40.Location = new Point(10, 198);
            textBox40.Name = "textBox40";
            textBox40.Size = new Size(450, 23);
            textBox40.TabIndex = 7;
            // 
            // tpMultiVolume
            // 
            tpMultiVolume.BackColor = SystemColors.Control;
            tpMultiVolume.Controls.Add(tcMVTypes);
            tpMultiVolume.Location = new Point(4, 24);
            tpMultiVolume.Name = "tpMultiVolume";
            tpMultiVolume.Padding = new Padding(3);
            tpMultiVolume.Size = new Size(518, 762);
            tpMultiVolume.TabIndex = 1;
            tpMultiVolume.Text = "Многочастные (многотомные) ресурсы";
            // 
            // tcMVTypes
            // 
            tcMVTypes.Controls.Add(tpMVWholeMultivolume);
            tcMVTypes.Controls.Add(tpMVSeparateVolume);
            tcMVTypes.ImeMode = ImeMode.NoControl;
            tcMVTypes.Location = new Point(3, 6);
            tcMVTypes.Name = "tcMVTypes";
            tcMVTypes.SelectedIndex = 0;
            tcMVTypes.Size = new Size(513, 752);
            tcMVTypes.TabIndex = 1;
            // 
            // tpMVWholeMultivolume
            // 
            tpMVWholeMultivolume.BackColor = SystemColors.Control;
            tpMVWholeMultivolume.Controls.Add(gbMVWholeMultivolumeRequired);
            tpMVWholeMultivolume.Controls.Add(gbMVWholeMultivolumeOptional);
            tpMVWholeMultivolume.Location = new Point(4, 24);
            tpMVWholeMultivolume.Name = "tpMVWholeMultivolume";
            tpMVWholeMultivolume.Padding = new Padding(3);
            tpMVWholeMultivolume.Size = new Size(505, 724);
            tpMVWholeMultivolume.TabIndex = 0;
            tpMVWholeMultivolume.Text = "Многотомное издание в целом";
            // 
            // gbMVWholeMultivolumeRequired
            // 
            gbMVWholeMultivolumeRequired.Controls.Add(label53);
            gbMVWholeMultivolumeRequired.Controls.Add(textBox52);
            gbMVWholeMultivolumeRequired.Controls.Add(label41);
            gbMVWholeMultivolumeRequired.Controls.Add(textBox25);
            gbMVWholeMultivolumeRequired.Controls.Add(button4);
            gbMVWholeMultivolumeRequired.Controls.Add(listBox2);
            gbMVWholeMultivolumeRequired.Controls.Add(label42);
            gbMVWholeMultivolumeRequired.Controls.Add(textBox41);
            gbMVWholeMultivolumeRequired.Controls.Add(label43);
            gbMVWholeMultivolumeRequired.Controls.Add(textBox42);
            gbMVWholeMultivolumeRequired.Controls.Add(label44);
            gbMVWholeMultivolumeRequired.Controls.Add(textBox43);
            gbMVWholeMultivolumeRequired.Controls.Add(label45);
            gbMVWholeMultivolumeRequired.Controls.Add(textBox44);
            gbMVWholeMultivolumeRequired.Controls.Add(label46);
            gbMVWholeMultivolumeRequired.Controls.Add(textBox45);
            gbMVWholeMultivolumeRequired.Location = new Point(10, 10);
            gbMVWholeMultivolumeRequired.Name = "gbMVWholeMultivolumeRequired";
            gbMVWholeMultivolumeRequired.Size = new Size(488, 441);
            gbMVWholeMultivolumeRequired.TabIndex = 0;
            gbMVWholeMultivolumeRequired.TabStop = false;
            gbMVWholeMultivolumeRequired.Text = "Обязательные поля";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Location = new Point(10, 386);
            label53.Name = "label53";
            label53.Size = new Size(120, 15);
            label53.TabIndex = 14;
            label53.Text = "Количество страниц";
            // 
            // textBox52
            // 
            textBox52.Location = new Point(10, 406);
            textBox52.Name = "textBox52";
            textBox52.Size = new Size(450, 23);
            textBox52.TabIndex = 15;
            textBox52.TextChanged += textBox52_TextChanged;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(10, 20);
            label41.Name = "label41";
            label41.Size = new Size(57, 15);
            label41.TabIndex = 0;
            label41.Text = "Автор(ы)";
            // 
            // textBox25
            // 
            textBox25.Location = new Point(10, 40);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(350, 23);
            textBox25.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(370, 40);
            button4.Name = "button4";
            button4.Size = new Size(90, 23);
            button4.TabIndex = 2;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(10, 70);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(450, 64);
            listBox2.TabIndex = 3;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(10, 140);
            label42.Name = "label42";
            label42.Size = new Size(57, 15);
            label42.TabIndex = 4;
            label42.Text = "Заглавие";
            // 
            // textBox41
            // 
            textBox41.Location = new Point(10, 160);
            textBox41.Name = "textBox41";
            textBox41.Size = new Size(450, 23);
            textBox41.TabIndex = 5;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(10, 190);
            label43.Name = "label43";
            label43.Size = new Size(109, 15);
            label43.TabIndex = 6;
            label43.Text = "Количество томов";
            // 
            // textBox42
            // 
            textBox42.Location = new Point(10, 210);
            textBox42.Name = "textBox42";
            textBox42.Size = new Size(450, 23);
            textBox42.TabIndex = 7;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(10, 240);
            label44.Name = "label44";
            label44.Size = new Size(89, 15);
            label44.TabIndex = 8;
            label44.Text = "Место издания";
            // 
            // textBox43
            // 
            textBox43.Location = new Point(10, 260);
            textBox43.Name = "textBox43";
            textBox43.Size = new Size(450, 23);
            textBox43.TabIndex = 9;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(10, 290);
            label45.Name = "label45";
            label45.Size = new Size(81, 15);
            label45.TabIndex = 10;
            label45.Text = "Издательство";
            // 
            // textBox44
            // 
            textBox44.Location = new Point(10, 310);
            textBox44.Name = "textBox44";
            textBox44.Size = new Size(450, 23);
            textBox44.TabIndex = 11;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(10, 340);
            label46.Name = "label46";
            label46.Size = new Size(73, 15);
            label46.TabIndex = 12;
            label46.Text = "Год издания";
            // 
            // textBox45
            // 
            textBox45.Location = new Point(10, 360);
            textBox45.Name = "textBox45";
            textBox45.Size = new Size(450, 23);
            textBox45.TabIndex = 13;
            // 
            // gbMVWholeMultivolumeOptional
            // 
            gbMVWholeMultivolumeOptional.Controls.Add(panelMVWholeMultivolumeOptional);
            gbMVWholeMultivolumeOptional.Location = new Point(10, 457);
            gbMVWholeMultivolumeOptional.Name = "gbMVWholeMultivolumeOptional";
            gbMVWholeMultivolumeOptional.Size = new Size(488, 261);
            gbMVWholeMultivolumeOptional.TabIndex = 1;
            gbMVWholeMultivolumeOptional.TabStop = false;
            gbMVWholeMultivolumeOptional.Text = "Необязательные поля";
            // 
            // panelMVWholeMultivolumeOptional
            // 
            panelMVWholeMultivolumeOptional.AutoScroll = true;
            panelMVWholeMultivolumeOptional.Controls.Add(label47);
            panelMVWholeMultivolumeOptional.Controls.Add(label48);
            panelMVWholeMultivolumeOptional.Controls.Add(textBox46);
            panelMVWholeMultivolumeOptional.Controls.Add(textBox51);
            panelMVWholeMultivolumeOptional.Controls.Add(label52);
            panelMVWholeMultivolumeOptional.Controls.Add(textBox47);
            panelMVWholeMultivolumeOptional.Controls.Add(textBox50);
            panelMVWholeMultivolumeOptional.Controls.Add(label49);
            panelMVWholeMultivolumeOptional.Controls.Add(label51);
            panelMVWholeMultivolumeOptional.Controls.Add(textBox48);
            panelMVWholeMultivolumeOptional.Controls.Add(textBox49);
            panelMVWholeMultivolumeOptional.Controls.Add(label50);
            panelMVWholeMultivolumeOptional.Location = new Point(10, 22);
            panelMVWholeMultivolumeOptional.Name = "panelMVWholeMultivolumeOptional";
            panelMVWholeMultivolumeOptional.Size = new Size(473, 233);
            panelMVWholeMultivolumeOptional.TabIndex = 16;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(0, 2);
            label47.Name = "label47";
            label47.Size = new Size(88, 15);
            label47.TabIndex = 0;
            label47.Text = "Вид документа";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(0, 52);
            label48.Name = "label48";
            label48.Size = new Size(147, 15);
            label48.TabIndex = 2;
            label48.Text = "Область ответственности";
            // 
            // textBox46
            // 
            textBox46.Location = new Point(0, 22);
            textBox46.Name = "textBox46";
            textBox46.Size = new Size(450, 23);
            textBox46.TabIndex = 1;
            // 
            // textBox51
            // 
            textBox51.Location = new Point(0, 272);
            textBox51.Name = "textBox51";
            textBox51.Size = new Size(450, 23);
            textBox51.TabIndex = 11;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Location = new Point(0, 252);
            label52.Name = "label52";
            label52.Size = new Size(32, 15);
            label52.TabIndex = 10;
            label52.Text = "ISBN";
            // 
            // textBox47
            // 
            textBox47.Location = new Point(0, 72);
            textBox47.Name = "textBox47";
            textBox47.Size = new Size(450, 23);
            textBox47.TabIndex = 3;
            // 
            // textBox50
            // 
            textBox50.Location = new Point(0, 222);
            textBox50.Name = "textBox50";
            textBox50.Size = new Size(450, 23);
            textBox50.TabIndex = 9;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(0, 102);
            label49.Name = "label49";
            label49.Size = new Size(57, 15);
            label49.TabIndex = 4;
            label49.Text = "Редактор";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new Point(0, 202);
            label51.Name = "label51";
            label51.Size = new Size(41, 15);
            label51.TabIndex = 8;
            label51.Text = "Серия";
            // 
            // textBox48
            // 
            textBox48.Location = new Point(0, 122);
            textBox48.Name = "textBox48";
            textBox48.Size = new Size(450, 23);
            textBox48.TabIndex = 5;
            // 
            // textBox49
            // 
            textBox49.Location = new Point(0, 172);
            textBox49.Name = "textBox49";
            textBox49.Size = new Size(450, 23);
            textBox49.TabIndex = 7;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(0, 152);
            label50.Name = "label50";
            label50.Size = new Size(92, 15);
            label50.TabIndex = 6;
            label50.Text = "Номер издания";
            // 
            // tpMVSeparateVolume
            // 
            tpMVSeparateVolume.BackColor = SystemColors.Control;
            tpMVSeparateVolume.Controls.Add(gbMVSeparateVolumeRequired);
            tpMVSeparateVolume.Controls.Add(gbMVSeparateVolumeOptional);
            tpMVSeparateVolume.Location = new Point(4, 24);
            tpMVSeparateVolume.Name = "tpMVSeparateVolume";
            tpMVSeparateVolume.Padding = new Padding(3);
            tpMVSeparateVolume.Size = new Size(505, 724);
            tpMVSeparateVolume.TabIndex = 1;
            tpMVSeparateVolume.Text = "Отдельный том";
            // 
            // gbMVSeparateVolumeRequired
            // 
            gbMVSeparateVolumeRequired.Controls.Add(label68);
            gbMVSeparateVolumeRequired.Controls.Add(textBox67);
            gbMVSeparateVolumeRequired.Controls.Add(label67);
            gbMVSeparateVolumeRequired.Controls.Add(textBox66);
            gbMVSeparateVolumeRequired.Controls.Add(label54);
            gbMVSeparateVolumeRequired.Controls.Add(textBox53);
            gbMVSeparateVolumeRequired.Controls.Add(label55);
            gbMVSeparateVolumeRequired.Controls.Add(textBox54);
            gbMVSeparateVolumeRequired.Controls.Add(button5);
            gbMVSeparateVolumeRequired.Controls.Add(listBox3);
            gbMVSeparateVolumeRequired.Controls.Add(label56);
            gbMVSeparateVolumeRequired.Controls.Add(textBox55);
            gbMVSeparateVolumeRequired.Controls.Add(label57);
            gbMVSeparateVolumeRequired.Controls.Add(textBox56);
            gbMVSeparateVolumeRequired.Controls.Add(label58);
            gbMVSeparateVolumeRequired.Controls.Add(textBox57);
            gbMVSeparateVolumeRequired.Controls.Add(label59);
            gbMVSeparateVolumeRequired.Controls.Add(textBox58);
            gbMVSeparateVolumeRequired.Controls.Add(label60);
            gbMVSeparateVolumeRequired.Controls.Add(textBox59);
            gbMVSeparateVolumeRequired.Location = new Point(10, 10);
            gbMVSeparateVolumeRequired.Name = "gbMVSeparateVolumeRequired";
            gbMVSeparateVolumeRequired.Size = new Size(488, 531);
            gbMVSeparateVolumeRequired.TabIndex = 2;
            gbMVSeparateVolumeRequired.TabStop = false;
            gbMVSeparateVolumeRequired.Text = "Обязательные поля";
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Location = new Point(10, 478);
            label68.Name = "label68";
            label68.Size = new Size(120, 15);
            label68.TabIndex = 18;
            label68.Text = "Количество страниц";
            // 
            // textBox67
            // 
            textBox67.Location = new Point(10, 498);
            textBox67.Name = "textBox67";
            textBox67.Size = new Size(450, 23);
            textBox67.TabIndex = 19;
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Location = new Point(10, 432);
            label67.Name = "label67";
            label67.Size = new Size(73, 15);
            label67.TabIndex = 16;
            label67.Text = "Год издания";
            // 
            // textBox66
            // 
            textBox66.Location = new Point(10, 452);
            textBox66.Name = "textBox66";
            textBox66.Size = new Size(450, 23);
            textBox66.TabIndex = 17;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new Point(10, 386);
            label54.Name = "label54";
            label54.Size = new Size(81, 15);
            label54.TabIndex = 14;
            label54.Text = "Издательство";
            // 
            // textBox53
            // 
            textBox53.Location = new Point(10, 406);
            textBox53.Name = "textBox53";
            textBox53.Size = new Size(450, 23);
            textBox53.TabIndex = 15;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new Point(10, 20);
            label55.Name = "label55";
            label55.Size = new Size(57, 15);
            label55.TabIndex = 0;
            label55.Text = "Автор(ы)";
            // 
            // textBox54
            // 
            textBox54.Location = new Point(10, 40);
            textBox54.Name = "textBox54";
            textBox54.Size = new Size(350, 23);
            textBox54.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(370, 40);
            button5.Name = "button5";
            button5.Size = new Size(90, 23);
            button5.TabIndex = 2;
            button5.Text = "Добавить";
            button5.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(10, 70);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(450, 64);
            listBox3.TabIndex = 3;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(10, 140);
            label56.Name = "label56";
            label56.Size = new Size(57, 15);
            label56.TabIndex = 4;
            label56.Text = "Заглавие";
            // 
            // textBox55
            // 
            textBox55.Location = new Point(10, 160);
            textBox55.Name = "textBox55";
            textBox55.Size = new Size(450, 23);
            textBox55.TabIndex = 5;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Location = new Point(10, 190);
            label57.Name = "label57";
            label57.Size = new Size(109, 15);
            label57.TabIndex = 6;
            label57.Text = "Количество томов";
            // 
            // textBox56
            // 
            textBox56.Location = new Point(10, 210);
            textBox56.Name = "textBox56";
            textBox56.Size = new Size(450, 23);
            textBox56.TabIndex = 7;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Location = new Point(10, 240);
            label58.Name = "label58";
            label58.Size = new Size(75, 15);
            label58.TabIndex = 8;
            label58.Text = "Номер тома";
            // 
            // textBox57
            // 
            textBox57.Location = new Point(10, 260);
            textBox57.Name = "textBox57";
            textBox57.Size = new Size(450, 23);
            textBox57.TabIndex = 9;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Location = new Point(10, 290);
            label59.Name = "label59";
            label59.Size = new Size(87, 15);
            label59.TabIndex = 10;
            label59.Text = "Заглавие тома";
            // 
            // textBox58
            // 
            textBox58.Location = new Point(10, 310);
            textBox58.Name = "textBox58";
            textBox58.Size = new Size(450, 23);
            textBox58.TabIndex = 11;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Location = new Point(10, 340);
            label60.Name = "label60";
            label60.Size = new Size(89, 15);
            label60.TabIndex = 12;
            label60.Text = "Место издания";
            // 
            // textBox59
            // 
            textBox59.Location = new Point(10, 360);
            textBox59.Name = "textBox59";
            textBox59.Size = new Size(450, 23);
            textBox59.TabIndex = 13;
            // 
            // gbMVSeparateVolumeOptional
            // 
            gbMVSeparateVolumeOptional.Controls.Add(panelMVSeparateVolumeOptional);
            gbMVSeparateVolumeOptional.Location = new Point(10, 547);
            gbMVSeparateVolumeOptional.Name = "gbMVSeparateVolumeOptional";
            gbMVSeparateVolumeOptional.Size = new Size(488, 171);
            gbMVSeparateVolumeOptional.TabIndex = 3;
            gbMVSeparateVolumeOptional.TabStop = false;
            gbMVSeparateVolumeOptional.Text = "Необязательные поля";
            // 
            // panelMVSeparateVolumeOptional
            // 
            panelMVSeparateVolumeOptional.AutoScroll = true;
            panelMVSeparateVolumeOptional.Controls.Add(label61);
            panelMVSeparateVolumeOptional.Controls.Add(textBox60);
            panelMVSeparateVolumeOptional.Controls.Add(textBox65);
            panelMVSeparateVolumeOptional.Controls.Add(label62);
            panelMVSeparateVolumeOptional.Controls.Add(label66);
            panelMVSeparateVolumeOptional.Controls.Add(textBox61);
            panelMVSeparateVolumeOptional.Controls.Add(textBox64);
            panelMVSeparateVolumeOptional.Controls.Add(label63);
            panelMVSeparateVolumeOptional.Controls.Add(label65);
            panelMVSeparateVolumeOptional.Controls.Add(textBox62);
            panelMVSeparateVolumeOptional.Controls.Add(textBox63);
            panelMVSeparateVolumeOptional.Controls.Add(label64);
            panelMVSeparateVolumeOptional.Location = new Point(10, 22);
            panelMVSeparateVolumeOptional.Name = "panelMVSeparateVolumeOptional";
            panelMVSeparateVolumeOptional.Size = new Size(473, 143);
            panelMVSeparateVolumeOptional.TabIndex = 20;
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.Location = new Point(0, 0);
            label61.Name = "label61";
            label61.Size = new Size(88, 15);
            label61.TabIndex = 0;
            label61.Text = "Вид документа";
            // 
            // textBox60
            // 
            textBox60.Location = new Point(0, 20);
            textBox60.Name = "textBox60";
            textBox60.Size = new Size(450, 23);
            textBox60.TabIndex = 1;
            // 
            // textBox65
            // 
            textBox65.Location = new Point(0, 270);
            textBox65.Name = "textBox65";
            textBox65.Size = new Size(450, 23);
            textBox65.TabIndex = 11;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Location = new Point(0, 50);
            label62.Name = "label62";
            label62.Size = new Size(147, 15);
            label62.TabIndex = 2;
            label62.Text = "Область ответственности";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Location = new Point(0, 250);
            label66.Name = "label66";
            label66.Size = new Size(32, 15);
            label66.TabIndex = 10;
            label66.Text = "ISBN";
            // 
            // textBox61
            // 
            textBox61.Location = new Point(0, 70);
            textBox61.Name = "textBox61";
            textBox61.Size = new Size(450, 23);
            textBox61.TabIndex = 3;
            // 
            // textBox64
            // 
            textBox64.Location = new Point(0, 220);
            textBox64.Name = "textBox64";
            textBox64.Size = new Size(450, 23);
            textBox64.TabIndex = 9;
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Location = new Point(0, 100);
            label63.Name = "label63";
            label63.Size = new Size(57, 15);
            label63.TabIndex = 4;
            label63.Text = "Редактор";
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Location = new Point(0, 200);
            label65.Name = "label65";
            label65.Size = new Size(41, 15);
            label65.TabIndex = 8;
            label65.Text = "Серия";
            // 
            // textBox62
            // 
            textBox62.Location = new Point(0, 120);
            textBox62.Name = "textBox62";
            textBox62.Size = new Size(450, 23);
            textBox62.TabIndex = 5;
            // 
            // textBox63
            // 
            textBox63.Location = new Point(0, 170);
            textBox63.Name = "textBox63";
            textBox63.Size = new Size(450, 23);
            textBox63.TabIndex = 7;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Location = new Point(0, 150);
            label64.Name = "label64";
            label64.Size = new Size(92, 15);
            label64.TabIndex = 6;
            label64.Text = "Номер издания";
            // 
            // tpElectronicResources
            // 
            tpElectronicResources.BackColor = SystemColors.Control;
            tpElectronicResources.Controls.Add(tcERTypes);
            tpElectronicResources.Location = new Point(4, 24);
            tpElectronicResources.Name = "tpElectronicResources";
            tpElectronicResources.Padding = new Padding(3);
            tpElectronicResources.Size = new Size(518, 762);
            tpElectronicResources.TabIndex = 2;
            tpElectronicResources.Text = "Электронные ресурсы";
            // 
            // tcERTypes
            // 
            tcERTypes.Controls.Add(tpEREbook);
            tcERTypes.Controls.Add(tpERMultimediaEdition);
            tcERTypes.Controls.Add(tpEREjournalArticle);
            tcERTypes.Controls.Add(tpERWebsite);
            tcERTypes.Location = new Point(3, 6);
            tcERTypes.Name = "tcERTypes";
            tcERTypes.SelectedIndex = 0;
            tcERTypes.Size = new Size(513, 752);
            tcERTypes.TabIndex = 1;
            // 
            // tpEREbook
            // 
            tpEREbook.BackColor = SystemColors.Control;
            tpEREbook.Controls.Add(gbEREbookRequired);
            tpEREbook.Controls.Add(gbEREbookOptional);
            tpEREbook.Location = new Point(4, 24);
            tpEREbook.Name = "tpEREbook";
            tpEREbook.Padding = new Padding(3);
            tpEREbook.Size = new Size(505, 724);
            tpEREbook.TabIndex = 0;
            tpEREbook.Text = "Электронная книга";
            // 
            // gbEREbookRequired
            // 
            gbEREbookRequired.Controls.Add(label173);
            gbEREbookRequired.Controls.Add(textBox172);
            gbEREbookRequired.Controls.Add(label69);
            gbEREbookRequired.Controls.Add(textBox68);
            gbEREbookRequired.Controls.Add(button6);
            gbEREbookRequired.Controls.Add(listBox4);
            gbEREbookRequired.Controls.Add(label70);
            gbEREbookRequired.Controls.Add(textBox69);
            gbEREbookRequired.Controls.Add(label71);
            gbEREbookRequired.Controls.Add(textBox70);
            gbEREbookRequired.Controls.Add(label72);
            gbEREbookRequired.Controls.Add(textBox71);
            gbEREbookRequired.Controls.Add(label73);
            gbEREbookRequired.Controls.Add(textBox72);
            gbEREbookRequired.Controls.Add(label74);
            gbEREbookRequired.Controls.Add(textBox73);
            gbEREbookRequired.Location = new Point(10, 10);
            gbEREbookRequired.Name = "gbEREbookRequired";
            gbEREbookRequired.Size = new Size(488, 451);
            gbEREbookRequired.TabIndex = 0;
            gbEREbookRequired.TabStop = false;
            gbEREbookRequired.Text = "Обязательные поля";
            // 
            // label173
            // 
            label173.AutoSize = true;
            label173.Location = new Point(10, 385);
            label173.Name = "label173";
            label173.Size = new Size(99, 15);
            label173.TabIndex = 14;
            label173.Text = "Дата обращения";
            // 
            // textBox172
            // 
            textBox172.Location = new Point(10, 405);
            textBox172.Name = "textBox172";
            textBox172.Size = new Size(450, 23);
            textBox172.TabIndex = 15;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Location = new Point(10, 20);
            label69.Name = "label69";
            label69.Size = new Size(57, 15);
            label69.TabIndex = 0;
            label69.Text = "Автор(ы)";
            // 
            // textBox68
            // 
            textBox68.Location = new Point(10, 40);
            textBox68.Name = "textBox68";
            textBox68.Size = new Size(350, 23);
            textBox68.TabIndex = 1;
            // 
            // button6
            // 
            button6.Location = new Point(370, 40);
            button6.Name = "button6";
            button6.Size = new Size(90, 23);
            button6.TabIndex = 2;
            button6.Text = "Добавить";
            button6.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(10, 70);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(450, 64);
            listBox4.TabIndex = 3;
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Location = new Point(10, 140);
            label70.Name = "label70";
            label70.Size = new Size(57, 15);
            label70.TabIndex = 4;
            label70.Text = "Заглавие";
            // 
            // textBox69
            // 
            textBox69.Location = new Point(10, 160);
            textBox69.Name = "textBox69";
            textBox69.Size = new Size(450, 23);
            textBox69.TabIndex = 5;
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Location = new Point(10, 190);
            label71.Name = "label71";
            label71.Size = new Size(89, 15);
            label71.TabIndex = 6;
            label71.Text = "Место издания";
            // 
            // textBox70
            // 
            textBox70.Location = new Point(10, 210);
            textBox70.Name = "textBox70";
            textBox70.Size = new Size(450, 23);
            textBox70.TabIndex = 7;
            // 
            // label72
            // 
            label72.AutoSize = true;
            label72.Location = new Point(10, 240);
            label72.Name = "label72";
            label72.Size = new Size(81, 15);
            label72.TabIndex = 8;
            label72.Text = "Издательство";
            // 
            // textBox71
            // 
            textBox71.Location = new Point(10, 260);
            textBox71.Name = "textBox71";
            textBox71.Size = new Size(450, 23);
            textBox71.TabIndex = 9;
            // 
            // label73
            // 
            label73.AutoSize = true;
            label73.Location = new Point(10, 290);
            label73.Name = "label73";
            label73.Size = new Size(73, 15);
            label73.TabIndex = 10;
            label73.Text = "Год издания";
            // 
            // textBox72
            // 
            textBox72.Location = new Point(10, 310);
            textBox72.Name = "textBox72";
            textBox72.Size = new Size(450, 23);
            textBox72.TabIndex = 11;
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.Location = new Point(10, 340);
            label74.Name = "label74";
            label74.Size = new Size(28, 15);
            label74.TabIndex = 12;
            label74.Text = "URL";
            // 
            // textBox73
            // 
            textBox73.Location = new Point(10, 360);
            textBox73.Name = "textBox73";
            textBox73.Size = new Size(450, 23);
            textBox73.TabIndex = 13;
            // 
            // gbEREbookOptional
            // 
            gbEREbookOptional.Controls.Add(panelEREbookOptional);
            gbEREbookOptional.Location = new Point(10, 467);
            gbEREbookOptional.Name = "gbEREbookOptional";
            gbEREbookOptional.Size = new Size(488, 251);
            gbEREbookOptional.TabIndex = 1;
            gbEREbookOptional.TabStop = false;
            gbEREbookOptional.Text = "Необязательные поля";
            // 
            // panelEREbookOptional
            // 
            panelEREbookOptional.AutoScroll = true;
            panelEREbookOptional.Controls.Add(label174);
            panelEREbookOptional.Controls.Add(label81);
            panelEREbookOptional.Controls.Add(textBox173);
            panelEREbookOptional.Controls.Add(textBox80);
            panelEREbookOptional.Controls.Add(label75);
            panelEREbookOptional.Controls.Add(textBox79);
            panelEREbookOptional.Controls.Add(textBox74);
            panelEREbookOptional.Controls.Add(label80);
            panelEREbookOptional.Controls.Add(label76);
            panelEREbookOptional.Controls.Add(textBox78);
            panelEREbookOptional.Controls.Add(textBox75);
            panelEREbookOptional.Controls.Add(label79);
            panelEREbookOptional.Controls.Add(label77);
            panelEREbookOptional.Controls.Add(textBox77);
            panelEREbookOptional.Controls.Add(textBox76);
            panelEREbookOptional.Controls.Add(label78);
            panelEREbookOptional.Location = new Point(10, 22);
            panelEREbookOptional.Name = "panelEREbookOptional";
            panelEREbookOptional.Size = new Size(473, 223);
            panelEREbookOptional.TabIndex = 16;
            // 
            // label174
            // 
            label174.AutoSize = true;
            label174.Location = new Point(0, 347);
            label174.Name = "label174";
            label174.Size = new Size(91, 15);
            label174.TabIndex = 14;
            label174.Text = "Режим доступа";
            // 
            // label81
            // 
            label81.AutoSize = true;
            label81.Location = new Point(0, 300);
            label81.Name = "label81";
            label81.Size = new Size(32, 15);
            label81.TabIndex = 12;
            label81.Text = "ISBN";
            // 
            // textBox173
            // 
            textBox173.Location = new Point(0, 367);
            textBox173.Name = "textBox173";
            textBox173.Size = new Size(450, 23);
            textBox173.TabIndex = 15;
            // 
            // textBox80
            // 
            textBox80.Location = new Point(0, 320);
            textBox80.Name = "textBox80";
            textBox80.Size = new Size(450, 23);
            textBox80.TabIndex = 13;
            // 
            // label75
            // 
            label75.AutoSize = true;
            label75.Location = new Point(0, 0);
            label75.Name = "label75";
            label75.Size = new Size(88, 15);
            label75.TabIndex = 0;
            label75.Text = "Вид документа";
            // 
            // textBox79
            // 
            textBox79.Location = new Point(0, 270);
            textBox79.Name = "textBox79";
            textBox79.Size = new Size(450, 23);
            textBox79.TabIndex = 11;
            // 
            // textBox74
            // 
            textBox74.Location = new Point(0, 20);
            textBox74.Name = "textBox74";
            textBox74.Size = new Size(450, 23);
            textBox74.TabIndex = 1;
            // 
            // label80
            // 
            label80.AutoSize = true;
            label80.Location = new Point(0, 250);
            label80.Name = "label80";
            label80.Size = new Size(41, 15);
            label80.TabIndex = 10;
            label80.Text = "Серия";
            // 
            // label76
            // 
            label76.AutoSize = true;
            label76.Location = new Point(0, 50);
            label76.Name = "label76";
            label76.Size = new Size(147, 15);
            label76.TabIndex = 2;
            label76.Text = "Область ответственности";
            // 
            // textBox78
            // 
            textBox78.Location = new Point(0, 220);
            textBox78.Name = "textBox78";
            textBox78.Size = new Size(450, 23);
            textBox78.TabIndex = 9;
            // 
            // textBox75
            // 
            textBox75.Location = new Point(0, 70);
            textBox75.Name = "textBox75";
            textBox75.Size = new Size(450, 23);
            textBox75.TabIndex = 3;
            // 
            // label79
            // 
            label79.AutoSize = true;
            label79.Location = new Point(0, 200);
            label79.Name = "label79";
            label79.Size = new Size(120, 15);
            label79.TabIndex = 8;
            label79.Text = "Количество страниц";
            // 
            // label77
            // 
            label77.AutoSize = true;
            label77.Location = new Point(0, 100);
            label77.Name = "label77";
            label77.Size = new Size(57, 15);
            label77.TabIndex = 4;
            label77.Text = "Редактор";
            // 
            // textBox77
            // 
            textBox77.Location = new Point(0, 170);
            textBox77.Name = "textBox77";
            textBox77.Size = new Size(450, 23);
            textBox77.TabIndex = 7;
            // 
            // textBox76
            // 
            textBox76.Location = new Point(0, 120);
            textBox76.Name = "textBox76";
            textBox76.Size = new Size(450, 23);
            textBox76.TabIndex = 5;
            // 
            // label78
            // 
            label78.AutoSize = true;
            label78.Location = new Point(0, 150);
            label78.Name = "label78";
            label78.Size = new Size(92, 15);
            label78.TabIndex = 6;
            label78.Text = "Номер издания";
            // 
            // tpERMultimediaEdition
            // 
            tpERMultimediaEdition.BackColor = SystemColors.Control;
            tpERMultimediaEdition.Controls.Add(gbERMultimediaEditionRequired);
            tpERMultimediaEdition.Controls.Add(gbERMultimediaEditionOptional);
            tpERMultimediaEdition.Location = new Point(4, 24);
            tpERMultimediaEdition.Name = "tpERMultimediaEdition";
            tpERMultimediaEdition.Padding = new Padding(3);
            tpERMultimediaEdition.Size = new Size(505, 724);
            tpERMultimediaEdition.TabIndex = 1;
            tpERMultimediaEdition.Text = "Мультимедийное издание (на диске)";
            // 
            // gbERMultimediaEditionRequired
            // 
            gbERMultimediaEditionRequired.Controls.Add(label83);
            gbERMultimediaEditionRequired.Controls.Add(textBox82);
            gbERMultimediaEditionRequired.Controls.Add(button3);
            gbERMultimediaEditionRequired.Controls.Add(listBox6);
            gbERMultimediaEditionRequired.Controls.Add(label84);
            gbERMultimediaEditionRequired.Controls.Add(textBox83);
            gbERMultimediaEditionRequired.Controls.Add(label85);
            gbERMultimediaEditionRequired.Controls.Add(textBox84);
            gbERMultimediaEditionRequired.Controls.Add(label86);
            gbERMultimediaEditionRequired.Controls.Add(textBox85);
            gbERMultimediaEditionRequired.Controls.Add(label87);
            gbERMultimediaEditionRequired.Controls.Add(textBox86);
            gbERMultimediaEditionRequired.Controls.Add(label88);
            gbERMultimediaEditionRequired.Controls.Add(textBox87);
            gbERMultimediaEditionRequired.Location = new Point(10, 10);
            gbERMultimediaEditionRequired.Name = "gbERMultimediaEditionRequired";
            gbERMultimediaEditionRequired.Size = new Size(488, 395);
            gbERMultimediaEditionRequired.TabIndex = 2;
            gbERMultimediaEditionRequired.TabStop = false;
            gbERMultimediaEditionRequired.Text = "Обязательные поля";
            // 
            // label83
            // 
            label83.AutoSize = true;
            label83.Location = new Point(10, 20);
            label83.Name = "label83";
            label83.Size = new Size(57, 15);
            label83.TabIndex = 0;
            label83.Text = "Автор(ы)";
            // 
            // textBox82
            // 
            textBox82.Location = new Point(10, 40);
            textBox82.Name = "textBox82";
            textBox82.Size = new Size(350, 23);
            textBox82.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(370, 40);
            button3.Name = "button3";
            button3.Size = new Size(90, 23);
            button3.TabIndex = 2;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBox6
            // 
            listBox6.ItemHeight = 15;
            listBox6.Location = new Point(10, 70);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(450, 64);
            listBox6.TabIndex = 3;
            // 
            // label84
            // 
            label84.AutoSize = true;
            label84.Location = new Point(10, 140);
            label84.Name = "label84";
            label84.Size = new Size(57, 15);
            label84.TabIndex = 4;
            label84.Text = "Заглавие";
            // 
            // textBox83
            // 
            textBox83.Location = new Point(10, 160);
            textBox83.Name = "textBox83";
            textBox83.Size = new Size(450, 23);
            textBox83.TabIndex = 5;
            // 
            // label85
            // 
            label85.AutoSize = true;
            label85.Location = new Point(10, 190);
            label85.Name = "label85";
            label85.Size = new Size(89, 15);
            label85.TabIndex = 6;
            label85.Text = "Место издания";
            // 
            // textBox84
            // 
            textBox84.Location = new Point(10, 210);
            textBox84.Name = "textBox84";
            textBox84.Size = new Size(450, 23);
            textBox84.TabIndex = 7;
            // 
            // label86
            // 
            label86.AutoSize = true;
            label86.Location = new Point(10, 240);
            label86.Name = "label86";
            label86.Size = new Size(81, 15);
            label86.TabIndex = 8;
            label86.Text = "Издательство";
            // 
            // textBox85
            // 
            textBox85.Location = new Point(10, 260);
            textBox85.Name = "textBox85";
            textBox85.Size = new Size(450, 23);
            textBox85.TabIndex = 9;
            // 
            // label87
            // 
            label87.AutoSize = true;
            label87.Location = new Point(10, 290);
            label87.Name = "label87";
            label87.Size = new Size(73, 15);
            label87.TabIndex = 10;
            label87.Text = "Год издания";
            // 
            // textBox86
            // 
            textBox86.Location = new Point(10, 310);
            textBox86.Name = "textBox86";
            textBox86.Size = new Size(450, 23);
            textBox86.TabIndex = 11;
            // 
            // label88
            // 
            label88.AutoSize = true;
            label88.Location = new Point(10, 340);
            label88.Name = "label88";
            label88.Size = new Size(60, 15);
            label88.TabIndex = 12;
            label88.Text = "Носитель";
            // 
            // textBox87
            // 
            textBox87.Location = new Point(10, 360);
            textBox87.Name = "textBox87";
            textBox87.Size = new Size(450, 23);
            textBox87.TabIndex = 13;
            // 
            // gbERMultimediaEditionOptional
            // 
            gbERMultimediaEditionOptional.Controls.Add(panelERMultimediaEditionOptional);
            gbERMultimediaEditionOptional.Location = new Point(10, 411);
            gbERMultimediaEditionOptional.Name = "gbERMultimediaEditionOptional";
            gbERMultimediaEditionOptional.Size = new Size(488, 307);
            gbERMultimediaEditionOptional.TabIndex = 3;
            gbERMultimediaEditionOptional.TabStop = false;
            gbERMultimediaEditionOptional.Text = "Необязательные поля";
            // 
            // panelERMultimediaEditionOptional
            // 
            panelERMultimediaEditionOptional.AutoScroll = true;
            panelERMultimediaEditionOptional.Controls.Add(label90);
            panelERMultimediaEditionOptional.Controls.Add(textBox89);
            panelERMultimediaEditionOptional.Controls.Add(textBox94);
            panelERMultimediaEditionOptional.Controls.Add(label91);
            panelERMultimediaEditionOptional.Controls.Add(label95);
            panelERMultimediaEditionOptional.Controls.Add(textBox90);
            panelERMultimediaEditionOptional.Controls.Add(textBox93);
            panelERMultimediaEditionOptional.Controls.Add(label92);
            panelERMultimediaEditionOptional.Controls.Add(label94);
            panelERMultimediaEditionOptional.Controls.Add(textBox91);
            panelERMultimediaEditionOptional.Controls.Add(textBox92);
            panelERMultimediaEditionOptional.Controls.Add(label93);
            panelERMultimediaEditionOptional.Location = new Point(10, 22);
            panelERMultimediaEditionOptional.Name = "panelERMultimediaEditionOptional";
            panelERMultimediaEditionOptional.Size = new Size(473, 279);
            panelERMultimediaEditionOptional.TabIndex = 4;
            // 
            // label90
            // 
            label90.AutoSize = true;
            label90.Location = new Point(0, 1);
            label90.Name = "label90";
            label90.Size = new Size(88, 15);
            label90.TabIndex = 0;
            label90.Text = "Вид документа";
            // 
            // textBox89
            // 
            textBox89.Location = new Point(0, 21);
            textBox89.Name = "textBox89";
            textBox89.Size = new Size(450, 23);
            textBox89.TabIndex = 1;
            // 
            // textBox94
            // 
            textBox94.Location = new Point(0, 271);
            textBox94.Name = "textBox94";
            textBox94.Size = new Size(450, 23);
            textBox94.TabIndex = 11;
            // 
            // label91
            // 
            label91.AutoSize = true;
            label91.Location = new Point(0, 51);
            label91.Name = "label91";
            label91.Size = new Size(147, 15);
            label91.TabIndex = 2;
            label91.Text = "Область ответственности";
            // 
            // label95
            // 
            label95.AutoSize = true;
            label95.Location = new Point(0, 251);
            label95.Name = "label95";
            label95.Size = new Size(32, 15);
            label95.TabIndex = 10;
            label95.Text = "ISBN";
            // 
            // textBox90
            // 
            textBox90.Location = new Point(0, 71);
            textBox90.Name = "textBox90";
            textBox90.Size = new Size(450, 23);
            textBox90.TabIndex = 3;
            // 
            // textBox93
            // 
            textBox93.Location = new Point(0, 221);
            textBox93.Name = "textBox93";
            textBox93.Size = new Size(450, 23);
            textBox93.TabIndex = 9;
            // 
            // label92
            // 
            label92.AutoSize = true;
            label92.Location = new Point(0, 101);
            label92.Name = "label92";
            label92.Size = new Size(57, 15);
            label92.TabIndex = 4;
            label92.Text = "Редактор";
            // 
            // label94
            // 
            label94.AutoSize = true;
            label94.Location = new Point(0, 201);
            label94.Name = "label94";
            label94.Size = new Size(78, 15);
            label94.TabIndex = 8;
            label94.Text = "Примечание";
            // 
            // textBox91
            // 
            textBox91.Location = new Point(0, 121);
            textBox91.Name = "textBox91";
            textBox91.Size = new Size(450, 23);
            textBox91.TabIndex = 5;
            // 
            // textBox92
            // 
            textBox92.Location = new Point(0, 171);
            textBox92.Name = "textBox92";
            textBox92.Size = new Size(450, 23);
            textBox92.TabIndex = 7;
            // 
            // label93
            // 
            label93.AutoSize = true;
            label93.Location = new Point(0, 151);
            label93.Name = "label93";
            label93.Size = new Size(79, 15);
            label93.TabIndex = 6;
            label93.Text = "Организация";
            // 
            // tpEREjournalArticle
            // 
            tpEREjournalArticle.BackColor = SystemColors.Control;
            tpEREjournalArticle.Controls.Add(gbEREjournalArticleReqired);
            tpEREjournalArticle.Controls.Add(gbEREjournalArticleOptional);
            tpEREjournalArticle.Location = new Point(4, 24);
            tpEREjournalArticle.Name = "tpEREjournalArticle";
            tpEREjournalArticle.Padding = new Padding(3);
            tpEREjournalArticle.Size = new Size(505, 724);
            tpEREjournalArticle.TabIndex = 2;
            tpEREjournalArticle.Text = "Статья из электронного журнала";
            // 
            // gbEREjournalArticleReqired
            // 
            gbEREjournalArticleReqired.Controls.Add(label82);
            gbEREjournalArticleReqired.Controls.Add(textBox81);
            gbEREjournalArticleReqired.Controls.Add(label97);
            gbEREjournalArticleReqired.Controls.Add(textBox96);
            gbEREjournalArticleReqired.Controls.Add(label98);
            gbEREjournalArticleReqired.Controls.Add(textBox97);
            gbEREjournalArticleReqired.Controls.Add(button8);
            gbEREjournalArticleReqired.Controls.Add(listBox7);
            gbEREjournalArticleReqired.Controls.Add(label99);
            gbEREjournalArticleReqired.Controls.Add(textBox98);
            gbEREjournalArticleReqired.Controls.Add(label100);
            gbEREjournalArticleReqired.Controls.Add(textBox99);
            gbEREjournalArticleReqired.Controls.Add(label101);
            gbEREjournalArticleReqired.Controls.Add(textBox100);
            gbEREjournalArticleReqired.Controls.Add(label102);
            gbEREjournalArticleReqired.Controls.Add(textBox101);
            gbEREjournalArticleReqired.Controls.Add(label103);
            gbEREjournalArticleReqired.Controls.Add(textBox102);
            gbEREjournalArticleReqired.Location = new Point(10, 10);
            gbEREjournalArticleReqired.Name = "gbEREjournalArticleReqired";
            gbEREjournalArticleReqired.Size = new Size(470, 486);
            gbEREjournalArticleReqired.TabIndex = 2;
            gbEREjournalArticleReqired.TabStop = false;
            gbEREjournalArticleReqired.Text = "Обязательные поля";
            // 
            // label82
            // 
            label82.AutoSize = true;
            label82.Location = new Point(10, 432);
            label82.Name = "label82";
            label82.Size = new Size(99, 15);
            label82.TabIndex = 16;
            label82.Text = "Дата обращения";
            // 
            // textBox81
            // 
            textBox81.Location = new Point(10, 452);
            textBox81.Name = "textBox81";
            textBox81.Size = new Size(450, 23);
            textBox81.TabIndex = 17;
            // 
            // label97
            // 
            label97.AutoSize = true;
            label97.Location = new Point(10, 385);
            label97.Name = "label97";
            label97.Size = new Size(28, 15);
            label97.TabIndex = 14;
            label97.Text = "URL";
            // 
            // textBox96
            // 
            textBox96.Location = new Point(10, 405);
            textBox96.Name = "textBox96";
            textBox96.Size = new Size(450, 23);
            textBox96.TabIndex = 15;
            // 
            // label98
            // 
            label98.AutoSize = true;
            label98.Location = new Point(10, 20);
            label98.Name = "label98";
            label98.Size = new Size(57, 15);
            label98.TabIndex = 0;
            label98.Text = "Автор(ы)";
            // 
            // textBox97
            // 
            textBox97.Location = new Point(10, 40);
            textBox97.Name = "textBox97";
            textBox97.Size = new Size(350, 23);
            textBox97.TabIndex = 1;
            // 
            // button8
            // 
            button8.Location = new Point(370, 40);
            button8.Name = "button8";
            button8.Size = new Size(90, 23);
            button8.TabIndex = 2;
            button8.Text = "Добавить";
            button8.UseVisualStyleBackColor = true;
            // 
            // listBox7
            // 
            listBox7.ItemHeight = 15;
            listBox7.Location = new Point(10, 70);
            listBox7.Name = "listBox7";
            listBox7.Size = new Size(450, 64);
            listBox7.TabIndex = 3;
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Location = new Point(10, 140);
            label99.Name = "label99";
            label99.Size = new Size(57, 15);
            label99.TabIndex = 4;
            label99.Text = "Заглавие";
            // 
            // textBox98
            // 
            textBox98.Location = new Point(10, 160);
            textBox98.Name = "textBox98";
            textBox98.Size = new Size(450, 23);
            textBox98.TabIndex = 5;
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Location = new Point(10, 190);
            label100.Name = "label100";
            label100.Size = new Size(110, 15);
            label100.TabIndex = 6;
            label100.Text = "Название журнала";
            // 
            // textBox99
            // 
            textBox99.Location = new Point(10, 210);
            textBox99.Name = "textBox99";
            textBox99.Size = new Size(450, 23);
            textBox99.TabIndex = 7;
            // 
            // label101
            // 
            label101.AutoSize = true;
            label101.Location = new Point(10, 240);
            label101.Name = "label101";
            label101.Size = new Size(26, 15);
            label101.TabIndex = 8;
            label101.Text = "Год";
            // 
            // textBox100
            // 
            textBox100.Location = new Point(10, 260);
            textBox100.Name = "textBox100";
            textBox100.Size = new Size(450, 23);
            textBox100.TabIndex = 9;
            // 
            // label102
            // 
            label102.AutoSize = true;
            label102.Location = new Point(10, 290);
            label102.Name = "label102";
            label102.Size = new Size(96, 15);
            label102.TabIndex = 10;
            label102.Text = "Номер журнала";
            // 
            // textBox101
            // 
            textBox101.Location = new Point(10, 310);
            textBox101.Name = "textBox101";
            textBox101.Size = new Size(450, 23);
            textBox101.TabIndex = 11;
            // 
            // label103
            // 
            label103.AutoSize = true;
            label103.Location = new Point(10, 340);
            label103.Name = "label103";
            label103.Size = new Size(63, 15);
            label103.TabIndex = 12;
            label103.Text = "Страницы";
            // 
            // textBox102
            // 
            textBox102.Location = new Point(10, 360);
            textBox102.Name = "textBox102";
            textBox102.Size = new Size(450, 23);
            textBox102.TabIndex = 13;
            // 
            // gbEREjournalArticleOptional
            // 
            gbEREjournalArticleOptional.Controls.Add(label105);
            gbEREjournalArticleOptional.Controls.Add(textBox104);
            gbEREjournalArticleOptional.Location = new Point(10, 502);
            gbEREjournalArticleOptional.Name = "gbEREjournalArticleOptional";
            gbEREjournalArticleOptional.Size = new Size(470, 216);
            gbEREjournalArticleOptional.TabIndex = 3;
            gbEREjournalArticleOptional.TabStop = false;
            gbEREjournalArticleOptional.Text = "Необязательные поля";
            // 
            // label105
            // 
            label105.AutoSize = true;
            label105.Location = new Point(10, 20);
            label105.Name = "label105";
            label105.Size = new Size(91, 15);
            label105.TabIndex = 0;
            label105.Text = "Режим доступа";
            // 
            // textBox104
            // 
            textBox104.Location = new Point(10, 40);
            textBox104.Name = "textBox104";
            textBox104.Size = new Size(450, 23);
            textBox104.TabIndex = 1;
            // 
            // tpERWebsite
            // 
            tpERWebsite.BackColor = SystemColors.Control;
            tpERWebsite.Controls.Add(gbERWebsiteRequired);
            tpERWebsite.Controls.Add(gbERWebsiteOptional);
            tpERWebsite.Location = new Point(4, 24);
            tpERWebsite.Name = "tpERWebsite";
            tpERWebsite.Padding = new Padding(3);
            tpERWebsite.Size = new Size(505, 724);
            tpERWebsite.TabIndex = 3;
            tpERWebsite.Text = "Сайт";
            // 
            // gbERWebsiteRequired
            // 
            gbERWebsiteRequired.Controls.Add(label112);
            gbERWebsiteRequired.Controls.Add(textBox111);
            gbERWebsiteRequired.Controls.Add(label113);
            gbERWebsiteRequired.Controls.Add(textBox112);
            gbERWebsiteRequired.Controls.Add(label114);
            gbERWebsiteRequired.Controls.Add(textBox113);
            gbERWebsiteRequired.Location = new Point(10, 10);
            gbERWebsiteRequired.Name = "gbERWebsiteRequired";
            gbERWebsiteRequired.Size = new Size(488, 170);
            gbERWebsiteRequired.TabIndex = 6;
            gbERWebsiteRequired.TabStop = false;
            gbERWebsiteRequired.Text = "Обязательные поля";
            // 
            // label112
            // 
            label112.AutoSize = true;
            label112.Location = new Point(10, 67);
            label112.Name = "label112";
            label112.Size = new Size(28, 15);
            label112.TabIndex = 14;
            label112.Text = "URL";
            // 
            // textBox111
            // 
            textBox111.Location = new Point(10, 87);
            textBox111.Name = "textBox111";
            textBox111.Size = new Size(450, 23);
            textBox111.TabIndex = 15;
            // 
            // label113
            // 
            label113.AutoSize = true;
            label113.Location = new Point(10, 20);
            label113.Name = "label113";
            label113.Size = new Size(92, 15);
            label113.TabIndex = 4;
            label113.Text = "Название сайта";
            // 
            // textBox112
            // 
            textBox112.Location = new Point(10, 40);
            textBox112.Name = "textBox112";
            textBox112.Size = new Size(450, 23);
            textBox112.TabIndex = 5;
            // 
            // label114
            // 
            label114.AutoSize = true;
            label114.Location = new Point(10, 115);
            label114.Name = "label114";
            label114.Size = new Size(99, 15);
            label114.TabIndex = 6;
            label114.Text = "Дата обращения";
            // 
            // textBox113
            // 
            textBox113.Location = new Point(10, 135);
            textBox113.Name = "textBox113";
            textBox113.Size = new Size(450, 23);
            textBox113.TabIndex = 7;
            // 
            // gbERWebsiteOptional
            // 
            gbERWebsiteOptional.Controls.Add(label89);
            gbERWebsiteOptional.Controls.Add(textBox88);
            gbERWebsiteOptional.Controls.Add(label117);
            gbERWebsiteOptional.Controls.Add(textBox116);
            gbERWebsiteOptional.Controls.Add(label118);
            gbERWebsiteOptional.Controls.Add(textBox117);
            gbERWebsiteOptional.Controls.Add(label119);
            gbERWebsiteOptional.Controls.Add(textBox118);
            gbERWebsiteOptional.Controls.Add(label120);
            gbERWebsiteOptional.Controls.Add(textBox119);
            gbERWebsiteOptional.Location = new Point(10, 186);
            gbERWebsiteOptional.Name = "gbERWebsiteOptional";
            gbERWebsiteOptional.Size = new Size(488, 532);
            gbERWebsiteOptional.TabIndex = 7;
            gbERWebsiteOptional.TabStop = false;
            gbERWebsiteOptional.Text = "Необязательные поля";
            // 
            // label89
            // 
            label89.AutoSize = true;
            label89.Location = new Point(10, 224);
            label89.Name = "label89";
            label89.Size = new Size(71, 15);
            label89.TabIndex = 8;
            label89.Text = "Учредитель";
            // 
            // textBox88
            // 
            textBox88.Location = new Point(10, 244);
            textBox88.Name = "textBox88";
            textBox88.Size = new Size(450, 23);
            textBox88.TabIndex = 9;
            // 
            // label117
            // 
            label117.AutoSize = true;
            label117.Location = new Point(10, 28);
            label117.Name = "label117";
            label117.Size = new Size(88, 15);
            label117.TabIndex = 0;
            label117.Text = "Вид документа";
            // 
            // textBox116
            // 
            textBox116.Location = new Point(10, 48);
            textBox116.Name = "textBox116";
            textBox116.Size = new Size(450, 23);
            textBox116.TabIndex = 1;
            // 
            // label118
            // 
            label118.AutoSize = true;
            label118.Location = new Point(10, 78);
            label118.Name = "label118";
            label118.Size = new Size(89, 15);
            label118.TabIndex = 2;
            label118.Text = "Место издания";
            // 
            // textBox117
            // 
            textBox117.Location = new Point(10, 98);
            textBox117.Name = "textBox117";
            textBox117.Size = new Size(450, 23);
            textBox117.TabIndex = 3;
            // 
            // label119
            // 
            label119.AutoSize = true;
            label119.Location = new Point(10, 128);
            label119.Name = "label119";
            label119.Size = new Size(151, 15);
            label119.TabIndex = 4;
            label119.Text = "Год создания/обновления";
            // 
            // textBox118
            // 
            textBox118.Location = new Point(10, 148);
            textBox118.Name = "textBox118";
            textBox118.Size = new Size(450, 23);
            textBox118.TabIndex = 5;
            // 
            // label120
            // 
            label120.AutoSize = true;
            label120.Location = new Point(10, 178);
            label120.Name = "label120";
            label120.Size = new Size(91, 15);
            label120.TabIndex = 6;
            label120.Text = "Режим доступа";
            // 
            // textBox119
            // 
            textBox119.Location = new Point(10, 198);
            textBox119.Name = "textBox119";
            textBox119.Size = new Size(450, 23);
            textBox119.TabIndex = 7;
            // 
            // tpConstituentParts
            // 
            tpConstituentParts.BackColor = SystemColors.Control;
            tpConstituentParts.Controls.Add(tcCPTypes);
            tpConstituentParts.Location = new Point(4, 24);
            tpConstituentParts.Name = "tpConstituentParts";
            tpConstituentParts.Padding = new Padding(3);
            tpConstituentParts.Size = new Size(518, 762);
            tpConstituentParts.TabIndex = 3;
            tpConstituentParts.Text = "Составные части (статьи, главы) ресурсов";
            // 
            // tcCPTypes
            // 
            tcCPTypes.Controls.Add(tpCPBookArticle);
            tcCPTypes.Controls.Add(tpCPJournalArticle);
            tcCPTypes.Controls.Add(tpCPNewspaperArticle);
            tcCPTypes.Controls.Add(tpCPWebsiteArticle);
            tcCPTypes.Location = new Point(3, 6);
            tcCPTypes.Name = "tcCPTypes";
            tcCPTypes.SelectedIndex = 0;
            tcCPTypes.Size = new Size(513, 752);
            tcCPTypes.TabIndex = 2;
            // 
            // tpCPBookArticle
            // 
            tpCPBookArticle.BackColor = SystemColors.Control;
            tpCPBookArticle.Controls.Add(gbCPBookArticleRequired);
            tpCPBookArticle.Controls.Add(gbCPBookArticleOptional);
            tpCPBookArticle.Location = new Point(4, 24);
            tpCPBookArticle.Name = "tpCPBookArticle";
            tpCPBookArticle.Padding = new Padding(3);
            tpCPBookArticle.Size = new Size(505, 724);
            tpCPBookArticle.TabIndex = 0;
            tpCPBookArticle.Text = "Статья/раздел из книги";
            // 
            // gbCPBookArticleRequired
            // 
            gbCPBookArticleRequired.Controls.Add(label130);
            gbCPBookArticleRequired.Controls.Add(textBox129);
            gbCPBookArticleRequired.Controls.Add(label129);
            gbCPBookArticleRequired.Controls.Add(textBox128);
            gbCPBookArticleRequired.Controls.Add(label123);
            gbCPBookArticleRequired.Controls.Add(textBox122);
            gbCPBookArticleRequired.Controls.Add(button12);
            gbCPBookArticleRequired.Controls.Add(listBox11);
            gbCPBookArticleRequired.Controls.Add(label121);
            gbCPBookArticleRequired.Controls.Add(textBox120);
            gbCPBookArticleRequired.Controls.Add(button7);
            gbCPBookArticleRequired.Controls.Add(listBox5);
            gbCPBookArticleRequired.Controls.Add(label122);
            gbCPBookArticleRequired.Controls.Add(textBox121);
            gbCPBookArticleRequired.Controls.Add(label124);
            gbCPBookArticleRequired.Controls.Add(textBox123);
            gbCPBookArticleRequired.Controls.Add(label125);
            gbCPBookArticleRequired.Controls.Add(textBox124);
            gbCPBookArticleRequired.Controls.Add(label126);
            gbCPBookArticleRequired.Controls.Add(textBox125);
            gbCPBookArticleRequired.Location = new Point(10, 10);
            gbCPBookArticleRequired.Name = "gbCPBookArticleRequired";
            gbCPBookArticleRequired.Size = new Size(488, 548);
            gbCPBookArticleRequired.TabIndex = 0;
            gbCPBookArticleRequired.TabStop = false;
            gbCPBookArticleRequired.Text = "Обязательные поля";
            // 
            // label130
            // 
            label130.AutoSize = true;
            label130.Location = new Point(10, 495);
            label130.Name = "label130";
            label130.Size = new Size(63, 15);
            label130.TabIndex = 20;
            label130.Text = "Страницы";
            // 
            // textBox129
            // 
            textBox129.Location = new Point(10, 515);
            textBox129.Name = "textBox129";
            textBox129.Size = new Size(450, 23);
            textBox129.TabIndex = 21;
            // 
            // label129
            // 
            label129.AutoSize = true;
            label129.Location = new Point(10, 448);
            label129.Name = "label129";
            label129.Size = new Size(73, 15);
            label129.TabIndex = 18;
            label129.Text = "Год издания";
            // 
            // textBox128
            // 
            textBox128.Location = new Point(10, 468);
            textBox128.Name = "textBox128";
            textBox128.Size = new Size(450, 23);
            textBox128.TabIndex = 19;
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.Location = new Point(10, 186);
            label123.Name = "label123";
            label123.Size = new Size(92, 15);
            label123.TabIndex = 14;
            label123.Text = "Автор(ы) книги";
            // 
            // textBox122
            // 
            textBox122.Location = new Point(10, 206);
            textBox122.Name = "textBox122";
            textBox122.Size = new Size(350, 23);
            textBox122.TabIndex = 15;
            // 
            // button12
            // 
            button12.Location = new Point(370, 206);
            button12.Name = "button12";
            button12.Size = new Size(90, 23);
            button12.TabIndex = 16;
            button12.Text = "Добавить";
            button12.UseVisualStyleBackColor = true;
            // 
            // listBox11
            // 
            listBox11.ItemHeight = 15;
            listBox11.Location = new Point(10, 236);
            listBox11.Name = "listBox11";
            listBox11.Size = new Size(450, 64);
            listBox11.TabIndex = 17;
            // 
            // label121
            // 
            label121.AutoSize = true;
            label121.Location = new Point(10, 20);
            label121.Name = "label121";
            label121.Size = new Size(95, 15);
            label121.TabIndex = 0;
            label121.Text = "Автор(ы) статьи";
            // 
            // textBox120
            // 
            textBox120.Location = new Point(10, 40);
            textBox120.Name = "textBox120";
            textBox120.Size = new Size(350, 23);
            textBox120.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(370, 40);
            button7.Name = "button7";
            button7.Size = new Size(90, 23);
            button7.TabIndex = 2;
            button7.Text = "Добавить";
            button7.UseVisualStyleBackColor = true;
            // 
            // listBox5
            // 
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(10, 70);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(450, 64);
            listBox5.TabIndex = 3;
            // 
            // label122
            // 
            label122.AutoSize = true;
            label122.Location = new Point(10, 140);
            label122.Name = "label122";
            label122.Size = new Size(95, 15);
            label122.TabIndex = 4;
            label122.Text = "Заглавие статьи";
            // 
            // textBox121
            // 
            textBox121.Location = new Point(10, 160);
            textBox121.Name = "textBox121";
            textBox121.Size = new Size(450, 23);
            textBox121.TabIndex = 5;
            // 
            // label124
            // 
            label124.AutoSize = true;
            label124.Location = new Point(10, 303);
            label124.Name = "label124";
            label124.Size = new Size(92, 15);
            label124.TabIndex = 8;
            label124.Text = "Заглавие книги";
            // 
            // textBox123
            // 
            textBox123.Location = new Point(10, 323);
            textBox123.Name = "textBox123";
            textBox123.Size = new Size(450, 23);
            textBox123.TabIndex = 9;
            // 
            // label125
            // 
            label125.AutoSize = true;
            label125.Location = new Point(10, 353);
            label125.Name = "label125";
            label125.Size = new Size(89, 15);
            label125.TabIndex = 10;
            label125.Text = "Место издания";
            // 
            // textBox124
            // 
            textBox124.Location = new Point(10, 373);
            textBox124.Name = "textBox124";
            textBox124.Size = new Size(450, 23);
            textBox124.TabIndex = 11;
            // 
            // label126
            // 
            label126.AutoSize = true;
            label126.Location = new Point(10, 403);
            label126.Name = "label126";
            label126.Size = new Size(81, 15);
            label126.TabIndex = 12;
            label126.Text = "Издательство";
            // 
            // textBox125
            // 
            textBox125.Location = new Point(10, 423);
            textBox125.Name = "textBox125";
            textBox125.Size = new Size(450, 23);
            textBox125.TabIndex = 13;
            // 
            // gbCPBookArticleOptional
            // 
            gbCPBookArticleOptional.Controls.Add(label127);
            gbCPBookArticleOptional.Controls.Add(textBox126);
            gbCPBookArticleOptional.Controls.Add(label128);
            gbCPBookArticleOptional.Controls.Add(textBox127);
            gbCPBookArticleOptional.Location = new Point(10, 564);
            gbCPBookArticleOptional.Name = "gbCPBookArticleOptional";
            gbCPBookArticleOptional.Size = new Size(488, 154);
            gbCPBookArticleOptional.TabIndex = 1;
            gbCPBookArticleOptional.TabStop = false;
            gbCPBookArticleOptional.Text = "Необязательные поля";
            // 
            // label127
            // 
            label127.AutoSize = true;
            label127.Location = new Point(10, 20);
            label127.Name = "label127";
            label127.Size = new Size(123, 15);
            label127.TabIndex = 0;
            label127.Text = "Вид документа книги";
            // 
            // textBox126
            // 
            textBox126.Location = new Point(10, 40);
            textBox126.Name = "textBox126";
            textBox126.Size = new Size(450, 23);
            textBox126.TabIndex = 1;
            // 
            // label128
            // 
            label128.AutoSize = true;
            label128.Location = new Point(10, 70);
            label128.Name = "label128";
            label128.Size = new Size(92, 15);
            label128.TabIndex = 2;
            label128.Text = "Редактор книги";
            // 
            // textBox127
            // 
            textBox127.Location = new Point(10, 90);
            textBox127.Name = "textBox127";
            textBox127.Size = new Size(450, 23);
            textBox127.TabIndex = 3;
            // 
            // tpCPJournalArticle
            // 
            tpCPJournalArticle.BackColor = SystemColors.Control;
            tpCPJournalArticle.Controls.Add(gbCPJournalArticleRequired);
            tpCPJournalArticle.Controls.Add(gbCPJournalArticleOptional);
            tpCPJournalArticle.Location = new Point(4, 24);
            tpCPJournalArticle.Name = "tpCPJournalArticle";
            tpCPJournalArticle.Padding = new Padding(3);
            tpCPJournalArticle.Size = new Size(505, 724);
            tpCPJournalArticle.TabIndex = 1;
            tpCPJournalArticle.Text = "Статья из журнала";
            // 
            // gbCPJournalArticleRequired
            // 
            gbCPJournalArticleRequired.Controls.Add(label96);
            gbCPJournalArticleRequired.Controls.Add(textBox95);
            gbCPJournalArticleRequired.Controls.Add(button9);
            gbCPJournalArticleRequired.Controls.Add(listBox8);
            gbCPJournalArticleRequired.Controls.Add(label104);
            gbCPJournalArticleRequired.Controls.Add(textBox103);
            gbCPJournalArticleRequired.Controls.Add(label106);
            gbCPJournalArticleRequired.Controls.Add(textBox105);
            gbCPJournalArticleRequired.Controls.Add(label107);
            gbCPJournalArticleRequired.Controls.Add(textBox106);
            gbCPJournalArticleRequired.Controls.Add(label108);
            gbCPJournalArticleRequired.Controls.Add(textBox107);
            gbCPJournalArticleRequired.Controls.Add(label109);
            gbCPJournalArticleRequired.Controls.Add(textBox108);
            gbCPJournalArticleRequired.Location = new Point(10, 10);
            gbCPJournalArticleRequired.Name = "gbCPJournalArticleRequired";
            gbCPJournalArticleRequired.Size = new Size(488, 396);
            gbCPJournalArticleRequired.TabIndex = 2;
            gbCPJournalArticleRequired.TabStop = false;
            gbCPJournalArticleRequired.Text = "Обязательные поля";
            // 
            // label96
            // 
            label96.AutoSize = true;
            label96.Location = new Point(10, 20);
            label96.Name = "label96";
            label96.Size = new Size(57, 15);
            label96.TabIndex = 0;
            label96.Text = "Автор(ы)";
            // 
            // textBox95
            // 
            textBox95.Location = new Point(10, 40);
            textBox95.Name = "textBox95";
            textBox95.Size = new Size(350, 23);
            textBox95.TabIndex = 1;
            // 
            // button9
            // 
            button9.Location = new Point(370, 40);
            button9.Name = "button9";
            button9.Size = new Size(90, 23);
            button9.TabIndex = 2;
            button9.Text = "Добавить";
            button9.UseVisualStyleBackColor = true;
            // 
            // listBox8
            // 
            listBox8.ItemHeight = 15;
            listBox8.Location = new Point(10, 70);
            listBox8.Name = "listBox8";
            listBox8.Size = new Size(450, 64);
            listBox8.TabIndex = 3;
            // 
            // label104
            // 
            label104.AutoSize = true;
            label104.Location = new Point(10, 140);
            label104.Name = "label104";
            label104.Size = new Size(95, 15);
            label104.TabIndex = 4;
            label104.Text = "Заглавие статьи";
            // 
            // textBox103
            // 
            textBox103.Location = new Point(10, 160);
            textBox103.Name = "textBox103";
            textBox103.Size = new Size(450, 23);
            textBox103.TabIndex = 5;
            // 
            // label106
            // 
            label106.AutoSize = true;
            label106.Location = new Point(10, 190);
            label106.Name = "label106";
            label106.Size = new Size(110, 15);
            label106.TabIndex = 6;
            label106.Text = "Название журнала";
            // 
            // textBox105
            // 
            textBox105.Location = new Point(10, 210);
            textBox105.Name = "textBox105";
            textBox105.Size = new Size(450, 23);
            textBox105.TabIndex = 7;
            // 
            // label107
            // 
            label107.AutoSize = true;
            label107.Location = new Point(10, 240);
            label107.Name = "label107";
            label107.Size = new Size(26, 15);
            label107.TabIndex = 8;
            label107.Text = "Год";
            // 
            // textBox106
            // 
            textBox106.Location = new Point(10, 260);
            textBox106.Name = "textBox106";
            textBox106.Size = new Size(450, 23);
            textBox106.TabIndex = 9;
            // 
            // label108
            // 
            label108.AutoSize = true;
            label108.Location = new Point(10, 290);
            label108.Name = "label108";
            label108.Size = new Size(96, 15);
            label108.TabIndex = 10;
            label108.Text = "Номер журнала";
            // 
            // textBox107
            // 
            textBox107.Location = new Point(10, 310);
            textBox107.Name = "textBox107";
            textBox107.Size = new Size(450, 23);
            textBox107.TabIndex = 11;
            // 
            // label109
            // 
            label109.AutoSize = true;
            label109.Location = new Point(10, 340);
            label109.Name = "label109";
            label109.Size = new Size(63, 15);
            label109.TabIndex = 12;
            label109.Text = "Страницы";
            // 
            // textBox108
            // 
            textBox108.Location = new Point(10, 360);
            textBox108.Name = "textBox108";
            textBox108.Size = new Size(450, 23);
            textBox108.TabIndex = 13;
            // 
            // gbCPJournalArticleOptional
            // 
            gbCPJournalArticleOptional.Controls.Add(label110);
            gbCPJournalArticleOptional.Controls.Add(textBox109);
            gbCPJournalArticleOptional.Location = new Point(10, 412);
            gbCPJournalArticleOptional.Name = "gbCPJournalArticleOptional";
            gbCPJournalArticleOptional.Size = new Size(488, 300);
            gbCPJournalArticleOptional.TabIndex = 3;
            gbCPJournalArticleOptional.TabStop = false;
            gbCPJournalArticleOptional.Text = "Необязательные поля";
            // 
            // label110
            // 
            label110.AutoSize = true;
            label110.Location = new Point(10, 20);
            label110.Name = "label110";
            label110.Size = new Size(27, 15);
            label110.TabIndex = 0;
            label110.Text = "DOI";
            // 
            // textBox109
            // 
            textBox109.Location = new Point(10, 40);
            textBox109.Name = "textBox109";
            textBox109.Size = new Size(450, 23);
            textBox109.TabIndex = 1;
            // 
            // tpCPNewspaperArticle
            // 
            tpCPNewspaperArticle.BackColor = SystemColors.Control;
            tpCPNewspaperArticle.Controls.Add(gbCPNewspaperArticleReqired);
            tpCPNewspaperArticle.Controls.Add(gbCPNewspaperArticleOptional);
            tpCPNewspaperArticle.Location = new Point(4, 24);
            tpCPNewspaperArticle.Name = "tpCPNewspaperArticle";
            tpCPNewspaperArticle.Padding = new Padding(3);
            tpCPNewspaperArticle.Size = new Size(505, 724);
            tpCPNewspaperArticle.TabIndex = 2;
            tpCPNewspaperArticle.Text = "Статья из газеты";
            // 
            // gbCPNewspaperArticleReqired
            // 
            gbCPNewspaperArticleReqired.Controls.Add(label137);
            gbCPNewspaperArticleReqired.Controls.Add(textBox136);
            gbCPNewspaperArticleReqired.Controls.Add(button10);
            gbCPNewspaperArticleReqired.Controls.Add(listBox9);
            gbCPNewspaperArticleReqired.Controls.Add(label138);
            gbCPNewspaperArticleReqired.Controls.Add(textBox137);
            gbCPNewspaperArticleReqired.Controls.Add(label139);
            gbCPNewspaperArticleReqired.Controls.Add(textBox138);
            gbCPNewspaperArticleReqired.Controls.Add(label140);
            gbCPNewspaperArticleReqired.Controls.Add(textBox139);
            gbCPNewspaperArticleReqired.Controls.Add(label141);
            gbCPNewspaperArticleReqired.Controls.Add(textBox140);
            gbCPNewspaperArticleReqired.Controls.Add(label142);
            gbCPNewspaperArticleReqired.Controls.Add(textBox141);
            gbCPNewspaperArticleReqired.Location = new Point(10, 10);
            gbCPNewspaperArticleReqired.Name = "gbCPNewspaperArticleReqired";
            gbCPNewspaperArticleReqired.Size = new Size(488, 391);
            gbCPNewspaperArticleReqired.TabIndex = 2;
            gbCPNewspaperArticleReqired.TabStop = false;
            gbCPNewspaperArticleReqired.Text = "Обязательные поля";
            // 
            // label137
            // 
            label137.AutoSize = true;
            label137.Location = new Point(10, 20);
            label137.Name = "label137";
            label137.Size = new Size(57, 15);
            label137.TabIndex = 0;
            label137.Text = "Автор(ы)";
            // 
            // textBox136
            // 
            textBox136.Location = new Point(10, 40);
            textBox136.Name = "textBox136";
            textBox136.Size = new Size(350, 23);
            textBox136.TabIndex = 1;
            // 
            // button10
            // 
            button10.Location = new Point(370, 40);
            button10.Name = "button10";
            button10.Size = new Size(90, 23);
            button10.TabIndex = 2;
            button10.Text = "Добавить";
            button10.UseVisualStyleBackColor = true;
            // 
            // listBox9
            // 
            listBox9.ItemHeight = 15;
            listBox9.Location = new Point(10, 70);
            listBox9.Name = "listBox9";
            listBox9.Size = new Size(450, 64);
            listBox9.TabIndex = 3;
            // 
            // label138
            // 
            label138.AutoSize = true;
            label138.Location = new Point(10, 140);
            label138.Name = "label138";
            label138.Size = new Size(95, 15);
            label138.TabIndex = 4;
            label138.Text = "Заглавие статьи";
            // 
            // textBox137
            // 
            textBox137.Location = new Point(10, 160);
            textBox137.Name = "textBox137";
            textBox137.Size = new Size(450, 23);
            textBox137.TabIndex = 5;
            // 
            // label139
            // 
            label139.AutoSize = true;
            label139.Location = new Point(10, 190);
            label139.Name = "label139";
            label139.Size = new Size(98, 15);
            label139.TabIndex = 6;
            label139.Text = "Название газеты";
            // 
            // textBox138
            // 
            textBox138.Location = new Point(10, 210);
            textBox138.Name = "textBox138";
            textBox138.Size = new Size(450, 23);
            textBox138.TabIndex = 7;
            // 
            // label140
            // 
            label140.AutoSize = true;
            label140.Location = new Point(10, 240);
            label140.Name = "label140";
            label140.Size = new Size(26, 15);
            label140.TabIndex = 8;
            label140.Text = "Год";
            // 
            // textBox139
            // 
            textBox139.Location = new Point(10, 260);
            textBox139.Name = "textBox139";
            textBox139.Size = new Size(450, 23);
            textBox139.TabIndex = 9;
            // 
            // label141
            // 
            label141.AutoSize = true;
            label141.Location = new Point(10, 290);
            label141.Name = "label141";
            label141.Size = new Size(81, 15);
            label141.TabIndex = 10;
            label141.Text = "Дата выпуска";
            // 
            // textBox140
            // 
            textBox140.Location = new Point(10, 310);
            textBox140.Name = "textBox140";
            textBox140.Size = new Size(450, 23);
            textBox140.TabIndex = 11;
            // 
            // label142
            // 
            label142.AutoSize = true;
            label142.Location = new Point(10, 336);
            label142.Name = "label142";
            label142.Size = new Size(63, 15);
            label142.TabIndex = 12;
            label142.Text = "Страницы";
            // 
            // textBox141
            // 
            textBox141.Location = new Point(10, 356);
            textBox141.Name = "textBox141";
            textBox141.Size = new Size(450, 23);
            textBox141.TabIndex = 13;
            // 
            // gbCPNewspaperArticleOptional
            // 
            gbCPNewspaperArticleOptional.Controls.Add(label143);
            gbCPNewspaperArticleOptional.Controls.Add(textBox142);
            gbCPNewspaperArticleOptional.Controls.Add(label144);
            gbCPNewspaperArticleOptional.Controls.Add(textBox143);
            gbCPNewspaperArticleOptional.Location = new Point(10, 407);
            gbCPNewspaperArticleOptional.Name = "gbCPNewspaperArticleOptional";
            gbCPNewspaperArticleOptional.Size = new Size(488, 311);
            gbCPNewspaperArticleOptional.TabIndex = 3;
            gbCPNewspaperArticleOptional.TabStop = false;
            gbCPNewspaperArticleOptional.Text = "Необязательные поля";
            // 
            // label143
            // 
            label143.AutoSize = true;
            label143.Location = new Point(10, 20);
            label143.Name = "label143";
            label143.Size = new Size(175, 15);
            label143.TabIndex = 0;
            label143.Text = "Дополнительная информация";
            // 
            // textBox142
            // 
            textBox142.Location = new Point(10, 40);
            textBox142.Name = "textBox142";
            textBox142.Size = new Size(450, 23);
            textBox142.TabIndex = 1;
            // 
            // label144
            // 
            label144.AutoSize = true;
            label144.Location = new Point(10, 70);
            label144.Name = "label144";
            label144.Size = new Size(131, 15);
            label144.TabIndex = 2;
            label144.Text = "Записал (интервьюер)";
            // 
            // textBox143
            // 
            textBox143.Location = new Point(10, 90);
            textBox143.Name = "textBox143";
            textBox143.Size = new Size(450, 23);
            textBox143.TabIndex = 3;
            // 
            // tpCPWebsiteArticle
            // 
            tpCPWebsiteArticle.BackColor = SystemColors.Control;
            tpCPWebsiteArticle.Controls.Add(gbCPWebsiteArticleRequired);
            tpCPWebsiteArticle.Controls.Add(gbCPWebsiteArticleOptional);
            tpCPWebsiteArticle.Location = new Point(4, 24);
            tpCPWebsiteArticle.Name = "tpCPWebsiteArticle";
            tpCPWebsiteArticle.Padding = new Padding(3);
            tpCPWebsiteArticle.Size = new Size(505, 724);
            tpCPWebsiteArticle.TabIndex = 3;
            tpCPWebsiteArticle.Text = "Статья с сайта";
            // 
            // gbCPWebsiteArticleRequired
            // 
            gbCPWebsiteArticleRequired.Controls.Add(label150);
            gbCPWebsiteArticleRequired.Controls.Add(textBox149);
            gbCPWebsiteArticleRequired.Controls.Add(button11);
            gbCPWebsiteArticleRequired.Controls.Add(listBox10);
            gbCPWebsiteArticleRequired.Controls.Add(label151);
            gbCPWebsiteArticleRequired.Controls.Add(textBox150);
            gbCPWebsiteArticleRequired.Controls.Add(label152);
            gbCPWebsiteArticleRequired.Controls.Add(textBox151);
            gbCPWebsiteArticleRequired.Controls.Add(label153);
            gbCPWebsiteArticleRequired.Controls.Add(textBox152);
            gbCPWebsiteArticleRequired.Controls.Add(label154);
            gbCPWebsiteArticleRequired.Controls.Add(textBox153);
            gbCPWebsiteArticleRequired.Location = new Point(10, 10);
            gbCPWebsiteArticleRequired.Name = "gbCPWebsiteArticleRequired";
            gbCPWebsiteArticleRequired.Size = new Size(488, 345);
            gbCPWebsiteArticleRequired.TabIndex = 2;
            gbCPWebsiteArticleRequired.TabStop = false;
            gbCPWebsiteArticleRequired.Text = "Обязательные поля";
            // 
            // label150
            // 
            label150.AutoSize = true;
            label150.Location = new Point(10, 20);
            label150.Name = "label150";
            label150.Size = new Size(57, 15);
            label150.TabIndex = 0;
            label150.Text = "Автор(ы)";
            // 
            // textBox149
            // 
            textBox149.Location = new Point(10, 40);
            textBox149.Name = "textBox149";
            textBox149.Size = new Size(350, 23);
            textBox149.TabIndex = 1;
            // 
            // button11
            // 
            button11.Location = new Point(370, 40);
            button11.Name = "button11";
            button11.Size = new Size(90, 23);
            button11.TabIndex = 2;
            button11.Text = "Добавить";
            button11.UseVisualStyleBackColor = true;
            // 
            // listBox10
            // 
            listBox10.ItemHeight = 15;
            listBox10.Location = new Point(10, 70);
            listBox10.Name = "listBox10";
            listBox10.Size = new Size(450, 64);
            listBox10.TabIndex = 3;
            // 
            // label151
            // 
            label151.AutoSize = true;
            label151.Location = new Point(10, 140);
            label151.Name = "label151";
            label151.Size = new Size(95, 15);
            label151.TabIndex = 4;
            label151.Text = "Заглавие статьи";
            // 
            // textBox150
            // 
            textBox150.Location = new Point(10, 160);
            textBox150.Name = "textBox150";
            textBox150.Size = new Size(450, 23);
            textBox150.TabIndex = 5;
            // 
            // label152
            // 
            label152.AutoSize = true;
            label152.Location = new Point(10, 190);
            label152.Name = "label152";
            label152.Size = new Size(92, 15);
            label152.TabIndex = 6;
            label152.Text = "Название сайта";
            // 
            // textBox151
            // 
            textBox151.Location = new Point(10, 210);
            textBox151.Name = "textBox151";
            textBox151.Size = new Size(450, 23);
            textBox151.TabIndex = 7;
            // 
            // label153
            // 
            label153.AutoSize = true;
            label153.Location = new Point(10, 240);
            label153.Name = "label153";
            label153.Size = new Size(28, 15);
            label153.TabIndex = 8;
            label153.Text = "URL";
            // 
            // textBox152
            // 
            textBox152.Location = new Point(10, 260);
            textBox152.Name = "textBox152";
            textBox152.Size = new Size(450, 23);
            textBox152.TabIndex = 9;
            // 
            // label154
            // 
            label154.AutoSize = true;
            label154.Location = new Point(10, 290);
            label154.Name = "label154";
            label154.Size = new Size(99, 15);
            label154.TabIndex = 10;
            label154.Text = "Дата обращения";
            // 
            // textBox153
            // 
            textBox153.Location = new Point(10, 310);
            textBox153.Name = "textBox153";
            textBox153.Size = new Size(450, 23);
            textBox153.TabIndex = 11;
            // 
            // gbCPWebsiteArticleOptional
            // 
            gbCPWebsiteArticleOptional.Controls.Add(label156);
            gbCPWebsiteArticleOptional.Controls.Add(textBox155);
            gbCPWebsiteArticleOptional.Controls.Add(label157);
            gbCPWebsiteArticleOptional.Controls.Add(textBox156);
            gbCPWebsiteArticleOptional.Controls.Add(label158);
            gbCPWebsiteArticleOptional.Controls.Add(textBox157);
            gbCPWebsiteArticleOptional.Controls.Add(label159);
            gbCPWebsiteArticleOptional.Controls.Add(textBox158);
            gbCPWebsiteArticleOptional.Location = new Point(10, 361);
            gbCPWebsiteArticleOptional.Name = "gbCPWebsiteArticleOptional";
            gbCPWebsiteArticleOptional.Size = new Size(488, 357);
            gbCPWebsiteArticleOptional.TabIndex = 3;
            gbCPWebsiteArticleOptional.TabStop = false;
            gbCPWebsiteArticleOptional.Text = "Необязательные поля";
            // 
            // label156
            // 
            label156.AutoSize = true;
            label156.Location = new Point(10, 20);
            label156.Name = "label156";
            label156.Size = new Size(60, 15);
            label156.TabIndex = 0;
            label156.Text = "Вид сайта";
            // 
            // textBox155
            // 
            textBox155.Location = new Point(10, 40);
            textBox155.Name = "textBox155";
            textBox155.Size = new Size(450, 23);
            textBox155.TabIndex = 1;
            // 
            // label157
            // 
            label157.AutoSize = true;
            label157.Location = new Point(10, 70);
            label157.Name = "label157";
            label157.Size = new Size(96, 15);
            label157.TabIndex = 2;
            label157.Text = "Год публикации";
            // 
            // textBox156
            // 
            textBox156.Location = new Point(10, 90);
            textBox156.Name = "textBox156";
            textBox156.Size = new Size(450, 23);
            textBox156.TabIndex = 3;
            // 
            // label158
            // 
            label158.AutoSize = true;
            label158.Location = new Point(10, 120);
            label158.Name = "label158";
            label158.Size = new Size(102, 15);
            label158.TabIndex = 4;
            label158.Text = "Дата публикации";
            // 
            // textBox157
            // 
            textBox157.Location = new Point(10, 140);
            textBox157.Name = "textBox157";
            textBox157.Size = new Size(450, 23);
            textBox157.TabIndex = 5;
            // 
            // label159
            // 
            label159.AutoSize = true;
            label159.Location = new Point(10, 170);
            label159.Name = "label159";
            label159.Size = new Size(175, 15);
            label159.TabIndex = 6;
            label159.Text = "Дополнительная информация";
            // 
            // textBox158
            // 
            textBox158.Location = new Point(10, 190);
            textBox158.Name = "textBox158";
            textBox158.Size = new Size(450, 23);
            textBox158.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 847);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tcCategories.ResumeLayout(false);
            tpSingleVolume.ResumeLayout(false);
            tcSVTypes.ResumeLayout(false);
            tpSVBook.ResumeLayout(false);
            gpSVBookRequired.ResumeLayout(false);
            gpSVBookRequired.PerformLayout();
            gpSVBookOptional.ResumeLayout(false);
            panelSVBookOptional.ResumeLayout(false);
            panelSVBookOptional.PerformLayout();
            tpSVRegulatoryDocument.ResumeLayout(false);
            gbSVRegulatoryDocumentRequired.ResumeLayout(false);
            gbSVRegulatoryDocumentRequired.PerformLayout();
            gbSVRegulatoryDocumentOptional.ResumeLayout(false);
            panelSVRegulatoryDocumentOptional.ResumeLayout(false);
            panelSVRegulatoryDocumentOptional.PerformLayout();
            tpSVDissertationAbstract.ResumeLayout(false);
            gbSVDissertationAbstractRequired.ResumeLayout(false);
            gbSVDissertationAbstractRequired.PerformLayout();
            gbSVDissertationAbstractOptional.ResumeLayout(false);
            gbSVDissertationAbstractOptional.PerformLayout();
            tpSVDissertation.ResumeLayout(false);
            gbSVDissertationRequired.ResumeLayout(false);
            gbSVDissertationRequired.PerformLayout();
            gbSVDissertationOptional.ResumeLayout(false);
            gbSVDissertationOptional.PerformLayout();
            tpMultiVolume.ResumeLayout(false);
            tcMVTypes.ResumeLayout(false);
            tpMVWholeMultivolume.ResumeLayout(false);
            gbMVWholeMultivolumeRequired.ResumeLayout(false);
            gbMVWholeMultivolumeRequired.PerformLayout();
            gbMVWholeMultivolumeOptional.ResumeLayout(false);
            panelMVWholeMultivolumeOptional.ResumeLayout(false);
            panelMVWholeMultivolumeOptional.PerformLayout();
            tpMVSeparateVolume.ResumeLayout(false);
            gbMVSeparateVolumeRequired.ResumeLayout(false);
            gbMVSeparateVolumeRequired.PerformLayout();
            gbMVSeparateVolumeOptional.ResumeLayout(false);
            panelMVSeparateVolumeOptional.ResumeLayout(false);
            panelMVSeparateVolumeOptional.PerformLayout();
            tpElectronicResources.ResumeLayout(false);
            tcERTypes.ResumeLayout(false);
            tpEREbook.ResumeLayout(false);
            gbEREbookRequired.ResumeLayout(false);
            gbEREbookRequired.PerformLayout();
            gbEREbookOptional.ResumeLayout(false);
            panelEREbookOptional.ResumeLayout(false);
            panelEREbookOptional.PerformLayout();
            tpERMultimediaEdition.ResumeLayout(false);
            gbERMultimediaEditionRequired.ResumeLayout(false);
            gbERMultimediaEditionRequired.PerformLayout();
            gbERMultimediaEditionOptional.ResumeLayout(false);
            panelERMultimediaEditionOptional.ResumeLayout(false);
            panelERMultimediaEditionOptional.PerformLayout();
            tpEREjournalArticle.ResumeLayout(false);
            gbEREjournalArticleReqired.ResumeLayout(false);
            gbEREjournalArticleReqired.PerformLayout();
            gbEREjournalArticleOptional.ResumeLayout(false);
            gbEREjournalArticleOptional.PerformLayout();
            tpERWebsite.ResumeLayout(false);
            gbERWebsiteRequired.ResumeLayout(false);
            gbERWebsiteRequired.PerformLayout();
            gbERWebsiteOptional.ResumeLayout(false);
            gbERWebsiteOptional.PerformLayout();
            tpConstituentParts.ResumeLayout(false);
            tcCPTypes.ResumeLayout(false);
            tpCPBookArticle.ResumeLayout(false);
            gbCPBookArticleRequired.ResumeLayout(false);
            gbCPBookArticleRequired.PerformLayout();
            gbCPBookArticleOptional.ResumeLayout(false);
            gbCPBookArticleOptional.PerformLayout();
            tpCPJournalArticle.ResumeLayout(false);
            gbCPJournalArticleRequired.ResumeLayout(false);
            gbCPJournalArticleRequired.PerformLayout();
            gbCPJournalArticleOptional.ResumeLayout(false);
            gbCPJournalArticleOptional.PerformLayout();
            tpCPNewspaperArticle.ResumeLayout(false);
            gbCPNewspaperArticleReqired.ResumeLayout(false);
            gbCPNewspaperArticleReqired.PerformLayout();
            gbCPNewspaperArticleOptional.ResumeLayout(false);
            gbCPNewspaperArticleOptional.PerformLayout();
            tpCPWebsiteArticle.ResumeLayout(false);
            gbCPWebsiteArticleRequired.ResumeLayout(false);
            gbCPWebsiteArticleRequired.PerformLayout();
            gbCPWebsiteArticleOptional.ResumeLayout(false);
            gbCPWebsiteArticleOptional.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox gbSVRegulatoryDocumentRequired;
        private Label labelSVRDTitle;
        private TextBox textBox2;
        private Label labelSVRDPublishingLocation;
        private TextBox textBox3;
        private Label labelSVRDPublisher;
        private TextBox textBox4;
        private Label labelSVRDPublishYear;
        private TextBox textBox5;
        private GroupBox gbSVRegulatoryDocumentOptional;
        private Label labelSVRDDocumentType;
        private TextBox textBox7;
        private Label labelSVRDApprovalDate;
        private TextBox textBox8;
        private Label labelSVRDImplementDate;
        private TextBox textBox9;
        private Label labelSVRDDeveloper;
        private TextBox textBox10;
        private Label labelSVRDISBN;
        private TextBox textBox11;
        private Label labelSVRDTitleTranslation;
        private TextBox textBox12;
        private Label labelSVRDOfficialEdition;
        private TextBox textBox13;
        private TabPage tpSVDissertationAbstract;
        private TabPage tpSVDissertation;
        private Label labelSVRDDocumentNumber;
        private TextBox textBox1;
        private Label labelSVRDPagesCount;
        private TextBox textBox6;
        private Label labelSVRDCountry;
        private TextBox textBox16;
        private Label labelSVRDAdditions;
        private TextBox textBox15;
        private Label labelSVRDAbbreviation;
        private TextBox textBox14;
        private GroupBox gbSVDissertationAbstractRequired;
        private Label label17;
        private TextBox textBox17;
        private Label label18;
        private TextBox textBox18;
        private Label label19;
        private TextBox textBox19;
        private Label label20;
        private TextBox textBox20;
        private Label label21;
        private TextBox textBox21;
        private GroupBox gbSVDissertationAbstractOptional;
        private Label label26;
        private TextBox textBox26;
        private Label label27;
        private TextBox textBox27;
        private Label label28;
        private TextBox textBox28;
        private Label label29;
        private TextBox textBox29;
        private ListBox listBox1;
        private Label label24;
        private TextBox textBox24;
        private Label label23;
        private TextBox textBox23;
        private Label label22;
        private TextBox textBox22;
        private GroupBox gbSVDissertationRequired;
        private Label label30;
        private TextBox textBox30;
        private Label label31;
        private TextBox textBox31;
        private Label label32;
        private TextBox textBox32;
        private Label label33;
        private TextBox textBox33;
        private Label label34;
        private TextBox textBox34;
        private Label label35;
        private TextBox textBox35;
        private Label label36;
        private TextBox textBox36;
        private GroupBox gbSVDissertationOptional;
        private Label label37;
        private TextBox textBox37;
        private Label label38;
        private TextBox textBox38;
        private Label label39;
        private TextBox textBox39;
        private Label label40;
        private TextBox textBox40;
        private Label label25;
        private Button button2;
        private Button button1;
        private TabControl tcCategories;
        private TabPage tpSingleVolume;
        private TabPage tpMultiVolume;
        private TabControl tcMVTypes;
        private TabPage tpMVWholeMultivolume;
        private GroupBox gbMVWholeMultivolumeOptional;
        private Label label47;
        private TextBox textBox46;
        private Label label48;
        private TextBox textBox47;
        private Label label49;
        private TextBox textBox48;
        private Label label50;
        private TextBox textBox49;
        private Label label51;
        private TextBox textBox50;
        private Label label52;
        private TextBox textBox51;
        private TabPage tpMVSeparateVolume;
        private TabPage tpElectronicResources;
        private TabPage tpConstituentParts;
        private GroupBox gbMVWholeMultivolumeRequired;
        private Label label53;
        private TextBox textBox52;
        private Label label41;
        private TextBox textBox25;
        private Button button4;
        private ListBox listBox2;
        private Label label42;
        private TextBox textBox41;
        private Label label43;
        private TextBox textBox42;
        private Label label44;
        private TextBox textBox43;
        private Label label45;
        private TextBox textBox44;
        private Label label46;
        private TextBox textBox45;
        private GroupBox gbMVSeparateVolumeRequired;
        private Label label54;
        private TextBox textBox53;
        private Label label55;
        private TextBox textBox54;
        private Button button5;
        private ListBox listBox3;
        private Label label56;
        private TextBox textBox55;
        private Label label57;
        private TextBox textBox56;
        private Label label58;
        private TextBox textBox57;
        private Label label59;
        private TextBox textBox58;
        private Label label60;
        private TextBox textBox59;
        private GroupBox gbMVSeparateVolumeOptional;
        private Label label61;
        private TextBox textBox60;
        private Label label62;
        private TextBox textBox61;
        private Label label63;
        private TextBox textBox62;
        private Label label64;
        private TextBox textBox63;
        private Label label65;
        private TextBox textBox64;
        private Label label66;
        private TextBox textBox65;
        private Label label68;
        private TextBox textBox67;
        private Label label67;
        private TextBox textBox66;
        private TabControl tcERTypes;
        private TabPage tpEREbook;
        private GroupBox gbEREbookRequired;
        private Label label69;
        private TextBox textBox68;
        private Button button6;
        private ListBox listBox4;
        private Label label70;
        private TextBox textBox69;
        private Label label71;
        private TextBox textBox70;
        private Label label72;
        private TextBox textBox71;
        private Label label73;
        private TextBox textBox72;
        private Label label74;
        private TextBox textBox73;
        private GroupBox gbEREbookOptional;
        private Label label75;
        private TextBox textBox74;
        private Label label76;
        private TextBox textBox75;
        private Label label77;
        private TextBox textBox76;
        private Label label78;
        private TextBox textBox77;
        private Label label79;
        private TextBox textBox78;
        private Label label80;
        private TextBox textBox79;
        private Label label81;
        private TextBox textBox80;
        private TabPage tpERMultimediaEdition;
        private TabPage tpEREjournalArticle;
        private TabPage tpERWebsite;
        private GroupBox gbERWebsiteRequired;
        private Label label112;
        private TextBox textBox111;
        private Label label113;
        private TextBox textBox112;
        private Label label114;
        private TextBox textBox113;
        private GroupBox gbERWebsiteOptional;
        private Label label117;
        private TextBox textBox116;
        private Label label118;
        private TextBox textBox117;
        private Label label119;
        private TextBox textBox118;
        private Label label120;
        private TextBox textBox119;
        private TabControl tcCPTypes;
        private TabPage tpCPBookArticle;
        private GroupBox gbCPBookArticleRequired;
        private Label label121;
        private TextBox textBox120;
        private Button button7;
        private ListBox listBox5;
        private Label label122;
        private TextBox textBox121;
        private Label label124;
        private TextBox textBox123;
        private Label label125;
        private TextBox textBox124;
        private Label label126;
        private TextBox textBox125;
        private GroupBox gbCPBookArticleOptional;
        private Label label127;
        private TextBox textBox126;
        private Label label128;
        private TextBox textBox127;
        private TabPage tpCPJournalArticle;
        private TabPage tpCPNewspaperArticle;
        private TabPage tpCPWebsiteArticle;
        private Label label173;
        private TextBox textBox172;
        private Label label174;
        private TextBox textBox173;
        private GroupBox gbERMultimediaEditionRequired;
        private Label label83;
        private TextBox textBox82;
        private Button button3;
        private ListBox listBox6;
        private Label label84;
        private TextBox textBox83;
        private Label label85;
        private TextBox textBox84;
        private Label label86;
        private TextBox textBox85;
        private Label label87;
        private TextBox textBox86;
        private Label label88;
        private TextBox textBox87;
        private GroupBox gbERMultimediaEditionOptional;
        private Label label90;
        private TextBox textBox89;
        private Label label91;
        private TextBox textBox90;
        private Label label92;
        private TextBox textBox91;
        private Label label93;
        private TextBox textBox92;
        private Label label94;
        private TextBox textBox93;
        private Label label95;
        private TextBox textBox94;
        private GroupBox gbEREjournalArticleReqired;
        private Label label97;
        private TextBox textBox96;
        private Label label98;
        private TextBox textBox97;
        private Button button8;
        private ListBox listBox7;
        private Label label99;
        private TextBox textBox98;
        private Label label100;
        private TextBox textBox99;
        private Label label101;
        private TextBox textBox100;
        private Label label102;
        private TextBox textBox101;
        private Label label103;
        private TextBox textBox102;
        private GroupBox gbEREjournalArticleOptional;
        private Label label105;
        private TextBox textBox104;
        private Label label82;
        private TextBox textBox81;
        private Label label89;
        private TextBox textBox88;
        private GroupBox gbCPJournalArticleRequired;
        private Label label96;
        private TextBox textBox95;
        private Button button9;
        private ListBox listBox8;
        private Label label104;
        private TextBox textBox103;
        private Label label106;
        private TextBox textBox105;
        private Label label107;
        private TextBox textBox106;
        private Label label108;
        private TextBox textBox107;
        private Label label109;
        private TextBox textBox108;
        private GroupBox gbCPJournalArticleOptional;
        private Label label110;
        private TextBox textBox109;
        private GroupBox gbCPNewspaperArticleReqired;
        private Label label137;
        private TextBox textBox136;
        private Button button10;
        private ListBox listBox9;
        private Label label138;
        private TextBox textBox137;
        private Label label139;
        private TextBox textBox138;
        private Label label140;
        private TextBox textBox139;
        private Label label141;
        private TextBox textBox140;
        private Label label142;
        private TextBox textBox141;
        private GroupBox gbCPNewspaperArticleOptional;
        private Label label143;
        private TextBox textBox142;
        private Label label144;
        private TextBox textBox143;
        private GroupBox gbCPWebsiteArticleRequired;
        private Label label150;
        private TextBox textBox149;
        private Button button11;
        private ListBox listBox10;
        private Label label151;
        private TextBox textBox150;
        private Label label152;
        private TextBox textBox151;
        private Label label153;
        private TextBox textBox152;
        private Label label154;
        private TextBox textBox153;
        private GroupBox gbCPWebsiteArticleOptional;
        private Label label156;
        private TextBox textBox155;
        private Label label157;
        private TextBox textBox156;
        private Label label158;
        private TextBox textBox157;
        private Label label159;
        private TextBox textBox158;
        private Label label130;
        private TextBox textBox129;
        private Label label129;
        private TextBox textBox128;
        private Label label123;
        private TextBox textBox122;
        private Button button12;
        private ListBox listBox11;
        private Panel panel1;
        private CheckBox cbWordAbbreviation;
        private Button buttonAddRecord;
        private Panel panelSVBookOptional;
        private Panel panelSVRegulatoryDocumentOptional;
        private Panel panelMVWholeMultivolumeOptional;
        private Panel panelMVSeparateVolumeOptional;
        private Panel panelEREbookOptional;
        private Panel panelERMultimediaEditionOptional;
    }
}
