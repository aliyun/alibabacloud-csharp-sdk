// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster to which the instance belongs.</para>
        /// <remarks>
        /// <para> This parameter will be deprecated. We recommend that you use other parameters to ensure compatibility.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

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
        /// <para>The performance mode of the burstable instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The details of the data disk.</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyDataDisks DataDisks { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyDataDisks : TeaModel {
            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<DescribeRCInstanceAttributeResponseBodyDataDisksDataDisk> DataDisk { get; set; }
            public class DescribeRCInstanceAttributeResponseBodyDataDisksDataDisk : TeaModel {
                /// <summary>
                /// <para>The category of the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Indicates whether the data disk is released when the instance is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The data disk is released when the instance is released.</description></item>
                /// <item><description><b>false</b>: The data disk is reserved when the instance is released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>Indicates whether the data disk is encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                /// <summary>
                /// <para>The performance level of data disk. This parameter is available when the data disk is an Enterprise SSD (ESSD).</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The size of the data disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

        }

        /// <summary>
        /// <para>The attributes of the dedicated hosts.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DedicatedHostAttribute")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyDedicatedHostAttribute DedicatedHostAttribute { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyDedicatedHostAttribute : TeaModel {
            /// <summary>
            /// <para>The ID of the dedicated host.</para>
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
        /// <para>The ID of the deployment set.</para>
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
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The Elastic Compute Service (ECS) instance family.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.2xlarge</para>
        /// </summary>
        [NameInMap("EcsInstanceType")]
        [Validation(Required=false)]
        public string EcsInstanceType { get; set; }

        /// <summary>
        /// <para>The elastic IP address (EIP) associated with the instance.</para>
        /// </summary>
        [NameInMap("EipAddress")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyEipAddress EipAddress { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyEipAddress : TeaModel {
            /// <summary>
            /// <para>The EIP ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp14k3rz6cbg6zxbe****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The maximum Internet bandwidth of the EIP. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The billing method of the Internet-facing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>paybytraffic:</b> pay-by-data-transfer</description></item>
            /// <item><description><b>paybybandwidth</b>: pay-by-bandwidth</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the <b>pay-by-traffic</b> billing method is used for network usage, the maximum inbound and outbound bandwidths are used as the upper limits of bandwidths instead of guaranteed performance specifications. In scenarios in which demands exceed resource supplies, the maximum bandwidths may not be reached. If you want guaranteed bandwidths for your instance, use the <b>pay-by-bandwidth</b> billing method for network usage.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>paybytraffic</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The EIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.147.XXX.XXX</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the Jumbo Frame feature is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <para>The instance hostname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iZ2zej1n3cin51rlmby****</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

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
        /// <para>The image ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-2oqiu973jwcxe****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The private IP addresses of the instance in the classic network.</para>
        /// </summary>
        [NameInMap("InnerIpAddress")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyInnerIpAddress InnerIpAddress { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyInnerIpAddress : TeaModel {
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

        }

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
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>classic</b></description></item>
        /// <item><description><b>vpc</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The instance type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.x4.xlarge.6cm</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByBandwidth</b>: pay-by-bandwidth</description></item>
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the <b>pay-by-traffic</b> billing method is used for network usage, the maximum inbound and outbound bandwidths are used as the upper limits of bandwidths instead of guaranteed performance specifications. In scenarios in which demands exceed resource supplies, the maximum bandwidths may not be reached. If you want guaranteed bandwidths for your instance, use the <b>pay-by-bandwidth</b> billing method for network usage.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum inbound bandwidth from the Internet. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound bandwidth to the Internet. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is I/O optimized.</para>
        /// <list type="bullet">
        /// <item><description><b>optimized</b>: The instance is I/O optimized.</description></item>
        /// <item><description><b>none</b>: The instance is not I/O optimized.</description></item>
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
        /// <para>The memory capacity of the instance. Unit: MiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The reasons why the instance is locked.</para>
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeRCInstanceAttributeResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeRCInstanceAttributeResponseBodyOperationLocksLockReason : TeaModel {
                /// <summary>
                /// <para>The reason why the instance is locked. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>financial</b>: The instance is locked due to overdue payments.</description></item>
                /// <item><description><b>security</b>: The instance is locked for security purposes.</description></item>
                /// <item><description><b>recycling</b>: The instance is locked because the instance is a preemptible instance and pending to be released.</description></item>
                /// <item><description><b>dedicatedhostfinancial</b>: The instance is locked due to overdue payments for the dedicated host.</description></item>
                /// <item><description><b>refunded</b>: The instance is locked because a refund was made for the instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

            }

        }

        /// <summary>
        /// <para>The public IP address of the instance.</para>
        /// </summary>
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
        /// <para>The security groups.</para>
        /// </summary>
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
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Pending</b></description></item>
        /// <item><description><b>Running</b></description></item>
        /// <item><description><b>Starting</b></description></item>
        /// <item><description><b>Stopping</b></description></item>
        /// <item><description><b>Stopped</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the billing of the instance continues after the instance is stopped. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>KeepCharging</b>: The billing of the instance continues after the instance is stopped, and resources are retained for the instance.</description></item>
        /// <item><description><b>StopCharging</b>: The billing of the instance stops after the instance is stopped. After the instance is stopped, resources such as CPU cores, memory resources, and public IP address are released. The instance may be unable to restart if some required resources are out of stock in the current region.</description></item>
        /// <item><description><b>Not-applicable</b>: The No Fees for Stopped Instances feature is not supported for the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Not-applicable</para>
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

        /// <summary>
        /// <para>The virtual LAN (VLAN) ID of the instance.</para>
        /// <remarks>
        /// <para> This parameter will be deprecated. We recommend that you use other parameters to ensure compatibility.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public string VlanId { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) attributes of the instance.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("VpcAttributes")]
        [Validation(Required=false)]
        public DescribeRCInstanceAttributeResponseBodyVpcAttributes VpcAttributes { get; set; }
        public class DescribeRCInstanceAttributeResponseBodyVpcAttributes : TeaModel {
            /// <summary>
            /// <para>The network address translation (NAT) IP address of the instance. The NAT IP address is used by instances in different VPCs for communication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("NatIpAddress")]
            [Validation(Required=false)]
            public string NatIpAddress { get; set; }

            /// <summary>
            /// <para>The private IP addresses of the instance.</para>
            /// </summary>
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
