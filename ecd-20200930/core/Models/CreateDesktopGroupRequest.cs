// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDesktopGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to authorize all users in the desktop group\&quot;s categories.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("AllClassifyUsers")]
        [Validation(Required=false)]
        public bool? AllClassifyUsers { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow automatic creation of desktops in the subscription desktop group. This parameter is required and applies only when <c>ChargeType</c> is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowAutoSetup")]
        [Validation(Required=false)]
        public int? AllowAutoSetup { get; set; }

        /// <summary>
        /// <para>The number of desktops to reserve in the pay-as-you-go desktop group. This parameter is required and applies only when <c>ChargeType</c> is set to <c>PostPaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Does not reserve desktops.</para>
        /// </description></item>
        /// <item><description><para>N: Reserves N desktops, where N is an integer from 1 to 100.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If no desktops are reserved, a user must wait for a new desktop to be created and started, which can cause connection delays. We recommend reserving an appropriate number of desktops to improve connection times.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowBufferCount")]
        [Validation(Required=false)]
        public int? AllowBufferCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically pay for subscription orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the subscription desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The number of concurrent sessions allowed per desktop in a multi-session desktop group.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BindAmount")]
        [Validation(Required=false)]
        public long? BindAmount { get; set; }

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
        /// <list type="bullet">
        /// <item><description><para>For <c>subscription</c> desktop groups: The number of desktops to purchase. Valid values: 0 to 200.</para>
        /// </description></item>
        /// <item><description><para>For <c>pay-as-you-go</c> desktop groups: The minimum number of desktops in the group. Valid values: 0 to <c>MaxDesktopsCount</c>. The default value is 1.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BuyDesktopsCount")]
        [Validation(Required=false)]
        public int? BuyDesktopsCount { get; set; }

        /// <summary>
        /// <para>The billing method of the desktops.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The type of the desktop group.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>teacher</para>
        /// </summary>
        [NameInMap("Classify")]
        [Validation(Required=false)]
        public string Classify { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. You can use your client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>A description or comments for the desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The maximum duration of a connected session. When the session duration reaches this value, the session is automatically disconnected. Unit: milliseconds. Valid values: 900000 (15 minutes) to 345600000 (4 days).</para>
        /// 
        /// <b>Example:</b>
        /// <para>900000</para>
        /// </summary>
        [NameInMap("ConnectDuration")]
        [Validation(Required=false)]
        public long? ConnectDuration { get; set; }

        /// <summary>
        /// <para>The type of the data disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("DataDiskCategory")]
        [Validation(Required=false)]
        public string DataDiskCategory { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the ESSD. Default value: PL0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("DataDiskPerLevel")]
        [Validation(Required=false)]
        public string DataDiskPerLevel { get; set; }

        /// <summary>
        /// <para>The size of the data disk. Unit: GiB. The value must be a multiple of 20 and in the range of 0 to 16,380.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>A value of 0 indicates that no data disk is attached.</para>
        /// </description></item>
        /// <item><description><para>If the selected bundle uses an Enhanced SSD (ESSD) at PL0, the minimum data disk size is 40 GiB.</para>
        /// </description></item>
        /// <item><description><para>If the selected bundle uses an SSD, the minimum data disk size is 20 GiB.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>A value of 0 indicates that no data disk is attached.</para>
        /// </description></item>
        /// <item><description><para>If the selected bundle uses an SSD, the minimum data disk size is 20 GiB.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        /// <summary>
        /// <para>The default number of desktops to create in the desktop group. The default value is 1.</para>
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

        [NameInMap("DeleteDuration")]
        [Validation(Required=false)]
        public long? DeleteDuration { get; set; }

        /// <summary>
        /// <para>The name of the desktop group. The name must be 1 to 30 characters long, start with a letter or a Chinese character, and must not begin with <c>http://</c> or <c>https://</c>. The name can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), or hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SharedComputers01</para>
        /// </summary>
        [NameInMap("DesktopGroupName")]
        [Validation(Required=false)]
        public string DesktopGroupName { get; set; }

        /// <summary>
        /// <para>The desktop type. You can call the <a href="~~DescribeDesktopTypes~~">DescribeDesktopTypes</a> operation to query supported desktop types.</para>
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
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dri-uf62w3qzt4aigvlcb****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>An array of user IDs to authorize for the desktop group.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>Specifies the pool type. To create a static pool, set this parameter to <c>Exclusive</c>. This is required if <c>SessionType</c> is <c>MultipleSession</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("ExclusiveType")]
        [Validation(Required=false)]
        public string ExclusiveType { get; set; }

        /// <summary>
        /// <para>The ID of the Apsara File Storage NAS file system used for user data roaming.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>kegd-nas-****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The number of individual desktops to create. This parameter is required only if <c>MultiResource</c> is set to <c>false</c>. Valid values: 1 to 5. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupAmount")]
        [Validation(Required=false)]
        public int? GroupAmount { get; set; }

        /// <summary>
        /// <para>The version of the desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GroupVersion")]
        [Validation(Required=false)]
        public int? GroupVersion { get; set; }

        /// <summary>
        /// <para>The custom hostname for the desktops. This parameter is applicable only to Windows desktops in an AD office network.</para>
        /// <para>The hostname must meet the following naming conventions:</para>
        /// <list type="bullet">
        /// <item><description><para>Must be 2 to 15 characters in length.</para>
        /// </description></item>
        /// <item><description><para>Can contain letters, digits, and hyphens (-). It cannot start or end with a hyphen, contain consecutive hyphens, or consist only of digits.</para>
        /// </description></item>
        /// </list>
        /// <para>To generate sequential hostnames when creating multiple desktops, use the format <c>name_prefix[begin_number,bits]name_suffix</c>. For example, if you set the Hostname parameter to <c>ecd-[1,4]-test</c>, the first desktop is named ecd-0001-test, the second is named ecd-0002-test, and so on.</para>
        /// <list type="bullet">
        /// <item><description><para><c>name_prefix</c>: The prefix of the hostname.</para>
        /// </description></item>
        /// <item><description><para><c>[begin_number,bits]</c>: The sequential number in the hostname. <c>begin_number</c> is the starting number, which can be an integer from 0 to 999999. The default value is 0. <c>bits</c> is the number of digits, which can be an integer from 1 to 6. The default value is 6.</para>
        /// </description></item>
        /// <item><description><para><c>name_suffix</c>: The suffix of the hostname.</para>
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
        /// <para>The maximum duration that a session can be idle before it is automatically disconnected. A session is considered idle if there is no keyboard or mouse input. Unit: milliseconds. Valid values: 360000 (6 minutes) to 3600000 (60 minutes).</para>
        /// <para>Thirty seconds before disconnection, the user is prompted to save their work to prevent data loss.</para>
        /// <remarks>
        /// <para>This parameter applies only to desktops created from image version 1.0.2 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>360000</para>
        /// </summary>
        [NameInMap("IdleDisconnectDuration")]
        [Validation(Required=false)]
        public long? IdleDisconnectDuration { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-gx2x1dhsmusr2****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The duration for which a session is kept active after a user disconnects. Unit: milliseconds. Valid values: 180000 (3 minutes) to 345600000 (4 days). A value of 0 indicates that the session is retained indefinitely.</para>
        /// <para>If a user reconnects within this period, they can resume their session. If they fail to reconnect, the session is terminated, and any unsaved data is lost.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180000</para>
        /// </summary>
        [NameInMap("KeepDuration")]
        [Validation(Required=false)]
        public long? KeepDuration { get; set; }

        /// <summary>
        /// <para>The load balancing policy for the multi-session desktop group.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LoadPolicy")]
        [Validation(Required=false)]
        public long? LoadPolicy { get; set; }

        /// <summary>
        /// <para>The maximum number of desktops in the pay-as-you-go desktop group. Valid values: 0 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxDesktopsCount { get; set; }

        /// <summary>
        /// <para>The minimum number of desktops in the subscription desktop group. This parameter is required only if <c>ChargeType</c> is <c>PrePaid</c>. Valid values: 0 to <c>MaxDesktopsCount</c>. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDesktopsCount")]
        [Validation(Required=false)]
        public int? MinDesktopsCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MultiResource")]
        [Validation(Required=false)]
        public bool? MultiResource { get; set; }

        /// <summary>
        /// <para>The ID of the office network for the desktops.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+os-c5cy7q578s8jc****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The type of the desktop.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OwnType")]
        [Validation(Required=false)]
        public int? OwnType { get; set; }

        /// <summary>
        /// <para>The subscription duration for the desktops. This parameter is required only if <c>ChargeType</c> is set to <c>PrePaid</c>. The <c>PeriodUnit</c> parameter specifies the time unit for this duration.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PeriodUnit</c> is <c>Month</c>, the valid values are:</para>
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
        /// <item><description><para>If <c>PeriodUnit</c> is <c>Year</c>, the valid values are:</para>
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
        /// <para>The time unit of the subscription period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the policy to apply to the desktops.</para>
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
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProfileFollowSwitch")]
        [Validation(Required=false)]
        public bool? ProfileFollowSwitch { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_*****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The session usage threshold that triggers auto scaling for multi-session desktop groups. Session usage is calculated by using the following formula:</para>
        /// <para><c>Session usage = (Number of connected sessions / (Total number of desktops × Maximum number of sessions per desktop)) × 100%</c></para>
        /// <para>When session usage reaches this threshold, new desktops are created. When session usage falls below this threshold, the group scales in by deleting surplus desktops.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("RatioThreshold")]
        [Validation(Required=false)]
        public float? RatioThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the region. To find the regions supported by Elastic Desktop Service (EDS), call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation.</para>
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
        /// <para>The desktop reset type.</para>
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
        /// <para>This parameter is not yet available.</para>
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
        /// <para>The amount of time a desktop can be idle before it is automatically stopped. Connecting to a stopped desktop automatically starts it. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("StopDuration")]
        [Validation(Required=false)]
        public long? StopDuration { get; set; }

        /// <summary>
        /// <para>The type of the system disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the ESSD. Default value: PL0.</para>
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
        /// <para>The system disk size must be at least the size of the image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The list of tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDesktopGroupRequestTag> Tag { get; set; }
        public class CreateDesktopGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key cannot be an empty string, can be up to 128 characters long, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. The value can be an empty string. The value can be up to 128 characters in length and cannot start with <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The ID of the key from Key Management Service (KMS) used for disk encryption. You can call the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation to obtain the key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
        /// </summary>
        [NameInMap("VolumeEncryptionKey")]
        [Validation(Required=false)]
        public string VolumeEncryptionKey { get; set; }

        /// <summary>
        /// <para>The ID of the Virtual Private Cloud (VPC) that contains the office network for the desktops.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
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
