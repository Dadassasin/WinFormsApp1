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
        private TextBox tbSVBAuthors;
        private Button buttonSVBAuthorsAdd;
        private ListBox lbSVBAuthors;

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
        private TextBox tbSVBTitle;
        private TextBox tbSVBPublishingLocation;
        private TextBox tbSVBPublisher;
        private TextBox tbSVBPublishYear;
        private TextBox tbSVBPagesCount;
        private TextBox tbSVBDocumentType;
        private TextBox tbSVBEditor;
        private TextBox tbSVBEditionNumber;
        private TextBox tbSVBSeries;
        private TextBox tbSVBISBN;
        private TextBox tbSVBTranslator;
        private TextBox tbSVBOrganization;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            button1 = new Button();
            panelRtbMLA = new Panel();
            rtbMLA = new RichTextBox();
            panelRtbGOST = new Panel();
            rtbGOST = new RichTextBox();
            panelConvertTitle = new Panel();
            labelConvert = new Label();
            labelGOST = new Label();
            labelMLA = new Label();
            buttonConvert = new Button();
            buttonPDFExportResult = new Button();
            buttonWordExportResult = new Button();
            buttonCopyResult = new Button();
            labelResult = new Label();
            lbResult = new ListBox();
            cmsListBox = new ContextMenuStrip(components);
            tsmiDeleteSelected = new ToolStripMenuItem();
            tsmiDeleteAll = new ToolStripMenuItem();
            tsmiCopy = new ToolStripMenuItem();
            panelAddRecord = new Panel();
            buttonAddRecord = new Button();
            cbWordAbbreviation = new CheckBox();
            tcCategories = new TabControl();
            tpSingleVolume = new TabPage();
            tcSVTypes = new TabControl();
            tpSVBook = new TabPage();
            gpSVBookRequired = new GroupBox();
            panelSVBookRequired = new Panel();
            cbSVBAuthors = new CheckBox();
            buttonSVBPublisherAdd = new Button();
            lbSVBPublisher = new ListBox();
            buttonSVBPublishingLocationAdd = new Button();
            lbSVBPublishingLocation = new ListBox();
            labelSVBAuthors = new Label();
            tbSVBAuthors = new TextBox();
            tbSVBPagesCount = new TextBox();
            buttonSVBAuthorsAdd = new Button();
            labelSVBPagesCount = new Label();
            lbSVBAuthors = new ListBox();
            tbSVBPublishYear = new TextBox();
            labelSVBTitle = new Label();
            labelSVBPublishYear = new Label();
            tbSVBTitle = new TextBox();
            tbSVBPublisher = new TextBox();
            labelSVBPublishingLocation = new Label();
            labelSVBPublisher = new Label();
            tbSVBPublishingLocation = new TextBox();
            gpSVBookOptional = new GroupBox();
            panelSVBookOptional = new Panel();
            cbSVBEditorType = new ComboBox();
            lbSVBEditor = new ListBox();
            buttonSVBEditorAdd = new Button();
            labelSVBParallelTitle = new Label();
            tbSVBParallelTitle = new TextBox();
            labelSVBContentType = new Label();
            tbSVBContentType = new TextBox();
            labelSVBDocumentType = new Label();
            tbSVBOrganization = new TextBox();
            tbSVBDocumentType = new TextBox();
            labelSVBEditor = new Label();
            tbSVBTranslator = new TextBox();
            labelSVBOrganization = new Label();
            tbSVBEditor = new TextBox();
            labelSVBTranslator = new Label();
            labelSVBEditionNumber = new Label();
            tbSVBISBN = new TextBox();
            tbSVBEditionNumber = new TextBox();
            labelSVBISBN = new Label();
            labelSVBSeries = new Label();
            tbSVBSeries = new TextBox();
            tpSVRegulatoryDocument = new TabPage();
            gbSVRegulatoryDocumentRequired = new GroupBox();
            labelSVRDDocumentNumber = new Label();
            tbSVRDDocumentNumber = new TextBox();
            labelSVRDTitle = new Label();
            tbSVRDTitle = new TextBox();
            labelSVRDPublishingLocation = new Label();
            tbSVRDPublishingLocation = new TextBox();
            labelSVRDPublisher = new Label();
            tbSVRDPublisher = new TextBox();
            labelSVRDPublishYear = new Label();
            tbSVRDPublishYear = new TextBox();
            gbSVRegulatoryDocumentOptional = new GroupBox();
            panelSVRegulatoryDocumentOptional = new Panel();
            labelSVRDCountry = new Label();
            labelSVRDDocumentType = new Label();
            tbSVRDCountry = new TextBox();
            tbSVRDOfficialEdition = new TextBox();
            labelSVRDAdditions = new Label();
            labelSVRDOfficialEdition = new Label();
            tbSVRDAdditions = new TextBox();
            tbSVRDTitleTranslation = new TextBox();
            labelSVRDAbbreviation = new Label();
            labelSVRDTitleTranslation = new Label();
            tbSVRDAbbreviation = new TextBox();
            tbSVRDISBN = new TextBox();
            labelSVRDPagesCount = new Label();
            labelSVRDISBN = new Label();
            tbSVRDPagesCount = new TextBox();
            tbSVRDDeveloper = new TextBox();
            labelSVRDDeveloper = new Label();
            tbSVRDDocumentType = new TextBox();
            tbSVRDImplementDate = new TextBox();
            labelSVRDApprovalDate = new Label();
            labelSVRDImplementDate = new Label();
            tbSVRDApprovalDate = new TextBox();
            tpSVDissertationAbstract = new TabPage();
            gbSVDissertationAbstractRequired = new GroupBox();
            panelSVDissertationAbstractRequired = new Panel();
            labelSVDADefenseLocation = new Label();
            labelSVDAAuthor = new Label();
            tbSVDADefenseLocation = new TextBox();
            tbSVDAPublishingLocation = new TextBox();
            labelSVDAPagesCount = new Label();
            labelSVDAPublishingLocation = new Label();
            tbSVDAPagesCount = new TextBox();
            tbSVDADegree = new TextBox();
            labelSVDAPublishYear = new Label();
            labelSVDADegree = new Label();
            tbSVDAPublishYear = new TextBox();
            tbSVDASpecialty = new TextBox();
            labelSVDATitle = new Label();
            labelSVDASpecialty = new Label();
            tbSVDATitle = new TextBox();
            tbSVDAAuthor = new TextBox();
            gbSVDissertationAbstractOptional = new GroupBox();
            labelSVDADocumentType = new Label();
            tbSVDADocumentType = new TextBox();
            labelSVDAAuthorFullName = new Label();
            tbSVDAAuthorFullName = new TextBox();
            labelSVDAOrganization = new Label();
            tbSVDAOrganization = new TextBox();
            labelSVDABibliography = new Label();
            tbSVDABibliography = new TextBox();
            tpSVDissertation = new TabPage();
            gbSVDissertationRequired = new GroupBox();
            panelSVDissertationRequired = new Panel();
            labelSVDPagesCount = new Label();
            labelSVDAuthor = new Label();
            tbSVDPagesCount = new TextBox();
            tbSVDPublishingLocation = new TextBox();
            labelSVDPublishYear = new Label();
            labelSVDPublishingLocation = new Label();
            tbSVDPublishYear = new TextBox();
            tbSVDDegree = new TextBox();
            labelSVDTitle = new Label();
            labelSVDDegree = new Label();
            tbSVDTitle = new TextBox();
            tbSVDSpecialty = new TextBox();
            labelSVDSpecialty = new Label();
            tbSVDAuthor = new TextBox();
            gbSVDissertationOptional = new GroupBox();
            labelSVDDocumentType = new Label();
            tbSVDDocumentType = new TextBox();
            labelSVDAuthorFullName = new Label();
            tbSVDAuthorFullName = new TextBox();
            labelSVDOrganization = new Label();
            tbSVDOrganization = new TextBox();
            labelSVDBibliography = new Label();
            tbSVDBibliography = new TextBox();
            tpMultiVolume = new TabPage();
            tcMVTypes = new TabControl();
            tpMVWholeMultivolume = new TabPage();
            gbMVWholeMultivolumeRequired = new GroupBox();
            panelMVWholeMultivolumeRequired = new Panel();
            labelMVWMPagesCount = new Label();
            labelMVWMAuthors = new Label();
            tbMVWMPagesCount = new TextBox();
            tbMVWMPublishYear = new TextBox();
            labelMVWMPublishYear = new Label();
            tbMVWMAuthors = new TextBox();
            tbMVWMPublisher = new TextBox();
            buttonMVWMAuthorsAdd = new Button();
            labelMVWMPublisher = new Label();
            lbMVWMAuthors = new ListBox();
            tbMVWMPublishingLocation = new TextBox();
            labelMVWMTitle = new Label();
            labelMVWMPublishingLocation = new Label();
            tbMVWMTitle = new TextBox();
            tbMVWMVolumesNumber = new TextBox();
            labelMVWMVolumesNumber = new Label();
            gbMVWholeMultivolumeOptional = new GroupBox();
            labelMVWMDocumentType = new Label();
            labelMVWMSeries = new Label();
            tbMVWMSeries = new TextBox();
            labelMVWMResponsibilityArea = new Label();
            tbMVWMResponsibilityArea = new TextBox();
            labelMVWMEditionNumber = new Label();
            labelMVWMEditor = new Label();
            tbMVWMDocumentType = new TextBox();
            labelMVWMISBN = new Label();
            tbMVWMEditionNumber = new TextBox();
            tbMVWMEditor = new TextBox();
            tbMVWMISBN = new TextBox();
            tpMVSeparateVolume = new TabPage();
            gbMVSeparateVolumeRequired = new GroupBox();
            panelMVSeparateVolumeRequired = new Panel();
            labelMVSVPagesCount = new Label();
            labelMVSVAuthors = new Label();
            tbMVSVPagesCount = new TextBox();
            tbMVSVPublishingLocation = new TextBox();
            labelMVSVPublishYear = new Label();
            labelMVSVPublishingLocation = new Label();
            tbMVSVPublishYear = new TextBox();
            tbMVSVVolumeTitle = new TextBox();
            labelMVSVPublisher = new Label();
            labelMVSVVolumeTitle = new Label();
            tbMVSVPublisher = new TextBox();
            tbMVSVVolumeNumber = new TextBox();
            labelMVSVVolumeNumber = new Label();
            tbMVSVAuthors = new TextBox();
            tbMVSVVolumesCount = new TextBox();
            buttonMVSVAuthorsAdd = new Button();
            labelMVSVVolumesCount = new Label();
            lbMVSVAuthors = new ListBox();
            tbMVSVTitle = new TextBox();
            labelMVSVTitle = new Label();
            gbMVSeparateVolumeOptional = new GroupBox();
            labelMVSVDocumentType = new Label();
            tbMVSVDocumentType = new TextBox();
            tbMVSVSeries = new TextBox();
            labelMVSVEditionNumber = new Label();
            labelMVSVEditor = new Label();
            tbMVSVISBN = new TextBox();
            tbMVSVResponsibilityArea = new TextBox();
            tbMVSVEditionNumber = new TextBox();
            labelMVSVSeries = new Label();
            labelMVSVResponsibilityArea = new Label();
            labelMVSVISBN = new Label();
            tbMVSVEditor = new TextBox();
            tpElectronicResources = new TabPage();
            tcERTypes = new TabControl();
            tpEREbook = new TabPage();
            gbEREbookRequired = new GroupBox();
            panelEREbookRequired = new Panel();
            labelEREbAccessDate = new Label();
            labelEREbAuthors = new Label();
            tbEREbAccessDate = new TextBox();
            tbEREbURL = new TextBox();
            labelEREbURL = new Label();
            tbEREbAuthors = new TextBox();
            tbEREbPublishYear = new TextBox();
            labelEREbAuthorsAdd = new Button();
            labelEREbPublishYear = new Label();
            lbEREbAuthors = new ListBox();
            tbEREbPublisher = new TextBox();
            labelEREbTitle = new Label();
            labelEREbPublisher = new Label();
            tbEREbTitle = new TextBox();
            tbEREbPublishingLocation = new TextBox();
            labelEREbPublishingLocation = new Label();
            gbEREbookOptional = new GroupBox();
            panelEREbookOptional = new Panel();
            labelEREbAccessMode = new Label();
            labelEREbISBN = new Label();
            tbEREbAccessMode = new TextBox();
            tbEREbISBN = new TextBox();
            labelEREbDocumentType = new Label();
            tbEREbSeries = new TextBox();
            tbEREbDocumentType = new TextBox();
            labelEREbSeries = new Label();
            labelEREbResponsibilityArea = new Label();
            tbEREbPagesCount = new TextBox();
            tbEREbResponsibilityArea = new TextBox();
            labelEREbPagesCount = new Label();
            labelEREbEditor = new Label();
            tbEREbEditionNumber = new TextBox();
            tbEREbEditor = new TextBox();
            labelEREbEditionNumber = new Label();
            tpERMultimediaEdition = new TabPage();
            gbERMultimediaEditionRequired = new GroupBox();
            panelERMultimediaEditionRequired = new Panel();
            labelERMEAuthors = new Label();
            tbERMEAuthors = new TextBox();
            tbERMEDataCarrier = new TextBox();
            buttonERMEAuthorsAdd = new Button();
            labelERMEDataCarrier = new Label();
            lbERMEAuthors = new ListBox();
            tbERMEPublishYear = new TextBox();
            labelERMETitle = new Label();
            labelERMEPublishYear = new Label();
            tbERMETitle = new TextBox();
            tbERMEPublisher = new TextBox();
            labelERMEPublishingLocation = new Label();
            labelERMEPublisher = new Label();
            tbERMEPublishingLocation = new TextBox();
            gbERMultimediaEditionOptional = new GroupBox();
            labelERMEDocumentType = new Label();
            labelERMEResponsibilityArea = new Label();
            tbERMENotation = new TextBox();
            tbERMEDocumentType = new TextBox();
            labelERMEEditor = new Label();
            labelERMEOrganization = new Label();
            tbERMEResponsibilityArea = new TextBox();
            tbERMEISBN = new TextBox();
            labelERMENotation = new Label();
            tbERMEOrganization = new TextBox();
            labelERMEISBN = new Label();
            tbERMEEditor = new TextBox();
            tpEREjournalArticle = new TabPage();
            gbEREjournalArticleReqired = new GroupBox();
            panelEREjournalArticleReqired = new Panel();
            labelEREjAAccessDate = new Label();
            labelEREjAAuthors = new Label();
            tbEREjAAccessDate = new TextBox();
            tbEREjAPages = new TextBox();
            labelEREjAURL = new Label();
            labelEREjAPages = new Label();
            tbEREjAURL = new TextBox();
            tbEREjAJournalNumber = new TextBox();
            labelEREjAJournalNumber = new Label();
            tbEREjAAuthors = new TextBox();
            tbEREjAYear = new TextBox();
            tbEREjAAuthorsAdd = new Button();
            labelEREjAYear = new Label();
            lbEREjAAuthors = new ListBox();
            tbEREjAJournalName = new TextBox();
            labelEREjATitle = new Label();
            labelEREjAJournalName = new Label();
            tbEREjATitle = new TextBox();
            gbEREjournalArticleOptional = new GroupBox();
            labelEREjAAccessMode = new Label();
            tbEREjAAccessMode = new TextBox();
            tpERWebsite = new TabPage();
            gbERWebsiteRequired = new GroupBox();
            labelERWWebsiteURL = new Label();
            tbERWWebsiteURL = new TextBox();
            labelERWWebsiteName = new Label();
            tbERWWebsiteName = new TextBox();
            labelERWAccessDate = new Label();
            tbERWAccessDate = new TextBox();
            gbERWebsiteOptional = new GroupBox();
            labelERWFounder = new Label();
            tbERWFounder = new TextBox();
            labelERWDocumentType = new Label();
            tbERWDocumentType = new TextBox();
            labelERWPublishingLocation = new Label();
            tbERWPublishingLocation = new TextBox();
            labelERWCreationYear = new Label();
            tbERWCreationYear = new TextBox();
            labelERWAccessMode = new Label();
            tbERWAccessMode = new TextBox();
            tpConstituentParts = new TabPage();
            tcCPTypes = new TabControl();
            tpCPBookArticle = new TabPage();
            gbCPBookArticleRequired = new GroupBox();
            panelCPBookArticleRequired = new Panel();
            labelCPBAPages = new Label();
            labelCPBAArticleAuthors = new Label();
            tbCPBAPages = new TextBox();
            tbCPBAPublisher = new TextBox();
            labelCPBAPublishYear = new Label();
            labelCPBAPublisher = new Label();
            tbCPBAPublishYear = new TextBox();
            tbCPBAPublishingLocation = new TextBox();
            labelCPBABookAuthors = new Label();
            labelCPBAPublishingLocation = new Label();
            tbCPBABookAuthors = new TextBox();
            tbCPBABookTitle = new TextBox();
            buttonCPBABookAuthorsAdd = new Button();
            labelCPBABookTitle = new Label();
            lbCPBABookAuthors = new ListBox();
            tbCPBAArticleTitle = new TextBox();
            labelCPBAArticleTitle = new Label();
            tbCPBAArticleAuthors = new TextBox();
            lbCPBAArticleAuthors = new ListBox();
            buttonCPBAArticleAuthorsAdd = new Button();
            gbCPBookArticleOptional = new GroupBox();
            labelCPBABookDocumentType = new Label();
            tbCPBABookDocumentType = new TextBox();
            labelCPBABookEditor = new Label();
            tbCPBABookEditor = new TextBox();
            tpCPJournalArticle = new TabPage();
            gbCPJournalArticleRequired = new GroupBox();
            panelCPJournalArticleRequired = new Panel();
            labelCPJAAuthors = new Label();
            tbCPJAAuthors = new TextBox();
            tbCPJAPages = new TextBox();
            buttonCPJAAuthorsAdd = new Button();
            labelCPJAPages = new Label();
            lbCPJAAuthors = new ListBox();
            tbCPJAJournalNumber = new TextBox();
            labelCPJAArticleTitle = new Label();
            labelCPJAJournalNumber = new Label();
            tbCPJAArticleTitle = new TextBox();
            tbCPJAYear = new TextBox();
            labelCPJAJournalName = new Label();
            labelCPJAYear = new Label();
            tbCPJAJournalName = new TextBox();
            gbCPJournalArticleOptional = new GroupBox();
            labelCPJADOI = new Label();
            tbCPJADOI = new TextBox();
            tpCPNewspaperArticle = new TabPage();
            gbCPNewspaperArticleReqired = new GroupBox();
            panelCPNewspaperArticleReqired = new Panel();
            labelCPNAAuthors = new Label();
            tbCPNAAuthors = new TextBox();
            tbCPNAPages = new TextBox();
            buttonCPNAAuthorsAdd = new Button();
            labelCPNAPages = new Label();
            lbCPNAAuthors = new ListBox();
            tbCPNAReleaseDate = new TextBox();
            labelCPNAArticleTitle = new Label();
            labelCPNAReleaseDate = new Label();
            tbCPNAArticleTitle = new TextBox();
            tbCPNAYear = new TextBox();
            labelCPNANewspaperName = new Label();
            labelCPNAYear = new Label();
            tbCPNANewspaperName = new TextBox();
            gbCPNewspaperArticleOptional = new GroupBox();
            labelCPNAAdditionalInformation = new Label();
            tbCPNAAdditionalInformation = new TextBox();
            labelCPNAInterviewer = new Label();
            tbCPNAInterviewer = new TextBox();
            tpCPWebsiteArticle = new TabPage();
            gbCPWebsiteArticleRequired = new GroupBox();
            panelCPWebsiteArticleRequired = new Panel();
            labelCPWAAuthors = new Label();
            tbCPWAAuthors = new TextBox();
            tbCPWAAccessDate = new TextBox();
            buttonCPWAAuthorsAdd = new Button();
            labelCPWAAccessDate = new Label();
            lbCPWAAuthors = new ListBox();
            tbCPWAURL = new TextBox();
            labelCPWAArticleTitle = new Label();
            labelCPWAURL = new Label();
            tbCPWAArticleTitle = new TextBox();
            tbCPWAWebsiteName = new TextBox();
            labelCPWAWebsiteName = new Label();
            gbCPWebsiteArticleOptional = new GroupBox();
            labelCPWAWebsiteType = new Label();
            tbCPWAWebsiteType = new TextBox();
            labelCPWAPublishingYear = new Label();
            tbCPWAPublishingYear = new TextBox();
            labelCPWAPublishingDate = new Label();
            tbCPWAPublishingDate = new TextBox();
            labelCPWAAdditionalInformation = new Label();
            tbCPWAAdditionalInformation = new TextBox();
            ttMain = new ToolTip(components);
            tpSVConferenceMaterials = new TabPage();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            panelRtbMLA.SuspendLayout();
            panelRtbGOST.SuspendLayout();
            panelConvertTitle.SuspendLayout();
            cmsListBox.SuspendLayout();
            panelAddRecord.SuspendLayout();
            tcCategories.SuspendLayout();
            tpSingleVolume.SuspendLayout();
            tcSVTypes.SuspendLayout();
            tpSVBook.SuspendLayout();
            gpSVBookRequired.SuspendLayout();
            panelSVBookRequired.SuspendLayout();
            gpSVBookOptional.SuspendLayout();
            panelSVBookOptional.SuspendLayout();
            tpSVRegulatoryDocument.SuspendLayout();
            gbSVRegulatoryDocumentRequired.SuspendLayout();
            gbSVRegulatoryDocumentOptional.SuspendLayout();
            panelSVRegulatoryDocumentOptional.SuspendLayout();
            tpSVDissertationAbstract.SuspendLayout();
            gbSVDissertationAbstractRequired.SuspendLayout();
            panelSVDissertationAbstractRequired.SuspendLayout();
            gbSVDissertationAbstractOptional.SuspendLayout();
            tpSVDissertation.SuspendLayout();
            gbSVDissertationRequired.SuspendLayout();
            panelSVDissertationRequired.SuspendLayout();
            gbSVDissertationOptional.SuspendLayout();
            tpMultiVolume.SuspendLayout();
            tcMVTypes.SuspendLayout();
            tpMVWholeMultivolume.SuspendLayout();
            gbMVWholeMultivolumeRequired.SuspendLayout();
            panelMVWholeMultivolumeRequired.SuspendLayout();
            gbMVWholeMultivolumeOptional.SuspendLayout();
            tpMVSeparateVolume.SuspendLayout();
            gbMVSeparateVolumeRequired.SuspendLayout();
            panelMVSeparateVolumeRequired.SuspendLayout();
            gbMVSeparateVolumeOptional.SuspendLayout();
            tpElectronicResources.SuspendLayout();
            tcERTypes.SuspendLayout();
            tpEREbook.SuspendLayout();
            gbEREbookRequired.SuspendLayout();
            panelEREbookRequired.SuspendLayout();
            gbEREbookOptional.SuspendLayout();
            panelEREbookOptional.SuspendLayout();
            tpERMultimediaEdition.SuspendLayout();
            gbERMultimediaEditionRequired.SuspendLayout();
            panelERMultimediaEditionRequired.SuspendLayout();
            gbERMultimediaEditionOptional.SuspendLayout();
            tpEREjournalArticle.SuspendLayout();
            gbEREjournalArticleReqired.SuspendLayout();
            panelEREjournalArticleReqired.SuspendLayout();
            gbEREjournalArticleOptional.SuspendLayout();
            tpERWebsite.SuspendLayout();
            gbERWebsiteRequired.SuspendLayout();
            gbERWebsiteOptional.SuspendLayout();
            tpConstituentParts.SuspendLayout();
            tcCPTypes.SuspendLayout();
            tpCPBookArticle.SuspendLayout();
            gbCPBookArticleRequired.SuspendLayout();
            panelCPBookArticleRequired.SuspendLayout();
            gbCPBookArticleOptional.SuspendLayout();
            tpCPJournalArticle.SuspendLayout();
            gbCPJournalArticleRequired.SuspendLayout();
            panelCPJournalArticleRequired.SuspendLayout();
            gbCPJournalArticleOptional.SuspendLayout();
            tpCPNewspaperArticle.SuspendLayout();
            gbCPNewspaperArticleReqired.SuspendLayout();
            panelCPNewspaperArticleReqired.SuspendLayout();
            gbCPNewspaperArticleOptional.SuspendLayout();
            tpCPWebsiteArticle.SuspendLayout();
            gbCPWebsiteArticleRequired.SuspendLayout();
            panelCPWebsiteArticleRequired.SuspendLayout();
            gbCPWebsiteArticleOptional.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelAddRecord);
            splitContainer1.Panel2.Controls.Add(tcCategories);
            splitContainer1.Size = new Size(837, 808);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(buttonPDFExportResult);
            splitContainer2.Panel2.Controls.Add(buttonWordExportResult);
            splitContainer2.Panel2.Controls.Add(buttonCopyResult);
            splitContainer2.Panel2.Controls.Add(labelResult);
            splitContainer2.Panel2.Controls.Add(lbResult);
            splitContainer2.Size = new Size(300, 808);
            splitContainer2.SplitterDistance = 389;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.BorderStyle = BorderStyle.FixedSingle;
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(button1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(panelRtbMLA);
            splitContainer3.Panel2.Controls.Add(panelRtbGOST);
            splitContainer3.Panel2.Controls.Add(panelConvertTitle);
            splitContainer3.Panel2.Controls.Add(labelGOST);
            splitContainer3.Panel2.Controls.Add(labelMLA);
            splitContainer3.Panel2.Controls.Add(buttonConvert);
            splitContainer3.Size = new Size(300, 389);
            splitContainer3.SplitterDistance = 47;
            splitContainer3.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(4, 3);
            button1.Name = "button1";
            button1.Size = new Size(291, 39);
            button1.TabIndex = 0;
            button1.Text = "Вернуться в меню";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelRtbMLA
            // 
            panelRtbMLA.BorderStyle = BorderStyle.FixedSingle;
            panelRtbMLA.Controls.Add(rtbMLA);
            panelRtbMLA.Location = new Point(4, 204);
            panelRtbMLA.Name = "panelRtbMLA";
            panelRtbMLA.Size = new Size(291, 90);
            panelRtbMLA.TabIndex = 4;
            // 
            // rtbMLA
            // 
            rtbMLA.BorderStyle = BorderStyle.None;
            rtbMLA.Location = new Point(0, 0);
            rtbMLA.Name = "rtbMLA";
            rtbMLA.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbMLA.Size = new Size(290, 90);
            rtbMLA.TabIndex = 6;
            rtbMLA.Text = "";
            // 
            // panelRtbGOST
            // 
            panelRtbGOST.BorderStyle = BorderStyle.FixedSingle;
            panelRtbGOST.Controls.Add(rtbGOST);
            panelRtbGOST.Location = new Point(4, 88);
            panelRtbGOST.Name = "panelRtbGOST";
            panelRtbGOST.Size = new Size(291, 90);
            panelRtbGOST.TabIndex = 11;
            // 
            // rtbGOST
            // 
            rtbGOST.BorderStyle = BorderStyle.None;
            rtbGOST.Location = new Point(0, 0);
            rtbGOST.Name = "rtbGOST";
            rtbGOST.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbGOST.Size = new Size(290, 90);
            rtbGOST.TabIndex = 8;
            rtbGOST.Text = "";
            // 
            // panelConvertTitle
            // 
            panelConvertTitle.BackColor = SystemColors.ControlLight;
            panelConvertTitle.Controls.Add(labelConvert);
            panelConvertTitle.Location = new Point(2, 3);
            panelConvertTitle.Name = "panelConvertTitle";
            panelConvertTitle.Size = new Size(293, 59);
            panelConvertTitle.TabIndex = 10;
            // 
            // labelConvert
            // 
            labelConvert.AutoSize = true;
            labelConvert.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelConvert.Location = new Point(63, 3);
            labelConvert.Name = "labelConvert";
            labelConvert.Size = new Size(175, 50);
            labelConvert.TabIndex = 5;
            labelConvert.Text = "Конвертировать в \r\n нужный формат";
            // 
            // labelGOST
            // 
            labelGOST.AutoSize = true;
            labelGOST.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelGOST.Location = new Point(70, 65);
            labelGOST.Name = "labelGOST";
            labelGOST.Size = new Size(166, 20);
            labelGOST.TabIndex = 9;
            labelGOST.Text = "Киберленинка «ГОСТ»";
            // 
            // labelMLA
            // 
            labelMLA.AutoSize = true;
            labelMLA.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMLA.Location = new Point(70, 181);
            labelMLA.Name = "labelMLA";
            labelMLA.Size = new Size(161, 20);
            labelMLA.TabIndex = 7;
            labelMLA.Text = "Киберленинка «MLA»";
            // 
            // buttonConvert
            // 
            buttonConvert.BackColor = SystemColors.Info;
            buttonConvert.FlatStyle = FlatStyle.Flat;
            buttonConvert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConvert.Location = new Point(4, 299);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(291, 34);
            buttonConvert.TabIndex = 4;
            buttonConvert.Text = "Конвертировать";
            buttonConvert.UseVisualStyleBackColor = false;
            // 
            // buttonPDFExportResult
            // 
            buttonPDFExportResult.BackColor = Color.IndianRed;
            buttonPDFExportResult.FlatStyle = FlatStyle.Flat;
            buttonPDFExportResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPDFExportResult.Location = new Point(151, 370);
            buttonPDFExportResult.Name = "buttonPDFExportResult";
            buttonPDFExportResult.Size = new Size(144, 40);
            buttonPDFExportResult.TabIndex = 4;
            buttonPDFExportResult.Text = "Экспорт в PDF";
            buttonPDFExportResult.UseVisualStyleBackColor = false;
            // 
            // buttonWordExportResult
            // 
            buttonWordExportResult.BackColor = SystemColors.ActiveCaption;
            buttonWordExportResult.FlatStyle = FlatStyle.Flat;
            buttonWordExportResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWordExportResult.Location = new Point(3, 370);
            buttonWordExportResult.Name = "buttonWordExportResult";
            buttonWordExportResult.Size = new Size(144, 40);
            buttonWordExportResult.TabIndex = 3;
            buttonWordExportResult.Text = "Экспорт в Word";
            buttonWordExportResult.UseVisualStyleBackColor = false;
            // 
            // buttonCopyResult
            // 
            buttonCopyResult.BackColor = Color.SandyBrown;
            buttonCopyResult.FlatStyle = FlatStyle.Flat;
            buttonCopyResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCopyResult.Location = new Point(3, 327);
            buttonCopyResult.Name = "buttonCopyResult";
            buttonCopyResult.Size = new Size(292, 40);
            buttonCopyResult.TabIndex = 2;
            buttonCopyResult.Text = "Скопировать все";
            buttonCopyResult.UseVisualStyleBackColor = false;
            buttonCopyResult.Click += buttonCopyResult_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.Location = new Point(103, 10);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(96, 25);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат";
            // 
            // lbResult
            // 
            lbResult.BackColor = SystemColors.ControlLight;
            lbResult.BorderStyle = BorderStyle.FixedSingle;
            lbResult.ContextMenuStrip = cmsListBox;
            lbResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.FormattingEnabled = true;
            lbResult.HorizontalScrollbar = true;
            lbResult.ItemHeight = 20;
            lbResult.Location = new Point(3, 42);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(292, 282);
            lbResult.TabIndex = 0;
            lbResult.MouseDown += ListBox_MouseDown;
            // 
            // cmsListBox
            // 
            cmsListBox.Items.AddRange(new ToolStripItem[] { tsmiDeleteSelected, tsmiDeleteAll, tsmiCopy });
            cmsListBox.Name = "contextMenuStrip1";
            cmsListBox.Size = new Size(147, 70);
            cmsListBox.Opening += cmsListBox_Opening;
            // 
            // tsmiDeleteSelected
            // 
            tsmiDeleteSelected.Name = "tsmiDeleteSelected";
            tsmiDeleteSelected.Size = new Size(146, 22);
            tsmiDeleteSelected.Text = "Удалить";
            tsmiDeleteSelected.Click += tsmiDeleteSelected_Click;
            // 
            // tsmiDeleteAll
            // 
            tsmiDeleteAll.Name = "tsmiDeleteAll";
            tsmiDeleteAll.Size = new Size(146, 22);
            tsmiDeleteAll.Text = "Удалить все";
            tsmiDeleteAll.Click += tsmiDeleteAll_Click;
            // 
            // tsmiCopy
            // 
            tsmiCopy.Name = "tsmiCopy";
            tsmiCopy.Size = new Size(146, 22);
            tsmiCopy.Text = "Скопировать";
            tsmiCopy.Click += tsmiCopy_Click;
            // 
            // panelAddRecord
            // 
            panelAddRecord.BackColor = SystemColors.ControlLight;
            panelAddRecord.Controls.Add(buttonAddRecord);
            panelAddRecord.Controls.Add(cbWordAbbreviation);
            panelAddRecord.Location = new Point(10, 757);
            panelAddRecord.Name = "panelAddRecord";
            panelAddRecord.Size = new Size(509, 42);
            panelAddRecord.TabIndex = 2;
            // 
            // buttonAddRecord
            // 
            buttonAddRecord.BackColor = SystemColors.MenuHighlight;
            buttonAddRecord.FlatStyle = FlatStyle.Flat;
            buttonAddRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddRecord.Location = new Point(304, 4);
            buttonAddRecord.Name = "buttonAddRecord";
            buttonAddRecord.Size = new Size(202, 34);
            buttonAddRecord.TabIndex = 1;
            buttonAddRecord.Text = "Добавить";
            buttonAddRecord.UseVisualStyleBackColor = false;
            buttonAddRecord.Click += buttonAddRecord_Click;
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
            tcCategories.Size = new Size(529, 748);
            tcCategories.TabIndex = 1;
            // 
            // tpSingleVolume
            // 
            tpSingleVolume.BackColor = SystemColors.Control;
            tpSingleVolume.Controls.Add(tcSVTypes);
            tpSingleVolume.Location = new Point(4, 24);
            tpSingleVolume.Name = "tpSingleVolume";
            tpSingleVolume.Padding = new Padding(3);
            tpSingleVolume.Size = new Size(521, 720);
            tpSingleVolume.TabIndex = 0;
            tpSingleVolume.Text = "Одночастные (однотомные) ресурсы";
            // 
            // tcSVTypes
            // 
            tcSVTypes.Controls.Add(tpSVBook);
            tcSVTypes.Controls.Add(tpSVConferenceMaterials);
            tcSVTypes.Controls.Add(tpSVRegulatoryDocument);
            tcSVTypes.Controls.Add(tpSVDissertationAbstract);
            tcSVTypes.Controls.Add(tpSVDissertation);
            tcSVTypes.ImeMode = ImeMode.NoControl;
            tcSVTypes.Location = new Point(3, 6);
            tcSVTypes.Name = "tcSVTypes";
            tcSVTypes.SelectedIndex = 0;
            tcSVTypes.Size = new Size(513, 709);
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
            tpSVBook.Size = new Size(505, 681);
            tpSVBook.TabIndex = 0;
            tpSVBook.Text = "Книга";
            // 
            // gpSVBookRequired
            // 
            gpSVBookRequired.Controls.Add(panelSVBookRequired);
            gpSVBookRequired.Location = new Point(10, 10);
            gpSVBookRequired.Name = "gpSVBookRequired";
            gpSVBookRequired.Size = new Size(488, 330);
            gpSVBookRequired.TabIndex = 0;
            gpSVBookRequired.TabStop = false;
            gpSVBookRequired.Text = "Обязательные поля";
            // 
            // panelSVBookRequired
            // 
            panelSVBookRequired.AutoScroll = true;
            panelSVBookRequired.Controls.Add(cbSVBAuthors);
            panelSVBookRequired.Controls.Add(buttonSVBPublisherAdd);
            panelSVBookRequired.Controls.Add(lbSVBPublisher);
            panelSVBookRequired.Controls.Add(buttonSVBPublishingLocationAdd);
            panelSVBookRequired.Controls.Add(lbSVBPublishingLocation);
            panelSVBookRequired.Controls.Add(labelSVBAuthors);
            panelSVBookRequired.Controls.Add(tbSVBAuthors);
            panelSVBookRequired.Controls.Add(tbSVBPagesCount);
            panelSVBookRequired.Controls.Add(buttonSVBAuthorsAdd);
            panelSVBookRequired.Controls.Add(labelSVBPagesCount);
            panelSVBookRequired.Controls.Add(lbSVBAuthors);
            panelSVBookRequired.Controls.Add(tbSVBPublishYear);
            panelSVBookRequired.Controls.Add(labelSVBTitle);
            panelSVBookRequired.Controls.Add(labelSVBPublishYear);
            panelSVBookRequired.Controls.Add(tbSVBTitle);
            panelSVBookRequired.Controls.Add(tbSVBPublisher);
            panelSVBookRequired.Controls.Add(labelSVBPublishingLocation);
            panelSVBookRequired.Controls.Add(labelSVBPublisher);
            panelSVBookRequired.Controls.Add(tbSVBPublishingLocation);
            panelSVBookRequired.Location = new Point(10, 22);
            panelSVBookRequired.Name = "panelSVBookRequired";
            panelSVBookRequired.Size = new Size(473, 302);
            panelSVBookRequired.TabIndex = 14;
            // 
            // cbSVBAuthors
            // 
            cbSVBAuthors.AutoSize = true;
            cbSVBAuthors.Location = new Point(371, 22);
            cbSVBAuthors.Name = "cbSVBAuthors";
            cbSVBAuthors.Size = new Size(79, 19);
            cbSVBAuthors.TabIndex = 18;
            cbSVBAuthors.Text = "5 авторов";
            ttMain.SetToolTip(cbSVBAuthors, "Включить логику формирования для 5 и более авторов.\r\n[Включается автоматически при добавлении 5 и более авторов]");
            cbSVBAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonSVBPublisherAdd
            // 
            buttonSVBPublisherAdd.Location = new Point(360, 308);
            buttonSVBPublisherAdd.Name = "buttonSVBPublisherAdd";
            buttonSVBPublisherAdd.Size = new Size(90, 23);
            buttonSVBPublisherAdd.TabIndex = 17;
            buttonSVBPublisherAdd.Text = "Добавить";
            buttonSVBPublisherAdd.UseVisualStyleBackColor = true;
            buttonSVBPublisherAdd.Click += buttonSVBPublisherAdd_Click;
            // 
            // lbSVBPublisher
            // 
            lbSVBPublisher.ContextMenuStrip = cmsListBox;
            lbSVBPublisher.ItemHeight = 15;
            lbSVBPublisher.Location = new Point(0, 337);
            lbSVBPublisher.Name = "lbSVBPublisher";
            lbSVBPublisher.Size = new Size(450, 64);
            lbSVBPublisher.TabIndex = 16;
            lbSVBPublisher.MouseDown += ListBox_MouseDown;
            // 
            // buttonSVBPublishingLocationAdd
            // 
            buttonSVBPublishingLocationAdd.Location = new Point(360, 190);
            buttonSVBPublishingLocationAdd.Name = "buttonSVBPublishingLocationAdd";
            buttonSVBPublishingLocationAdd.Size = new Size(90, 23);
            buttonSVBPublishingLocationAdd.TabIndex = 15;
            buttonSVBPublishingLocationAdd.Text = "Добавить";
            buttonSVBPublishingLocationAdd.UseVisualStyleBackColor = true;
            buttonSVBPublishingLocationAdd.Click += buttonSVBPublishingLocationAdd_Click;
            // 
            // lbSVBPublishingLocation
            // 
            lbSVBPublishingLocation.ContextMenuStrip = cmsListBox;
            lbSVBPublishingLocation.ItemHeight = 15;
            lbSVBPublishingLocation.Location = new Point(0, 219);
            lbSVBPublishingLocation.Name = "lbSVBPublishingLocation";
            lbSVBPublishingLocation.Size = new Size(450, 64);
            lbSVBPublishingLocation.TabIndex = 14;
            lbSVBPublishingLocation.MouseDown += ListBox_MouseDown;
            // 
            // labelSVBAuthors
            // 
            labelSVBAuthors.AutoSize = true;
            labelSVBAuthors.Location = new Point(0, 0);
            labelSVBAuthors.Name = "labelSVBAuthors";
            labelSVBAuthors.Size = new Size(57, 15);
            labelSVBAuthors.TabIndex = 0;
            labelSVBAuthors.Text = "Автор(ы)";
            ttMain.SetToolTip(labelSVBAuthors, resources.GetString("labelSVBAuthors.ToolTip"));
            // 
            // tbSVBAuthors
            // 
            tbSVBAuthors.Location = new Point(0, 20);
            tbSVBAuthors.Name = "tbSVBAuthors";
            tbSVBAuthors.Size = new Size(269, 23);
            tbSVBAuthors.TabIndex = 1;
            ttMain.SetToolTip(tbSVBAuthors, resources.GetString("tbSVBAuthors.ToolTip"));
            // 
            // tbSVBPagesCount
            // 
            tbSVBPagesCount.Location = new Point(0, 474);
            tbSVBPagesCount.Name = "tbSVBPagesCount";
            tbSVBPagesCount.Size = new Size(450, 23);
            tbSVBPagesCount.TabIndex = 13;
            ttMain.SetToolTip(tbSVBPagesCount, "Общий объем книги в страницах.\r\nПример: \"134\".\r\n");
            // 
            // buttonSVBAuthorsAdd
            // 
            buttonSVBAuthorsAdd.Location = new Point(275, 20);
            buttonSVBAuthorsAdd.Name = "buttonSVBAuthorsAdd";
            buttonSVBAuthorsAdd.Size = new Size(90, 23);
            buttonSVBAuthorsAdd.TabIndex = 2;
            buttonSVBAuthorsAdd.Text = "Добавить";
            buttonSVBAuthorsAdd.UseVisualStyleBackColor = true;
            buttonSVBAuthorsAdd.Click += buttonSVBAuthorsAdd_Click;
            // 
            // labelSVBPagesCount
            // 
            labelSVBPagesCount.AutoSize = true;
            labelSVBPagesCount.Location = new Point(0, 454);
            labelSVBPagesCount.Name = "labelSVBPagesCount";
            labelSVBPagesCount.Size = new Size(120, 15);
            labelSVBPagesCount.TabIndex = 12;
            labelSVBPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelSVBPagesCount, "Общий объем книги в страницах.\r\nПример: \"134\".");
            // 
            // lbSVBAuthors
            // 
            lbSVBAuthors.ContextMenuStrip = cmsListBox;
            lbSVBAuthors.ItemHeight = 15;
            lbSVBAuthors.Location = new Point(0, 49);
            lbSVBAuthors.Name = "lbSVBAuthors";
            lbSVBAuthors.Size = new Size(450, 64);
            lbSVBAuthors.TabIndex = 3;
            lbSVBAuthors.MouseDown += ListBox_MouseDown;
            // 
            // tbSVBPublishYear
            // 
            tbSVBPublishYear.Location = new Point(0, 424);
            tbSVBPublishYear.Name = "tbSVBPublishYear";
            tbSVBPublishYear.Size = new Size(450, 23);
            tbSVBPublishYear.TabIndex = 11;
            ttMain.SetToolTip(tbSVBPublishYear, "Год публикации книги в формате четырёх цифр.\r\nПример: \"2019\".");
            // 
            // labelSVBTitle
            // 
            labelSVBTitle.AutoSize = true;
            labelSVBTitle.Location = new Point(0, 120);
            labelSVBTitle.Name = "labelSVBTitle";
            labelSVBTitle.Size = new Size(57, 15);
            labelSVBTitle.TabIndex = 4;
            labelSVBTitle.Text = "Заглавие";
            ttMain.SetToolTip(labelSVBTitle, "Полное название книги, как указано в источнике, без сокращений.\r\nПример: \"Экономика организации. Ресурсы коммерческой организации\".");
            // 
            // labelSVBPublishYear
            // 
            labelSVBPublishYear.AutoSize = true;
            labelSVBPublishYear.Location = new Point(0, 404);
            labelSVBPublishYear.Name = "labelSVBPublishYear";
            labelSVBPublishYear.Size = new Size(73, 15);
            labelSVBPublishYear.TabIndex = 10;
            labelSVBPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelSVBPublishYear, "Год публикации книги в формате четырёх цифр.\nПример: \"2019\".");
            // 
            // tbSVBTitle
            // 
            tbSVBTitle.Location = new Point(0, 140);
            tbSVBTitle.Name = "tbSVBTitle";
            tbSVBTitle.Size = new Size(450, 23);
            tbSVBTitle.TabIndex = 5;
            ttMain.SetToolTip(tbSVBTitle, "Полное название книги, как указано в источнике, без сокращений.\r\nПример: \"Экономика организации. Ресурсы коммерческой организации\".");
            // 
            // tbSVBPublisher
            // 
            tbSVBPublisher.Location = new Point(0, 308);
            tbSVBPublisher.Name = "tbSVBPublisher";
            tbSVBPublisher.Size = new Size(354, 23);
            tbSVBPublisher.TabIndex = 9;
            ttMain.SetToolTip(tbSVBPublisher, "Название издательства без сокращений в общем случае.\r\nПример: \"Юрайт\" или \"Издательство Урал. университета\".\r\n");
            // 
            // labelSVBPublishingLocation
            // 
            labelSVBPublishingLocation.AutoSize = true;
            labelSVBPublishingLocation.Location = new Point(0, 170);
            labelSVBPublishingLocation.Name = "labelSVBPublishingLocation";
            labelSVBPublishingLocation.Size = new Size(89, 15);
            labelSVBPublishingLocation.TabIndex = 6;
            labelSVBPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelSVBPublishingLocation, resources.GetString("labelSVBPublishingLocation.ToolTip"));
            // 
            // labelSVBPublisher
            // 
            labelSVBPublisher.AutoSize = true;
            labelSVBPublisher.Location = new Point(0, 288);
            labelSVBPublisher.Name = "labelSVBPublisher";
            labelSVBPublisher.Size = new Size(81, 15);
            labelSVBPublisher.TabIndex = 8;
            labelSVBPublisher.Text = "Издательство";
            ttMain.SetToolTip(labelSVBPublisher, resources.GetString("labelSVBPublisher.ToolTip"));
            // 
            // tbSVBPublishingLocation
            // 
            tbSVBPublishingLocation.Location = new Point(0, 190);
            tbSVBPublishingLocation.Name = "tbSVBPublishingLocation";
            tbSVBPublishingLocation.Size = new Size(354, 23);
            tbSVBPublishingLocation.TabIndex = 7;
            ttMain.SetToolTip(tbSVBPublishingLocation, resources.GetString("tbSVBPublishingLocation.ToolTip"));
            // 
            // gpSVBookOptional
            // 
            gpSVBookOptional.Controls.Add(panelSVBookOptional);
            gpSVBookOptional.Location = new Point(10, 346);
            gpSVBookOptional.Name = "gpSVBookOptional";
            gpSVBookOptional.Size = new Size(488, 330);
            gpSVBookOptional.TabIndex = 1;
            gpSVBookOptional.TabStop = false;
            gpSVBookOptional.Text = "Необязательные поля";
            // 
            // panelSVBookOptional
            // 
            panelSVBookOptional.AutoScroll = true;
            panelSVBookOptional.Controls.Add(cbSVBEditorType);
            panelSVBookOptional.Controls.Add(lbSVBEditor);
            panelSVBookOptional.Controls.Add(buttonSVBEditorAdd);
            panelSVBookOptional.Controls.Add(labelSVBParallelTitle);
            panelSVBookOptional.Controls.Add(tbSVBParallelTitle);
            panelSVBookOptional.Controls.Add(labelSVBContentType);
            panelSVBookOptional.Controls.Add(tbSVBContentType);
            panelSVBookOptional.Controls.Add(labelSVBDocumentType);
            panelSVBookOptional.Controls.Add(tbSVBOrganization);
            panelSVBookOptional.Controls.Add(tbSVBDocumentType);
            panelSVBookOptional.Controls.Add(labelSVBEditor);
            panelSVBookOptional.Controls.Add(tbSVBTranslator);
            panelSVBookOptional.Controls.Add(labelSVBOrganization);
            panelSVBookOptional.Controls.Add(tbSVBEditor);
            panelSVBookOptional.Controls.Add(labelSVBTranslator);
            panelSVBookOptional.Controls.Add(labelSVBEditionNumber);
            panelSVBookOptional.Controls.Add(tbSVBISBN);
            panelSVBookOptional.Controls.Add(tbSVBEditionNumber);
            panelSVBookOptional.Controls.Add(labelSVBISBN);
            panelSVBookOptional.Controls.Add(labelSVBSeries);
            panelSVBookOptional.Controls.Add(tbSVBSeries);
            panelSVBookOptional.Location = new Point(10, 22);
            panelSVBookOptional.Name = "panelSVBookOptional";
            panelSVBookOptional.Size = new Size(473, 302);
            panelSVBookOptional.TabIndex = 14;
            // 
            // cbSVBEditorType
            // 
            cbSVBEditorType.FormattingEnabled = true;
            cbSVBEditorType.Items.AddRange(new object[] { "\"Под редакцией\"", "\"Под общей редакцией\"", "\"Ответственный редактор\"" });
            cbSVBEditorType.Location = new Point(194, 157);
            cbSVBEditorType.Name = "cbSVBEditorType";
            cbSVBEditorType.Size = new Size(160, 23);
            cbSVBEditorType.TabIndex = 20;
            // 
            // lbSVBEditor
            // 
            lbSVBEditor.ContextMenuStrip = cmsListBox;
            lbSVBEditor.ItemHeight = 15;
            lbSVBEditor.Location = new Point(0, 187);
            lbSVBEditor.Name = "lbSVBEditor";
            lbSVBEditor.Size = new Size(450, 64);
            lbSVBEditor.TabIndex = 19;
            lbSVBEditor.MouseDown += ListBox_MouseDown;
            // 
            // buttonSVBEditorAdd
            // 
            buttonSVBEditorAdd.Location = new Point(360, 157);
            buttonSVBEditorAdd.Name = "buttonSVBEditorAdd";
            buttonSVBEditorAdd.Size = new Size(90, 23);
            buttonSVBEditorAdd.TabIndex = 18;
            buttonSVBEditorAdd.Text = "Добавить";
            buttonSVBEditorAdd.UseVisualStyleBackColor = true;
            buttonSVBEditorAdd.Click += buttonSVBEditorAdd_Click;
            // 
            // labelSVBParallelTitle
            // 
            labelSVBParallelTitle.AutoSize = true;
            labelSVBParallelTitle.Location = new Point(0, 0);
            labelSVBParallelTitle.Name = "labelSVBParallelTitle";
            labelSVBParallelTitle.Size = new Size(139, 15);
            labelSVBParallelTitle.TabIndex = 16;
            labelSVBParallelTitle.Text = "Параллельное заглавие";
            ttMain.SetToolTip(labelSVBParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"");
            // 
            // tbSVBParallelTitle
            // 
            tbSVBParallelTitle.Location = new Point(0, 20);
            tbSVBParallelTitle.Name = "tbSVBParallelTitle";
            tbSVBParallelTitle.Size = new Size(450, 23);
            tbSVBParallelTitle.TabIndex = 17;
            ttMain.SetToolTip(tbSVBParallelTitle, "Заглавие, повторённое в документе на другом языке (или в другой письменности), \r\nуказываемое в библиографической записи через знак \"=\".\r\nПример: \"Theorie und Praktikum in der deutschen Grammatik\"\r\n");
            // 
            // labelSVBContentType
            // 
            labelSVBContentType.AutoSize = true;
            labelSVBContentType.Location = new Point(0, 92);
            labelSVBContentType.Name = "labelSVBContentType";
            labelSVBContentType.Size = new Size(97, 15);
            labelSVBContentType.TabIndex = 14;
            labelSVBContentType.Text = "Вид содержания";
            ttMain.SetToolTip(labelSVBContentType, "Уточняет тип содержания. Формат: тип содержания без \"Текст\".\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // tbSVBContentType
            // 
            tbSVBContentType.Location = new Point(0, 112);
            tbSVBContentType.Name = "tbSVBContentType";
            tbSVBContentType.Size = new Size(450, 23);
            tbSVBContentType.TabIndex = 15;
            ttMain.SetToolTip(tbSVBContentType, "Уточняет тип содержания. Формат: тип содержания без \"Текст\".\r\nПример: Текст : непосредственный\" или \"Текст : электронный\".");
            // 
            // labelSVBDocumentType
            // 
            labelSVBDocumentType.AutoSize = true;
            labelSVBDocumentType.Location = new Point(0, 46);
            labelSVBDocumentType.Name = "labelSVBDocumentType";
            labelSVBDocumentType.Size = new Size(88, 15);
            labelSVBDocumentType.TabIndex = 0;
            labelSVBDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelSVBDocumentType, "Уточняет тип издания (учебник, монография и т.д.).\r\nВ квадратных скобках указывается, если вид документа не указан в самом источнике напрямую.\r\nПример: \"учебное пособие\" или \"[монография]\".");
            // 
            // tbSVBOrganization
            // 
            tbSVBOrganization.Location = new Point(0, 470);
            tbSVBOrganization.Name = "tbSVBOrganization";
            tbSVBOrganization.Size = new Size(450, 23);
            tbSVBOrganization.TabIndex = 13;
            ttMain.SetToolTip(tbSVBOrganization, resources.GetString("tbSVBOrganization.ToolTip"));
            // 
            // tbSVBDocumentType
            // 
            tbSVBDocumentType.Location = new Point(0, 66);
            tbSVBDocumentType.Name = "tbSVBDocumentType";
            tbSVBDocumentType.Size = new Size(450, 23);
            tbSVBDocumentType.TabIndex = 1;
            ttMain.SetToolTip(tbSVBDocumentType, "Уточняет тип издания (учебник, монография и т.д.).\r\nВ квадратных скобках указывается, если вид документа не указан в самом источнике напрямую.\r\nПример: \"учебное пособие\" или \"[монография]\".");
            // 
            // labelSVBEditor
            // 
            labelSVBEditor.AutoSize = true;
            labelSVBEditor.Location = new Point(0, 138);
            labelSVBEditor.Name = "labelSVBEditor";
            labelSVBEditor.Size = new Size(57, 15);
            labelSVBEditor.TabIndex = 2;
            labelSVBEditor.Text = "Редактор";
            ttMain.SetToolTip(labelSVBEditor, "Имя редактора, если он указан, которое добавляется после \"; под редакцией\". Формат: инициалы, фамилия в родительском падеже.\r\nПример: \"Н. Р. Кельчевской\".");
            // 
            // tbSVBTranslator
            // 
            tbSVBTranslator.Location = new Point(0, 424);
            tbSVBTranslator.Name = "tbSVBTranslator";
            tbSVBTranslator.Size = new Size(450, 23);
            tbSVBTranslator.TabIndex = 11;
            ttMain.SetToolTip(tbSVBTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".\r\n");
            // 
            // labelSVBOrganization
            // 
            labelSVBOrganization.AutoSize = true;
            labelSVBOrganization.Location = new Point(0, 450);
            labelSVBOrganization.Name = "labelSVBOrganization";
            labelSVBOrganization.Size = new Size(79, 15);
            labelSVBOrganization.TabIndex = 12;
            labelSVBOrganization.Text = "Организация";
            ttMain.SetToolTip(labelSVBOrganization, resources.GetString("labelSVBOrganization.ToolTip"));
            // 
            // tbSVBEditor
            // 
            tbSVBEditor.Location = new Point(0, 158);
            tbSVBEditor.Name = "tbSVBEditor";
            tbSVBEditor.Size = new Size(188, 23);
            tbSVBEditor.TabIndex = 3;
            ttMain.SetToolTip(tbSVBEditor, resources.GetString("tbSVBEditor.ToolTip"));
            // 
            // labelSVBTranslator
            // 
            labelSVBTranslator.AutoSize = true;
            labelSVBTranslator.Location = new Point(0, 404);
            labelSVBTranslator.Name = "labelSVBTranslator";
            labelSVBTranslator.Size = new Size(74, 15);
            labelSVBTranslator.TabIndex = 10;
            labelSVBTranslator.Text = "Переводчик";
            ttMain.SetToolTip(labelSVBTranslator, "Имя переводчика для переводных изданий, после \"; перевод с …\".\r\nПример: \"английского А. Ю. Заякина\".");
            // 
            // labelSVBEditionNumber
            // 
            labelSVBEditionNumber.AutoSize = true;
            labelSVBEditionNumber.Location = new Point(0, 254);
            labelSVBEditionNumber.Name = "labelSVBEditionNumber";
            labelSVBEditionNumber.Size = new Size(92, 15);
            labelSVBEditionNumber.TabIndex = 4;
            labelSVBEditionNumber.Text = "Номер издания";
            ttMain.SetToolTip(labelSVBEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, переработанное и дополненное\".");
            // 
            // tbSVBISBN
            // 
            tbSVBISBN.Location = new Point(0, 374);
            tbSVBISBN.Name = "tbSVBISBN";
            tbSVBISBN.Size = new Size(450, 23);
            tbSVBISBN.TabIndex = 9;
            ttMain.SetToolTip(tbSVBISBN, "Международный стандартный номер книги.\r\nПример: \"978-5-534-10585-8\".");
            // 
            // tbSVBEditionNumber
            // 
            tbSVBEditionNumber.Location = new Point(0, 274);
            tbSVBEditionNumber.Name = "tbSVBEditionNumber";
            tbSVBEditionNumber.Size = new Size(450, 23);
            tbSVBEditionNumber.TabIndex = 5;
            ttMain.SetToolTip(tbSVBEditionNumber, "Номер издания и уточнения (переработанное, дополненное), если не первое, перед местом издания.\r\nПример: \"2-е издание, перераб. и доп.\".");
            // 
            // labelSVBISBN
            // 
            labelSVBISBN.AutoSize = true;
            labelSVBISBN.Location = new Point(0, 354);
            labelSVBISBN.Name = "labelSVBISBN";
            labelSVBISBN.Size = new Size(32, 15);
            labelSVBISBN.TabIndex = 8;
            labelSVBISBN.Text = "ISBN";
            ttMain.SetToolTip(labelSVBISBN, "Международный стандартный номер книги.\r\nПример: \"978-5-534-10585-8\".");
            // 
            // labelSVBSeries
            // 
            labelSVBSeries.AutoSize = true;
            labelSVBSeries.Location = new Point(0, 304);
            labelSVBSeries.Name = "labelSVBSeries";
            labelSVBSeries.Size = new Size(41, 15);
            labelSVBSeries.TabIndex = 6;
            labelSVBSeries.Text = "Серия";
            ttMain.SetToolTip(labelSVBSeries, "Название серии, в которой издана книга.\r\nПример: \"Профессиональное образование\".");
            // 
            // tbSVBSeries
            // 
            tbSVBSeries.Location = new Point(0, 324);
            tbSVBSeries.Name = "tbSVBSeries";
            tbSVBSeries.Size = new Size(450, 23);
            tbSVBSeries.TabIndex = 7;
            ttMain.SetToolTip(tbSVBSeries, "Название серии, в которой издана книга.\r\nПример: \"Профессиональное образование\".\r\n");
            // 
            // tpSVRegulatoryDocument
            // 
            tpSVRegulatoryDocument.BackColor = SystemColors.Control;
            tpSVRegulatoryDocument.Controls.Add(gbSVRegulatoryDocumentRequired);
            tpSVRegulatoryDocument.Controls.Add(gbSVRegulatoryDocumentOptional);
            tpSVRegulatoryDocument.Location = new Point(4, 24);
            tpSVRegulatoryDocument.Name = "tpSVRegulatoryDocument";
            tpSVRegulatoryDocument.Padding = new Padding(3);
            tpSVRegulatoryDocument.Size = new Size(505, 681);
            tpSVRegulatoryDocument.TabIndex = 1;
            tpSVRegulatoryDocument.Text = "Нормативный документ";
            // 
            // gbSVRegulatoryDocumentRequired
            // 
            gbSVRegulatoryDocumentRequired.Controls.Add(labelSVRDDocumentNumber);
            gbSVRegulatoryDocumentRequired.Controls.Add(tbSVRDDocumentNumber);
            gbSVRegulatoryDocumentRequired.Controls.Add(labelSVRDTitle);
            gbSVRegulatoryDocumentRequired.Controls.Add(tbSVRDTitle);
            gbSVRegulatoryDocumentRequired.Controls.Add(labelSVRDPublishingLocation);
            gbSVRegulatoryDocumentRequired.Controls.Add(tbSVRDPublishingLocation);
            gbSVRegulatoryDocumentRequired.Controls.Add(labelSVRDPublisher);
            gbSVRegulatoryDocumentRequired.Controls.Add(tbSVRDPublisher);
            gbSVRegulatoryDocumentRequired.Controls.Add(labelSVRDPublishYear);
            gbSVRegulatoryDocumentRequired.Controls.Add(tbSVRDPublishYear);
            gbSVRegulatoryDocumentRequired.Location = new Point(10, 10);
            gbSVRegulatoryDocumentRequired.Name = "gbSVRegulatoryDocumentRequired";
            gbSVRegulatoryDocumentRequired.Size = new Size(488, 330);
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
            ttMain.SetToolTip(labelSVRDDocumentNumber, "Уникальный номер документа (ГОСТа, закона), включая префиксы.\nПример: \"ГОСТ Р 57564–2017\" или \"№ 131-ФЗ\".");
            // 
            // tbSVRDDocumentNumber
            // 
            tbSVRDDocumentNumber.Location = new Point(10, 87);
            tbSVRDDocumentNumber.Name = "tbSVRDDocumentNumber";
            tbSVRDDocumentNumber.Size = new Size(450, 23);
            tbSVRDDocumentNumber.TabIndex = 15;
            ttMain.SetToolTip(tbSVRDDocumentNumber, "Уникальный номер документа (ГОСТа, закона), включая префиксы.\r\nПример: \"ГОСТ Р 57564–2017\" или \"№ 131-ФЗ\".");
            // 
            // labelSVRDTitle
            // 
            labelSVRDTitle.AutoSize = true;
            labelSVRDTitle.Location = new Point(10, 20);
            labelSVRDTitle.Name = "labelSVRDTitle";
            labelSVRDTitle.Size = new Size(57, 15);
            labelSVRDTitle.TabIndex = 4;
            labelSVRDTitle.Text = "Заглавие";
            ttMain.SetToolTip(labelSVRDTitle, "Полное название документа, как указано в источнике.\r\nПример: \"Организация и проведение работ по международной стандартизации в Российской Федерации\" или \"Уголовный кодекс Российской Федерации\".");
            // 
            // tbSVRDTitle
            // 
            tbSVRDTitle.Location = new Point(10, 40);
            tbSVRDTitle.Name = "tbSVRDTitle";
            tbSVRDTitle.Size = new Size(450, 23);
            tbSVRDTitle.TabIndex = 5;
            ttMain.SetToolTip(tbSVRDTitle, "Полное название документа, как указано в источнике.\nПример: \"Организация и проведение работ по международной стандартизации в Российской Федерации\" или \"Уголовный кодекс Российской Федерации\".");
            // 
            // labelSVRDPublishingLocation
            // 
            labelSVRDPublishingLocation.AutoSize = true;
            labelSVRDPublishingLocation.Location = new Point(10, 115);
            labelSVRDPublishingLocation.Name = "labelSVRDPublishingLocation";
            labelSVRDPublishingLocation.Size = new Size(89, 15);
            labelSVRDPublishingLocation.TabIndex = 6;
            labelSVRDPublishingLocation.Text = "Место издания";
            ttMain.SetToolTip(labelSVRDPublishingLocation, "Город, где документ опубликован.\nПример: \"Москва\".");
            // 
            // tbSVRDPublishingLocation
            // 
            tbSVRDPublishingLocation.Location = new Point(10, 135);
            tbSVRDPublishingLocation.Name = "tbSVRDPublishingLocation";
            tbSVRDPublishingLocation.Size = new Size(450, 23);
            tbSVRDPublishingLocation.TabIndex = 7;
            ttMain.SetToolTip(tbSVRDPublishingLocation, "Город, где документ опубликован.\nПример: \"Москва\".");
            // 
            // labelSVRDPublisher
            // 
            labelSVRDPublisher.AutoSize = true;
            labelSVRDPublisher.Location = new Point(10, 161);
            labelSVRDPublisher.Name = "labelSVRDPublisher";
            labelSVRDPublisher.Size = new Size(230, 15);
            labelSVRDPublisher.TabIndex = 8;
            labelSVRDPublisher.Text = "Издательство или источник публикации";
            ttMain.SetToolTip(labelSVRDPublisher, "Издательство (для ГОСТов) или официальный источник (для законов).\nПример: \"Стандартинформ\" (ГОСТ) или \"Эксмо\" (закон).");
            // 
            // tbSVRDPublisher
            // 
            tbSVRDPublisher.Location = new Point(10, 181);
            tbSVRDPublisher.Name = "tbSVRDPublisher";
            tbSVRDPublisher.Size = new Size(450, 23);
            tbSVRDPublisher.TabIndex = 9;
            ttMain.SetToolTip(tbSVRDPublisher, "Издательство (для ГОСТов) или официальный источник (для законов).\nПример: \"Стандартинформ\" (ГОСТ) или \"Эксмо\" (закон).");
            // 
            // labelSVRDPublishYear
            // 
            labelSVRDPublishYear.AutoSize = true;
            labelSVRDPublishYear.Location = new Point(10, 207);
            labelSVRDPublishYear.Name = "labelSVRDPublishYear";
            labelSVRDPublishYear.Size = new Size(73, 15);
            labelSVRDPublishYear.TabIndex = 10;
            labelSVRDPublishYear.Text = "Год издания";
            ttMain.SetToolTip(labelSVRDPublishYear, "Год публикации документа.\nПример: \"2017\".");
            // 
            // tbSVRDPublishYear
            // 
            tbSVRDPublishYear.Location = new Point(10, 227);
            tbSVRDPublishYear.Name = "tbSVRDPublishYear";
            tbSVRDPublishYear.Size = new Size(450, 23);
            tbSVRDPublishYear.TabIndex = 11;
            ttMain.SetToolTip(tbSVRDPublishYear, "Год публикации документа.\r\nПример: \"2017\".");
            // 
            // gbSVRegulatoryDocumentOptional
            // 
            gbSVRegulatoryDocumentOptional.Controls.Add(panelSVRegulatoryDocumentOptional);
            gbSVRegulatoryDocumentOptional.Location = new Point(10, 346);
            gbSVRegulatoryDocumentOptional.Name = "gbSVRegulatoryDocumentOptional";
            gbSVRegulatoryDocumentOptional.Size = new Size(488, 330);
            gbSVRegulatoryDocumentOptional.TabIndex = 3;
            gbSVRegulatoryDocumentOptional.TabStop = false;
            gbSVRegulatoryDocumentOptional.Text = "Необязательные поля";
            // 
            // panelSVRegulatoryDocumentOptional
            // 
            panelSVRegulatoryDocumentOptional.AutoScroll = true;
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDCountry);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDDocumentType);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDCountry);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDOfficialEdition);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDAdditions);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDOfficialEdition);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDAdditions);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDTitleTranslation);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDAbbreviation);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDTitleTranslation);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDAbbreviation);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDISBN);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDPagesCount);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDISBN);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDPagesCount);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDDeveloper);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDDeveloper);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDDocumentType);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDImplementDate);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDApprovalDate);
            panelSVRegulatoryDocumentOptional.Controls.Add(labelSVRDImplementDate);
            panelSVRegulatoryDocumentOptional.Controls.Add(tbSVRDApprovalDate);
            panelSVRegulatoryDocumentOptional.Location = new Point(10, 22);
            panelSVRegulatoryDocumentOptional.Name = "panelSVRegulatoryDocumentOptional";
            panelSVRegulatoryDocumentOptional.Size = new Size(473, 302);
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
            ttMain.SetToolTip(labelSVRDCountry, "Юрисдикция документа.\nПример: \"Российская Федерация\".");
            // 
            // labelSVRDDocumentType
            // 
            labelSVRDDocumentType.AutoSize = true;
            labelSVRDDocumentType.Location = new Point(0, 0);
            labelSVRDDocumentType.Name = "labelSVRDDocumentType";
            labelSVRDDocumentType.Size = new Size(88, 15);
            labelSVRDDocumentType.TabIndex = 0;
            labelSVRDDocumentType.Text = "Вид документа";
            ttMain.SetToolTip(labelSVRDDocumentType, "Уточняет тип документа (стандарт, закон).\nПример: \"национальный стандарт Российской Федерации\" или \"федеральный закон\".");
            // 
            // tbSVRDCountry
            // 
            tbSVRDCountry.Location = new Point(0, 491);
            tbSVRDCountry.Name = "tbSVRDCountry";
            tbSVRDCountry.Size = new Size(450, 23);
            tbSVRDCountry.TabIndex = 21;
            ttMain.SetToolTip(tbSVRDCountry, "Юрисдикция документа.\nПример: \"Российская Федерация\".");
            // 
            // tbSVRDOfficialEdition
            // 
            tbSVRDOfficialEdition.Location = new Point(0, 360);
            tbSVRDOfficialEdition.Name = "tbSVRDOfficialEdition";
            tbSVRDOfficialEdition.Size = new Size(450, 23);
            tbSVRDOfficialEdition.TabIndex = 13;
            ttMain.SetToolTip(tbSVRDOfficialEdition, "Указание официального статуса документа.\nПример: \"издание официальное\".");
            // 
            // labelSVRDAdditions
            // 
            labelSVRDAdditions.AutoSize = true;
            labelSVRDAdditions.Location = new Point(0, 429);
            labelSVRDAdditions.Name = "labelSVRDAdditions";
            labelSVRDAdditions.Size = new Size(149, 15);
            labelSVRDAdditions.TabIndex = 18;
            labelSVRDAdditions.Text = "Дополнения и изменения";
            ttMain.SetToolTip(labelSVRDAdditions, "Указание актуальности текста с датой изменений.\nПример: \"текст с изменениями и дополнениями на 1 августа 2017 года\".");
            // 
            // labelSVRDOfficialEdition
            // 
            labelSVRDOfficialEdition.AutoSize = true;
            labelSVRDOfficialEdition.Location = new Point(0, 342);
            labelSVRDOfficialEdition.Name = "labelSVRDOfficialEdition";
            labelSVRDOfficialEdition.Size = new Size(132, 15);
            labelSVRDOfficialEdition.TabIndex = 12;
            labelSVRDOfficialEdition.Text = "Издание официальное";
            ttMain.SetToolTip(labelSVRDOfficialEdition, "Указание официального статуса документа.\nПример: \"издание официальное\".");
            // 
            // tbSVRDAdditions
            // 
            tbSVRDAdditions.Location = new Point(0, 447);
            tbSVRDAdditions.Name = "tbSVRDAdditions";
            tbSVRDAdditions.Size = new Size(450, 23);
            tbSVRDAdditions.TabIndex = 19;
            ttMain.SetToolTip(tbSVRDAdditions, "Указание актуальности текста с датой изменений.\nПример: \"текст с изменениями и дополнениями на 1 августа 2017 года\".");
            // 
            // tbSVRDTitleTranslation
            // 
            tbSVRDTitleTranslation.Location = new Point(0, 312);
            tbSVRDTitleTranslation.Name = "tbSVRDTitleTranslation";
            tbSVRDTitleTranslation.Size = new Size(450, 23);
            tbSVRDTitleTranslation.TabIndex = 11;
            ttMain.SetToolTip(tbSVRDTitleTranslation, "Английский перевод названия (для ГОСТов).\nПример: \"= Organization and implementation of activity on international standardization in Russian Federation\".");
            // 
            // labelSVRDAbbreviation
            // 
            labelSVRDAbbreviation.AutoSize = true;
            labelSVRDAbbreviation.Location = new Point(0, 386);
            labelSVRDAbbreviation.Name = "labelSVRDAbbreviation";
            labelSVRDAbbreviation.Size = new Size(78, 15);
            labelSVRDAbbreviation.TabIndex = 16;
            labelSVRDAbbreviation.Text = "Сокращение";
            ttMain.SetToolTip(labelSVRDAbbreviation, "Краткое обозначение документа (для кодексов).\nПример: \"УК\".");
            // 
            // labelSVRDTitleTranslation
            // 
            labelSVRDTitleTranslation.AutoSize = true;
            labelSVRDTitleTranslation.Location = new Point(0, 292);
            labelSVRDTitleTranslation.Name = "labelSVRDTitleTranslation";
            labelSVRDTitleTranslation.Size = new Size(189, 15);
            labelSVRDTitleTranslation.TabIndex = 10;
            labelSVRDTitleTranslation.Text = "Перевод заглавия на английский";
            ttMain.SetToolTip(labelSVRDTitleTranslation, "Английский перевод названия (для ГОСТов).\nПример: \"= Organization and implementation of activity on international standardization in Russian Federation\".");
            // 
            // tbSVRDAbbreviation
            // 
            tbSVRDAbbreviation.Location = new Point(0, 404);
            tbSVRDAbbreviation.Name = "tbSVRDAbbreviation";
            tbSVRDAbbreviation.Size = new Size(450, 23);
            tbSVRDAbbreviation.TabIndex = 17;
            ttMain.SetToolTip(tbSVRDAbbreviation, "Краткое обозначение документа (для кодексов).\nПример: \"УК\".");
            // 
            // tbSVRDISBN
            // 
            tbSVRDISBN.Location = new Point(0, 262);
            tbSVRDISBN.Name = "tbSVRDISBN";
            tbSVRDISBN.Size = new Size(450, 23);
            tbSVRDISBN.TabIndex = 9;
            ttMain.SetToolTip(tbSVRDISBN, "Номер ISBN, если документ издан в книжной форме.\nПример: \"ISBN 978-5-04-004029-2\".");
            // 
            // labelSVRDPagesCount
            // 
            labelSVRDPagesCount.AutoSize = true;
            labelSVRDPagesCount.Location = new Point(0, 196);
            labelSVRDPagesCount.Name = "labelSVRDPagesCount";
            labelSVRDPagesCount.Size = new Size(120, 15);
            labelSVRDPagesCount.TabIndex = 14;
            labelSVRDPagesCount.Text = "Количество страниц";
            ttMain.SetToolTip(labelSVRDPagesCount, "Объем документа в страницах.\nПример: \"43 с.\" или \"350 с.\".");
            // 
            // labelSVRDISBN
            // 
            labelSVRDISBN.AutoSize = true;
            labelSVRDISBN.Location = new Point(0, 242);
            labelSVRDISBN.Name = "labelSVRDISBN";
            labelSVRDISBN.Size = new Size(32, 15);
            labelSVRDISBN.TabIndex = 8;
            labelSVRDISBN.Text = "ISBN";
            ttMain.SetToolTip(labelSVRDISBN, "Номер ISBN, если документ издан в книжной форме.\nПример: \"ISBN 978-5-04-004029-2\".");
            // 
            // tbSVRDPagesCount
            // 
            tbSVRDPagesCount.Location = new Point(0, 216);
            tbSVRDPagesCount.Name = "tbSVRDPagesCount";
            tbSVRDPagesCount.Size = new Size(450, 23);
            tbSVRDPagesCount.TabIndex = 15;
            ttMain.SetToolTip(tbSVRDPagesCount, "Объем документа в страницах.\nПример: \"43 с.\" или \"350 с.\".");
            // 
            // tbSVRDDeveloper
            // 
            tbSVRDDeveloper.Location = new Point(0, 170);
            tbSVRDDeveloper.Name = "tbSVRDDeveloper";
            tbSVRDDeveloper.Size = new Size(450, 23);
            tbSVRDDeveloper.TabIndex = 7;
            ttMain.SetToolTip(tbSVRDDeveloper, "Организация, разработавшая документ (для ГОСТов).\nПример: \"разработан Всероссийским научно-исследовательским институтом стандартизации и сертификации в машиностроении (ВНИИНМАШ)\".");
            // 
            // labelSVRDDeveloper
            // 
            labelSVRDDeveloper.AutoSize = true;
            labelSVRDDeveloper.Location = new Point(0, 150);
            labelSVRDDeveloper.Name = "labelSVRDDeveloper";
            labelSVRDDeveloper.Size = new Size(77, 15);
            labelSVRDDeveloper.TabIndex = 6;
            labelSVRDDeveloper.Text = "Разработчик";
            ttMain.SetToolTip(labelSVRDDeveloper, "Организация, разработавшая документ (для ГОСТов).\nПример: \"разработан Всероссийским научно-исследовательским институтом стандартизации и сертификации в машиностроении (ВНИИНМАШ)\".");
            // 
            // tbSVRDDocumentType
            // 
            tbSVRDDocumentType.Location = new Point(0, 20);
            tbSVRDDocumentType.Name = "tbSVRDDocumentType";
            tbSVRDDocumentType.Size = new Size(450, 23);
            tbSVRDDocumentType.TabIndex = 1;
            ttMain.SetToolTip(tbSVRDDocumentType, "Уточняет тип документа (стандарт, закон).\r\nПример: \"национальный стандарт Российской Федерации\" или \"федеральный закон\".");
            // 
            // tbSVRDImplementDate
            // 
            tbSVRDImplementDate.Location = new Point(0, 120);
            tbSVRDImplementDate.Name = "tbSVRDImplementDate";
            tbSVRDImplementDate.Size = new Size(450, 23);
            tbSVRDImplementDate.TabIndex = 5;
            ttMain.SetToolTip(tbSVRDImplementDate, "Дата начала действия или одобрения документа.\nПример: \"дата введения 2017-12-01\" или \"одобрен Советом Федерации 5 июня 1996 года\".");
            // 
            // labelSVRDApprovalDate
            // 
            labelSVRDApprovalDate.AutoSize = true;
            labelSVRDApprovalDate.Location = new Point(0, 50);
            labelSVRDApprovalDate.Name = "labelSVRDApprovalDate";
            labelSVRDApprovalDate.Size = new Size(163, 15);
            labelSVRDApprovalDate.TabIndex = 2;
            labelSVRDApprovalDate.Text = "Дата утверждения/принятия";
            ttMain.SetToolTip(labelSVRDApprovalDate, resources.GetString("labelSVRDApprovalDate.ToolTip"));
            // 
            // labelSVRDImplementDate
            // 
            labelSVRDImplementDate.AutoSize = true;
            labelSVRDImplementDate.Location = new Point(0, 100);
            labelSVRDImplementDate.Name = "labelSVRDImplementDate";
            labelSVRDImplementDate.Size = new Size(150, 15);
            labelSVRDImplementDate.TabIndex = 4;
            labelSVRDImplementDate.Text = "Дата введения/одобрения";
            ttMain.SetToolTip(labelSVRDImplementDate, "Дата начала действия или одобрения документа.\nПример: \"дата введения 2017-12-01\" или \"одобрен Советом Федерации 5 июня 1996 года\".");
            // 
            // tbSVRDApprovalDate
            // 
            tbSVRDApprovalDate.Location = new Point(0, 70);
            tbSVRDApprovalDate.Name = "tbSVRDApprovalDate";
            tbSVRDApprovalDate.Size = new Size(450, 23);
            tbSVRDApprovalDate.TabIndex = 3;
            ttMain.SetToolTip(tbSVRDApprovalDate, resources.GetString("tbSVRDApprovalDate.ToolTip"));
            // 
            // tpSVDissertationAbstract
            // 
            tpSVDissertationAbstract.BackColor = SystemColors.Control;
            tpSVDissertationAbstract.Controls.Add(gbSVDissertationAbstractRequired);
            tpSVDissertationAbstract.Controls.Add(gbSVDissertationAbstractOptional);
            tpSVDissertationAbstract.Location = new Point(4, 24);
            tpSVDissertationAbstract.Name = "tpSVDissertationAbstract";
            tpSVDissertationAbstract.Padding = new Padding(3);
            tpSVDissertationAbstract.Size = new Size(505, 681);
            tpSVDissertationAbstract.TabIndex = 2;
            tpSVDissertationAbstract.Text = "Автореферат диссертации";
            // 
            // gbSVDissertationAbstractRequired
            // 
            gbSVDissertationAbstractRequired.Controls.Add(panelSVDissertationAbstractRequired);
            gbSVDissertationAbstractRequired.Location = new Point(10, 10);
            gbSVDissertationAbstractRequired.Name = "gbSVDissertationAbstractRequired";
            gbSVDissertationAbstractRequired.Size = new Size(488, 330);
            gbSVDissertationAbstractRequired.TabIndex = 4;
            gbSVDissertationAbstractRequired.TabStop = false;
            gbSVDissertationAbstractRequired.Text = "Обязательные поля";
            // 
            // panelSVDissertationAbstractRequired
            // 
            panelSVDissertationAbstractRequired.AutoScroll = true;
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDADefenseLocation);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDAAuthor);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDADefenseLocation);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDAPublishingLocation);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDAPagesCount);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDAPublishingLocation);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDAPagesCount);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDADegree);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDAPublishYear);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDADegree);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDAPublishYear);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDASpecialty);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDATitle);
            panelSVDissertationAbstractRequired.Controls.Add(labelSVDASpecialty);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDATitle);
            panelSVDissertationAbstractRequired.Controls.Add(tbSVDAAuthor);
            panelSVDissertationAbstractRequired.Location = new Point(10, 22);
            panelSVDissertationAbstractRequired.Name = "panelSVDissertationAbstractRequired";
            panelSVDissertationAbstractRequired.Size = new Size(472, 302);
            panelSVDissertationAbstractRequired.TabIndex = 8;
            // 
            // labelSVDADefenseLocation
            // 
            labelSVDADefenseLocation.AutoSize = true;
            labelSVDADefenseLocation.Location = new Point(0, 326);
            labelSVDADefenseLocation.Name = "labelSVDADefenseLocation";
            labelSVDADefenseLocation.Size = new Size(88, 15);
            labelSVDADefenseLocation.TabIndex = 20;
            labelSVDADefenseLocation.Text = "Место защиты";
            // 
            // labelSVDAAuthor
            // 
            labelSVDAAuthor.AutoSize = true;
            labelSVDAAuthor.Location = new Point(0, 0);
            labelSVDAAuthor.Name = "labelSVDAAuthor";
            labelSVDAAuthor.Size = new Size(40, 15);
            labelSVDAAuthor.TabIndex = 4;
            labelSVDAAuthor.Text = "Автор";
            // 
            // tbSVDADefenseLocation
            // 
            tbSVDADefenseLocation.Location = new Point(0, 346);
            tbSVDADefenseLocation.Name = "tbSVDADefenseLocation";
            tbSVDADefenseLocation.Size = new Size(450, 23);
            tbSVDADefenseLocation.TabIndex = 21;
            // 
            // tbSVDAPublishingLocation
            // 
            tbSVDAPublishingLocation.Location = new Point(0, 207);
            tbSVDAPublishingLocation.Name = "tbSVDAPublishingLocation";
            tbSVDAPublishingLocation.Size = new Size(450, 23);
            tbSVDAPublishingLocation.TabIndex = 11;
            // 
            // labelSVDAPagesCount
            // 
            labelSVDAPagesCount.AutoSize = true;
            labelSVDAPagesCount.Location = new Point(0, 281);
            labelSVDAPagesCount.Name = "labelSVDAPagesCount";
            labelSVDAPagesCount.Size = new Size(120, 15);
            labelSVDAPagesCount.TabIndex = 18;
            labelSVDAPagesCount.Text = "Количество страниц";
            // 
            // labelSVDAPublishingLocation
            // 
            labelSVDAPublishingLocation.AutoSize = true;
            labelSVDAPublishingLocation.Location = new Point(0, 187);
            labelSVDAPublishingLocation.Name = "labelSVDAPublishingLocation";
            labelSVDAPublishingLocation.Size = new Size(89, 15);
            labelSVDAPublishingLocation.TabIndex = 10;
            labelSVDAPublishingLocation.Text = "Место издания";
            // 
            // tbSVDAPagesCount
            // 
            tbSVDAPagesCount.Location = new Point(0, 301);
            tbSVDAPagesCount.Name = "tbSVDAPagesCount";
            tbSVDAPagesCount.Size = new Size(450, 23);
            tbSVDAPagesCount.TabIndex = 19;
            // 
            // tbSVDADegree
            // 
            tbSVDADegree.Location = new Point(0, 161);
            tbSVDADegree.Name = "tbSVDADegree";
            tbSVDADegree.Size = new Size(450, 23);
            tbSVDADegree.TabIndex = 9;
            // 
            // labelSVDAPublishYear
            // 
            labelSVDAPublishYear.AutoSize = true;
            labelSVDAPublishYear.Location = new Point(0, 234);
            labelSVDAPublishYear.Name = "labelSVDAPublishYear";
            labelSVDAPublishYear.Size = new Size(73, 15);
            labelSVDAPublishYear.TabIndex = 16;
            labelSVDAPublishYear.Text = "Год издания";
            // 
            // labelSVDADegree
            // 
            labelSVDADegree.AutoSize = true;
            labelSVDADegree.Location = new Point(0, 141);
            labelSVDADegree.Name = "labelSVDADegree";
            labelSVDADegree.Size = new Size(52, 15);
            labelSVDADegree.TabIndex = 8;
            labelSVDADegree.Text = "Степень";
            // 
            // tbSVDAPublishYear
            // 
            tbSVDAPublishYear.Location = new Point(0, 254);
            tbSVDAPublishYear.Name = "tbSVDAPublishYear";
            tbSVDAPublishYear.Size = new Size(450, 23);
            tbSVDAPublishYear.TabIndex = 17;
            // 
            // tbSVDASpecialty
            // 
            tbSVDASpecialty.Location = new Point(0, 115);
            tbSVDASpecialty.Name = "tbSVDASpecialty";
            tbSVDASpecialty.Size = new Size(450, 23);
            tbSVDASpecialty.TabIndex = 7;
            // 
            // labelSVDATitle
            // 
            labelSVDATitle.AutoSize = true;
            labelSVDATitle.Location = new Point(0, 47);
            labelSVDATitle.Name = "labelSVDATitle";
            labelSVDATitle.Size = new Size(57, 15);
            labelSVDATitle.TabIndex = 14;
            labelSVDATitle.Text = "Заглавие";
            // 
            // labelSVDASpecialty
            // 
            labelSVDASpecialty.AutoSize = true;
            labelSVDASpecialty.Location = new Point(0, 95);
            labelSVDASpecialty.Name = "labelSVDASpecialty";
            labelSVDASpecialty.Size = new Size(185, 15);
            labelSVDASpecialty.TabIndex = 6;
            labelSVDASpecialty.Text = "Специальность (код и название)";
            // 
            // tbSVDATitle
            // 
            tbSVDATitle.Location = new Point(0, 67);
            tbSVDATitle.Name = "tbSVDATitle";
            tbSVDATitle.Size = new Size(450, 23);
            tbSVDATitle.TabIndex = 15;
            // 
            // tbSVDAAuthor
            // 
            tbSVDAAuthor.Location = new Point(0, 20);
            tbSVDAAuthor.Name = "tbSVDAAuthor";
            tbSVDAAuthor.Size = new Size(450, 23);
            tbSVDAAuthor.TabIndex = 5;
            // 
            // gbSVDissertationAbstractOptional
            // 
            gbSVDissertationAbstractOptional.Controls.Add(labelSVDADocumentType);
            gbSVDissertationAbstractOptional.Controls.Add(tbSVDADocumentType);
            gbSVDissertationAbstractOptional.Controls.Add(labelSVDAAuthorFullName);
            gbSVDissertationAbstractOptional.Controls.Add(tbSVDAAuthorFullName);
            gbSVDissertationAbstractOptional.Controls.Add(labelSVDAOrganization);
            gbSVDissertationAbstractOptional.Controls.Add(tbSVDAOrganization);
            gbSVDissertationAbstractOptional.Controls.Add(labelSVDABibliography);
            gbSVDissertationAbstractOptional.Controls.Add(tbSVDABibliography);
            gbSVDissertationAbstractOptional.Location = new Point(10, 346);
            gbSVDissertationAbstractOptional.Name = "gbSVDissertationAbstractOptional";
            gbSVDissertationAbstractOptional.Size = new Size(488, 330);
            gbSVDissertationAbstractOptional.TabIndex = 5;
            gbSVDissertationAbstractOptional.TabStop = false;
            gbSVDissertationAbstractOptional.Text = "Необязательные поля";
            // 
            // labelSVDADocumentType
            // 
            labelSVDADocumentType.AutoSize = true;
            labelSVDADocumentType.Location = new Point(10, 28);
            labelSVDADocumentType.Name = "labelSVDADocumentType";
            labelSVDADocumentType.Size = new Size(88, 15);
            labelSVDADocumentType.TabIndex = 0;
            labelSVDADocumentType.Text = "Вид документа";
            // 
            // tbSVDADocumentType
            // 
            tbSVDADocumentType.Location = new Point(10, 48);
            tbSVDADocumentType.Name = "tbSVDADocumentType";
            tbSVDADocumentType.Size = new Size(450, 23);
            tbSVDADocumentType.TabIndex = 1;
            // 
            // labelSVDAAuthorFullName
            // 
            labelSVDAAuthorFullName.AutoSize = true;
            labelSVDAAuthorFullName.Location = new Point(10, 78);
            labelSVDAAuthorFullName.Name = "labelSVDAAuthorFullName";
            labelSVDAAuthorFullName.Size = new Size(115, 15);
            labelSVDAAuthorFullName.TabIndex = 2;
            labelSVDAAuthorFullName.Text = "Полное имя автора";
            // 
            // tbSVDAAuthorFullName
            // 
            tbSVDAAuthorFullName.Location = new Point(10, 98);
            tbSVDAAuthorFullName.Name = "tbSVDAAuthorFullName";
            tbSVDAAuthorFullName.Size = new Size(450, 23);
            tbSVDAAuthorFullName.TabIndex = 3;
            // 
            // labelSVDAOrganization
            // 
            labelSVDAOrganization.AutoSize = true;
            labelSVDAOrganization.Location = new Point(10, 128);
            labelSVDAOrganization.Name = "labelSVDAOrganization";
            labelSVDAOrganization.Size = new Size(79, 15);
            labelSVDAOrganization.TabIndex = 4;
            labelSVDAOrganization.Text = "Организация";
            // 
            // tbSVDAOrganization
            // 
            tbSVDAOrganization.Location = new Point(10, 148);
            tbSVDAOrganization.Name = "tbSVDAOrganization";
            tbSVDAOrganization.Size = new Size(450, 23);
            tbSVDAOrganization.TabIndex = 5;
            // 
            // labelSVDABibliography
            // 
            labelSVDABibliography.AutoSize = true;
            labelSVDABibliography.Location = new Point(10, 178);
            labelSVDABibliography.Name = "labelSVDABibliography";
            labelSVDABibliography.Size = new Size(199, 15);
            labelSVDABibliography.TabIndex = 6;
            labelSVDABibliography.Text = "Библиография (диапазон страниц)";
            // 
            // tbSVDABibliography
            // 
            tbSVDABibliography.Location = new Point(10, 198);
            tbSVDABibliography.Name = "tbSVDABibliography";
            tbSVDABibliography.Size = new Size(450, 23);
            tbSVDABibliography.TabIndex = 7;
            // 
            // tpSVDissertation
            // 
            tpSVDissertation.BackColor = SystemColors.Control;
            tpSVDissertation.Controls.Add(gbSVDissertationRequired);
            tpSVDissertation.Controls.Add(gbSVDissertationOptional);
            tpSVDissertation.Location = new Point(4, 24);
            tpSVDissertation.Name = "tpSVDissertation";
            tpSVDissertation.Padding = new Padding(3);
            tpSVDissertation.Size = new Size(505, 681);
            tpSVDissertation.TabIndex = 3;
            tpSVDissertation.Text = "Диссертация";
            // 
            // gbSVDissertationRequired
            // 
            gbSVDissertationRequired.Controls.Add(panelSVDissertationRequired);
            gbSVDissertationRequired.Location = new Point(10, 10);
            gbSVDissertationRequired.Name = "gbSVDissertationRequired";
            gbSVDissertationRequired.Size = new Size(488, 330);
            gbSVDissertationRequired.TabIndex = 6;
            gbSVDissertationRequired.TabStop = false;
            gbSVDissertationRequired.Text = "Обязательные поля";
            // 
            // panelSVDissertationRequired
            // 
            panelSVDissertationRequired.AutoScroll = true;
            panelSVDissertationRequired.Controls.Add(labelSVDPagesCount);
            panelSVDissertationRequired.Controls.Add(labelSVDAuthor);
            panelSVDissertationRequired.Controls.Add(tbSVDPagesCount);
            panelSVDissertationRequired.Controls.Add(tbSVDPublishingLocation);
            panelSVDissertationRequired.Controls.Add(labelSVDPublishYear);
            panelSVDissertationRequired.Controls.Add(labelSVDPublishingLocation);
            panelSVDissertationRequired.Controls.Add(tbSVDPublishYear);
            panelSVDissertationRequired.Controls.Add(tbSVDDegree);
            panelSVDissertationRequired.Controls.Add(labelSVDTitle);
            panelSVDissertationRequired.Controls.Add(labelSVDDegree);
            panelSVDissertationRequired.Controls.Add(tbSVDTitle);
            panelSVDissertationRequired.Controls.Add(tbSVDSpecialty);
            panelSVDissertationRequired.Controls.Add(labelSVDSpecialty);
            panelSVDissertationRequired.Controls.Add(tbSVDAuthor);
            panelSVDissertationRequired.Location = new Point(10, 22);
            panelSVDissertationRequired.Name = "panelSVDissertationRequired";
            panelSVDissertationRequired.Size = new Size(472, 302);
            panelSVDissertationRequired.TabIndex = 8;
            // 
            // labelSVDPagesCount
            // 
            labelSVDPagesCount.AutoSize = true;
            labelSVDPagesCount.Location = new Point(0, 281);
            labelSVDPagesCount.Name = "labelSVDPagesCount";
            labelSVDPagesCount.Size = new Size(120, 15);
            labelSVDPagesCount.TabIndex = 18;
            labelSVDPagesCount.Text = "Количество страниц";
            // 
            // labelSVDAuthor
            // 
            labelSVDAuthor.AutoSize = true;
            labelSVDAuthor.Location = new Point(0, 0);
            labelSVDAuthor.Name = "labelSVDAuthor";
            labelSVDAuthor.Size = new Size(40, 15);
            labelSVDAuthor.TabIndex = 4;
            labelSVDAuthor.Text = "Автор";
            // 
            // tbSVDPagesCount
            // 
            tbSVDPagesCount.Location = new Point(0, 301);
            tbSVDPagesCount.Name = "tbSVDPagesCount";
            tbSVDPagesCount.Size = new Size(450, 23);
            tbSVDPagesCount.TabIndex = 19;
            // 
            // tbSVDPublishingLocation
            // 
            tbSVDPublishingLocation.Location = new Point(0, 207);
            tbSVDPublishingLocation.Name = "tbSVDPublishingLocation";
            tbSVDPublishingLocation.Size = new Size(450, 23);
            tbSVDPublishingLocation.TabIndex = 11;
            // 
            // labelSVDPublishYear
            // 
            labelSVDPublishYear.AutoSize = true;
            labelSVDPublishYear.Location = new Point(0, 234);
            labelSVDPublishYear.Name = "labelSVDPublishYear";
            labelSVDPublishYear.Size = new Size(73, 15);
            labelSVDPublishYear.TabIndex = 16;
            labelSVDPublishYear.Text = "Год издания";
            // 
            // labelSVDPublishingLocation
            // 
            labelSVDPublishingLocation.AutoSize = true;
            labelSVDPublishingLocation.Location = new Point(0, 187);
            labelSVDPublishingLocation.Name = "labelSVDPublishingLocation";
            labelSVDPublishingLocation.Size = new Size(89, 15);
            labelSVDPublishingLocation.TabIndex = 10;
            labelSVDPublishingLocation.Text = "Место издания";
            // 
            // tbSVDPublishYear
            // 
            tbSVDPublishYear.Location = new Point(0, 254);
            tbSVDPublishYear.Name = "tbSVDPublishYear";
            tbSVDPublishYear.Size = new Size(450, 23);
            tbSVDPublishYear.TabIndex = 17;
            // 
            // tbSVDDegree
            // 
            tbSVDDegree.Location = new Point(0, 161);
            tbSVDDegree.Name = "tbSVDDegree";
            tbSVDDegree.Size = new Size(450, 23);
            tbSVDDegree.TabIndex = 9;
            // 
            // labelSVDTitle
            // 
            labelSVDTitle.AutoSize = true;
            labelSVDTitle.Location = new Point(0, 47);
            labelSVDTitle.Name = "labelSVDTitle";
            labelSVDTitle.Size = new Size(57, 15);
            labelSVDTitle.TabIndex = 14;
            labelSVDTitle.Text = "Заглавие";
            // 
            // labelSVDDegree
            // 
            labelSVDDegree.AutoSize = true;
            labelSVDDegree.Location = new Point(0, 141);
            labelSVDDegree.Name = "labelSVDDegree";
            labelSVDDegree.Size = new Size(52, 15);
            labelSVDDegree.TabIndex = 8;
            labelSVDDegree.Text = "Степень";
            // 
            // tbSVDTitle
            // 
            tbSVDTitle.Location = new Point(0, 67);
            tbSVDTitle.Name = "tbSVDTitle";
            tbSVDTitle.Size = new Size(450, 23);
            tbSVDTitle.TabIndex = 15;
            // 
            // tbSVDSpecialty
            // 
            tbSVDSpecialty.Location = new Point(0, 115);
            tbSVDSpecialty.Name = "tbSVDSpecialty";
            tbSVDSpecialty.Size = new Size(450, 23);
            tbSVDSpecialty.TabIndex = 7;
            // 
            // labelSVDSpecialty
            // 
            labelSVDSpecialty.AutoSize = true;
            labelSVDSpecialty.Location = new Point(0, 95);
            labelSVDSpecialty.Name = "labelSVDSpecialty";
            labelSVDSpecialty.Size = new Size(185, 15);
            labelSVDSpecialty.TabIndex = 6;
            labelSVDSpecialty.Text = "Специальность (код и название)";
            // 
            // tbSVDAuthor
            // 
            tbSVDAuthor.Location = new Point(0, 20);
            tbSVDAuthor.Name = "tbSVDAuthor";
            tbSVDAuthor.Size = new Size(450, 23);
            tbSVDAuthor.TabIndex = 5;
            // 
            // gbSVDissertationOptional
            // 
            gbSVDissertationOptional.Controls.Add(labelSVDDocumentType);
            gbSVDissertationOptional.Controls.Add(tbSVDDocumentType);
            gbSVDissertationOptional.Controls.Add(labelSVDAuthorFullName);
            gbSVDissertationOptional.Controls.Add(tbSVDAuthorFullName);
            gbSVDissertationOptional.Controls.Add(labelSVDOrganization);
            gbSVDissertationOptional.Controls.Add(tbSVDOrganization);
            gbSVDissertationOptional.Controls.Add(labelSVDBibliography);
            gbSVDissertationOptional.Controls.Add(tbSVDBibliography);
            gbSVDissertationOptional.Location = new Point(10, 346);
            gbSVDissertationOptional.Name = "gbSVDissertationOptional";
            gbSVDissertationOptional.Size = new Size(488, 330);
            gbSVDissertationOptional.TabIndex = 7;
            gbSVDissertationOptional.TabStop = false;
            gbSVDissertationOptional.Text = "Необязательные поля";
            // 
            // labelSVDDocumentType
            // 
            labelSVDDocumentType.AutoSize = true;
            labelSVDDocumentType.Location = new Point(10, 28);
            labelSVDDocumentType.Name = "labelSVDDocumentType";
            labelSVDDocumentType.Size = new Size(88, 15);
            labelSVDDocumentType.TabIndex = 0;
            labelSVDDocumentType.Text = "Вид документа";
            // 
            // tbSVDDocumentType
            // 
            tbSVDDocumentType.Location = new Point(10, 48);
            tbSVDDocumentType.Name = "tbSVDDocumentType";
            tbSVDDocumentType.Size = new Size(450, 23);
            tbSVDDocumentType.TabIndex = 1;
            // 
            // labelSVDAuthorFullName
            // 
            labelSVDAuthorFullName.AutoSize = true;
            labelSVDAuthorFullName.Location = new Point(10, 78);
            labelSVDAuthorFullName.Name = "labelSVDAuthorFullName";
            labelSVDAuthorFullName.Size = new Size(115, 15);
            labelSVDAuthorFullName.TabIndex = 2;
            labelSVDAuthorFullName.Text = "Полное имя автора";
            // 
            // tbSVDAuthorFullName
            // 
            tbSVDAuthorFullName.Location = new Point(10, 98);
            tbSVDAuthorFullName.Name = "tbSVDAuthorFullName";
            tbSVDAuthorFullName.Size = new Size(450, 23);
            tbSVDAuthorFullName.TabIndex = 3;
            // 
            // labelSVDOrganization
            // 
            labelSVDOrganization.AutoSize = true;
            labelSVDOrganization.Location = new Point(10, 128);
            labelSVDOrganization.Name = "labelSVDOrganization";
            labelSVDOrganization.Size = new Size(79, 15);
            labelSVDOrganization.TabIndex = 4;
            labelSVDOrganization.Text = "Организация";
            // 
            // tbSVDOrganization
            // 
            tbSVDOrganization.Location = new Point(10, 148);
            tbSVDOrganization.Name = "tbSVDOrganization";
            tbSVDOrganization.Size = new Size(450, 23);
            tbSVDOrganization.TabIndex = 5;
            // 
            // labelSVDBibliography
            // 
            labelSVDBibliography.AutoSize = true;
            labelSVDBibliography.Location = new Point(10, 178);
            labelSVDBibliography.Name = "labelSVDBibliography";
            labelSVDBibliography.Size = new Size(199, 15);
            labelSVDBibliography.TabIndex = 6;
            labelSVDBibliography.Text = "Библиография (диапазон страниц)";
            // 
            // tbSVDBibliography
            // 
            tbSVDBibliography.Location = new Point(10, 198);
            tbSVDBibliography.Name = "tbSVDBibliography";
            tbSVDBibliography.Size = new Size(450, 23);
            tbSVDBibliography.TabIndex = 7;
            // 
            // tpMultiVolume
            // 
            tpMultiVolume.BackColor = SystemColors.Control;
            tpMultiVolume.Controls.Add(tcMVTypes);
            tpMultiVolume.Location = new Point(4, 24);
            tpMultiVolume.Name = "tpMultiVolume";
            tpMultiVolume.Padding = new Padding(3);
            tpMultiVolume.Size = new Size(521, 720);
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
            tcMVTypes.Size = new Size(513, 709);
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
            tpMVWholeMultivolume.Size = new Size(505, 681);
            tpMVWholeMultivolume.TabIndex = 0;
            tpMVWholeMultivolume.Text = "Многотомное издание в целом";
            // 
            // gbMVWholeMultivolumeRequired
            // 
            gbMVWholeMultivolumeRequired.Controls.Add(panelMVWholeMultivolumeRequired);
            gbMVWholeMultivolumeRequired.Location = new Point(10, 10);
            gbMVWholeMultivolumeRequired.Name = "gbMVWholeMultivolumeRequired";
            gbMVWholeMultivolumeRequired.Size = new Size(488, 330);
            gbMVWholeMultivolumeRequired.TabIndex = 0;
            gbMVWholeMultivolumeRequired.TabStop = false;
            gbMVWholeMultivolumeRequired.Text = "Обязательные поля";
            // 
            // panelMVWholeMultivolumeRequired
            // 
            panelMVWholeMultivolumeRequired.AutoScroll = true;
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMPagesCount);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMAuthors);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMPagesCount);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMPublishYear);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMPublishYear);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMAuthors);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMPublisher);
            panelMVWholeMultivolumeRequired.Controls.Add(buttonMVWMAuthorsAdd);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMPublisher);
            panelMVWholeMultivolumeRequired.Controls.Add(lbMVWMAuthors);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMPublishingLocation);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMTitle);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMPublishingLocation);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMTitle);
            panelMVWholeMultivolumeRequired.Controls.Add(tbMVWMVolumesNumber);
            panelMVWholeMultivolumeRequired.Controls.Add(labelMVWMVolumesNumber);
            panelMVWholeMultivolumeRequired.Location = new Point(10, 22);
            panelMVWholeMultivolumeRequired.Name = "panelMVWholeMultivolumeRequired";
            panelMVWholeMultivolumeRequired.Size = new Size(473, 302);
            panelMVWholeMultivolumeRequired.TabIndex = 0;
            // 
            // labelMVWMPagesCount
            // 
            labelMVWMPagesCount.AutoSize = true;
            labelMVWMPagesCount.Location = new Point(0, 366);
            labelMVWMPagesCount.Name = "labelMVWMPagesCount";
            labelMVWMPagesCount.Size = new Size(120, 15);
            labelMVWMPagesCount.TabIndex = 14;
            labelMVWMPagesCount.Text = "Количество страниц";
            // 
            // labelMVWMAuthors
            // 
            labelMVWMAuthors.AutoSize = true;
            labelMVWMAuthors.Location = new Point(0, 0);
            labelMVWMAuthors.Name = "labelMVWMAuthors";
            labelMVWMAuthors.Size = new Size(57, 15);
            labelMVWMAuthors.TabIndex = 0;
            labelMVWMAuthors.Text = "Автор(ы)";
            // 
            // tbMVWMPagesCount
            // 
            tbMVWMPagesCount.Location = new Point(0, 386);
            tbMVWMPagesCount.Name = "tbMVWMPagesCount";
            tbMVWMPagesCount.Size = new Size(450, 23);
            tbMVWMPagesCount.TabIndex = 15;
            // 
            // tbMVWMPublishYear
            // 
            tbMVWMPublishYear.Location = new Point(0, 340);
            tbMVWMPublishYear.Name = "tbMVWMPublishYear";
            tbMVWMPublishYear.Size = new Size(450, 23);
            tbMVWMPublishYear.TabIndex = 13;
            // 
            // labelMVWMPublishYear
            // 
            labelMVWMPublishYear.AutoSize = true;
            labelMVWMPublishYear.Location = new Point(0, 320);
            labelMVWMPublishYear.Name = "labelMVWMPublishYear";
            labelMVWMPublishYear.Size = new Size(73, 15);
            labelMVWMPublishYear.TabIndex = 12;
            labelMVWMPublishYear.Text = "Год издания";
            // 
            // tbMVWMAuthors
            // 
            tbMVWMAuthors.Location = new Point(0, 20);
            tbMVWMAuthors.Name = "tbMVWMAuthors";
            tbMVWMAuthors.Size = new Size(350, 23);
            tbMVWMAuthors.TabIndex = 1;
            // 
            // tbMVWMPublisher
            // 
            tbMVWMPublisher.Location = new Point(0, 290);
            tbMVWMPublisher.Name = "tbMVWMPublisher";
            tbMVWMPublisher.Size = new Size(450, 23);
            tbMVWMPublisher.TabIndex = 11;
            // 
            // buttonMVWMAuthorsAdd
            // 
            buttonMVWMAuthorsAdd.Location = new Point(360, 20);
            buttonMVWMAuthorsAdd.Name = "buttonMVWMAuthorsAdd";
            buttonMVWMAuthorsAdd.Size = new Size(90, 23);
            buttonMVWMAuthorsAdd.TabIndex = 2;
            buttonMVWMAuthorsAdd.Text = "Добавить";
            buttonMVWMAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // labelMVWMPublisher
            // 
            labelMVWMPublisher.AutoSize = true;
            labelMVWMPublisher.Location = new Point(0, 270);
            labelMVWMPublisher.Name = "labelMVWMPublisher";
            labelMVWMPublisher.Size = new Size(81, 15);
            labelMVWMPublisher.TabIndex = 10;
            labelMVWMPublisher.Text = "Издательство";
            // 
            // lbMVWMAuthors
            // 
            lbMVWMAuthors.ItemHeight = 15;
            lbMVWMAuthors.Location = new Point(0, 50);
            lbMVWMAuthors.Name = "lbMVWMAuthors";
            lbMVWMAuthors.Size = new Size(450, 64);
            lbMVWMAuthors.TabIndex = 3;
            // 
            // tbMVWMPublishingLocation
            // 
            tbMVWMPublishingLocation.Location = new Point(0, 240);
            tbMVWMPublishingLocation.Name = "tbMVWMPublishingLocation";
            tbMVWMPublishingLocation.Size = new Size(450, 23);
            tbMVWMPublishingLocation.TabIndex = 9;
            // 
            // labelMVWMTitle
            // 
            labelMVWMTitle.AutoSize = true;
            labelMVWMTitle.Location = new Point(0, 120);
            labelMVWMTitle.Name = "labelMVWMTitle";
            labelMVWMTitle.Size = new Size(57, 15);
            labelMVWMTitle.TabIndex = 4;
            labelMVWMTitle.Text = "Заглавие";
            // 
            // labelMVWMPublishingLocation
            // 
            labelMVWMPublishingLocation.AutoSize = true;
            labelMVWMPublishingLocation.Location = new Point(0, 220);
            labelMVWMPublishingLocation.Name = "labelMVWMPublishingLocation";
            labelMVWMPublishingLocation.Size = new Size(89, 15);
            labelMVWMPublishingLocation.TabIndex = 8;
            labelMVWMPublishingLocation.Text = "Место издания";
            // 
            // tbMVWMTitle
            // 
            tbMVWMTitle.Location = new Point(0, 140);
            tbMVWMTitle.Name = "tbMVWMTitle";
            tbMVWMTitle.Size = new Size(450, 23);
            tbMVWMTitle.TabIndex = 5;
            // 
            // tbMVWMVolumesNumber
            // 
            tbMVWMVolumesNumber.Location = new Point(0, 190);
            tbMVWMVolumesNumber.Name = "tbMVWMVolumesNumber";
            tbMVWMVolumesNumber.Size = new Size(450, 23);
            tbMVWMVolumesNumber.TabIndex = 7;
            // 
            // labelMVWMVolumesNumber
            // 
            labelMVWMVolumesNumber.AutoSize = true;
            labelMVWMVolumesNumber.Location = new Point(0, 170);
            labelMVWMVolumesNumber.Name = "labelMVWMVolumesNumber";
            labelMVWMVolumesNumber.Size = new Size(109, 15);
            labelMVWMVolumesNumber.TabIndex = 6;
            labelMVWMVolumesNumber.Text = "Количество томов";
            // 
            // gbMVWholeMultivolumeOptional
            // 
            gbMVWholeMultivolumeOptional.Controls.Add(labelMVWMDocumentType);
            gbMVWholeMultivolumeOptional.Controls.Add(labelMVWMSeries);
            gbMVWholeMultivolumeOptional.Controls.Add(tbMVWMSeries);
            gbMVWholeMultivolumeOptional.Controls.Add(labelMVWMResponsibilityArea);
            gbMVWholeMultivolumeOptional.Controls.Add(tbMVWMResponsibilityArea);
            gbMVWholeMultivolumeOptional.Controls.Add(labelMVWMEditionNumber);
            gbMVWholeMultivolumeOptional.Controls.Add(labelMVWMEditor);
            gbMVWholeMultivolumeOptional.Controls.Add(tbMVWMDocumentType);
            gbMVWholeMultivolumeOptional.Controls.Add(labelMVWMISBN);
            gbMVWholeMultivolumeOptional.Controls.Add(tbMVWMEditionNumber);
            gbMVWholeMultivolumeOptional.Controls.Add(tbMVWMEditor);
            gbMVWholeMultivolumeOptional.Controls.Add(tbMVWMISBN);
            gbMVWholeMultivolumeOptional.Location = new Point(10, 346);
            gbMVWholeMultivolumeOptional.Name = "gbMVWholeMultivolumeOptional";
            gbMVWholeMultivolumeOptional.Size = new Size(488, 330);
            gbMVWholeMultivolumeOptional.TabIndex = 1;
            gbMVWholeMultivolumeOptional.TabStop = false;
            gbMVWholeMultivolumeOptional.Text = "Необязательные поля";
            // 
            // labelMVWMDocumentType
            // 
            labelMVWMDocumentType.AutoSize = true;
            labelMVWMDocumentType.Location = new Point(10, 21);
            labelMVWMDocumentType.Name = "labelMVWMDocumentType";
            labelMVWMDocumentType.Size = new Size(88, 15);
            labelMVWMDocumentType.TabIndex = 0;
            labelMVWMDocumentType.Text = "Вид документа";
            // 
            // labelMVWMSeries
            // 
            labelMVWMSeries.AutoSize = true;
            labelMVWMSeries.Location = new Point(10, 221);
            labelMVWMSeries.Name = "labelMVWMSeries";
            labelMVWMSeries.Size = new Size(41, 15);
            labelMVWMSeries.TabIndex = 8;
            labelMVWMSeries.Text = "Серия";
            // 
            // tbMVWMSeries
            // 
            tbMVWMSeries.Location = new Point(10, 241);
            tbMVWMSeries.Name = "tbMVWMSeries";
            tbMVWMSeries.Size = new Size(450, 23);
            tbMVWMSeries.TabIndex = 9;
            // 
            // labelMVWMResponsibilityArea
            // 
            labelMVWMResponsibilityArea.AutoSize = true;
            labelMVWMResponsibilityArea.Location = new Point(10, 71);
            labelMVWMResponsibilityArea.Name = "labelMVWMResponsibilityArea";
            labelMVWMResponsibilityArea.Size = new Size(147, 15);
            labelMVWMResponsibilityArea.TabIndex = 2;
            labelMVWMResponsibilityArea.Text = "Область ответственности";
            // 
            // tbMVWMResponsibilityArea
            // 
            tbMVWMResponsibilityArea.Location = new Point(10, 91);
            tbMVWMResponsibilityArea.Name = "tbMVWMResponsibilityArea";
            tbMVWMResponsibilityArea.Size = new Size(450, 23);
            tbMVWMResponsibilityArea.TabIndex = 3;
            // 
            // labelMVWMEditionNumber
            // 
            labelMVWMEditionNumber.AutoSize = true;
            labelMVWMEditionNumber.Location = new Point(10, 171);
            labelMVWMEditionNumber.Name = "labelMVWMEditionNumber";
            labelMVWMEditionNumber.Size = new Size(92, 15);
            labelMVWMEditionNumber.TabIndex = 6;
            labelMVWMEditionNumber.Text = "Номер издания";
            // 
            // labelMVWMEditor
            // 
            labelMVWMEditor.AutoSize = true;
            labelMVWMEditor.Location = new Point(10, 121);
            labelMVWMEditor.Name = "labelMVWMEditor";
            labelMVWMEditor.Size = new Size(57, 15);
            labelMVWMEditor.TabIndex = 4;
            labelMVWMEditor.Text = "Редактор";
            // 
            // tbMVWMDocumentType
            // 
            tbMVWMDocumentType.Location = new Point(10, 41);
            tbMVWMDocumentType.Name = "tbMVWMDocumentType";
            tbMVWMDocumentType.Size = new Size(450, 23);
            tbMVWMDocumentType.TabIndex = 1;
            // 
            // labelMVWMISBN
            // 
            labelMVWMISBN.AutoSize = true;
            labelMVWMISBN.Location = new Point(10, 271);
            labelMVWMISBN.Name = "labelMVWMISBN";
            labelMVWMISBN.Size = new Size(32, 15);
            labelMVWMISBN.TabIndex = 10;
            labelMVWMISBN.Text = "ISBN";
            // 
            // tbMVWMEditionNumber
            // 
            tbMVWMEditionNumber.Location = new Point(10, 191);
            tbMVWMEditionNumber.Name = "tbMVWMEditionNumber";
            tbMVWMEditionNumber.Size = new Size(450, 23);
            tbMVWMEditionNumber.TabIndex = 7;
            // 
            // tbMVWMEditor
            // 
            tbMVWMEditor.Location = new Point(10, 141);
            tbMVWMEditor.Name = "tbMVWMEditor";
            tbMVWMEditor.Size = new Size(450, 23);
            tbMVWMEditor.TabIndex = 5;
            // 
            // tbMVWMISBN
            // 
            tbMVWMISBN.Location = new Point(10, 291);
            tbMVWMISBN.Name = "tbMVWMISBN";
            tbMVWMISBN.Size = new Size(450, 23);
            tbMVWMISBN.TabIndex = 11;
            // 
            // tpMVSeparateVolume
            // 
            tpMVSeparateVolume.BackColor = SystemColors.Control;
            tpMVSeparateVolume.Controls.Add(gbMVSeparateVolumeRequired);
            tpMVSeparateVolume.Controls.Add(gbMVSeparateVolumeOptional);
            tpMVSeparateVolume.Location = new Point(4, 24);
            tpMVSeparateVolume.Name = "tpMVSeparateVolume";
            tpMVSeparateVolume.Padding = new Padding(3);
            tpMVSeparateVolume.Size = new Size(505, 681);
            tpMVSeparateVolume.TabIndex = 1;
            tpMVSeparateVolume.Text = "Отдельный том";
            // 
            // gbMVSeparateVolumeRequired
            // 
            gbMVSeparateVolumeRequired.Controls.Add(panelMVSeparateVolumeRequired);
            gbMVSeparateVolumeRequired.Location = new Point(10, 10);
            gbMVSeparateVolumeRequired.Name = "gbMVSeparateVolumeRequired";
            gbMVSeparateVolumeRequired.Size = new Size(488, 330);
            gbMVSeparateVolumeRequired.TabIndex = 2;
            gbMVSeparateVolumeRequired.TabStop = false;
            gbMVSeparateVolumeRequired.Text = "Обязательные поля";
            // 
            // panelMVSeparateVolumeRequired
            // 
            panelMVSeparateVolumeRequired.AutoScroll = true;
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVPagesCount);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVAuthors);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVPagesCount);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVPublishingLocation);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVPublishYear);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVPublishingLocation);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVPublishYear);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVVolumeTitle);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVPublisher);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVVolumeTitle);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVPublisher);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVVolumeNumber);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVVolumeNumber);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVAuthors);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVVolumesCount);
            panelMVSeparateVolumeRequired.Controls.Add(buttonMVSVAuthorsAdd);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVVolumesCount);
            panelMVSeparateVolumeRequired.Controls.Add(lbMVSVAuthors);
            panelMVSeparateVolumeRequired.Controls.Add(tbMVSVTitle);
            panelMVSeparateVolumeRequired.Controls.Add(labelMVSVTitle);
            panelMVSeparateVolumeRequired.Location = new Point(10, 22);
            panelMVSeparateVolumeRequired.Name = "panelMVSeparateVolumeRequired";
            panelMVSeparateVolumeRequired.Size = new Size(473, 302);
            panelMVSeparateVolumeRequired.TabIndex = 0;
            // 
            // labelMVSVPagesCount
            // 
            labelMVSVPagesCount.AutoSize = true;
            labelMVSVPagesCount.Location = new Point(0, 458);
            labelMVSVPagesCount.Name = "labelMVSVPagesCount";
            labelMVSVPagesCount.Size = new Size(120, 15);
            labelMVSVPagesCount.TabIndex = 18;
            labelMVSVPagesCount.Text = "Количество страниц";
            // 
            // labelMVSVAuthors
            // 
            labelMVSVAuthors.AutoSize = true;
            labelMVSVAuthors.Location = new Point(0, 0);
            labelMVSVAuthors.Name = "labelMVSVAuthors";
            labelMVSVAuthors.Size = new Size(57, 15);
            labelMVSVAuthors.TabIndex = 0;
            labelMVSVAuthors.Text = "Автор(ы)";
            // 
            // tbMVSVPagesCount
            // 
            tbMVSVPagesCount.Location = new Point(0, 478);
            tbMVSVPagesCount.Name = "tbMVSVPagesCount";
            tbMVSVPagesCount.Size = new Size(450, 23);
            tbMVSVPagesCount.TabIndex = 19;
            // 
            // tbMVSVPublishingLocation
            // 
            tbMVSVPublishingLocation.Location = new Point(0, 340);
            tbMVSVPublishingLocation.Name = "tbMVSVPublishingLocation";
            tbMVSVPublishingLocation.Size = new Size(450, 23);
            tbMVSVPublishingLocation.TabIndex = 13;
            // 
            // labelMVSVPublishYear
            // 
            labelMVSVPublishYear.AutoSize = true;
            labelMVSVPublishYear.Location = new Point(0, 412);
            labelMVSVPublishYear.Name = "labelMVSVPublishYear";
            labelMVSVPublishYear.Size = new Size(73, 15);
            labelMVSVPublishYear.TabIndex = 16;
            labelMVSVPublishYear.Text = "Год издания";
            // 
            // labelMVSVPublishingLocation
            // 
            labelMVSVPublishingLocation.AutoSize = true;
            labelMVSVPublishingLocation.Location = new Point(0, 320);
            labelMVSVPublishingLocation.Name = "labelMVSVPublishingLocation";
            labelMVSVPublishingLocation.Size = new Size(89, 15);
            labelMVSVPublishingLocation.TabIndex = 12;
            labelMVSVPublishingLocation.Text = "Место издания";
            // 
            // tbMVSVPublishYear
            // 
            tbMVSVPublishYear.Location = new Point(0, 432);
            tbMVSVPublishYear.Name = "tbMVSVPublishYear";
            tbMVSVPublishYear.Size = new Size(450, 23);
            tbMVSVPublishYear.TabIndex = 17;
            // 
            // tbMVSVVolumeTitle
            // 
            tbMVSVVolumeTitle.Location = new Point(0, 290);
            tbMVSVVolumeTitle.Name = "tbMVSVVolumeTitle";
            tbMVSVVolumeTitle.Size = new Size(450, 23);
            tbMVSVVolumeTitle.TabIndex = 11;
            // 
            // labelMVSVPublisher
            // 
            labelMVSVPublisher.AutoSize = true;
            labelMVSVPublisher.Location = new Point(0, 366);
            labelMVSVPublisher.Name = "labelMVSVPublisher";
            labelMVSVPublisher.Size = new Size(81, 15);
            labelMVSVPublisher.TabIndex = 14;
            labelMVSVPublisher.Text = "Издательство";
            // 
            // labelMVSVVolumeTitle
            // 
            labelMVSVVolumeTitle.AutoSize = true;
            labelMVSVVolumeTitle.Location = new Point(0, 270);
            labelMVSVVolumeTitle.Name = "labelMVSVVolumeTitle";
            labelMVSVVolumeTitle.Size = new Size(87, 15);
            labelMVSVVolumeTitle.TabIndex = 10;
            labelMVSVVolumeTitle.Text = "Заглавие тома";
            // 
            // tbMVSVPublisher
            // 
            tbMVSVPublisher.Location = new Point(0, 386);
            tbMVSVPublisher.Name = "tbMVSVPublisher";
            tbMVSVPublisher.Size = new Size(450, 23);
            tbMVSVPublisher.TabIndex = 15;
            // 
            // tbMVSVVolumeNumber
            // 
            tbMVSVVolumeNumber.Location = new Point(0, 240);
            tbMVSVVolumeNumber.Name = "tbMVSVVolumeNumber";
            tbMVSVVolumeNumber.Size = new Size(450, 23);
            tbMVSVVolumeNumber.TabIndex = 9;
            // 
            // labelMVSVVolumeNumber
            // 
            labelMVSVVolumeNumber.AutoSize = true;
            labelMVSVVolumeNumber.Location = new Point(0, 220);
            labelMVSVVolumeNumber.Name = "labelMVSVVolumeNumber";
            labelMVSVVolumeNumber.Size = new Size(75, 15);
            labelMVSVVolumeNumber.TabIndex = 8;
            labelMVSVVolumeNumber.Text = "Номер тома";
            // 
            // tbMVSVAuthors
            // 
            tbMVSVAuthors.Location = new Point(0, 20);
            tbMVSVAuthors.Name = "tbMVSVAuthors";
            tbMVSVAuthors.Size = new Size(350, 23);
            tbMVSVAuthors.TabIndex = 1;
            // 
            // tbMVSVVolumesCount
            // 
            tbMVSVVolumesCount.Location = new Point(0, 190);
            tbMVSVVolumesCount.Name = "tbMVSVVolumesCount";
            tbMVSVVolumesCount.Size = new Size(450, 23);
            tbMVSVVolumesCount.TabIndex = 7;
            // 
            // buttonMVSVAuthorsAdd
            // 
            buttonMVSVAuthorsAdd.Location = new Point(360, 20);
            buttonMVSVAuthorsAdd.Name = "buttonMVSVAuthorsAdd";
            buttonMVSVAuthorsAdd.Size = new Size(90, 23);
            buttonMVSVAuthorsAdd.TabIndex = 2;
            buttonMVSVAuthorsAdd.Text = "Добавить";
            buttonMVSVAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // labelMVSVVolumesCount
            // 
            labelMVSVVolumesCount.AutoSize = true;
            labelMVSVVolumesCount.Location = new Point(0, 170);
            labelMVSVVolumesCount.Name = "labelMVSVVolumesCount";
            labelMVSVVolumesCount.Size = new Size(109, 15);
            labelMVSVVolumesCount.TabIndex = 6;
            labelMVSVVolumesCount.Text = "Количество томов";
            // 
            // lbMVSVAuthors
            // 
            lbMVSVAuthors.ItemHeight = 15;
            lbMVSVAuthors.Location = new Point(0, 50);
            lbMVSVAuthors.Name = "lbMVSVAuthors";
            lbMVSVAuthors.Size = new Size(450, 64);
            lbMVSVAuthors.TabIndex = 3;
            // 
            // tbMVSVTitle
            // 
            tbMVSVTitle.Location = new Point(0, 140);
            tbMVSVTitle.Name = "tbMVSVTitle";
            tbMVSVTitle.Size = new Size(450, 23);
            tbMVSVTitle.TabIndex = 5;
            // 
            // labelMVSVTitle
            // 
            labelMVSVTitle.AutoSize = true;
            labelMVSVTitle.Location = new Point(0, 120);
            labelMVSVTitle.Name = "labelMVSVTitle";
            labelMVSVTitle.Size = new Size(57, 15);
            labelMVSVTitle.TabIndex = 4;
            labelMVSVTitle.Text = "Заглавие";
            // 
            // gbMVSeparateVolumeOptional
            // 
            gbMVSeparateVolumeOptional.Controls.Add(labelMVSVDocumentType);
            gbMVSeparateVolumeOptional.Controls.Add(tbMVSVDocumentType);
            gbMVSeparateVolumeOptional.Controls.Add(tbMVSVSeries);
            gbMVSeparateVolumeOptional.Controls.Add(labelMVSVEditionNumber);
            gbMVSeparateVolumeOptional.Controls.Add(labelMVSVEditor);
            gbMVSeparateVolumeOptional.Controls.Add(tbMVSVISBN);
            gbMVSeparateVolumeOptional.Controls.Add(tbMVSVResponsibilityArea);
            gbMVSeparateVolumeOptional.Controls.Add(tbMVSVEditionNumber);
            gbMVSeparateVolumeOptional.Controls.Add(labelMVSVSeries);
            gbMVSeparateVolumeOptional.Controls.Add(labelMVSVResponsibilityArea);
            gbMVSeparateVolumeOptional.Controls.Add(labelMVSVISBN);
            gbMVSeparateVolumeOptional.Controls.Add(tbMVSVEditor);
            gbMVSeparateVolumeOptional.Location = new Point(10, 346);
            gbMVSeparateVolumeOptional.Name = "gbMVSeparateVolumeOptional";
            gbMVSeparateVolumeOptional.Size = new Size(488, 330);
            gbMVSeparateVolumeOptional.TabIndex = 3;
            gbMVSeparateVolumeOptional.TabStop = false;
            gbMVSeparateVolumeOptional.Text = "Необязательные поля";
            // 
            // labelMVSVDocumentType
            // 
            labelMVSVDocumentType.AutoSize = true;
            labelMVSVDocumentType.Location = new Point(10, 21);
            labelMVSVDocumentType.Name = "labelMVSVDocumentType";
            labelMVSVDocumentType.Size = new Size(88, 15);
            labelMVSVDocumentType.TabIndex = 0;
            labelMVSVDocumentType.Text = "Вид документа";
            // 
            // tbMVSVDocumentType
            // 
            tbMVSVDocumentType.Location = new Point(10, 41);
            tbMVSVDocumentType.Name = "tbMVSVDocumentType";
            tbMVSVDocumentType.Size = new Size(450, 23);
            tbMVSVDocumentType.TabIndex = 1;
            // 
            // tbMVSVSeries
            // 
            tbMVSVSeries.Location = new Point(10, 241);
            tbMVSVSeries.Name = "tbMVSVSeries";
            tbMVSVSeries.Size = new Size(450, 23);
            tbMVSVSeries.TabIndex = 9;
            // 
            // labelMVSVEditionNumber
            // 
            labelMVSVEditionNumber.AutoSize = true;
            labelMVSVEditionNumber.Location = new Point(10, 171);
            labelMVSVEditionNumber.Name = "labelMVSVEditionNumber";
            labelMVSVEditionNumber.Size = new Size(92, 15);
            labelMVSVEditionNumber.TabIndex = 6;
            labelMVSVEditionNumber.Text = "Номер издания";
            // 
            // labelMVSVEditor
            // 
            labelMVSVEditor.AutoSize = true;
            labelMVSVEditor.Location = new Point(10, 121);
            labelMVSVEditor.Name = "labelMVSVEditor";
            labelMVSVEditor.Size = new Size(57, 15);
            labelMVSVEditor.TabIndex = 4;
            labelMVSVEditor.Text = "Редактор";
            // 
            // tbMVSVISBN
            // 
            tbMVSVISBN.Location = new Point(10, 291);
            tbMVSVISBN.Name = "tbMVSVISBN";
            tbMVSVISBN.Size = new Size(450, 23);
            tbMVSVISBN.TabIndex = 11;
            // 
            // tbMVSVResponsibilityArea
            // 
            tbMVSVResponsibilityArea.Location = new Point(10, 91);
            tbMVSVResponsibilityArea.Name = "tbMVSVResponsibilityArea";
            tbMVSVResponsibilityArea.Size = new Size(450, 23);
            tbMVSVResponsibilityArea.TabIndex = 3;
            // 
            // tbMVSVEditionNumber
            // 
            tbMVSVEditionNumber.Location = new Point(10, 191);
            tbMVSVEditionNumber.Name = "tbMVSVEditionNumber";
            tbMVSVEditionNumber.Size = new Size(450, 23);
            tbMVSVEditionNumber.TabIndex = 7;
            // 
            // labelMVSVSeries
            // 
            labelMVSVSeries.AutoSize = true;
            labelMVSVSeries.Location = new Point(10, 221);
            labelMVSVSeries.Name = "labelMVSVSeries";
            labelMVSVSeries.Size = new Size(41, 15);
            labelMVSVSeries.TabIndex = 8;
            labelMVSVSeries.Text = "Серия";
            // 
            // labelMVSVResponsibilityArea
            // 
            labelMVSVResponsibilityArea.AutoSize = true;
            labelMVSVResponsibilityArea.Location = new Point(10, 71);
            labelMVSVResponsibilityArea.Name = "labelMVSVResponsibilityArea";
            labelMVSVResponsibilityArea.Size = new Size(147, 15);
            labelMVSVResponsibilityArea.TabIndex = 2;
            labelMVSVResponsibilityArea.Text = "Область ответственности";
            // 
            // labelMVSVISBN
            // 
            labelMVSVISBN.AutoSize = true;
            labelMVSVISBN.Location = new Point(10, 271);
            labelMVSVISBN.Name = "labelMVSVISBN";
            labelMVSVISBN.Size = new Size(32, 15);
            labelMVSVISBN.TabIndex = 10;
            labelMVSVISBN.Text = "ISBN";
            // 
            // tbMVSVEditor
            // 
            tbMVSVEditor.Location = new Point(10, 141);
            tbMVSVEditor.Name = "tbMVSVEditor";
            tbMVSVEditor.Size = new Size(450, 23);
            tbMVSVEditor.TabIndex = 5;
            // 
            // tpElectronicResources
            // 
            tpElectronicResources.BackColor = SystemColors.Control;
            tpElectronicResources.Controls.Add(tcERTypes);
            tpElectronicResources.Location = new Point(4, 24);
            tpElectronicResources.Name = "tpElectronicResources";
            tpElectronicResources.Padding = new Padding(3);
            tpElectronicResources.Size = new Size(521, 720);
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
            tcERTypes.Size = new Size(513, 709);
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
            tpEREbook.Size = new Size(505, 681);
            tpEREbook.TabIndex = 0;
            tpEREbook.Text = "Электронная книга";
            // 
            // gbEREbookRequired
            // 
            gbEREbookRequired.Controls.Add(panelEREbookRequired);
            gbEREbookRequired.Location = new Point(10, 10);
            gbEREbookRequired.Name = "gbEREbookRequired";
            gbEREbookRequired.Size = new Size(488, 330);
            gbEREbookRequired.TabIndex = 0;
            gbEREbookRequired.TabStop = false;
            gbEREbookRequired.Text = "Обязательные поля";
            // 
            // panelEREbookRequired
            // 
            panelEREbookRequired.AutoScroll = true;
            panelEREbookRequired.Controls.Add(labelEREbAccessDate);
            panelEREbookRequired.Controls.Add(labelEREbAuthors);
            panelEREbookRequired.Controls.Add(tbEREbAccessDate);
            panelEREbookRequired.Controls.Add(tbEREbURL);
            panelEREbookRequired.Controls.Add(labelEREbURL);
            panelEREbookRequired.Controls.Add(tbEREbAuthors);
            panelEREbookRequired.Controls.Add(tbEREbPublishYear);
            panelEREbookRequired.Controls.Add(labelEREbAuthorsAdd);
            panelEREbookRequired.Controls.Add(labelEREbPublishYear);
            panelEREbookRequired.Controls.Add(lbEREbAuthors);
            panelEREbookRequired.Controls.Add(tbEREbPublisher);
            panelEREbookRequired.Controls.Add(labelEREbTitle);
            panelEREbookRequired.Controls.Add(labelEREbPublisher);
            panelEREbookRequired.Controls.Add(tbEREbTitle);
            panelEREbookRequired.Controls.Add(tbEREbPublishingLocation);
            panelEREbookRequired.Controls.Add(labelEREbPublishingLocation);
            panelEREbookRequired.Location = new Point(10, 22);
            panelEREbookRequired.Name = "panelEREbookRequired";
            panelEREbookRequired.Size = new Size(473, 302);
            panelEREbookRequired.TabIndex = 0;
            // 
            // labelEREbAccessDate
            // 
            labelEREbAccessDate.AutoSize = true;
            labelEREbAccessDate.Location = new Point(0, 365);
            labelEREbAccessDate.Name = "labelEREbAccessDate";
            labelEREbAccessDate.Size = new Size(99, 15);
            labelEREbAccessDate.TabIndex = 14;
            labelEREbAccessDate.Text = "Дата обращения";
            // 
            // labelEREbAuthors
            // 
            labelEREbAuthors.AutoSize = true;
            labelEREbAuthors.Location = new Point(0, 0);
            labelEREbAuthors.Name = "labelEREbAuthors";
            labelEREbAuthors.Size = new Size(57, 15);
            labelEREbAuthors.TabIndex = 0;
            labelEREbAuthors.Text = "Автор(ы)";
            // 
            // tbEREbAccessDate
            // 
            tbEREbAccessDate.Location = new Point(0, 385);
            tbEREbAccessDate.Name = "tbEREbAccessDate";
            tbEREbAccessDate.Size = new Size(450, 23);
            tbEREbAccessDate.TabIndex = 15;
            // 
            // tbEREbURL
            // 
            tbEREbURL.Location = new Point(0, 340);
            tbEREbURL.Name = "tbEREbURL";
            tbEREbURL.Size = new Size(450, 23);
            tbEREbURL.TabIndex = 13;
            // 
            // labelEREbURL
            // 
            labelEREbURL.AutoSize = true;
            labelEREbURL.Location = new Point(0, 320);
            labelEREbURL.Name = "labelEREbURL";
            labelEREbURL.Size = new Size(28, 15);
            labelEREbURL.TabIndex = 12;
            labelEREbURL.Text = "URL";
            // 
            // tbEREbAuthors
            // 
            tbEREbAuthors.Location = new Point(0, 20);
            tbEREbAuthors.Name = "tbEREbAuthors";
            tbEREbAuthors.Size = new Size(350, 23);
            tbEREbAuthors.TabIndex = 1;
            // 
            // tbEREbPublishYear
            // 
            tbEREbPublishYear.Location = new Point(0, 290);
            tbEREbPublishYear.Name = "tbEREbPublishYear";
            tbEREbPublishYear.Size = new Size(450, 23);
            tbEREbPublishYear.TabIndex = 11;
            // 
            // labelEREbAuthorsAdd
            // 
            labelEREbAuthorsAdd.Location = new Point(360, 20);
            labelEREbAuthorsAdd.Name = "labelEREbAuthorsAdd";
            labelEREbAuthorsAdd.Size = new Size(90, 23);
            labelEREbAuthorsAdd.TabIndex = 2;
            labelEREbAuthorsAdd.Text = "Добавить";
            labelEREbAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // labelEREbPublishYear
            // 
            labelEREbPublishYear.AutoSize = true;
            labelEREbPublishYear.Location = new Point(0, 270);
            labelEREbPublishYear.Name = "labelEREbPublishYear";
            labelEREbPublishYear.Size = new Size(73, 15);
            labelEREbPublishYear.TabIndex = 10;
            labelEREbPublishYear.Text = "Год издания";
            // 
            // lbEREbAuthors
            // 
            lbEREbAuthors.ItemHeight = 15;
            lbEREbAuthors.Location = new Point(0, 50);
            lbEREbAuthors.Name = "lbEREbAuthors";
            lbEREbAuthors.Size = new Size(450, 64);
            lbEREbAuthors.TabIndex = 3;
            // 
            // tbEREbPublisher
            // 
            tbEREbPublisher.Location = new Point(0, 240);
            tbEREbPublisher.Name = "tbEREbPublisher";
            tbEREbPublisher.Size = new Size(450, 23);
            tbEREbPublisher.TabIndex = 9;
            // 
            // labelEREbTitle
            // 
            labelEREbTitle.AutoSize = true;
            labelEREbTitle.Location = new Point(0, 120);
            labelEREbTitle.Name = "labelEREbTitle";
            labelEREbTitle.Size = new Size(57, 15);
            labelEREbTitle.TabIndex = 4;
            labelEREbTitle.Text = "Заглавие";
            // 
            // labelEREbPublisher
            // 
            labelEREbPublisher.AutoSize = true;
            labelEREbPublisher.Location = new Point(0, 220);
            labelEREbPublisher.Name = "labelEREbPublisher";
            labelEREbPublisher.Size = new Size(81, 15);
            labelEREbPublisher.TabIndex = 8;
            labelEREbPublisher.Text = "Издательство";
            // 
            // tbEREbTitle
            // 
            tbEREbTitle.Location = new Point(0, 140);
            tbEREbTitle.Name = "tbEREbTitle";
            tbEREbTitle.Size = new Size(450, 23);
            tbEREbTitle.TabIndex = 5;
            // 
            // tbEREbPublishingLocation
            // 
            tbEREbPublishingLocation.Location = new Point(0, 190);
            tbEREbPublishingLocation.Name = "tbEREbPublishingLocation";
            tbEREbPublishingLocation.Size = new Size(450, 23);
            tbEREbPublishingLocation.TabIndex = 7;
            // 
            // labelEREbPublishingLocation
            // 
            labelEREbPublishingLocation.AutoSize = true;
            labelEREbPublishingLocation.Location = new Point(0, 170);
            labelEREbPublishingLocation.Name = "labelEREbPublishingLocation";
            labelEREbPublishingLocation.Size = new Size(89, 15);
            labelEREbPublishingLocation.TabIndex = 6;
            labelEREbPublishingLocation.Text = "Место издания";
            // 
            // gbEREbookOptional
            // 
            gbEREbookOptional.Controls.Add(panelEREbookOptional);
            gbEREbookOptional.Location = new Point(10, 346);
            gbEREbookOptional.Name = "gbEREbookOptional";
            gbEREbookOptional.Size = new Size(488, 330);
            gbEREbookOptional.TabIndex = 1;
            gbEREbookOptional.TabStop = false;
            gbEREbookOptional.Text = "Необязательные поля";
            // 
            // panelEREbookOptional
            // 
            panelEREbookOptional.AutoScroll = true;
            panelEREbookOptional.Controls.Add(labelEREbAccessMode);
            panelEREbookOptional.Controls.Add(labelEREbISBN);
            panelEREbookOptional.Controls.Add(tbEREbAccessMode);
            panelEREbookOptional.Controls.Add(tbEREbISBN);
            panelEREbookOptional.Controls.Add(labelEREbDocumentType);
            panelEREbookOptional.Controls.Add(tbEREbSeries);
            panelEREbookOptional.Controls.Add(tbEREbDocumentType);
            panelEREbookOptional.Controls.Add(labelEREbSeries);
            panelEREbookOptional.Controls.Add(labelEREbResponsibilityArea);
            panelEREbookOptional.Controls.Add(tbEREbPagesCount);
            panelEREbookOptional.Controls.Add(tbEREbResponsibilityArea);
            panelEREbookOptional.Controls.Add(labelEREbPagesCount);
            panelEREbookOptional.Controls.Add(labelEREbEditor);
            panelEREbookOptional.Controls.Add(tbEREbEditionNumber);
            panelEREbookOptional.Controls.Add(tbEREbEditor);
            panelEREbookOptional.Controls.Add(labelEREbEditionNumber);
            panelEREbookOptional.Location = new Point(10, 22);
            panelEREbookOptional.Name = "panelEREbookOptional";
            panelEREbookOptional.Size = new Size(473, 302);
            panelEREbookOptional.TabIndex = 16;
            // 
            // labelEREbAccessMode
            // 
            labelEREbAccessMode.AutoSize = true;
            labelEREbAccessMode.Location = new Point(0, 347);
            labelEREbAccessMode.Name = "labelEREbAccessMode";
            labelEREbAccessMode.Size = new Size(91, 15);
            labelEREbAccessMode.TabIndex = 14;
            labelEREbAccessMode.Text = "Режим доступа";
            // 
            // labelEREbISBN
            // 
            labelEREbISBN.AutoSize = true;
            labelEREbISBN.Location = new Point(0, 300);
            labelEREbISBN.Name = "labelEREbISBN";
            labelEREbISBN.Size = new Size(32, 15);
            labelEREbISBN.TabIndex = 12;
            labelEREbISBN.Text = "ISBN";
            // 
            // tbEREbAccessMode
            // 
            tbEREbAccessMode.Location = new Point(0, 367);
            tbEREbAccessMode.Name = "tbEREbAccessMode";
            tbEREbAccessMode.Size = new Size(450, 23);
            tbEREbAccessMode.TabIndex = 15;
            // 
            // tbEREbISBN
            // 
            tbEREbISBN.Location = new Point(0, 320);
            tbEREbISBN.Name = "tbEREbISBN";
            tbEREbISBN.Size = new Size(450, 23);
            tbEREbISBN.TabIndex = 13;
            // 
            // labelEREbDocumentType
            // 
            labelEREbDocumentType.AutoSize = true;
            labelEREbDocumentType.Location = new Point(0, 0);
            labelEREbDocumentType.Name = "labelEREbDocumentType";
            labelEREbDocumentType.Size = new Size(88, 15);
            labelEREbDocumentType.TabIndex = 0;
            labelEREbDocumentType.Text = "Вид документа";
            // 
            // tbEREbSeries
            // 
            tbEREbSeries.Location = new Point(0, 270);
            tbEREbSeries.Name = "tbEREbSeries";
            tbEREbSeries.Size = new Size(450, 23);
            tbEREbSeries.TabIndex = 11;
            // 
            // tbEREbDocumentType
            // 
            tbEREbDocumentType.Location = new Point(0, 20);
            tbEREbDocumentType.Name = "tbEREbDocumentType";
            tbEREbDocumentType.Size = new Size(450, 23);
            tbEREbDocumentType.TabIndex = 1;
            // 
            // labelEREbSeries
            // 
            labelEREbSeries.AutoSize = true;
            labelEREbSeries.Location = new Point(0, 250);
            labelEREbSeries.Name = "labelEREbSeries";
            labelEREbSeries.Size = new Size(41, 15);
            labelEREbSeries.TabIndex = 10;
            labelEREbSeries.Text = "Серия";
            // 
            // labelEREbResponsibilityArea
            // 
            labelEREbResponsibilityArea.AutoSize = true;
            labelEREbResponsibilityArea.Location = new Point(0, 50);
            labelEREbResponsibilityArea.Name = "labelEREbResponsibilityArea";
            labelEREbResponsibilityArea.Size = new Size(147, 15);
            labelEREbResponsibilityArea.TabIndex = 2;
            labelEREbResponsibilityArea.Text = "Область ответственности";
            // 
            // tbEREbPagesCount
            // 
            tbEREbPagesCount.Location = new Point(0, 220);
            tbEREbPagesCount.Name = "tbEREbPagesCount";
            tbEREbPagesCount.Size = new Size(450, 23);
            tbEREbPagesCount.TabIndex = 9;
            // 
            // tbEREbResponsibilityArea
            // 
            tbEREbResponsibilityArea.Location = new Point(0, 70);
            tbEREbResponsibilityArea.Name = "tbEREbResponsibilityArea";
            tbEREbResponsibilityArea.Size = new Size(450, 23);
            tbEREbResponsibilityArea.TabIndex = 3;
            // 
            // labelEREbPagesCount
            // 
            labelEREbPagesCount.AutoSize = true;
            labelEREbPagesCount.Location = new Point(0, 200);
            labelEREbPagesCount.Name = "labelEREbPagesCount";
            labelEREbPagesCount.Size = new Size(120, 15);
            labelEREbPagesCount.TabIndex = 8;
            labelEREbPagesCount.Text = "Количество страниц";
            // 
            // labelEREbEditor
            // 
            labelEREbEditor.AutoSize = true;
            labelEREbEditor.Location = new Point(0, 100);
            labelEREbEditor.Name = "labelEREbEditor";
            labelEREbEditor.Size = new Size(57, 15);
            labelEREbEditor.TabIndex = 4;
            labelEREbEditor.Text = "Редактор";
            // 
            // tbEREbEditionNumber
            // 
            tbEREbEditionNumber.Location = new Point(0, 170);
            tbEREbEditionNumber.Name = "tbEREbEditionNumber";
            tbEREbEditionNumber.Size = new Size(450, 23);
            tbEREbEditionNumber.TabIndex = 7;
            // 
            // tbEREbEditor
            // 
            tbEREbEditor.Location = new Point(0, 120);
            tbEREbEditor.Name = "tbEREbEditor";
            tbEREbEditor.Size = new Size(450, 23);
            tbEREbEditor.TabIndex = 5;
            // 
            // labelEREbEditionNumber
            // 
            labelEREbEditionNumber.AutoSize = true;
            labelEREbEditionNumber.Location = new Point(0, 150);
            labelEREbEditionNumber.Name = "labelEREbEditionNumber";
            labelEREbEditionNumber.Size = new Size(92, 15);
            labelEREbEditionNumber.TabIndex = 6;
            labelEREbEditionNumber.Text = "Номер издания";
            // 
            // tpERMultimediaEdition
            // 
            tpERMultimediaEdition.BackColor = SystemColors.Control;
            tpERMultimediaEdition.Controls.Add(gbERMultimediaEditionRequired);
            tpERMultimediaEdition.Controls.Add(gbERMultimediaEditionOptional);
            tpERMultimediaEdition.Location = new Point(4, 24);
            tpERMultimediaEdition.Name = "tpERMultimediaEdition";
            tpERMultimediaEdition.Padding = new Padding(3);
            tpERMultimediaEdition.Size = new Size(505, 681);
            tpERMultimediaEdition.TabIndex = 1;
            tpERMultimediaEdition.Text = "Мультимедийное издание (на диске)";
            // 
            // gbERMultimediaEditionRequired
            // 
            gbERMultimediaEditionRequired.Controls.Add(panelERMultimediaEditionRequired);
            gbERMultimediaEditionRequired.Location = new Point(10, 10);
            gbERMultimediaEditionRequired.Name = "gbERMultimediaEditionRequired";
            gbERMultimediaEditionRequired.Size = new Size(488, 330);
            gbERMultimediaEditionRequired.TabIndex = 2;
            gbERMultimediaEditionRequired.TabStop = false;
            gbERMultimediaEditionRequired.Text = "Обязательные поля";
            // 
            // panelERMultimediaEditionRequired
            // 
            panelERMultimediaEditionRequired.AutoScroll = true;
            panelERMultimediaEditionRequired.Controls.Add(labelERMEAuthors);
            panelERMultimediaEditionRequired.Controls.Add(tbERMEAuthors);
            panelERMultimediaEditionRequired.Controls.Add(tbERMEDataCarrier);
            panelERMultimediaEditionRequired.Controls.Add(buttonERMEAuthorsAdd);
            panelERMultimediaEditionRequired.Controls.Add(labelERMEDataCarrier);
            panelERMultimediaEditionRequired.Controls.Add(lbERMEAuthors);
            panelERMultimediaEditionRequired.Controls.Add(tbERMEPublishYear);
            panelERMultimediaEditionRequired.Controls.Add(labelERMETitle);
            panelERMultimediaEditionRequired.Controls.Add(labelERMEPublishYear);
            panelERMultimediaEditionRequired.Controls.Add(tbERMETitle);
            panelERMultimediaEditionRequired.Controls.Add(tbERMEPublisher);
            panelERMultimediaEditionRequired.Controls.Add(labelERMEPublishingLocation);
            panelERMultimediaEditionRequired.Controls.Add(labelERMEPublisher);
            panelERMultimediaEditionRequired.Controls.Add(tbERMEPublishingLocation);
            panelERMultimediaEditionRequired.Location = new Point(10, 22);
            panelERMultimediaEditionRequired.Name = "panelERMultimediaEditionRequired";
            panelERMultimediaEditionRequired.Size = new Size(473, 302);
            panelERMultimediaEditionRequired.TabIndex = 0;
            // 
            // labelERMEAuthors
            // 
            labelERMEAuthors.AutoSize = true;
            labelERMEAuthors.Location = new Point(0, 0);
            labelERMEAuthors.Name = "labelERMEAuthors";
            labelERMEAuthors.Size = new Size(57, 15);
            labelERMEAuthors.TabIndex = 0;
            labelERMEAuthors.Text = "Автор(ы)";
            // 
            // tbERMEAuthors
            // 
            tbERMEAuthors.Location = new Point(0, 20);
            tbERMEAuthors.Name = "tbERMEAuthors";
            tbERMEAuthors.Size = new Size(350, 23);
            tbERMEAuthors.TabIndex = 1;
            // 
            // tbERMEDataCarrier
            // 
            tbERMEDataCarrier.Location = new Point(0, 340);
            tbERMEDataCarrier.Name = "tbERMEDataCarrier";
            tbERMEDataCarrier.Size = new Size(450, 23);
            tbERMEDataCarrier.TabIndex = 13;
            // 
            // buttonERMEAuthorsAdd
            // 
            buttonERMEAuthorsAdd.Location = new Point(360, 20);
            buttonERMEAuthorsAdd.Name = "buttonERMEAuthorsAdd";
            buttonERMEAuthorsAdd.Size = new Size(90, 23);
            buttonERMEAuthorsAdd.TabIndex = 2;
            buttonERMEAuthorsAdd.Text = "Добавить";
            buttonERMEAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // labelERMEDataCarrier
            // 
            labelERMEDataCarrier.AutoSize = true;
            labelERMEDataCarrier.Location = new Point(0, 320);
            labelERMEDataCarrier.Name = "labelERMEDataCarrier";
            labelERMEDataCarrier.Size = new Size(60, 15);
            labelERMEDataCarrier.TabIndex = 12;
            labelERMEDataCarrier.Text = "Носитель";
            // 
            // lbERMEAuthors
            // 
            lbERMEAuthors.ItemHeight = 15;
            lbERMEAuthors.Location = new Point(0, 50);
            lbERMEAuthors.Name = "lbERMEAuthors";
            lbERMEAuthors.Size = new Size(450, 64);
            lbERMEAuthors.TabIndex = 3;
            // 
            // tbERMEPublishYear
            // 
            tbERMEPublishYear.Location = new Point(0, 290);
            tbERMEPublishYear.Name = "tbERMEPublishYear";
            tbERMEPublishYear.Size = new Size(450, 23);
            tbERMEPublishYear.TabIndex = 11;
            // 
            // labelERMETitle
            // 
            labelERMETitle.AutoSize = true;
            labelERMETitle.Location = new Point(0, 120);
            labelERMETitle.Name = "labelERMETitle";
            labelERMETitle.Size = new Size(57, 15);
            labelERMETitle.TabIndex = 4;
            labelERMETitle.Text = "Заглавие";
            // 
            // labelERMEPublishYear
            // 
            labelERMEPublishYear.AutoSize = true;
            labelERMEPublishYear.Location = new Point(0, 270);
            labelERMEPublishYear.Name = "labelERMEPublishYear";
            labelERMEPublishYear.Size = new Size(73, 15);
            labelERMEPublishYear.TabIndex = 10;
            labelERMEPublishYear.Text = "Год издания";
            // 
            // tbERMETitle
            // 
            tbERMETitle.Location = new Point(0, 140);
            tbERMETitle.Name = "tbERMETitle";
            tbERMETitle.Size = new Size(450, 23);
            tbERMETitle.TabIndex = 5;
            // 
            // tbERMEPublisher
            // 
            tbERMEPublisher.Location = new Point(0, 240);
            tbERMEPublisher.Name = "tbERMEPublisher";
            tbERMEPublisher.Size = new Size(450, 23);
            tbERMEPublisher.TabIndex = 9;
            // 
            // labelERMEPublishingLocation
            // 
            labelERMEPublishingLocation.AutoSize = true;
            labelERMEPublishingLocation.Location = new Point(0, 170);
            labelERMEPublishingLocation.Name = "labelERMEPublishingLocation";
            labelERMEPublishingLocation.Size = new Size(89, 15);
            labelERMEPublishingLocation.TabIndex = 6;
            labelERMEPublishingLocation.Text = "Место издания";
            // 
            // labelERMEPublisher
            // 
            labelERMEPublisher.AutoSize = true;
            labelERMEPublisher.Location = new Point(0, 220);
            labelERMEPublisher.Name = "labelERMEPublisher";
            labelERMEPublisher.Size = new Size(81, 15);
            labelERMEPublisher.TabIndex = 8;
            labelERMEPublisher.Text = "Издательство";
            // 
            // tbERMEPublishingLocation
            // 
            tbERMEPublishingLocation.Location = new Point(0, 190);
            tbERMEPublishingLocation.Name = "tbERMEPublishingLocation";
            tbERMEPublishingLocation.Size = new Size(450, 23);
            tbERMEPublishingLocation.TabIndex = 7;
            // 
            // gbERMultimediaEditionOptional
            // 
            gbERMultimediaEditionOptional.Controls.Add(labelERMEDocumentType);
            gbERMultimediaEditionOptional.Controls.Add(labelERMEResponsibilityArea);
            gbERMultimediaEditionOptional.Controls.Add(tbERMENotation);
            gbERMultimediaEditionOptional.Controls.Add(tbERMEDocumentType);
            gbERMultimediaEditionOptional.Controls.Add(labelERMEEditor);
            gbERMultimediaEditionOptional.Controls.Add(labelERMEOrganization);
            gbERMultimediaEditionOptional.Controls.Add(tbERMEResponsibilityArea);
            gbERMultimediaEditionOptional.Controls.Add(tbERMEISBN);
            gbERMultimediaEditionOptional.Controls.Add(labelERMENotation);
            gbERMultimediaEditionOptional.Controls.Add(tbERMEOrganization);
            gbERMultimediaEditionOptional.Controls.Add(labelERMEISBN);
            gbERMultimediaEditionOptional.Controls.Add(tbERMEEditor);
            gbERMultimediaEditionOptional.Location = new Point(10, 346);
            gbERMultimediaEditionOptional.Name = "gbERMultimediaEditionOptional";
            gbERMultimediaEditionOptional.Size = new Size(488, 330);
            gbERMultimediaEditionOptional.TabIndex = 3;
            gbERMultimediaEditionOptional.TabStop = false;
            gbERMultimediaEditionOptional.Text = "Необязательные поля";
            // 
            // labelERMEDocumentType
            // 
            labelERMEDocumentType.AutoSize = true;
            labelERMEDocumentType.Location = new Point(10, 21);
            labelERMEDocumentType.Name = "labelERMEDocumentType";
            labelERMEDocumentType.Size = new Size(88, 15);
            labelERMEDocumentType.TabIndex = 0;
            labelERMEDocumentType.Text = "Вид документа";
            // 
            // labelERMEResponsibilityArea
            // 
            labelERMEResponsibilityArea.AutoSize = true;
            labelERMEResponsibilityArea.Location = new Point(10, 71);
            labelERMEResponsibilityArea.Name = "labelERMEResponsibilityArea";
            labelERMEResponsibilityArea.Size = new Size(147, 15);
            labelERMEResponsibilityArea.TabIndex = 2;
            labelERMEResponsibilityArea.Text = "Область ответственности";
            // 
            // tbERMENotation
            // 
            tbERMENotation.Location = new Point(10, 241);
            tbERMENotation.Name = "tbERMENotation";
            tbERMENotation.Size = new Size(450, 23);
            tbERMENotation.TabIndex = 9;
            // 
            // tbERMEDocumentType
            // 
            tbERMEDocumentType.Location = new Point(10, 41);
            tbERMEDocumentType.Name = "tbERMEDocumentType";
            tbERMEDocumentType.Size = new Size(450, 23);
            tbERMEDocumentType.TabIndex = 1;
            // 
            // labelERMEEditor
            // 
            labelERMEEditor.AutoSize = true;
            labelERMEEditor.Location = new Point(10, 121);
            labelERMEEditor.Name = "labelERMEEditor";
            labelERMEEditor.Size = new Size(57, 15);
            labelERMEEditor.TabIndex = 4;
            labelERMEEditor.Text = "Редактор";
            // 
            // labelERMEOrganization
            // 
            labelERMEOrganization.AutoSize = true;
            labelERMEOrganization.Location = new Point(10, 171);
            labelERMEOrganization.Name = "labelERMEOrganization";
            labelERMEOrganization.Size = new Size(79, 15);
            labelERMEOrganization.TabIndex = 6;
            labelERMEOrganization.Text = "Организация";
            // 
            // tbERMEResponsibilityArea
            // 
            tbERMEResponsibilityArea.Location = new Point(10, 91);
            tbERMEResponsibilityArea.Name = "tbERMEResponsibilityArea";
            tbERMEResponsibilityArea.Size = new Size(450, 23);
            tbERMEResponsibilityArea.TabIndex = 3;
            // 
            // tbERMEISBN
            // 
            tbERMEISBN.Location = new Point(10, 291);
            tbERMEISBN.Name = "tbERMEISBN";
            tbERMEISBN.Size = new Size(450, 23);
            tbERMEISBN.TabIndex = 11;
            // 
            // labelERMENotation
            // 
            labelERMENotation.AutoSize = true;
            labelERMENotation.Location = new Point(10, 221);
            labelERMENotation.Name = "labelERMENotation";
            labelERMENotation.Size = new Size(78, 15);
            labelERMENotation.TabIndex = 8;
            labelERMENotation.Text = "Примечание";
            // 
            // tbERMEOrganization
            // 
            tbERMEOrganization.Location = new Point(10, 191);
            tbERMEOrganization.Name = "tbERMEOrganization";
            tbERMEOrganization.Size = new Size(450, 23);
            tbERMEOrganization.TabIndex = 7;
            // 
            // labelERMEISBN
            // 
            labelERMEISBN.AutoSize = true;
            labelERMEISBN.Location = new Point(10, 271);
            labelERMEISBN.Name = "labelERMEISBN";
            labelERMEISBN.Size = new Size(32, 15);
            labelERMEISBN.TabIndex = 10;
            labelERMEISBN.Text = "ISBN";
            // 
            // tbERMEEditor
            // 
            tbERMEEditor.Location = new Point(10, 141);
            tbERMEEditor.Name = "tbERMEEditor";
            tbERMEEditor.Size = new Size(450, 23);
            tbERMEEditor.TabIndex = 5;
            // 
            // tpEREjournalArticle
            // 
            tpEREjournalArticle.BackColor = SystemColors.Control;
            tpEREjournalArticle.Controls.Add(gbEREjournalArticleReqired);
            tpEREjournalArticle.Controls.Add(gbEREjournalArticleOptional);
            tpEREjournalArticle.Location = new Point(4, 24);
            tpEREjournalArticle.Name = "tpEREjournalArticle";
            tpEREjournalArticle.Padding = new Padding(3);
            tpEREjournalArticle.Size = new Size(505, 681);
            tpEREjournalArticle.TabIndex = 2;
            tpEREjournalArticle.Text = "Статья из электронного журнала";
            // 
            // gbEREjournalArticleReqired
            // 
            gbEREjournalArticleReqired.Controls.Add(panelEREjournalArticleReqired);
            gbEREjournalArticleReqired.Location = new Point(10, 10);
            gbEREjournalArticleReqired.Name = "gbEREjournalArticleReqired";
            gbEREjournalArticleReqired.Size = new Size(488, 330);
            gbEREjournalArticleReqired.TabIndex = 2;
            gbEREjournalArticleReqired.TabStop = false;
            gbEREjournalArticleReqired.Text = "Обязательные поля";
            // 
            // panelEREjournalArticleReqired
            // 
            panelEREjournalArticleReqired.AutoScroll = true;
            panelEREjournalArticleReqired.Controls.Add(labelEREjAAccessDate);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAAuthors);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAAccessDate);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAPages);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAURL);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAPages);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAURL);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAJournalNumber);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAJournalNumber);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAAuthors);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAYear);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAAuthorsAdd);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAYear);
            panelEREjournalArticleReqired.Controls.Add(lbEREjAAuthors);
            panelEREjournalArticleReqired.Controls.Add(tbEREjAJournalName);
            panelEREjournalArticleReqired.Controls.Add(labelEREjATitle);
            panelEREjournalArticleReqired.Controls.Add(labelEREjAJournalName);
            panelEREjournalArticleReqired.Controls.Add(tbEREjATitle);
            panelEREjournalArticleReqired.Location = new Point(10, 22);
            panelEREjournalArticleReqired.Name = "panelEREjournalArticleReqired";
            panelEREjournalArticleReqired.Size = new Size(472, 302);
            panelEREjournalArticleReqired.TabIndex = 0;
            // 
            // labelEREjAAccessDate
            // 
            labelEREjAAccessDate.AutoSize = true;
            labelEREjAAccessDate.Location = new Point(0, 412);
            labelEREjAAccessDate.Name = "labelEREjAAccessDate";
            labelEREjAAccessDate.Size = new Size(99, 15);
            labelEREjAAccessDate.TabIndex = 16;
            labelEREjAAccessDate.Text = "Дата обращения";
            // 
            // labelEREjAAuthors
            // 
            labelEREjAAuthors.AutoSize = true;
            labelEREjAAuthors.Location = new Point(0, 0);
            labelEREjAAuthors.Name = "labelEREjAAuthors";
            labelEREjAAuthors.Size = new Size(57, 15);
            labelEREjAAuthors.TabIndex = 0;
            labelEREjAAuthors.Text = "Автор(ы)";
            // 
            // tbEREjAAccessDate
            // 
            tbEREjAAccessDate.Location = new Point(0, 432);
            tbEREjAAccessDate.Name = "tbEREjAAccessDate";
            tbEREjAAccessDate.Size = new Size(450, 23);
            tbEREjAAccessDate.TabIndex = 17;
            // 
            // tbEREjAPages
            // 
            tbEREjAPages.Location = new Point(0, 340);
            tbEREjAPages.Name = "tbEREjAPages";
            tbEREjAPages.Size = new Size(450, 23);
            tbEREjAPages.TabIndex = 13;
            // 
            // labelEREjAURL
            // 
            labelEREjAURL.AutoSize = true;
            labelEREjAURL.Location = new Point(0, 365);
            labelEREjAURL.Name = "labelEREjAURL";
            labelEREjAURL.Size = new Size(28, 15);
            labelEREjAURL.TabIndex = 14;
            labelEREjAURL.Text = "URL";
            // 
            // labelEREjAPages
            // 
            labelEREjAPages.AutoSize = true;
            labelEREjAPages.Location = new Point(0, 320);
            labelEREjAPages.Name = "labelEREjAPages";
            labelEREjAPages.Size = new Size(63, 15);
            labelEREjAPages.TabIndex = 12;
            labelEREjAPages.Text = "Страницы";
            // 
            // tbEREjAURL
            // 
            tbEREjAURL.Location = new Point(0, 385);
            tbEREjAURL.Name = "tbEREjAURL";
            tbEREjAURL.Size = new Size(450, 23);
            tbEREjAURL.TabIndex = 15;
            // 
            // tbEREjAJournalNumber
            // 
            tbEREjAJournalNumber.Location = new Point(0, 290);
            tbEREjAJournalNumber.Name = "tbEREjAJournalNumber";
            tbEREjAJournalNumber.Size = new Size(450, 23);
            tbEREjAJournalNumber.TabIndex = 11;
            // 
            // labelEREjAJournalNumber
            // 
            labelEREjAJournalNumber.AutoSize = true;
            labelEREjAJournalNumber.Location = new Point(0, 270);
            labelEREjAJournalNumber.Name = "labelEREjAJournalNumber";
            labelEREjAJournalNumber.Size = new Size(96, 15);
            labelEREjAJournalNumber.TabIndex = 10;
            labelEREjAJournalNumber.Text = "Номер журнала";
            // 
            // tbEREjAAuthors
            // 
            tbEREjAAuthors.Location = new Point(0, 20);
            tbEREjAAuthors.Name = "tbEREjAAuthors";
            tbEREjAAuthors.Size = new Size(350, 23);
            tbEREjAAuthors.TabIndex = 1;
            // 
            // tbEREjAYear
            // 
            tbEREjAYear.Location = new Point(0, 240);
            tbEREjAYear.Name = "tbEREjAYear";
            tbEREjAYear.Size = new Size(450, 23);
            tbEREjAYear.TabIndex = 9;
            // 
            // tbEREjAAuthorsAdd
            // 
            tbEREjAAuthorsAdd.Location = new Point(360, 20);
            tbEREjAAuthorsAdd.Name = "tbEREjAAuthorsAdd";
            tbEREjAAuthorsAdd.Size = new Size(90, 23);
            tbEREjAAuthorsAdd.TabIndex = 2;
            tbEREjAAuthorsAdd.Text = "Добавить";
            tbEREjAAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // labelEREjAYear
            // 
            labelEREjAYear.AutoSize = true;
            labelEREjAYear.Location = new Point(0, 220);
            labelEREjAYear.Name = "labelEREjAYear";
            labelEREjAYear.Size = new Size(26, 15);
            labelEREjAYear.TabIndex = 8;
            labelEREjAYear.Text = "Год";
            // 
            // lbEREjAAuthors
            // 
            lbEREjAAuthors.ItemHeight = 15;
            lbEREjAAuthors.Location = new Point(0, 50);
            lbEREjAAuthors.Name = "lbEREjAAuthors";
            lbEREjAAuthors.Size = new Size(450, 64);
            lbEREjAAuthors.TabIndex = 3;
            // 
            // tbEREjAJournalName
            // 
            tbEREjAJournalName.Location = new Point(0, 190);
            tbEREjAJournalName.Name = "tbEREjAJournalName";
            tbEREjAJournalName.Size = new Size(450, 23);
            tbEREjAJournalName.TabIndex = 7;
            // 
            // labelEREjATitle
            // 
            labelEREjATitle.AutoSize = true;
            labelEREjATitle.Location = new Point(0, 120);
            labelEREjATitle.Name = "labelEREjATitle";
            labelEREjATitle.Size = new Size(57, 15);
            labelEREjATitle.TabIndex = 4;
            labelEREjATitle.Text = "Заглавие";
            // 
            // labelEREjAJournalName
            // 
            labelEREjAJournalName.AutoSize = true;
            labelEREjAJournalName.Location = new Point(0, 170);
            labelEREjAJournalName.Name = "labelEREjAJournalName";
            labelEREjAJournalName.Size = new Size(110, 15);
            labelEREjAJournalName.TabIndex = 6;
            labelEREjAJournalName.Text = "Название журнала";
            // 
            // tbEREjATitle
            // 
            tbEREjATitle.Location = new Point(0, 140);
            tbEREjATitle.Name = "tbEREjATitle";
            tbEREjATitle.Size = new Size(450, 23);
            tbEREjATitle.TabIndex = 5;
            // 
            // gbEREjournalArticleOptional
            // 
            gbEREjournalArticleOptional.Controls.Add(labelEREjAAccessMode);
            gbEREjournalArticleOptional.Controls.Add(tbEREjAAccessMode);
            gbEREjournalArticleOptional.Location = new Point(10, 346);
            gbEREjournalArticleOptional.Name = "gbEREjournalArticleOptional";
            gbEREjournalArticleOptional.Size = new Size(488, 330);
            gbEREjournalArticleOptional.TabIndex = 3;
            gbEREjournalArticleOptional.TabStop = false;
            gbEREjournalArticleOptional.Text = "Необязательные поля";
            // 
            // labelEREjAAccessMode
            // 
            labelEREjAAccessMode.AutoSize = true;
            labelEREjAAccessMode.Location = new Point(10, 20);
            labelEREjAAccessMode.Name = "labelEREjAAccessMode";
            labelEREjAAccessMode.Size = new Size(91, 15);
            labelEREjAAccessMode.TabIndex = 0;
            labelEREjAAccessMode.Text = "Режим доступа";
            // 
            // tbEREjAAccessMode
            // 
            tbEREjAAccessMode.Location = new Point(10, 40);
            tbEREjAAccessMode.Name = "tbEREjAAccessMode";
            tbEREjAAccessMode.Size = new Size(450, 23);
            tbEREjAAccessMode.TabIndex = 1;
            // 
            // tpERWebsite
            // 
            tpERWebsite.BackColor = SystemColors.Control;
            tpERWebsite.Controls.Add(gbERWebsiteRequired);
            tpERWebsite.Controls.Add(gbERWebsiteOptional);
            tpERWebsite.Location = new Point(4, 24);
            tpERWebsite.Name = "tpERWebsite";
            tpERWebsite.Padding = new Padding(3);
            tpERWebsite.Size = new Size(505, 681);
            tpERWebsite.TabIndex = 3;
            tpERWebsite.Text = "Сайт";
            // 
            // gbERWebsiteRequired
            // 
            gbERWebsiteRequired.Controls.Add(labelERWWebsiteURL);
            gbERWebsiteRequired.Controls.Add(tbERWWebsiteURL);
            gbERWebsiteRequired.Controls.Add(labelERWWebsiteName);
            gbERWebsiteRequired.Controls.Add(tbERWWebsiteName);
            gbERWebsiteRequired.Controls.Add(labelERWAccessDate);
            gbERWebsiteRequired.Controls.Add(tbERWAccessDate);
            gbERWebsiteRequired.Location = new Point(10, 10);
            gbERWebsiteRequired.Name = "gbERWebsiteRequired";
            gbERWebsiteRequired.Size = new Size(488, 330);
            gbERWebsiteRequired.TabIndex = 6;
            gbERWebsiteRequired.TabStop = false;
            gbERWebsiteRequired.Text = "Обязательные поля";
            // 
            // labelERWWebsiteURL
            // 
            labelERWWebsiteURL.AutoSize = true;
            labelERWWebsiteURL.Location = new Point(10, 67);
            labelERWWebsiteURL.Name = "labelERWWebsiteURL";
            labelERWWebsiteURL.Size = new Size(28, 15);
            labelERWWebsiteURL.TabIndex = 14;
            labelERWWebsiteURL.Text = "URL";
            // 
            // tbERWWebsiteURL
            // 
            tbERWWebsiteURL.Location = new Point(10, 87);
            tbERWWebsiteURL.Name = "tbERWWebsiteURL";
            tbERWWebsiteURL.Size = new Size(450, 23);
            tbERWWebsiteURL.TabIndex = 15;
            // 
            // labelERWWebsiteName
            // 
            labelERWWebsiteName.AutoSize = true;
            labelERWWebsiteName.Location = new Point(10, 20);
            labelERWWebsiteName.Name = "labelERWWebsiteName";
            labelERWWebsiteName.Size = new Size(92, 15);
            labelERWWebsiteName.TabIndex = 4;
            labelERWWebsiteName.Text = "Название сайта";
            // 
            // tbERWWebsiteName
            // 
            tbERWWebsiteName.Location = new Point(10, 40);
            tbERWWebsiteName.Name = "tbERWWebsiteName";
            tbERWWebsiteName.Size = new Size(450, 23);
            tbERWWebsiteName.TabIndex = 5;
            // 
            // labelERWAccessDate
            // 
            labelERWAccessDate.AutoSize = true;
            labelERWAccessDate.Location = new Point(10, 115);
            labelERWAccessDate.Name = "labelERWAccessDate";
            labelERWAccessDate.Size = new Size(99, 15);
            labelERWAccessDate.TabIndex = 6;
            labelERWAccessDate.Text = "Дата обращения";
            // 
            // tbERWAccessDate
            // 
            tbERWAccessDate.Location = new Point(10, 135);
            tbERWAccessDate.Name = "tbERWAccessDate";
            tbERWAccessDate.Size = new Size(450, 23);
            tbERWAccessDate.TabIndex = 7;
            // 
            // gbERWebsiteOptional
            // 
            gbERWebsiteOptional.Controls.Add(labelERWFounder);
            gbERWebsiteOptional.Controls.Add(tbERWFounder);
            gbERWebsiteOptional.Controls.Add(labelERWDocumentType);
            gbERWebsiteOptional.Controls.Add(tbERWDocumentType);
            gbERWebsiteOptional.Controls.Add(labelERWPublishingLocation);
            gbERWebsiteOptional.Controls.Add(tbERWPublishingLocation);
            gbERWebsiteOptional.Controls.Add(labelERWCreationYear);
            gbERWebsiteOptional.Controls.Add(tbERWCreationYear);
            gbERWebsiteOptional.Controls.Add(labelERWAccessMode);
            gbERWebsiteOptional.Controls.Add(tbERWAccessMode);
            gbERWebsiteOptional.Location = new Point(10, 345);
            gbERWebsiteOptional.Name = "gbERWebsiteOptional";
            gbERWebsiteOptional.Size = new Size(488, 330);
            gbERWebsiteOptional.TabIndex = 7;
            gbERWebsiteOptional.TabStop = false;
            gbERWebsiteOptional.Text = "Необязательные поля";
            // 
            // labelERWFounder
            // 
            labelERWFounder.AutoSize = true;
            labelERWFounder.Location = new Point(10, 224);
            labelERWFounder.Name = "labelERWFounder";
            labelERWFounder.Size = new Size(71, 15);
            labelERWFounder.TabIndex = 8;
            labelERWFounder.Text = "Учредитель";
            // 
            // tbERWFounder
            // 
            tbERWFounder.Location = new Point(10, 244);
            tbERWFounder.Name = "tbERWFounder";
            tbERWFounder.Size = new Size(450, 23);
            tbERWFounder.TabIndex = 9;
            // 
            // labelERWDocumentType
            // 
            labelERWDocumentType.AutoSize = true;
            labelERWDocumentType.Location = new Point(10, 28);
            labelERWDocumentType.Name = "labelERWDocumentType";
            labelERWDocumentType.Size = new Size(88, 15);
            labelERWDocumentType.TabIndex = 0;
            labelERWDocumentType.Text = "Вид документа";
            // 
            // tbERWDocumentType
            // 
            tbERWDocumentType.Location = new Point(10, 48);
            tbERWDocumentType.Name = "tbERWDocumentType";
            tbERWDocumentType.Size = new Size(450, 23);
            tbERWDocumentType.TabIndex = 1;
            // 
            // labelERWPublishingLocation
            // 
            labelERWPublishingLocation.AutoSize = true;
            labelERWPublishingLocation.Location = new Point(10, 78);
            labelERWPublishingLocation.Name = "labelERWPublishingLocation";
            labelERWPublishingLocation.Size = new Size(89, 15);
            labelERWPublishingLocation.TabIndex = 2;
            labelERWPublishingLocation.Text = "Место издания";
            // 
            // tbERWPublishingLocation
            // 
            tbERWPublishingLocation.Location = new Point(10, 98);
            tbERWPublishingLocation.Name = "tbERWPublishingLocation";
            tbERWPublishingLocation.Size = new Size(450, 23);
            tbERWPublishingLocation.TabIndex = 3;
            // 
            // labelERWCreationYear
            // 
            labelERWCreationYear.AutoSize = true;
            labelERWCreationYear.Location = new Point(10, 128);
            labelERWCreationYear.Name = "labelERWCreationYear";
            labelERWCreationYear.Size = new Size(151, 15);
            labelERWCreationYear.TabIndex = 4;
            labelERWCreationYear.Text = "Год создания/обновления";
            // 
            // tbERWCreationYear
            // 
            tbERWCreationYear.Location = new Point(10, 148);
            tbERWCreationYear.Name = "tbERWCreationYear";
            tbERWCreationYear.Size = new Size(450, 23);
            tbERWCreationYear.TabIndex = 5;
            // 
            // labelERWAccessMode
            // 
            labelERWAccessMode.AutoSize = true;
            labelERWAccessMode.Location = new Point(10, 178);
            labelERWAccessMode.Name = "labelERWAccessMode";
            labelERWAccessMode.Size = new Size(91, 15);
            labelERWAccessMode.TabIndex = 6;
            labelERWAccessMode.Text = "Режим доступа";
            // 
            // tbERWAccessMode
            // 
            tbERWAccessMode.Location = new Point(10, 198);
            tbERWAccessMode.Name = "tbERWAccessMode";
            tbERWAccessMode.Size = new Size(450, 23);
            tbERWAccessMode.TabIndex = 7;
            // 
            // tpConstituentParts
            // 
            tpConstituentParts.BackColor = SystemColors.Control;
            tpConstituentParts.Controls.Add(tcCPTypes);
            tpConstituentParts.Location = new Point(4, 24);
            tpConstituentParts.Name = "tpConstituentParts";
            tpConstituentParts.Padding = new Padding(3);
            tpConstituentParts.Size = new Size(521, 720);
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
            tcCPTypes.Size = new Size(513, 709);
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
            tpCPBookArticle.Size = new Size(505, 681);
            tpCPBookArticle.TabIndex = 0;
            tpCPBookArticle.Text = "Статья/раздел из книги";
            // 
            // gbCPBookArticleRequired
            // 
            gbCPBookArticleRequired.Controls.Add(panelCPBookArticleRequired);
            gbCPBookArticleRequired.Location = new Point(10, 10);
            gbCPBookArticleRequired.Name = "gbCPBookArticleRequired";
            gbCPBookArticleRequired.Size = new Size(488, 330);
            gbCPBookArticleRequired.TabIndex = 0;
            gbCPBookArticleRequired.TabStop = false;
            gbCPBookArticleRequired.Text = "Обязательные поля";
            // 
            // panelCPBookArticleRequired
            // 
            panelCPBookArticleRequired.AutoScroll = true;
            panelCPBookArticleRequired.Controls.Add(labelCPBAPages);
            panelCPBookArticleRequired.Controls.Add(labelCPBAArticleAuthors);
            panelCPBookArticleRequired.Controls.Add(tbCPBAPages);
            panelCPBookArticleRequired.Controls.Add(tbCPBAPublisher);
            panelCPBookArticleRequired.Controls.Add(labelCPBAPublishYear);
            panelCPBookArticleRequired.Controls.Add(labelCPBAPublisher);
            panelCPBookArticleRequired.Controls.Add(tbCPBAPublishYear);
            panelCPBookArticleRequired.Controls.Add(tbCPBAPublishingLocation);
            panelCPBookArticleRequired.Controls.Add(labelCPBABookAuthors);
            panelCPBookArticleRequired.Controls.Add(labelCPBAPublishingLocation);
            panelCPBookArticleRequired.Controls.Add(tbCPBABookAuthors);
            panelCPBookArticleRequired.Controls.Add(tbCPBABookTitle);
            panelCPBookArticleRequired.Controls.Add(buttonCPBABookAuthorsAdd);
            panelCPBookArticleRequired.Controls.Add(labelCPBABookTitle);
            panelCPBookArticleRequired.Controls.Add(lbCPBABookAuthors);
            panelCPBookArticleRequired.Controls.Add(tbCPBAArticleTitle);
            panelCPBookArticleRequired.Controls.Add(labelCPBAArticleTitle);
            panelCPBookArticleRequired.Controls.Add(tbCPBAArticleAuthors);
            panelCPBookArticleRequired.Controls.Add(lbCPBAArticleAuthors);
            panelCPBookArticleRequired.Controls.Add(buttonCPBAArticleAuthorsAdd);
            panelCPBookArticleRequired.Location = new Point(10, 22);
            panelCPBookArticleRequired.Name = "panelCPBookArticleRequired";
            panelCPBookArticleRequired.Size = new Size(472, 302);
            panelCPBookArticleRequired.TabIndex = 0;
            // 
            // labelCPBAPages
            // 
            labelCPBAPages.AutoSize = true;
            labelCPBAPages.Location = new Point(0, 475);
            labelCPBAPages.Name = "labelCPBAPages";
            labelCPBAPages.Size = new Size(63, 15);
            labelCPBAPages.TabIndex = 20;
            labelCPBAPages.Text = "Страницы";
            // 
            // labelCPBAArticleAuthors
            // 
            labelCPBAArticleAuthors.AutoSize = true;
            labelCPBAArticleAuthors.Location = new Point(0, 0);
            labelCPBAArticleAuthors.Name = "labelCPBAArticleAuthors";
            labelCPBAArticleAuthors.Size = new Size(95, 15);
            labelCPBAArticleAuthors.TabIndex = 0;
            labelCPBAArticleAuthors.Text = "Автор(ы) статьи";
            // 
            // tbCPBAPages
            // 
            tbCPBAPages.Location = new Point(0, 495);
            tbCPBAPages.Name = "tbCPBAPages";
            tbCPBAPages.Size = new Size(450, 23);
            tbCPBAPages.TabIndex = 21;
            // 
            // tbCPBAPublisher
            // 
            tbCPBAPublisher.Location = new Point(0, 403);
            tbCPBAPublisher.Name = "tbCPBAPublisher";
            tbCPBAPublisher.Size = new Size(450, 23);
            tbCPBAPublisher.TabIndex = 13;
            // 
            // labelCPBAPublishYear
            // 
            labelCPBAPublishYear.AutoSize = true;
            labelCPBAPublishYear.Location = new Point(0, 428);
            labelCPBAPublishYear.Name = "labelCPBAPublishYear";
            labelCPBAPublishYear.Size = new Size(73, 15);
            labelCPBAPublishYear.TabIndex = 18;
            labelCPBAPublishYear.Text = "Год издания";
            // 
            // labelCPBAPublisher
            // 
            labelCPBAPublisher.AutoSize = true;
            labelCPBAPublisher.Location = new Point(0, 383);
            labelCPBAPublisher.Name = "labelCPBAPublisher";
            labelCPBAPublisher.Size = new Size(81, 15);
            labelCPBAPublisher.TabIndex = 12;
            labelCPBAPublisher.Text = "Издательство";
            // 
            // tbCPBAPublishYear
            // 
            tbCPBAPublishYear.Location = new Point(0, 448);
            tbCPBAPublishYear.Name = "tbCPBAPublishYear";
            tbCPBAPublishYear.Size = new Size(450, 23);
            tbCPBAPublishYear.TabIndex = 19;
            // 
            // tbCPBAPublishingLocation
            // 
            tbCPBAPublishingLocation.Location = new Point(0, 353);
            tbCPBAPublishingLocation.Name = "tbCPBAPublishingLocation";
            tbCPBAPublishingLocation.Size = new Size(450, 23);
            tbCPBAPublishingLocation.TabIndex = 11;
            // 
            // labelCPBABookAuthors
            // 
            labelCPBABookAuthors.AutoSize = true;
            labelCPBABookAuthors.Location = new Point(0, 166);
            labelCPBABookAuthors.Name = "labelCPBABookAuthors";
            labelCPBABookAuthors.Size = new Size(92, 15);
            labelCPBABookAuthors.TabIndex = 14;
            labelCPBABookAuthors.Text = "Автор(ы) книги";
            // 
            // labelCPBAPublishingLocation
            // 
            labelCPBAPublishingLocation.AutoSize = true;
            labelCPBAPublishingLocation.Location = new Point(0, 333);
            labelCPBAPublishingLocation.Name = "labelCPBAPublishingLocation";
            labelCPBAPublishingLocation.Size = new Size(89, 15);
            labelCPBAPublishingLocation.TabIndex = 10;
            labelCPBAPublishingLocation.Text = "Место издания";
            // 
            // tbCPBABookAuthors
            // 
            tbCPBABookAuthors.Location = new Point(0, 186);
            tbCPBABookAuthors.Name = "tbCPBABookAuthors";
            tbCPBABookAuthors.Size = new Size(350, 23);
            tbCPBABookAuthors.TabIndex = 15;
            // 
            // tbCPBABookTitle
            // 
            tbCPBABookTitle.Location = new Point(0, 303);
            tbCPBABookTitle.Name = "tbCPBABookTitle";
            tbCPBABookTitle.Size = new Size(450, 23);
            tbCPBABookTitle.TabIndex = 9;
            // 
            // buttonCPBABookAuthorsAdd
            // 
            buttonCPBABookAuthorsAdd.Location = new Point(360, 186);
            buttonCPBABookAuthorsAdd.Name = "buttonCPBABookAuthorsAdd";
            buttonCPBABookAuthorsAdd.Size = new Size(90, 23);
            buttonCPBABookAuthorsAdd.TabIndex = 16;
            buttonCPBABookAuthorsAdd.Text = "Добавить";
            buttonCPBABookAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // labelCPBABookTitle
            // 
            labelCPBABookTitle.AutoSize = true;
            labelCPBABookTitle.Location = new Point(0, 283);
            labelCPBABookTitle.Name = "labelCPBABookTitle";
            labelCPBABookTitle.Size = new Size(92, 15);
            labelCPBABookTitle.TabIndex = 8;
            labelCPBABookTitle.Text = "Заглавие книги";
            // 
            // lbCPBABookAuthors
            // 
            lbCPBABookAuthors.ItemHeight = 15;
            lbCPBABookAuthors.Location = new Point(0, 216);
            lbCPBABookAuthors.Name = "lbCPBABookAuthors";
            lbCPBABookAuthors.Size = new Size(450, 64);
            lbCPBABookAuthors.TabIndex = 17;
            // 
            // tbCPBAArticleTitle
            // 
            tbCPBAArticleTitle.Location = new Point(0, 140);
            tbCPBAArticleTitle.Name = "tbCPBAArticleTitle";
            tbCPBAArticleTitle.Size = new Size(450, 23);
            tbCPBAArticleTitle.TabIndex = 5;
            // 
            // labelCPBAArticleTitle
            // 
            labelCPBAArticleTitle.AutoSize = true;
            labelCPBAArticleTitle.Location = new Point(0, 120);
            labelCPBAArticleTitle.Name = "labelCPBAArticleTitle";
            labelCPBAArticleTitle.Size = new Size(95, 15);
            labelCPBAArticleTitle.TabIndex = 4;
            labelCPBAArticleTitle.Text = "Заглавие статьи";
            // 
            // tbCPBAArticleAuthors
            // 
            tbCPBAArticleAuthors.Location = new Point(0, 20);
            tbCPBAArticleAuthors.Name = "tbCPBAArticleAuthors";
            tbCPBAArticleAuthors.Size = new Size(350, 23);
            tbCPBAArticleAuthors.TabIndex = 1;
            // 
            // lbCPBAArticleAuthors
            // 
            lbCPBAArticleAuthors.ItemHeight = 15;
            lbCPBAArticleAuthors.Location = new Point(0, 50);
            lbCPBAArticleAuthors.Name = "lbCPBAArticleAuthors";
            lbCPBAArticleAuthors.Size = new Size(450, 64);
            lbCPBAArticleAuthors.TabIndex = 3;
            // 
            // buttonCPBAArticleAuthorsAdd
            // 
            buttonCPBAArticleAuthorsAdd.Location = new Point(360, 20);
            buttonCPBAArticleAuthorsAdd.Name = "buttonCPBAArticleAuthorsAdd";
            buttonCPBAArticleAuthorsAdd.Size = new Size(90, 23);
            buttonCPBAArticleAuthorsAdd.TabIndex = 2;
            buttonCPBAArticleAuthorsAdd.Text = "Добавить";
            buttonCPBAArticleAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // gbCPBookArticleOptional
            // 
            gbCPBookArticleOptional.Controls.Add(labelCPBABookDocumentType);
            gbCPBookArticleOptional.Controls.Add(tbCPBABookDocumentType);
            gbCPBookArticleOptional.Controls.Add(labelCPBABookEditor);
            gbCPBookArticleOptional.Controls.Add(tbCPBABookEditor);
            gbCPBookArticleOptional.Location = new Point(10, 345);
            gbCPBookArticleOptional.Name = "gbCPBookArticleOptional";
            gbCPBookArticleOptional.Size = new Size(488, 330);
            gbCPBookArticleOptional.TabIndex = 1;
            gbCPBookArticleOptional.TabStop = false;
            gbCPBookArticleOptional.Text = "Необязательные поля";
            // 
            // labelCPBABookDocumentType
            // 
            labelCPBABookDocumentType.AutoSize = true;
            labelCPBABookDocumentType.Location = new Point(10, 20);
            labelCPBABookDocumentType.Name = "labelCPBABookDocumentType";
            labelCPBABookDocumentType.Size = new Size(123, 15);
            labelCPBABookDocumentType.TabIndex = 0;
            labelCPBABookDocumentType.Text = "Вид документа книги";
            // 
            // tbCPBABookDocumentType
            // 
            tbCPBABookDocumentType.Location = new Point(10, 40);
            tbCPBABookDocumentType.Name = "tbCPBABookDocumentType";
            tbCPBABookDocumentType.Size = new Size(450, 23);
            tbCPBABookDocumentType.TabIndex = 1;
            // 
            // labelCPBABookEditor
            // 
            labelCPBABookEditor.AutoSize = true;
            labelCPBABookEditor.Location = new Point(10, 70);
            labelCPBABookEditor.Name = "labelCPBABookEditor";
            labelCPBABookEditor.Size = new Size(92, 15);
            labelCPBABookEditor.TabIndex = 2;
            labelCPBABookEditor.Text = "Редактор книги";
            // 
            // tbCPBABookEditor
            // 
            tbCPBABookEditor.Location = new Point(10, 90);
            tbCPBABookEditor.Name = "tbCPBABookEditor";
            tbCPBABookEditor.Size = new Size(450, 23);
            tbCPBABookEditor.TabIndex = 3;
            // 
            // tpCPJournalArticle
            // 
            tpCPJournalArticle.BackColor = SystemColors.Control;
            tpCPJournalArticle.Controls.Add(gbCPJournalArticleRequired);
            tpCPJournalArticle.Controls.Add(gbCPJournalArticleOptional);
            tpCPJournalArticle.Location = new Point(4, 24);
            tpCPJournalArticle.Name = "tpCPJournalArticle";
            tpCPJournalArticle.Padding = new Padding(3);
            tpCPJournalArticle.Size = new Size(505, 681);
            tpCPJournalArticle.TabIndex = 1;
            tpCPJournalArticle.Text = "Статья из журнала";
            // 
            // gbCPJournalArticleRequired
            // 
            gbCPJournalArticleRequired.Controls.Add(panelCPJournalArticleRequired);
            gbCPJournalArticleRequired.Location = new Point(10, 10);
            gbCPJournalArticleRequired.Name = "gbCPJournalArticleRequired";
            gbCPJournalArticleRequired.Size = new Size(488, 330);
            gbCPJournalArticleRequired.TabIndex = 2;
            gbCPJournalArticleRequired.TabStop = false;
            gbCPJournalArticleRequired.Text = "Обязательные поля";
            // 
            // panelCPJournalArticleRequired
            // 
            panelCPJournalArticleRequired.AutoScroll = true;
            panelCPJournalArticleRequired.Controls.Add(labelCPJAAuthors);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAAuthors);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAPages);
            panelCPJournalArticleRequired.Controls.Add(buttonCPJAAuthorsAdd);
            panelCPJournalArticleRequired.Controls.Add(labelCPJAPages);
            panelCPJournalArticleRequired.Controls.Add(lbCPJAAuthors);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAJournalNumber);
            panelCPJournalArticleRequired.Controls.Add(labelCPJAArticleTitle);
            panelCPJournalArticleRequired.Controls.Add(labelCPJAJournalNumber);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAArticleTitle);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAYear);
            panelCPJournalArticleRequired.Controls.Add(labelCPJAJournalName);
            panelCPJournalArticleRequired.Controls.Add(labelCPJAYear);
            panelCPJournalArticleRequired.Controls.Add(tbCPJAJournalName);
            panelCPJournalArticleRequired.Location = new Point(10, 22);
            panelCPJournalArticleRequired.Name = "panelCPJournalArticleRequired";
            panelCPJournalArticleRequired.Size = new Size(472, 302);
            panelCPJournalArticleRequired.TabIndex = 0;
            // 
            // labelCPJAAuthors
            // 
            labelCPJAAuthors.AutoSize = true;
            labelCPJAAuthors.Location = new Point(0, 0);
            labelCPJAAuthors.Name = "labelCPJAAuthors";
            labelCPJAAuthors.Size = new Size(57, 15);
            labelCPJAAuthors.TabIndex = 0;
            labelCPJAAuthors.Text = "Автор(ы)";
            // 
            // tbCPJAAuthors
            // 
            tbCPJAAuthors.Location = new Point(0, 20);
            tbCPJAAuthors.Name = "tbCPJAAuthors";
            tbCPJAAuthors.Size = new Size(350, 23);
            tbCPJAAuthors.TabIndex = 1;
            // 
            // tbCPJAPages
            // 
            tbCPJAPages.Location = new Point(0, 340);
            tbCPJAPages.Name = "tbCPJAPages";
            tbCPJAPages.Size = new Size(450, 23);
            tbCPJAPages.TabIndex = 13;
            // 
            // buttonCPJAAuthorsAdd
            // 
            buttonCPJAAuthorsAdd.Location = new Point(360, 20);
            buttonCPJAAuthorsAdd.Name = "buttonCPJAAuthorsAdd";
            buttonCPJAAuthorsAdd.Size = new Size(90, 23);
            buttonCPJAAuthorsAdd.TabIndex = 2;
            buttonCPJAAuthorsAdd.Text = "Добавить";
            buttonCPJAAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // labelCPJAPages
            // 
            labelCPJAPages.AutoSize = true;
            labelCPJAPages.Location = new Point(0, 320);
            labelCPJAPages.Name = "labelCPJAPages";
            labelCPJAPages.Size = new Size(63, 15);
            labelCPJAPages.TabIndex = 12;
            labelCPJAPages.Text = "Страницы";
            // 
            // lbCPJAAuthors
            // 
            lbCPJAAuthors.ItemHeight = 15;
            lbCPJAAuthors.Location = new Point(0, 50);
            lbCPJAAuthors.Name = "lbCPJAAuthors";
            lbCPJAAuthors.Size = new Size(450, 64);
            lbCPJAAuthors.TabIndex = 3;
            // 
            // tbCPJAJournalNumber
            // 
            tbCPJAJournalNumber.Location = new Point(0, 290);
            tbCPJAJournalNumber.Name = "tbCPJAJournalNumber";
            tbCPJAJournalNumber.Size = new Size(450, 23);
            tbCPJAJournalNumber.TabIndex = 11;
            // 
            // labelCPJAArticleTitle
            // 
            labelCPJAArticleTitle.AutoSize = true;
            labelCPJAArticleTitle.Location = new Point(0, 120);
            labelCPJAArticleTitle.Name = "labelCPJAArticleTitle";
            labelCPJAArticleTitle.Size = new Size(95, 15);
            labelCPJAArticleTitle.TabIndex = 4;
            labelCPJAArticleTitle.Text = "Заглавие статьи";
            // 
            // labelCPJAJournalNumber
            // 
            labelCPJAJournalNumber.AutoSize = true;
            labelCPJAJournalNumber.Location = new Point(0, 270);
            labelCPJAJournalNumber.Name = "labelCPJAJournalNumber";
            labelCPJAJournalNumber.Size = new Size(96, 15);
            labelCPJAJournalNumber.TabIndex = 10;
            labelCPJAJournalNumber.Text = "Номер журнала";
            // 
            // tbCPJAArticleTitle
            // 
            tbCPJAArticleTitle.Location = new Point(0, 140);
            tbCPJAArticleTitle.Name = "tbCPJAArticleTitle";
            tbCPJAArticleTitle.Size = new Size(450, 23);
            tbCPJAArticleTitle.TabIndex = 5;
            // 
            // tbCPJAYear
            // 
            tbCPJAYear.Location = new Point(0, 240);
            tbCPJAYear.Name = "tbCPJAYear";
            tbCPJAYear.Size = new Size(450, 23);
            tbCPJAYear.TabIndex = 9;
            // 
            // labelCPJAJournalName
            // 
            labelCPJAJournalName.AutoSize = true;
            labelCPJAJournalName.Location = new Point(0, 170);
            labelCPJAJournalName.Name = "labelCPJAJournalName";
            labelCPJAJournalName.Size = new Size(110, 15);
            labelCPJAJournalName.TabIndex = 6;
            labelCPJAJournalName.Text = "Название журнала";
            // 
            // labelCPJAYear
            // 
            labelCPJAYear.AutoSize = true;
            labelCPJAYear.Location = new Point(0, 220);
            labelCPJAYear.Name = "labelCPJAYear";
            labelCPJAYear.Size = new Size(26, 15);
            labelCPJAYear.TabIndex = 8;
            labelCPJAYear.Text = "Год";
            // 
            // tbCPJAJournalName
            // 
            tbCPJAJournalName.Location = new Point(0, 190);
            tbCPJAJournalName.Name = "tbCPJAJournalName";
            tbCPJAJournalName.Size = new Size(450, 23);
            tbCPJAJournalName.TabIndex = 7;
            // 
            // gbCPJournalArticleOptional
            // 
            gbCPJournalArticleOptional.Controls.Add(labelCPJADOI);
            gbCPJournalArticleOptional.Controls.Add(tbCPJADOI);
            gbCPJournalArticleOptional.Location = new Point(10, 345);
            gbCPJournalArticleOptional.Name = "gbCPJournalArticleOptional";
            gbCPJournalArticleOptional.Size = new Size(488, 330);
            gbCPJournalArticleOptional.TabIndex = 3;
            gbCPJournalArticleOptional.TabStop = false;
            gbCPJournalArticleOptional.Text = "Необязательные поля";
            // 
            // labelCPJADOI
            // 
            labelCPJADOI.AutoSize = true;
            labelCPJADOI.Location = new Point(10, 20);
            labelCPJADOI.Name = "labelCPJADOI";
            labelCPJADOI.Size = new Size(27, 15);
            labelCPJADOI.TabIndex = 0;
            labelCPJADOI.Text = "DOI";
            // 
            // tbCPJADOI
            // 
            tbCPJADOI.Location = new Point(10, 40);
            tbCPJADOI.Name = "tbCPJADOI";
            tbCPJADOI.Size = new Size(450, 23);
            tbCPJADOI.TabIndex = 1;
            // 
            // tpCPNewspaperArticle
            // 
            tpCPNewspaperArticle.BackColor = SystemColors.Control;
            tpCPNewspaperArticle.Controls.Add(gbCPNewspaperArticleReqired);
            tpCPNewspaperArticle.Controls.Add(gbCPNewspaperArticleOptional);
            tpCPNewspaperArticle.Location = new Point(4, 24);
            tpCPNewspaperArticle.Name = "tpCPNewspaperArticle";
            tpCPNewspaperArticle.Padding = new Padding(3);
            tpCPNewspaperArticle.Size = new Size(505, 681);
            tpCPNewspaperArticle.TabIndex = 2;
            tpCPNewspaperArticle.Text = "Статья из газеты";
            // 
            // gbCPNewspaperArticleReqired
            // 
            gbCPNewspaperArticleReqired.Controls.Add(panelCPNewspaperArticleReqired);
            gbCPNewspaperArticleReqired.Location = new Point(10, 10);
            gbCPNewspaperArticleReqired.Name = "gbCPNewspaperArticleReqired";
            gbCPNewspaperArticleReqired.Size = new Size(488, 330);
            gbCPNewspaperArticleReqired.TabIndex = 2;
            gbCPNewspaperArticleReqired.TabStop = false;
            gbCPNewspaperArticleReqired.Text = "Обязательные поля";
            // 
            // panelCPNewspaperArticleReqired
            // 
            panelCPNewspaperArticleReqired.AutoScroll = true;
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNAAuthors);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNAAuthors);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNAPages);
            panelCPNewspaperArticleReqired.Controls.Add(buttonCPNAAuthorsAdd);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNAPages);
            panelCPNewspaperArticleReqired.Controls.Add(lbCPNAAuthors);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNAReleaseDate);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNAArticleTitle);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNAReleaseDate);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNAArticleTitle);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNAYear);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNANewspaperName);
            panelCPNewspaperArticleReqired.Controls.Add(labelCPNAYear);
            panelCPNewspaperArticleReqired.Controls.Add(tbCPNANewspaperName);
            panelCPNewspaperArticleReqired.Location = new Point(10, 22);
            panelCPNewspaperArticleReqired.Name = "panelCPNewspaperArticleReqired";
            panelCPNewspaperArticleReqired.Size = new Size(472, 302);
            panelCPNewspaperArticleReqired.TabIndex = 0;
            // 
            // labelCPNAAuthors
            // 
            labelCPNAAuthors.AutoSize = true;
            labelCPNAAuthors.Location = new Point(0, 0);
            labelCPNAAuthors.Name = "labelCPNAAuthors";
            labelCPNAAuthors.Size = new Size(57, 15);
            labelCPNAAuthors.TabIndex = 0;
            labelCPNAAuthors.Text = "Автор(ы)";
            // 
            // tbCPNAAuthors
            // 
            tbCPNAAuthors.Location = new Point(0, 20);
            tbCPNAAuthors.Name = "tbCPNAAuthors";
            tbCPNAAuthors.Size = new Size(350, 23);
            tbCPNAAuthors.TabIndex = 1;
            // 
            // tbCPNAPages
            // 
            tbCPNAPages.Location = new Point(0, 336);
            tbCPNAPages.Name = "tbCPNAPages";
            tbCPNAPages.Size = new Size(450, 23);
            tbCPNAPages.TabIndex = 13;
            // 
            // buttonCPNAAuthorsAdd
            // 
            buttonCPNAAuthorsAdd.Location = new Point(360, 20);
            buttonCPNAAuthorsAdd.Name = "buttonCPNAAuthorsAdd";
            buttonCPNAAuthorsAdd.Size = new Size(90, 23);
            buttonCPNAAuthorsAdd.TabIndex = 2;
            buttonCPNAAuthorsAdd.Text = "Добавить";
            buttonCPNAAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // labelCPNAPages
            // 
            labelCPNAPages.AutoSize = true;
            labelCPNAPages.Location = new Point(0, 316);
            labelCPNAPages.Name = "labelCPNAPages";
            labelCPNAPages.Size = new Size(63, 15);
            labelCPNAPages.TabIndex = 12;
            labelCPNAPages.Text = "Страницы";
            // 
            // lbCPNAAuthors
            // 
            lbCPNAAuthors.ItemHeight = 15;
            lbCPNAAuthors.Location = new Point(0, 50);
            lbCPNAAuthors.Name = "lbCPNAAuthors";
            lbCPNAAuthors.Size = new Size(450, 64);
            lbCPNAAuthors.TabIndex = 3;
            // 
            // tbCPNAReleaseDate
            // 
            tbCPNAReleaseDate.Location = new Point(0, 290);
            tbCPNAReleaseDate.Name = "tbCPNAReleaseDate";
            tbCPNAReleaseDate.Size = new Size(450, 23);
            tbCPNAReleaseDate.TabIndex = 11;
            // 
            // labelCPNAArticleTitle
            // 
            labelCPNAArticleTitle.AutoSize = true;
            labelCPNAArticleTitle.Location = new Point(0, 120);
            labelCPNAArticleTitle.Name = "labelCPNAArticleTitle";
            labelCPNAArticleTitle.Size = new Size(95, 15);
            labelCPNAArticleTitle.TabIndex = 4;
            labelCPNAArticleTitle.Text = "Заглавие статьи";
            // 
            // labelCPNAReleaseDate
            // 
            labelCPNAReleaseDate.AutoSize = true;
            labelCPNAReleaseDate.Location = new Point(0, 270);
            labelCPNAReleaseDate.Name = "labelCPNAReleaseDate";
            labelCPNAReleaseDate.Size = new Size(81, 15);
            labelCPNAReleaseDate.TabIndex = 10;
            labelCPNAReleaseDate.Text = "Дата выпуска";
            // 
            // tbCPNAArticleTitle
            // 
            tbCPNAArticleTitle.Location = new Point(0, 140);
            tbCPNAArticleTitle.Name = "tbCPNAArticleTitle";
            tbCPNAArticleTitle.Size = new Size(450, 23);
            tbCPNAArticleTitle.TabIndex = 5;
            // 
            // tbCPNAYear
            // 
            tbCPNAYear.Location = new Point(0, 240);
            tbCPNAYear.Name = "tbCPNAYear";
            tbCPNAYear.Size = new Size(450, 23);
            tbCPNAYear.TabIndex = 9;
            // 
            // labelCPNANewspaperName
            // 
            labelCPNANewspaperName.AutoSize = true;
            labelCPNANewspaperName.Location = new Point(0, 170);
            labelCPNANewspaperName.Name = "labelCPNANewspaperName";
            labelCPNANewspaperName.Size = new Size(98, 15);
            labelCPNANewspaperName.TabIndex = 6;
            labelCPNANewspaperName.Text = "Название газеты";
            // 
            // labelCPNAYear
            // 
            labelCPNAYear.AutoSize = true;
            labelCPNAYear.Location = new Point(0, 220);
            labelCPNAYear.Name = "labelCPNAYear";
            labelCPNAYear.Size = new Size(26, 15);
            labelCPNAYear.TabIndex = 8;
            labelCPNAYear.Text = "Год";
            // 
            // tbCPNANewspaperName
            // 
            tbCPNANewspaperName.Location = new Point(0, 190);
            tbCPNANewspaperName.Name = "tbCPNANewspaperName";
            tbCPNANewspaperName.Size = new Size(450, 23);
            tbCPNANewspaperName.TabIndex = 7;
            // 
            // gbCPNewspaperArticleOptional
            // 
            gbCPNewspaperArticleOptional.Controls.Add(labelCPNAAdditionalInformation);
            gbCPNewspaperArticleOptional.Controls.Add(tbCPNAAdditionalInformation);
            gbCPNewspaperArticleOptional.Controls.Add(labelCPNAInterviewer);
            gbCPNewspaperArticleOptional.Controls.Add(tbCPNAInterviewer);
            gbCPNewspaperArticleOptional.Location = new Point(10, 345);
            gbCPNewspaperArticleOptional.Name = "gbCPNewspaperArticleOptional";
            gbCPNewspaperArticleOptional.Size = new Size(488, 330);
            gbCPNewspaperArticleOptional.TabIndex = 3;
            gbCPNewspaperArticleOptional.TabStop = false;
            gbCPNewspaperArticleOptional.Text = "Необязательные поля";
            // 
            // labelCPNAAdditionalInformation
            // 
            labelCPNAAdditionalInformation.AutoSize = true;
            labelCPNAAdditionalInformation.Location = new Point(10, 20);
            labelCPNAAdditionalInformation.Name = "labelCPNAAdditionalInformation";
            labelCPNAAdditionalInformation.Size = new Size(175, 15);
            labelCPNAAdditionalInformation.TabIndex = 0;
            labelCPNAAdditionalInformation.Text = "Дополнительная информация";
            // 
            // tbCPNAAdditionalInformation
            // 
            tbCPNAAdditionalInformation.Location = new Point(10, 40);
            tbCPNAAdditionalInformation.Name = "tbCPNAAdditionalInformation";
            tbCPNAAdditionalInformation.Size = new Size(450, 23);
            tbCPNAAdditionalInformation.TabIndex = 1;
            // 
            // labelCPNAInterviewer
            // 
            labelCPNAInterviewer.AutoSize = true;
            labelCPNAInterviewer.Location = new Point(10, 70);
            labelCPNAInterviewer.Name = "labelCPNAInterviewer";
            labelCPNAInterviewer.Size = new Size(131, 15);
            labelCPNAInterviewer.TabIndex = 2;
            labelCPNAInterviewer.Text = "Записал (интервьюер)";
            // 
            // tbCPNAInterviewer
            // 
            tbCPNAInterviewer.Location = new Point(10, 90);
            tbCPNAInterviewer.Name = "tbCPNAInterviewer";
            tbCPNAInterviewer.Size = new Size(450, 23);
            tbCPNAInterviewer.TabIndex = 3;
            // 
            // tpCPWebsiteArticle
            // 
            tpCPWebsiteArticle.BackColor = SystemColors.Control;
            tpCPWebsiteArticle.Controls.Add(gbCPWebsiteArticleRequired);
            tpCPWebsiteArticle.Controls.Add(gbCPWebsiteArticleOptional);
            tpCPWebsiteArticle.Location = new Point(4, 24);
            tpCPWebsiteArticle.Name = "tpCPWebsiteArticle";
            tpCPWebsiteArticle.Padding = new Padding(3);
            tpCPWebsiteArticle.Size = new Size(505, 681);
            tpCPWebsiteArticle.TabIndex = 3;
            tpCPWebsiteArticle.Text = "Статья с сайта";
            // 
            // gbCPWebsiteArticleRequired
            // 
            gbCPWebsiteArticleRequired.Controls.Add(panelCPWebsiteArticleRequired);
            gbCPWebsiteArticleRequired.Location = new Point(10, 10);
            gbCPWebsiteArticleRequired.Name = "gbCPWebsiteArticleRequired";
            gbCPWebsiteArticleRequired.Size = new Size(488, 330);
            gbCPWebsiteArticleRequired.TabIndex = 2;
            gbCPWebsiteArticleRequired.TabStop = false;
            gbCPWebsiteArticleRequired.Text = "Обязательные поля";
            // 
            // panelCPWebsiteArticleRequired
            // 
            panelCPWebsiteArticleRequired.AutoScroll = true;
            panelCPWebsiteArticleRequired.Controls.Add(labelCPWAAuthors);
            panelCPWebsiteArticleRequired.Controls.Add(tbCPWAAuthors);
            panelCPWebsiteArticleRequired.Controls.Add(tbCPWAAccessDate);
            panelCPWebsiteArticleRequired.Controls.Add(buttonCPWAAuthorsAdd);
            panelCPWebsiteArticleRequired.Controls.Add(labelCPWAAccessDate);
            panelCPWebsiteArticleRequired.Controls.Add(lbCPWAAuthors);
            panelCPWebsiteArticleRequired.Controls.Add(tbCPWAURL);
            panelCPWebsiteArticleRequired.Controls.Add(labelCPWAArticleTitle);
            panelCPWebsiteArticleRequired.Controls.Add(labelCPWAURL);
            panelCPWebsiteArticleRequired.Controls.Add(tbCPWAArticleTitle);
            panelCPWebsiteArticleRequired.Controls.Add(tbCPWAWebsiteName);
            panelCPWebsiteArticleRequired.Controls.Add(labelCPWAWebsiteName);
            panelCPWebsiteArticleRequired.Location = new Point(10, 22);
            panelCPWebsiteArticleRequired.Name = "panelCPWebsiteArticleRequired";
            panelCPWebsiteArticleRequired.Size = new Size(472, 302);
            panelCPWebsiteArticleRequired.TabIndex = 0;
            // 
            // labelCPWAAuthors
            // 
            labelCPWAAuthors.AutoSize = true;
            labelCPWAAuthors.Location = new Point(0, 0);
            labelCPWAAuthors.Name = "labelCPWAAuthors";
            labelCPWAAuthors.Size = new Size(57, 15);
            labelCPWAAuthors.TabIndex = 0;
            labelCPWAAuthors.Text = "Автор(ы)";
            // 
            // tbCPWAAuthors
            // 
            tbCPWAAuthors.Location = new Point(0, 20);
            tbCPWAAuthors.Name = "tbCPWAAuthors";
            tbCPWAAuthors.Size = new Size(350, 23);
            tbCPWAAuthors.TabIndex = 1;
            // 
            // tbCPWAAccessDate
            // 
            tbCPWAAccessDate.Location = new Point(0, 290);
            tbCPWAAccessDate.Name = "tbCPWAAccessDate";
            tbCPWAAccessDate.Size = new Size(450, 23);
            tbCPWAAccessDate.TabIndex = 11;
            // 
            // buttonCPWAAuthorsAdd
            // 
            buttonCPWAAuthorsAdd.Location = new Point(360, 20);
            buttonCPWAAuthorsAdd.Name = "buttonCPWAAuthorsAdd";
            buttonCPWAAuthorsAdd.Size = new Size(90, 23);
            buttonCPWAAuthorsAdd.TabIndex = 2;
            buttonCPWAAuthorsAdd.Text = "Добавить";
            buttonCPWAAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // labelCPWAAccessDate
            // 
            labelCPWAAccessDate.AutoSize = true;
            labelCPWAAccessDate.Location = new Point(0, 270);
            labelCPWAAccessDate.Name = "labelCPWAAccessDate";
            labelCPWAAccessDate.Size = new Size(99, 15);
            labelCPWAAccessDate.TabIndex = 10;
            labelCPWAAccessDate.Text = "Дата обращения";
            // 
            // lbCPWAAuthors
            // 
            lbCPWAAuthors.ItemHeight = 15;
            lbCPWAAuthors.Location = new Point(0, 50);
            lbCPWAAuthors.Name = "lbCPWAAuthors";
            lbCPWAAuthors.Size = new Size(450, 64);
            lbCPWAAuthors.TabIndex = 3;
            // 
            // tbCPWAURL
            // 
            tbCPWAURL.Location = new Point(0, 240);
            tbCPWAURL.Name = "tbCPWAURL";
            tbCPWAURL.Size = new Size(450, 23);
            tbCPWAURL.TabIndex = 9;
            // 
            // labelCPWAArticleTitle
            // 
            labelCPWAArticleTitle.AutoSize = true;
            labelCPWAArticleTitle.Location = new Point(0, 120);
            labelCPWAArticleTitle.Name = "labelCPWAArticleTitle";
            labelCPWAArticleTitle.Size = new Size(95, 15);
            labelCPWAArticleTitle.TabIndex = 4;
            labelCPWAArticleTitle.Text = "Заглавие статьи";
            // 
            // labelCPWAURL
            // 
            labelCPWAURL.AutoSize = true;
            labelCPWAURL.Location = new Point(0, 220);
            labelCPWAURL.Name = "labelCPWAURL";
            labelCPWAURL.Size = new Size(28, 15);
            labelCPWAURL.TabIndex = 8;
            labelCPWAURL.Text = "URL";
            // 
            // tbCPWAArticleTitle
            // 
            tbCPWAArticleTitle.Location = new Point(0, 140);
            tbCPWAArticleTitle.Name = "tbCPWAArticleTitle";
            tbCPWAArticleTitle.Size = new Size(450, 23);
            tbCPWAArticleTitle.TabIndex = 5;
            // 
            // tbCPWAWebsiteName
            // 
            tbCPWAWebsiteName.Location = new Point(0, 190);
            tbCPWAWebsiteName.Name = "tbCPWAWebsiteName";
            tbCPWAWebsiteName.Size = new Size(450, 23);
            tbCPWAWebsiteName.TabIndex = 7;
            // 
            // labelCPWAWebsiteName
            // 
            labelCPWAWebsiteName.AutoSize = true;
            labelCPWAWebsiteName.Location = new Point(0, 170);
            labelCPWAWebsiteName.Name = "labelCPWAWebsiteName";
            labelCPWAWebsiteName.Size = new Size(92, 15);
            labelCPWAWebsiteName.TabIndex = 6;
            labelCPWAWebsiteName.Text = "Название сайта";
            // 
            // gbCPWebsiteArticleOptional
            // 
            gbCPWebsiteArticleOptional.Controls.Add(labelCPWAWebsiteType);
            gbCPWebsiteArticleOptional.Controls.Add(tbCPWAWebsiteType);
            gbCPWebsiteArticleOptional.Controls.Add(labelCPWAPublishingYear);
            gbCPWebsiteArticleOptional.Controls.Add(tbCPWAPublishingYear);
            gbCPWebsiteArticleOptional.Controls.Add(labelCPWAPublishingDate);
            gbCPWebsiteArticleOptional.Controls.Add(tbCPWAPublishingDate);
            gbCPWebsiteArticleOptional.Controls.Add(labelCPWAAdditionalInformation);
            gbCPWebsiteArticleOptional.Controls.Add(tbCPWAAdditionalInformation);
            gbCPWebsiteArticleOptional.Location = new Point(10, 345);
            gbCPWebsiteArticleOptional.Name = "gbCPWebsiteArticleOptional";
            gbCPWebsiteArticleOptional.Size = new Size(488, 330);
            gbCPWebsiteArticleOptional.TabIndex = 3;
            gbCPWebsiteArticleOptional.TabStop = false;
            gbCPWebsiteArticleOptional.Text = "Необязательные поля";
            // 
            // labelCPWAWebsiteType
            // 
            labelCPWAWebsiteType.AutoSize = true;
            labelCPWAWebsiteType.Location = new Point(10, 20);
            labelCPWAWebsiteType.Name = "labelCPWAWebsiteType";
            labelCPWAWebsiteType.Size = new Size(60, 15);
            labelCPWAWebsiteType.TabIndex = 0;
            labelCPWAWebsiteType.Text = "Вид сайта";
            // 
            // tbCPWAWebsiteType
            // 
            tbCPWAWebsiteType.Location = new Point(10, 40);
            tbCPWAWebsiteType.Name = "tbCPWAWebsiteType";
            tbCPWAWebsiteType.Size = new Size(450, 23);
            tbCPWAWebsiteType.TabIndex = 1;
            // 
            // labelCPWAPublishingYear
            // 
            labelCPWAPublishingYear.AutoSize = true;
            labelCPWAPublishingYear.Location = new Point(10, 70);
            labelCPWAPublishingYear.Name = "labelCPWAPublishingYear";
            labelCPWAPublishingYear.Size = new Size(96, 15);
            labelCPWAPublishingYear.TabIndex = 2;
            labelCPWAPublishingYear.Text = "Год публикации";
            // 
            // tbCPWAPublishingYear
            // 
            tbCPWAPublishingYear.Location = new Point(10, 90);
            tbCPWAPublishingYear.Name = "tbCPWAPublishingYear";
            tbCPWAPublishingYear.Size = new Size(450, 23);
            tbCPWAPublishingYear.TabIndex = 3;
            // 
            // labelCPWAPublishingDate
            // 
            labelCPWAPublishingDate.AutoSize = true;
            labelCPWAPublishingDate.Location = new Point(10, 120);
            labelCPWAPublishingDate.Name = "labelCPWAPublishingDate";
            labelCPWAPublishingDate.Size = new Size(102, 15);
            labelCPWAPublishingDate.TabIndex = 4;
            labelCPWAPublishingDate.Text = "Дата публикации";
            // 
            // tbCPWAPublishingDate
            // 
            tbCPWAPublishingDate.Location = new Point(10, 140);
            tbCPWAPublishingDate.Name = "tbCPWAPublishingDate";
            tbCPWAPublishingDate.Size = new Size(450, 23);
            tbCPWAPublishingDate.TabIndex = 5;
            // 
            // labelCPWAAdditionalInformation
            // 
            labelCPWAAdditionalInformation.AutoSize = true;
            labelCPWAAdditionalInformation.Location = new Point(10, 170);
            labelCPWAAdditionalInformation.Name = "labelCPWAAdditionalInformation";
            labelCPWAAdditionalInformation.Size = new Size(175, 15);
            labelCPWAAdditionalInformation.TabIndex = 6;
            labelCPWAAdditionalInformation.Text = "Дополнительная информация";
            // 
            // tbCPWAAdditionalInformation
            // 
            tbCPWAAdditionalInformation.Location = new Point(10, 190);
            tbCPWAAdditionalInformation.Name = "tbCPWAAdditionalInformation";
            tbCPWAAdditionalInformation.Size = new Size(450, 23);
            tbCPWAAdditionalInformation.TabIndex = 7;
            // 
            // tpSVConferenceMaterials
            // 
            tpSVConferenceMaterials.BackColor = SystemColors.Control;
            tpSVConferenceMaterials.Location = new Point(4, 24);
            tpSVConferenceMaterials.Name = "tpSVConferenceMaterials";
            tpSVConferenceMaterials.Padding = new Padding(3);
            tpSVConferenceMaterials.Size = new Size(505, 681);
            tpSVConferenceMaterials.TabIndex = 4;
            tpSVConferenceMaterials.Text = "Материалы конференции";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 808);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            panelRtbMLA.ResumeLayout(false);
            panelRtbGOST.ResumeLayout(false);
            panelConvertTitle.ResumeLayout(false);
            panelConvertTitle.PerformLayout();
            cmsListBox.ResumeLayout(false);
            panelAddRecord.ResumeLayout(false);
            panelAddRecord.PerformLayout();
            tcCategories.ResumeLayout(false);
            tpSingleVolume.ResumeLayout(false);
            tcSVTypes.ResumeLayout(false);
            tpSVBook.ResumeLayout(false);
            gpSVBookRequired.ResumeLayout(false);
            panelSVBookRequired.ResumeLayout(false);
            panelSVBookRequired.PerformLayout();
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
            panelSVDissertationAbstractRequired.ResumeLayout(false);
            panelSVDissertationAbstractRequired.PerformLayout();
            gbSVDissertationAbstractOptional.ResumeLayout(false);
            gbSVDissertationAbstractOptional.PerformLayout();
            tpSVDissertation.ResumeLayout(false);
            gbSVDissertationRequired.ResumeLayout(false);
            panelSVDissertationRequired.ResumeLayout(false);
            panelSVDissertationRequired.PerformLayout();
            gbSVDissertationOptional.ResumeLayout(false);
            gbSVDissertationOptional.PerformLayout();
            tpMultiVolume.ResumeLayout(false);
            tcMVTypes.ResumeLayout(false);
            tpMVWholeMultivolume.ResumeLayout(false);
            gbMVWholeMultivolumeRequired.ResumeLayout(false);
            panelMVWholeMultivolumeRequired.ResumeLayout(false);
            panelMVWholeMultivolumeRequired.PerformLayout();
            gbMVWholeMultivolumeOptional.ResumeLayout(false);
            gbMVWholeMultivolumeOptional.PerformLayout();
            tpMVSeparateVolume.ResumeLayout(false);
            gbMVSeparateVolumeRequired.ResumeLayout(false);
            panelMVSeparateVolumeRequired.ResumeLayout(false);
            panelMVSeparateVolumeRequired.PerformLayout();
            gbMVSeparateVolumeOptional.ResumeLayout(false);
            gbMVSeparateVolumeOptional.PerformLayout();
            tpElectronicResources.ResumeLayout(false);
            tcERTypes.ResumeLayout(false);
            tpEREbook.ResumeLayout(false);
            gbEREbookRequired.ResumeLayout(false);
            panelEREbookRequired.ResumeLayout(false);
            panelEREbookRequired.PerformLayout();
            gbEREbookOptional.ResumeLayout(false);
            panelEREbookOptional.ResumeLayout(false);
            panelEREbookOptional.PerformLayout();
            tpERMultimediaEdition.ResumeLayout(false);
            gbERMultimediaEditionRequired.ResumeLayout(false);
            panelERMultimediaEditionRequired.ResumeLayout(false);
            panelERMultimediaEditionRequired.PerformLayout();
            gbERMultimediaEditionOptional.ResumeLayout(false);
            gbERMultimediaEditionOptional.PerformLayout();
            tpEREjournalArticle.ResumeLayout(false);
            gbEREjournalArticleReqired.ResumeLayout(false);
            panelEREjournalArticleReqired.ResumeLayout(false);
            panelEREjournalArticleReqired.PerformLayout();
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
            panelCPBookArticleRequired.ResumeLayout(false);
            panelCPBookArticleRequired.PerformLayout();
            gbCPBookArticleOptional.ResumeLayout(false);
            gbCPBookArticleOptional.PerformLayout();
            tpCPJournalArticle.ResumeLayout(false);
            gbCPJournalArticleRequired.ResumeLayout(false);
            panelCPJournalArticleRequired.ResumeLayout(false);
            panelCPJournalArticleRequired.PerformLayout();
            gbCPJournalArticleOptional.ResumeLayout(false);
            gbCPJournalArticleOptional.PerformLayout();
            tpCPNewspaperArticle.ResumeLayout(false);
            gbCPNewspaperArticleReqired.ResumeLayout(false);
            panelCPNewspaperArticleReqired.ResumeLayout(false);
            panelCPNewspaperArticleReqired.PerformLayout();
            gbCPNewspaperArticleOptional.ResumeLayout(false);
            gbCPNewspaperArticleOptional.PerformLayout();
            tpCPWebsiteArticle.ResumeLayout(false);
            gbCPWebsiteArticleRequired.ResumeLayout(false);
            panelCPWebsiteArticleRequired.ResumeLayout(false);
            panelCPWebsiteArticleRequired.PerformLayout();
            gbCPWebsiteArticleOptional.ResumeLayout(false);
            gbCPWebsiteArticleOptional.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox gbSVRegulatoryDocumentRequired;
        private Label labelSVRDTitle;
        private TextBox tbSVRDTitle;
        private Label labelSVRDPublishingLocation;
        private TextBox tbSVRDPublishingLocation;
        private Label labelSVRDPublisher;
        private TextBox tbSVRDPublisher;
        private Label labelSVRDPublishYear;
        private TextBox tbSVRDPublishYear;
        private GroupBox gbSVRegulatoryDocumentOptional;
        private Label labelSVRDDocumentType;
        private TextBox tbSVRDDocumentType;
        private Label labelSVRDApprovalDate;
        private TextBox tbSVRDApprovalDate;
        private Label labelSVRDImplementDate;
        private TextBox tbSVRDImplementDate;
        private Label labelSVRDDeveloper;
        private TextBox tbSVRDDeveloper;
        private Label labelSVRDISBN;
        private TextBox tbSVRDISBN;
        private Label labelSVRDTitleTranslation;
        private TextBox tbSVRDTitleTranslation;
        private Label labelSVRDOfficialEdition;
        private TextBox tbSVRDOfficialEdition;
        private TabPage tpSVDissertationAbstract;
        private TabPage tpSVDissertation;
        private Label labelSVRDDocumentNumber;
        private TextBox tbSVRDDocumentNumber;
        private Label labelSVRDPagesCount;
        private TextBox tbSVRDPagesCount;
        private Label labelSVRDCountry;
        private TextBox tbSVRDCountry;
        private Label labelSVRDAdditions;
        private TextBox tbSVRDAdditions;
        private Label labelSVRDAbbreviation;
        private TextBox tbSVRDAbbreviation;
        private GroupBox gbSVDissertationAbstractRequired;
        private Label labelSVDATitle;
        private TextBox tbSVDATitle;
        private Label labelSVDAAuthor;
        private TextBox tbSVDAAuthor;
        private Label labelSVDASpecialty;
        private TextBox tbSVDASpecialty;
        private Label labelSVDADegree;
        private TextBox tbSVDADegree;
        private Label labelSVDAPublishingLocation;
        private TextBox tbSVDAPublishingLocation;
        private GroupBox gbSVDissertationAbstractOptional;
        private Label labelSVDADocumentType;
        private TextBox tbSVDADocumentType;
        private Label labelSVDAAuthorFullName;
        private TextBox tbSVDAAuthorFullName;
        private Label labelSVDAOrganization;
        private TextBox tbSVDAOrganization;
        private Label labelSVDABibliography;
        private TextBox tbSVDABibliography;
        private Label labelSVDADefenseLocation;
        private TextBox tbSVDADefenseLocation;
        private Label labelSVDAPagesCount;
        private TextBox tbSVDAPagesCount;
        private Label labelSVDAPublishYear;
        private TextBox tbSVDAPublishYear;
        private GroupBox gbSVDissertationRequired;
        private Label labelSVDPagesCount;
        private TextBox tbSVDPagesCount;
        private Label labelSVDPublishYear;
        private TextBox tbSVDPublishYear;
        private Label labelSVDTitle;
        private TextBox tbSVDTitle;
        private Label labelSVDAuthor;
        private TextBox tbSVDAuthor;
        private Label labelSVDSpecialty;
        private TextBox tbSVDSpecialty;
        private Label labelSVDDegree;
        private TextBox tbSVDDegree;
        private Label labelSVDPublishingLocation;
        private TextBox tbSVDPublishingLocation;
        private GroupBox gbSVDissertationOptional;
        private Label labelSVDDocumentType;
        private TextBox tbSVDDocumentType;
        private Label labelSVDAuthorFullName;
        private TextBox tbSVDAuthorFullName;
        private Label labelSVDOrganization;
        private TextBox tbSVDOrganization;
        private Label labelSVDBibliography;
        private TextBox tbSVDBibliography;
        private TabControl tcCategories;
        private TabPage tpSingleVolume;
        private TabPage tpMultiVolume;
        private TabControl tcMVTypes;
        private TabPage tpMVWholeMultivolume;
        private GroupBox gbMVWholeMultivolumeOptional;
        private Label labelMVWMDocumentType;
        private TextBox tbMVWMDocumentType;
        private Label labelMVWMResponsibilityArea;
        private TextBox tbMVWMResponsibilityArea;
        private Label labelMVWMEditor;
        private TextBox tbMVWMEditor;
        private Label labelMVWMEditionNumber;
        private TextBox tbMVWMEditionNumber;
        private Label labelMVWMSeries;
        private TextBox tbMVWMSeries;
        private Label labelMVWMISBN;
        private TextBox tbMVWMISBN;
        private TabPage tpMVSeparateVolume;
        private TabPage tpElectronicResources;
        private TabPage tpConstituentParts;
        private GroupBox gbMVWholeMultivolumeRequired;
        private Label labelMVWMPagesCount;
        private TextBox tbMVWMPagesCount;
        private Label labelMVWMAuthors;
        private TextBox tbMVWMAuthors;
        private Button buttonMVWMAuthorsAdd;
        private ListBox lbMVWMAuthors;
        private Label labelMVWMTitle;
        private TextBox tbMVWMTitle;
        private Label labelMVWMVolumesNumber;
        private TextBox tbMVWMVolumesNumber;
        private Label labelMVWMPublishingLocation;
        private TextBox tbMVWMPublishingLocation;
        private Label labelMVWMPublisher;
        private TextBox tbMVWMPublisher;
        private Label labelMVWMPublishYear;
        private TextBox tbMVWMPublishYear;
        private GroupBox gbMVSeparateVolumeRequired;
        private Label labelMVSVPublisher;
        private TextBox tbMVSVPublisher;
        private Label labelMVSVAuthors;
        private TextBox tbMVSVAuthors;
        private Button buttonMVSVAuthorsAdd;
        private ListBox lbMVSVAuthors;
        private Label labelMVSVTitle;
        private TextBox tbMVSVTitle;
        private Label labelMVSVVolumesCount;
        private TextBox tbMVSVVolumesCount;
        private Label labelMVSVVolumeNumber;
        private TextBox tbMVSVVolumeNumber;
        private Label labelMVSVVolumeTitle;
        private TextBox tbMVSVVolumeTitle;
        private Label labelMVSVPublishingLocation;
        private TextBox tbMVSVPublishingLocation;
        private GroupBox gbMVSeparateVolumeOptional;
        private Label labelMVSVDocumentType;
        private TextBox tbMVSVDocumentType;
        private Label labelMVSVResponsibilityArea;
        private TextBox tbMVSVResponsibilityArea;
        private Label labelMVSVEditor;
        private TextBox tbMVSVEditor;
        private Label labelMVSVEditionNumber;
        private TextBox tbMVSVEditionNumber;
        private Label labelMVSVSeries;
        private TextBox tbMVSVSeries;
        private Label labelMVSVISBN;
        private TextBox tbMVSVISBN;
        private Label labelMVSVPagesCount;
        private TextBox tbMVSVPagesCount;
        private Label labelMVSVPublishYear;
        private TextBox tbMVSVPublishYear;
        private TabControl tcERTypes;
        private TabPage tpEREbook;
        private GroupBox gbEREbookRequired;
        private Label labelEREbAuthors;
        private TextBox tbEREbAuthors;
        private Button labelEREbAuthorsAdd;
        private ListBox lbEREbAuthors;
        private Label labelEREbTitle;
        private TextBox tbEREbTitle;
        private Label labelEREbPublishingLocation;
        private TextBox tbEREbPublishingLocation;
        private Label labelEREbPublisher;
        private TextBox tbEREbPublisher;
        private Label labelEREbPublishYear;
        private TextBox tbEREbPublishYear;
        private Label labelEREbURL;
        private TextBox tbEREbURL;
        private GroupBox gbEREbookOptional;
        private Label labelEREbDocumentType;
        private TextBox tbEREbDocumentType;
        private Label labelEREbResponsibilityArea;
        private TextBox tbEREbResponsibilityArea;
        private Label labelEREbEditor;
        private TextBox tbEREbEditor;
        private Label labelEREbEditionNumber;
        private TextBox tbEREbEditionNumber;
        private Label labelEREbPagesCount;
        private TextBox tbEREbPagesCount;
        private Label labelEREbSeries;
        private TextBox tbEREbSeries;
        private Label labelEREbISBN;
        private TextBox tbEREbISBN;
        private TabPage tpERMultimediaEdition;
        private TabPage tpEREjournalArticle;
        private TabPage tpERWebsite;
        private GroupBox gbERWebsiteRequired;
        private Label labelERWWebsiteURL;
        private TextBox tbERWWebsiteURL;
        private Label labelERWWebsiteName;
        private TextBox tbERWWebsiteName;
        private Label labelERWAccessDate;
        private TextBox tbERWAccessDate;
        private GroupBox gbERWebsiteOptional;
        private Label labelERWDocumentType;
        private TextBox tbERWDocumentType;
        private Label labelERWPublishingLocation;
        private TextBox tbERWPublishingLocation;
        private Label labelERWCreationYear;
        private TextBox tbERWCreationYear;
        private Label labelERWAccessMode;
        private TextBox tbERWAccessMode;
        private TabControl tcCPTypes;
        private TabPage tpCPBookArticle;
        private GroupBox gbCPBookArticleRequired;
        private Label labelCPBAArticleAuthors;
        private TextBox tbCPBAArticleAuthors;
        private Button buttonCPBAArticleAuthorsAdd;
        private ListBox lbCPBAArticleAuthors;
        private Label labelCPBAArticleTitle;
        private TextBox tbCPBAArticleTitle;
        private Label labelCPBABookTitle;
        private TextBox tbCPBABookTitle;
        private Label labelCPBAPublishingLocation;
        private TextBox tbCPBAPublishingLocation;
        private Label labelCPBAPublisher;
        private TextBox tbCPBAPublisher;
        private GroupBox gbCPBookArticleOptional;
        private Label labelCPBABookDocumentType;
        private TextBox tbCPBABookDocumentType;
        private Label labelCPBABookEditor;
        private TextBox tbCPBABookEditor;
        private TabPage tpCPJournalArticle;
        private TabPage tpCPNewspaperArticle;
        private TabPage tpCPWebsiteArticle;
        private Label labelEREbAccessDate;
        private TextBox tbEREbAccessDate;
        private Label labelEREbAccessMode;
        private TextBox tbEREbAccessMode;
        private GroupBox gbERMultimediaEditionRequired;
        private Label labelERMEAuthors;
        private TextBox tbERMEAuthors;
        private Button buttonERMEAuthorsAdd;
        private ListBox lbERMEAuthors;
        private Label labelERMETitle;
        private TextBox tbERMETitle;
        private Label labelERMEPublishingLocation;
        private TextBox tbERMEPublishingLocation;
        private Label labelERMEPublisher;
        private TextBox tbERMEPublisher;
        private Label labelERMEPublishYear;
        private TextBox tbERMEPublishYear;
        private Label labelERMEDataCarrier;
        private TextBox tbERMEDataCarrier;
        private GroupBox gbERMultimediaEditionOptional;
        private Label labelERMEDocumentType;
        private TextBox tbERMEDocumentType;
        private Label labelERMEResponsibilityArea;
        private TextBox tbERMEResponsibilityArea;
        private Label labelERMEEditor;
        private TextBox tbERMEEditor;
        private Label labelERMEOrganization;
        private TextBox tbERMEOrganization;
        private Label labelERMENotation;
        private TextBox tbERMENotation;
        private Label labelERMEISBN;
        private TextBox tbERMEISBN;
        private GroupBox gbEREjournalArticleReqired;
        private Label labelEREjAURL;
        private TextBox tbEREjAURL;
        private Label labelEREjAAuthors;
        private TextBox tbEREjAAuthors;
        private Button tbEREjAAuthorsAdd;
        private ListBox lbEREjAAuthors;
        private Label labelEREjATitle;
        private TextBox tbEREjATitle;
        private Label labelEREjAJournalName;
        private TextBox tbEREjAJournalName;
        private Label labelEREjAYear;
        private TextBox tbEREjAYear;
        private Label labelEREjAJournalNumber;
        private TextBox tbEREjAJournalNumber;
        private Label labelEREjAPages;
        private TextBox tbEREjAPages;
        private GroupBox gbEREjournalArticleOptional;
        private Label labelEREjAAccessMode;
        private TextBox tbEREjAAccessMode;
        private Label labelEREjAAccessDate;
        private TextBox tbEREjAAccessDate;
        private Label labelERWFounder;
        private TextBox tbERWFounder;
        private GroupBox gbCPJournalArticleRequired;
        private Label labelCPJAAuthors;
        private TextBox tbCPJAAuthors;
        private Button buttonCPJAAuthorsAdd;
        private ListBox lbCPJAAuthors;
        private Label labelCPJAArticleTitle;
        private TextBox tbCPJAArticleTitle;
        private Label labelCPJAJournalName;
        private TextBox tbCPJAJournalName;
        private Label labelCPJAYear;
        private TextBox tbCPJAYear;
        private Label labelCPJAJournalNumber;
        private TextBox tbCPJAJournalNumber;
        private Label labelCPJAPages;
        private TextBox tbCPJAPages;
        private GroupBox gbCPJournalArticleOptional;
        private Label labelCPJADOI;
        private TextBox tbCPJADOI;
        private GroupBox gbCPNewspaperArticleReqired;
        private Label labelCPNAAuthors;
        private TextBox tbCPNAAuthors;
        private Button buttonCPNAAuthorsAdd;
        private ListBox lbCPNAAuthors;
        private Label labelCPNAArticleTitle;
        private TextBox tbCPNAArticleTitle;
        private Label labelCPNANewspaperName;
        private TextBox tbCPNANewspaperName;
        private Label labelCPNAYear;
        private TextBox tbCPNAYear;
        private Label labelCPNAReleaseDate;
        private TextBox tbCPNAReleaseDate;
        private Label labelCPNAPages;
        private TextBox tbCPNAPages;
        private GroupBox gbCPNewspaperArticleOptional;
        private Label labelCPNAAdditionalInformation;
        private TextBox tbCPNAAdditionalInformation;
        private Label labelCPNAInterviewer;
        private TextBox tbCPNAInterviewer;
        private GroupBox gbCPWebsiteArticleRequired;
        private Label labelCPWAAuthors;
        private TextBox tbCPWAAuthors;
        private Button buttonCPWAAuthorsAdd;
        private ListBox lbCPWAAuthors;
        private Label labelCPWAArticleTitle;
        private TextBox tbCPWAArticleTitle;
        private Label labelCPWAWebsiteName;
        private TextBox tbCPWAWebsiteName;
        private Label labelCPWAURL;
        private TextBox tbCPWAURL;
        private Label labelCPWAAccessDate;
        private TextBox tbCPWAAccessDate;
        private GroupBox gbCPWebsiteArticleOptional;
        private Label labelCPWAWebsiteType;
        private TextBox tbCPWAWebsiteType;
        private Label labelCPWAPublishingYear;
        private TextBox tbCPWAPublishingYear;
        private Label labelCPWAPublishingDate;
        private TextBox tbCPWAPublishingDate;
        private Label labelCPWAAdditionalInformation;
        private TextBox tbCPWAAdditionalInformation;
        private Label labelCPBAPages;
        private TextBox tbCPBAPages;
        private Label labelCPBAPublishYear;
        private TextBox tbCPBAPublishYear;
        private Label labelCPBABookAuthors;
        private TextBox tbCPBABookAuthors;
        private Button buttonCPBABookAuthorsAdd;
        private ListBox lbCPBABookAuthors;
        private Panel panelAddRecord;
        private CheckBox cbWordAbbreviation;
        private Button buttonAddRecord;
        private Panel panelSVBookOptional;
        private Panel panelSVRegulatoryDocumentOptional;
        private Panel panelEREbookOptional;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Panel panelSVDissertationAbstractRequired;
        private Panel panelSVBookRequired;
        private Panel panelSVDissertationRequired;
        private Panel panelMVWholeMultivolumeRequired;
        private Panel panelMVSeparateVolumeRequired;
        private Panel panelEREbookRequired;
        private Panel panelERMultimediaEditionRequired;
        private Panel panelEREjournalArticleReqired;
        private Panel panelCPBookArticleRequired;
        private Panel panelCPJournalArticleRequired;
        private Panel panelCPNewspaperArticleReqired;
        private Panel panelCPWebsiteArticleRequired;
        private ListBox lbResult;
        private Button buttonCopyResult;
        private Button buttonWordExportResult;
        private Button buttonConvert;
        private RichTextBox rtbMLA;
        private Label labelConvert;
        private Label labelResult;
        private Label labelMLA;
        private Label labelGOST;
        private RichTextBox rtbGOST;
        private Panel panelConvertTitle;
        private Button button1;
        private Panel panelRtbGOST;
        private Panel panelRtbMLA;
        private ToolTip ttMain;
        private ContextMenuStrip cmsListBox;
        private ToolStripMenuItem tsmiDeleteSelected;
        private ToolStripMenuItem tsmiDeleteAll;
        private ToolStripMenuItem tsmiCopy;
        private ListBox lbSVBPublisher;
        private Button buttonSVBPublishingLocationAdd;
        private ListBox lbSVBPublishingLocation;
        private Button buttonSVBPublisherAdd;
        private Label labelSVBContentType;
        private TextBox tbSVBContentType;
        private CheckBox cbSVBAuthors;
        private Label labelSVBParallelTitle;
        private TextBox tbSVBParallelTitle;
        private ListBox lbSVBEditor;
        private Button buttonSVBEditorAdd;
        private Button buttonPDFExportResult;
        private ComboBox cbSVBEditorType;
        private TabPage tpSVConferenceMaterials;
    }
}
