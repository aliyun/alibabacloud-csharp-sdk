// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeSceneResourceRecommendResponseBody : TeaModel {
        [NameInMap("RecommendProducts")]
        [Validation(Required=false)]
        public DescribeSceneResourceRecommendResponseBodyRecommendProducts RecommendProducts { get; set; }
        public class DescribeSceneResourceRecommendResponseBodyRecommendProducts : TeaModel {
            [NameInMap("RecommendProduct")]
            [Validation(Required=false)]
            public List<DescribeSceneResourceRecommendResponseBodyRecommendProductsRecommendProduct> RecommendProduct { get; set; }
            public class DescribeSceneResourceRecommendResponseBodyRecommendProductsRecommendProduct : TeaModel {
                [NameInMap("RecommendInstanceSpecs")]
                [Validation(Required=false)]
                public DescribeSceneResourceRecommendResponseBodyRecommendProductsRecommendProductRecommendInstanceSpecs RecommendInstanceSpecs { get; set; }
                public class DescribeSceneResourceRecommendResponseBodyRecommendProductsRecommendProductRecommendInstanceSpecs : TeaModel {
                    [NameInMap("RecommendInstanceSpec")]
                    [Validation(Required=false)]
                    public List<DescribeSceneResourceRecommendResponseBodyRecommendProductsRecommendProductRecommendInstanceSpecsRecommendInstanceSpec> RecommendInstanceSpec { get; set; }
                    public class DescribeSceneResourceRecommendResponseBodyRecommendProductsRecommendProductRecommendInstanceSpecsRecommendInstanceSpec : TeaModel {
                        [NameInMap("Cores")]
                        [Validation(Required=false)]
                        public int? Cores { get; set; }

                        [NameInMap("InstanceTypes")]
                        [Validation(Required=false)]
                        public DescribeSceneResourceRecommendResponseBodyRecommendProductsRecommendProductRecommendInstanceSpecsRecommendInstanceSpecInstanceTypes InstanceTypes { get; set; }
                        public class DescribeSceneResourceRecommendResponseBodyRecommendProductsRecommendProductRecommendInstanceSpecsRecommendInstanceSpecInstanceTypes : TeaModel {
                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public List<DescribeSceneResourceRecommendResponseBodyRecommendProductsRecommendProductRecommendInstanceSpecsRecommendInstanceSpecInstanceTypesInstanceType> InstanceType { get; set; }
                            public class DescribeSceneResourceRecommendResponseBodyRecommendProductsRecommendProductRecommendInstanceSpecsRecommendInstanceSpecInstanceTypesInstanceType : TeaModel {
                                [NameInMap("InstanceTypeFamily")]
                                [Validation(Required=false)]
                                public string InstanceTypeFamily { get; set; }

                                [NameInMap("InstanceTypeName")]
                                [Validation(Required=false)]
                                public string InstanceTypeName { get; set; }

                                [NameInMap("Priority")]
                                [Validation(Required=false)]
                                public int? Priority { get; set; }

                            }

                        }

                        [NameInMap("Memory")]
                        [Validation(Required=false)]
                        public float? Memory { get; set; }

                    }

                }

                [NameInMap("RecommendReason")]
                [Validation(Required=false)]
                public string RecommendReason { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
