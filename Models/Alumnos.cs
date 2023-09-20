public class Alumnos{
    public int IdAlumno {get; set;}
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public string Legajo {get; set;}
    public string Curso {get; set;}


    public Alumnos(){
    
    }

    public Alumnos(int idalumno, string nombre, string apellido, string legajo, string curso ){
        IdAlumno=idalumno;
        Nombre=nombre;
        Apellido=apellido;
        Legajo=legajo;
        Curso=curso;
    }

}