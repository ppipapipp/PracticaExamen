using System.Data.SqlClient;
using Dapper;

public class BD{

    private static string _connectionString = @"Server=localhost; DataBase=GestionAlumnos;Trusted_Connection=True;";

    public static List<Alumnos> GetListadoAlumnos(){

        List<Alumnos> ListadoAlumnos = new List<Alumnos>();
        string sql = "SELECT Nombre, Apellido, Legajo, Curso FROM Alumnos;";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            
            ListadoAlumnos = db.Query<Alumnos>(sql).ToList();
        }
        return ListadoAlumnos;
    }

    public static List<Alumnos> GetDetalleAlumno (string legajo){
        List<Alumnos> DetalleAlumno = null;
        string sql = "SELECT Nombre, Apellido, Legajo, Curso FROM Alumnos WHERE Legajo = @legajo;";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            
            DetalleAlumno = db.Query<Alumnos>(sql, new {legajo}).ToList();
        }
        return DetalleAlumno;
    }

        public static List<Notas> GetNotasAlumno (string legajo){
        List<Notas> NotasAlumno = null;
        string sql = "SELECT Nota FROM Notas inner join Alumnos on Alumnos.idAlumno = Notas.idAlumno WHERE Legajo = @legajo;";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            
            NotasAlumno = db.Query<Notas>(sql, new {legajo}).ToList();
        }
        return NotasAlumno;
    }


}

