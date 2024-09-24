// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about dedicated clusters returned.</para>
        /// </summary>
        [NameInMap("DedicatedHostGroups")]
        [Validation(Required=false)]
        public DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroups DedicatedHostGroups { get; set; }
        public class DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroups : TeaModel {
            [NameInMap("DedicatedHostGroups")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroups> DedicatedHostGroups { get; set; }
            public class DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroups : TeaModel {
                /// <summary>
                /// <para>The policy based on which the system allocates resources in the dedicated cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Evenly</b>: The system evenly allocates the resources to all the hosts in the dedicated cluster.</description></item>
                /// <item><description><b>Intensively</b>: The system preferentially allocates the resources to the heavily loaded hosts in the dedicated cluster.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Evenly</para>
                /// </summary>
                [NameInMap("AllocationPolicy")]
                [Validation(Required=false)]
                public string AllocationPolicy { get; set; }

                /// <summary>
                /// <para>The ID of the bastion host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bastionhost-cn-m7xxxxxxxx</para>
                /// </summary>
                [NameInMap("BastionInstanceId")]
                [Validation(Required=false)]
                public string BastionInstanceId { get; set; }

                /// <summary>
                /// <para>The percentage of allocated cores in the dedicated cluster. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("CpuAllocateRation")]
                [Validation(Required=false)]
                public float? CpuAllocateRation { get; set; }

                /// <summary>
                /// <para>The number of allocated cores in the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("CpuAllocatedAmount")]
                [Validation(Required=false)]
                public float? CpuAllocatedAmount { get; set; }

                /// <summary>
                /// <para>The core overcommitment ratio of the dedicated cluster. Unit: %. For more information about the core overcommitment ratio, see <a href="https://help.aliyun.com/document_detail/182328.html">Manage a dedicated cluster</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("CpuAllocationRatio")]
                [Validation(Required=false)]
                public int? CpuAllocationRatio { get; set; }

                /// <summary>
                /// <para>The timestamp when the dedicated cluster was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1571125370000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The type of storage media that is used for the hosts in the dedicated cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>dhg_cloud_ssd</b>: cloud disks</description></item>
                /// <item><description><b>dhg_local_ssd</b>: local disks</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dhg_cloud_ssd</para>
                /// </summary>
                [NameInMap("DedicatedHostCountGroupByHostType")]
                [Validation(Required=false)]
                public Dictionary<string, object> DedicatedHostCountGroupByHostType { get; set; }

                /// <summary>
                /// <para>The name of the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testHostGroup</para>
                /// </summary>
                [NameInMap("DedicatedHostGroupDesc")]
                [Validation(Required=false)]
                public string DedicatedHostGroupDesc { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dhg-7a9xxxxxxxx</para>
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// <para>The percentage of allocated disk space in the dedicated cluster. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.49</para>
                /// </summary>
                [NameInMap("DiskAllocateRation")]
                [Validation(Required=false)]
                public float? DiskAllocateRation { get; set; }

                /// <summary>
                /// <para>The amount of allocated disk space in the dedicated cluster. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("DiskAllocatedAmount")]
                [Validation(Required=false)]
                public float? DiskAllocatedAmount { get; set; }

                /// <summary>
                /// <para>The disk overcommitment ratio of the dedicated cluster. Unit: %. For more information about the core overcommitment ratio, see <a href="https://help.aliyun.com/document_detail/182328.html">Manage a dedicated cluster</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("DiskAllocationRatio")]
                [Validation(Required=false)]
                public int? DiskAllocationRatio { get; set; }

                /// <summary>
                /// <para>The amount of used disk space in the dedicated cluster. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DiskUsedAmount")]
                [Validation(Required=false)]
                public float? DiskUsedAmount { get; set; }

                /// <summary>
                /// <para>The disk usage of the dedicated cluster. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DiskUtility")]
                [Validation(Required=false)]
                public float? DiskUtility { get; set; }

                /// <summary>
                /// <para>The database engine of the instances in the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The total number of hosts in the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("HostNumber")]
                [Validation(Required=false)]
                public int? HostNumber { get; set; }

                /// <summary>
                /// <para>The policy that is used to handle host failures. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Auto</b>: The system automatically replaces faulty hosts.</description></item>
                /// <item><description><b>Manual</b>: You must manually replace faulty hosts.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Auto</para>
                /// </summary>
                [NameInMap("HostReplacePolicy")]
                [Validation(Required=false)]
                public string HostReplacePolicy { get; set; }

                /// <summary>
                /// <para>The total number of instances in the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public int? InstanceNumber { get; set; }

                /// <summary>
                /// <para>The percentage of allocated memory space in the dedicated cluster. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33.7</para>
                /// </summary>
                [NameInMap("MemAllocateRation")]
                [Validation(Required=false)]
                public float? MemAllocateRation { get; set; }

                /// <summary>
                /// <para>The amount of allocated memory space in the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16384</para>
                /// </summary>
                [NameInMap("MemAllocatedAmount")]
                [Validation(Required=false)]
                public float? MemAllocatedAmount { get; set; }

                /// <summary>
                /// <para>The memory overcommitment ratio of the dedicated cluster. Unit: %. For more information about the core overcommitment ratio, see <a href="https://help.aliyun.com/document_detail/182328.html">Manage a dedicated cluster</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("MemAllocationRatio")]
                [Validation(Required=false)]
                public int? MemAllocationRatio { get; set; }

                /// <summary>
                /// <para>The amount of used memory space in the dedicated cluster. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MemUsedAmount")]
                [Validation(Required=false)]
                public float? MemUsedAmount { get; set; }

                /// <summary>
                /// <para>The memory usage of the dedicated cluster. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MemUtility")]
                [Validation(Required=false)]
                public float? MemUtility { get; set; }

                /// <summary>
                /// <para>Indicates whether the feature that allows you to have the OS permissions on the host is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b> or <b>null</b>: The permissions cannot be granted.</description></item>
                /// <item><description><b>1</b>: The permissions can be granted.</description></item>
                /// <item><description><b>3</b>: The permissions have been granted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("OpenPermission")]
                [Validation(Required=false)]
                public string OpenPermission { get; set; }

                /// <summary>
                /// <para>The name and ID of the dedicated cluster. The value consists of <b>DedicatedHostGroupDesc</b> and <b>DedicatedHostGroupId</b>. Format: DedicatedHostGroupDesc/DedicatedHostGroupId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testHostGroup/dhg-7a9xxxxxxxx</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) to which the dedicated cluster belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1oxxxxxx</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The zones to which the hosts of the dedicated cluster belong.</para>
                /// </summary>
                [NameInMap("ZoneIDList")]
                [Validation(Required=false)]
                public DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroupsZoneIDList ZoneIDList { get; set; }
                public class DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroupsZoneIDList : TeaModel {
                    [NameInMap("ZoneIDList")]
                    [Validation(Required=false)]
                    public List<string> ZoneIDList { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AB44DC0A-7E77-442A-97A9-C6418694CB22</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
