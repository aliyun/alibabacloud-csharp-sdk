// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDesktopGroupRequest : TeaModel {
        /// <summary>
        /// <para>The types of the users.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("AllClassifyUsers")]
        [Validation(Required=false)]
        public bool? AllClassifyUsers { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable batch-based automatic creation of subscription cloud computers for the shared group. This parameter is required if you set <c>ChargeType</c> to <c>PrePaid</c>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: enables batch-based automatic creation of subscription cloud computers.</description></item>
        /// <item><description>1: disables batch-based automatic creation of subscription cloud computers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowAutoSetup")]
        [Validation(Required=false)]
        public int? AllowAutoSetup { get; set; }

        /// <summary>
        /// <para>The maximum number of pay-as-you-go cloud computers that can be reserved in the shared group. This parameter is required if you set <c>ChargeType</c> to <c>PostPaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: does not reserve any cloud computers.</description></item>
        /// <item><description>N: reserves N cloud computers (1≤ N ≤ 100).</description></item>
        /// </list>
        /// <remarks>
        /// <para> Setting this parameter to 0 means no cloud computers will be reserved in the shared group. In this case, the system must create, start, and assign cloud computers to end users upon request, which can be time-consuming. To improve user experience, we recommend that you reserve a specific number of cloud computers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowBufferCount")]
        [Validation(Required=false)]
        public int? AllowBufferCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically complete the payment for subscription orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the shared subscription group.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The number of concurrent sessions of the multi-session shared group.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BindAmount")]
        [Validation(Required=false)]
        public long? BindAmount { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-je9hani001wfn****</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>For shared subscription groups, this parameter defines the initial number of cloud computers to be created. Valid values: 0 to 200.</description></item>
        /// <item><description>For shared pay-as-you-go groups, this parameter defines the minimum initial number of cloud computers to be created. Valid values: 0 to <c>MaxDesktopsCount</c>. Default value: 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BuyDesktopsCount")]
        [Validation(Required=false)]
        public int? BuyDesktopsCount { get; set; }

        /// <summary>
        /// <para>The billing method of the shared group.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// <item><description>PrePaid: subscription.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The type of the cloud computers in the shared group.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>teacher: cloud computers designed for teachers.</description></item>
        /// <item><description>student: cloud computers designed for students.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>teacher</para>
        /// </summary>
        [NameInMap("Classify")]
        [Validation(Required=false)]
        public string Classify { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The remarks of the shared group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The maximum duration for which each session remains connected. The session is automatically disconnected once the specified maximum time limit is reached. Unit: milliseconds. Valid values: 900000 to 345600000. That is, the session can be connected for 15 to 5,760 minutes (4 days).</para>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("ConnectDuration")]
        [Validation(Required=false)]
        public long? ConnectDuration { get; set; }

        /// <summary>
        /// <para>The category of the data disk.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_auto: the standard SSD.</description></item>
        /// <item><description>cloud_essd: the ESSD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("DataDiskCategory")]
        [Validation(Required=false)]
        public string DataDiskCategory { get; set; }

        /// <summary>
        /// <para>The PL of the data disk of the ESSD category. Default value: PL0.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL1</description></item>
        /// <item><description>PL0</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("DataDiskPerLevel")]
        [Validation(Required=false)]
        public string DataDiskPerLevel { get; set; }

        /// <summary>
        /// <para>The size of the data disk. Unit: GB. Valid values: 0 to 16380. The value must be an integral multiple of 20.</para>
        /// <list type="bullet">
        /// <item><description>A value of 0 means no data disk is attached.</description></item>
        /// <item><description>If the selected plan includes a standard SSD, the data disk size must be at least 20 GB.</description></item>
        /// </list>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        /// <summary>
        /// <para>The default number of cloud computers that you want to create at the same time in the shared group. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultInitDesktopCount")]
        [Validation(Required=false)]
        public int? DefaultInitDesktopCount { get; set; }

        /// <summary>
        /// <para>The language of the OS.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en-US: English.</description></item>
        /// <item><description>zh-HK: Traditional Chinese.</description></item>
        /// <item><description>zh-CN: Simplified Chinese</description></item>
        /// <item><description>ja-JP: Japanese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("DefaultLanguage")]
        [Validation(Required=false)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// <para>The name of the shared group. The name can be up to 30 characters in length and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-). It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktopGroupName1</para>
        /// </summary>
        [NameInMap("DesktopGroupName")]
        [Validation(Required=false)]
        public string DesktopGroupName { get; set; }

        /// <summary>
        /// <para>The specifications of the cloud computer. You can call the <a href="~~DescribeDesktopTypes~~">DescribeDesktopTypes</a> operation to query all the supported specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.enterprise_office.16c64g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The IDs of the end users.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>Specifies whether the shared group is exclusive. You must set this parameter to <c>Exclusive</c> when <c>SessionType</c> is set to <c>MultipleSession</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("ExclusiveType")]
        [Validation(Required=false)]
        public string ExclusiveType { get; set; }

        /// <summary>
        /// <para>The ID of the File Storage NAS (NAS) file system for the user data roaming feature.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>04f314****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The number of shared groups for the single-cloud computer type. You must specify this parameter if you set <c>MultiResource</c> to <c>false</c>. Valid values: 1 to 5. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupAmount")]
        [Validation(Required=false)]
        public int? GroupAmount { get; set; }

        /// <summary>
        /// <para>The version of the shared group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GroupVersion")]
        [Validation(Required=false)]
        public int? GroupVersion { get; set; }

        /// <summary>
        /// <para>The hostname series of the cloud computer. This parameter is supported exclusively when the office network operates on Active Directory (AD) and the cloud computer runs on a Windows operating system.</para>
        /// <para>Naming conventions:</para>
        /// <list type="bullet">
        /// <item><description>A hostname must be 2 to 15 characters in length</description></item>
        /// <item><description>and can contain only letters, digits, and hyphens (-). It cannot start or end with a hyphen (-), contain consecutive hyphens (-), or contain only digits.</description></item>
        /// </list>
        /// <para>If you want to create multiple cloud computers, specify their hostnames in the <c>name_prefix[begin_number,bits]name_suffix</c> format. For example, if you set Hostname to ecd-[1,4]-test, the hostnames of the cloud computers will be assigned sequentially as ecd-0001-test, ecd-0002-test, and so on.</para>
        /// <list type="bullet">
        /// <item><description><c>name_prefix</c>: the prefix of the hostname.</description></item>
        /// <item><description><c>[begin_number,bits]</c>: the sequential number in the hostname. The <c>begin_number</c> value is the starting number. Valid values of begin_number: 0 to 999999. Default value: 0. The <c>bits</c> value is the number of digits. Valid values: 1 to 6. Default value: 6.</description></item>
        /// <item><description><c>name_suffix</c>: the suffix of the hostname.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testhost</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The duration after which a session is terminated if no keyboard or mouse activity is detected. When an end user connects to a cloud computer, a session is initiated. If no input from the keyboard or mouse is detected within this specified timeframe, the session is automatically closed. Unit: milliseconds. Valid values: 360000 to 3600000 (6 minutes to 60 minutes)</para>
        /// <para>The system prompts end users to save their data 30 seconds before a session is disconnected. To avoid data loss, end users must save their session data upon receiving the prompt.</para>
        /// <remarks>
        /// <para> This parameter is suitable only for cloud computers whose image version is v1.0.2 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("IdleDisconnectDuration")]
        [Validation(Required=false)]
        public long? IdleDisconnectDuration { get; set; }

        /// <summary>
        /// <para>The ID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-gx2x1dhsmusr2****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The duration for which each session remains active after disconnection. Valid values: 180000 (3 minutes) to 345600000 (4 days). Unit: milliseconds. If you set this parameter to 0, the session is permanently retained after disconnection.</para>
        /// <para>When a session is disconnected, take note of the following items: 1. If the end user does not resume the session within the specified duration, the session will close, and all unsaved data will be cleared. 2. If the end user resumes the session within the specified duration, the session data will remain accessible for continued use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000</para>
        /// </summary>
        [NameInMap("KeepDuration")]
        [Validation(Required=false)]
        public long? KeepDuration { get; set; }

        /// <summary>
        /// <para>The load balancing policy of the multi-session shared group.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: depth-first</description></item>
        /// <item><description>1: breadth first</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LoadPolicy")]
        [Validation(Required=false)]
        public long? LoadPolicy { get; set; }

        /// <summary>
        /// <para>The maximum number of pay-as-you-go cloud computers that can be automatically provisioned at the same time in the shared group. Valid values: 0 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxDesktopsCount { get; set; }

        /// <summary>
        /// <para>The minimum number of subscription cloud computers that can be automatically provisioned at the same time in the shared group. This parameter is required if you set <c>ChargeType</c> to <c>PrePaid</c>. Default value: 1. Valid values: 0 to <c>MaxDesktopsCount</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDesktopsCount")]
        [Validation(Required=false)]
        public int? MinDesktopsCount { get; set; }

        /// <summary>
        /// <para>Specifies whether the shared group is a multi-cloud computer type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: a multi-cloud computer type.</description></item>
        /// <item><description>false: a single-cloud computer type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MultiResource")]
        [Validation(Required=false)]
        public bool? MultiResource { get; set; }

        /// <summary>
        /// <para>The ID of the office network.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+os-c5cy7q578s8jc****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The session type of the shared group.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: single-session.</description></item>
        /// <item><description>1: multi-session.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OwnType")]
        [Validation(Required=false)]
        public int? OwnType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the shared group. This parameter is required if you set <c>ChargeType</c> to <c>PrePaid</c>. You must specify the subscription duration unit by using <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>PeriodUnit</c> to <c>Month</c>, valid values of this parameter:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set <c>PeriodUnit</c> to <c>Year</c>, valid values of this parameter:</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-9c2d6t2dwflqr****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable user data roaming.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProfileFollowSwitch")]
        [Validation(Required=false)]
        public bool? ProfileFollowSwitch { get; set; }

        /// <summary>
        /// <para>The ID of the coupon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_*****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The threshold for the ratio of connected sessions. This parameter defines the condition that activates automatic scaling of cloud computers in a multi-session shared group. The ratio of connected sessions is calculated by using the following formula:</para>
        /// <para><c>Ratio of connected sessions = Number of connected sessions/(Total number of cloud computers × Maximum number of sessions allowed for each cloud computer) × 100%</c>.</para>
        /// <para>If the connected session ratio exceeds the specified threshold, new cloud computers are provisioned. If the ratio falls below the threshold, idle cloud computers are deleted.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("RatioThreshold")]
        [Validation(Required=false)]
        public float? RatioThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>The reset option of the shared group.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Reset is not required.</description></item>
        /// <item><description>1: Only the system disk is reset.</description></item>
        /// <item><description>2: Only the data disk is reset.</description></item>
        /// <item><description>3: Both the system disk and the data disk are reset.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public long? ResetType { get; set; }

        /// <summary>
        /// <para>The ID of the scaling policy.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("ScaleStrategyId")]
        [Validation(Required=false)]
        public string ScaleStrategyId { get; set; }

        /// <summary>
        /// <para>The type of the session.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SingleSession</description></item>
        /// <item><description>MultipleSession</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SingleSession</para>
        /// </summary>
        [NameInMap("SessionType")]
        [Validation(Required=false)]
        public string SessionType { get; set; }

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
        /// <para>The maximum period of inactivity allowed before a cloud computer is automatically stopped. If the idle duration reaches the specified limit, the system stops the cloud computer. When an end user reconnects to the stopped cloud computer, it automatically restarts. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("StopDuration")]
        [Validation(Required=false)]
        public long? StopDuration { get; set; }

        /// <summary>
        /// <para>The category of the system disk.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_auto: the standard SSD.</description></item>
        /// <item><description>cloud_essd: the Enterprise SSD (ESSD).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the system disk of the ESSD category. Default value: PL0.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL1</description></item>
        /// <item><description>PL0</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("SystemDiskPerLevel")]
        [Validation(Required=false)]
        public string SystemDiskPerLevel { get; set; }

        /// <summary>
        /// <para>The size of the system disk. Unit: GiB.</para>
        /// <remarks>
        /// <para> The system disk must be at least as large as the image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDesktopGroupRequestTag> Tag { get; set; }
        public class CreateDesktopGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You cannot specify an empty string as a tag key. A tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify an empty string as a tag key. A tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the timer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-0caoeogrk9m5****</para>
        /// </summary>
        [NameInMap("TimerGroupId")]
        [Validation(Required=false)]
        public string TimerGroupId { get; set; }

        [NameInMap("UserGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

        [NameInMap("UserOuPath")]
        [Validation(Required=false)]
        public string UserOuPath { get; set; }

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
        /// <para>The ID of the Key Management Service (KMS) key that you want to use when disk encryption is enabled. You can call the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation to obtain a list of KMS keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
        /// </summary>
        [NameInMap("VolumeEncryptionKey")]
        [Validation(Required=false)]
        public string VolumeEncryptionKey { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
