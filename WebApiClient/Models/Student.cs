using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiClient.Models
{
  public class Student
  {
    public Guid StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
  }
}