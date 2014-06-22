﻿namespace SCJMapper_V2
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      timer1.Stop( );
      // Unacquire all DirectInput objects.
      foreach ( JoystickCls js in m_JS ) js.FinishDX( );

      if ( disposing && ( components != null ) ) {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.btDumpList = new System.Windows.Forms.Button();
      this.btReset = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.rtb = new System.Windows.Forms.RichTextBox();
      this.btGrab = new System.Windows.Forms.Button();
      this.btDump = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label56 = new System.Windows.Forms.Label();
      this.label55 = new System.Windows.Forms.Label();
      this.label57 = new System.Windows.Forms.Label();
      this.label54 = new System.Windows.Forms.Label();
      this.cbJs3 = new System.Windows.Forms.ComboBox();
      this.cbJs2 = new System.Windows.Forms.ComboBox();
      this.cbJs1 = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btFind = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.btClear = new System.Windows.Forms.Button();
      this.lblLastJ = new System.Windows.Forms.Label();
      this.lblAction = new System.Windows.Forms.Label();
      this.btAssign = new System.Windows.Forms.Button();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.tc1 = new System.Windows.Forms.TabControl();
      this.tabJS1 = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label8 = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.buttonExit = new System.Windows.Forms.Button();
      this.OFD = new System.Windows.Forms.OpenFileDialog();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.cmCopyPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsiCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiPReplace = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiSelAll = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsiOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.SFD = new System.Windows.Forms.SaveFileDialog();
      this.IL = new System.Windows.Forms.ImageList(this.components);
      this.UC_JoyPanel = new SCJMapper_V2.UC_JoyPanel();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.tc1.SuspendLayout();
      this.tabJS1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.cmCopyPaste.SuspendLayout();
      this.SuspendLayout();
      // 
      // btDumpList
      // 
      this.btDumpList.Location = new System.Drawing.Point(398, 636);
      this.btDumpList.Name = "btDumpList";
      this.btDumpList.Size = new System.Drawing.Size(94, 26);
      this.btDumpList.TabIndex = 24;
      this.btDumpList.Text = "Dump List-->";
      this.btDumpList.UseVisualStyleBackColor = true;
      this.btDumpList.Click += new System.EventHandler(this.btDumpList_Click);
      // 
      // btReset
      // 
      this.btReset.Location = new System.Drawing.Point(397, 679);
      this.btReset.Name = "btReset";
      this.btReset.Size = new System.Drawing.Size(94, 24);
      this.btReset.TabIndex = 23;
      this.btReset.Text = "Reset";
      this.btReset.Click += new System.EventHandler(this.btReset_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(797, 685);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(214, 13);
      this.label3.TabIndex = 22;
      this.label3.Text = "Right click above to open the context menu";
      // 
      // rtb
      // 
      this.rtb.AcceptsTab = true;
      this.rtb.BackColor = System.Drawing.Color.Ivory;
      this.rtb.ContextMenuStrip = this.cmCopyPaste;
      this.rtb.DetectUrls = false;
      this.rtb.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtb.Location = new System.Drawing.Point(682, 74);
      this.rtb.Name = "rtb";
      this.rtb.Size = new System.Drawing.Size(439, 608);
      this.rtb.TabIndex = 21;
      this.rtb.Text = "";
      this.rtb.WordWrap = false;
      // 
      // btGrab
      // 
      this.btGrab.Location = new System.Drawing.Point(579, 604);
      this.btGrab.Name = "btGrab";
      this.btGrab.Size = new System.Drawing.Size(94, 26);
      this.btGrab.TabIndex = 19;
      this.btGrab.Text = "<-- Grab XML";
      this.btGrab.UseVisualStyleBackColor = true;
      this.btGrab.Click += new System.EventHandler(this.btGrab_Click);
      // 
      // btDump
      // 
      this.btDump.Location = new System.Drawing.Point(398, 604);
      this.btDump.Name = "btDump";
      this.btDump.Size = new System.Drawing.Size(94, 26);
      this.btDump.TabIndex = 20;
      this.btDump.Text = "Dump XML-->";
      this.btDump.UseVisualStyleBackColor = true;
      this.btDump.Click += new System.EventHandler(this.btDump_Click);
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Controls.Add(this.label56);
      this.panel3.Controls.Add(this.label55);
      this.panel3.Controls.Add(this.label57);
      this.panel3.Controls.Add(this.label54);
      this.panel3.Controls.Add(this.cbJs3);
      this.panel3.Controls.Add(this.cbJs2);
      this.panel3.Controls.Add(this.cbJs1);
      this.panel3.Location = new System.Drawing.Point(387, 355);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(289, 134);
      this.panel3.TabIndex = 18;
      // 
      // label56
      // 
      this.label56.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label56.Location = new System.Drawing.Point(7, 101);
      this.label56.Name = "label56";
      this.label56.Size = new System.Drawing.Size(39, 20);
      this.label56.TabIndex = 2;
      this.label56.Text = "js3";
      // 
      // label55
      // 
      this.label55.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label55.Location = new System.Drawing.Point(7, 74);
      this.label55.Name = "label55";
      this.label55.Size = new System.Drawing.Size(39, 20);
      this.label55.TabIndex = 2;
      this.label55.Text = "js2";
      // 
      // label57
      // 
      this.label57.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label57.Location = new System.Drawing.Point(7, 9);
      this.label57.Name = "label57";
      this.label57.Size = new System.Drawing.Size(267, 20);
      this.label57.TabIndex = 2;
      this.label57.Text = "SC-Device to Joystick Mapping";
      // 
      // label54
      // 
      this.label54.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label54.Location = new System.Drawing.Point(7, 47);
      this.label54.Name = "label54";
      this.label54.Size = new System.Drawing.Size(39, 20);
      this.label54.TabIndex = 2;
      this.label54.Text = "js1";
      // 
      // cbJs3
      // 
      this.cbJs3.DisplayMember = "js1";
      this.cbJs3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbJs3.FormattingEnabled = true;
      this.cbJs3.Items.AddRange(new object[] {
            "Joystick 1",
            "Joystick 2",
            "Joystick 3"});
      this.cbJs3.Location = new System.Drawing.Point(52, 98);
      this.cbJs3.MaxDropDownItems = 4;
      this.cbJs3.Name = "cbJs3";
      this.cbJs3.Size = new System.Drawing.Size(233, 25);
      this.cbJs3.TabIndex = 0;
      // 
      // cbJs2
      // 
      this.cbJs2.DisplayMember = "js1";
      this.cbJs2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbJs2.FormattingEnabled = true;
      this.cbJs2.Items.AddRange(new object[] {
            "Joystick 1",
            "Joystick 2",
            "Joystick 3"});
      this.cbJs2.Location = new System.Drawing.Point(52, 71);
      this.cbJs2.MaxDropDownItems = 4;
      this.cbJs2.Name = "cbJs2";
      this.cbJs2.Size = new System.Drawing.Size(233, 25);
      this.cbJs2.TabIndex = 0;
      // 
      // cbJs1
      // 
      this.cbJs1.DisplayMember = "js1";
      this.cbJs1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbJs1.FormattingEnabled = true;
      this.cbJs1.Items.AddRange(new object[] {
            "Joystick 1",
            "Joystick 2",
            "Joystick 3"});
      this.cbJs1.Location = new System.Drawing.Point(52, 44);
      this.cbJs1.MaxDropDownItems = 4;
      this.cbJs1.Name = "cbJs1";
      this.cbJs1.Size = new System.Drawing.Size(233, 25);
      this.cbJs1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.btFind);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.btClear);
      this.panel2.Controls.Add(this.lblLastJ);
      this.panel2.Controls.Add(this.lblAction);
      this.panel2.Controls.Add(this.btAssign);
      this.panel2.Location = new System.Drawing.Point(387, 495);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(289, 103);
      this.panel2.TabIndex = 17;
      // 
      // btFind
      // 
      this.btFind.Location = new System.Drawing.Point(190, 37);
      this.btFind.Name = "btFind";
      this.btFind.Size = new System.Drawing.Size(84, 20);
      this.btFind.TabIndex = 12;
      this.btFind.Text = "Find 1st.";
      this.btFind.UseVisualStyleBackColor = true;
      this.btFind.Click += new System.EventHandler(this.btFind_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(7, 37);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(25, 13);
      this.label7.TabIndex = 3;
      this.label7.Text = "Ctrl.";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(7, 17);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(31, 13);
      this.label6.TabIndex = 3;
      this.label6.Text = "Cmd.";
      // 
      // btClear
      // 
      this.btClear.Location = new System.Drawing.Point(190, 67);
      this.btClear.Name = "btClear";
      this.btClear.Size = new System.Drawing.Size(94, 25);
      this.btClear.TabIndex = 2;
      this.btClear.Text = "Clear";
      this.btClear.UseVisualStyleBackColor = true;
      this.btClear.Click += new System.EventHandler(this.btClear_Click);
      // 
      // lblLastJ
      // 
      this.lblLastJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblLastJ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLastJ.Location = new System.Drawing.Point(52, 37);
      this.lblLastJ.Name = "lblLastJ";
      this.lblLastJ.Size = new System.Drawing.Size(135, 20);
      this.lblLastJ.TabIndex = 1;
      this.lblLastJ.Text = "...";
      // 
      // lblAction
      // 
      this.lblAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblAction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAction.Location = new System.Drawing.Point(52, 17);
      this.lblAction.Name = "lblAction";
      this.lblAction.Size = new System.Drawing.Size(222, 20);
      this.lblAction.TabIndex = 1;
      this.lblAction.Text = "...";
      // 
      // btAssign
      // 
      this.btAssign.Location = new System.Drawing.Point(10, 67);
      this.btAssign.Name = "btAssign";
      this.btAssign.Size = new System.Drawing.Size(94, 25);
      this.btAssign.TabIndex = 0;
      this.btAssign.Text = "Assign";
      this.btAssign.UseVisualStyleBackColor = true;
      this.btAssign.Click += new System.EventHandler(this.btAssign_Click);
      // 
      // treeView1
      // 
      this.treeView1.HotTracking = true;
      this.treeView1.ImageKey = "Map";
      this.treeView1.ImageList = this.IL;
      this.treeView1.Location = new System.Drawing.Point(12, 74);
      this.treeView1.Name = "treeView1";
      this.treeView1.SelectedImageKey = "Selected";
      this.treeView1.Size = new System.Drawing.Size(369, 629);
      this.treeView1.TabIndex = 16;
      this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
      // 
      // tc1
      // 
      this.tc1.Controls.Add(this.tabJS1);
      this.tc1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
      this.tc1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tc1.HotTrack = true;
      this.tc1.ItemSize = new System.Drawing.Size(62, 22);
      this.tc1.Location = new System.Drawing.Point(387, 74);
      this.tc1.Multiline = true;
      this.tc1.Name = "tc1";
      this.tc1.SelectedIndex = 0;
      this.tc1.Size = new System.Drawing.Size(289, 275);
      this.tc1.TabIndex = 15;
      this.tc1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tc1_DrawItem);
      // 
      // tabJS1
      // 
      this.tabJS1.Controls.Add(this.UC_JoyPanel);
      this.tabJS1.Location = new System.Drawing.Point(4, 26);
      this.tabJS1.Name = "tabJS1";
      this.tabJS1.Padding = new System.Windows.Forms.Padding(3);
      this.tabJS1.Size = new System.Drawing.Size(281, 245);
      this.tabJS1.TabIndex = 0;
      this.tabJS1.Text = "Joystick 1";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.lblTitle);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Location = new System.Drawing.Point(2, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1109, 66);
      this.panel1.TabIndex = 14;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(353, 42);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(54, 13);
      this.label8.TabIndex = 2;
      this.label8.Text = "by Cassini";
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(226, 8);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(185, 25);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "SC Joystick Mapper";
      // 
      // label4
      // 
      this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
      this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label4.Location = new System.Drawing.Point(0, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(220, 66);
      this.label4.TabIndex = 0;
      // 
      // buttonExit
      // 
      this.buttonExit.Location = new System.Drawing.Point(577, 679);
      this.buttonExit.Name = "buttonExit";
      this.buttonExit.Size = new System.Drawing.Size(94, 24);
      this.buttonExit.TabIndex = 13;
      this.buttonExit.Text = "Exit";
      this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
      // 
      // OFD
      // 
      this.OFD.DefaultExt = "xml";
      this.OFD.FileName = "Open Map File";
      this.OFD.Filter = "Mapping files|*.xml|All files|*.*";
      this.OFD.ReadOnlyChecked = true;
      this.OFD.SupportMultiDottedExtensions = true;
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // cmCopyPaste
      // 
      this.cmCopyPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCopy,
            this.tsiPaste,
            this.tsiPReplace,
            this.tsiSelAll,
            this.toolStripSeparator1,
            this.tsiOpen,
            this.tsiSaveAs});
      this.cmCopyPaste.Name = "cmCopyPaste";
      this.cmCopyPaste.Size = new System.Drawing.Size(170, 142);
      // 
      // tsiCopy
      // 
      this.tsiCopy.Name = "tsiCopy";
      this.tsiCopy.Size = new System.Drawing.Size(169, 22);
      this.tsiCopy.Text = "Copy";
      this.tsiCopy.Click += new System.EventHandler(this.tsiCopy_Click);
      // 
      // tsiPaste
      // 
      this.tsiPaste.Name = "tsiPaste";
      this.tsiPaste.Size = new System.Drawing.Size(169, 22);
      this.tsiPaste.Text = "Paste";
      this.tsiPaste.Click += new System.EventHandler(this.tsiPaste_Click);
      // 
      // tsiPReplace
      // 
      this.tsiPReplace.Name = "tsiPReplace";
      this.tsiPReplace.Size = new System.Drawing.Size(169, 22);
      this.tsiPReplace.Text = "Paste (Replace all)";
      this.tsiPReplace.Click += new System.EventHandler(this.tsiPReplace_Click);
      // 
      // tsiSelAll
      // 
      this.tsiSelAll.Name = "tsiSelAll";
      this.tsiSelAll.Size = new System.Drawing.Size(169, 22);
      this.tsiSelAll.Text = "Select All";
      this.tsiSelAll.Click += new System.EventHandler(this.tsiSelAll_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
      // 
      // tsiOpen
      // 
      this.tsiOpen.Name = "tsiOpen";
      this.tsiOpen.Size = new System.Drawing.Size(169, 22);
      this.tsiOpen.Text = "Open...";
      this.tsiOpen.Click += new System.EventHandler(this.tsiOpen_Click);
      // 
      // tsiSaveAs
      // 
      this.tsiSaveAs.Name = "tsiSaveAs";
      this.tsiSaveAs.Size = new System.Drawing.Size(169, 22);
      this.tsiSaveAs.Text = "Save as...";
      this.tsiSaveAs.Click += new System.EventHandler(this.tsiSaveAs_Click);
      // 
      // SFD
      // 
      this.SFD.DefaultExt = "xml";
      this.SFD.Filter = "Mapping files|*.xml|Text files|*.txt|All files|*.*";
      this.SFD.SupportMultiDottedExtensions = true;
      // 
      // IL
      // 
      this.IL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL.ImageStream")));
      this.IL.TransparentColor = System.Drawing.Color.Transparent;
      this.IL.Images.SetKeyName(0, "Map");
      this.IL.Images.SetKeyName(1, "Selected");
      this.IL.Images.SetKeyName(2, "J");
      this.IL.Images.SetKeyName(3, "K");
      this.IL.Images.SetKeyName(4, "X");
      this.IL.Images.SetKeyName(5, "P");
      this.IL.Images.SetKeyName(6, "Z");
      // 
      // UC_JoyPanel
      // 
      this.UC_JoyPanel.Location = new System.Drawing.Point(0, 6);
      this.UC_JoyPanel.Name = "UC_JoyPanel";
      this.UC_JoyPanel.Size = new System.Drawing.Size(278, 234);
      this.UC_JoyPanel.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1132, 715);
      this.Controls.Add(this.btDumpList);
      this.Controls.Add(this.btReset);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.rtb);
      this.Controls.Add(this.btGrab);
      this.Controls.Add(this.btDump);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.treeView1);
      this.Controls.Add(this.tc1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.buttonExit);
      this.Name = "MainForm";
      this.Text = "SC Joystick Mapper";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.tc1.ResumeLayout(false);
      this.tabJS1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.cmCopyPaste.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btDumpList;
    private System.Windows.Forms.Button btReset;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RichTextBox rtb;
    private System.Windows.Forms.Button btGrab;
    private System.Windows.Forms.Button btDump;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label56;
    private System.Windows.Forms.Label label55;
    private System.Windows.Forms.Label label57;
    private System.Windows.Forms.Label label54;
    private System.Windows.Forms.ComboBox cbJs3;
    private System.Windows.Forms.ComboBox cbJs2;
    private System.Windows.Forms.ComboBox cbJs1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btFind;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btClear;
    private System.Windows.Forms.Label lblLastJ;
    private System.Windows.Forms.Label lblAction;
    private System.Windows.Forms.Button btAssign;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.TabControl tc1;
    private System.Windows.Forms.TabPage tabJS1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button buttonExit;
    private System.Windows.Forms.OpenFileDialog OFD;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ContextMenuStrip cmCopyPaste;
    private System.Windows.Forms.ToolStripMenuItem tsiCopy;
    private System.Windows.Forms.ToolStripMenuItem tsiPaste;
    private System.Windows.Forms.ToolStripMenuItem tsiPReplace;
    private System.Windows.Forms.ToolStripMenuItem tsiSelAll;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem tsiOpen;
    private System.Windows.Forms.ToolStripMenuItem tsiSaveAs;
    private System.Windows.Forms.SaveFileDialog SFD;
    private System.Windows.Forms.ImageList IL;
    private UC_JoyPanel UC_JoyPanel;
  }
}
