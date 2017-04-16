# Ejemplo para la introducción de Xamarin con Android.

Aplicación con un botón, un variable que se usa como contador y una etiqueta que se pinta el resultado del contador.

Cada vez que se pulsa sobre el botón se actualiza el valor de la etiqueta (TextView).

VISTA MAIN del fichero AXML

Creamos un TextView para mostrar el resultado. 
*Importante el atributo Id(android:id="@+id/labelResultado"), vamos a recoger este valor para trabajar sobre este control.
 <TextView
        android:text="0"
        android:layout_width="match_parent"
        android:textSize="32dp"
        android:gravity="center"
        android:textColor="#80ff0000"
        android:layout_height="wrap_content"
        android:id="@+id/labelResultado"
        android:layout_marginBottom="49.0dp"
        android:layout_marginTop="43.5dp" />
		
Creamos un botón y tambien asociamos con un Id		
    <Button
        android:text="Sumar"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:id="@+id/botonContar" />
		

FICHERO MainActivity

    public class MainActivity : Activity
    {
		//Definimos una variable
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
		

Cualquiera duda contacta por twitter: @elbrinner

