using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace FruitCo.Foundation.EnterpriseStructure
{
  public struct Templates
  {
    public static class Enterprise
    {
      public static readonly ID TemplateId = new ID("{057AADFF-0FC8-4C75-A254-6A242C9B941A}");
      public static class Fields
      {
        public static readonly ID Name = new ID("{A17A769D-E745-46DB-9726-85BED62C5535}");
        public static readonly ID Logo = new ID("{74C071CF-C693-4375-8233-E0CBA5346719}");
      }
    }
    public static class SiteRoot
    {
      public static readonly ID TemplateId = new ID("{27AA05FB-81C0-4861-B390-ED190C6A1CE9}");
      public static class Fields
      {
        public static readonly ID Title = new ID("{9712C486-565C-4639-AE95-59DF69E3F684}");
        public static readonly ID Entreprise = new ID("{76169346-E13A-4589-99C4-BAFD198A7C18}");
      }
    }
  }
}