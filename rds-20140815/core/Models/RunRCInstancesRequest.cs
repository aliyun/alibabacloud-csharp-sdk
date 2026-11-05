// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RunRCInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ACU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gn8is</para>
        /// </summary>
        [NameInMap("AcuType")]
        [Validation(Required=false)]
        public string AcuType { get; set; }

        /// <summary>
        /// <para>The number of RDS Custom instances to create. This parameter is applicable only when you create multiple RDS Custom instances at a time.</para>
        /// <para>Valid values: <b>1</b> to <b>30</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Automatic payment is enabled. You must ensure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: Only an order is generated and no payment is deducted.<remarks>
        /// <para>If the balance of your payment method is insufficient, you can set the AutoPay parameter to false. In this case, an unpaid order is generated, and you can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you use a coupon and then downgrade the instance configuration, the amount deducted by the voucher is not refunded.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rds_ai_app&quot;:&quot;true&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the token, but you must ensure that the token is unique among different requests. The token can contain a maximum of 64 ASCII characters and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ACK Edge cluster information.</para>
        /// </summary>
        [NameInMap("CreateAckEdgeParam")]
        [Validation(Required=false)]
        public RunRCInstancesRequestCreateAckEdgeParam CreateAckEdgeParam { get; set; }
        public class RunRCInstancesRequestCreateAckEdgeParam : TeaModel {
            /// <summary>
            /// <para>The ID of the destination ACK Edge cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c463aaa89e2b84cacacfbf23c4867****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The ID of the destination edge node pool in the ACK Edge cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np47e018268fb34e2289ff4c4d22b5****</para>
            /// </summary>
            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

        }

        /// <summary>
        /// <para>A reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("CreateExtraParam")]
        [Validation(Required=false)]
        public string CreateExtraParam { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is allowed to join an ACK cluster. When this parameter is set to <b>1</b>, the created instance can be added to an ACK cluster by calling the <b>AttachRCInstances</b> API operation, which enables efficient management of containerized applications.</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CreateMode")]
        [Validation(Required=false)]
        public string CreateMode { get; set; }

        /// <summary>
        /// <para>The data cloud disks.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<RunRCInstancesRequestDataDisk> DataDisk { get; set; }
        public class RunRCInstancesRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The category of the data cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cloud_efficiency</b>: ultra disk</description></item>
            /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
            /// <item><description><b>cloud_essd</b> (default): ESSD</description></item>
            /// <item><description><b>cloud_auto</b>: premium performance disk</description></item>
            /// </list>
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
            /// <para>null</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>The mount point of the data cloud disk.</para>
            /// <remarks>
            /// <para>This parameter is applicable only to full images. You can set this parameter to the mount point of the data cloud disk in the full image, and modify the <b>DataDisk.Size</b> and <b>DataDisk.Category</b> parameters to change the category and size of the data cloud disk in the full image.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The performance level of the data cloud disk when it is an ESSD. For the performance differences of ESSD, see <a href="https://help.aliyun.com/document_detail/2859916.html">ESSD</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PL0</b></description></item>
            /// <item><description><b>PL1</b> (default)</description></item>
            /// <item><description><b>PL2</b></description></item>
            /// <item><description><b>PL3</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the data cloud disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: 20 to 32,768</description></item>
            /// <item><description>cloud_ssd: 20 to 32,768</description></item>
            /// <item><description>cloud_auto: 1 to 65,536</description></item>
            /// <item><description>cloud_essd: The valid values vary based on the <b>DataDisk.PerformanceLevel</b> parameter.<list type="bullet">
            /// <item><description>PL0: 1 to 65,536</description></item>
            /// <item><description>PL1: 20 to 65,536</description></item>
            /// <item><description>PL2: 461 to 65,536</description></item>
            /// <item><description>PL3: 1,261 to 65,536</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>If you specify the <b>DataDisk.SnapshotId</b> parameter and the size of the snapshot specified by this parameter is larger than the value of <b>DataDisk.Size</b>, the created cloud disk has the same size as the snapshot. If the snapshot size is smaller than the value of <b>DataDisk.Size</b>, the created cloud disk has the size specified by <b>DataDisk.Size</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The snapshot used to create the data cloud disk.</para>
            /// <list type="bullet">
            /// <item><description>If the size of the snapshot specified by <b>DataDisk.SnapshotId</b> is larger than the value of <b>DataDisk.Size</b>, the created cloud disk has the same size as the snapshot. If the snapshot size is smaller than the value of <b>DataDisk.Size</b>, the created cloud disk has the size specified by <b>DataDisk.Size</b>.</description></item>
            /// <item><description>Snapshots cannot be used to create elastic ephemeral disks.</description></item>
            /// <item><description>Snapshots created on or before July 15, 2013 cannot be used to create cloud disks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwka0yuh****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable release protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled</description></item>
        /// <item><description><b>false</b> (default): disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The deployment set ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-uf6670sipmph********</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The instance description. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance_Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run before creating the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the instance. The dry run checks items such as request parameters, request format, service limits, and inventory.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request and creates the instance directly after the check passes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The hostname of the instance. The hostname must be 2 to 64 characters in length.</para>
        /// <list type="bullet">
        /// <item><description>The hostname can be segmented by periods (.). Each segment can contain letters, digits, and hyphens (-).</description></item>
        /// <item><description>A period (.) or hyphen (-) cannot be used as the first or last character, and cannot be used consecutively.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testHost1</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The image ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-dsvjzw2ii8n4******</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Prepaid</b>: subscription</description></item>
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and can contain letters, Chinese characters, digits, periods (.), underscores (_), colons (:), and hyphens (-). The default value is the instance ID. When you create multiple RDS Custom instances, you can specify sequential instance names in batches. The names can contain square brackets ([]) and commas (,). For more information, see <a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/create-an-rds-custom-instance#00481f9ba381u">Create an RDS Custom instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-node-[99,1]-rchost</para>
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
        /// <para>null</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth for Custom for SQL Server. Unit: Mbit/s.</para>
        /// <para>Valid values: 0 to 1024. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>A reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
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
        /// <para>The network-related attribute parameters.</para>
        /// </summary>
        [NameInMap("NetworkOptions")]
        [Validation(Required=false)]
        public RunRCInstancesRequestNetworkOptions NetworkOptions { get; set; }
        public class RunRCInstancesRequestNetworkOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the Jumbo Frame feature for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: disables the Jumbo Frame feature. The maximum transmission unit (MTU) of all ENIs (including the primary ENI and secondary ENIs) on the instance is set to 1500.</description></item>
            /// <item><description>true: enables the Jumbo Frame feature. The MTU of all ENIs (including the primary ENI and secondary ENIs) on the instance is set to 8500.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <para>Note: Only specific instance types of the eighth generation and later support the Jumbo Frame feature. For more information, see ECS instance MTU.</para>
            /// </summary>
            [NameInMap("EnableJumboFrame")]
            [Validation(Required=false)]
            public bool? EnableJumboFrame { get; set; }

        }

        /// <summary>
        /// <para>The password of the instance account. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include: <c>()~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestRDS123!</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the password preset in the image. If you specify this parameter, you must leave the Password parameter empty and ensure that a password is preset in the image. Default value: false.</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

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
        /// <para>The unit of the billing duration for the subscription billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance. When you assign a private IP address to a VPC-connected ECS instance, you must select an available IP address from the CIDR block of the vSwitch specified by VSwitchId.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.1.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72329885****</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
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
        /// <para>The time-based elastic rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rule&quot;:[{&quot;beginTime&quot;:&quot;09:00&quot;,&quot;endTime&quot;:&quot;17:00&quot;,&quot;acu&quot;:4}]}</para>
        /// </summary>
        [NameInMap("ScheduledRule")]
        [Validation(Required=false)]
        public string ScheduledRule { get; set; }

        /// <summary>
        /// <para>A reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the instance belongs. Instances in the same security group can access each other. The maximum number of instances that a security group can contain depends on the security group type. For more information, see the &quot;Security groups&quot; section in <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// <remarks>
        /// <para>The SecurityGroupId parameter determines the network type of the instance. For example, if the network type of the specified security group is VPC, the instance is a VPC-connected instance and the VSwitchId parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-uf6av412xaxixu******</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The security groups to which the instance is added. You can add the instance to up to 10 security groups. Note: You cannot specify both SecurityGroupId and SecurityGroupIds.N at the same time.</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The bidding policy for the pay-as-you-go instance. This parameter takes effect only when the <b>InstanceChargeType</b> parameter is set to <b>PostPaid</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NoSpot</b>: regular pay-as-you-go instance</description></item>
        /// <item><description><b>SpotAsPriceGo</b>: system automatically bids based on the current market price</description></item>
        /// </list>
        /// <para>Default value: <b>NoSpot</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The form of RDS Custom. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>eni</b>: dual ENI</description></item>
        /// <item><description><b>edge</b>: edge node pool</description></item>
        /// <item><description><b>share</b>: VPC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>share</para>
        /// </summary>
        [NameInMap("SupportCase")]
        [Validation(Required=false)]
        public string SupportCase { get; set; }

        /// <summary>
        /// <para>The system cloud disk.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public RunRCInstancesRequestSystemDisk SystemDisk { get; set; }
        public class RunRCInstancesRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The category of the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cloud_efficiency</b>: ultra disk</description></item>
            /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
            /// <item><description><b>cloud_essd</b> (default): ESSD</description></item>
            /// <item><description><b>cloud_auto</b>: premium performance disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level of the system cloud disk when it is an ESSD. For the performance differences of ESSD, see <a href="https://help.aliyun.com/document_detail/2859916.html">ESSD</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PL0</b></description></item>
            /// <item><description><b>PL1</b> (default)</description></item>
            /// <item><description><b>PL2</b></description></item>
            /// <item><description><b>PL3</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GiB. The value must be greater than or equal to the size of the image specified by the <b>ImageId</b> parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cloud_efficiency</b>: 20 to 2048</description></item>
            /// <item><description><b>cloud_ssd</b>: 20 to 2048</description></item>
            /// <item><description><b>cloud_auto</b>: 1 to 2048</description></item>
            /// <item><description><b>cloud_essd</b>: The valid values vary based on the <b>SystemDisk.PerformanceLevel</b> parameter.<list type="bullet">
            /// <item><description>PL0: 1 to 2048</description></item>
            /// <item><description>PL1: 20 to 2048</description></item>
            /// <item><description>PL2: 461 to 2048</description></item>
            /// <item><description>PL3: 1,261 to 2048</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
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
        public List<RunRCInstancesRequestTag> Tag { get; set; }
        public class RunRCInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can create up to N tag keys at a time. Valid values of N: <b>1</b> to <b>20</b>. Empty strings are not allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value that corresponds to the tag key. You can create up to N tag values at a time. Valid values of N: <b>1</b> to <b>20</b>. Empty strings are allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Testvalue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance user data. The raw data can be up to 32 KB in size.</para>
        /// <para>Do not pass confidential information such as passwords and private keys in plaintext. If you must pass such information, encrypt and use Base64 encoding before transmission, and then perform decryption and use it inside the instance. The following example shows how to transform a script to a Base64 character string:</para>
        /// <pre><c>echo -n \\&quot;#!/bin/sh
        /// echo &quot;Hello World&quot;\\&quot; | base64 -w 0
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>IyEvYmluL3NoCmVjaG8gIkhlbGxvIFdvcmxkLiBUaGUgdGltZSBpcyBub3cgJChkYXRlIC1SKSIhIHwgdGVlIC9yb290L3VzZXJkYXRhX3Rlc3QudHh0</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>Specifies whether the custom data is encoded in Base64.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UserDataInBase64")]
        [Validation(Required=false)]
        public bool? UserDataInBase64 { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the target instance. If you create a VPC-connected RDS Custom instance, you must specify a vSwitch ID, and the security group and the vSwitch must belong to the same VPC.</para>
        /// <remarks>
        /// <para>If you configure the VSwitchId parameter, the ZoneId parameter must be set to the zone where the vSwitch resides. You can also leave the ZoneId parameter empty, and the system automatically selects the zone where the specified vSwitch resides.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2vcd61ngm890sk****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the DescribeZones operation to query the zone list.</para>
        /// <remarks>
        /// <para>If you specify the VSwitchId parameter, the ZoneId parameter must be set to the zone where the vSwitch resides. You can also leave the ZoneId parameter empty, and the system automatically selects the zone where the specified vSwitch resides.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
