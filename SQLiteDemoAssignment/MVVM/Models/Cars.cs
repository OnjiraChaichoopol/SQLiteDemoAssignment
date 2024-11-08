using System;
using SQLite;

namespace SQLiteDemoAssignment.MVVM.Models;

public class Cars
{
    [PrimaryKey , AutoIncrement]
    public int ID { get; set; }
    [Column("Brand")]    
    public string Model { get; set; }
    [Column("Color")]  
    public string Color { get; set; }
}
