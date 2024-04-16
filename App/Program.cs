bool runner = true;

while(runner == true){

    Console.WriteLine("BIENVENIDO A LA CALCULADORA DE EDAD");
    Console.WriteLine("Ingrese su edad"); 

    int edad = int.Parse(Console.ReadLine());

    if( edad >= 0 && edad <= 3){
        Console.WriteLine("Recien nacido");
    }else if ( edad >= 4 && edad <= 9){
        Console.WriteLine("Infante");
    }else if ( edad >= 10 && edad <= 12 ){
        Console.WriteLine("Puberto");
    }else if ( edad >= 13 && edad <= 19){
        Console.WriteLine("Adolecente"); 
    }else if ( edad >= 20 && edad <= 29){
        Console.WriteLine("joven"); 
    }else if ( edad >= 30 && edad <= 49){
        Console.WriteLine("Adulto"); 
    }else if ( edad >= 50 && edad <= 59){
        Console.WriteLine("Adulto mayor"); 
    }else if ( edad >= 60){
        Console.WriteLine("Anciano") ;
    }

    bool runner_2 = true;

    while(runner_2 == true){
        Console.WriteLine("Desea continuar usando la calculadora? 1.- Si.   2.- No");
        int answer = int.Parse(Console.ReadLine());

        if(answer == 1){
            runner_2 = false;

        }else if ( answer == 2 ){
            runner_2 = false;
            runner = false;
            Console.WriteLine("Gracias por usar la calculadora de edad!");  

        }else{
            Console.WriteLine("Ingreso valores fuera del rango especificado!.");
        }
    }   
}

