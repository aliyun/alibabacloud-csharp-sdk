// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeReservedInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E572643C-6A29-49D6-9D4E-6CFA4E063A3E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details about the reserved instances.</para>
        /// </summary>
        [NameInMap("ReservedInstances")]
        [Validation(Required=false)]
        public DescribeReservedInstancesResponseBodyReservedInstances ReservedInstances { get; set; }
        public class DescribeReservedInstancesResponseBodyReservedInstances : TeaModel {
            [NameInMap("ReservedInstance")]
            [Validation(Required=false)]
            public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstance> ReservedInstance { get; set; }
            public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstance : TeaModel {
                /// <summary>
                /// <para>Indicates the sharing status of the reserved instance when the AllocationType parameter is set to Shared. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>allocated: The reserved instance is allocated to another account.</description></item>
                /// <item><description>beAllocated: The reserved instance is allocated by another account.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>allocated</para>
                /// </summary>
                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-12-10T12:07Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-10T12:07Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The number of pay-as-you-go instances that are of the same instance type as the reserved instance and can be matched to the reserved instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("InstanceAmount")]
                [Validation(Required=false)]
                public int? InstanceAmount { get; set; }

                /// <summary>
                /// <para>The instance type of the pay-as-you-go instances that can be matched to the reserved instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g5.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The payment option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>All Upfront</para>
                /// </summary>
                [NameInMap("OfferingType")]
                [Validation(Required=false)]
                public string OfferingType { get; set; }

                /// <summary>
                /// <para>Details about the lock status of the reserved instance.</para>
                /// </summary>
                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocks OperationLocks { get; set; }
                public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocks : TeaModel {
                    [NameInMap("OperationLock")]
                    [Validation(Required=false)]
                    public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocksOperationLock> OperationLock { get; set; }
                    public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocksOperationLock : TeaModel {
                        /// <summary>
                        /// <para>The reason why the instance is locked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>security</para>
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                /// <summary>
                /// <para>The operating system of the image used by the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Windows</description></item>
                /// <item><description>Linux</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Linux</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The reserved instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ri-bpzhex2ulpzf53****</para>
                /// </summary>
                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>riZbpzhex2ulpzf53****</para>
                /// </summary>
                [NameInMap("ReservedInstanceName")]
                [Validation(Required=false)]
                public string ReservedInstanceName { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EcsDocTest</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>region</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The effective time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-12-10T12:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Details about the tags of the reserved instance.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTags Tags { get; set; }
                public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTagsTag> Tag { get; set; }
                    public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTagsTag : TeaModel {
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
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-z</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of reserved instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
