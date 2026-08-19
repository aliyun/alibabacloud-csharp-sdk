// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListRiskItemsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paging query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the risk analysis policy. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remote logon risk analysis policy</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The risk category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>data_safe</c>: data security.</description></item>
        /// <item><description><c>identify_safe</c>: identity security.</description></item>
        /// <item><description><c>device_safe</c>: device security.</description></item>
        /// <item><description><c>access_safe</c>: access security.</description></item>
        /// <item><description><c>ai_agent_safe</c>: Agent security.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>identify_safe</para>
        /// </summary>
        [NameInMap("RiskCategory")]
        [Validation(Required=false)]
        public string RiskCategory { get; set; }

        /// <summary>
        /// <para>The risk event ID. If specified, the exact risk event is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69ef648034cf53d7bac7a9c9c912****</para>
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public string RiskId { get; set; }

        /// <summary>
        /// <para>The risk level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>High</c>: high risk.</description></item>
        /// <item><description><c>Medium</c>: medium risk.</description></item>
        /// <item><description><c>Low</c>: low risk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>High</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The risk scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>account_share</c>: account sharing.</description></item>
        /// <item><description><c>account_stolen</c>: account theft.</description></item>
        /// <item><description><c>device_share</c>: device sharing.</description></item>
        /// <item><description><c>remote_logon</c>: remote logon from an unusual location.</description></item>
        /// <item><description><c>sensitive_data_leakage</c>: sensitive data exfiltration.</description></item>
        /// <item><description><c>compressed_archive_exfil</c>: compressed data exfiltration from the internal network.</description></item>
        /// <item><description><c>lateral_scanning</c>: lateral scanning.</description></item>
        /// <item><description><c>ai_skill_malware</c>: malicious Skill.</description></item>
        /// <item><description><c>ai_config_check</c>: AI configuration check.</description></item>
        /// <item><description><c>openclaw_vulnerability</c>: OpenClaw vulnerability.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>account_stolen</para>
        /// </summary>
        [NameInMap("RiskScene")]
        [Validation(Required=false)]
        public string RiskScene { get; set; }

        /// <summary>
        /// <para>The disposition status of the risk event. This parameter cannot be set together with <c>StatusList</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unprocess</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of disposition statuses of risk events, in Flat serialization format. This parameter cannot be set together with Status.</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// <para>The username associated with the risk event. Fuzzy match is supported. Maximum length: 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhang***</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
