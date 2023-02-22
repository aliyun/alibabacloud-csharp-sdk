// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class QueryItemDetailWithDivisionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryItemDetailWithDivisionResponseBodyModel Model { get; set; }
        public class QueryItemDetailWithDivisionResponseBodyModel : TeaModel {
            [NameInMap("CanNotBeSoldCode")]
            [Validation(Required=false)]
            public string CanNotBeSoldCode { get; set; }

            [NameInMap("CanNotBeSoldMassage")]
            [Validation(Required=false)]
            public string CanNotBeSoldMassage { get; set; }

            [NameInMap("CanSell")]
            [Validation(Required=false)]
            public bool? CanSell { get; set; }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("CategoryIds")]
            [Validation(Required=false)]
            public List<long?> CategoryIds { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("Current")]
            [Validation(Required=false)]
            public string Current { get; set; }

            [NameInMap("CustomizedAttributeMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CustomizedAttributeMap { get; set; }

            [NameInMap("DescOption")]
            [Validation(Required=false)]
            public string DescOption { get; set; }

            [NameInMap("DescPath")]
            [Validation(Required=false)]
            public string DescPath { get; set; }

            [NameInMap("DistributionMallId")]
            [Validation(Required=false)]
            public string DistributionMallId { get; set; }

            [NameInMap("Features")]
            [Validation(Required=false)]
            public Dictionary<string, string> Features { get; set; }

            [NameInMap("FirstPicUrl")]
            [Validation(Required=false)]
            public string FirstPicUrl { get; set; }

            [NameInMap("HasQuantity")]
            [Validation(Required=false)]
            public bool? HasQuantity { get; set; }

            [NameInMap("IforestProps")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> IforestProps { get; set; }

            [NameInMap("InvoiceType")]
            [Validation(Required=false)]
            public int? InvoiceType { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemImages")]
            [Validation(Required=false)]
            public List<string> ItemImages { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("ItemTotalSimpleValue")]
            [Validation(Required=false)]
            public string ItemTotalSimpleValue { get; set; }

            [NameInMap("ItemTotalValue")]
            [Validation(Required=false)]
            public int? ItemTotalValue { get; set; }

            [NameInMap("LmItemAttributeMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> LmItemAttributeMap { get; set; }

            [NameInMap("LmItemCategory")]
            [Validation(Required=false)]
            public string LmItemCategory { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }

            [NameInMap("MinPrice")]
            [Validation(Required=false)]
            public long? MinPrice { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Properties { get; set; }

            [NameInMap("Prov")]
            [Validation(Required=false)]
            public string Prov { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public long? ReservePrice { get; set; }

            [NameInMap("SecuredTransactions")]
            [Validation(Required=false)]
            public int? SecuredTransactions { get; set; }

            [NameInMap("SellerPayPostfee")]
            [Validation(Required=false)]
            public bool? SellerPayPostfee { get; set; }

            [NameInMap("SimpleQuantity")]
            [Validation(Required=false)]
            public string SimpleQuantity { get; set; }

            /// <summary>
            /// sku list
            /// </summary>
            [NameInMap("SkuModels")]
            [Validation(Required=false)]
            public List<QueryItemDetailWithDivisionResponseBodyModelSkuModels> SkuModels { get; set; }
            public class QueryItemDetailWithDivisionResponseBodyModelSkuModels : TeaModel {
                [NameInMap("CanNotBeSoldCode")]
                [Validation(Required=false)]
                public string CanNotBeSoldCode { get; set; }

                [NameInMap("CanNotBeSoldMassage")]
                [Validation(Required=false)]
                public string CanNotBeSoldMassage { get; set; }

                [NameInMap("CustomizedAttributeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomizedAttributeMap { get; set; }

                [NameInMap("DistributionMallId")]
                [Validation(Required=false)]
                public string DistributionMallId { get; set; }

                [NameInMap("ExtJson")]
                [Validation(Required=false)]
                public string ExtJson { get; set; }

                [NameInMap("HasQuantity")]
                [Validation(Required=false)]
                public bool? HasQuantity { get; set; }

                [NameInMap("InvoiceType")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("LmSkuAttributeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> LmSkuAttributeMap { get; set; }

                [NameInMap("PriceCent")]
                [Validation(Required=false)]
                public long? PriceCent { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                [NameInMap("ReservePrice")]
                [Validation(Required=false)]
                public long? ReservePrice { get; set; }

                [NameInMap("SimpleQuantity")]
                [Validation(Required=false)]
                public string SimpleQuantity { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public long? SkuId { get; set; }

                [NameInMap("SkuPicUrl")]
                [Validation(Required=false)]
                public string SkuPicUrl { get; set; }

                [NameInMap("SkuPvs")]
                [Validation(Required=false)]
                public string SkuPvs { get; set; }

                [NameInMap("SkuTitle")]
                [Validation(Required=false)]
                public string SkuTitle { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SupplierPrice")]
                [Validation(Required=false)]
                public long? SupplierPrice { get; set; }

            }

            [NameInMap("SkuPropertys")]
            [Validation(Required=false)]
            public List<QueryItemDetailWithDivisionResponseBodyModelSkuPropertys> SkuPropertys { get; set; }
            public class QueryItemDetailWithDivisionResponseBodyModelSkuPropertys : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<QueryItemDetailWithDivisionResponseBodyModelSkuPropertysValues> Values { get; set; }
                public class QueryItemDetailWithDivisionResponseBodyModelSkuPropertysValues : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

            }

            [NameInMap("ThirdPartyItemId")]
            [Validation(Required=false)]
            public string ThirdPartyItemId { get; set; }

            [NameInMap("ThirdPartyName")]
            [Validation(Required=false)]
            public string ThirdPartyName { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

            [NameInMap("VideoPicUrl")]
            [Validation(Required=false)]
            public string VideoPicUrl { get; set; }

            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

            [NameInMap("VirtualItemType")]
            [Validation(Required=false)]
            public string VirtualItemType { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
