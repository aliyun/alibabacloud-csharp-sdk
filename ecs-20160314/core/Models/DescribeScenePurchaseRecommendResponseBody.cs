// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeScenePurchaseRecommendResponseBody : TeaModel {
        [NameInMap("RecommendProducts")]
        [Validation(Required=false)]
        public DescribeScenePurchaseRecommendResponseBodyRecommendProducts RecommendProducts { get; set; }
        public class DescribeScenePurchaseRecommendResponseBodyRecommendProducts : TeaModel {
            [NameInMap("RecommendProduct")]
            [Validation(Required=false)]
            public List<DescribeScenePurchaseRecommendResponseBodyRecommendProductsRecommendProduct> RecommendProduct { get; set; }
            public class DescribeScenePurchaseRecommendResponseBodyRecommendProductsRecommendProduct : TeaModel {
                [NameInMap("RecommendSpSpecs")]
                [Validation(Required=false)]
                public DescribeScenePurchaseRecommendResponseBodyRecommendProductsRecommendProductRecommendSpSpecs RecommendSpSpecs { get; set; }
                public class DescribeScenePurchaseRecommendResponseBodyRecommendProductsRecommendProductRecommendSpSpecs : TeaModel {
                    [NameInMap("RecommendSpSpec")]
                    [Validation(Required=false)]
                    public List<DescribeScenePurchaseRecommendResponseBodyRecommendProductsRecommendProductRecommendSpSpecsRecommendSpSpec> RecommendSpSpec { get; set; }
                    public class DescribeScenePurchaseRecommendResponseBodyRecommendProductsRecommendProductRecommendSpSpecsRecommendSpSpec : TeaModel {
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public int? Duration { get; set; }

                        [NameInMap("EffectiveDate")]
                        [Validation(Required=false)]
                        public string EffectiveDate { get; set; }

                        [NameInMap("PayMode")]
                        [Validation(Required=false)]
                        public string PayMode { get; set; }

                        [NameInMap("PricingCycle")]
                        [Validation(Required=false)]
                        public string PricingCycle { get; set; }

                        [NameInMap("RecommendReason")]
                        [Validation(Required=false)]
                        public string RecommendReason { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
