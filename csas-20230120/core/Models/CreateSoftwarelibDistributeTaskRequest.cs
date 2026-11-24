// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateSoftwarelibDistributeTaskRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the terminal devices. Duplicate IDs are not allowed. A single ID can be up to 1,000 characters in length. This parameter is required when MatchMode is set to DevTagNormal. If MatchMode is set to other values, this parameter must not be specified. Otherwise, the request is rejected.</para>
        /// </summary>
        [NameInMap("DevTags")]
        [Validation(Required=false)]
        public List<string> DevTags { get; set; }

        /// <summary>
        /// <para>The IDs of the device groups. Duplicate IDs are not allowed. This parameter is required when MatchMode is set to DeviceGroupNormal. If MatchMode is set to other values, this parameter must not be specified. Otherwise, the request is rejected. You can obtain the values by calling the <a href="~~ListDeviceGroups~~">ListDeviceGroups</a> operation.</para>
        /// </summary>
        [NameInMap("DeviceGroupIds")]
        [Validation(Required=false)]
        public List<string> DeviceGroupIds { get; set; }

        /// <summary>
        /// <para>The execution mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Once</b>: Immediate execution.</description></item>
        /// <item><description><b>Schedule</b>: Scheduled execution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("ExecuteMode")]
        [Validation(Required=false)]
        public string ExecuteMode { get; set; }

        /// <summary>
        /// <para>The scheduled execution parameters. The value is a JSON-formatted string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;template_code&quot;: &quot;software_install&quot;,
        ///     &quot;software_url&quot;: &quot;https://****&quot;,
        ///     &quot;md5&quot;: &quot;87ccfcce1956e9f2385137f690d7fb64&quot;,
        ///     &quot;install_check_switch&quot;: false,
        ///     &quot;software_name&quot;: &quot;&quot;,
        ///     &quot;software_name_en&quot;: &quot;&quot;,
        ///     &quot;speed_limit&quot;: 0,
        ///     &quot;software_id&quot;: &quot;softwarelib-software-18a2417da2779e65&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ExecuteParameters")]
        [Validation(Required=false)]
        public string ExecuteParameters { get; set; }

        /// <summary>
        /// <para>The execution cycle of the task. The value is a JSON-formatted string. The validType field specifies the cycle type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Once</b>: Single execution.</description></item>
        /// <item><description><b>Interval</b>: Interval-based execution.</description></item>
        /// <item><description><b>Weekly</b>: Weekly execution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;validType&quot;:&quot;Once&quot;}</para>
        /// </summary>
        [NameInMap("ExecutePeriod")]
        [Validation(Required=false)]
        public string ExecutePeriod { get; set; }

        /// <summary>
        /// <para>The expiration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Expire</b>: The task expires at the time specified by GmtExpired.</description></item>
        /// <item><description><b>Never</b>: The task never expires.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Expire</para>
        /// </summary>
        [NameInMap("ExpireMode")]
        [Validation(Required=false)]
        public string ExpireMode { get; set; }

        /// <summary>
        /// <para>The expiration time of the task. The value is a UNIX timestamp in milliseconds. This parameter takes effect only when ExpireMode is set to Expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786945543000</para>
        /// </summary>
        [NameInMap("GmtExpired")]
        [Validation(Required=false)]
        public string GmtExpired { get; set; }

        /// <summary>
        /// <para>The target type for policy matching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: All users.</description></item>
        /// <item><description><b>UserGroupNormal</b>: Specified user groups.</description></item>
        /// <item><description><b>DevTagNormal</b>: Specified devices.</description></item>
        /// <item><description><b>DeviceGroupNormal</b>: Specified device groups.</description></item>
        /// <item><description><b>DevTagAll</b>: All devices.</description></item>
        /// <item><description><b>None</b>: Not configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupAll</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The name of the task. The name must be 1 to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_task</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of retries after the task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RetryTimes")]
        [Validation(Required=false)]
        public string RetryTimes { get; set; }

        /// <summary>
        /// <para>The name of the administrator account used to execute the task in Windows. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("RunAsAccount")]
        [Validation(Required=false)]
        public string RunAsAccount { get; set; }

        /// <summary>
        /// <para>The ID of the software in the software library. You can obtain the value by calling the <a href="~~ListSoftwarelibSoftware~~">ListSoftwarelibSoftware</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>softwarelib-software-9f9de7b5a16f****</para>
        /// </summary>
        [NameInMap("SoftwareId")]
        [Validation(Required=false)]
        public string SoftwareId { get; set; }

        /// <summary>
        /// <para>The name of the software. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test software</para>
        /// </summary>
        [NameInMap("SoftwareName")]
        [Validation(Required=false)]
        public string SoftwareName { get; set; }

        /// <summary>
        /// <para>The operating system to which the task applies. Only a single value is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Windows</b>: Windows.</description></item>
        /// <item><description><b>Mac(Apple)</b>: macOS on Apple silicon.</description></item>
        /// <item><description><b>Mac(Intel)</b>: macOS on Intel processors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Mac(Apple)</para>
        /// </summary>
        [NameInMap("SupportOs")]
        [Validation(Required=false)]
        public string SupportOs { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>server</b>: Tasks delivered from the console.</description></item>
        /// <item><description><b>client</b>: Tasks initiated by the client.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>server</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The timeout period for task execution. Unit: seconds. For example, a value of 3600 indicates 1 hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public string Timeout { get; set; }

        /// <summary>
        /// <para>The IDs of the user groups. Duplicate IDs are not allowed. This parameter is required and must contain at least one ID when MatchMode is set to UserGroupNormal. If MatchMode is set to other values, this parameter must not be specified. Otherwise, the request is rejected. You can obtain the values by calling the <a href="~~ListUserGroups~~">ListUserGroups</a> operation.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The ID of the software version to be distributed. When you create a software version, you can obtain the value from the VersionId response parameter of the <a href="~~CreateSoftwarelibVersion~~">CreateSoftwarelibVersion</a> operation. For more information about how to view and manage software versions, see <a href="https://www.alibabacloud.com/help/en/sase/user-guide/software-management">Software management</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>softwarelib-version-30925615d2e4****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
