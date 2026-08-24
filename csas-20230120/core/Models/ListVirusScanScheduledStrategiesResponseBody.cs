// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanScheduledStrategiesResponseBody : TeaModel {
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
        /// <para>The list of scheduled virus scan policies.</para>
        /// </summary>
        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public List<ListVirusScanScheduledStrategiesResponseBodyStrategies> Strategies { get; set; }
        public class ListVirusScanScheduledStrategiesResponseBodyStrategies : TeaModel {
            /// <summary>
            /// <para>The time when the policy was created, in the format of yyyy-MM-dd HH:mm:ss. The time is in UTC+8.</para>
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
            public List<ListVirusScanScheduledStrategiesResponseBodyStrategiesCustomMatchGroup> CustomMatchGroup { get; set; }
            public class ListVirusScanScheduledStrategiesResponseBodyStrategiesCustomMatchGroup : TeaModel {
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
            /// <para>The time when the policy last triggered a scan, in the format of yyyy-MM-dd HH:mm:ss. The time is in UTC+8. An empty string is returned if the policy has never been triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-21 01:00:03</para>
            /// </summary>
            [NameInMap("LastTriggerTime")]
            [Validation(Required=false)]
            public string LastTriggerTime { get; set; }

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
            /// <para>The collection of user group IDs to which the policy applies. An empty list is returned when MatchMode is set to UserGroupAll.</para>
            /// </summary>
            [NameInMap("MatchTargetIds")]
            [Validation(Required=false)]
            public List<string> MatchTargetIds { get; set; }

            /// <summary>
            /// <para>The maximum percentage of terminal CPU usage allowed during scanning.</para>
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
            /// <para>The policy priority. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The start hour during which the scan can be triggered. The value is a whole hour number ranging from 0 to 23, inclusive. This field is not a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScanBeginTime")]
            [Validation(Required=false)]
            public int? ScanBeginTime { get; set; }

            /// <summary>
            /// <para>The end hour during which the scan can be triggered. The value is a whole hour number ranging from 1 to 24, exclusive of the specified hour, and must be greater than ScanBeginTime. The scan task generated by each trigger expires at this hour on the same day. This field is not a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("ScanEndTime")]
            [Validation(Required=false)]
            public int? ScanEndTime { get; set; }

            /// <summary>
            /// <para>The unit of the trigger cycle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>day</b>: By day.</description></item>
            /// <item><description><b>week</b>: By week.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>week</para>
            /// </summary>
            [NameInMap("ScanFrequency")]
            [Validation(Required=false)]
            public string ScanFrequency { get; set; }

            /// <summary>
            /// <para>The interval number of the trigger cycle. This parameter works together with ScanFrequency to determine the trigger cycle. For example, if ScanFrequency is set to week and ScanInterval is set to 1, the scan is triggered once a week.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScanInterval")]
            [Validation(Required=false)]
            public int? ScanInterval { get; set; }

            /// <summary>
            /// <para>The scan path scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Quick</b>: Quick scan. Only critical system directories and common risk locations are scanned.</description></item>
            /// <item><description><b>Full</b>: Full disk scan.</description></item>
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
            /// <para>The enabled status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Full disk scan on R&amp;D department terminals every Sunday at midnight</para>
            /// </summary>
            [NameInMap("StrategyDescription")]
            [Validation(Required=false)]
            public string StrategyDescription { get; set; }

            /// <summary>
            /// <para>The ID of the scheduled virus scan policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vc-strategy-8a3f6c2e91b7****</para>
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public string StrategyId { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weekly_Scan_DevTeam</para>
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// <para>The list of exempted users. Users in this list are excluded from the scan performed by this policy. An empty list is returned if no exemptions are configured.</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public List<string> Whitelist { get; set; }

        }

        /// <summary>
        /// <para>The total number of scheduled virus scan policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
