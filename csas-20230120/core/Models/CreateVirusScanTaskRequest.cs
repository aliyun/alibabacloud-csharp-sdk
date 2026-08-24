// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateVirusScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The task expiration time, in seconds-level UNIX timestamp. After this time, endpoints no longer pull and execute this task. If this parameter is not specified or the specified time is earlier than the current time, the value defaults to the current time plus 24 hours.</para>
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
        /// <para>The matching mode for the effective scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: applies to all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: applies only to users in specified user groups. UserGroupIds is required when this value is specified.</description></item>
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
        /// <para>The maximum percentage of endpoint CPU usage during scanning. Valid values: 0 to 100. If this parameter is not specified or is set to 0, the default value is determined by PerformanceMode: 50 for SecurityFirst, 30 for Balance, and 15 for ExperienceFirst.</para>
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
        /// <para>The scan performance pattern. Valid values:</para>
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
        /// <para>The scan path scope. Valid values:</para>
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
        /// <para>The task description. The description can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, spaces, periods (.), commas (,), semicolons (;), forward slashes (/), at signs (@), hyphens (-), and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Full scan for R&amp;D department</para>
        /// </summary>
        [NameInMap("TaskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        /// <summary>
        /// <para>The collection of user group IDs to which the task applies. This parameter is required when MatchMode is set to UserGroupNormal and cannot be specified when MatchMode is set to UserGroupAll. At least 1 and at most 100 IDs can be specified. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of exempt users. Users in this list do not execute this scan task. A maximum of 1000 users can be specified. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
