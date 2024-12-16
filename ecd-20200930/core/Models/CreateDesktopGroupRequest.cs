// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDesktopGroupRequest : TeaModel {
        /// <summary>
        /// <para>The end users whom you want to add to all types of desktop groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("AllClassifyUsers")]
        [Validation(Required=false)]
        public bool? AllClassifyUsers { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create cloud desktops in the desktop group if you set the billing method to subscription. If you set the ChargeType parameter to PrePaid, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowAutoSetup")]
        [Validation(Required=false)]
        public int? AllowAutoSetup { get; set; }

        /// <summary>
        /// <para>Specifies whether to reserve cloud desktops if you set the billing method to pay-as-you-go. If you set the ChargeType parameter to PostPaid, this parameter is required. Valid values: 0: does not allow the system to reserve cloud desktops. N: allows the system to reserve N cloud desktops. The variable N must be an integer that ranges from 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowBufferCount")]
        [Validation(Required=false)]
        public int? AllowBufferCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The number of sessions that are allowed per cloud desktop in a multi-session desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BindAmount")]
        [Validation(Required=false)]
        public long? BindAmount { get; set; }

        /// <summary>
        /// <para>The ID of the desktop template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-je9hani001wfn****</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// <para>The number of cloud desktops that you want to purchase. Valid values: 0 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BuyDesktopsCount")]
        [Validation(Required=false)]
        public int? BuyDesktopsCount { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud desktops in the desktop group.</para>
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
        /// <para>The remarks on the desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The maximum period of time during which the session is connected. When the specified maximum period of time is reached, the session automatically disconnects. Unit: milliseconds. This parameter is required only for cloud desktops in the same desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("ConnectDuration")]
        [Validation(Required=false)]
        public long? ConnectDuration { get; set; }

        /// <summary>
        /// <para>The default number of cloud desktops to create when you create the desktop group. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultInitDesktopCount")]
        [Validation(Required=false)]
        public int? DefaultInitDesktopCount { get; set; }

        /// <summary>
        /// <para>The name of the desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktopGroupName1</para>
        /// </summary>
        [NameInMap("DesktopGroupName")]
        [Validation(Required=false)]
        public string DesktopGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The end users that can use the desktop group.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The File Storage NAS (NAS) file system that is used after data roaming is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04f314****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The desktop group version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GroupVersion")]
        [Validation(Required=false)]
        public int? GroupVersion { get; set; }

        /// <summary>
        /// <para>The maximum period of time for which a session remains idle. If an end user performs no operations on a cloud desktop by using keyboards or mouses during a session, the session becomes idle. When the specified maximum period of time is reached, the session automatically disconnects. Unit: milliseconds. This parameter is required only for cloud desktops in the same desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("IdleDisconnectDuration")]
        [Validation(Required=false)]
        public long? IdleDisconnectDuration { get; set; }

        /// <summary>
        /// <para>The retention period of the cloud desktop after the end user disconnects from the cloud desktop. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000</para>
        /// </summary>
        [NameInMap("KeepDuration")]
        [Validation(Required=false)]
        public long? KeepDuration { get; set; }

        /// <summary>
        /// <para>The load balancing policy of the multi-session desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LoadPolicy")]
        [Validation(Required=false)]
        public long? LoadPolicy { get; set; }

        /// <summary>
        /// <para>The maximum number of cloud desktops that the desktop group can contain. Valid values: 0 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxDesktopsCount { get; set; }

        /// <summary>
        /// <para>The minimum number of cloud desktops that must be contained in the desktop group if you set the billing method to subscription. If you set the ChargeType parameter to PrePaid, this parameter is required. Valid values: 0 to the value of MaxDesktopsCount. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDesktopsCount")]
        [Validation(Required=false)]
        public int? MinDesktopsCount { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+os-c5cy7q578s8jc****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The type of the desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OwnType")]
        [Validation(Required=false)]
        public int? OwnType { get; set; }

        /// <summary>
        /// <para>The subscription period of the cloud desktops in the desktop group. The unit is specified by the PeriodUnit parameter. The Period parameter takes effect only if you set the ChargeType parameter to PrePaid.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values if you set the PeriodUnit parameter to Month:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values if you set the PeriodUnit parameter to Year:</para>
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
        /// <para>Specifies whether to enable data roaming.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProfileFollowSwitch")]
        [Validation(Required=false)]
        public bool? ProfileFollowSwitch { get; set; }

        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The threshold for the ratio of connected sessions. This parameter is the condition that triggers auto scaling in a multi-session desktop group. <c>Ratio of connected sessions = Number of connected sessions/(Total number of cloud desktops × Maximum number of sessions allowed for each cloud desktop) × 100%</c>. When the specified threshold is reached, new cloud desktops are automatically created. When the specified threshold is not reached, idle cloud desktops are released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("RatioThreshold")]
        [Validation(Required=false)]
        public float? RatioThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies which type of the disk to reset for cloud desktops in the desktop group.</para>
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
        /// <para>This parameter is unavailable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("ScaleStrategyId")]
        [Validation(Required=false)]
        public string ScaleStrategyId { get; set; }

        /// <summary>
        /// <para>The period of time before the idle cloud desktop is stopped. When the specified period of time is reached, the idle cloud desktop automatically stops. If an end user connects to a stopped cloud desktop, the cloud desktop automatically starts. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("StopDuration")]
        [Validation(Required=false)]
        public long? StopDuration { get; set; }

        /// <summary>
        /// <para>The tags that you want to attach to the cloud computer pool. You can specify 1 to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDesktopGroupRequestTag> Tag { get; set; }
        public class CreateDesktopGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. If you specify the <c>Tag</c> parameter, you must also specify the <c>Key</c> parameter. The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>. You cannot specify an empty string as a tag key.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. The tag value can be an empty string. The tag value can be up to 128 characters in length. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The ID of the virtual private cloud (VPC) in which you want to create the desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
