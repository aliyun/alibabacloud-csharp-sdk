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
        /// <item><description><b>Quarantine</b>: quarantines quarantined files</description></item>
        /// <item><description><b>Notify</b>: reports alerts only and does not process quarantined files</description></item>
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
        /// <item><description><b>Quarantine</b>: quarantines quarantined files</description></item>
        /// <item><description><b>Notify</b>: reports alerts only and does not process quarantined files</description></item>
        /// <item><description><b>None</b>: takes no action</description></item>
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
        /// <para>The matching mode for the effective scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: applies to all users under the current Alibaba Cloud account</description></item>
        /// <item><description><b>UserGroupNormal</b>: applies only to users in the specified user groups, which requires UserGroupIds</description></item>
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
        /// <para>The maximum percentage of the endpoint CPU usage during the scan. Valid values: 0 to 100. If you do not specify this parameter or set it to 0, the default value is determined by PerformanceMode: 50 for SecurityFirst, 30 for Balance, and 15 for ExperienceFirst.</para>
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
        /// <item><description><b>Quarantine</b>: quarantines quarantined files</description></item>
        /// <item><description><b>Notify</b>: reports alerts only and does not process quarantined files</description></item>
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
        /// <para>The scan performance schema pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SecurityFirst</b>: security first, with a default maximum CPU usage of 50%</description></item>
        /// <item><description><b>Balance</b>: balanced, with a default maximum CPU usage of 30%</description></item>
        /// <item><description><b>ExperienceFirst</b>: experience first, with a default maximum CPU usage of 15%</description></item>
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
        /// <para>The start hour for triggering the scan. The value must be an integer on the hour. Valid values: 0 to 23. The specified hour is included. This field is not a timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanBeginTime")]
        [Validation(Required=false)]
        public long? ScanBeginTime { get; set; }

        /// <summary>
        /// <para>The end hour for triggering the scan. The value must be an integer on the hour. Valid values: 1 to 24. The specified hour is excluded and must be greater than ScanBeginTime. The scan task generated by each trigger becomes invalid at this hour on the same day. This field is not a timestamp.</para>
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
        /// <item><description><b>day</b>: day</description></item>
        /// <item><description><b>week</b>: week</description></item>
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
        /// <para>The interval of the trigger cycle. This parameter and ScanFrequency determine the trigger cycle. Valid values: 1 to 30. For example, if ScanFrequency is set to week and ScanInterval is set to 1, the scan is performed once a week.</para>
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
        /// <item><description><b>Quick</b>: quick scan, which scans only system key directories and common risk locations</description></item>
        /// <item><description><b>Full</b>: full scan</description></item>
        /// <item><description><b>Custom</b>: custom path scan, which requires ScanPath</description></item>
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
        /// <para>The custom scan paths. This parameter is required when ScanMode is set to Custom, and cannot be specified when ScanMode is set to Quick or Full. You can specify up to 100 paths. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("ScanPath")]
        [Validation(Required=false)]
        public List<string> ScanPath { get; set; }

        /// <summary>
        /// <para>The types of viruses to be handled in this scan. You must specify at least one virus type. Duplicate values are not allowed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScanTargets")]
        [Validation(Required=false)]
        public List<string> ScanTargets { get; set; }

        /// <summary>
        /// <para>The enabling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled. The policy immediately participates in periodic scheduling.</description></item>
        /// <item><description><b>Disabled</b>: Disabled. The policy is only saved and does not trigger scans.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>Full scan of endpoints in the R&amp;D department every Sunday morning</para>
        /// </summary>
        [NameInMap("StrategyDescription")]
        [Validation(Required=false)]
        public string StrategyDescription { get; set; }

        /// <summary>
        /// <para>Policy Name of the policy. Policy Name can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not allowed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weekly scan for the R&amp;D department</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The IDs of the effective user groups. This parameter is required when MatchMode is set to UserGroupNormal, and cannot be specified when MatchMode is set to UserGroupAll. You must specify at least one and up to 100 user group IDs. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The whitelist of users. Users in the whitelist are excluded from the scan policy. You can specify up to 1,000 users. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
