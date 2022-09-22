// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeRecommendProductResponseBody : TeaModel {
        [NameInMap("RecommendProducts")]
        [Validation(Required=false)]
        public DescribeRecommendProductResponseBodyRecommendProducts RecommendProducts { get; set; }
        public class DescribeRecommendProductResponseBodyRecommendProducts : TeaModel {
            [NameInMap("RecommendProduct")]
            [Validation(Required=false)]
            public List<DescribeRecommendProductResponseBodyRecommendProductsRecommendProduct> RecommendProduct { get; set; }
            public class DescribeRecommendProductResponseBodyRecommendProductsRecommendProduct : TeaModel {
                [NameInMap("RecommendInstanceTypes")]
                [Validation(Required=false)]
                public DescribeRecommendProductResponseBodyRecommendProductsRecommendProductRecommendInstanceTypes RecommendInstanceTypes { get; set; }
                public class DescribeRecommendProductResponseBodyRecommendProductsRecommendProductRecommendInstanceTypes : TeaModel {
                    [NameInMap("RecommendInstanceType")]
                    [Validation(Required=false)]
                    public List<DescribeRecommendProductResponseBodyRecommendProductsRecommendProductRecommendInstanceTypesRecommendInstanceType> RecommendInstanceType { get; set; }
                    public class DescribeRecommendProductResponseBodyRecommendProductsRecommendProductRecommendInstanceTypesRecommendInstanceType : TeaModel {
                        [NameInMap("CapacitySpecification")]
                        [Validation(Required=false)]
                        public string CapacitySpecification { get; set; }

                        [NameInMap("InstanceChargeType")]
                        [Validation(Required=false)]
                        public string InstanceChargeType { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public DescribeRecommendProductResponseBodyRecommendProductsRecommendProductRecommendInstanceTypesRecommendInstanceTypeInstanceType InstanceType { get; set; }
                        public class DescribeRecommendProductResponseBodyRecommendProductsRecommendProductRecommendInstanceTypesRecommendInstanceTypeInstanceType : TeaModel {
                            [NameInMap("Cores")]
                            [Validation(Required=false)]
                            public int? Cores { get; set; }

                            [NameInMap("Generation")]
                            [Validation(Required=false)]
                            public string Generation { get; set; }

                            [NameInMap("InstanceFamilyLevel")]
                            [Validation(Required=false)]
                            public string InstanceFamilyLevel { get; set; }

                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }

                            [NameInMap("InstanceTypeFamily")]
                            [Validation(Required=false)]
                            public string InstanceTypeFamily { get; set; }

                            [NameInMap("Memory")]
                            [Validation(Required=false)]
                            public int? Memory { get; set; }

                            [NameInMap("SupportIoOptimized")]
                            [Validation(Required=false)]
                            public string SupportIoOptimized { get; set; }

                        }

                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        [NameInMap("Price")]
                        [Validation(Required=false)]
                        public float? Price { get; set; }

                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public int? Priority { get; set; }

                        [NameInMap("SpotStrategy")]
                        [Validation(Required=false)]
                        public string SpotStrategy { get; set; }

                    }

                }

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
