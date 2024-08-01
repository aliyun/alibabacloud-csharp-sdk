// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCapacityReservationsResponseBody : TeaModel {
        /// <summary>
        /// Details of the capacity reservations.
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
                /// Details of the allocated resources.
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
                        /// The number of available instances.
                        /// </summary>
                        [NameInMap("AvailableAmount")]
                        [Validation(Required=false)]
                        public int? AvailableAmount { get; set; }

                        /// <summary>
                        /// Details of instance usage.
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
                                /// The ID of the Alibaba Cloud account.
                                /// </summary>
                                [NameInMap("AccountId")]
                                [Validation(Required=false)]
                                public string AccountId { get; set; }

                                /// <summary>
                                /// The name of the Alibaba Cloud service.
                                /// </summary>
                                [NameInMap("ServiceName")]
                                [Validation(Required=false)]
                                public string ServiceName { get; set; }

                                /// <summary>
                                /// The number of instances that are used by the Alibaba Cloud account or service.
                                /// </summary>
                                [NameInMap("UsedAmount")]
                                [Validation(Required=false)]
                                public int? UsedAmount { get; set; }

                            }

                        }

                        /// <summary>
                        /// The instance type of the instances.
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The total number of instances for which the capacity of an instance type is reserved.
                        /// </summary>
                        [NameInMap("TotalAmount")]
                        [Validation(Required=false)]
                        public int? TotalAmount { get; set; }

                        /// <summary>
                        /// The number of instances that have used the capacity reservation.
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
                /// The ID of the capacity reservation owner.
                /// </summary>
                [NameInMap("CapacityReservationOwnerId")]
                [Validation(Required=false)]
                public string CapacityReservationOwnerId { get; set; }

                /// <summary>
                /// The description of the capacity reservation.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the capacity reservation expires.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The release mode of the capacity reservation. Valid values:
                /// 
                /// *   Limited: The capacity reservation is automatically released at a specified time.
                /// *   Unlimited: The capacity reservation is manually released. You can release the capacity reservation anytime.
                /// </summary>
                [NameInMap("EndTimeType")]
                [Validation(Required=false)]
                public string EndTimeType { get; set; }

                /// <summary>
                /// The billing method of the instances created by using the capacity reservation. Valid values:
                /// 
                /// *   PostPaid: pay-as-you-go.
                /// *   PrePaid: subscription.
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The operating system type of the instances created by using the capacity reservation. Valid values:
                /// 
                /// *   windows
                /// *   linux
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The ID of the capacity reservation.
                /// </summary>
                [NameInMap("PrivatePoolOptionsId")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsId { get; set; }

                /// <summary>
                /// The type of the private pool generated after the capacity reservation takes effect. Valid values:
                /// 
                /// *   Open: open private pool.
                /// *   Target: targeted private pool.
                /// </summary>
                [NameInMap("PrivatePoolOptionsMatchCriteria")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsMatchCriteria { get; set; }

                /// <summary>
                /// The name of the capacity reservation.
                /// </summary>
                [NameInMap("PrivatePoolOptionsName")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsName { get; set; }

                /// <summary>
                /// The region ID of the capacity reservation.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the reserved instance used with the capacity reservation.
                /// </summary>
                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the capacity reservation belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the savings plan used with the capacity reservation.
                /// </summary>
                [NameInMap("SavingPlanId")]
                [Validation(Required=false)]
                public string SavingPlanId { get; set; }

                /// <summary>
                /// The time when the capacity reservation takes effect.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The mode in which the capacity reservation takes effect. Valid values:
                /// 
                /// *   Now: The capacity reservation takes effect immediately after it is created.
                /// *   Later: The capacity reservation takes effect at a specified time.
                /// </summary>
                [NameInMap("StartTimeType")]
                [Validation(Required=false)]
                public string StartTimeType { get; set; }

                /// <summary>
                /// The status of the capacity reservation. Valid values:
                /// 
                /// *   Pending: The capacity reservation is being initialized.
                /// *   Preparing: The capacity reservation is being prepared.
                /// *   Prepared: The capacity reservation is to take effect.
                /// *   Active: The capacity reservation is in effect.
                /// *   Released: The capacity reservation has been released manually or automatically when it expired.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags that are added to the capacity reservation.
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
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("TimeSlot")]
                [Validation(Required=false)]
                public string TimeSlot { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.If NextToken is empty, no next page exists.
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
