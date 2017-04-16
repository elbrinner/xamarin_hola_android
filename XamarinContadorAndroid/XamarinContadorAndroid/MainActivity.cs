using Android.App;
using Android.Widget;
using Android.OS;

namespace XamarinContadorAndroid
{
    [Activity(Label = "Hola mundo Droid Xamarin", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int contador = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Establecer la vista  "Main" localizada en resource/layout
            SetContentView(Resource.Layout.Main);

            //Buscamos um botón que contega el id "botonContar" en el fichero Main.
            Button botonSumar = FindViewById<Button>(Resource.Id.botonContar);

            //Buscamos un textView que contega el id "labelResultado" en el fichero Main.
            TextView componenteView = FindViewById<TextView>(Resource.Id.labelResultado);

            //Asignamos un evento al botón 
            // LLamamos una función y asignamos su valor al TextView
            botonSumar.Click += delegate { componenteView.Text = this.Sumar();  };
        }

        /// <summary>
        /// Suma uno y retorna el resultado como una string. Ya que no podemos retorna directamente un int a un ViewText.Text
        /// </summary>
        /// <returns>String con el resultado de la suma</returns>
        private string Sumar()
        {
            contador++;
            return string.Format("{0}", contador);
        }
    }
}

