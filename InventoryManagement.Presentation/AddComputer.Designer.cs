namespace InventoryManagement.Presentation
{
    partial class frmAddComputer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtPcName = new System.Windows.Forms.TextBox();
            this.txtGMPc = new System.Windows.Forms.TextBox();
            this.txtOperativeSis = new System.Windows.Forms.TextBox();
            this.txtGMMonitor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdditionalLic = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOfficeLic = new System.Windows.Forms.TextBox();
            this.txtOfficeVer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gbxDisclaimer = new System.Windows.Forms.GroupBox();
            this.gbxAntivirus = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxDisclaimer.SuspendLayout();
            this.gbxAntivirus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir Computadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dependencia:";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Estudiantes_Practicantes",
            "Legislatura_Municipal",
            "Oficina_del_Alcalde",
            "Ayuda_al_Ciudadano",
            "Sub_Programa_Asuntos_de_la_Mujer",
            "Sub_Programa_Personas_Impedimentos",
            "Ayudantes_del_Alcalde",
            "Control_de_Acceso_Vec_y_peatonal",
            "Ayuda_al_Cuidadano__serv_comunales",
            "Ciudad_Verde",
            "Asuntos_Legales",
            "Auditoría_Interna",
            "Ofic_Protocolo_y_Coord_de_Act",
            "Oficina_de_Planificación",
            "CDBG_Planificación",
            "Ordenamiento_Territorial",
            "DC_Desarrollo_Comunal",
            "DC_Inic_Obras_Públicas",
            "DC_Proyecto_Impacto",
            "DC_Proyecto_Bayamón_Empresa",
            "DC_Diseño_y_Construcción",
            "DC_Adquisición_y_Rehalojo",
            "Depto_de_Finanzas",
            "Depto_de_Recursos_Humanos",
            "Depto_de_Secretaría",
            "Serv_Gen_Dirección",
            "Serv_Gen_Programa_de_Consejería",
            "Serv_Gen_Programa_Mantenimiento",
            "Serv_Gen_Compras_y_Suministros",
            "Serv_Gen_Servicios_Miscelaneos",
            "Serv_Gen_Otras_DepMun_Est_Fed",
            "Depto_de_Servicios_Generales",
            "Serv_Gen_Imprenta_y_Maq_Dupl",
            "SG_Mantenimiento",
            "SG_Mantenimiento_Casa_Alcaldía",
            "SG_Distribución",
            "Depto_de_Historia_y_Cultura",
            "HC_Banda_Municipal",
            "HC_Museo",
            "WIA_Depto_Trabajo",
            "WIA_Proyecto_Especial_Edward_Byrne",
            "WIA_Welfare_of_Work",
            "Serv_Com_Administración",
            "Serv_Com_Empleo_y_Futuro",
            "Serv_Com_Taller_de_Artes",
            "Serv_Com_Prevención",
            "Serv_Com_Alianza_y_Refugio",
            "Serv_Com_Ciudad_Dorada",
            "Serv_Com_Villa_Contessa",
            "Serv_Com_Senior_Citizens",
            "Serv_Com_ProyPater_Responsable",
            "Serv_Com_Asist_en_el_Hogar",
            "Serv_Com_Empleo_Envejecientes",
            "Serv_Com_Ciud_Dor_Cefe_Cedeño",
            "Serv_Com_Proyecto_HPRP_ARRA",
            "HS_Olazabal",
            "HS_Riverview",
            "HS_Santa_Juanita_I",
            "HS_Pueblito",
            "HS_Sta_Olaya_I",
            "HS_Paloma_Oficina",
            "HS_Teresita",
            "HS_Santa_Olaya_II",
            "HS_Rexville",
            "HS_Santa_Juanita_III",
            "HS_Campo_Alegre",
            "HS_La_Milagrosa",
            "HS_Ciudad_del_Niño",
            "HS_Ger_Salud_y_Des",
            "HS_Alt_de_Flam_II",
            "HS_Almacén",
            "HS_Juan_Sánchez_I",
            "HS_Administración",
            "HS_Ger_Educación",
            "HS_Brisas",
            "HS_Guadiana",
            "HS_Minillas",
            "HS_Miraflores",
            "HS_El_Verde",
            "HS_Guaraguao",
            "Hs_USI_I",
            "HS_La_Peña",
            "HS_Brigada",
            "HS_Río_Hondo",
            "HS_Feijoo",
            "HS_San_Fernando",
            "HS_Dajaos",
            "HS_Bo_Nuevo_I",
            "HS_Doña_Elena",
            "Hs_USI_IV",
            "HS_Villa_España",
            "HS_Vista_Alegre",
            "HS_Paloma_Centro",
            "HS_Pasarell",
            "HS_Alt_De_Flamb",
            "HS_Flamingo",
            "HS_Falin_Torrech",
            "HS_Early_Oficina",
            "Hs_USI_III",
            "Hs_USI_II",
            "HS_Bella_Vista",
            "HS_Early_Sierra_Bayamón",
            "HS_Valencia",
            "HS_Finanzas",
            "HS_Piñas",
            "HS_Bay_Gdns_I",
            "HS_Van_Scoy_II",
            "HS_Sta_Monica",
            "HS_Anones",
            "HS_Margarita",
            "HS_Alianza",
            "HS_Alcaldia",
            "HS_Cedro_Abajo",
            "HS_Rio_Plantation",
            "HS_Mi_Jardin",
            "HS_Valle_del_Sol",
            "HS_Bayamón_Gardens_II",
            "HS_Cerro_Gordo",
            "HS_Sabana",
            "HS_Ger_S_N_N_E",
            "HS_Virgilio_Davila",
            "HS_Van_Scoy_I",
            "HS_Sierra_Linda",
            "HS_Naranjito_Pueblo",
            "HS_HSTE_Sierra_Bayamon",
            "HS_USDA_Administración",
            "HS_USDA_Operaciones",
            "HS_Municipal",
            "HS_Child_Care_Edif_F",
            "HS_Early_Santa_Elena",
            "HS_Zona_VI_Adm",
            "HS_USI_V",
            "HS_Ciudad_del_Niño_C_C_I_Edif_A",
            "HS_Sta_Juanita_III_C_C",
            "HS_Flamingo_C_C_I",
            "HS_La_Morenita",
            "HS_Juan_Sanchez_II",
            "HS_Riverview_CC",
            "HS_Pueblito_CC",
            "HS_Hato_Tejas_C_C_I",
            "HS_Alt_de_Flamboyan_C_C_I",
            "HS_Olazabal_CC",
            "HS_Sta_Juanita_III_C_I",
            "HS_Ciudad_del_Niñ_C_C_II_Edif_B",
            "HS_Hato_Tejas",
            "HS_Flamingo_Hills_C_C_II",
            "HS_Alt_de_Flamboyan_C_C_II",
            "HS_Sta_Juanita_III_C_C_II",
            "HS_Sta_Juanita_III_C_C_III",
            "HS_Ciudad_del_Niño_CC_III_Edif_C",
            "HS_USDA_AdmGerencia_y_Desarrollo",
            "HS_USDA_Pueblito",
            "HS_USDA_Margarita",
            "HS_USDA_StaJuanita_IV",
            "HS_USDA_Ciudad_del_Niño",
            "HS_USDA_AdmGer_Des_y_Salud",
            "HS_HSTM_Zona_III",
            "HS_HSTM_Almacen",
            "HS_HSTM_Rio_Hondo",
            "HS_HSTM_Sta_Juanita",
            "HS_HSTM_Valle_del_Sol",
            "HS_HSTM_Piña",
            "HS_HSTM_Zona_II_Adm",
            "HS_HSTM_Brigada",
            "HS_HSTM_La_Peña",
            "HS_HSTM_Van_Scoy_I",
            "HS_HSTM_Hato_Tejas",
            "HS_HSTM_Alt_Flamboyan",
            "HS_HSTM_Ciudad_del_Niño",
            "HS_HSTM_Sta_Mónica",
            "HS_HSTM_Sta_Juanita_I",
            "HS_HSTM_La_Milagrosa",
            "HS_HSTM_Dajaos",
            "HS_HSTM_Bella_Vista",
            "HS_USDA_OPER_PASARELL",
            "HS_EARLY_CENTRO_C_C_I",
            "HS_LA_PRIETA",
            "HS_Sta_Juanita_IV",
            "HS_E_R_S_E_A",
            "HS_LOMAS",
            "EM_Parque_de_las_Ciencias",
            "EM_Parque_Forestal",
            "EM_Complejo_Onofre_Carballeira",
            "EM_Gimnasio_Miguel_A_Frau",
            "EM_Estadio_Juan_R_Loubriel",
            "EM_Coliseo_Ruben_Rodríguez",
            "Empresas_Municipales",
            "Depto_de_Transportación",
            "PA_Dirección",
            "PA_Programa_Reciclaje",
            "PA_Prog_Conserv_y_Obras",
            "PA_Protección_Especial",
            "OP_Dirección",
            "OP_Ingenieria, Estudio_y_Diseño",
            "OP_Programa_Equipo_Pesado",
            "OP_Construcción__Mantenimiento",
            "OP_Oficinistas_y_Delineantes",
            "RD_Dirección",
            "RD_Parque_Roberto_J_Jughanns",
            "RD_Parque_Lineal",
            "RD_Prog_Ornato_y_Mantenimiento",
            "RD_Depto_Recreación_y_Deportes",
            "RD_Complejo_Rafael_Martínez_Nadal",
            "RD_Complejo_Efrain_Calcaño_Alicea",
            "RD_Monumento_Pasea_Barbosa",
            "RD_Cancha_Pepín_Cestero",
            "RD_Parque_Central_de_Niños_Bay_",
            "RD_Centros_Comunales",
            "RD_Campo_de_Golf",
            "RD_Campo_de_Soccer",
            "AMMED_Programa_de_Dirección",
            "AMMED_Búsqueda_y_Rescate",
            "AMMED_Vigilantes_Vida_y_Propiedad",
            "AMMED_Orientación_Adiestramiento",
            "AMMED",
            "AMMED_Manejo_de_Emergs_y_Desastre",
            "Compras_Bienes_y_Suministros",
            "DE_Programa_de_Dirección",
            "DE_Servicio_al_Estudiantes",
            "DE_Mant_Edificios_Escolares",
            "DE_Programa_de_Bioblioteca",
            "FC_Plaza_de_Mercado",
            "FC_Terminal_Tomas_Kuilan_Pérez",
            "FC_Terminal_Antonio_Guardarrama",
            "FC_Terminal_Joaquín_Montesino",
            "FC_Regl_Vendedores_Ambulantes",
            "FC_Administración",
            "Depto_de_Servicios_Técnicos",
            "Depto_de_Vivienda_Municipal",
            "DV_Programa_Home",
            "DV_Sección_8",
            "DV_HOME_Nueva_Construcción",
            "DV_HOME_Adq_Hogar_Propio",
            "Depto_de_Reforestación_y_Ornato",
            "Paseo_Lineal_Rio_Bayamón",
            "Cementerio_Lomas_Verde",
            "Cementerio_Braulio_Dueño",
            "Oficina_Gerencia_y_Presupuesto",
            "Información_Gerencial",
            "Seg_Púb_Dirección",
            "Seg_Púb_Policía_Municipal",
            "Seg_Púb__Propuesta_C_O_P_S_",
            "Seg_Pub_Propuesta_A_R_R_A",
            "Seg_Púb_TASS",
            "Seg_Pub_Policias_Auxiliares",
            "Médicina_Pre_Hosp_y_Desatre",
            "Salud_a_tu_Alcance",
            "Centro_de_Epidemiología",
            "Epidemiología_Formula_Grant",
            "Centro_de_Epidemiologia_Municipal",
            "Ofic_de_Prensa_Y_Comunicaciones",
            "Programa_Vigilantes_Ambientales",
            "Programa_Nuevo_Amanecer",
            "Program_de_Deambulantes",
            "Alcaldía_en_tu_Comunidad",
            "Oficina_de_Permisos"});
            this.cbxDepartment.Location = new System.Drawing.Point(257, 155);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(265, 24);
            this.cbxDepartment.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(257, 223);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(265, 22);
            this.txtUser.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marca:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(257, 284);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(265, 22);
            this.txtBrand.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Modelo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "RAM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "PC Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "GM PC:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(257, 349);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(265, 22);
            this.txtModel.TabIndex = 11;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(257, 406);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(265, 22);
            this.txtRAM.TabIndex = 12;
            // 
            // txtPcName
            // 
            this.txtPcName.Location = new System.Drawing.Point(257, 467);
            this.txtPcName.Name = "txtPcName";
            this.txtPcName.Size = new System.Drawing.Size(265, 22);
            this.txtPcName.TabIndex = 13;
            // 
            // txtGMPc
            // 
            this.txtGMPc.Location = new System.Drawing.Point(257, 527);
            this.txtGMPc.Name = "txtGMPc";
            this.txtGMPc.Size = new System.Drawing.Size(265, 22);
            this.txtGMPc.TabIndex = 14;
            // 
            // txtOperativeSis
            // 
            this.txtOperativeSis.Location = new System.Drawing.Point(257, 649);
            this.txtOperativeSis.Name = "txtOperativeSis";
            this.txtOperativeSis.Size = new System.Drawing.Size(265, 22);
            this.txtOperativeSis.TabIndex = 20;
            // 
            // txtGMMonitor
            // 
            this.txtGMMonitor.Location = new System.Drawing.Point(257, 589);
            this.txtGMMonitor.Name = "txtGMMonitor";
            this.txtGMMonitor.Size = new System.Drawing.Size(265, 22);
            this.txtGMMonitor.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(100, 645);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Sist. Operativo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(100, 585);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "GM Monitor:";
            // 
            // txtAdditionalLic
            // 
            this.txtAdditionalLic.Location = new System.Drawing.Point(993, 460);
            this.txtAdditionalLic.Multiline = true;
            this.txtAdditionalLic.Name = "txtAdditionalLic";
            this.txtAdditionalLic.Size = new System.Drawing.Size(320, 188);
            this.txtAdditionalLic.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(750, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Licencias Adicionales:";
            // 
            // txtOfficeLic
            // 
            this.txtOfficeLic.Location = new System.Drawing.Point(907, 277);
            this.txtOfficeLic.Name = "txtOfficeLic";
            this.txtOfficeLic.Size = new System.Drawing.Size(265, 22);
            this.txtOfficeLic.TabIndex = 28;
            // 
            // txtOfficeVer
            // 
            this.txtOfficeVer.Location = new System.Drawing.Point(907, 220);
            this.txtOfficeVer.Name = "txtOfficeVer";
            this.txtOfficeVer.Size = new System.Drawing.Size(265, 22);
            this.txtOfficeVer.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(750, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Lic. Office:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(750, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 25);
            this.label16.TabIndex = 23;
            this.label16.Text = "Ver. Office:";
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(907, 155);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(265, 22);
            this.txtLicense.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(750, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 25);
            this.label17.TabIndex = 21;
            this.label17.Text = "Licencia:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 21);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Si";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 21);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gbxDisclaimer
            // 
            this.gbxDisclaimer.Controls.Add(this.radioButton1);
            this.gbxDisclaimer.Controls.Add(this.radioButton2);
            this.gbxDisclaimer.Location = new System.Drawing.Point(755, 327);
            this.gbxDisclaimer.Name = "gbxDisclaimer";
            this.gbxDisclaimer.Size = new System.Drawing.Size(179, 100);
            this.gbxDisclaimer.TabIndex = 36;
            this.gbxDisclaimer.TabStop = false;
            this.gbxDisclaimer.Text = "Disclaimer";
            // 
            // gbxAntivirus
            // 
            this.gbxAntivirus.Controls.Add(this.radioButton3);
            this.gbxAntivirus.Controls.Add(this.radioButton4);
            this.gbxAntivirus.Location = new System.Drawing.Point(993, 327);
            this.gbxAntivirus.Name = "gbxAntivirus";
            this.gbxAntivirus.Size = new System.Drawing.Size(179, 100);
            this.gbxAntivirus.TabIndex = 37;
            this.gbxAntivirus.TabStop = false;
            this.gbxAntivirus.Text = "Antivirus";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(41, 21);
            this.radioButton3.TabIndex = 34;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Si";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 59);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 21);
            this.radioButton4.TabIndex = 35;
            this.radioButton4.Text = "No";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1127, 727);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(239, 103);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxAntivirus);
            this.Controls.Add(this.gbxDisclaimer);
            this.Controls.Add(this.txtAdditionalLic);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOfficeLic);
            this.Controls.Add(this.txtOfficeVer);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtOperativeSis);
            this.Controls.Add(this.txtGMMonitor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGMPc);
            this.Controls.Add(this.txtPcName);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddComputer";
            this.Size = new System.Drawing.Size(1583, 884);
            this.gbxDisclaimer.ResumeLayout(false);
            this.gbxDisclaimer.PerformLayout();
            this.gbxAntivirus.ResumeLayout(false);
            this.gbxAntivirus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtPcName;
        private System.Windows.Forms.TextBox txtGMPc;
        private System.Windows.Forms.TextBox txtOperativeSis;
        private System.Windows.Forms.TextBox txtGMMonitor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAdditionalLic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOfficeLic;
        private System.Windows.Forms.TextBox txtOfficeVer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gbxDisclaimer;
        private System.Windows.Forms.GroupBox gbxAntivirus;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btnSave;
    }
}
