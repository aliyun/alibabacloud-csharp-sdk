// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryItemInSubBizsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ItemBizList")]
        [Validation(Required=false)]
        public List<QueryItemInSubBizsResponseBodyItemBizList> ItemBizList { get; set; }
        public class QueryItemInSubBizsResponseBodyItemBizList : TeaModel {
            [NameInMap("CanSell")]
            [Validation(Required=false)]
            public bool? CanSell { get; set; }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("DescOption")]
            [Validation(Required=false)]
            public string DescOption { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemImages")]
            [Validation(Required=false)]
            public List<string> ItemImages { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }

            [NameInMap("PropertiesJson")]
            [Validation(Required=false)]
            public string PropertiesJson { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public long? ReservePrice { get; set; }

            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public long? SellerId { get; set; }

            [NameInMap("SkuList")]
            [Validation(Required=false)]
            public List<QueryItemInSubBizsResponseBodyItemBizListSkuList> SkuList { get; set; }
            public class QueryItemInSubBizsResponseBodyItemBizListSkuList : TeaModel {
                [NameInMap("BenefitId")]
                [Validation(Required=false)]
                public string BenefitId { get; set; }

                [NameInMap("CanSell")]
                [Validation(Required=false)]
                public bool? CanSell { get; set; }

                [NameInMap("CustomizedAttributeMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomizedAttributeMap { get; set; }

                [NameInMap("PointPrice")]
                [Validation(Required=false)]
                public long? PointPrice { get; set; }

                [NameInMap("Points")]
                [Validation(Required=false)]
                public long? Points { get; set; }

                [NameInMap("PointsAmount")]
                [Validation(Required=false)]
                public long? PointsAmount { get; set; }

                [NameInMap("PriceCent")]
                [Validation(Required=false)]
                public long? PriceCent { get; set; }

                [NameInMap("ReservePrice")]
                [Validation(Required=false)]
                public long? ReservePrice { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public long? SkuId { get; set; }

                [NameInMap("SkuPicUrl")]
                [Validation(Required=false)]
                public string SkuPicUrl { get; set; }

                [NameInMap("SkuProperties")]
                [Validation(Required=false)]
                public string SkuProperties { get; set; }

                [NameInMap("SkuPropertiesJson")]
                [Validation(Required=false)]
                public string SkuPropertiesJson { get; set; }

                [NameInMap("SkuTitle")]
                [Validation(Required=false)]
                public string SkuTitle { get; set; }

            }

            [NameInMap("SubBizId")]
            [Validation(Required=false)]
            public string SubBizId { get; set; }

            [NameInMap("TbShopName")]
            [Validation(Required=false)]
            public string TbShopName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
