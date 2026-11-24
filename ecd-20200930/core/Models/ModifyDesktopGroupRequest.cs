// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow automatic creation of cloud desktops in a subscription shared cloud desktop. This parameter takes effect and is required only when the <c>ChargeType</c> parameter is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowAutoSetup")]
        [Validation(Required=false)]
        public int? AllowAutoSetup { get; set; }

        /// <summary>
        /// <para>The number of reserved cloud desktops allowed in a pay-as-you-go shared cloud desktop. This parameter takes effect and is required only when the <c>ChargeType</c> parameter is set to <c>PostPaid</c>. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>0: No reserved cloud desktops.</description></item>
        /// <item><description>N: N reserved cloud desktops (1 ≤ N ≤ 100).</description></item>
        /// </list>
        /// <remarks>
        /// <para>If no available cloud desktops are reserved, when an end user initiates a connection request, the system must first create and start a cloud desktop and then assign it to the user, which takes a relatively long time. Reserve a certain number of cloud desktops as needed to ensure the user experience.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowBufferCount")]
        [Validation(Required=false)]
        public int? AllowBufferCount { get; set; }

        /// <summary>
        /// <para>The number of concurrent sessions allowed per cloud desktop in multi-session and multi-desktop shared cloud desktops.</para>
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
        /// <list type="bullet">
        /// <item><description>For a subscription shared cloud desktop: the number of cloud desktops to purchase. Valid values: 0 to 200.</description></item>
        /// <item><description>For a pay-as-you-go shared cloud desktop: the minimum number of cloud desktops to create in the pool. Default value: 1. Valid values: 0 to the value of <c>MaxDesktopsCount</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("BuyDesktopsCount")]
        [Validation(Required=false)]
        public int? BuyDesktopsCount { get; set; }

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
        /// <para>The retention period before a cloud desktop in the cloud desktop pool is automatically deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("DeleteDuration")]
        [Validation(Required=false)]
        public long? DeleteDuration { get; set; }

        /// <summary>
        /// <para>The ID of the shared cloud desktop.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The name of the shared cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktopGroupName1</para>
        /// </summary>
        [NameInMap("DesktopGroupName")]
        [Validation(Required=false)]
        public string DesktopGroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableSessionConfig")]
        [Validation(Required=false)]
        public bool? DisableSessionConfig { get; set; }

        /// <summary>
        /// <para>The ID of the NAS file system used for the user data roaming feature.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>04f314****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The maximum idle time before a user session is disconnected. If no keyboard or mouse operations are performed within this maximum duration after a user session is connected, the session is disconnected. Unit: milliseconds. Valid values: 360000 (6 minutes) to 3600000 (60 minutes).</para>
        /// <para>30 seconds before this duration is reached, the end user in the session receives a prompt message to save document data. The end user must save the document data promptly to avoid data loss.</para>
        /// <remarks>
        /// <para>This parameter applies only to cloud desktops with an image version of 1.0.2 or later.</para>
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
        /// <para>desktopimage-windows-server-2016-64-ch</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The retention period after a session is disconnected. Unit: milliseconds. Valid values: 180000 (3 minutes) to 345600000 (4 days). A value of 0 indicates that the session is always retained.</para>
        /// <para>If a session is disconnected intentionally by the user or unexpectedly due to other factors, the retention period starts from the time of disconnection. If the user does not reconnect to the session within this period, the session is logged off and unsaved data is destroyed. If the user successfully reconnects within this period, the user can enter the original session and access the data before the disconnection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180000</para>
        /// </summary>
        [NameInMap("KeepDuration")]
        [Validation(Required=false)]
        public long? KeepDuration { get; set; }

        /// <summary>
        /// <para>The load balancing policy for multi-session and multi-desktop shared cloud desktops.</para>
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
        /// <para>The maximum number of cloud desktops that can be accommodated in a pay-as-you-go shared cloud desktop. Valid values: 0 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxDesktopsCount { get; set; }

        /// <summary>
        /// <para>The upper limit for the automatic creation of cloud desktops in a subscription shared cloud desktop. This parameter takes effect and is required only when the <c>ChargeType</c> parameter is set to <c>PrePaid</c>. Default value: 1. Valid values: 0 to the value of <c>MaxDesktopsCount</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDesktopsCount")]
        [Validation(Required=false)]
        public int? MinDesktopsCount { get; set; }

        /// <summary>
        /// <para>The ID of the cloud desktop template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-7t275tpgjueeu****</para>
        /// </summary>
        [NameInMap("OwnBundleId")]
        [Validation(Required=false)]
        public string OwnBundleId { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-53iyi2aar0nd6****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The list of policy group IDs.</para>
        /// </summary>
        [NameInMap("PolicyGroupIds")]
        [Validation(Required=false)]
        public List<string> PolicyGroupIds { get; set; }

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
        /// <para>The session usage threshold, which is used as the trigger for automatic scaling of multi-session and multi-desktop shared cloud desktops. The formula for session usage is:</para>
        /// <para><c>Session usage = Number of attached sessions / (Total number of cloud desktop resources × Maximum number of sessions supported per cloud desktop) × 100%</c></para>
        /// <para>When the session usage reaches this threshold, new cloud desktops are created. When the session usage does not reach this threshold, excess cloud desktops are deleted.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0.85</para>
        /// </summary>
        [NameInMap("RatioThreshold")]
        [Validation(Required=false)]
        public float? RatioThreshold { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The ID of the scaling policy group.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s-kakowkdl****</para>
        /// </summary>
        [NameInMap("ScaleStrategyId")]
        [Validation(Required=false)]
        public string ScaleStrategyId { get; set; }

        /// <summary>
        /// <para>The idle shutdown time. When the idle time of a cloud desktop reaches this value, the cloud desktop is automatically shut down. If a user connects to the cloud desktop after it is shut down, the cloud desktop is automatically started. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("StopDuration")]
        [Validation(Required=false)]
        public long? StopDuration { get; set; }

    }

}
