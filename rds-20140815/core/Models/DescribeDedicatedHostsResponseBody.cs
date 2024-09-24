// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostsResponseBody : TeaModel {
        /// <summary>
        /// <para>The host group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-7a9xxxxxxxx</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The host information.</para>
        /// </summary>
        [NameInMap("DedicatedHosts")]
        [Validation(Required=false)]
        public DescribeDedicatedHostsResponseBodyDedicatedHosts DedicatedHosts { get; set; }
        public class DescribeDedicatedHostsResponseBodyDedicatedHosts : TeaModel {
            [NameInMap("DedicatedHosts")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHosts> DedicatedHosts { get; set; }
            public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHosts : TeaModel {
                /// <summary>
                /// <para>The host account. You can call the <a href="https://help.aliyun.com/document_detail/196877.html">CreateDedicatedHostAccount</a> operation to create a host account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>Specifies whether instances can be deployed on the host. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Instances cannot be deployed on the host.</description></item>
                /// <item><description><b>1</b>: Instances can be deployed on the host.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                /// <summary>
                /// <para>The bastion host ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bastionhost-cn-m7xxxxxxxx</para>
                /// </summary>
                [NameInMap("BastionInstanceId")]
                [Validation(Required=false)]
                public string BastionInstanceId { get; set; }

                /// <summary>
                /// <para>The core overcommitment ratio of the dedicated cluster. Unit: percentage. For more information about the core overcommitment ratio, see <a href="https://help.aliyun.com/document_detail/182328.html">Manage a dedicated cluster</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("CPUAllocationRatio")]
                [Validation(Required=false)]
                public string CPUAllocationRatio { get; set; }

                /// <summary>
                /// <para>The number of used CPU cores on the host. Unit: cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CpuUsed")]
                [Validation(Required=false)]
                public string CpuUsed { get; set; }

                /// <summary>
                /// <para>The time when the host was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-25 17:29:06.0</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The dedicated cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dhg-7a9xxxxxxxx</para>
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// <para>The host ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bpxxxxxxx</para>
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                /// <summary>
                /// <para>The disk overcommitment ratio of the dedicated cluster. Unit: percentage. For more information about the core overcommitment ratio, see <a href="https://help.aliyun.com/document_detail/182328.html">Manage a dedicated cluster</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("DiskAllocationRatio")]
                [Validation(Required=false)]
                public string DiskAllocationRatio { get; set; }

                /// <summary>
                /// <para>The time when the host expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-25T16:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The database engine of instances that are created on the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The total number of CPU cores that are configured for the host. Unit: cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("HostCPU")]
                [Validation(Required=false)]
                public string HostCPU { get; set; }

                /// <summary>
                /// <para>The instance type of the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.i2.16xlarge</para>
                /// </summary>
                [NameInMap("HostClass")]
                [Validation(Required=false)]
                public string HostClass { get; set; }

                /// <summary>
                /// <para>The total memory space of the host. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32238</para>
                /// </summary>
                [NameInMap("HostMem")]
                [Validation(Required=false)]
                public string HostMem { get; set; }

                /// <summary>
                /// <para>The host name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testHost1</para>
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// <para>The status of the host. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: creating</description></item>
                /// <item><description><b>1</b>: running</description></item>
                /// <item><description><b>2</b>: faulty</description></item>
                /// <item><description><b>3</b>: being replaced</description></item>
                /// <item><description><b>4</b>: deprecated</description></item>
                /// <item><description><b>5</b>: deleting</description></item>
                /// <item><description><b>6</b>: restarting</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HostStatus")]
                [Validation(Required=false)]
                public string HostStatus { get; set; }

                /// <summary>
                /// <para>The storage capacity of the host. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2097152</para>
                /// </summary>
                [NameInMap("HostStorage")]
                [Validation(Required=false)]
                public string HostStorage { get; set; }

                /// <summary>
                /// <para>The storage type of the host. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>dhg_cloud_ssd</b>: ESSD</description></item>
                /// <item><description><b>dhg_local_ssd</b>: local SSD</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dhg_cloud_ssd</para>
                /// </summary>
                [NameInMap("HostType")]
                [Validation(Required=false)]
                public string HostType { get; set; }

                /// <summary>
                /// <para>The internal IP address of the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.xx.xx.xx</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The host image. This parameter is returned only when the <b>Engine</b> parameter is set to <b>mssql</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>WindowsWithMssqlStdLicense</b>: a Windows image that contains the licenses of SQL Server Standard Edition</description></item>
                /// <item><description><b>WindowsWithMssqlEntLisence</b>: a Windows image that contains the licenses of SQL Server Enterprise Edition</description></item>
                /// <item><description><b>WindowsWithMssqlWebLisence</b>: a Windows image that contains the licenses of SQL Server Web Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>WindowsWithMssqlStdLicense</para>
                /// </summary>
                [NameInMap("ImageCategory")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                /// <summary>
                /// <para>The total number of instances that are created on the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public string InstanceNumber { get; set; }

                /// <summary>
                /// <para>The maximum memory usage per host in the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("MemAllocationRatio")]
                [Validation(Required=false)]
                public string MemAllocationRatio { get; set; }

                /// <summary>
                /// <para>The size of the used memory. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16384</para>
                /// </summary>
                [NameInMap("MemoryUsed")]
                [Validation(Required=false)]
                public string MemoryUsed { get; set; }

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
                /// <para>The amount of used storage space on the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StorageUsed")]
                [Validation(Required=false)]
                public string StorageUsed { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) to which the host belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bpxxxxxxx</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch associated with the specified VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bpxxxxxxx</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The zone ID of the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C860658E-68A6-46C1-AF6E-3AE7C4D3CACF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
