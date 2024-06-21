namespace gestionstock3
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerArtilceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheDeLancementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheEnfilagePiquageAuPeigneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheDeControleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculDesBesoinsDesFilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcMachinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesMachinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMachinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arretsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRSDesMachinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificationDeProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePlanificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesDePlanificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calulPlanificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichePlanificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ficheTRSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.parcMachinesToolStripMenuItem,
            this.planificationDeProductionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(615, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.supprimerFournisseurToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(88, 20);
            this.fileMenu.Text = "Fournisseurs";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.nouveau;
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.newToolStripMenuItem.Text = "Nouvelle  Fournisseur";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.liste;
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openToolStripMenuItem.Text = "Listes Fournisseurs ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.update;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.saveToolStripMenuItem.Text = "Modifier Fournisseur";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // supprimerFournisseurToolStripMenuItem
            // 
            this.supprimerFournisseurToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.delet;
            this.supprimerFournisseurToolStripMenuItem.Name = "supprimerFournisseurToolStripMenuItem";
            this.supprimerFournisseurToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.supprimerFournisseurToolStripMenuItem.Text = "Supprimer Fournisseur";
            this.supprimerFournisseurToolStripMenuItem.Click += new System.EventHandler(this.supprimerFournisseurToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.editMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Fils";
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.nouveau;
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.undoToolStripMenuItem.Text = "Nouveau Fil";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.liste;
            this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.redoToolStripMenuItem.Text = "Listes Fils";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.update;
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cutToolStripMenuItem.Text = "Modifier Fil";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.delet;
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.copyToolStripMenuItem.Text = "Supprimer Fil";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.modifierArticleToolStripMenuItem,
            this.supprimerArticleToolStripMenuItem,
            this.imprimerArtilceToolStripMenuItem,
            this.ficheDeLancementToolStripMenuItem,
            this.ficheEnfilagePiquageAuPeigneToolStripMenuItem,
            this.ficheDeControleToolStripMenuItem,
            this.calculDesBesoinsDesFilsToolStripMenuItem});
            this.viewMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(60, 20);
            this.viewMenu.Text = "Articles";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.nouveau;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.toolBarToolStripMenuItem.Text = "Nouvelle Article";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.liste;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.statusBarToolStripMenuItem.Text = "Listes Articles";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // modifierArticleToolStripMenuItem
            // 
            this.modifierArticleToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.update;
            this.modifierArticleToolStripMenuItem.Name = "modifierArticleToolStripMenuItem";
            this.modifierArticleToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.modifierArticleToolStripMenuItem.Text = "Modifier Article";
            this.modifierArticleToolStripMenuItem.Click += new System.EventHandler(this.modifierArticleToolStripMenuItem_Click);
            // 
            // supprimerArticleToolStripMenuItem
            // 
            this.supprimerArticleToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.delet;
            this.supprimerArticleToolStripMenuItem.Name = "supprimerArticleToolStripMenuItem";
            this.supprimerArticleToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.supprimerArticleToolStripMenuItem.Text = "Supprimer Article";
            this.supprimerArticleToolStripMenuItem.Click += new System.EventHandler(this.supprimerArticleToolStripMenuItem_Click);
            // 
            // imprimerArtilceToolStripMenuItem
            // 
            this.imprimerArtilceToolStripMenuItem.Name = "imprimerArtilceToolStripMenuItem";
            this.imprimerArtilceToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.imprimerArtilceToolStripMenuItem.Text = "Fiche technique";
            this.imprimerArtilceToolStripMenuItem.Click += new System.EventHandler(this.imprimerArtilceToolStripMenuItem_Click);
            // 
            // ficheDeLancementToolStripMenuItem
            // 
            this.ficheDeLancementToolStripMenuItem.Name = "ficheDeLancementToolStripMenuItem";
            this.ficheDeLancementToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.ficheDeLancementToolStripMenuItem.Text = "Fiche de lancement  ";
            // 
            // ficheEnfilagePiquageAuPeigneToolStripMenuItem
            // 
            this.ficheEnfilagePiquageAuPeigneToolStripMenuItem.Name = "ficheEnfilagePiquageAuPeigneToolStripMenuItem";
            this.ficheEnfilagePiquageAuPeigneToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.ficheEnfilagePiquageAuPeigneToolStripMenuItem.Text = "Fiche Enfilage/Piquage au peigne";
            // 
            // ficheDeControleToolStripMenuItem
            // 
            this.ficheDeControleToolStripMenuItem.Name = "ficheDeControleToolStripMenuItem";
            this.ficheDeControleToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.ficheDeControleToolStripMenuItem.Text = "Fiche  de  controle ";
            // 
            // calculDesBesoinsDesFilsToolStripMenuItem
            // 
            this.calculDesBesoinsDesFilsToolStripMenuItem.Name = "calculDesBesoinsDesFilsToolStripMenuItem";
            this.calculDesBesoinsDesFilsToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.calculDesBesoinsDesFilsToolStripMenuItem.Text = "Calcul des besoins des  fils";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.listesCommandesToolStripMenuItem,
            this.modifierCommandeToolStripMenuItem,
            this.supprimerCommandeToolStripMenuItem});
            this.toolsMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(79, 20);
            this.toolsMenu.Text = "Commande";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.nouveau;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.optionsToolStripMenuItem.Text = "Nouvelle Commande";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // listesCommandesToolStripMenuItem
            // 
            this.listesCommandesToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.liste;
            this.listesCommandesToolStripMenuItem.Name = "listesCommandesToolStripMenuItem";
            this.listesCommandesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listesCommandesToolStripMenuItem.Text = "Listes Commandes";
            this.listesCommandesToolStripMenuItem.Click += new System.EventHandler(this.listesCommandesToolStripMenuItem_Click);
            // 
            // modifierCommandeToolStripMenuItem
            // 
            this.modifierCommandeToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.update;
            this.modifierCommandeToolStripMenuItem.Name = "modifierCommandeToolStripMenuItem";
            this.modifierCommandeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.modifierCommandeToolStripMenuItem.Text = "Modifier Commande ";
            this.modifierCommandeToolStripMenuItem.Click += new System.EventHandler(this.modifierCommandeToolStripMenuItem_Click);
            // 
            // supprimerCommandeToolStripMenuItem
            // 
            this.supprimerCommandeToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.delet;
            this.supprimerCommandeToolStripMenuItem.Name = "supprimerCommandeToolStripMenuItem";
            this.supprimerCommandeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.supprimerCommandeToolStripMenuItem.Text = "Supprimer Commande";
            this.supprimerCommandeToolStripMenuItem.Click += new System.EventHandler(this.supprimerCommandeToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveleToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem});
            this.windowsMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(71, 20);
            this.windowsMenu.Text = "Tisserand";
            this.windowsMenu.Click += new System.EventHandler(this.windowsMenu_Click);
            // 
            // nouveleToolStripMenuItem
            // 
            this.nouveleToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.nouveau;
            this.nouveleToolStripMenuItem.Name = "nouveleToolStripMenuItem";
            this.nouveleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.nouveleToolStripMenuItem.Text = "Nouvelle Tisserand";
            this.nouveleToolStripMenuItem.Click += new System.EventHandler(this.nouveleToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.liste;
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cascadeToolStripMenuItem.Text = "Listes Tisserands";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.update;
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tileVerticalToolStripMenuItem.Text = "Modifier Tisserand";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.delet;
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Suprrimer Tisserand";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // parcMachinesToolStripMenuItem
            // 
            this.parcMachinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleMachineToolStripMenuItem,
            this.listesMachinesToolStripMenuItem,
            this.modifierMachinesToolStripMenuItem,
            this.supprimerMachineToolStripMenuItem,
            this.arretsToolStripMenuItem,
            this.tRSDesMachinesToolStripMenuItem,
            this.ficheTRSToolStripMenuItem});
            this.parcMachinesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcMachinesToolStripMenuItem.Name = "parcMachinesToolStripMenuItem";
            this.parcMachinesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.parcMachinesToolStripMenuItem.Text = "Parc machines";
            // 
            // nouvelleMachineToolStripMenuItem
            // 
            this.nouvelleMachineToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.nouveau;
            this.nouvelleMachineToolStripMenuItem.Name = "nouvelleMachineToolStripMenuItem";
            this.nouvelleMachineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouvelleMachineToolStripMenuItem.Text = "Nouvelle  machine";
            this.nouvelleMachineToolStripMenuItem.Click += new System.EventHandler(this.nouvelleMachineToolStripMenuItem_Click);
            // 
            // listesMachinesToolStripMenuItem
            // 
            this.listesMachinesToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.liste;
            this.listesMachinesToolStripMenuItem.Name = "listesMachinesToolStripMenuItem";
            this.listesMachinesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listesMachinesToolStripMenuItem.Text = "Listes machines";
            this.listesMachinesToolStripMenuItem.Click += new System.EventHandler(this.listesMachinesToolStripMenuItem_Click);
            // 
            // modifierMachinesToolStripMenuItem
            // 
            this.modifierMachinesToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.update;
            this.modifierMachinesToolStripMenuItem.Name = "modifierMachinesToolStripMenuItem";
            this.modifierMachinesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierMachinesToolStripMenuItem.Text = "Modifier machine";
            this.modifierMachinesToolStripMenuItem.Click += new System.EventHandler(this.modifierMachinesToolStripMenuItem_Click);
            // 
            // supprimerMachineToolStripMenuItem
            // 
            this.supprimerMachineToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.delet;
            this.supprimerMachineToolStripMenuItem.Name = "supprimerMachineToolStripMenuItem";
            this.supprimerMachineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerMachineToolStripMenuItem.Text = "Supprimer machine";
            this.supprimerMachineToolStripMenuItem.Click += new System.EventHandler(this.supprimerMachineToolStripMenuItem_Click);
            // 
            // arretsToolStripMenuItem
            // 
            this.arretsToolStripMenuItem.Name = "arretsToolStripMenuItem";
            this.arretsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arretsToolStripMenuItem.Text = "Arrets";
            this.arretsToolStripMenuItem.Click += new System.EventHandler(this.arretsToolStripMenuItem_Click);
            // 
            // tRSDesMachinesToolStripMenuItem
            // 
            this.tRSDesMachinesToolStripMenuItem.Name = "tRSDesMachinesToolStripMenuItem";
            this.tRSDesMachinesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tRSDesMachinesToolStripMenuItem.Text = "TRS des machines ";
            this.tRSDesMachinesToolStripMenuItem.Click += new System.EventHandler(this.tRSDesMachinesToolStripMenuItem_Click);
            // 
            // planificationDeProductionToolStripMenuItem
            // 
            this.planificationDeProductionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePlanificationToolStripMenuItem,
            this.listesDePlanificationToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.calulPlanificationToolStripMenuItem,
            this.fichePlanificationToolStripMenuItem});
            this.planificationDeProductionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planificationDeProductionToolStripMenuItem.Name = "planificationDeProductionToolStripMenuItem";
            this.planificationDeProductionToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.planificationDeProductionToolStripMenuItem.Text = "Planification de production";
            // 
            // nouvellePlanificationToolStripMenuItem
            // 
            this.nouvellePlanificationToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.nouveau;
            this.nouvellePlanificationToolStripMenuItem.Name = "nouvellePlanificationToolStripMenuItem";
            this.nouvellePlanificationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.nouvellePlanificationToolStripMenuItem.Text = "Nouvelle Planification";
            this.nouvellePlanificationToolStripMenuItem.Click += new System.EventHandler(this.nouvellePlanificationToolStripMenuItem_Click);
            // 
            // listesDePlanificationToolStripMenuItem
            // 
            this.listesDePlanificationToolStripMenuItem.Name = "listesDePlanificationToolStripMenuItem";
            this.listesDePlanificationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listesDePlanificationToolStripMenuItem.Text = "Listes de planification";
            this.listesDePlanificationToolStripMenuItem.Click += new System.EventHandler(this.listesDePlanificationToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.modifierToolStripMenuItem.Text = "Modifier Planification";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // calulPlanificationToolStripMenuItem
            // 
            this.calulPlanificationToolStripMenuItem.Image = global::gestionstock3.Properties.Resources.calcul;
            this.calulPlanificationToolStripMenuItem.Name = "calulPlanificationToolStripMenuItem";
            this.calulPlanificationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.calulPlanificationToolStripMenuItem.Text = "Saisie de production";
            this.calulPlanificationToolStripMenuItem.Click += new System.EventHandler(this.calulPlanificationToolStripMenuItem_Click);
            // 
            // fichePlanificationToolStripMenuItem
            // 
            this.fichePlanificationToolStripMenuItem.Name = "fichePlanificationToolStripMenuItem";
            this.fichePlanificationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.fichePlanificationToolStripMenuItem.Text = "Suivi de production";
            this.fichePlanificationToolStripMenuItem.Click += new System.EventHandler(this.fichePlanificationToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 363);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(615, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel.Text = "État";
            // 
            // ficheTRSToolStripMenuItem
            // 
            this.ficheTRSToolStripMenuItem.Name = "ficheTRSToolStripMenuItem";
            this.ficheTRSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ficheTRSToolStripMenuItem.Text = "Fiche TRS";
            this.ficheTRSToolStripMenuItem.Click += new System.EventHandler(this.ficheTRSToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 385);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.ShowIcon = false;
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem modifierArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcMachinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesMachinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierMachinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificationDeProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvellePlanificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calulPlanificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerArtilceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichePlanificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheDeLancementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheEnfilagePiquageAuPeigneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheDeControleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculDesBesoinsDesFilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arretsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesDePlanificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRSDesMachinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheTRSToolStripMenuItem;
    }
}



