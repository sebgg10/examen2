namespace examen2;

public partial class Form1 : Form
{
    ComboBox cmbMoneda;
    Label lblMoneda;
    Label lblMonto;
    Label lblConversiones;
    TextBox txtMonto;
    Button buttonCalcular;
    Button btnAceptar;
    Button btnLimpiar;

    CheckBox MXN;
    CheckBox USD;
    CheckBox CAD;
    CheckBox EUR;
    CheckBox JPY;
    Label lblConversionMXN;
    Label lblConversionUSD;
    Label lblConversionCAD;
    Label lblConversionEUR;
    Label lblConversionJPY;
    TextBox txtConversionMXN;
    TextBox txtConversionUSD;
    TextBox txtConversionCAD;
    TextBox txtConversionEUR;
    TextBox txtConversionJPY;
    Ventana2 nuevaVentana;

    public Form1()
    {
        cmbMoneda = new ComboBox();
        lblMoneda = new Label();
        lblMonto = new Label();
        lblConversiones = new Label();
        txtMonto = new TextBox();
        buttonCalcular = new Button();
        btnAceptar = new Button();
        btnLimpiar = new Button();
        MXN = new CheckBox();
        USD = new CheckBox();
        CAD = new CheckBox();
        EUR = new CheckBox();
        JPY = new CheckBox();
        lblConversionMXN = new Label();
        lblConversionUSD = new Label();
        lblConversionEUR = new Label();
        lblConversionCAD = new Label();
        lblConversionJPY = new Label();
        txtConversionMXN = new TextBox();
        txtConversionUSD = new TextBox();
        txtConversionCAD = new TextBox();
        txtConversionEUR = new TextBox();
        txtConversionJPY = new TextBox();
        nuevaVentana = new Ventana2();

        InitializeComponent();
        InicializaComponentes();
        
    }
    private void InicializaComponentes(){
        //Tamaño de la ventana
        this.Size = new Size(400,400);

        //Opciones del comboBox inicial
        cmbMoneda.Text = "--Selecciona la moneda a convertir--";
        cmbMoneda.Items.Add("MXN - Peso Mexicano");
        cmbMoneda.Items.Add("USD - Dolar Estadounidense");
        cmbMoneda.Items.Add("CAD - Dolar Canadiense");
        cmbMoneda.Items.Add("EUR - Euro");
        cmbMoneda.Items.Add("JPY - Yen Japones");
        cmbMoneda.Size = new Size(225,20);
        cmbMoneda.Location = new Point(10,30);


        //Etiqueta del ComboBox inicial
        lblMoneda.Text = "Moneda";
        lblMoneda.AutoSize = true;
        lblMoneda.Location = new Point(10,10);

        //Etiqueta del TextBox monto
        lblMonto.Text = "Monto";
        lblMonto.AutoSize = true;
        lblMonto.Location = new Point(250,10);

        //Etiqueta Conversiones
        lblConversiones.Text = "Conversiones";
        lblConversiones.AutoSize = true;
        lblConversiones.Location = new Point(10,100);

        //TextBox monto
        txtMonto.Size = new Size(100,20);
        txtMonto.Location = new Point(250, 30);

        //buttonCalcular (Ventana)
        buttonCalcular.Text = "Calcular";
        buttonCalcular.AutoSize = true;
        buttonCalcular.Location = new Point(250,60);
        buttonCalcular.Click += new EventHandler(buttonCalcular_Click);

        //buttonLimpiar
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.AutoSize = true;
        btnLimpiar.Location = new Point(300,320);
        btnLimpiar.Click += new EventHandler(btnLimpiar_Click);

        //CheckBox
        MXN.Text = "MXN - Peso Mexicano";
        MXN.AutoSize = true;
        USD.Text = "USD - Dolar Estadounidense";
        USD.AutoSize = true;
        CAD.Text = "CAD - Dolar Canadiense";
        CAD.AutoSize = true;
        EUR.Text = "EUR - Euro";
        EUR.AutoSize = true;
        JPY.Text = "JPY - Yen Japones";
        JPY.AutoSize = true;

        //Boton Aceptar
        btnAceptar.Text = "Aceptar";
        btnAceptar.AutoSize = true;
        btnAceptar.Location = new Point(210,165);

        this.Controls.Add(cmbMoneda);
        this.Controls.Add(lblMoneda);
        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);
        this.Controls.Add(buttonCalcular);
        this.Controls.Add(lblConversiones);
        this.Controls.Add(btnLimpiar);
    }
    private void btnLimpiar_Click(object sender, EventArgs e){
        Application.Restart();
    }
    private void buttonCalcular_Click(object sender, EventArgs e)
    {
        if (cmbMoneda.SelectedItem != null && txtMonto.Text.Length != 0){
            if (cmbMoneda.SelectedItem.ToString() == "MXN - Peso Mexicano")
            {
                nuevaVentana.Controls.Add(USD);
                USD.Location = new Point(10,10);
                nuevaVentana.Controls.Add(CAD);
                CAD.Location = new Point(10,30);
                nuevaVentana.Controls.Add(EUR);
                EUR.Location = new Point(10,50);
                nuevaVentana.Controls.Add(JPY);
                JPY.Location = new Point(10,70);
                nuevaVentana.Controls.Add(btnAceptar);
                btnAceptar.Click += new EventHandler(btnAceptar_ClickMXN);
                nuevaVentana.Show();
            }

            if (cmbMoneda.SelectedItem.ToString() == "USD - Dolar Estadounidense")
            {
                nuevaVentana.Controls.Add(MXN);
                MXN.Location = new Point(10,10);
                nuevaVentana.Controls.Add(CAD);
                CAD.Location = new Point(10,30);
                nuevaVentana.Controls.Add(EUR);
                EUR.Location = new Point(10,50);
                nuevaVentana.Controls.Add(JPY);
                JPY.Location = new Point(10,70);
                nuevaVentana.Controls.Add(btnAceptar);
                btnAceptar.Click += new EventHandler(btnAceptar_ClickUSD);
                nuevaVentana.Show();
            }

            if (cmbMoneda.SelectedItem.ToString() == "CAD - Dolar Canadiense")
            {
                nuevaVentana.Controls.Add(MXN);
                MXN.Location = new Point(10,10);
                nuevaVentana.Controls.Add(USD);
                USD.Location = new Point(10,30);
                nuevaVentana.Controls.Add(EUR);
                EUR.Location = new Point(10,50);
                nuevaVentana.Controls.Add(JPY);
                JPY.Location = new Point(10,70);
                nuevaVentana.Controls.Add(btnAceptar);
                btnAceptar.Click += new EventHandler(btnAceptar_ClickCAD);
                nuevaVentana.Show();
            }

            if (cmbMoneda.SelectedItem.ToString() == "EUR - Euro")
            {
                nuevaVentana.Controls.Add(MXN);
                MXN.Location = new Point(10,10);
                nuevaVentana.Controls.Add(USD);
                USD.Location = new Point(10,30);
                nuevaVentana.Controls.Add(CAD);
                CAD.Location = new Point(10,50);
                nuevaVentana.Controls.Add(JPY);
                JPY.Location = new Point(10,70);
                nuevaVentana.Controls.Add(btnAceptar);
                btnAceptar.Click += new EventHandler(btnAceptar_ClickEUR);
                nuevaVentana.Show();
            }

            if (cmbMoneda.SelectedItem.ToString() == "JPY - Yen Japones")
            {
                nuevaVentana.Controls.Add(MXN);
                MXN.Location = new Point(10,10);
                nuevaVentana.Controls.Add(USD);
                USD.Location = new Point(10,30);
                nuevaVentana.Controls.Add(CAD);
                CAD.Location = new Point(10,50);
                nuevaVentana.Controls.Add(EUR);
                EUR.Location = new Point(10,70);
                nuevaVentana.Controls.Add(btnAceptar);
                btnAceptar.Click += new EventHandler(btnAceptar_ClickJPY);
                nuevaVentana.Show();
            }
        }
    }

    private void btnAceptar_ClickMXN(object sender, EventArgs e){
        if (USD.Checked)
        {
            //Etiqueta ConversionUSD
            lblConversionUSD.Text = "USD - Dolar Estadounidense";
            lblConversionUSD.AutoSize = true;
            lblConversionUSD.Location = new Point(10,140);

            //TextBox ConversionUSD
            txtConversionUSD.Size = new Size(100,20);
            txtConversionUSD.Location = new Point(250, 140);

            this.Controls.Add(lblConversionUSD);
            this.Controls.Add(txtConversionUSD);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionUSD.Text = "$  " + (monto*0.05).ToString();
        }
        if (CAD.Checked)
        {
            //Etiqueta ConversionCAD
            lblConversionCAD.Text = "CAD - Dolar Canadiense";
            lblConversionCAD.AutoSize = true;
            lblConversionCAD.Location = new Point(10,160);

            //TextBox ConversionCAD
            txtConversionCAD.Size = new Size(100,20);
            txtConversionCAD.Location = new Point(250, 160);

            this.Controls.Add(lblConversionCAD);
            this.Controls.Add(txtConversionCAD);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionCAD.Text = "$  "+(monto*0.06).ToString();
        }
        if (EUR.Checked)
        {
            //Etiqueta ConversionEUR
            lblConversionEUR.Text = "EUR - Euro";
            lblConversionEUR.AutoSize = true;
            lblConversionEUR.Location = new Point(10,180);

            //TextBox ConversionEUR
            txtConversionEUR.Size = new Size(100,20);
            txtConversionEUR.Location = new Point(250, 180);

            this.Controls.Add(lblConversionEUR);
            this.Controls.Add(txtConversionEUR);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionEUR.Text = "€  "+(monto*0.04).ToString();
        }
        if (JPY.Checked)
        {
            //Etiqueta ConversionJPY
            lblConversionJPY.Text = "JPY - Yen Japones";
            lblConversionJPY.AutoSize = true;
            lblConversionJPY.Location = new Point(10,200);

            //TextBox ConversionJPY
            txtConversionJPY.Size = new Size(100,20);
            txtConversionJPY.Location = new Point(250, 200);

            this.Controls.Add(lblConversionJPY);
            this.Controls.Add(txtConversionJPY);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionJPY.Text = "¥  "+(monto*5.32).ToString();
        }
        nuevaVentana.Close();
    }

    private void btnAceptar_ClickUSD(object sender, EventArgs e){
        if (MXN.Checked)
        {
            //Etiqueta ConversionMXN
            lblConversionMXN.Text = "MXN - Peso Mexicano";
            lblConversionMXN.AutoSize = true;
            lblConversionMXN.Location = new Point(10,120);

            //TextBox ConversionMXN
            txtConversionMXN.Size = new Size(100,20);
            txtConversionMXN.Location = new Point(250, 120);

            this.Controls.Add(lblConversionMXN);
            this.Controls.Add(txtConversionMXN);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionMXN.Text = "$  "+(monto*21.23).ToString();
        }
        if (CAD.Checked)
        {
            //Etiqueta ConversionCAD
            lblConversionCAD.Text = "CAD - Dolar Canadiense";
            lblConversionCAD.AutoSize = true;
            lblConversionCAD.Location = new Point(10,140);

            //TextBox ConversionCAD
            txtConversionCAD.Size = new Size(100,20);
            txtConversionCAD.Location = new Point(250, 140);

            this.Controls.Add(lblConversionCAD);
            this.Controls.Add(txtConversionCAD);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionCAD.Text = "$  "+(monto*1.28).ToString();
        }
        if (EUR.Checked)
        {
            //Etiqueta ConversionEUR
            lblConversionEUR.Text = "EUR - Euro";
            lblConversionEUR.AutoSize = true;
            lblConversionEUR.Location = new Point(10,160);

            //TextBox ConversionEUR
            txtConversionEUR.Size = new Size(100,20);
            txtConversionEUR.Location = new Point(250, 160);

            this.Controls.Add(lblConversionEUR);
            this.Controls.Add(txtConversionEUR);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionEUR.Text = "€  "+(monto*0.89).ToString();
        }
        if (JPY.Checked)
        {
            //Etiqueta ConversionJPY
            lblConversionJPY.Text = "JPY - Yen Japones";
            lblConversionJPY.AutoSize = true;
            lblConversionJPY.Location = new Point(10,180);

            //TextBox ConversionJPY
            txtConversionJPY.Size = new Size(100,20);
            txtConversionJPY.Location = new Point(250, 180);

            this.Controls.Add(lblConversionJPY);
            this.Controls.Add(txtConversionJPY);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionJPY.Text = "¥  "+(monto*113.05).ToString();
        }
        nuevaVentana.Close();
    }
    private void btnAceptar_ClickCAD(object sender, EventArgs e){
        if (MXN.Checked)
        {
            //Etiqueta ConversionMXN
            lblConversionMXN.Text = "MXN - Peso Mexicano";
            lblConversionMXN.AutoSize = true;
            lblConversionMXN.Location = new Point(10,120);

            //TextBox ConversionMXN
            txtConversionMXN.Size = new Size(100,20);
            txtConversionMXN.Location = new Point(250, 120);

            this.Controls.Add(lblConversionMXN);
            this.Controls.Add(txtConversionMXN);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionMXN.Text = "$  "+(monto*16.55).ToString();

        }
        if (USD.Checked)
        {
            //Etiqueta ConversionUSD
            lblConversionUSD.Text = "USD - Dolar Estadounidense";
            lblConversionUSD.AutoSize = true;
            lblConversionUSD.Location = new Point(10,140);

            //TextBox ConversionUSD
            txtConversionUSD.Size = new Size(100,20);
            txtConversionUSD.Location = new Point(250, 140);

            this.Controls.Add(lblConversionUSD);
            this.Controls.Add(txtConversionUSD);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionUSD.Text = "$  "+(monto*0.78).ToString();
        }
        if (EUR.Checked)
        {
            //Etiqueta ConversionEUR
            lblConversionEUR.Text = "EUR - Euro";
            lblConversionEUR.AutoSize = true;
            lblConversionEUR.Location = new Point(10,160);

            //TextBox ConversionEUR
            txtConversionEUR.Size = new Size(100,20);
            txtConversionEUR.Location = new Point(250, 160);

            this.Controls.Add(lblConversionEUR);
            this.Controls.Add(txtConversionEUR);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionEUR.Text = "€  "+(monto*0.69).ToString();
        }
        if (JPY.Checked)
        {
            //Etiqueta ConversionJPY
            lblConversionJPY.Text = "JPY - Yen Japones";
            lblConversionJPY.AutoSize = true;
            lblConversionJPY.Location = new Point(10,180);

            //TextBox ConversionJPY
            txtConversionJPY.Size = new Size(100,20);
            txtConversionJPY.Location = new Point(250, 180);

            this.Controls.Add(lblConversionJPY);
            this.Controls.Add(txtConversionJPY);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionJPY.Text = "¥  "+(monto*88.12).ToString();
        }
        nuevaVentana.Close();
    }
    private void btnAceptar_ClickEUR(object sender, EventArgs e){
        if (MXN.Checked)
        {
            //Etiqueta ConversionMXN
            lblConversionMXN.Text = "MXN - Peso Mexicano";
            lblConversionMXN.AutoSize = true;
            lblConversionMXN.Location = new Point(10,120);

            //TextBox ConversionMXN
            txtConversionMXN.Size = new Size(100,20);
            txtConversionMXN.Location = new Point(250, 120);

            this.Controls.Add(lblConversionMXN);
            this.Controls.Add(txtConversionMXN);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionMXN.Text = "$  "+(monto*23.96).ToString();

        }
        if (USD.Checked)
        {
            //Etiqueta ConversionUSD
            lblConversionUSD.Text = "USD - Dolar Estadounidense";
            lblConversionUSD.AutoSize = true;
            lblConversionUSD.Location = new Point(10,140);

            //TextBox ConversionUSD
            txtConversionUSD.Size = new Size(100,20);
            txtConversionUSD.Location = new Point(250, 140);

            this.Controls.Add(lblConversionUSD);
            this.Controls.Add(txtConversionUSD);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionUSD.Text = "$  "+(monto*1.13).ToString();
        }
        if (CAD.Checked)
        {
            //Etiqueta ConversionCAD
            lblConversionCAD.Text = "CAD - Dolar Canadiense";
            lblConversionCAD.AutoSize = true;
            lblConversionCAD.Location = new Point(10,160);

            //TextBox ConversionCAD
            txtConversionCAD.Size = new Size(100,20);
            txtConversionCAD.Location = new Point(250, 160);

            this.Controls.Add(lblConversionCAD);
            this.Controls.Add(txtConversionCAD);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionCAD.Text = "$  "+(monto*1.45).ToString();
        }
        if (JPY.Checked)
        {
            //Etiqueta ConversionJPY
            lblConversionJPY.Text = "JPY - Yen Japones";
            lblConversionJPY.AutoSize = true;
            lblConversionJPY.Location = new Point(10,180);

            //TextBox ConversionJPY
            txtConversionJPY.Size = new Size(100,20);
            txtConversionJPY.Location = new Point(250, 180);

            this.Controls.Add(lblConversionJPY);
            this.Controls.Add(txtConversionJPY);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionJPY.Text = "¥  "+(monto*127.56).ToString();
        }
        nuevaVentana.Close();
    }
    private void btnAceptar_ClickJPY(object sender, EventArgs e){
        if (MXN.Checked)
        {
            //Etiqueta ConversionMXN
            lblConversionMXN.Text = "MXN - Peso Mexicano";
            lblConversionMXN.AutoSize = true;
            lblConversionMXN.Location = new Point(10,120);

            //TextBox ConversionMXN
            txtConversionMXN.Size = new Size(100,20);
            txtConversionMXN.Location = new Point(250, 120);

            this.Controls.Add(lblConversionMXN);
            this.Controls.Add(txtConversionMXN);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionMXN.Text = "$  "+(monto*0.1878).ToString();

        }
        if (USD.Checked)
        {
            //Etiqueta ConversionUSD
            lblConversionUSD.Text = "USD - Dolar Estadounidense";
            lblConversionUSD.AutoSize = true;
            lblConversionUSD.Location = new Point(10,140);

            //TextBox ConversionUSD
            txtConversionUSD.Size = new Size(100,20);
            txtConversionUSD.Location = new Point(250, 140);

            this.Controls.Add(lblConversionUSD);
            this.Controls.Add(txtConversionUSD);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionUSD.Text = "$  "+(monto*0.0088).ToString();
        }
        if (CAD.Checked)
        {
            //Etiqueta ConversionCAD
            lblConversionCAD.Text = "CAD - Dolar Canadiense";
            lblConversionCAD.AutoSize = true;
            lblConversionCAD.Location = new Point(10,160);

            //TextBox ConversionCAD
            txtConversionCAD.Size = new Size(100,20);
            txtConversionCAD.Location = new Point(250, 160);

            this.Controls.Add(lblConversionCAD);
            this.Controls.Add(txtConversionCAD);
            
            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionCAD.Text = "$  "+(monto*0.0113).ToString();
        }
        if (EUR.Checked)
        {
            //Etiqueta ConversionEUR
            lblConversionEUR.Text = "EUR - Euro";
            lblConversionEUR.AutoSize = true;
            lblConversionEUR.Location = new Point(10,180);

            //TextBox ConversionEUR
            txtConversionEUR.Size = new Size(100,20);
            txtConversionEUR.Location = new Point(250, 180);

            this.Controls.Add(lblConversionEUR);
            this.Controls.Add(txtConversionEUR);

            double monto = Convert.ToDouble(txtMonto.Text);
            txtConversionEUR.Text = "€  "+(monto*0.0078).ToString();
        }
        nuevaVentana.Close();
    }    
}
