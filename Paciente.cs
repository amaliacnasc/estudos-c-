using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pacientes
{
    public class Paciente
    {

        private string _nomePacientes;    
    public string NomePacientes { get{
          return _nomePacientes.ToUpper();
    }
      
    set  {
        if (_nomePacientes==""){
                    throw new ArgumentException("Nome do paciente não pode ser vazio");
        }  _nomePacientes = value; 
    } }

     private   int _idade;
    public int Idade{ get{

                return _idade; 

    } set{
        if(_idade == null || _idade <0){
                    throw new ArgumentException("Idade não pode ser vazio ou menor que zero"); 
        } _idade = value; 
    } }
    private string _email;
    public string Email { get{
                return _email;
    } set{
        if (_email==""){
                    throw new ArgumentException("O campo do email não pode ser vazio"); 
        }_email = value; 
    } }
    }

}