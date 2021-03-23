// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetPayAsYouGoPriceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPayAsYouGoPriceResponseBodyData Data { get; set; }
        public class GetPayAsYouGoPriceResponseBodyData : TeaModel {
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }
            [NameInMap("ModuleDetails")]
            [Validation(Required=false)]
            public GetPayAsYouGoPriceResponseBodyDataModuleDetails ModuleDetails { get; set; }
            public class GetPayAsYouGoPriceResponseBodyDataModuleDetails : TeaModel {
                [NameInMap("ModuleDetail")]
                [Validation(Required=false)]
                public List<GetPayAsYouGoPriceResponseBodyDataModuleDetailsModuleDetail> ModuleDetail { get; set; }
                public class GetPayAsYouGoPriceResponseBodyDataModuleDetailsModuleDetail : TeaModel {
                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    [NameInMap("OriginalCost")]
                    [Validation(Required=false)]
                    public float? OriginalCost { get; set; }

                    [NameInMap("InvoiceDiscount")]
                    [Validation(Required=false)]
                    public float? InvoiceDiscount { get; set; }

                    [NameInMap("CostAfterDiscount")]
                    [Validation(Required=false)]
                    public float? CostAfterDiscount { get; set; }

                    [NameInMap("UnitPrice")]
                    [Validation(Required=false)]
                    public float? UnitPrice { get; set; }

                }

            }
            [NameInMap("PromotionDetails")]
            [Validation(Required=false)]
            public GetPayAsYouGoPriceResponseBodyDataPromotionDetails PromotionDetails { get; set; }
            public class GetPayAsYouGoPriceResponseBodyDataPromotionDetails : TeaModel {
                [NameInMap("PromotionDetail")]
                [Validation(Required=false)]
                public List<GetPayAsYouGoPriceResponseBodyDataPromotionDetailsPromotionDetail> PromotionDetail { get; set; }
                public class GetPayAsYouGoPriceResponseBodyDataPromotionDetailsPromotionDetail : TeaModel {
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public long? PromotionId { get; set; }

                }

            }
        };

    }

}
