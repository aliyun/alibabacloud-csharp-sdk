// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssurancesResponseBody : TeaModel {
        [NameInMap("ElasticityAssuranceSet")]
        [Validation(Required=false)]
        public DescribeElasticityAssurancesResponseBodyElasticityAssuranceSet ElasticityAssuranceSet { get; set; }
        public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSet : TeaModel {
            [NameInMap("ElasticityAssuranceItem")]
            [Validation(Required=false)]
            public List<DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItem> ElasticityAssuranceItem { get; set; }
            public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItem : TeaModel {
                public DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResources AllocatedResources { get; set; }
                public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResources : TeaModel {
                    [NameInMap("AllocatedResource")]
                    [Validation(Required=false)]
                    public List<DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResourcesAllocatedResource> AllocatedResource { get; set; }
                    public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResourcesAllocatedResource : TeaModel {
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("TotalAmount")]
                        [Validation(Required=false)]
                        public int? TotalAmount { get; set; }

                        [NameInMap("UsedAmount")]
                        [Validation(Required=false)]
                        public int? UsedAmount { get; set; }

                        [NameInMap("zoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }
                public string Description { get; set; }
                public string EndTime { get; set; }
                public string InstanceChargeType { get; set; }
                public string LatestStartTime { get; set; }
                public string PrivatePoolOptionsId { get; set; }
                public string PrivatePoolOptionsMatchCriteria { get; set; }
                public string PrivatePoolOptionsName { get; set; }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public string StartTime { get; set; }
                public string StartTimeType { get; set; }
                public string Status { get; set; }
                public DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemTags Tags { get; set; }
                public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemTagsTag> Tag { get; set; }
                    public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }
                public string TotalAssuranceTimes { get; set; }
                public int? UsedAssuranceTimes { get; set; }
            }
        };

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
