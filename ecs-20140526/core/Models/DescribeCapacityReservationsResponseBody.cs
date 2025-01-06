// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCapacityReservationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the capacity reservations.</para>
        /// </summary>
        [NameInMap("CapacityReservationSet")]
        [Validation(Required=false)]
        public DescribeCapacityReservationsResponseBodyCapacityReservationSet CapacityReservationSet { get; set; }
        public class DescribeCapacityReservationsResponseBodyCapacityReservationSet : TeaModel {
            [NameInMap("CapacityReservationItem")]
            [Validation(Required=false)]
            public List<DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItem> CapacityReservationItem { get; set; }
            public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItem : TeaModel {
                /// <summary>
                /// <para>Details of the allocated resources.</para>
                /// </summary>
                [NameInMap("AllocatedResources")]
                [Validation(Required=false)]
                public DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResources AllocatedResources { get; set; }
                public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResources : TeaModel {
                    [NameInMap("AllocatedResource")]
                    [Validation(Required=false)]
                    public List<DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResource> AllocatedResource { get; set; }
                    public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResource : TeaModel {
                        /// <summary>
                        /// <para>The number of available instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("AvailableAmount")]
                        [Validation(Required=false)]
                        public int? AvailableAmount { get; set; }

                        /// <summary>
                        /// <para>Details of instance usage.</para>
                        /// </summary>
                        [NameInMap("CapacityReservationUsages")]
                        [Validation(Required=false)]
                        public DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResourceCapacityReservationUsages CapacityReservationUsages { get; set; }
                        public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResourceCapacityReservationUsages : TeaModel {
                            [NameInMap("CapacityReservationUsage")]
                            [Validation(Required=false)]
                            public List<DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResourceCapacityReservationUsagesCapacityReservationUsage> CapacityReservationUsage { get; set; }
                            public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResourceCapacityReservationUsagesCapacityReservationUsage : TeaModel {
                                /// <summary>
                                /// <para>The ID of the Alibaba Cloud account.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>105909559088****</para>
                                /// </summary>
                                [NameInMap("AccountId")]
                                [Validation(Required=false)]
                                public string AccountId { get; set; }

                                /// <summary>
                                /// <para>The name of the Alibaba Cloud service.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>maxcompute.aliyuncs.com</para>
                                /// </summary>
                                [NameInMap("ServiceName")]
                                [Validation(Required=false)]
                                public string ServiceName { get; set; }

                                /// <summary>
                                /// <para>The number of instances that are used by the Alibaba Cloud account or service.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>20</para>
                                /// </summary>
                                [NameInMap("UsedAmount")]
                                [Validation(Required=false)]
                                public int? UsedAmount { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The instance type of the instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ecs.c6.large</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The total number of instances for which the capacity of an instance type is reserved.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("TotalAmount")]
                        [Validation(Required=false)]
                        public int? TotalAmount { get; set; }

                        /// <summary>
                        /// <para>The number of instances that have used the capacity reservation.</para>
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
                /// <para>The ID of the capacity reservation owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100************7</para>
                /// </summary>
                [NameInMap("CapacityReservationOwnerId")]
                [Validation(Required=false)]
                public string CapacityReservationOwnerId { get; set; }

                /// <summary>
                /// <para>The description of the capacity reservation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the capacity reservation expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-02-19T03:02Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The release mode of the capacity reservation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Limited: The capacity reservation is automatically released at a specified time.</description></item>
                /// <item><description>Unlimited: The capacity reservation is manually released. You can release the capacity reservation anytime.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlimited</para>
                /// </summary>
                [NameInMap("EndTimeType")]
                [Validation(Required=false)]
                public string EndTimeType { get; set; }

                /// <summary>
                /// <para>The billing method of the instances created by using the capacity reservation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PostPaid: pay-as-you-go.</description></item>
                /// <item><description>PrePaid: subscription.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The operating system type of the instances created by using the capacity reservation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>windows</description></item>
                /// <item><description>linux</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>linux</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The ID of the capacity reservation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>crp-bp1gubrkqutenqdd****</para>
                /// </summary>
                [NameInMap("PrivatePoolOptionsId")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsId { get; set; }

                /// <summary>
                /// <para>The type of the private pool generated after the capacity reservation takes effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Open: open private pool. If you use the capacity reservation to create Elastic Compute Service (ECS) instances, the open private pool that is associated with the capacity reservation is automatically matched. If no capacity is available in the open private pool, resources in the public pool are automatically used to create the instances.</description></item>
                /// <item><description>Target: targeted private pool. If you use the capacity reservation to create ECS instances, the targeted private pool that is associated with the capacity reservation is automatically matched. If no capacity is available in the private pool, the instances fail to be created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Open</para>
                /// </summary>
                [NameInMap("PrivatePoolOptionsMatchCriteria")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsMatchCriteria { get; set; }

                /// <summary>
                /// <para>The name of the capacity reservation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>crpTestName</para>
                /// </summary>
                [NameInMap("PrivatePoolOptionsName")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsName { get; set; }

                /// <summary>
                /// <para>The region ID of the capacity reservation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the reserved instance used with the capacity reservation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ri-bpzhex2ulpzf53****</para>
                /// </summary>
                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the capacity reservation belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the savings plan used with the capacity reservation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spn-c29b5e18pJMT****</para>
                /// </summary>
                [NameInMap("SavingPlanId")]
                [Validation(Required=false)]
                public string SavingPlanId { get; set; }

                /// <summary>
                /// <para>The time when the capacity reservation takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-02-19T02:01Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The mode in which the capacity reservation takes effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Now: The capacity reservation takes effect immediately after it is created.</description></item>
                /// <item><description>Later: The capacity reservation takes effect at a specified time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Now</para>
                /// </summary>
                [NameInMap("StartTimeType")]
                [Validation(Required=false)]
                public string StartTimeType { get; set; }

                /// <summary>
                /// <para>The status of the capacity reservation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The capacity reservation is being initialized.</description></item>
                /// <item><description>Preparing: The capacity reservation is being prepared.</description></item>
                /// <item><description>Prepared: The capacity reservation is to take effect.</description></item>
                /// <item><description>Active: The capacity reservation is in effect.</description></item>
                /// <item><description>Released: The capacity reservation has been released manually or automatically when it expired.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags that are added to the capacity reservation.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemTags Tags { get; set; }
                public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemTagsTag> Tag { get; set; }
                    public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
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
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("TimeSlot")]
                [Validation(Required=false)]
                public string TimeSlot { get; set; }

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
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
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
