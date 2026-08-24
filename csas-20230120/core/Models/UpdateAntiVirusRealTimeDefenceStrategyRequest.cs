// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateAntiVirusRealTimeDefenceStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The action to take on high-risk virus files. Required when configuring the real-time defense policy for the first time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Quarantine</b>: Quarantines quarantined file.</description></item>
        /// <item><description><b>Notify</b>: Reports an alert only without taking action on quarantined file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Quarantine</para>
        /// </summary>
        [NameInMap("HighRiskOperation")]
        [Validation(Required=false)]
        public string HighRiskOperation { get; set; }

        /// <summary>
        /// <para>The action to take on low-risk virus files. Required when configuring the real-time defense policy for the first time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Quarantine</b>: Quarantines quarantined file.</description></item>
        /// <item><description><b>Notify</b>: Reports an alert only without taking action on quarantined file.</description></item>
        /// <item><description><b>None</b>: Takes no action.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("LowRiskOperation")]
        [Validation(Required=false)]
        public string LowRiskOperation { get; set; }

        /// <summary>
        /// <para>The matching mode for the effective scope. Required when configuring the real-time defense policy for the first time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: Applies to all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: Applies only to users in specified user groups. UserGroupIds is required in this case.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The maximum percentage of endpoint CPU that real-time defense can consume. Valid values: 0 to 100. When configuring for the first time, the value is stored as 0 but takes effect as 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxCpuUsage")]
        [Validation(Required=false)]
        public long? MaxCpuUsage { get; set; }

        /// <summary>
        /// <para>The action to take on medium-risk virus files. Required when configuring the real-time defense policy for the first time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Quarantine</b>: Quarantines quarantined file.</description></item>
        /// <item><description><b>Notify</b>: Reports an alert only without taking action on quarantined file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Notify</para>
        /// </summary>
        [NameInMap("MidRiskOperation")]
        [Validation(Required=false)]
        public string MidRiskOperation { get; set; }

        /// <summary>
        /// <para>The collection of virus types to be handled by real-time defense. Duplicates are not allowed. Required when configuring the real-time defense policy for the first time. When the policy already exists, this parameter performs a full replacement. The collection you pass in replaces the existing configuration.</para>
        /// </summary>
        [NameInMap("ScanTargets")]
        [Validation(Required=false)]
        public List<string> ScanTargets { get; set; }

        /// <summary>
        /// <para>The enabling status. Required when configuring the real-time defense policy for the first time. Valid values:</para>
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
        /// <para>The collection of user group IDs to which the policy applies. Required when MatchMode is set to UserGroupNormal. Not allowed when MatchMode is set to UserGroupAll. At least 1 and at most 100 entries are allowed. Duplicates are not allowed. When MatchMode is UserGroupNormal, you must pass in the complete user group collection on every call, even when modifying only other parameters.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The exception user list. Users in this list are excluded from real-time defense. A maximum of 1000 entries are allowed. Duplicates are not allowed. This parameter performs a full replacement. The list you pass in replaces the existing list.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
