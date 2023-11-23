// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class QueryInvoiceInfoByRequestNoResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public QueryInvoiceInfoByRequestNoResponseBodyReturnValue ReturnValue { get; set; }
        public class QueryInvoiceInfoByRequestNoResponseBodyReturnValue : TeaModel {
            [NameInMap("EncryptProps")]
            [Validation(Required=false)]
            public Dictionary<string, string> EncryptProps { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryInvoiceInfoByRequestNoResponseBodyReturnValueList> List { get; set; }
            public class QueryInvoiceInfoByRequestNoResponseBodyReturnValueList : TeaModel {
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("CurrencyCode")]
                [Validation(Required=false)]
                public string CurrencyCode { get; set; }

                [NameInMap("Customer")]
                [Validation(Required=false)]
                public QueryInvoiceInfoByRequestNoResponseBodyReturnValueListCustomer Customer { get; set; }
                public class QueryInvoiceInfoByRequestNoResponseBodyReturnValueListCustomer : TeaModel {
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

                [NameInMap("DetailList")]
                [Validation(Required=false)]
                public List<QueryInvoiceInfoByRequestNoResponseBodyReturnValueListDetailList> DetailList { get; set; }
                public class QueryInvoiceInfoByRequestNoResponseBodyReturnValueListDetailList : TeaModel {
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public double? Amount { get; set; }

                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    [NameInMap("CargoName")]
                    [Validation(Required=false)]
                    public string CargoName { get; set; }

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

                    [NameInMap("ExcludingTaxUnitPrice")]
                    [Validation(Required=false)]
                    public double? ExcludingTaxUnitPrice { get; set; }

                    [NameInMap("InvoiceDetailId")]
                    [Validation(Required=false)]
                    public long? InvoiceDetailId { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

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

                    [NameInMap("Sign")]
                    [Validation(Required=false)]
                    public string Sign { get; set; }

                    [NameInMap("SourceList")]
                    [Validation(Required=false)]
                    public List<QueryInvoiceInfoByRequestNoResponseBodyReturnValueListDetailListSourceList> SourceList { get; set; }
                    public class QueryInvoiceInfoByRequestNoResponseBodyReturnValueListDetailListSourceList : TeaModel {
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
                        public QueryInvoiceInfoByRequestNoResponseBodyReturnValueListDetailListSourceListCustomer Customer { get; set; }
                        public class QueryInvoiceInfoByRequestNoResponseBodyReturnValueListDetailListSourceListCustomer : TeaModel {
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

                [NameInMap("EncryptProps")]
                [Validation(Required=false)]
                public Dictionary<string, string> EncryptProps { get; set; }

                [NameInMap("ExcludingTaxAmount")]
                [Validation(Required=false)]
                public double? ExcludingTaxAmount { get; set; }

                [NameInMap("ExcludingTaxRedAmount")]
                [Validation(Required=false)]
                public double? ExcludingTaxRedAmount { get; set; }

                [NameInMap("ExcludingTaxRemainAmount")]
                [Validation(Required=false)]
                public double? ExcludingTaxRemainAmount { get; set; }

                [NameInMap("InvoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                [NameInMap("InvoiceDate")]
                [Validation(Required=false)]
                public string InvoiceDate { get; set; }

                [NameInMap("InvoiceId")]
                [Validation(Required=false)]
                public long? InvoiceId { get; set; }

                [NameInMap("InvoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                [NameInMap("InvoiceStatus")]
                [Validation(Required=false)]
                public string InvoiceStatus { get; set; }

                [NameInMap("InvoiceType")]
                [Validation(Required=false)]
                public string InvoiceType { get; set; }

                [NameInMap("IsRed")]
                [Validation(Required=false)]
                public bool? IsRed { get; set; }

                [NameInMap("IsReissue")]
                [Validation(Required=false)]
                public bool? IsReissue { get; set; }

                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("LinkInvoiceCode")]
                [Validation(Required=false)]
                public string LinkInvoiceCode { get; set; }

                [NameInMap("LinkInvoiceNo")]
                [Validation(Required=false)]
                public string LinkInvoiceNo { get; set; }

                [NameInMap("LogisticsInfo")]
                [Validation(Required=false)]
                public QueryInvoiceInfoByRequestNoResponseBodyReturnValueListLogisticsInfo LogisticsInfo { get; set; }
                public class QueryInvoiceInfoByRequestNoResponseBodyReturnValueListLogisticsInfo : TeaModel {
                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    [NameInMap("Customer")]
                    [Validation(Required=false)]
                    public QueryInvoiceInfoByRequestNoResponseBodyReturnValueListLogisticsInfoCustomer Customer { get; set; }
                    public class QueryInvoiceInfoByRequestNoResponseBodyReturnValueListLogisticsInfoCustomer : TeaModel {
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

                    [NameInMap("GmtSend")]
                    [Validation(Required=false)]
                    public string GmtSend { get; set; }

                    [NameInMap("InvoiceCode")]
                    [Validation(Required=false)]
                    public string InvoiceCode { get; set; }

                    [NameInMap("InvoiceDate")]
                    [Validation(Required=false)]
                    public string InvoiceDate { get; set; }

                    [NameInMap("InvoiceId")]
                    [Validation(Required=false)]
                    public long? InvoiceId { get; set; }

                    [NameInMap("InvoiceNo")]
                    [Validation(Required=false)]
                    public string InvoiceNo { get; set; }

                    [NameInMap("InvoiceNos")]
                    [Validation(Required=false)]
                    public string InvoiceNos { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("LogisticsCompanies")]
                    [Validation(Required=false)]
                    public string LogisticsCompanies { get; set; }

                    [NameInMap("RelatedId")]
                    [Validation(Required=false)]
                    public string RelatedId { get; set; }

                    [NameInMap("Sender")]
                    [Validation(Required=false)]
                    public string Sender { get; set; }

                    [NameInMap("Sign")]
                    [Validation(Required=false)]
                    public string Sign { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("TrackingNumber")]
                    [Validation(Required=false)]
                    public string TrackingNumber { get; set; }

                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                }

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

                [NameInMap("RedAmount")]
                [Validation(Required=false)]
                public double? RedAmount { get; set; }

                [NameInMap("RelatedId")]
                [Validation(Required=false)]
                public string RelatedId { get; set; }

                [NameInMap("RemainAmount")]
                [Validation(Required=false)]
                public double? RemainAmount { get; set; }

                [NameInMap("Sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

                [NameInMap("SiteId")]
                [Validation(Required=false)]
                public string SiteId { get; set; }

                [NameInMap("TaxAmount")]
                [Validation(Required=false)]
                public double? TaxAmount { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

        }

    }

}
