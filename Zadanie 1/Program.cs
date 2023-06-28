using System;
using System.Security.Cryptography.X509Certificates;
using static TransformDate;
public class Person {
    private string fullName;
    public string FullName
    {
        get { return fullName; }
        set {
            if (string.IsNullOrEmpty(value)){
                throw new ArgumentException("Nazwisko nie może być puste.");
            }

            fullName = value;
            updateNameFullName(value);
        }
    }
    public Person(string fullName){
        FullName = nameUP(fullName);
    }
    private string? name;
    private string? fullname;
    public string Name {
        get => name;
        set {
            if (string.IsNullOrEmpty(value)){
                throw new ArgumentException("Imię nie może być puste.");
            }
            name = value;
        }
    }
    public string Fullname {
        get => fullname;
        set { fullname = value; }
    }
    public DateTime? DateOfBorn { get; set; }
    public DateTime? DateOfDead { get; set; }
    public TimeSpan? Age {
        get {
            if (DateOfBorn == null){
                return null;
            }
            DateTime death_Alive = DateOfDead ?? DateTime.Now.Date;
            return death_Alive - DateOfBorn.Value;
        }
    }
    private void updateNameFullName(string value){
        if (string.IsNullOrEmpty(value)){
            name = null;
            fullname = null;
        }
        else
        {
            string[] split = value.Split(' ');
            if (split.Length == 1){
                name = split[0];
                fullname = string.Empty;
            }
            else if (split.Length > 1){
                name = split[0];
                fullname = split[split.Length - 1];
            }
        }

    }
    public override string ToString(){
        return $"Imię i Nazwisko: {FullName}\n" +
               $"Imię: {Name}\n" +
               $"Nazwisko: {Fullname}\n" +
               $"Data urodzenia: {DateOfBorn?.ToShortDateString()}\n" +
               $"Data śmierci: {DateOfDead?.ToShortDateString()}\n" +
               $"Wiek: {((short?)(Age?.TotalDays/365))} lat\n";
    }
}
