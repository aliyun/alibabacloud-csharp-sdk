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
                [NameInMap("AllocatedResources")]
                [Validation(Required=false)]
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

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("LatestStartTime")]
                [Validation(Required=false)]
                public string LatestStartTime { get; set; }

                [NameInMap("PrivatePoolOptionsId")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsId { get; set; }

                [NameInMap("PrivatePoolOptionsMatchCriteria")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsMatchCriteria { get; set; }

                [NameInMap("PrivatePoolOptionsName")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsName { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StartTimeType")]
                [Validation(Required=false)]
                public string StartTimeType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                [NameInMap("TotalAssuranceTimes")]
                [Validation(Required=false)]
                public string TotalAssuranceTimes { get; set; }

                [NameInMap("UsedAssuranceTimes")]
                [Validation(Required=false)]
                public int? UsedAssuranceTimes { get; set; }

            }

        }

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
