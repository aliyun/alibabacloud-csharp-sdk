// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstancesResponseBody : TeaModel {
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The instance information.</para>
        /// </summary>
        [NameInMap("RCInstances")]
        [Validation(Required=false)]
        public List<DescribeRCInstancesResponseBodyRCInstances> RCInstances { get; set; }
        public class DescribeRCInstancesResponseBodyRCInstances : TeaModel {
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testrdscustom</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance can be added to an ACK cluster. If the parameter settings for this field is <b>1</b>, the created instance can be added to an ACK cluster by calling the <b>AttachRCInstances</b> API operation, which enables efficient management of container applications.</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Yes.</description></item>
            /// <item><description><b>0</b> (default): No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CreateMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            /// <summary>
            /// <para>The database type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_custom</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The deployment set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp14k1xvolvsy4z3****</para>
            /// </summary>
            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testHostName</para>
            /// </summary>
            [NameInMap("EcsHostName")]
            [Validation(Required=false)]
            public string EcsHostName { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC+0.</para>
            /// <remarks>
            /// <para>The expiration time displayed on the console is UTC+8.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-02T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The task creation time (GMT).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-22 07:56:53.0</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The host IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            /// <summary>
            /// <para>The host name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zeaiz4g9u23f40m****</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20250117.vhd</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PrePaid</b>: subscription.</description></item>
            /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze704f*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-node</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2844823.html">RDS Custom instance type list</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.x2.xlarge.6cm</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The instance family.</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2844823.html">RDS Custom instance type list</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x.6cm</para>
            /// </summary>
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16384</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The node type. If the value <b>rds_vnode</b> is returned, the node is a container node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_vnode</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CentOS  7.4 64 位</para>
            /// </summary>
            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            /// <summary>
            /// <para>The public IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.89.XX.XX</para>
            /// </summary>
            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

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
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2vcbcivwfxiozhtp****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The bidding strategy for pay-as-you-go instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NoSpot</b>: A regular pay-as-you-go instance.</description></item>
            /// <item><description><b>SpotAsPriceGo</b>: The system automatically bids, following the current market price.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-12-10T04:04Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: Being created.</description></item>
            /// <item><description><b>Running</b>: Running.</description></item>
            /// <item><description><b>Starting</b>: Being started.</description></item>
            /// <item><description><b>Stopping</b>: Being stopped.</description></item>
            /// <item><description><b>Stopped</b>: Stopped.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The instance status returned by this operation may be delayed. If the value differs from the value returned by the <b>DescribeRCInstanceAttribute</b> operation, the value returned by <b>DescribeRCInstanceAttribute</b> prevails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StoppedMode")]
            [Validation(Required=false)]
            public string StoppedMode { get; set; }

            /// <summary>
            /// <para>The details of the instances and tags.</para>
            /// </summary>
            [NameInMap("TagResources")]
            [Validation(Required=false)]
            public List<DescribeRCInstancesResponseBodyRCInstancesTagResources> TagResources { get; set; }
            public class DescribeRCInstancesResponseBodyRCInstancesTagResources : TeaModel {
                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rc-t8q22a87745hf8******</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// <list type="bullet">
                /// <item><description><c>ALIYUN::RDS::INSTANCE</c>: ApsaraDB RDS instance.</description></item>
                /// <item><description><c>ALIYUN::RDS::CUSTOM</c>: RDS Custom instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::RDS::CUSTOM</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testRC</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test01</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The tag details.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeRCInstancesResponseBodyRCInstancesTags> Tags { get; set; }
            public class DescribeRCInstancesResponseBodyRCInstancesTags : TeaModel {
                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rc-t8q22a87745hf8******</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// <list type="bullet">
                /// <item><description><c>ALIYUN::RDS::INSTANCE</c>: ApsaraDB RDS instance.</description></item>
                /// <item><description><c>ALIYUN::RDS::CUSTOM</c>: RDS Custom instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::RDS::CUSTOM</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testRC</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test01</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The VPC attributes.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("VpcAttributes")]
            [Validation(Required=false)]
            public DescribeRCInstancesResponseBodyRCInstancesVpcAttributes VpcAttributes { get; set; }
            public class DescribeRCInstancesResponseBodyRCInstancesVpcAttributes : TeaModel {
                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("NatIpAddress")]
                [Validation(Required=false)]
                public string NatIpAddress { get; set; }

                /// <summary>
                /// <para>The private IP address.</para>
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public List<string> PrivateIpAddress { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1nb3pv03878tgnj****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6f7l4fg90****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6f7l4fg90****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9DD55F4-1A5F-48CA-BA57-DFB3CA8C4C34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
