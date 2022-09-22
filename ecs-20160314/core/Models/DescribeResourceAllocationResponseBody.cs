// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeResourceAllocationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourcePlanningResponse")]
        [Validation(Required=false)]
        public DescribeResourceAllocationResponseBodyResourcePlanningResponse ResourcePlanningResponse { get; set; }
        public class DescribeResourceAllocationResponseBodyResourcePlanningResponse : TeaModel {
            [NameInMap("ResourceModels")]
            [Validation(Required=false)]
            public DescribeResourceAllocationResponseBodyResourcePlanningResponseResourceModels ResourceModels { get; set; }
            public class DescribeResourceAllocationResponseBodyResourcePlanningResponseResourceModels : TeaModel {
                [NameInMap("ResourceModel")]
                [Validation(Required=false)]
                public List<DescribeResourceAllocationResponseBodyResourcePlanningResponseResourceModelsResourceModel> ResourceModel { get; set; }
                public class DescribeResourceAllocationResponseBodyResourcePlanningResponseResourceModelsResourceModel : TeaModel {
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public int? Amount { get; set; }

                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("IoOptimized")]
                    [Validation(Required=false)]
                    public string IoOptimized { get; set; }

                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public float? Price { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("SpotStrategy")]
                    [Validation(Required=false)]
                    public string SpotStrategy { get; set; }

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
