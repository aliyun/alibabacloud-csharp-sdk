// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCapacityReservationsResponseBody : TeaModel {
        [NameInMap("CapacityReservationSet")]
        [Validation(Required=false)]
        public DescribeCapacityReservationsResponseBodyCapacityReservationSet CapacityReservationSet { get; set; }
        public class DescribeCapacityReservationsResponseBodyCapacityReservationSet : TeaModel {
            [NameInMap("CapacityReservationItem")]
            [Validation(Required=false)]
            public List<DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItem> CapacityReservationItem { get; set; }
            public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItem : TeaModel {
                [NameInMap("AllocatedResources")]
                [Validation(Required=false)]
                public DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResources AllocatedResources { get; set; }
                public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResources : TeaModel {
                    [NameInMap("AllocatedResource")]
                    [Validation(Required=false)]
                    public List<DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResource> AllocatedResource { get; set; }
                    public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResource : TeaModel {
                        [NameInMap("AvailableAmount")]
                        [Validation(Required=false)]
                        public int? AvailableAmount { get; set; }

                        [NameInMap("CapacityReservationUsages")]
                        [Validation(Required=false)]
                        public DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResourceCapacityReservationUsages CapacityReservationUsages { get; set; }
                        public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResourceCapacityReservationUsages : TeaModel {
                            [NameInMap("CapacityReservationUsage")]
                            [Validation(Required=false)]
                            public List<DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResourceCapacityReservationUsagesCapacityReservationUsage> CapacityReservationUsage { get; set; }
                            public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResourceCapacityReservationUsagesCapacityReservationUsage : TeaModel {
                                [NameInMap("AccountId")]
                                [Validation(Required=false)]
                                public string AccountId { get; set; }

                                [NameInMap("ServiceName")]
                                [Validation(Required=false)]
                                public string ServiceName { get; set; }

                                [NameInMap("UsedAmount")]
                                [Validation(Required=false)]
                                public int? UsedAmount { get; set; }

                            }

                        }

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

                [NameInMap("CapacityReservationOwnerId")]
                [Validation(Required=false)]
                public string CapacityReservationOwnerId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("EndTimeType")]
                [Validation(Required=false)]
                public string EndTimeType { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

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

                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SavingPlanId")]
                [Validation(Required=false)]
                public string SavingPlanId { get; set; }

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
                public DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemTags Tags { get; set; }
                public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemTagsTag> Tag { get; set; }
                    public class DescribeCapacityReservationsResponseBodyCapacityReservationSetCapacityReservationItemTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

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
