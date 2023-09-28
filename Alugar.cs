using System;

class Alugar
{
  public string Name { get; set;}
  public string Email {get; set;}

  public Alugar(string nome, string email) {
    Name = nome;
    Email = email;
}
  public override string ToString() {
  return Name + ", " + Email;
  }
}