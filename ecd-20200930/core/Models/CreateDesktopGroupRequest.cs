// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDesktopGroupRequest : TeaModel {
        /// <summary>
        /// <para>The users of all shared cloud desktop categories.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllClassifyUsers")]
        [Validation(Required=false)]
        public bool? AllClassifyUsers { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow automatic creation of cloud desktops in subscription shared cloud desktops. This parameter takes effect and is required only when the <c>ChargeType</c> parameter is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowAutoSetup")]
        [Validation(Required=false)]
        public int? AllowAutoSetup { get; set; }

        /// <summary>
        /// <para>The number of reserved cloud desktops allowed in pay-as-you-go shared cloud desktops. This parameter takes effect and is required only when the <c>ChargeType</c> parameter is set to <c>PostPaid</c>. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>0: No cloud desktops are reserved.</description></item>
        /// <item><description>N: N cloud desktops are reserved (1 ≤ N ≤ 100).</description></item>
        /// </list>
        /// <remarks>
        /// <para>If no available cloud desktops are reserved, when an end user initiates a connection request, the system must create and start a cloud desktop before assigning it to the user, which takes a relatively long time. We recommend that you reserve a certain number of cloud desktops as needed to ensure the user experience.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowBufferCount")]
        [Validation(Required=false)]
        public int? AllowBufferCount { get; set; }

        /// <summary>
        /// <para>Specifies whether automatic payment is enabled for subscription orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for subscription shared cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The number of concurrent sessions allowed per cloud desktop in multi-session shared cloud desktops.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BindAmount")]
        [Validation(Required=false)]
        public long? BindAmount { get; set; }

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
        /// <list type="bullet">
        /// <item><description>For subscription shared cloud desktops: the initial number of cloud desktops created. Valid values: 0 to 200.</description></item>
        /// <item><description>For pay-as-you-go shared cloud desktops: the minimum initial number of cloud desktops created. Default value: 1. Valid values: 0 to the value of <c>MaxDesktopsCount</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BuyDesktopsCount")]
        [Validation(Required=false)]
        public int? BuyDesktopsCount { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud desktop.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The type of the shared cloud desktop.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>teacher</para>
        /// </summary>
        [NameInMap("Classify")]
        [Validation(Required=false)]
        public string Classify { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The maximum duration for which a session can remain connected. When the session connection duration reaches this value, the session is automatically disconnected. Unit: milliseconds. Valid values: 900000 (15 minutes) to 345600000 (4 days).</para>
        /// 
        /// <b>Example:</b>
        /// <para>900000</para>
        /// </summary>
        [NameInMap("ConnectDuration")]
        [Validation(Required=false)]
        public long? ConnectDuration { get; set; }

        /// <summary>
        /// <para>The category of the data cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("DataDiskCategory")]
        [Validation(Required=false)]
        public string DataDiskCategory { get; set; }

        /// <summary>
        /// <para>The performance level of the ESSD. Default value: PL0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("DataDiskPerLevel")]
        [Validation(Required=false)]
        public string DataDiskPerLevel { get; set; }

        /// <summary>
        /// <para>The capacity of the mounted data cloud disk. Unit: GB. Valid values: 0 to 16380. The value must be a multiple of 20.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>A value of 0 indicates that no data cloud disk is mounted.</para>
        /// </description></item>
        /// <item><description><para>If the selected plan uses ESSD cloud disks (performance level (PL) PL0), the minimum capacity of the mounted data cloud disk is 40 GB.</para>
        /// </description></item>
        /// <item><description><para>If the selected plan uses standard SSDs, the minimum capacity of the mounted data cloud disk is 20 GB.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>A value of 0 indicates that no data cloud disk is mounted.</para>
        /// </description></item>
        /// <item><description><para>If the selected plan uses standard SSDs, the minimum capacity of the mounted data cloud disk is 20 GB.</para>
        /// </description></item>
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
        /// <para>The default number of cloud desktops created when you create multiple shared cloud desktops. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultInitDesktopCount")]
        [Validation(Required=false)]
        public int? DefaultInitDesktopCount { get; set; }

        /// <summary>
        /// <para>The system language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("DefaultLanguage")]
        [Validation(Required=false)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// <para>The retention period before a cloud desktop in the cloud desktop pool is automatically deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("DeleteDuration")]
        [Validation(Required=false)]
        public long? DeleteDuration { get; set; }

        /// <summary>
        /// <para>The name of the shared cloud desktop. The name can be up to 30 characters in length. It must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>. It can contain Chinese characters, English letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SharedComputers01</para>
        /// </summary>
        [NameInMap("DesktopGroupName")]
        [Validation(Required=false)]
        public string DesktopGroupName { get; set; }

        /// <summary>
        /// <para>The cloud desktop type. You can call the <a href="~~DescribeDesktopTypes~~">DescribeDesktopTypes</a> operation to query the IDs of supported cloud desktop types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.enterprise_office.16c64g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dri-uf62w3qzt4aigvlcb****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The list of user IDs for the shared cloud desktop.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The pool type. To create a static pool, set this parameter to <c>Exclusive</c>. If the <c>SessionType</c> parameter is set to <c>MultipleSession</c>, you must specify this parameter and set the value to <c>Exclusive</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("ExclusiveType")]
        [Validation(Required=false)]
        public string ExclusiveType { get; set; }

        /// <summary>
        /// <para>The ID of the NAS file system used for the user data roaming feature.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>kegd-nas-****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The number of single-user shared cloud desktops to create. This parameter is required only when the <c>MultiResource</c> parameter is set to <c>false</c>. Valid values: 1 to 5. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupAmount")]
        [Validation(Required=false)]
        public int? GroupAmount { get; set; }

        /// <summary>
        /// <para>The version of the shared cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GroupVersion")]
        [Validation(Required=false)]
        public int? GroupVersion { get; set; }

        /// <summary>
        /// <para>The custom hostname settings of the cloud desktop. This parameter is supported only for the settings of cloud desktops that run the Windows operating system and are connected to an AD workspace.</para>
        /// <para>The hostname must meet the following naming rules:</para>
        /// <list type="bullet">
        /// <item><description>The hostname must be 2 to 15 characters in length.</description></item>
        /// <item><description>The hostname can contain letters, digits, and hyphens (-). It cannot start or end with a hyphen, contain consecutive hyphens, or contain only digits.</description></item>
        /// </list>
        /// <para>When you create multiple cloud desktops, you can use the <c>name_prefix[begin_number,bits]name_suffix</c> format to name the cloud desktops in a unified manner. For example, if you set Hostname to ecd-[1,4]-test, the hostname of the first cloud desktop is ecd-0001-test, the hostname of the second cloud desktop is ecd-0002-test, and so on.</para>
        /// <list type="bullet">
        /// <item><description><c>name_prefix</c>: the prefix of the hostname.</description></item>
        /// <item><description><c>[begin_number,bits]</c>: the sequential number in the hostname. <c>begin_number</c> specifies the starting number. Valid values: 0 to 999999. Default value: 0. <c>bits</c> specifies the number of digits. Valid values: 1 to 6. Default value: 6.</description></item>
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
        /// <para>The maximum idle time before a user session is disconnected. If no keyboard or mouse operations are performed within this maximum duration after a user session is established, the session is disconnected. Unit: milliseconds. Valid values: 360000 (6 minutes) to 3600000 (60 minutes).</para>
        /// <para>30 seconds before this duration is reached, the end user in the session receives a prompt message to save document data. The end user must save the document data promptly to avoid data loss.</para>
        /// <remarks>
        /// <para>This parameter applies only to cloud desktops whose image version is 1.0.2 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>360000</para>
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
        /// <para>The retention period of a session after it is disconnected. Unit: milliseconds. Valid values: 180000 (3 minutes) to 345600000 (4 days). A value of 0 indicates that the session is always retained.</para>
        /// <para>If a session is actively disconnected by the user or unexpectedly disconnected due to other factors, the retention period starts from the time of disconnection. If the user does not reconnect to the session within the retention period, the session is logged off and unsaved data is destroyed. If the user successfully reconnects to the session within the retention period, the user can enter the original session and access the data before the disconnection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180000</para>
        /// </summary>
        [NameInMap("KeepDuration")]
        [Validation(Required=false)]
        public long? KeepDuration { get; set; }

        /// <summary>
        /// <para>The load balancing policy for multi-session shared cloud desktops.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LoadPolicy")]
        [Validation(Required=false)]
        public long? LoadPolicy { get; set; }

        /// <summary>
        /// <para>The maximum number of pay-as-you-go shared cloud desktops. Valid values: 0 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxDesktopsCount { get; set; }

        /// <summary>
        /// <para>The maximum number of shared cloud desktops for automatic creation in a subscription plan. This parameter takes effect and is required only when the <c>ChargeType</c> parameter is set to <c>PrePaid</c>. Default value: 1. Valid values: 0 to the value of <c>MaxDesktopsCount</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDesktopsCount")]
        [Validation(Required=false)]
        public int? MinDesktopsCount { get; set; }

        /// <summary>
        /// <para>Specifies whether the cloud desktop is a multi-user shared cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MultiResource")]
        [Validation(Required=false)]
        public bool? MultiResource { get; set; }

        /// <summary>
        /// <para>The ID of the office network to which the shared cloud desktop belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+os-c5cy7q578s8jc****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The type of the shared cloud desktop.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OwnType")]
        [Validation(Required=false)]
        public int? OwnType { get; set; }

        /// <summary>
        /// <para>The subscription period of the shared cloud desktop. This parameter takes effect and is required only when the <c>ChargeType</c> parameter is set to <c>PrePaid</c>. The unit is specified by the <c>PeriodUnit</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values:<list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values:<list type="bullet">
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
        /// <para>The billing time unit for the subscription Billable methods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the policy associated with the shared cloud desktop.</para>
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
        /// <para>This parameter is not available.</para>
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
        /// <para>The session usage threshold, which is used as the trigger for automatic scaling of multi-session shared cloud desktops. The formula for calculating the session usage is:</para>
        /// <para><c>Session usage = Number of attached sessions / (Total number of cloud desktop resources × Maximum number of sessions supported per cloud desktop) × 100%</c></para>
        /// <para>When the session usage reaches this threshold, new cloud desktops are created. When the session usage does not reach this threshold, excess cloud desktops are deleted.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("RatioThreshold")]
        [Validation(Required=false)]
        public float? RatioThreshold { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the regions supported by Wuying Cloud Computer.</para>
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
        /// <para>1422724566551XXX</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>The reset type of the cloud desktop.</para>
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
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss-f9dkjz6vw3aaw****</para>
        /// </summary>
        [NameInMap("ScaleStrategyId")]
        [Validation(Required=false)]
        public string ScaleStrategyId { get; set; }

        /// <summary>
        /// <para>The session type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SingleSession</para>
        /// </summary>
        [NameInMap("SessionType")]
        [Validation(Required=false)]
        public string SessionType { get; set; }

        /// <summary>
        /// <para>The ID of the convenience user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ug-3f6c8a2b****</para>
        /// </summary>
        [NameInMap("SimpleUserGroupId")]
        [Validation(Required=false)]
        public string SimpleUserGroupId { get; set; }

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
        /// <para>The idle shutdown time. When the idle time of a cloud desktop reaches this value, the cloud desktop is automatically shut down. If a user connects to the cloud desktop after it is shut down, the cloud desktop is automatically started. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("StopDuration")]
        [Validation(Required=false)]
        public long? StopDuration { get; set; }

        /// <summary>
        /// <para>The category of the system cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The performance level of the ESSD. Default value: PL0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("SystemDiskPerLevel")]
        [Validation(Required=false)]
        public string SystemDiskPerLevel { get; set; }

        /// <summary>
        /// <para>The size of the system cloud disk. Unit: GiB.</para>
        /// <remarks>
        /// <para>The size of the system cloud disk cannot be smaller than the size of the image file.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The list of tags. The list can contain up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDesktopGroupRequestTag> Tag { get; set; }
        public class CreateDesktopGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string. It can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be an empty string. It can be up to 128 characters in length, and cannot start with <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The ID of the scheduled task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-0caoeogrk9m5****</para>
        /// </summary>
        [NameInMap("TimerGroupId")]
        [Validation(Required=false)]
        public string TimerGroupId { get; set; }

        /// <summary>
        /// <para>The name of the user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D group</para>
        /// </summary>
        [NameInMap("UserGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

        /// <summary>
        /// <para>The path of the user organizational unit (OU).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
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
        /// <para>The ID of the KMS key used when disk encryption is enabled. You can obtain the key ID by calling the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
        /// </summary>
        [NameInMap("VolumeEncryptionKey")]
        [Validation(Required=false)]
        public string VolumeEncryptionKey { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where the office network of the shared cloud desktop resides.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
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
