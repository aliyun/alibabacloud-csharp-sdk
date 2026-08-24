// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVulScanTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of vulnerability scanning tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListVulScanTasksResponseBodyTasks> Tasks { get; set; }
        public class ListVulScanTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The task creation time, in seconds-level UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786291200</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The effective scope specified by organizational structure. An empty list is returned if no organizational structure is configured.</para>
            /// </summary>
            [NameInMap("CustomMatchGroup")]
            [Validation(Required=false)]
            public List<ListVulScanTasksResponseBodyTasksCustomMatchGroup> CustomMatchGroup { get; set; }
            public class ListVulScanTasksResponseBodyTasksCustomMatchGroup : TeaModel {
                /// <summary>
                /// <para>The collection of organizational structure nodes.</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public List<string> Group { get; set; }

                /// <summary>
                /// <para>The identity provider ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idp-7c3f9a2e5b18****</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public string IdpId { get; set; }

            }

            /// <summary>
            /// <para>The task expiration time, in seconds-level UNIX timestamp. After this time, endpoints no longer pull and execute this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786291200</para>
            /// </summary>
            [NameInMap("EndTimestamp")]
            [Validation(Required=false)]
            public long? EndTimestamp { get; set; }

            /// <summary>
            /// <para>The matching mode of the effective scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: applies to all users under the current Alibaba Cloud account.</description></item>
            /// <item><description><b>UserGroupNormal</b>: applies only to users within specified user groups.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UserGroupNormal</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

            /// <summary>
            /// <para>The collection of effective user group IDs. An empty list is returned when MatchMode is UserGroupAll.</para>
            /// </summary>
            [NameInMap("MatchTargetIds")]
            [Validation(Required=false)]
            public List<string> MatchTargetIds { get; set; }

            /// <summary>
            /// <para>The ID of the vulnerability scheduled scan policy that triggered this task. An empty string is returned when TaskType is Instant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vul-scan-scheduled-strategy-8a3f6c2e91b7****</para>
            /// </summary>
            [NameInMap("ScheduledStrategyId")]
            [Validation(Required=false)]
            public string ScheduledStrategyId { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: the task is in progress and still within the validity period.</description></item>
            /// <item><description><b>Expired</b>: the task has expired and exceeded the validity period.</description></item>
            /// <item><description><b>Canceled</b>: the task has been canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The execution statistics of this task on user endpoint devices within the effective scope.</para>
            /// </summary>
            [NameInMap("TargetDeviceCount")]
            [Validation(Required=false)]
            public ListVulScanTasksResponseBodyTasksTargetDeviceCount TargetDeviceCount { get; set; }
            public class ListVulScanTasksResponseBodyTasksTargetDeviceCount : TeaModel {
                /// <summary>
                /// <para>The number of user endpoint devices that have acknowledged receipt of this task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("AckCount")]
                [Validation(Required=false)]
                public long? AckCount { get; set; }

                /// <summary>
                /// <para>The number of user endpoint devices on which the scan failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FailCount")]
                [Validation(Required=false)]
                public long? FailCount { get; set; }

                /// <summary>
                /// <para>The number of user endpoint devices currently executing the scan. This value is calculated by subtracting SuccessCount and FailCount from AckCount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("StartCount")]
                [Validation(Required=false)]
                public long? StartCount { get; set; }

                /// <summary>
                /// <para>The number of user endpoint devices on which the scan succeeded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

            }

            /// <summary>
            /// <para>The task description. An empty string is returned if no description is specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Execute a vulnerability scanning on R&amp;D department endpoints</para>
            /// </summary>
            [NameInMap("TaskDescription")]
            [Validation(Required=false)]
            public string TaskDescription { get; set; }

            /// <summary>
            /// <para>The vulnerability scanning task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vul-scan-task-4d7b1e9a6c38****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D department vulnerability scanning</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Instant</b>: an instant task created by CreateVulScanTask.</description></item>
            /// <item><description><b>Scheduled</b>: a scheduled task automatically created by a vulnerability scheduled scan policy on a periodic basis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Instant</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The total number of vulnerabilities detected by this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public long? VulCount { get; set; }

            /// <summary>
            /// <para>The list of exempted users. Users in this list are excluded from the scan. An empty list is returned if no exemption is configured.</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public List<string> Whitelist { get; set; }

        }

        /// <summary>
        /// <para>The total number of vulnerability scanning tasks that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
