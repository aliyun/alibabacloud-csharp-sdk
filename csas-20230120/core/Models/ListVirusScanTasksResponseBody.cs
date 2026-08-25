// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of virus scan tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListVirusScanTasksResponseBodyTasks> Tasks { get; set; }
        public class ListVirusScanTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The time when the task was created, in the yyyy-MM-dd HH:mm:ss format. The time is in the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-21 10:24:31</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The effective scope specified by organizational structure.</para>
            /// </summary>
            [NameInMap("CustomMatchGroup")]
            [Validation(Required=false)]
            public List<ListVirusScanTasksResponseBodyTasksCustomMatchGroup> CustomMatchGroup { get; set; }
            public class ListVirusScanTasksResponseBodyTasksCustomMatchGroup : TeaModel {
                /// <summary>
                /// <para>The collection of organizational structure nodes.</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public List<string> Group { get; set; }

                /// <summary>
                /// <para>The ID of the identity provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idp-7c3f9a2e5b18****</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public string IdpId { get; set; }

            }

            /// <summary>
            /// <para>The time when the task expires, in seconds-level UNIX timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786377600</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The action to take on high-risk virus files. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Quarantine</b>: Quarantine quarantined file.</description></item>
            /// <item><description><b>Notify</b>: Report an alert only without taking action on quarantined file.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Quarantine</para>
            /// </summary>
            [NameInMap("HighRiskOperation")]
            [Validation(Required=false)]
            public string HighRiskOperation { get; set; }

            /// <summary>
            /// <para>The action to take on low-risk virus files. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Quarantine</b>: Quarantine quarantined file.</description></item>
            /// <item><description><b>Notify</b>: Report an alert only without taking action on quarantined file.</description></item>
            /// <item><description><b>None</b>: Take no action.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("LowRiskOperation")]
            [Validation(Required=false)]
            public string LowRiskOperation { get; set; }

            /// <summary>
            /// <para>The matching mode for the effective scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: Applies to all users under the current Alibaba Cloud account.</description></item>
            /// <item><description><b>UserGroupNormal</b>: Applies only to users in specified user groups.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UserGroupNormal</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

            /// <summary>
            /// <para>The collection of user groups to which the task applies.</para>
            /// </summary>
            [NameInMap("MatchTargetInfos")]
            [Validation(Required=false)]
            public List<ListVirusScanTasksResponseBodyTasksMatchTargetInfos> MatchTargetInfos { get; set; }
            public class ListVirusScanTasksResponseBodyTasksMatchTargetInfos : TeaModel {
                /// <summary>
                /// <para>The ID of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usergroup-9d4f2a7b3c1e****</para>
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

                /// <summary>
                /// <para>The name of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>R&amp;D Department</para>
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

            }

            /// <summary>
            /// <para>The maximum percentage of endpoint CPU usage allowed during scanning.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MaxCpuUsage")]
            [Validation(Required=false)]
            public long? MaxCpuUsage { get; set; }

            /// <summary>
            /// <para>The action to take on medium-risk virus files. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Quarantine</b>: Quarantine quarantined file.</description></item>
            /// <item><description><b>Notify</b>: Report an alert only without taking action on quarantined file.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Notify</para>
            /// </summary>
            [NameInMap("MidRiskOperation")]
            [Validation(Required=false)]
            public string MidRiskOperation { get; set; }

            /// <summary>
            /// <para>The scan performance schema pattern. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SecurityFirst</b>: Security first. The default CPU usage upper limit is 50%.</description></item>
            /// <item><description><b>Balance</b>: Balanced. The default CPU usage upper limit is 30%.</description></item>
            /// <item><description><b>ExperienceFirst</b>: Experience first. The default CPU usage upper limit is 15%.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Balance</para>
            /// </summary>
            [NameInMap("PerformanceMode")]
            [Validation(Required=false)]
            public string PerformanceMode { get; set; }

            /// <summary>
            /// <para>The scan path scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Quick</b>: Quick scan. Only scans critical system directories and common risk locations.</description></item>
            /// <item><description><b>Full</b>: Full scan.</description></item>
            /// <item><description><b>Custom</b>: Custom path scan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Quick</para>
            /// </summary>
            [NameInMap("ScanMode")]
            [Validation(Required=false)]
            public string ScanMode { get; set; }

            /// <summary>
            /// <para>The collection of custom scan paths.</para>
            /// </summary>
            [NameInMap("ScanPath")]
            [Validation(Required=false)]
            public List<string> ScanPath { get; set; }

            /// <summary>
            /// <para>The collection of virus types to be handled in this scan.</para>
            /// </summary>
            [NameInMap("ScanTargets")]
            [Validation(Required=false)]
            public List<string> ScanTargets { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not canceled.</description></item>
            /// <item><description><b>1</b>: Canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The description of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Full scan for R&amp;D department</para>
            /// </summary>
            [NameInMap("TaskDescription")]
            [Validation(Required=false)]
            public string TaskDescription { get; set; }

            /// <summary>
            /// <para>The ID of the virus scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1:1024772</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The list of exempted users.</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public List<string> Whitelist { get; set; }

        }

        /// <summary>
        /// <para>The total number of virus scan tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
