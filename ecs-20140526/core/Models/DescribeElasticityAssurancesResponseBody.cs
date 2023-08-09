// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssurancesResponseBody : TeaModel {
        /// <summary>
        /// Details about the elasticity assurances.
        /// </summary>
        [NameInMap("ElasticityAssuranceSet")]
        [Validation(Required=false)]
        public DescribeElasticityAssurancesResponseBodyElasticityAssuranceSet ElasticityAssuranceSet { get; set; }
        public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSet : TeaModel {
            [NameInMap("ElasticityAssuranceItem")]
            [Validation(Required=false)]
            public List<DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItem> ElasticityAssuranceItem { get; set; }
            public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItem : TeaModel {
                /// <summary>
                /// Details about the allocated resources.
                /// </summary>
                [NameInMap("AllocatedResources")]
                [Validation(Required=false)]
                public DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResources AllocatedResources { get; set; }
                public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResources : TeaModel {
                    [NameInMap("AllocatedResource")]
                    [Validation(Required=false)]
                    public List<DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResourcesAllocatedResource> AllocatedResource { get; set; }
                    public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResourcesAllocatedResource : TeaModel {
                        /// <summary>
                        /// The instance type.
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The total number of instances for which capacity of an instance type is reserved.
                        /// </summary>
                        [NameInMap("TotalAmount")]
                        [Validation(Required=false)]
                        public int? TotalAmount { get; set; }

                        /// <summary>
                        /// The number of instances that have used the elasticity assurance.
                        /// </summary>
                        [NameInMap("UsedAmount")]
                        [Validation(Required=false)]
                        public int? UsedAmount { get; set; }

                        /// <summary>
                        /// The zone ID.
                        /// </summary>
                        [NameInMap("zoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// The description of the elasticity assurance.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the elasticity assurance expires.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The billing method of the instance. The value can be only PostPaid. Only pay-as-you-go instances can be created by using elasticity assurances.
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// > This parameter is not publicly available.
                /// </summary>
                [NameInMap("LatestStartTime")]
                [Validation(Required=false)]
                public string LatestStartTime { get; set; }

                /// <summary>
                /// The ID of the elasticity assurance.
                /// </summary>
                [NameInMap("PrivatePoolOptionsId")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsId { get; set; }

                /// <summary>
                /// The type of the private pool associated with the elasticity assurance. Valid values:
                /// 
                /// *   Open: open private pool
                /// *   Target: specific private pool
                /// </summary>
                [NameInMap("PrivatePoolOptionsMatchCriteria")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsMatchCriteria { get; set; }

                /// <summary>
                /// The name of the elasticity assurance.
                /// </summary>
                [NameInMap("PrivatePoolOptionsName")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsName { get; set; }

                /// <summary>
                /// The region ID of the elasticity assurance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The time when the elasticity assurance takes effect.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// Indicates when the elasticity assurance takes effect. Valid values:
                /// 
                /// *   Now: The elasticity assurance takes effect immediately after it is created.
                /// *   Later: The elasticity assurance takes effect at a specified time.
                /// </summary>
                [NameInMap("StartTimeType")]
                [Validation(Required=false)]
                public string StartTimeType { get; set; }

                /// <summary>
                /// The status of the elasticity assurance. Valid values:
                /// 
                /// *   Preparing
                /// *   Prepared
                /// *   Active
                /// *   Released
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags of the elasticity assurance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemTags Tags { get; set; }
                public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemTagsTag> Tag { get; set; }
                    public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The total number of times that the elasticity assurance is applied.
                /// </summary>
                [NameInMap("TotalAssuranceTimes")]
                [Validation(Required=false)]
                public string TotalAssuranceTimes { get; set; }

                /// <summary>
                /// > This parameter is not publicly available.
                /// </summary>
                [NameInMap("UsedAssuranceTimes")]
                [Validation(Required=false)]
                public int? UsedAssuranceTimes { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
