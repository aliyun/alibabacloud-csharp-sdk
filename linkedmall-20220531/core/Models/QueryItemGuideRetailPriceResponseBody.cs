// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class QueryItemGuideRetailPriceResponseBody : TeaModel {
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
        public List<QueryItemGuideRetailPriceResponseBodyModel> Model { get; set; }
        public class QueryItemGuideRetailPriceResponseBodyModel : TeaModel {
            [NameInMap("DistributionMallId")]
            [Validation(Required=false)]
            public string DistributionMallId { get; set; }

            [NameInMap("GuideRetailPriceScope")]
            [Validation(Required=false)]
            public string GuideRetailPriceScope { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("LowGuideRetailPriceScope")]
            [Validation(Required=false)]
            public string LowGuideRetailPriceScope { get; set; }

            [NameInMap("ReservedPrice")]
            [Validation(Required=false)]
            public long? ReservedPrice { get; set; }

            [NameInMap("ReservedPriceScope")]
            [Validation(Required=false)]
            public string ReservedPriceScope { get; set; }

            [NameInMap("SkuModels")]
            [Validation(Required=false)]
            public List<QueryItemGuideRetailPriceResponseBodyModelSkuModels> SkuModels { get; set; }
            public class QueryItemGuideRetailPriceResponseBodyModelSkuModels : TeaModel {
                [NameInMap("DistributionMallId")]
                [Validation(Required=false)]
                public string DistributionMallId { get; set; }

                [NameInMap("GuideRetailPrice")]
                [Validation(Required=false)]
                public long? GuideRetailPrice { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("LowGuideRetailPrice")]
                [Validation(Required=false)]
                public long? LowGuideRetailPrice { get; set; }

                [NameInMap("PriceCent")]
                [Validation(Required=false)]
                public long? PriceCent { get; set; }

                [NameInMap("ReservedPrice")]
                [Validation(Required=false)]
                public long? ReservedPrice { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public long? SkuId { get; set; }

                [NameInMap("SkuTitle")]
                [Validation(Required=false)]
                public string SkuTitle { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

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

    }

}
