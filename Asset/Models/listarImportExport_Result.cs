//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asset.Models
{
    using System;
    
    public partial class listarImportExport_Result
    {
        public int idDeclarationDetails { get; set; }
        public Nullable<int> Idpurchasing { get; set; }
        public Nullable<int> IdUOM { get; set; }
        public string AssetQuantityCustom { get; set; }
        public string GoodsDeclarationNumber { get; set; }
        public Nullable<System.DateTime> GoodsDeclarationSelectivityDate { get; set; }
        public string GoodsDeclarationReference { get; set; }
        public string TariffItemNumberHTS { get; set; }
        public string SupplierNameImportExport { get; set; }
        public Nullable<decimal> GoodsDeclarationAmount { get; set; }
    }
}
