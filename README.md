# -ORGA-Proyecto_2S2019G3
Proyecto de la clase de Organizacion computacional, grupo 3

Fue realizado con una libreria impout32, Se compró un puerto paralelo al cual se le conectaron cables a la salida para simular
el puerto serial, el puerto pararlelo nos facilitó el envio y recepción de datos,  debido a que este no utiliza el +232 para poder 
regular la caida de voltaje de la computadora para los demas circutos, este se debe probar previamente para que a la hora de pasar a la 
programación se descarten posibles fallas del cable.
Se prueban los pines 15 y 16 que son los puertos de control, se verifica que funcionen bien.

Para la programación, es recomendable que para evitar fallos se utilice sistema windows xp de 32 bits.
Se debe instalar Visual Studio 2010 especificamente la parte de C# para 32 bits o una que corresponda a el Sistema operativo
Se buscó simular un puerto serial utilizando un puerto paralelo, aprovechancho unicamente 2 pines 15 y 16 los cuales 
serviran para tx y rx (envio y recepcion de datos mediante cadnas de bit respectivamente) y el pin de tierra.
Se crea una clase la cual va tener el control de envio y recpion de datos y utilizando la libreria impout32.dll la cual envia al 
pin tx los datos en este caso las coordenadas del dibujo realziado desde la aplicacion y se indica a que puerto al que es recibido.
Se realiza un mapeo lexicografico que convierte la matriz en una sola cadena de bits que se envian a traves del puerto tx. En ese mapeo 
se analiza coordenada por coordenada hporizontamentle y se verifica si la casilla esta activa o inactiva, si esta activa manda 1 que indica 
que se debe imprimir, si manda un 0 ignora la casillaque se interpreta como un espacio en blanco. Cuando llega al final de la linea regresa 
al punto inicial y baja a la siguiente linea de coordenadas y se repite el proceso hasta que llegue al finfal de la matriz. Estos pulsos son
enviados desde el pin tx hacia el modulo de registros en donde se encuentro un contador interno de pulsos, estos al llegar a 7 cambian el 
modo de escritura o lectura de registro a su vez cuando liberan los bits se limpian los registros para que entre una nueva cadena de coordenadas
Los contadores cuentan pulsos del reloj estos cuando llegan a su maximo que es 7 y hacen un comparacion (si el numero es 7 cambia de estado) 
 
