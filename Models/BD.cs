using System.Data.SqlClient;
using Dapper;

public class BD{

    private static string _connectionString = @"Server=localhost; DataBase=GestionAlumnos;Trusted_Connection=True;";

    public static List<Alumnos> GetListadoAlumnos(){

        List<Alumnos> ListadoAlumnos = new List<Alumnos>();
        string sql = "SELECT * FROM Alumnos;";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            
            ListadoAlumnos = db.Query<Alumnos>(sql).ToList();
        }
        return ListadoAlumnos;
    }

    public static List<Alumnos> GetDetalleAlumno (string legajo){
        List<Alumnos> DetalleAlumno = null;
        string sql = "SELECT * FROM Alumnos WHERE Legajo = @legajo;";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            
            DetalleAlumno = db.Query<Alumnos>(sql, new {legajo}).ToList();
        }
        return DetalleAlumno;
    }


    public static List<Notas> GetNotasAlumno (int idalumno){
        List<Notas> NotasAlumno = null;
        string sql = "SELECT * FROM Notas WHERE idAlumno = @pidAlumno;";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            
            NotasAlumno = db.Query<Notas>(sql, new {pidAlumno=idalumno}).ToList();
        }
        return NotasAlumno;
    }

    public static List<Alumnos> GetPromedioMayor (string legajo){

        List<Alumnos> PromedioMayor = new List<Alumnos>();
        string sql = "SELECT * FROM Alumnos where Promedio >= 6;";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            
            PromedioMayor = db.Query<Alumnos>(sql).ToList();
        }
        return PromedioMayor;



    }

    public static List<Alumnos> GetPromedioMenor (string legajo){

        List<Alumnos> PromedioMenor = new List<Alumnos>();
        string sql = "SELECT * FROM Alumnos where Promedio < 6;";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            
            PromedioMenor = db.Query<Alumnos>(sql).ToList();
        }
        return PromedioMenor;
    }

}

