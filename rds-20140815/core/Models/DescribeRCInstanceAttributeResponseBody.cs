// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the cluster to which the instance belongs.</para>
        /// <remarks>
        /// <para>This parameter will be deprecated. For better compatibility, use other parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The number of vCPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance has joined an ACK cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Yes.</description></item>
        /// <item><description><b>0</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CreateMode")]
        [Validation(Required=false)]
        public int? CreateMode { get; set; }

        /// <summary>
        /// <para>The time when the instance was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-22T06:52:23Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The running mode of the burstable instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyDataDisks DataDisks { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyDataDisks : TeaModel {
            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<DescribeRCInstanceAttributeResponseBodyDataDisksDataDisk> DataDisk { get; set; }
            public class DescribeRCInstanceAttributeResponseBodyDataDisksDataDisk : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/dev/xvdb</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rcds-bp18um4r4f2fve24**</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

            }

        }

        /// <summary>
        /// <para>The database type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mssql</b>: SQL Server</description></item>
        /// <item><description><b>mysql</b>: MySQL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The dedicated host attributes.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DedicatedHostAttribute")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyDedicatedHostAttribute DedicatedHostAttribute { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyDedicatedHostAttribute : TeaModel {
            /// <summary>
            /// <para>The dedicated host ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            /// <summary>
            /// <para>The name of the dedicated host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("DedicatedHostName")]
            [Validation(Required=false)]
            public string DedicatedHostName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the release protection feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The deployment set ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-uf6c8qerk019bj1l****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The instance description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The corresponding ECS instance family.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.2xlarge</para>
        /// </summary>
        [NameInMap("EcsInstanceType")]
        [Validation(Required=false)]
        public string EcsInstanceType { get; set; }

        /// <summary>
        /// <para>The elastic IP address (EIP) binding information.</para>
        /// </summary>
        [NameInMap("EipAddress")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyEipAddress EipAddress { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyEipAddress : TeaModel {
            /// <summary>
            /// <para>The ID of the EIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp14k3rz6cbg6zxbe****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The Internet bandwidth throttling of the EIP. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The billing method for the public network instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>paybytraffic</b>: pay-by-data-transfer.</description></item>
            /// <item><description><b>paybybandwidth</b>: pay-by-bandwidth.<remarks>
            /// <para>In <b>pay-by-data-transfer</b> mode, the peak inbound and outbound bandwidths are both bandwidth upper limits and are not guaranteed. When resource contention occurs, the peak bandwidth may be throttled. If your business requires guaranteed bandwidth, use the <b>pay-by-bandwidth</b> mode.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>paybytraffic</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The EIP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.147.XXX.XXX</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the Jumbo frame feature is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableJumboFrame")]
        [Validation(Required=false)]
        public bool? EnableJumboFrame { get; set; }

        /// <summary>
        /// <para>The expiration time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-10T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NVIDIA V100</para>
        /// </summary>
        [NameInMap("GpuTypes")]
        [Validation(Required=false)]
        public string GpuTypes { get; set; }

        /// <summary>
        /// <para>The hostname of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iZ2zej1n3cin51rlmby****</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The host storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dhg_cloud_ssd</b>: ESSD cloud disk.</description></item>
        /// <item><description><b>dhg_local_ssd</b>: local standard SSD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dhg_cloud_ssd</para>
        /// </summary>
        [NameInMap("HostType")]
        [Validation(Required=false)]
        public string HostType { get; set; }

        /// <summary>
        /// <para>The ID of the image that the instance is running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-2oqiu973jwcxe****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("InnerIpAddress")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyInnerIpAddress InnerIpAddress { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyInnerIpAddress : TeaModel {
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

        }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-dh2jf9n6j4s14926****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The network type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>classic</b>: classic network.</description></item>
        /// <item><description><b>vpc</b>: VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.x4.xlarge.6cm</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The billing method for Internet bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByBandwidth</b>: pay-by-bandwidth.</description></item>
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer.</description></item>
        /// </list>
        /// <remarks>
        /// <para>In the <b>pay-by-data-transfer</b> mode, the peak inbound and outbound bandwidths are both bandwidth upper limits and are not guaranteed. When resource contention occurs, the peak bandwidth may be throttled. If your business requires guaranteed bandwidth, use the <b>pay-by-bandwidth</b> mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum inbound Internet bandwidth. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound Internet bandwidth. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is an I/O optimized instance.</para>
        /// <list type="bullet">
        /// <item><description><b>optimized</b>: I/O optimization enabled.</description></item>
        /// <item><description><b>none</b>: not I/O optimized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_01</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: MiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The node type. If <b>rds_vnode</b> is returned, the node is a container node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_vnode</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeRCInstanceAttributeResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeRCInstanceAttributeResponseBodyOperationLocksLockReason : TeaModel {
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

            }

        }

        [NameInMap("PublicIpAddress")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyPublicIpAddress PublicIpAddress { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyPublicIpAddress : TeaModel {
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

        }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA2D4F34-01A7-46EB-A339-D80882135206</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aeky6z354ks****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodySecurityGroupIds SecurityGroupIds { get; set; }
        public class DescribeRCInstanceAttributeResponseBodySecurityGroupIds : TeaModel {
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public List<string> SecurityGroupId { get; set; }

        }

        /// <summary>
        /// <para>The serial number of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b076f6ff-46d1-4234-a608-4e951ed6****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The bidding strategy for the pay-as-you-go instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NoSpot</b>: a regular pay-as-you-go instance.</description></item>
        /// <item><description><b>SpotAsPriceGo</b>: the system automatically bids, following the current market price.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Pending</b>: being created.</description></item>
        /// <item><description><b>Running</b>: running.</description></item>
        /// <item><description><b>Starting</b>: starting.</description></item>
        /// <item><description><b>Stopping</b>: stopping.</description></item>
        /// <item><description><b>Stopped</b>: stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance continues to be billed after it is stopped. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>KeepCharging</b>: The instance continues to be billed after it is stopped. Inventory resources are reserved for the instance.</description></item>
        /// <item><description><b>StopCharging</b>: The instance is not billed after it is stopped. After the instance is stopped, its resources such as vCPUs, memory, and public IP addresses are released. Whether the instance can be restarted depends on the available resource inventory in the current region.</description></item>
        /// <item><description><b>Not-applicable</b>: The instance does not support the No Fees for Stopped Instances feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Not-applicable</para>
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

        /// <summary>
        /// <para>The system cloud disk specifications.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodySystemDisk SystemDisk { get; set; }
        public class DescribeRCInstanceAttributeResponseBodySystemDisk : TeaModel {
            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>Indicates whether the cloud disk is encrypted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Encrypted.</description></item>
            /// <item><description><b>false</b>: Not encrypted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The type of the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cloud_efficiency</b>: ultra cloud disk.</description></item>
            /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
            /// <item><description><b>cloud_essd</b>: ESSD.</description></item>
            /// <item><description><b>cloud_auto</b>: premium performance disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the system cloud disk when it is an ESSD. When the system cloud disk is a standard SSD, this parameter is not returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PL0</b></description></item>
            /// <item><description><b>PL1</b></description></item>
            /// <item><description><b>PL2</b></description></item>
            /// <item><description><b>PL3</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

        }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyTags Tags { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeRCInstanceAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeRCInstanceAttributeResponseBodyTagsTag : TeaModel {
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The custom data of the instance, in Base64-encoded format.</para>
        /// <remarks>
        /// <para>If the instance does not have custom data, an empty string is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>IyEvYmluL3NoCmVjaG8gXCJIZWxsbyBXb3JsZC4gVGhlIHRpbWUgaXMgbm93ICQoZGF0ZSAtUikhXCIgfCB0ZWUgL3Jvb3QvdXNlcmRhdGFfdGVzdDA2MjB0d28udHh0</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the instance.</para>
        /// <remarks>
        /// <para>This parameter will be deprecated. For better compatibility, use other parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public string VlanId { get; set; }

        /// <summary>
        /// <para>The VPC attributes.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("VpcAttributes")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyVpcAttributes VpcAttributes { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyVpcAttributes : TeaModel {
            /// <summary>
            /// <para>The IP address of the cloud service, which is used for network communication between VPC-connected cloud services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("NatIpAddress")]
            [Validation(Required=false)]
            public string NatIpAddress { get; set; }

            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public DescribeRCInstanceAttributeResponseBodyVpcAttributesPrivateIpAddress PrivateIpAddress { get; set; }
            public class DescribeRCInstanceAttributeResponseBodyVpcAttributesPrivateIpAddress : TeaModel {
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public List<string> IpAddress { get; set; }

            }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1nt15muovrc5qdj****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zeu747v4765aw2id****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
