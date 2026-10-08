// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateRCNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The number of RDS Custom instances to create. This parameter is applicable only to batch creation of RDS Custom instances.</para>
        /// <para>Valid values: <b>1</b> to <b>5</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Automatic payment is enabled. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: Only an order is generated. No payment is made.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is true. If your payment method has an insufficient balance, set AutoPay to false. In this case, an unpaid order is generated. You can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter is valid only when you create subscription instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you purchase on a monthly basis, the auto-renewal epoch is 1 month.</description></item>
        /// <item><description>If you purchase on a yearly basis, the auto-renewal epoch is 1 year.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the RDS Custom container cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c463aaa89e2b84cacacfbf23c4867****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the instance to join an ACK cluster. If this parameter settings is set to <b>1</b>, the created instance can be added to an ACK cluster for efficient container application management.</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Yes.</description></item>
        /// <item><description><b>0</b> (default): No.</description></item>
        /// </list>
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
        public List<CreateRCNodePoolRequestDataDisk> DataDisk { get; set; }
        public class CreateRCNodePoolRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The type of the data cloud disk. Only <b>cloud_essd</b> (ESSD cloud disk) is supported. For more information about standard SSDs and other cloud disk types, see the related documentation.</para>
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
            /// <para>Specifies whether to encrypt the data cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the ESSD cloud disk. For standard SSDs and other cloud disk types, this parameter is not applicable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PL0</b>: A single cloud disk can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description><b>PL1</b>: A single cloud disk can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description><b>PL2</b>: A single cloud disk can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description><b>PL3</b>: A single cloud disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the data cloud disk. Unit: GiB. Valid values: 20 to 65536.</para>
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
        /// <para>ds-uf6c8qerk019bj1l****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The instance description. The description must be 2 to 256 characters in length and can contain letters and Chinese characters. The description cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the instance. The system checks the request parameters, request format, service limits, and available stock.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the check, the instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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
        /// <para>The image ID used by the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-dsvjzw2ii8n4fvr6de</para>
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
        /// <para>PrePaid</para>
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
        /// <para>The instance type. For the instance types supported by RDS Custom instances, see <a href="https://help.aliyun.com/document_detail/2844823.html">RDS Custom instance types</a>.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The name of the key pair. Only a single name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dell5502</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The name of the node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNodePool</para>
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
        /// <para>The subscription duration of the resource. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration for the subscription billable methods. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The security group ID. You can specify an existing security group ID. If the security group does not exist, automatic creation of a security group is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-m5e9abdu1rtxa12b****</para>
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
        /// <para>The supported scenario. This parameter is required when <b>createMode</b> is set to <b>1</b>. Currently, only <b>edge</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edge</para>
        /// </summary>
        [NameInMap("SupportCase")]
        [Validation(Required=false)]
        public string SupportCase { get; set; }

        /// <summary>
        /// <para>The system cloud disk specifications.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateRCNodePoolRequestSystemDisk SystemDisk { get; set; }
        public class CreateRCNodePoolRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The category of the system cloud disk. Only <b>cloud_essd</b> (Enterprise SSD) is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the ESSD cloud disk. For standard SSDs and other cloud disk types, this parameter is not applicable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PL0</b>: A single cloud disk can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description><b>PL1</b>: A single cloud disk can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description><b>PL2</b>: A single cloud disk can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description><b>PL3</b>: A single cloud disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GiB. Valid values: 20 to 2048.</para>
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
        public List<CreateRCNodePoolRequestTag> Tag { get; set; }
        public class CreateRCNodePoolRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can create up to N tag keys at a time. Valid values of N: <b>1 to 20</b>. The tag key cannot be an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value that corresponds to the tag key. You can create up to N tag values at a time. Valid values of N: <b>1</b> to <b>20</b>. The tag value can be an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>A reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <remarks>
        /// <para>The vSwitch must be in the same zone as the ApsaraDB RDS instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance.</para>
        /// <remarks>
        /// <para>If you specify the VSwitchId parameter, the ZoneId parameter must match the zone of the specified vSwitch. You can also leave this parameter empty, and the system automatically selects the zone of the specified vSwitch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
