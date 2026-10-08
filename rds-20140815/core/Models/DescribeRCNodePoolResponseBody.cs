// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCNodePoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node pool information.</para>
        /// </summary>
        [NameInMap("NodePoolList")]
        [Validation(Required=false)]
        public List<DescribeRCNodePoolResponseBodyNodePoolList> NodePoolList { get; set; }
        public class DescribeRCNodePoolResponseBodyNodePoolList : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic payment is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default): Automatic payment is enabled. Make sure that your account balance is sufficient.</description></item>
            /// <item><description><b>false</b>: Only an order is generated. No payment is made.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

            /// <summary>
            /// <para>Indicates whether auto-renewal is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default): Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The ID of the RDS Custom container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c463aaa89e2b84cacacfbf23c4867****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is allowed to join an ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreateMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            /// <summary>
            /// <para>The list of data cloud disks.</para>
            /// </summary>
            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<DescribeRCNodePoolResponseBodyNodePoolListDataDisk> DataDisk { get; set; }
            public class DescribeRCNodePoolResponseBodyNodePoolListDataDisk : TeaModel {
                /// <summary>
                /// <para>The type of the data cloud disk. Only <b>cloud_essd</b> (ESSD cloud disk) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>A reserved parameter. This parameter is not supported.</para>
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
                /// <item><description><b>false</b> (default): Not encrypted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                /// <summary>
                /// <para>The performance level (PL) of the standard SSD. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PL0</b>: A maximum of 10,000 random read/write IOPS per cloud disk.</description></item>
                /// <item><description><b>PL1</b>: A maximum of 50,000 random read/write IOPS per cloud disk.</description></item>
                /// <item><description><b>PL2</b>: A maximum of 100,000 random read/write IOPS per cloud disk.</description></item>
                /// <item><description><b>PL3</b>: A maximum of 1,000,000 random read/write IOPS per cloud disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL0</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The size of the data cloud disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>The deployment set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp18ukv66rlyuffv****</para>
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
            /// <para>The hostname of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testHost1</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The ID of the image used by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image-dsvjzw2ii8n4fvr****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Prepaid</b>: subscription.</description></item>
            /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

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
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.i8.large.2cm</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>A reserved parameter. This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>A reserved parameter. This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>A reserved parameter. This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public string IoOptimized { get; set; }

            /// <summary>
            /// <para>The name of the key pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dell5502</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The node pool ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np31da1b38983f4511b490fc62108a****</para>
            /// </summary>
            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

            /// <summary>
            /// <para>The name of the node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np31da1b38983f4511b490fc62108a****</para>
            /// </summary>
            [NameInMap("NodePoolName")]
            [Validation(Required=false)]
            public string NodePoolName { get; set; }

            /// <summary>
            /// <para>The password of the root account of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testPassword</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The subscription duration of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription billable methods duration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Year</b>: year.</description></item>
            /// <item><description><b>Month</b> (default): month.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Year</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmy****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>A reserved parameter. This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-uf6av412xaxixuez****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>A reserved parameter. This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The system cloud disk specifications.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public DescribeRCNodePoolResponseBodyNodePoolListSystemDisk SystemDisk { get; set; }
            public class DescribeRCNodePoolResponseBodyNodePoolListSystemDisk : TeaModel {
                /// <summary>
                /// <para>The type of the system cloud disk. Only <b>cloud_essd</b> (Enterprise SSD (ESSD)) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The performance level (PL) of the standard SSD. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PL0</b>: A maximum of 10,000 random read/write IOPS per cloud disk.</description></item>
                /// <item><description><b>PL1</b>: A maximum of 50,000 random read/write IOPS per cloud disk.</description></item>
                /// <item><description><b>PL2</b>: A maximum of 100,000 random read/write IOPS per cloud disk.</description></item>
                /// <item><description><b>PL3</b>: A maximum of 1,000,000 random read/write IOPS per cloud disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The size of the system cloud disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeRCNodePoolResponseBodyNodePoolListTag> Tag { get; set; }
            public class DescribeRCNodePoolResponseBodyNodePoolListTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Testkey1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value that corresponds to the tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Testvalue1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-zm0qvgv3sm3sjzbkr****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C816A4BF-A6EC-4722-95F9-2055859CCFD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
