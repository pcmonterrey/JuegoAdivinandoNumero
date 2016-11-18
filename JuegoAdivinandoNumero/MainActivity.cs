using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Views.InputMethods;

namespace JuegoAdivinandoNumero
{
    [Activity(Label = "Juego Adivinando Numero", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            var buttonContinuarTruco1 = (ImageButton)FindViewById<ImageButton>(Resource.Id.buttonContinuarTruco1);
            buttonContinuarTruco1.Click += ButtonContinuarTruco1_Click;
        }

        private void ButtonContinuarTruco1_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(Paso1));
        }
    }

    [Activity(Label = "Paso1")]
    public class Paso1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Paso1);
            var buttonContinuarPaso1 = (Button)FindViewById<Button>(Resource.Id.buttonContinuarPaso1);
            buttonContinuarPaso1.Click += ButtonContinuarPaso1_Click;
        }

        private void ButtonContinuarPaso1_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(Paso2));
        }
    }

    [Activity(Label = "Paso2")]
    public class Paso2 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Paso2);
            var buttonContinuarPaso2 = (Button)FindViewById<Button>(Resource.Id.buttonContinuarPaso2);
            buttonContinuarPaso2.Click += ButtonContinuarPaso2_Click;
        }

        private void ButtonContinuarPaso2_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(Paso3));
        }
    }

    [Activity(Label = "Paso3")]
    public class Paso3 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Paso3);
            var buttonContinuarPaso3 = (Button)FindViewById<Button>(Resource.Id.buttonContinuarPaso3);
            buttonContinuarPaso3.Click += ButtonContinuarPaso3_Click;
        }

        private void ButtonContinuarPaso3_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(Paso4));
        }
    }


    [Activity(Label = "Paso4")]
    public class Paso4 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Paso4);
            var buttonContinuarPaso4 = (Button)FindViewById<Button>(Resource.Id.buttonContinuarPaso4);
            buttonContinuarPaso4.Click += ButtonContinuarPaso4_Click;
        }

        private void ButtonContinuarPaso4_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(Paso5));
        }
    }


    [Activity(Label = "Paso5")]
    public class Paso5 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Paso5);
            var buttonContinuarPaso5 = (Button)FindViewById<Button>(Resource.Id.buttonContinuarPaso5);
            buttonContinuarPaso5.Click += ButtonContinuarPaso5_Click;
        }

        private void ButtonContinuarPaso5_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(Paso6));
        }

    }

    [Activity(Label = "Paso6")]
    public class Paso6 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Paso6);
            var textResultado = (EditText)FindViewById<EditText>(Resource.Id.editText1);
            textResultado.RequestFocus();

            InputMethodManager imm = (InputMethodManager)GetSystemService(Context.InputMethodService);
            imm.ToggleSoftInput(ShowFlags.Forced, HideSoftInputFlags.ImplicitOnly);

            var buttonContinuarPaso6 = (Button)FindViewById<Button>(Resource.Id.buttonContinuarPaso6);
            buttonContinuarPaso6.Click += ButtonContinuarPaso6_Click;
        }

        private void ButtonContinuarPaso6_Click(object sender, System.EventArgs e)
        {
            var textResultado = (EditText)FindViewById<EditText>(Resource.Id.editText1);
            if (textResultado.Text.Trim() != "")
            {
                Intent i = new Intent(this, typeof(Paso7));
                i.PutExtra("cantidad", int.Parse(textResultado.Text));
                StartActivity(i);
            }else
            {
                Toast.MakeText(this, "Olvidaste capturar la cantidad !!", ToastLength.Short).Show();
            }
        }
    }

    [Activity(Label = "Paso7")]
    public class Paso7 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Paso7);
            int cantidad = Intent.GetIntExtra("cantidad", 0) - 4;
            var textResultado = (TextView)FindViewById<TextView>(Resource.Id.textResultado);
            textResultado.Text = cantidad.ToString();

            var buttonContinuarPasoFin = (Button)FindViewById<Button>(Resource.Id.buttonContinuarPasoFin);
            buttonContinuarPasoFin.Click += ButtonContinuarPasoFin_Click;
        }

        private void ButtonContinuarPasoFin_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}

