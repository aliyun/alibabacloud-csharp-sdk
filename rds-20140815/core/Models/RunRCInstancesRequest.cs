// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RunRCInstancesRequest : TeaModel {
        /// <summary>
        /// <para>ACU type</para>
        /// 
        /// <b>Example:</b>
        /// <para>gn8is</para>
        /// </summary>
        [NameInMap("AcuType")]
        [Validation(Required=false)]
        public string AcuType { get; set; }

        /// <summary>
        /// <para>The number of RDS Custom instances that you want to create. The parameter is available if you want to create multiple RDS Custom instances at a time.</para>
        /// <para>Valid values: <b>1</b> to <b>10</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the automatic payment feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): enables the feature. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: disables the feature. An unpaid order is generated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If your account balance is insufficient, you can set the AutoPay parameter to false. In this case, an unpaid order is generated. You can complete the payment in the Expenses and Costs console.</para>
        /// </remarks>
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
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <item><description><b>true</b> (default): Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you use a coupon and later decrease the quota, the amount offset by the coupon will not be refunded.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

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
        /// <para>Information about the ACK Edge cluster.</para>
        /// </summary>
        [NameInMap("CreateAckEdgeParam")]
        [Validation(Required=false)]
        public RunRCInstancesRequestCreateAckEdgeParam CreateAckEdgeParam { get; set; }
        public class RunRCInstancesRequestCreateAckEdgeParam : TeaModel {
            /// <summary>
            /// <para>The ID of the target ACK Edge cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c463aaa89e2b84cacacfbf23c4867****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The ID of the target edge node pool in the ACK Edge cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np47e018268fb34e2289ff4c4d22b5****</para>
            /// </summary>
            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

        }

        /// <summary>
        /// <para>Reserved parameter. Not supported currently.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("CreateExtraParam")]
        [Validation(Required=false)]
        public string CreateExtraParam { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance can be added to an ACK cluster. When this parameter is set to <b>1</b>, the created instance can be added to an ACK cluster by invoking the <b>AttachRCInstances</b> API operation, enabling efficient management of container applications.</para>
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
        /// <para>The information about the data disks.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<RunRCInstancesRequestDataDisk> DataDisk { get; set; }
        public class RunRCInstancesRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The type of the data disk. Set the value to <b>cloud_essd</b>, which indicates Enterprise SSDs (ESSDs).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The reserved parameter. This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>The mount target of the data disk.</para>
            /// <remarks>
            /// <para>This parameter is used only in the full image (entire machine image) scenario. You can set this parameter to the mount target of the data disk in the full image and modify the corresponding <b>DataDisk.Size</b> and <b>DataDisk.Category</b> parameters to change the disk category and size of the data disk in the full image.</para>
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
            /// <para>The reserved parameter. This parameter is not supported.</para>
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
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The snapshot used to create the data disk.</para>
            /// <list type="bullet">
            /// <item><description>If the snapshot size corresponding to <b>DataDisk.SnapshotId</b> is greater than the value of <b>DataDisk.Size</b>, the created disk size matches the snapshot size. If the snapshot size is smaller than the value of <b>DataDisk.Size</b>, the created disk size equals the value of <b>DataDisk.Size</b>.</description></item>
            /// <item><description>Creating an elastic ephemeral disk from a snapshot is not supported.</description></item>
            /// <item><description>Snapshots created on or before July 15, 2013 cannot be used to create disks.</description></item>
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
        /// <para>Specifies whether to enable release protection. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled  </description></item>
        /// <item><description><b>false</b> (default): Disabled</description></item>
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
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, service limits, and insufficient inventory errors.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, the instance is directly created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Hostname of the instance (2–64 characters).  </para>
        /// <list type="bullet">
        /// <item><description>Multiple segments separated by periods (.) are supported. Each segment can contain uppercase and lowercase English letters, digits, and hyphens (-).  </description></item>
        /// <item><description>A period (.) or hyphen (-) cannot appear at the beginning or end of a segment, nor can two periods or hyphens appear consecutively.</description></item>
        /// </list>
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
        /// <para>image-dsvjzw2ii8n4******</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Set the value to <b>Prepaid</b>, which indicates the subscription billing method.</para>
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
        /// <para>rc-node-[99,1]-rchost</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. For more information about the instance types that are supported by RDS Custom instances, see <a href="https://help.aliyun.com/document_detail/2844823.html">Instance types for RDS Custom instances</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.i8.large.2cm</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The name of the AccessKey pair. You can specify only one name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dell5502</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("NetworkOptions")]
        [Validation(Required=false)]
        public RunRCInstancesRequestNetworkOptions NetworkOptions { get; set; }
        public class RunRCInstancesRequestNetworkOptions : TeaModel {
            [NameInMap("EnableJumboFrame")]
            [Validation(Required=false)]
            public bool? EnableJumboFrame { get; set; }

        }

        /// <summary>
        /// <para>The password of the account that is used to log on to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestRDS123!</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the password preset in the image. When this parameter is used, the Password parameter must be empty, and you must ensure that the selected image has a password already configured. Default value: false.</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values:</para>
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
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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
        /// <para>Scheduled elasticity rule</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rule&quot;:[{&quot;beginTime&quot;:&quot;09:00&quot;,&quot;endTime&quot;:&quot;17:00&quot;,&quot;acu&quot;:4}]}</para>
        /// </summary>
        [NameInMap("ScheduledRule")]
        [Validation(Required=false)]
        public string ScheduledRule { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which you want to add the new instance. Instances in the same security group can communicate with each other. The maximum number of instances allowed in a security group varies based on the type of the security group. For more information, see the &quot;Security group limits&quot; section in <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// <remarks>
        /// <para> The network type of the instance is determined by the security group specified by the SecurityGroupId parameter. For example, if the network type of the specified security group is VPC, the instance is a VPC-type instance. In this case, you must specify the VSwitchId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-uf6av412xaxixu******</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The spot strategy for pay-as-you-go instances. This parameter takes effect only when the <b>InstanceChargeType</b> parameter is set to <b>PostPaid</b>. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>NoSpot</b>: Normal pay-as-you-go instance.  </description></item>
        /// <item><description><b>SpotAsPriceGo</b>: The system automatically bids based on the current market price.</description></item>
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
        /// <para>The deployment type of RDS Custom. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>eni</b>: Dual network interface cards.</description></item>
        /// <item><description><b>edge</b>: Point of presence (POP) node pool.</description></item>
        /// <item><description><b>share</b>: VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>share</para>
        /// </summary>
        [NameInMap("SupportCase")]
        [Validation(Required=false)]
        public string SupportCase { get; set; }

        /// <summary>
        /// <para>The specification of the system disk.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public RunRCInstancesRequestSystemDisk SystemDisk { get; set; }
        public class RunRCInstancesRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The type of the system disk. Set the value to <b>cloud_essd</b>, which indicates ESSDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Performance level when the system disk is an enterprise SSD (ESSD). For details about performance differences among ESSD types, see <a href="https://help.aliyun.com/document_detail/2859916.html">enterprise SSD (ESSD)</a>. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>PL0</b>  </description></item>
            /// <item><description><b>PL1</b> (default)  </description></item>
            /// <item><description><b>PL2</b>  </description></item>
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
            /// <para>The size of the system disk. Unit: GiB. Only performance level 1 (PL1) ESSDs are supported. Valid values: 20 to 2048.</para>
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
            /// <para>The tag key. You can create up to N tag keys at the same time, where N ranges from <b>1 to 20</b>. Empty strings are not allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value corresponding to the tag key. You can create up to N tag values at the same time, where N ranges from <b>1 to 20</b>. Empty strings are allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Testvalue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance user data. The raw data can be up to 32 KB in size.  </para>
        /// <para>Do not pass sensitive information, such as passwords and private keys, in plaintext. If you must pass such information, encrypt it first, encode it in Base64, and then transmit it. Decrypt and use it inside the instance. The following is an example of converting a script into a Base64-encoded string:  </para>
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
        /// <para>Specifies whether custom data is Base64-encoded.  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.  </description></item>
        /// <item><description><b>false</b> (default): No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UserDataInBase64")]
        [Validation(Required=false)]
        public bool? UserDataInBase64 { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the instance. You must specify this parameter when you create an instance of the virtual private cloud (VPC) type. The specified vSwitch and security group must belong to the same VPC.</para>
        /// <remarks>
        /// <para> If you specify the VSwitchId parameter, the zone specified by the ZoneId parameter must be the same as the zone in which the specified vSwitch resides. You can leave the ZoneId parameter empty. In this case, the system uses the zone in which the specified vSwitch resides.</para>
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
        /// <para>The zone ID of the instance. You can call the DescribeZones operation to query the zone IDs.</para>
        /// <remarks>
        /// <para> If you specify the VSwitchId parameter, the zone specified by the ZoneId parameter must be the same as the zone in which the specified vSwitch resides. You can leave the ZoneId parameter empty. In this case, the system uses the zone in which the specified vSwitch resides.</para>
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
