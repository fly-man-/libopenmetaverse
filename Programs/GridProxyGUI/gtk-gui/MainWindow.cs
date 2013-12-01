
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action ExitAction;
	private global::Gtk.Action EditAction;
	private global::Gtk.Action HelpAction;
	private global::Gtk.Action AboutAction;
	private global::Gtk.Action RemoveAction;
	private global::Gtk.Action SelectAction;
	private global::Gtk.Action AllAction;
	private global::Gtk.Action AllAction1;
	private global::Gtk.Action SelectedAction;
	private global::Gtk.Action FindAction;
	private global::Gtk.Action OpenSessionAction;
	private global::Gtk.Action SaveSessionAction;
	private global::Gtk.Action SaveSessionAsAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox boxTopMenu;
	private global::Gtk.Alignment alignment2;
	private global::Gtk.MenuBar menubar1;
	private global::Gtk.VSeparator vseparator1;
	private global::Gtk.Label label1;
	private global::Gtk.ComboBoxEntry cbListen;
	private global::Gtk.Label label2;
	private global::Gtk.Entry txtPort;
	private global::Gtk.Label label3;
	private global::Gtk.ComboBoxEntry cbLoginURL;
	private global::Gtk.Button btnStart;
	private global::Gtk.HPaned mainSplit;
	private global::Gtk.ScrolledWindow sessionLogScroller;
	private global::Gtk.TreeView treeview1;
	private global::Gtk.Notebook tabsMain;
	private global::Gtk.ScrolledWindow logFileScroller;
	private global::Gtk.TextView txtSummary;
	private global::Gtk.Label label4;
	private global::Gtk.VBox filterBox;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Button btnLoadFilters;
	private global::Gtk.Button btnSaveFilters;
	private global::Gtk.CheckButton cbAutoCheckCaps;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Frame frameFilterUDP;
	private global::Gtk.Alignment containerFilterUDP;
	private global::Gtk.Label GtkLabel7;
	private global::Gtk.Frame frameFilterCap;
	private global::Gtk.Alignment containerFilterCap;
	private global::Gtk.Label GtkLabel8;
	private global::Gtk.HBox hbox4;
	private global::Gtk.CheckButton cbSelectAllUDP;
	private global::Gtk.CheckButton cbSelectAllCap;
	private global::Gtk.Label label5;
	private global::Gtk.Label label6;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, "<Alt>f");
		this.ExitAction = new global::Gtk.Action ("ExitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, null);
		this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.ExitAction, "<Primary>q");
		this.EditAction = new global::Gtk.Action ("EditAction", global::Mono.Unix.Catalog.GetString ("Edit"), null, null);
		this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Edit");
		w1.Add (this.EditAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.RemoveAction = new global::Gtk.Action ("RemoveAction", global::Mono.Unix.Catalog.GetString ("Remove"), null, null);
		this.RemoveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Remove");
		w1.Add (this.RemoveAction, null);
		this.SelectAction = new global::Gtk.Action ("SelectAction", global::Mono.Unix.Catalog.GetString ("Select"), null, null);
		this.SelectAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Select");
		w1.Add (this.SelectAction, null);
		this.AllAction = new global::Gtk.Action ("AllAction", global::Mono.Unix.Catalog.GetString ("All"), null, null);
		this.AllAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("All");
		w1.Add (this.AllAction, null);
		this.AllAction1 = new global::Gtk.Action ("AllAction1", global::Mono.Unix.Catalog.GetString ("All"), null, null);
		this.AllAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("All");
		w1.Add (this.AllAction1, null);
		this.SelectedAction = new global::Gtk.Action ("SelectedAction", global::Mono.Unix.Catalog.GetString ("Selected"), null, null);
		this.SelectedAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Selected");
		w1.Add (this.SelectedAction, null);
		this.FindAction = new global::Gtk.Action ("FindAction", global::Mono.Unix.Catalog.GetString ("Find"), null, null);
		this.FindAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Find (Ctrl-F)");
		w1.Add (this.FindAction, "<Primary>f");
		this.OpenSessionAction = new global::Gtk.Action ("OpenSessionAction", global::Mono.Unix.Catalog.GetString ("Open Session..."), null, null);
		this.OpenSessionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open Session...");
		w1.Add (this.OpenSessionAction, "<Primary>o");
		this.SaveSessionAction = new global::Gtk.Action ("SaveSessionAction", global::Mono.Unix.Catalog.GetString ("Save Session"), null, null);
		this.SaveSessionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save Session");
		w1.Add (this.SaveSessionAction, "<Primary>s");
		this.SaveSessionAsAction = new global::Gtk.Action ("SaveSessionAsAction", global::Mono.Unix.Catalog.GetString ("Save Session As..."), null, null);
		this.SaveSessionAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save Session As...");
		w1.Add (this.SaveSessionAsAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Grid Proxy");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.AllowShrink = true;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.boxTopMenu = new global::Gtk.HBox ();
		this.boxTopMenu.Name = "hbox1";
		this.boxTopMenu.Spacing = 6;
		this.boxTopMenu.BorderWidth = ((uint)(3));
		// Container child hbox1.Gtk.Box+BoxChild
		this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
		this.alignment2.Name = "alignment2";
		// Container child alignment2.Gtk.Container+ContainerChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='OpenSessionAction' action='OpenSessionAction'/><menuitem name='SaveSessionAction' action='SaveSessionAction'/><menuitem name='SaveSessionAsAction' action='SaveSessionAsAction'/><separator/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='EditAction' action='EditAction'><menu name='RemoveAction' action='RemoveAction'><menuitem name='AllAction1' action='AllAction1'/><menuitem name='SelectedAction' action='SelectedAction'/></menu><menu name='SelectAction' action='SelectAction'><menuitem name='AllAction' action='AllAction'/></menu><separator/><menuitem name='FindAction' action='FindAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.alignment2.Add (this.menubar1);
		this.boxTopMenu.Add (this.alignment2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.boxTopMenu [this.alignment2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vseparator1 = new global::Gtk.VSeparator ();
		this.vseparator1.Name = "vseparator1";
		this.boxTopMenu.Add (this.vseparator1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.boxTopMenu [this.vseparator1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Listen IP Address:");
		this.boxTopMenu.Add (this.label1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.boxTopMenu [this.label1]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.cbListen = global::Gtk.ComboBoxEntry.NewText ();
		this.cbListen.AppendText (global::Mono.Unix.Catalog.GetString ("127.0.0.1"));
		this.cbListen.AppendText (global::Mono.Unix.Catalog.GetString ("0.0.0.0"));
		this.cbListen.WidthRequest = 100;
		this.cbListen.Name = "cbListen";
		this.cbListen.Active = 0;
		this.boxTopMenu.Add (this.cbListen);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.boxTopMenu [this.cbListen]));
		w6.Position = 3;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Port");
		this.boxTopMenu.Add (this.label2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.boxTopMenu [this.label2]));
		w7.Position = 4;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.txtPort = new global::Gtk.Entry ();
		this.txtPort.WidthRequest = 50;
		this.txtPort.CanFocus = true;
		this.txtPort.Name = "txtPort";
		this.txtPort.Text = global::Mono.Unix.Catalog.GetString ("8080");
		this.txtPort.IsEditable = true;
		this.txtPort.MaxLength = 5;
		this.txtPort.InvisibleChar = '●';
		this.boxTopMenu.Add (this.txtPort);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.boxTopMenu [this.txtPort]));
		w8.Position = 5;
		w8.Expand = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Login URL");
		this.boxTopMenu.Add (this.label3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.boxTopMenu [this.label3]));
		w9.Position = 6;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.cbLoginURL = global::Gtk.ComboBoxEntry.NewText ();
		this.cbLoginURL.AppendText (global::Mono.Unix.Catalog.GetString ("https://login.agni.lindenlab.com/cgi-bin/login.cgi"));
		this.cbLoginURL.AppendText (global::Mono.Unix.Catalog.GetString ("https://login.aditi.lindenlab.com/cgi-bin/login.cgi"));
		this.cbLoginURL.AppendText (global::Mono.Unix.Catalog.GetString ("http://login.orgrid.org/"));
		this.cbLoginURL.WidthRequest = 300;
		this.cbLoginURL.Name = "cbLoginURL";
		this.cbLoginURL.Active = 0;
		this.boxTopMenu.Add (this.cbLoginURL);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.boxTopMenu [this.cbLoginURL]));
		w10.Position = 7;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnStart = new global::Gtk.Button ();
		this.btnStart.CanFocus = true;
		this.btnStart.Name = "btnStart";
		this.btnStart.UseUnderline = true;
		this.btnStart.Label = global::Mono.Unix.Catalog.GetString ("Start Proxy");
		this.boxTopMenu.Add (this.btnStart);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.boxTopMenu [this.btnStart]));
		w11.Position = 8;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox1.Add (this.boxTopMenu);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.boxTopMenu]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.mainSplit = new global::Gtk.HPaned ();
		this.mainSplit.CanFocus = true;
		this.mainSplit.Name = "mainSplit";
		this.mainSplit.Position = 1;
		// Container child mainSplit.Gtk.Paned+PanedChild
		this.sessionLogScroller = new global::Gtk.ScrolledWindow ();
		this.sessionLogScroller.Name = "GtkScrolledWindow1";
		this.sessionLogScroller.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.treeview1 = new global::Gtk.TreeView ();
		this.treeview1.CanFocus = true;
		this.treeview1.Name = "treeview1";
		this.sessionLogScroller.Add (this.treeview1);
		this.mainSplit.Add (this.sessionLogScroller);
		global::Gtk.Paned.PanedChild w14 = ((global::Gtk.Paned.PanedChild)(this.mainSplit [this.sessionLogScroller]));
		w14.Resize = false;
		// Container child mainSplit.Gtk.Paned+PanedChild
		this.tabsMain = new global::Gtk.Notebook ();
		this.tabsMain.CanFocus = true;
		this.tabsMain.Name = "tabsMain";
		this.tabsMain.CurrentPage = 1;
		this.tabsMain.EnablePopup = true;
		// Container child tabsMain.Gtk.Notebook+NotebookChild
		this.logFileScroller = new global::Gtk.ScrolledWindow ();
		this.logFileScroller.Name = "logFileScroller";
		this.logFileScroller.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child logFileScroller.Gtk.Container+ContainerChild
		this.txtSummary = new global::Gtk.TextView ();
		this.txtSummary.CanFocus = true;
		this.txtSummary.Name = "txtSummary";
		this.txtSummary.Editable = false;
		this.txtSummary.WrapMode = ((global::Gtk.WrapMode)(2));
		this.logFileScroller.Add (this.txtSummary);
		this.tabsMain.Add (this.logFileScroller);
		// Notebook tab
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Summary");
		this.tabsMain.SetTabLabel (this.logFileScroller, this.label4);
		this.label4.ShowAll ();
		// Container child tabsMain.Gtk.Notebook+NotebookChild
		this.filterBox = new global::Gtk.VBox ();
		this.filterBox.Name = "filterBox";
		this.filterBox.Spacing = 6;
		// Container child filterBox.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btnLoadFilters = new global::Gtk.Button ();
		this.btnLoadFilters.CanFocus = true;
		this.btnLoadFilters.Name = "btnLoadFilters";
		this.btnLoadFilters.UseUnderline = true;
		this.btnLoadFilters.Label = global::Mono.Unix.Catalog.GetString ("Load");
		global::Gtk.Image w17 = new global::Gtk.Image ();
		w17.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-open", global::Gtk.IconSize.Menu);
		this.btnLoadFilters.Image = w17;
		this.hbox2.Add (this.btnLoadFilters);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.btnLoadFilters]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btnSaveFilters = new global::Gtk.Button ();
		this.btnSaveFilters.CanFocus = true;
		this.btnSaveFilters.Name = "btnSaveFilters";
		this.btnSaveFilters.UseUnderline = true;
		this.btnSaveFilters.Label = global::Mono.Unix.Catalog.GetString ("Save");
		global::Gtk.Image w19 = new global::Gtk.Image ();
		w19.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
		this.btnSaveFilters.Image = w19;
		this.hbox2.Add (this.btnSaveFilters);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.btnSaveFilters]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.cbAutoCheckCaps = new global::Gtk.CheckButton ();
		this.cbAutoCheckCaps.CanFocus = true;
		this.cbAutoCheckCaps.Name = "cbAutoCheckCaps";
		this.cbAutoCheckCaps.Label = global::Mono.Unix.Catalog.GetString ("Auto Check New Capabilities");
		this.cbAutoCheckCaps.Active = true;
		this.cbAutoCheckCaps.DrawIndicator = true;
		this.cbAutoCheckCaps.UseUnderline = true;
		this.hbox2.Add (this.cbAutoCheckCaps);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.cbAutoCheckCaps]));
		w21.Position = 2;
		this.filterBox.Add (this.hbox2);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.filterBox [this.hbox2]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child filterBox.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Homogeneous = true;
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.frameFilterUDP = new global::Gtk.Frame ();
		this.frameFilterUDP.Name = "frameFilterUDP";
		this.frameFilterUDP.ShadowType = ((global::Gtk.ShadowType)(0));
		this.frameFilterUDP.LabelYalign = 0F;
		// Container child frameFilterUDP.Gtk.Container+ContainerChild
		this.containerFilterUDP = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.containerFilterUDP.Name = "containerFilterUDP";
		this.containerFilterUDP.LeftPadding = ((uint)(12));
		this.frameFilterUDP.Add (this.containerFilterUDP);
		this.GtkLabel7 = new global::Gtk.Label ();
		this.GtkLabel7.Name = "GtkLabel7";
		this.GtkLabel7.LabelProp = global::Mono.Unix.Catalog.GetString ("UDP Packets & Login");
		this.frameFilterUDP.LabelWidget = this.GtkLabel7;
		this.hbox3.Add (this.frameFilterUDP);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.frameFilterUDP]));
		w24.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.frameFilterCap = new global::Gtk.Frame ();
		this.frameFilterCap.Name = "frameFilterCap";
		this.frameFilterCap.ShadowType = ((global::Gtk.ShadowType)(0));
		this.frameFilterCap.LabelYalign = 0F;
		// Container child frameFilterCap.Gtk.Container+ContainerChild
		this.containerFilterCap = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.containerFilterCap.Name = "containerFilterCap";
		this.containerFilterCap.LeftPadding = ((uint)(12));
		this.frameFilterCap.Add (this.containerFilterCap);
		this.GtkLabel8 = new global::Gtk.Label ();
		this.GtkLabel8.Name = "GtkLabel8";
		this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString ("Capabilities & EventQueue Messages");
		this.frameFilterCap.LabelWidget = this.GtkLabel8;
		this.hbox3.Add (this.frameFilterCap);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.frameFilterCap]));
		w26.Position = 1;
		this.filterBox.Add (this.hbox3);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.filterBox [this.hbox3]));
		w27.Position = 1;
		// Container child filterBox.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Homogeneous = true;
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.cbSelectAllUDP = new global::Gtk.CheckButton ();
		this.cbSelectAllUDP.CanFocus = true;
		this.cbSelectAllUDP.Name = "cbSelectAllUDP";
		this.cbSelectAllUDP.Label = global::Mono.Unix.Catalog.GetString ("Select/Uncheck All");
		this.cbSelectAllUDP.DrawIndicator = true;
		this.cbSelectAllUDP.UseUnderline = true;
		this.hbox4.Add (this.cbSelectAllUDP);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.cbSelectAllUDP]));
		w28.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.cbSelectAllCap = new global::Gtk.CheckButton ();
		this.cbSelectAllCap.CanFocus = true;
		this.cbSelectAllCap.Name = "cbSelectAllCap";
		this.cbSelectAllCap.Label = global::Mono.Unix.Catalog.GetString ("Select/Uncheck All");
		this.cbSelectAllCap.DrawIndicator = true;
		this.cbSelectAllCap.UseUnderline = true;
		this.hbox4.Add (this.cbSelectAllCap);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.cbSelectAllCap]));
		w29.Position = 1;
		this.filterBox.Add (this.hbox4);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.filterBox [this.hbox4]));
		w30.PackType = ((global::Gtk.PackType)(1));
		w30.Position = 2;
		w30.Expand = false;
		w30.Fill = false;
		this.tabsMain.Add (this.filterBox);
		global::Gtk.Notebook.NotebookChild w31 = ((global::Gtk.Notebook.NotebookChild)(this.tabsMain [this.filterBox]));
		w31.Position = 1;
		// Notebook tab
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Filters");
		this.tabsMain.SetTabLabel (this.filterBox, this.label5);
		this.label5.ShowAll ();
		// Notebook tab
		global::Gtk.Label w32 = new global::Gtk.Label ();
		w32.Visible = true;
		this.tabsMain.Add (w32);
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Inspector");
		this.tabsMain.SetTabLabel (w32, this.label6);
		this.label6.ShowAll ();
		this.mainSplit.Add (this.tabsMain);
		this.vbox1.Add (this.mainSplit);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.mainSplit]));
		w34.Position = 1;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1211;
		this.DefaultHeight = 552;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.ExitAction.Activated += new global::System.EventHandler (this.OnExitActionActivated);
		this.btnStart.Clicked += new global::System.EventHandler (this.OnBtnStartClicked);
	}
}
