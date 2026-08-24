// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetAntiVirusRealTimeDefenceStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The action taken on high-risk virus files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Quarantine</b>: Quarantines quarantined file.</description></item>
        /// <item><description><b>Notify</b>: Reports an alert only without taking action on quarantined file. Quarantine is returned if no real-time defense policy has been configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Quarantine</para>
        /// </summary>
        [NameInMap("HighRiskOperation")]
        [Validation(Required=false)]
        public string HighRiskOperation { get; set; }

        /// <summary>
        /// <para>The action taken on low-risk virus files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Quarantine</b>: Quarantines quarantined file.</description></item>
        /// <item><description><b>Notify</b>: Reports an alert only without taking action on quarantined file.</description></item>
        /// <item><description><b>None</b>: Takes no action. None is returned if no real-time defense policy has been configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("LowRiskOperation")]
        [Validation(Required=false)]
        public string LowRiskOperation { get; set; }

        /// <summary>
        /// <para>The matching mode of the effective scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: Applies to all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: Applies only to users in specified user groups. An empty string is returned if no real-time defense policy has been configured.</description></item>
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
        /// <para>The maximum percentage of endpoint CPU that real-time defense can use. The default value 30 is returned if a policy has been configured but this parameter is not separately set. 0 is returned if no real-time defense policy has been configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxCpuUsage")]
        [Validation(Required=false)]
        public long? MaxCpuUsage { get; set; }

        /// <summary>
        /// <para>The action taken on medium-risk virus files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Quarantine</b>: Quarantines quarantined file.</description></item>
        /// <item><description><b>Notify</b>: Reports an alert only without taking action on quarantined file. Notify is returned if no real-time defense policy has been configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Notify</para>
        /// </summary>
        [NameInMap("MidRiskOperation")]
        [Validation(Required=false)]
        public string MidRiskOperation { get; set; }

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
        /// <para>The collection of virus types that the real-time defense handles. An empty list is returned if no real-time defense policy has been configured.</para>
        /// </summary>
        [NameInMap("ScanTargets")]
        [Validation(Required=false)]
        public List<string> ScanTargets { get; set; }

        /// <summary>
        /// <para>The enabling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled. Disabled is returned if no real-time defense policy has been configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the real-time defense policy. An empty string is returned if no real-time defense policy has been configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>av-rtd-2f5c8e1a7b94****</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// <para>The list of exempted usernames. Users in this list are not subject to real-time defense. An empty list is returned if no exemption is configured.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
