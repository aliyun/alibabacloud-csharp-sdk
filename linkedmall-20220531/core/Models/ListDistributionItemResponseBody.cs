// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class ListDistributionItemResponseBody : TeaModel {
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
        public List<ListDistributionItemResponseBodyModel> Model { get; set; }
        public class ListDistributionItemResponseBodyModel : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CategoryChain")]
            [Validation(Required=false)]
            public List<ListDistributionItemResponseBodyModelCategoryChain> CategoryChain { get; set; }
            public class ListDistributionItemResponseBodyModelCategoryChain : TeaModel {
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                [NameInMap("Leaf")]
                [Validation(Required=false)]
                public bool? Leaf { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("DescOption")]
            [Validation(Required=false)]
            public string DescOption { get; set; }

            [NameInMap("DistributionMallId")]
            [Validation(Required=false)]
            public string DistributionMallId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("HasQuantity")]
            [Validation(Required=false)]
            public bool? HasQuantity { get; set; }

            [NameInMap("IsCanSell")]
            [Validation(Required=false)]
            public bool? IsCanSell { get; set; }

            [NameInMap("ItemDesc")]
            [Validation(Required=false)]
            public string ItemDesc { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemIdStr")]
            [Validation(Required=false)]
            public string ItemIdStr { get; set; }

            [NameInMap("ItemImages")]
            [Validation(Required=false)]
            public List<string> ItemImages { get; set; }

            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("LmAttributeMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> LmAttributeMap { get; set; }

            [NameInMap("LmAttributeModels")]
            [Validation(Required=false)]
            public List<ListDistributionItemResponseBodyModelLmAttributeModels> LmAttributeModels { get; set; }
            public class ListDistributionItemResponseBodyModelLmAttributeModels : TeaModel {
                [NameInMap("AttrId")]
                [Validation(Required=false)]
                public long? AttrId { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public int? Category { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Restriction")]
                [Validation(Required=false)]
                public string Restriction { get; set; }

                [NameInMap("ScopeList")]
                [Validation(Required=false)]
                public List<string> ScopeList { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }

            [NameInMap("PicUrl")]
            [Validation(Required=false)]
            public string PicUrl { get; set; }

            [NameInMap("PriceCentScope")]
            [Validation(Required=false)]
            public string PriceCentScope { get; set; }

            [NameInMap("PropertiesJson")]
            [Validation(Required=false)]
            public string PropertiesJson { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            [NameInMap("ReservedPrice")]
            [Validation(Required=false)]
            public long? ReservedPrice { get; set; }

            [NameInMap("ReservedPriceScope")]
            [Validation(Required=false)]
            public string ReservedPriceScope { get; set; }

            [NameInMap("SimpleQuantity")]
            [Validation(Required=false)]
            public string SimpleQuantity { get; set; }

            [NameInMap("SimpleTotalSoldQuantity")]
            [Validation(Required=false)]
            public string SimpleTotalSoldQuantity { get; set; }

            [NameInMap("SkuList")]
            [Validation(Required=false)]
            public List<ListDistributionItemResponseBodyModelSkuList> SkuList { get; set; }
            public class ListDistributionItemResponseBodyModelSkuList : TeaModel {
                [NameInMap("CanSell")]
                [Validation(Required=false)]
                public bool? CanSell { get; set; }

                [NameInMap("CustomizedAttributeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomizedAttributeMap { get; set; }

                [NameInMap("ExtInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("HasQuantity")]
                [Validation(Required=false)]
                public bool? HasQuantity { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmAttributeModels")]
                [Validation(Required=false)]
                public List<ListDistributionItemResponseBodyModelSkuListLmAttributeModels> LmAttributeModels { get; set; }
                public class ListDistributionItemResponseBodyModelSkuListLmAttributeModels : TeaModel {
                    [NameInMap("AttrId")]
                    [Validation(Required=false)]
                    public long? AttrId { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public int? Category { get; set; }

                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Restriction")]
                    [Validation(Required=false)]
                    public string Restriction { get; set; }

                    [NameInMap("ScopeList")]
                    [Validation(Required=false)]
                    public List<string> ScopeList { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("PriceCent")]
                [Validation(Required=false)]
                public long? PriceCent { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public long? Quantity { get; set; }

                [NameInMap("ReservedPrice")]
                [Validation(Required=false)]
                public long? ReservedPrice { get; set; }

                [NameInMap("SimpleQuantity")]
                [Validation(Required=false)]
                public string SimpleQuantity { get; set; }

                [NameInMap("SkuDesc")]
                [Validation(Required=false)]
                public string SkuDesc { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public long? SkuId { get; set; }

                [NameInMap("SkuPicUrl")]
                [Validation(Required=false)]
                public string SkuPicUrl { get; set; }

                [NameInMap("SkuProperties")]
                [Validation(Required=false)]
                public Dictionary<string, string> SkuProperties { get; set; }

                [NameInMap("SkuPropertiesJson")]
                [Validation(Required=false)]
                public string SkuPropertiesJson { get; set; }

                [NameInMap("SkuTitle")]
                [Validation(Required=false)]
                public string SkuTitle { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

                [NameInMap("lmSkuAttributeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> LmSkuAttributeMap { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

            [NameInMap("TotalSoldQuantity")]
            [Validation(Required=false)]
            public int? TotalSoldQuantity { get; set; }

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
