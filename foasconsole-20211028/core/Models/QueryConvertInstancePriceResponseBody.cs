// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class QueryConvertInstancePriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public QueryConvertInstancePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class QueryConvertInstancePriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public QueryConvertInstancePriceResponseBodyPriceInfoDepreciateInfo DepreciateInfo { get; set; }
            public class QueryConvertInstancePriceResponseBodyPriceInfoDepreciateInfo : TeaModel {
                [NameInMap("CheapRate")]
                [Validation(Required=false)]
                public string CheapRate { get; set; }

                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public string CheapStandAmount { get; set; }

                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                [NameInMap("MonthPrice")]
                [Validation(Required=false)]
                public string MonthPrice { get; set; }

                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public string OriginalStandAmount { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            [NameInMap("IsContractActivity")]
            [Validation(Required=false)]
            public bool? IsContractActivity { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("OptionalPromotions")]
            [Validation(Required=false)]
            public List<QueryConvertInstancePriceResponseBodyPriceInfoOptionalPromotions> OptionalPromotions { get; set; }
            public class QueryConvertInstancePriceResponseBodyPriceInfoOptionalPromotions : TeaModel {
                [NameInMap("PromotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                [NameInMap("PromotionOptionNo")]
                [Validation(Required=false)]
                public string PromotionOptionNo { get; set; }

                [NameInMap("Selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<QueryConvertInstancePriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class QueryConvertInstancePriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public string StandDiscountPrice { get; set; }

            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public string StandPrice { get; set; }

            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public float? TradeAmount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
