// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateVirusScanScheduledStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The action to take on high-risk virus files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Quarantine</b>: quarantine quarantined file.</description></item>
        /// <item><description><b>Notify</b>: report an alert only without taking action on quarantined file.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <item><description><b>Quarantine</b>: quarantine quarantined file.</description></item>
        /// <item><description><b>Notify</b>: report an alert only without taking action on quarantined file.</description></item>
        /// <item><description><b>None</b>: take no action.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("LowRiskOperation")]
        [Validation(Required=false)]
        public string LowRiskOperation { get; set; }

        /// <summary>
        /// <para>The matching method for the effective scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: the policy takes effect for all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: the policy takes effect only for users in specified user groups. UserGroupIds is required when this value is specified.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The maximum percentage of terminal CPU usage during scanning. Valid values: 0 to 100. If this parameter is not specified or is set to 0, the default value based on PerformanceMode is used: 50 for SecurityFirst, 30 for Balance, and 15 for ExperienceFirst.</para>
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
        /// <item><description><b>Quarantine</b>: quarantine quarantined file.</description></item>
        /// <item><description><b>Notify</b>: report an alert only without taking action on quarantined file.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Notify</para>
        /// </summary>
        [NameInMap("MidRiskOperation")]
        [Validation(Required=false)]
        public string MidRiskOperation { get; set; }

        /// <summary>
        /// <para>The scan performance mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SecurityFirst</b>: security first. The default CPU usage limit is 50%.</description></item>
        /// <item><description><b>Balance</b>: balanced. The default CPU usage limit is 30%.</description></item>
        /// <item><description><b>ExperienceFirst</b>: experience first. The default CPU usage limit is 15%.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>The start hour for triggering scans, specified as a whole hour. Valid values: 0 to 23 (inclusive). This field is not a timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanBeginTime")]
        [Validation(Required=false)]
        public long? ScanBeginTime { get; set; }

        /// <summary>
        /// <para>The end hour for triggering scans, specified as a whole hour. Valid values: 1 to 24 (exclusive of the specified hour). The value must be greater than ScanBeginTime. Scan tasks generated by each trigger expire at this hour on the same day. This field is not a timestamp.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>week</para>
        /// </summary>
        [NameInMap("ScanFrequency")]
        [Validation(Required=false)]
        public string ScanFrequency { get; set; }

        /// <summary>
        /// <para>The interval number of the trigger cycle. This parameter works together with ScanFrequency to determine the trigger cycle. Valid values: 1 to 30. For example, if ScanFrequency is set to week and ScanInterval is set to 1, the scan is triggered once a week.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanInterval")]
        [Validation(Required=false)]
        public long? ScanInterval { get; set; }

        /// <summary>
        /// <para>The path scope of the scan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Quick</b>: quick scan. Only system critical directories and common risk locations are scanned.</description></item>
        /// <item><description><b>Full</b>: full disk scan.</description></item>
        /// <item><description><b>Custom</b>: custom path scan. ScanPath is required when this value is specified.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quick</para>
        /// </summary>
        [NameInMap("ScanMode")]
        [Validation(Required=false)]
        public string ScanMode { get; set; }

        /// <summary>
        /// <para>The collection of custom scan paths. This parameter is required when ScanMode is set to Custom and cannot be specified when ScanMode is set to Quick or Full. A maximum of 100 paths can be specified. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("ScanPath")]
        [Validation(Required=false)]
        public List<string> ScanPath { get; set; }

        /// <summary>
        /// <para>The collection of virus types to be handled in this scan. At least one type must be specified. Duplicate values are not allowed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScanTargets")]
        [Validation(Required=false)]
        public List<string> ScanTargets { get; set; }

        /// <summary>
        /// <para>The enabling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// <para>After the policy is enabled, it immediately participates in periodic scheduling. When the policy is disabled, it is only saved and does not trigger scans.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The policy name. The name can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WeeklyScanForRDDept</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The collection of user group IDs for the effective scope. This parameter is required when MatchMode is set to UserGroupNormal and cannot be specified when MatchMode is set to UserGroupAll. At least 1 and at most 100 IDs can be specified. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of exempt users. Users in this list are excluded from the scan triggered by this policy. A maximum of 1000 users can be specified. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
