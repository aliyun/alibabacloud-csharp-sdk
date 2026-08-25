// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateSoftwarelibDistributeTaskRequest : TeaModel {
        /// <summary>
        /// <para>The collection of terminal device IDs. Duplicate values are not allowed. Each ID must not exceed 1000 characters in length. This parameter is required when MatchMode is set to DevTagNormal. This parameter is not allowed when MatchMode is set to other values. Otherwise, the request is rejected.</para>
        /// </summary>
        [NameInMap("DevTags")]
        [Validation(Required=false)]
        public List<string> DevTags { get; set; }

        /// <summary>
        /// <para>The collection of device group IDs. Duplicate values are not allowed. This parameter is required when MatchMode is set to DeviceGroupNormal. This parameter is not allowed when MatchMode is set to other values. Otherwise, the request is rejected. You can call <a href="~~ListDeviceGroups~~">ListDeviceGroups</a> to obtain the values.</para>
        /// </summary>
        [NameInMap("DeviceGroupIds")]
        [Validation(Required=false)]
        public List<string> DeviceGroupIds { get; set; }

        /// <summary>
        /// <para>The execution mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Once</b>: immediate execution.</description></item>
        /// <item><description><b>Schedule</b>: scheduled execution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("ExecuteMode")]
        [Validation(Required=false)]
        public string ExecuteMode { get; set; }

        /// <summary>
        /// <para>The scheduling execution parameters in JSON format.</para>
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
        /// <para>The task execution cycle in JSON format. The validType field specifies the cycle type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Once</b>: one-time execution.</description></item>
        /// <item><description><b>Interval</b>: execution at intervals.</description></item>
        /// <item><description><b>Weekly</b>: weekly execution.</description></item>
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
        /// <item><description><b>Expire</b>: expires at the time specified by GmtExpired.</description></item>
        /// <item><description><b>Never</b>: never expires.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Expire</para>
        /// </summary>
        [NameInMap("ExpireMode")]
        [Validation(Required=false)]
        public string ExpireMode { get; set; }

        /// <summary>
        /// <para>The task expiration time as a millisecond-level UNIX timestamp. This parameter takes effect only when ExpireMode is set to Expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786945543000</para>
        /// </summary>
        [NameInMap("GmtExpired")]
        [Validation(Required=false)]
        public string GmtExpired { get; set; }

        /// <summary>
        /// <para>The policy matching target type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: all users.</description></item>
        /// <item><description><b>UserGroupNormal</b>: specified user groups.</description></item>
        /// <item><description><b>DevTagNormal</b>: specified devices.</description></item>
        /// <item><description><b>DeviceGroupNormal</b>: specified device groups.</description></item>
        /// <item><description><b>DevTagAll</b>: all devices.</description></item>
        /// <item><description><b>None</b>: not configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupAll</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The task name. The name must be 1 to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_task</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of retries after a task failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RetryTimes")]
        [Validation(Required=false)]
        public string RetryTimes { get; set; }

        /// <summary>
        /// <para>The administrator account name used to run the task on Windows. The name must not exceed 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("RunAsAccount")]
        [Validation(Required=false)]
        public string RunAsAccount { get; set; }

        /// <summary>
        /// <para>The software ID in the software library. You can call <a href="~~ListSoftwarelibSoftware~~">ListSoftwarelibSoftware</a> to obtain the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>softwarelib-software-9f9de7b5a16f****</para>
        /// </summary>
        [NameInMap("SoftwareId")]
        [Validation(Required=false)]
        public string SoftwareId { get; set; }

        /// <summary>
        /// <para>The software name. The name must not exceed 128 characters in length.</para>
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
        /// <item><description><b>Mac(Apple)</b>: macOS with Apple silicon.</description></item>
        /// <item><description><b>Mac(Intel)</b>: macOS with Intel processors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Mac(Apple)</para>
        /// </summary>
        [NameInMap("SupportOs")]
        [Validation(Required=false)]
        public string SupportOs { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>server</b>: a task delivered from the console.</description></item>
        /// <item><description><b>client</b>: a task initiated from the client.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>server</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The task execution timeout period. Unit: seconds. For example, a value of 3600 indicates 1 hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public string Timeout { get; set; }

        /// <summary>
        /// <para>The collection of user group IDs. Duplicate values are not allowed. This parameter is required and must contain at least one value when MatchMode is set to UserGroupNormal. This parameter is not allowed when MatchMode is set to other values. Otherwise, the request is rejected. You can call <a href="~~ListUserGroups~~">ListUserGroups</a> to obtain the values.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The ID of the software version to distribute. You can call <a href="~~ListSoftwarelibVersion~~">ListSoftwarelibVersion</a> to obtain the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>softwarelib-version-30925615d2e4****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
