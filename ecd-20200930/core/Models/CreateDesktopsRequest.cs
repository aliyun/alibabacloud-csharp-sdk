// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The number of cloud desktops to create. Valid values: 1 to 300. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The ID of the application control policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bwr-245d4e0e6b7d42f5afa97eb3fbc7e488</para>
        /// </summary>
        [NameInMap("AppRuleId")]
        [Validation(Required=false)]
        public string AppRuleId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the cloud desktops. This parameter is valid only when <c>ChargeType</c> is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The bundle ID. If you do not specify this parameter, you must use the <c>DesktopAttachment</c> parameter to configure the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-je9hani001wfn****</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// <para>An array of bundle objects. Use this parameter to create cloud desktops from one or more bundles in a single call.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("BundleModels")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestBundleModels> BundleModels { get; set; }
        public class CreateDesktopsRequestBundleModels : TeaModel {
            /// <summary>
            /// <para>The number of cloud desktops to create. Valid values: 1 to 300. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// <para>The bundle ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b-je9hani001wfn****</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The name of the cloud desktop. The name must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description><para>The name must be 1 to 64 characters in length.</para>
            /// </description></item>
            /// <item><description><para>The name must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
            /// <item><description><para>The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DemoComputer02</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The list of end user IDs to whom the cloud desktops are assigned.</para>
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <para>The custom hostname of the cloud desktop. This parameter is supported only for Windows cloud desktops that are in an AD office network.</para>
            /// <para>The hostname must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description><para>The hostname must be 2 to 15 characters in length.</para>
            /// </description></item>
            /// <item><description><para>The hostname can contain letters, digits, and hyphens (-). The hostname cannot start or end with a hyphen, contain consecutive hyphens, or consist of only digits.</para>
            /// </description></item>
            /// </list>
            /// <para>If you create multiple cloud desktops, you can use the <c>name_prefix[begin_number,bits]name_suffix</c> format to specify sequential hostnames for the cloud desktops. For example, if you set the <c>Hostname</c> parameter to <c>ecd-[1,4]-test</c>, the hostname of the first cloud desktop is <c>ecd-0001-test</c>, the second is <c>ecd-0002-test</c>, and so on.</para>
            /// <list type="bullet">
            /// <item><description><para><c>name_prefix</c>: the prefix of the hostname.</para>
            /// </description></item>
            /// <item><description><para><c>[begin_number,bits]</c>: The sequential part of the hostname.</para>
            /// </description></item>
            /// <item><description><para><c>name_suffix</c>: the suffix of the hostname.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testhost</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable disk encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key to use for disk encryption. You can call the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation to obtain a list of key IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is for internal use only.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PBKB1QbqEl2tslEuU6gRrLxvCFBU2M%2FVD0Eru6Oo%2FI9LTU3XQhvq3PGMWarE%2BPJdkNvCqT3blqlRSthNy4A%2BJQ%3D%3D</para>
        /// </summary>
        [NameInMap("ChannelCookie")]
        [Validation(Required=false)]
        public string ChannelCookie { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The parameters for creating a cloud desktop without a bundle. This parameter is used only if <c>BundleId</c> is not specified.</para>
        /// </summary>
        [NameInMap("DesktopAttachment")]
        [Validation(Required=false)]
        public CreateDesktopsRequestDesktopAttachment DesktopAttachment { get; set; }
        public class CreateDesktopsRequestDesktopAttachment : TeaModel {
            /// <summary>
            /// <para>The type of the data disk. The system disk and data disk must be of the same type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud_auto: AutoPL SSD</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: enhanced SSD (ESSD)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <para>The PL of the ESSD. This parameter is required only when <c>DataDiskCategory</c> is set to <c>cloud_essd</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PL0</para>
            /// </description></item>
            /// <item><description><para>PL1</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("DataDiskPerLevel")]
            [Validation(Required=false)]
            public string DataDiskPerLevel { get; set; }

            /// <summary>
            /// <para>The capacity of the data disk, in GiB. Valid values: 40 to 2,040. The value must be a multiple of 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

            /// <summary>
            /// <para>The display language of the cloud desktop\&quot;s operating system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>zh-CN: Simplified Chinese</para>
            /// </description></item>
            /// <item><description><para>zh-HK: Traditional Chinese (Hong Kong)</para>
            /// </description></item>
            /// <item><description><para>en-US: American English</para>
            /// </description></item>
            /// <item><description><para>ja-JP: Japanese</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("DefaultLanguage")]
            [Validation(Required=false)]
            public string DefaultLanguage { get; set; }

            /// <summary>
            /// <para>The desktop type. You can call the <a href="https://help.aliyun.com/document_detail/188882.html">DescribeDesktopTypes</a> operation to query the supported desktop types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eds.enterprise_office.8c16g</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-39ddhdb0ggzjx*****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The type of the system disk. The system disk and data disk must be of the same type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud_auto: AutoPL SSD</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: enhanced SSD (ESSD)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the ESSD. This parameter is required only when <c>SystemDiskCategory</c> is set to <c>cloud_essd</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PL0</para>
            /// </description></item>
            /// <item><description><para>PL1</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("SystemDiskPerLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerLevel { get; set; }

            /// <summary>
            /// <para>The capacity of the system disk, in GiB. Valid values: 60 to 500. The value must be a multiple of 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// <para>The private IP address of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.1</para>
        /// </summary>
        [NameInMap("DesktopMemberIp")]
        [Validation(Required=false)]
        public string DesktopMemberIp { get; set; }

        /// <summary>
        /// <para>The name of the cloud desktop. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be 1 to 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The name must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DemoComputer01</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically append a suffix to the value of <c>DesktopName</c> when you create multiple cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DesktopNameSuffix")]
        [Validation(Required=false)]
        public bool? DesktopNameSuffix { get; set; }

        /// <summary>
        /// <para>The details of the scheduled tasks for the cloud desktops. This parameter is being deprecated. We recommend that you use <c>TimerGroupId</c> instead.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DesktopTimers")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestDesktopTimers> DesktopTimers { get; set; }
        public class CreateDesktopsRequestDesktopTimers : TeaModel {
            /// <summary>
            /// <para>Specifies whether to allow end users to configure the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowClientSetting")]
            [Validation(Required=false)]
            public bool? AllowClientSetting { get; set; }

            /// <summary>
            /// <para>The cron expression for the scheduled task.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>The cron expression is evaluated in UTC. For example, to specify 00:00 (UTC+8) every day, set the value to <c>0 0 16 ? * 1,2,3,4,5,6,7</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 40 7 ? * 1,2,3,4,5,6,7</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcibly execute the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enforce")]
            [Validation(Required=false)]
            public bool? Enforce { get; set; }

            /// <summary>
            /// <para>The interval in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The operation to perform for the scheduled task. This parameter is valid only for scheduled tasks that are triggered by user disconnection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Shutdown</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The disk reset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RESET_TYPE_SYSTEM</para>
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public string ResetType { get; set; }

            /// <summary>
            /// <para>The type of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoOperationReboot</para>
            /// </summary>
            [NameInMap("TimerType")]
            [Validation(Required=false)]
            public string TimerType { get; set; }

        }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is for internal use only.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-300943****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The IDs of the end users to assign to the cloud desktops. You can specify up to 100 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>The extended information in a JSON string. This parameter is for internal use only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <para>The ID of the desktop pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-boyczi8enfyc5****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The custom hostname of the cloud desktop. This parameter is supported only for Windows cloud desktops that are in an AD office network.</para>
        /// <para>The hostname must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The hostname must be 2 to 15 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The hostname can contain letters, digits, and hyphens (-). The hostname cannot start or end with a hyphen, contain consecutive hyphens, or consist of only digits.</para>
        /// </description></item>
        /// </list>
        /// <para>If you create multiple cloud desktops, you can use the <c>name_prefix[begin_number,bits]name_suffix</c> format to specify sequential hostnames for the cloud desktops. For example, if you set the <c>Hostname</c> parameter to <c>ecd-[1,4]-test</c>, the hostname of the first cloud desktop is <c>ecd-0001-test</c>, the second is <c>ecd-0002-test</c>, and so on.</para>
        /// <list type="bullet">
        /// <item><description><para><c>name_prefix</c>: the prefix of the hostname.</para>
        /// </description></item>
        /// <item><description><para><c>[begin_number,bits]</c>: The sequential part of the hostname.</para>
        /// </description></item>
        /// <item><description><para><c>name_suffix</c>: the suffix of the hostname.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testhost</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The parameters for purchasing a monthly usage package.</para>
        /// </summary>
        [NameInMap("MonthDesktopSetting")]
        [Validation(Required=false)]
        public CreateDesktopsRequestMonthDesktopSetting MonthDesktopSetting { get; set; }
        public class CreateDesktopsRequestMonthDesktopSetting : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is for internal use only.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BuyerId")]
            [Validation(Required=false)]
            public long? BuyerId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is for internal use only.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The duration in hours for the monthly usage package. Valid values: 120, 250, and 360.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("UseDuration")]
            [Validation(Required=false)]
            public int? UseDuration { get; set; }

        }

        /// <summary>
        /// <para>The ID of the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-387822****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The subscription duration. The unit is specified by the <c>PeriodUnit</c> parameter. This parameter is required only when <c>ChargeType</c> is set to <c>PrePaid</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>1</para>
        /// </description></item>
        /// <item><description><para>2</para>
        /// </description></item>
        /// <item><description><para>3</para>
        /// </description></item>
        /// <item><description><para>6</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>1</para>
        /// </description></item>
        /// <item><description><para>2</para>
        /// </description></item>
        /// <item><description><para>3</para>
        /// </description></item>
        /// <item><description><para>4</para>
        /// </description></item>
        /// <item><description><para>5</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system-all-enabled-policy</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23141</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The additional parameters for a specific purchase type.</para>
        /// </summary>
        [NameInMap("PurchaseOptions")]
        [Validation(Required=false)]
        public CreateDesktopsRequestPurchaseOptions PurchaseOptions { get; set; }
        public class CreateDesktopsRequestPurchaseOptions : TeaModel {
            /// <summary>
            /// <para>The monthly credit package. This parameter is used to select a credit package when you purchase agent resources. Valid values: 200, 1600, and 4000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("MonthlyCredits")]
            [Validation(Required=false)]
            public int? MonthlyCredits { get; set; }

        }

        /// <summary>
        /// <para>The ID of the bandwidth QoS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-52fqmg6kvyro7zu4l</para>
        /// </summary>
        [NameInMap("QosRuleId")]
        [Validation(Required=false)]
        public string QosRuleId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the regions that support Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The UID of the resource owner in reseller mode. This parameter is required only in reseller mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1828644634819902</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-3mtuc28rx95lx****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is for internal use only.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>spn-26c1b7bcrjcI****</para>
        /// </summary>
        [NameInMap("SavingPlanId")]
        [Validation(Required=false)]
        public string SavingPlanId { get; set; }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-28mp6my0l6zow****</para>
        /// </summary>
        [NameInMap("SnapshotPolicyId")]
        [Validation(Required=false)]
        public string SnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1m*****</para>
        /// </summary>
        [NameInMap("SubnetId")]
        [Validation(Required=false)]
        public string SubnetId { get; set; }

        /// <summary>
        /// <para>The tags to add to the cloud desktops. A resource can have up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestTag> Tag { get; set; }
        public class CreateDesktopsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the scheduled task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-0caoeogrk9m5****</para>
        /// </summary>
        [NameInMap("TimerGroupId")]
        [Validation(Required=false)]
        public string TimerGroupId { get; set; }

        /// <summary>
        /// <para>The user assignment mode for the cloud desktops.</para>
        /// <remarks>
        /// <para>If you do not specify the <c>EndUserId</c> parameter, the created cloud desktops are unassigned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("UserAssignMode")]
        [Validation(Required=false)]
        public string UserAssignMode { get; set; }

        /// <summary>
        /// <para>The custom scripts to run on the cloud desktops after they start.</para>
        /// </summary>
        [NameInMap("UserCommands")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestUserCommands> UserCommands { get; set; }
        public class CreateDesktopsRequestUserCommands : TeaModel {
            /// <summary>
            /// <para>The content of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bmV3LWl0ZW0gZDpcdGVzdF91c2VyX2NvbW1hbmRzLnR4dCAtdHlwZSBm****</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The encoding format of the script content specified in the <c>Content</c> parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Base64</para>
            /// </summary>
            [NameInMap("ContentEncoding")]
            [Validation(Required=false)]
            public string ContentEncoding { get; set; }

            /// <summary>
            /// <para>The script type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RunPowerShellScript</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

        }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is for internal use only.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable disk encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VolumeEncryptionEnabled")]
        [Validation(Required=false)]
        public bool? VolumeEncryptionEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the KMS key to use for disk encryption. You can call the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation to obtain a list of key IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
        /// </summary>
        [NameInMap("VolumeEncryptionKey")]
        [Validation(Required=false)]
        public string VolumeEncryptionKey { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is for internal use only.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6w8u60n8xbkg5el****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
