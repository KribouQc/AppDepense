using System;
using SQLite;

namespace GestionDepense.Models;

public class Transaction
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Type { get; set; }
    public string Titre { get; set; }
    public float Somme { get; set; }
    public DateTime DateTimeTransaction { get; set; }
    public DateTime DateModificationM { get; set; }
}

