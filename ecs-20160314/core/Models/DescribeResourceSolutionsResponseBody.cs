// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeResourceSolutionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourcePlanningResponses")]
        [Validation(Required=false)]
        public DescribeResourceSolutionsResponseBodyResourcePlanningResponses ResourcePlanningResponses { get; set; }
        public class DescribeResourceSolutionsResponseBodyResourcePlanningResponses : TeaModel {
            [NameInMap("ResourcePlanningResponse")]
            [Validation(Required=false)]
            public List<DescribeResourceSolutionsResponseBodyResourcePlanningResponsesResourcePlanningResponse> ResourcePlanningResponse { get; set; }
            public class DescribeResourceSolutionsResponseBodyResourcePlanningResponsesResourcePlanningResponse : TeaModel {
                [NameInMap("RecommendReasons")]
                [Validation(Required=false)]
                public DescribeResourceSolutionsResponseBodyResourcePlanningResponsesResourcePlanningResponseRecommendReasons RecommendReasons { get; set; }
                public class DescribeResourceSolutionsResponseBodyResourcePlanningResponsesResourcePlanningResponseRecommendReasons : TeaModel {
                    [NameInMap("RecommendReason")]
                    [Validation(Required=false)]
                    public List<string> RecommendReason { get; set; }

                }

                [NameInMap("ResourceModels")]
                [Validation(Required=false)]
                public DescribeResourceSolutionsResponseBodyResourcePlanningResponsesResourcePlanningResponseResourceModels ResourceModels { get; set; }
                public class DescribeResourceSolutionsResponseBodyResourcePlanningResponsesResourcePlanningResponseResourceModels : TeaModel {
                    [NameInMap("ResourceModel")]
                    [Validation(Required=false)]
                    public List<DescribeResourceSolutionsResponseBodyResourcePlanningResponsesResourcePlanningResponseResourceModelsResourceModel> ResourceModel { get; set; }
                    public class DescribeResourceSolutionsResponseBodyResourcePlanningResponsesResourcePlanningResponseResourceModelsResourceModel : TeaModel {
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public int? Amount { get; set; }

                        [NameInMap("DeliveryTime")]
                        [Validation(Required=false)]
                        public string DeliveryTime { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                [NameInMap("SatisfiedAmount")]
                [Validation(Required=false)]
                public int? SatisfiedAmount { get; set; }

            }

        }

    }

}
