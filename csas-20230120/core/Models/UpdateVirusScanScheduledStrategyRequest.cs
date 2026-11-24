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
        /// <item><description><b>Quarantine</b>: Quarantines quarantined file.</description></item>
        /// <item><description><b>Notify</b>: Reports an alert only and does not process quarantined file.</description></item>
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
        /// <item><description><b>Quarantine</b>: Quarantines quarantined file.</description></item>
        /// <item><description><b>Notify</b>: Reports an alert only and does not process quarantined file.</description></item>
        /// <item><description><b>None</b>: Does not process quarantined file.</description></item>
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
        /// <item><description><b>UserGroupAll</b>: Takes effect for all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: Takes effect only for users in specified user groups. If you select this value, the UserGroupIds parameter is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The upper limit of the percentage of the endpoint CPU occupied during the scan. Valid values: 0 to 100.</para>
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
        /// <item><description><b>Quarantine</b>: Quarantines quarantined file.</description></item>
        /// <item><description><b>Notify</b>: Reports an alert only and does not process quarantined file.</description></item>
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
        /// <item><description><b>SecurityFirst</b>: Security first. The default upper limit of CPU usage is 50%.</description></item>
        /// <item><description><b>Balance</b>: Balanced. The default upper limit of CPU usage is 30%.</description></item>
        /// <item><description><b>ExperienceFirst</b>: Experience first. The default upper limit of CPU usage is 15%.</description></item>
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
        /// <para>The start hour when scans are allowed to be triggered. The value must be an integer on the hour. Valid values: 0 to 23, including the specified hour. This field is not a timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanBeginTime")]
        [Validation(Required=false)]
        public long? ScanBeginTime { get; set; }

        /// <summary>
        /// <para>The end hour when scans are allowed to be triggered. The value must be an integer on the hour. Valid values: 1 to 24, excluding the specified hour. The value must be greater than the value of ScanBeginTime. The scan task generated by each trigger becomes invalid at this hour on the same day. This field is not a timestamp.</para>
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
        /// <item><description><b>day</b>: Day.</description></item>
        /// <item><description><b>week</b>: Week.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>week</para>
        /// </summary>
        [NameInMap("ScanFrequency")]
        [Validation(Required=false)]
        public string ScanFrequency { get; set; }

        /// <summary>
        /// <para>The interval of the trigger cycle. This parameter and ScanFrequency together determine the trigger cycle. Valid values: 1 to 30. For example, if ScanFrequency is set to week and ScanInterval is set to 1, a scan is triggered once a week.</para>
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
        /// <item><description><b>Quick</b>: Quick scan. Only key system directories and common risk locations are scanned.</description></item>
        /// <item><description><b>Full</b>: Full scan.</description></item>
        /// <item><description><b>Custom</b>: Custom path scan. If you select this value, the ScanPath parameter is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Quick</para>
        /// </summary>
        [NameInMap("ScanMode")]
        [Validation(Required=false)]
        public string ScanMode { get; set; }

        /// <summary>
        /// <para>The collection of custom scan paths. The collection can contain up to 100 items and cannot contain duplicates. This parameter takes effect only when ScanMode is set to Custom.</para>
        /// </summary>
        [NameInMap("ScanPath")]
        [Validation(Required=false)]
        public List<string> ScanPath { get; set; }

        /// <summary>
        /// <para>The collection of virus types to be handled in the scan. The collection must contain at least one item and cannot contain duplicates.</para>
        /// </summary>
        [NameInMap("ScanTargets")]
        [Validation(Required=false)]
        public List<string> ScanTargets { get; set; }

        /// <summary>
        /// <para>The enabling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.
        /// After the policy is enabled, it immediately participates in periodic scheduling. If the policy is disabled, it is only saved and does not trigger scans.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The description of the policy. The description can contain Chinese characters, uppercase and lowercase letters, digits, spaces, periods (.), commas (,), semicolons (;), forward slashes (/), at signs (@), hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Full scan of R&amp;D department endpoints every Sunday morning</para>
        /// </summary>
        [NameInMap("StrategyDescription")]
        [Validation(Required=false)]
        public string StrategyDescription { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled virus scan policy to be modified. Value sources:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusScanScheduledStrategies~~">ListVirusScanScheduledStrategies</a>: Queries scheduled virus scan policies in batches.</description></item>
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
        /// <para>Policy Name of the policy. Policy Name can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weekly scan for the R&amp;D department</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The collection of effective user group IDs. The collection must contain at least one item and can contain up to 100 items. Duplicates are not allowed. If the effective scope is UserGroupNormal, the provided collection fully replaces the existing user groups of the policy. If the effective scope is UserGroupAll and the effective scope is not modified in this request, this parameter is not allowed.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The exception user list. Scans are not executed for users in this list. The list can contain up to 1,000 items and cannot contain duplicates. This parameter fully overwrites the existing list of the policy with the provided list.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
