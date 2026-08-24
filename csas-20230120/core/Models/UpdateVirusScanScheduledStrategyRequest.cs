// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateVirusScanScheduledStrategyRequest : TeaModel {
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
        /// <item><description><b>UserGroupAll</b>: The policy takes effect for all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: The policy takes effect only for users in specified user groups. UserGroupIds is required when this value is specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The maximum percentage of terminal CPU usage allowed during scanning. Valid values: 0 to 100.</para>
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
        /// <para>The scan performance pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SecurityFirst</b>: Security first. The default CPU usage limit is 50%.</description></item>
        /// <item><description><b>Balance</b>: Balanced. The default CPU usage limit is 30%.</description></item>
        /// <item><description><b>ExperienceFirst</b>: Experience first. The default CPU usage limit is 15%.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Balance</para>
        /// </summary>
        [NameInMap("PerformanceMode")]
        [Validation(Required=false)]
        public string PerformanceMode { get; set; }

        /// <summary>
        /// <para>The policy priority. A smaller value indicates a higher priority. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The start hour during which scans can be triggered. The value is a whole hour number. Valid values: 0 to 23, inclusive. This field is not a timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanBeginTime")]
        [Validation(Required=false)]
        public long? ScanBeginTime { get; set; }

        /// <summary>
        /// <para>The end hour during which scans can be triggered. The value is a whole hour number. Valid values: 1 to 24, exclusive of the specified hour, and must be greater than ScanBeginTime. Scan tasks generated by each trigger expire at this hour on the same day. This field is not a timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ScanEndTime")]
        [Validation(Required=false)]
        public long? ScanEndTime { get; set; }

        /// <summary>
        /// <para>The unit of the trigger cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: by day.</description></item>
        /// <item><description><b>week</b>: by week.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>week</para>
        /// </summary>
        [NameInMap("ScanFrequency")]
        [Validation(Required=false)]
        public string ScanFrequency { get; set; }

        /// <summary>
        /// <para>The interval number of the trigger cycle, which together with ScanFrequency determines the trigger cycle. Valid values: 1 to 30. For example, if ScanFrequency is set to week and ScanInterval is set to 1, the scan is triggered once a week.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanInterval")]
        [Validation(Required=false)]
        public long? ScanInterval { get; set; }

        /// <summary>
        /// <para>The path scope for scanning. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Quick</b>: Quick scan. Only system-critical directories and common risk locations are scanned.</description></item>
        /// <item><description><b>Full</b>: Full disk scan.</description></item>
        /// <item><description><b>Custom</b>: Custom path scan. ScanPath is required when this value is specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Quick</para>
        /// </summary>
        [NameInMap("ScanMode")]
        [Validation(Required=false)]
        public string ScanMode { get; set; }

        /// <summary>
        /// <para>The collection of custom scan paths. A maximum of 100 paths can be specified, and duplicates are not allowed. This parameter takes effect only when ScanMode is set to Custom.</para>
        /// </summary>
        [NameInMap("ScanPath")]
        [Validation(Required=false)]
        public List<string> ScanPath { get; set; }

        /// <summary>
        /// <para>The collection of virus types to be handled in this scan. At least one type must be specified, and duplicates are not allowed.</para>
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
        /// <para>When enabled, the policy immediately participates in periodic scheduling. When disabled, the policy is saved but does not trigger scans.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The policy description. The description can contain Chinese characters, uppercase and lowercase letters, digits, spaces, periods (.), commas (,), semicolons (;), forward slashes (/), at signs (@), hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Full disk scan for R&amp;D department terminals every Sunday at midnight</para>
        /// </summary>
        [NameInMap("StrategyDescription")]
        [Validation(Required=false)]
        public string StrategyDescription { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled virus scan policy to modify. You can obtain the value from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusScanScheduledStrategies~~">ListVirusScanScheduledStrategies</a>: Lists scheduled virus scan policies.</description></item>
        /// <item><description><a href="~~CreateVirusScanScheduledStrategy~~">CreateVirusScanScheduledStrategy</a>: Creates a scheduled virus scan policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vc-strategy-8a3f6c2e91b7****</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// <para>The policy name. The name can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weekly scan for R&amp;D department</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The collection of user group IDs for the effective scope. At least 1 and at most 100 IDs can be specified, and duplicates are not allowed. When the effective scope is UserGroupNormal, the provided collection fully replaces the existing user groups of the policy. When the effective scope is UserGroupAll and the effective scope is not being modified, this parameter must not be specified.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The exception user list. Users in this list are excluded from the scan performed by this policy. A maximum of 1000 entries can be specified, and duplicates are not allowed. This parameter performs a full overwrite, meaning the provided list replaces the existing list of the policy.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
