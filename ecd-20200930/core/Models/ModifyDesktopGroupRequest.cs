// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-creation of cloud computers for the subscription cloud computer share. You must specify this parameter when <c>ChargeType</c> is set to <c>PrePaid</c>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disable auto-creation of cloud computers.</description></item>
        /// <item><description>1: enables auto-creation of cloud computers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowAutoSetup")]
        [Validation(Required=false)]
        public int? AllowAutoSetup { get; set; }

        /// <summary>
        /// <para>The maximum number of standby cloud computers that can be reserved within the pay-as-you-go cloud computer share. You must specify this property only when <c>ChargeType</c> is set to <c>PostPaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: does not reserve any cloud computer.</description></item>
        /// <item><description>N: reserves N cloud computers (1≤ N ≤ 100).</description></item>
        /// </list>
        /// <remarks>
        /// <para> Setting this parameter to 0 means no cloud computers will be reserved within the cloud computer share. In this case, the system must create, start, and assign cloud computers to end users upon request, which can be time-consuming. To improve user experience, we recommend that you reserve a specific number of cloud computers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowBufferCount")]
        [Validation(Required=false)]
        public int? AllowBufferCount { get; set; }

        /// <summary>
        /// <para>The number of concurrent sessions allowed for each cloud computer within the multi-session many-to-many share.</para>
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
        /// <list type="bullet">
        /// <item><description>For subscription cloud computer shares, this parameter specifies the number of purchased cloud computers. Valid values: 0 to 200.</description></item>
        /// <item><description>For pay-as-you-go cloud computer shares, this parameter specifies the minimum number of cloud computers created in the initial batch. Default value: 1. Valid values: 0 to <c>MaxDesktopsCount</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("BuyDesktopsCount")]
        [Validation(Required=false)]
        public int? BuyDesktopsCount { get; set; }

        /// <summary>
        /// <para>The type of the cloud computer share.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>teacher: teacher-oriented.</description></item>
        /// <item><description>student: student-oriented.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>teacher</para>
        /// </summary>
        [NameInMap("Classify")]
        [Validation(Required=false)]
        public string Classify { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The maximum period of time during which the session is connected. When the specified maximum period of time is reached, the session is automatically disconnected. Unit: milliseconds. Valid values: 900000 to 345600000. That is, the session can be connected for 15 to 5,760 minutes (4 days).</para>
        /// 
        /// <b>Example:</b>
        /// <para>600000</para>
        /// </summary>
        [NameInMap("ConnectDuration")]
        [Validation(Required=false)]
        public long? ConnectDuration { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer share.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The name of the cloud computer share.</para>
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
        /// <para>The ID of the File Storage NAS (NAS) file system for the user data roaming feature.</para>
        /// <remarks>
        /// <para> This parameter is unavailable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>04f314****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>After an end user connects to a cloud computer, the session is established. If the system does not detect inputs from the keyboard or mouse within the specified period of time, the session is closed. Unit: milliseconds. Valid values: 360000 to 3600000 (6 minutes to 60 minutes)</para>
        /// <para>End users can receive a prompt to save data before sessions are disconnected. The system sends the prompt 30 seconds before the specified period of time is reached. To prevent data loss, end users must save the data of the sessions.</para>
        /// <remarks>
        /// <para> This parameter is suitable only for cloud computers whose image version is v1.0.2 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("IdleDisconnectDuration")]
        [Validation(Required=false)]
        public long? IdleDisconnectDuration { get; set; }

        /// <summary>
        /// <para>The IDs of the images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktopimage-windows-server-2016-64-ch</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The retention period of a session after it is disconnected. Unit: milliseconds. Valid values: 180000 to 345600000. That is, the session can be retained for 3 to 5,760 minutes (4 days) after it is disconnected. If you set this parameter to 0, the session is permanently retained after it is disconnected.</para>
        /// <para>When a session is disconnected, take note of the following situations: If an end user does not resume the session within the specified duration, the session is closed and all unsaved data is cleared. If the end user resumes the session within the specified duration, the end user can continue to access data of the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("KeepDuration")]
        [Validation(Required=false)]
        public long? KeepDuration { get; set; }

        /// <summary>
        /// <para>The load balancing policy for the multi-session many-to-many share.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: depth first.</description></item>
        /// <item><description>1: breadth first.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LoadPolicy")]
        [Validation(Required=false)]
        public long? LoadPolicy { get; set; }

        /// <summary>
        /// <para>The maximum number of cloud computers allowed in the pay-as-you-go cloud computer share. Valid values: 0 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxDesktopsCount { get; set; }

        /// <summary>
        /// <para>The maximum number of auto-created cloud computers allowed in the subscription cloud computer share. You must specify this parameter when <c>ChargeType</c> is set to <c>PrePaid</c>. Default value: 1. Valid values: 0 to <c>MaxDesktopsCount</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDesktopsCount")]
        [Validation(Required=false)]
        public int? MinDesktopsCount { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-7t275tpgjueeu****</para>
        /// </summary>
        [NameInMap("OwnBundleId")]
        [Validation(Required=false)]
        public string OwnBundleId { get; set; }

        /// <summary>
        /// <para>The ID of the security policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-53iyi2aar0nd6****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of policy groups.</para>
        /// </summary>
        [NameInMap("PolicyGroupIds")]
        [Validation(Required=false)]
        public List<string> PolicyGroupIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable user data roaming.</para>
        /// <remarks>
        /// <para> This parameter is unavailable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProfileFollowSwitch")]
        [Validation(Required=false)]
        public bool? ProfileFollowSwitch { get; set; }

        /// <summary>
        /// <para>The threshold for the ratio of connected sessions, which triggers automatic scaling of cloud computers within the multi-session many-to-many share. To calculate the ratio of connected sessions, use the following formula:</para>
        /// <para><c>Ratio of connected sessions = Number of connected sessions/(Total number of cloud computers × Maximum number of sessions allowed for each cloud computer) × 100%</c></para>
        /// <para>If the session ratio exceeds the threshold, new cloud computers are provisioned. If it falls below the threshold, additional cloud computers are removed.</para>
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
        /// <para>The disk reset type of cloud computers.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: does not reset disks.</para>
        /// </description></item>
        /// <item><description><para>1: resets only the system disks.</para>
        /// </description></item>
        /// <item><description><para>2: resets only the user disks.</para>
        /// </description></item>
        /// <item><description><para>3: resets the system disks and user disks.</para>
        /// </description></item>
        /// </list>
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
        /// <para> This parameter is unavailable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s-kakowkdl****</para>
        /// </summary>
        [NameInMap("ScaleStrategyId")]
        [Validation(Required=false)]
        public string ScaleStrategyId { get; set; }

        /// <summary>
        /// <para>The period of time before the idle cloud computer enters the Stopped state. When the specified period of time is reached, the cloud computer is automatically stopped. If an end user connects to the stopped cloud computer, the cloud computer automatically starts. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180000</para>
        /// </summary>
        [NameInMap("StopDuration")]
        [Validation(Required=false)]
        public long? StopDuration { get; set; }

    }

}
