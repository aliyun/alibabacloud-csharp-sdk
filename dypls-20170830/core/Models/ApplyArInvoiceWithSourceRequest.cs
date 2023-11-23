/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class ApplyArInvoiceWithSourceRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public ApplyArInvoiceWithSourceRequestAddress Address { get; set; }
        public class ApplyArInvoiceWithSourceRequestAddress : TeaModel {
            [NameInMap("AddressId")]
            [Validation(Required=false)]
            public string AddressId { get; set; }

            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Customer")]
            [Validation(Required=false)]
            public ApplyArInvoiceWithSourceRequestAddressCustomer Customer { get; set; }
            public class ApplyArInvoiceWithSourceRequestAddressCustomer : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("CustomerSite")]
                [Validation(Required=false)]
                public string CustomerSite { get; set; }

                [NameInMap("CustomerSystem")]
                [Validation(Required=false)]
                public string CustomerSystem { get; set; }

                [NameInMap("EncryptProps")]
                [Validation(Required=false)]
                public Dictionary<string, string> EncryptProps { get; set; }

                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("Sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("DetailedAddress")]
            [Validation(Required=false)]
            public string DetailedAddress { get; set; }

            [NameInMap("District")]
            [Validation(Required=false)]
            public string District { get; set; }

            [NameInMap("EncryptProps")]
            [Validation(Required=false)]
            public Dictionary<string, string> EncryptProps { get; set; }

            [NameInMap("FixedNumber")]
            [Validation(Required=false)]
            public string FixedNumber { get; set; }

            [NameInMap("FullAddress")]
            [Validation(Required=false)]
            public string FullAddress { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("IsEffective")]
            [Validation(Required=false)]
            public bool? IsEffective { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("MobileNumber")]
            [Validation(Required=false)]
            public string MobileNumber { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("RecipientName")]
            [Validation(Required=false)]
            public string RecipientName { get; set; }

            [NameInMap("RelatedId")]
            [Validation(Required=false)]
            public string RelatedId { get; set; }

            [NameInMap("RelatedSystem")]
            [Validation(Required=false)]
            public string RelatedSystem { get; set; }

            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

            [NameInMap("Street")]
            [Validation(Required=false)]
            public string Street { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("ZipCode")]
            [Validation(Required=false)]
            public string ZipCode { get; set; }

        }

        [NameInMap("Amount")]
        [Validation(Required=false)]
        public double? Amount { get; set; }

        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("Applier")]
        [Validation(Required=false)]
        public string Applier { get; set; }

        [NameInMap("ApplyDate")]
        [Validation(Required=false)]
        public string ApplyDate { get; set; }

        [NameInMap("CurrencyCode")]
        [Validation(Required=false)]
        public string CurrencyCode { get; set; }

        [NameInMap("Customer")]
        [Validation(Required=false)]
        public ApplyArInvoiceWithSourceRequestCustomer Customer { get; set; }
        public class ApplyArInvoiceWithSourceRequestCustomer : TeaModel {
            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            [NameInMap("CustomerSite")]
            [Validation(Required=false)]
            public string CustomerSite { get; set; }

            [NameInMap("CustomerSystem")]
            [Validation(Required=false)]
            public string CustomerSystem { get; set; }

            [NameInMap("EncryptProps")]
            [Validation(Required=false)]
            public Dictionary<string, string> EncryptProps { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("EncryptProps")]
        [Validation(Required=false)]
        public Dictionary<string, string> EncryptProps { get; set; }

        [NameInMap("ExcludingTaxAmount")]
        [Validation(Required=false)]
        public double? ExcludingTaxAmount { get; set; }

        [NameInMap("InputType")]
        [Validation(Required=false)]
        public string InputType { get; set; }

        [NameInMap("InvoiceType")]
        [Validation(Required=false)]
        public string InvoiceType { get; set; }

        [NameInMap("IsMerged")]
        [Validation(Required=false)]
        public bool? IsMerged { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public string MaterialType { get; set; }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("OuCode")]
        [Validation(Required=false)]
        public string OuCode { get; set; }

        [NameInMap("PurchaserBankInfo")]
        [Validation(Required=false)]
        public string PurchaserBankInfo { get; set; }

        [NameInMap("PurchaserContactInfo")]
        [Validation(Required=false)]
        public string PurchaserContactInfo { get; set; }

        [NameInMap("PurchaserName")]
        [Validation(Required=false)]
        public string PurchaserName { get; set; }

        [NameInMap("PurchaserTaxNo")]
        [Validation(Required=false)]
        public string PurchaserTaxNo { get; set; }

        [NameInMap("RequestNo")]
        [Validation(Required=false)]
        public string RequestNo { get; set; }

        [NameInMap("Sign")]
        [Validation(Required=false)]
        public string Sign { get; set; }

        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        [NameInMap("SourceList")]
        [Validation(Required=false)]
        public List<ApplyArInvoiceWithSourceRequestSourceList> SourceList { get; set; }
        public class ApplyArInvoiceWithSourceRequestSourceList : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public double? Amount { get; set; }

            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("BillAmount")]
            [Validation(Required=false)]
            public double? BillAmount { get; set; }

            [NameInMap("BillDomain")]
            [Validation(Required=false)]
            public string BillDomain { get; set; }

            [NameInMap("BillNo")]
            [Validation(Required=false)]
            public string BillNo { get; set; }

            [NameInMap("BillType")]
            [Validation(Required=false)]
            public string BillType { get; set; }

            [NameInMap("BlueSourceId")]
            [Validation(Required=false)]
            public long? BlueSourceId { get; set; }

            [NameInMap("CanMerge")]
            [Validation(Required=false)]
            public bool? CanMerge { get; set; }

            [NameInMap("CargoName")]
            [Validation(Required=false)]
            public string CargoName { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            [NameInMap("CurrencyCode")]
            [Validation(Required=false)]
            public string CurrencyCode { get; set; }

            [NameInMap("Customer")]
            [Validation(Required=false)]
            public ApplyArInvoiceWithSourceRequestSourceListCustomer Customer { get; set; }
            public class ApplyArInvoiceWithSourceRequestSourceListCustomer : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("CustomerSite")]
                [Validation(Required=false)]
                public string CustomerSite { get; set; }

                [NameInMap("CustomerSystem")]
                [Validation(Required=false)]
                public string CustomerSystem { get; set; }

                [NameInMap("EncryptProps")]
                [Validation(Required=false)]
                public Dictionary<string, string> EncryptProps { get; set; }

                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("Sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public double? DiscountAmount { get; set; }

            [NameInMap("DiscountTaxAmount")]
            [Validation(Required=false)]
            public double? DiscountTaxAmount { get; set; }

            [NameInMap("EncryptProps")]
            [Validation(Required=false)]
            public Dictionary<string, string> EncryptProps { get; set; }

            [NameInMap("ExcludingTaxAmount")]
            [Validation(Required=false)]
            public double? ExcludingTaxAmount { get; set; }

            [NameInMap("ExcludingTaxDiscountAmount")]
            [Validation(Required=false)]
            public double? ExcludingTaxDiscountAmount { get; set; }

            [NameInMap("ExcludingTaxRedAmount")]
            [Validation(Required=false)]
            public double? ExcludingTaxRedAmount { get; set; }

            [NameInMap("ExcludingTaxRemainAmount")]
            [Validation(Required=false)]
            public double? ExcludingTaxRemainAmount { get; set; }

            [NameInMap("GmtBill")]
            [Validation(Required=false)]
            public string GmtBill { get; set; }

            [NameInMap("GmtBillEnd")]
            [Validation(Required=false)]
            public string GmtBillEnd { get; set; }

            [NameInMap("GmtBillStart")]
            [Validation(Required=false)]
            public string GmtBillStart { get; set; }

            [NameInMap("GmtBuild")]
            [Validation(Required=false)]
            public string GmtBuild { get; set; }

            [NameInMap("IsApply")]
            [Validation(Required=false)]
            public string IsApply { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("MajorBillNo")]
            [Validation(Required=false)]
            public string MajorBillNo { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("OuCode")]
            [Validation(Required=false)]
            public string OuCode { get; set; }

            [NameInMap("ParentCategory")]
            [Validation(Required=false)]
            public string ParentCategory { get; set; }

            [NameInMap("ProductDomain")]
            [Validation(Required=false)]
            public string ProductDomain { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public double? Quantity { get; set; }

            [NameInMap("QuantityUnit")]
            [Validation(Required=false)]
            public string QuantityUnit { get; set; }

            [NameInMap("RedAmount")]
            [Validation(Required=false)]
            public double? RedAmount { get; set; }

            [NameInMap("RelatedId")]
            [Validation(Required=false)]
            public string RelatedId { get; set; }

            [NameInMap("RemainAmount")]
            [Validation(Required=false)]
            public double? RemainAmount { get; set; }

            [NameInMap("RevenueType")]
            [Validation(Required=false)]
            public string RevenueType { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public string SiteId { get; set; }

            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            [NameInMap("TaxAmount")]
            [Validation(Required=false)]
            public double? TaxAmount { get; set; }

            [NameInMap("TaxRate")]
            [Validation(Required=false)]
            public double? TaxRate { get; set; }

            [NameInMap("UnitPrice")]
            [Validation(Required=false)]
            public double? UnitPrice { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("TaxAmount")]
        [Validation(Required=false)]
        public double? TaxAmount { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
