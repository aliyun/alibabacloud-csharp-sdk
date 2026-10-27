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
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when ChargeType is set to PrePaid. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the cloud desktop template. If you do not specify a template ID, you can complete the creation by specifying the required fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-je9hani001wfn****</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// <para>The list of cloud desktop templates.</para>
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
            /// <para>The ID of the cloud desktop template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b-je9hani001wfn****</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The name of the cloud desktop. The name must meet the following rules:</para>
            /// <list type="bullet">
            /// <item><description>The name can be up to 64 characters in length.</description></item>
            /// <item><description>The name must start with a letter or a Chinese character, and cannot start with http:// or https://.</description></item>
            /// <item><description>The name can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DemoComputer02</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The list of users to whom the cloud desktop is assigned.</para>
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <para>The custom settings for the hostname of the cloud desktop. This parameter is supported only for cloud desktops whose operating system is Windows in an AD office network.</para>
            /// <para>The hostname must meet the following rules:</para>
            /// <list type="bullet">
            /// <item><description>The hostname must be 2 to 15 characters in length.</description></item>
            /// <item><description>The hostname can contain letters, digits, and hyphens (-). It cannot start or end with a hyphen, contain consecutive hyphens, or contain only digits.</description></item>
            /// </list>
            /// <para>When you create multiple cloud desktops, you can use the name_prefix[begin_number,bits]name_suffix format to name them in a unified manner. For example, if you set Hostname to ecd-[1,4]-test, the hostname of the first cloud desktop is ecd-0001-test, the hostname of the second cloud desktop is ecd-0002-test, and so on.</para>
            /// <list type="bullet">
            /// <item><description>name_prefix: the prefix of the hostname.</description></item>
            /// <item><description>[begin_number,bits]: the sequential number in the hostname. begin_number is the starting number. Valid values: 0 to 999999. Default value: 0. bits is the number of digits. Valid values: 1 to 6. Default value: 6.</description></item>
            /// <item><description>name_suffix: the suffix of the hostname.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testhost</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable cloud disk encryption. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key used when cloud disk encryption is enabled. You can call the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation to obtain the key ID.</para>
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
        /// <para>This field is currently not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PBKB1QbqEl2tslEuU6gRrLxvCFBU2M%2FVD0Eru6Oo%2FI9LTU3XQhvq3PGMWarE%2BPJdkNvCqT3blqlRSthNy4A%2BJQ%3D%3D</para>
        /// </summary>
        [NameInMap("ChannelCookie")]
        [Validation(Required=false)]
        public string ChannelCookie { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud desktop. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The parameters for creating a cloud desktop without a template. This parameter is invalid if the BundleId parameter is specified.</para>
        /// </summary>
        [NameInMap("DesktopAttachment")]
        [Validation(Required=false)]
        public CreateDesktopsRequestDesktopAttachment DesktopAttachment { get; set; }
        public class CreateDesktopsRequestDesktopAttachment : TeaModel {
            /// <summary>
            /// <para>The category of the data cloud disk. The system cloud disk and the data cloud disk must be of the same category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_auto: standard SSD</description></item>
            /// <item><description>cloud_essd: ESSD cloud disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD. This parameter is required if you select an ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0</description></item>
            /// <item><description>PL1</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("DataDiskPerLevel")]
            [Validation(Required=false)]
            public string DataDiskPerLevel { get; set; }

            /// <summary>
            /// <para>The capacity of the user disk. Unit: GiB. Valid values: 40 to 2040, in increments of 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

            /// <summary>
            /// <para>The language. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh-CN</description></item>
            /// <item><description>zh-HK</description></item>
            /// <item><description>en-US</description></item>
            /// <item><description>ja-JP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("DefaultLanguage")]
            [Validation(Required=false)]
            public string DefaultLanguage { get; set; }

            /// <summary>
            /// <para>The specifications of the cloud desktop. You can call the <a href="https://help.aliyun.com/document_detail/188882.html">DescribeDesktopTypes</a> operation to query the IDs of supported cloud desktop specifications.</para>
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
            /// <para>The category of the system cloud disk. The system cloud disk and the data cloud disk must be of the same category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_auto: standard SSD</description></item>
            /// <item><description>cloud_essd: ESSD cloud disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD. This parameter is required if you select an ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0</description></item>
            /// <item><description>PL1</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("SystemDiskPerLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerLevel { get; set; }

            /// <summary>
            /// <para>The capacity of the system cloud disk. Unit: GiB. Valid values: 40 to 2040, in increments of 10.</para>
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
        /// <para>The name of the cloud desktop. The name must meet the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 64 characters in length.</description></item>
        /// <item><description>The name must start with a letter or a Chinese character, and cannot start with http:// or https://.</description></item>
        /// <item><description>The name can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DemoComputer01</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <para>The format of the cloud desktop name.</para>
        /// </summary>
        [NameInMap("DesktopNameModel")]
        [Validation(Required=false)]
        public CreateDesktopsRequestDesktopNameModel DesktopNameModel { get; set; }
        public class CreateDesktopsRequestDesktopNameModel : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically add a suffix to the cloud desktop name when you create multiple cloud desktops in a batch. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DesktopNameIsSuffix")]
            [Validation(Required=false)]
            public bool? DesktopNameIsSuffix { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to automatically add a suffix to the cloud desktop name when you create multiple cloud desktops in a batch. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DesktopNameSuffix")]
        [Validation(Required=false)]
        public bool? DesktopNameSuffix { get; set; }

        /// <summary>
        /// <para>The details of the scheduled tasks for the cloud desktop. This parameter is being deprecated. Use the TImerGroupId parameter instead.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DesktopTimers")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestDesktopTimers> DesktopTimers { get; set; }
        public class CreateDesktopsRequestDesktopTimers : TeaModel {
            /// <summary>
            /// <para>Specifies whether to allow end users to configure scheduled tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowClientSetting")]
            [Validation(Required=false)]
            public bool? AllowClientSetting { get; set; }

            /// <summary>
            /// <para>The cron expression of the scheduled task.</para>
            /// <remarks>
            /// <para>Notice: You must specify the time in UTC. For example, to specify 00:00:00 every day in UTC+8 (Beijing time), pass 0 0 16 ? * 1,2,3,4,5,6,7.</notice></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0 40 7 ? * 1,2,3,4,5,6,7</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcibly execute the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enforce")]
            [Validation(Required=false)]
            public bool? Enforce { get; set; }

            /// <summary>
            /// <para>The time interval, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The operation type of the scheduled task. Currently, only disconnect scheduled tasks are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Shutdown</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The reset type of the cloud desktop.</para>
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
        /// <para>This parameter is not available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-300943****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The list of IDs of authorized users to be added to the cloud desktop. You can specify 1 to 100 user IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>The extended information in JSON string format. This parameter is available only for internal customers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <para>The ID of the cloud desktop pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-boyczi8enfyc5****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The GPU driver version of the host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Grid19</para>
        /// </summary>
        [NameInMap("HostGpuDriverVersion")]
        [Validation(Required=false)]
        public string HostGpuDriverVersion { get; set; }

        /// <summary>
        /// <para>The custom settings for the hostname of the cloud desktop. This parameter is supported only for cloud desktops whose operating system is Windows in an AD office network.</para>
        /// <para>The hostname must meet the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The hostname must be 2 to 15 characters in length.</description></item>
        /// <item><description>The hostname can contain letters, digits, and hyphens (-). It cannot start or end with a hyphen, contain consecutive hyphens, or contain only digits.</description></item>
        /// </list>
        /// <para>When you create multiple cloud desktops, you can use the name_prefix[begin_number,bits]name_suffix format to name them in a unified manner. For example, if you set Hostname to ecd-[1,4]-test, the hostname of the first cloud desktop is ecd-0001-test, the hostname of the second cloud desktop is ecd-0002-test, and so on.</para>
        /// <list type="bullet">
        /// <item><description>name_prefix: the prefix of the hostname.</description></item>
        /// <item><description>[begin_number,bits]: the sequential number in the hostname. begin_number is the starting number. Valid values: 0 to 999999. Default value: 0. bits is the number of digits. Valid values: 1 to 6. Default value: 6.</description></item>
        /// <item><description>name_suffix: the suffix of the hostname.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testhost</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The purchase parameters for the monthly hourly package.</para>
        /// </summary>
        [NameInMap("MonthDesktopSetting")]
        [Validation(Required=false)]
        public CreateDesktopsRequestMonthDesktopSetting MonthDesktopSetting { get; set; }
        public class CreateDesktopsRequestMonthDesktopSetting : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This field is currently not available for public use.</para>
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
            /// <para>This field is currently not available for public use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The plan selected when purchasing a monthly hourly package. Valid values: 120, 250, and 360.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
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
        /// <para>The OU path. After this parameter is specified, the cloud desktop joins the corresponding organizational unit (OU) in Active Directory (AD).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com/wuyingtest/computers</para>
        /// </summary>
        [NameInMap("OuPath")]
        [Validation(Required=false)]
        public string OuPath { get; set; }

        /// <summary>
        /// <para>The subscription period of the resource. The unit is specified by PeriodUnit. This parameter takes effect and is required only when ChargeType is set to PrePaid.</para>
        /// <list type="bullet">
        /// <item><description><para>If PeriodUnit is set to Month, valid values of this parameter are:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If PeriodUnit is set to Year, valid values of this parameter are:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>4</description></item>
        /// <item><description>5</description></item>
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
        /// <para>The time unit for the subscription billing method. Valid values:</para>
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
        /// <para>The ID of the promotional event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23141</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The additional parameters for specific purchase types.</para>
        /// </summary>
        [NameInMap("PurchaseOptions")]
        [Validation(Required=false)]
        public CreateDesktopsRequestPurchaseOptions PurchaseOptions { get; set; }
        public class CreateDesktopsRequestPurchaseOptions : TeaModel {
            /// <summary>
            /// <para>The quota of the Wuying credit package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("CreditPackageAmountSpec")]
            [Validation(Required=false)]
            public int? CreditPackageAmountSpec { get; set; }

            /// <summary>
            /// <para>The duration of the Wuying credit package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreditPackagePeriod")]
            [Validation(Required=false)]
            public int? CreditPackagePeriod { get; set; }

            /// <summary>
            /// <para>The unit of the credit package duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("CreditPackagePeriodUnit")]
            [Validation(Required=false)]
            public string CreditPackagePeriodUnit { get; set; }

            /// <summary>
            /// <para>The monthly credit package used to select a credit plan when purchasing agent resources. Valid values: 200, 1600, and 4000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("MonthlyCredits")]
            [Validation(Required=false)]
            public int? MonthlyCredits { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Internet bandwidth throttling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-52fqmg6kvyro7zu4l</para>
        /// </summary>
        [NameInMap("QosRuleId")]
        [Validation(Required=false)]
        public string QosRuleId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the list of regions supported by WUYING Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID for resource ownership in the reseller pattern. This parameter is not required in the non-reseller pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1828644634819902</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>The ID of compute resource pool (rp-xxx). This parameter is optional. If this parameter is specified, the cloud desktop is created from compute resource pool, computing resources are provided by compute resource pool, and no computing fee order is generated. If the ZoneId parameter is explicitly specified, it must be the same as the zone of compute resource pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rp-xxx</para>
        /// </summary>
        [NameInMap("ReservePoolId")]
        [Validation(Required=false)]
        public string ReservePoolId { get; set; }

        /// <summary>
        /// <para>The ID of the Wuying resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-3mtuc28rx95lx****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This field is currently not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>spn-26c1b7bcrjcI****</para>
        /// </summary>
        [NameInMap("SavingPlanId")]
        [Validation(Required=false)]
        public string SavingPlanId { get; set; }

        /// <summary>
        /// <para>The ID of the Wuying automatic snapshot policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-28mp6my0l6zow****</para>
        /// </summary>
        [NameInMap("SnapshotPolicyId")]
        [Validation(Required=false)]
        public string SnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud desktop. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>prePaid: monthly subscription without a duration limit.</description></item>
        /// <item><description>postPaid: pay-as-you-go.</description></item>
        /// <item><description>monthPackage: monthly duration package.</description></item>
        /// <item><description>jvsAgentPackage: JVS agent duration package.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>monthPackage</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>The subnet ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1m*****</para>
        /// </summary>
        [NameInMap("SubnetId")]
        [Validation(Required=false)]
        public string SubnetId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestTag> Tag { get; set; }
        public class CreateDesktopsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify 1 to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify 1 to 20 tag values.</para>
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
        /// <para>The assignment mode of the cloud desktop. Valid values:</para>
        /// <remarks>
        /// <para>If EndUserId is not specified, the created cloud desktop is not assigned to any user.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("UserAssignMode")]
        [Validation(Required=false)]
        public string UserAssignMode { get; set; }

        /// <summary>
        /// <para>The custom command script data.</para>
        /// </summary>
        [NameInMap("UserCommands")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestUserCommands> UserCommands { get; set; }
        public class CreateDesktopsRequestUserCommands : TeaModel {
            /// <summary>
            /// <para>The content of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bmV3LWl0ZW0gZDpcdGVzdF91c2VyX2NvbW1hbmRzLnR4dCAtdHlwZSBm****</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The encoding method of the command content. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Base64</para>
            /// </summary>
            [NameInMap("ContentEncoding")]
            [Validation(Required=false)]
            public string ContentEncoding { get; set; }

            /// <summary>
            /// <para>The language type of the command. Valid values:</para>
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
        /// <para>This parameter is not available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cloud disk encryption. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VolumeEncryptionEnabled")]
        [Validation(Required=false)]
        public bool? VolumeEncryptionEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key used when cloud disk encryption is enabled. You can call the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation to obtain the key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
        /// </summary>
        [NameInMap("VolumeEncryptionKey")]
        [Validation(Required=false)]
        public string VolumeEncryptionKey { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available for use.</para>
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
