// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssurancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the elasticity assurances.</para>
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
                /// <para>Details of the allocated resources.</para>
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
                        /// <remarks>
                        /// <para> This parameter is not publicly available.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("AvailableAmount")]
                        [Validation(Required=false)]
                        public int? AvailableAmount { get; set; }

                        /// <summary>
                        /// <remarks>
                        /// <para> This parameter is not publicly available.</para>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("ElasticityAssuranceUsages")]
                        [Validation(Required=false)]
                        public DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResourcesAllocatedResourceElasticityAssuranceUsages ElasticityAssuranceUsages { get; set; }
                        public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResourcesAllocatedResourceElasticityAssuranceUsages : TeaModel {
                            [NameInMap("ElasticityAssuranceUsage")]
                            [Validation(Required=false)]
                            public List<DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResourcesAllocatedResourceElasticityAssuranceUsagesElasticityAssuranceUsage> ElasticityAssuranceUsage { get; set; }
                            public class DescribeElasticityAssurancesResponseBodyElasticityAssuranceSetElasticityAssuranceItemAllocatedResourcesAllocatedResourceElasticityAssuranceUsagesElasticityAssuranceUsage : TeaModel {
                                /// <summary>
                                /// <remarks>
                                /// <para> This parameter is not publicly available.</para>
                                /// </remarks>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1144775968548340</para>
                                /// </summary>
                                [NameInMap("AccountId")]
                                [Validation(Required=false)]
                                public string AccountId { get; set; }

                                /// <summary>
                                /// <remarks>
                                /// <para> This parameter is not publicly available.</para>
                                /// </remarks>
                                /// 
                                /// <b>Example:</b>
                                /// <para>name</para>
                                /// </summary>
                                [NameInMap("ServiceName")]
                                [Validation(Required=false)]
                                public string ServiceName { get; set; }

                                /// <summary>
                                /// <remarks>
                                /// <para> This parameter is not publicly available.</para>
                                /// </remarks>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("UsedAmount")]
                                [Validation(Required=false)]
                                public int? UsedAmount { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The instance type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ecs.c6.large</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The total number of instances for which capacity of an instance type is reserved.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("TotalAmount")]
                        [Validation(Required=false)]
                        public int? TotalAmount { get; set; }

                        /// <summary>
                        /// <para>The number of instances that have used the elasticity assurance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("UsedAmount")]
                        [Validation(Required=false)]
                        public int? UsedAmount { get; set; }

                        /// <summary>
                        /// <para>The zone ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-h</para>
                        /// </summary>
                        [NameInMap("zoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The description of the elasticity assurance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>e114477596854834</para>
                /// </summary>
                [NameInMap("ElasticityAssuranceOwnerId")]
                [Validation(Required=false)]
                public string ElasticityAssuranceOwnerId { get; set; }

                /// <summary>
                /// <para>The time when the elasticity assurance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-03T16:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The billing method of the instance. The value can be only PostPaid. Only pay-as-you-go instances can be created by using elasticity assurances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <remarks>
                /// <para>This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("LatestStartTime")]
                [Validation(Required=false)]
                public string LatestStartTime { get; set; }

                /// <summary>
                /// <para>The ID of the elasticity assurance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp1ir35kqtn8ywci****</para>
                /// </summary>
                [NameInMap("PrivatePoolOptionsId")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsId { get; set; }

                /// <summary>
                /// <para>The type of the private pool associated with the elasticity assurance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Open: open private pool</description></item>
                /// <item><description>Target: specific private pool</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Target</para>
                /// </summary>
                [NameInMap("PrivatePoolOptionsMatchCriteria")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsMatchCriteria { get; set; }

                /// <summary>
                /// <para>The name of the elasticity assurance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eapTestName</para>
                /// </summary>
                [NameInMap("PrivatePoolOptionsName")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsName { get; set; }

                /// <summary>
                /// <para>The region ID of the elasticity assurance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The time when the elasticity assurance takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-03T05:25Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>Indicates when the elasticity assurance takes effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Now: The elasticity assurance takes effect immediately after it is created.</description></item>
                /// <item><description>Later: The elasticity assurance takes effect at a specified time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Now</para>
                /// </summary>
                [NameInMap("StartTimeType")]
                [Validation(Required=false)]
                public string StartTimeType { get; set; }

                /// <summary>
                /// <para>The status of the elasticity assurance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Preparing</description></item>
                /// <item><description>Prepared</description></item>
                /// <item><description>Active</description></item>
                /// <item><description>Released</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags of the elasticity assurance.</para>
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
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The total number of times that the elasticity assurance is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Unlimited</para>
                /// </summary>
                [NameInMap("TotalAssuranceTimes")]
                [Validation(Required=false)]
                public string TotalAssuranceTimes { get; set; }

                /// <summary>
                /// <remarks>
                /// <para>This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UsedAssuranceTimes")]
                [Validation(Required=false)]
                public int? UsedAssuranceTimes { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
