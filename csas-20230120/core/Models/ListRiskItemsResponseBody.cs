// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListRiskItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6707286-A50E-57B1-B2CF-EFAC59E850D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of risk events.</para>
        /// </summary>
        [NameInMap("RiskItems")]
        [Validation(Required=false)]
        public List<ListRiskItemsResponseBodyRiskItems> RiskItems { get; set; }
        public class ListRiskItemsResponseBodyRiskItems : TeaModel {
            /// <summary>
            /// <para>The name of the Agent that generated the risk event. An empty string is returned for non-Agent risk scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qoder****</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The AI risk analysis conclusion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The account logged on from an unusual device, and the behavior is inconsistent with the historical baseline</para>
            /// </summary>
            [NameInMap("AiConclusion")]
            [Validation(Required=false)]
            public string AiConclusion { get; set; }

            /// <summary>
            /// <para>The risk judgment provided by AI. An empty string is returned if no AI analysis results exist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Risk</c>: determined as risky.</description></item>
            /// <item><description><c>Ignore</c>: determined as not risky.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Risk</para>
            /// </summary>
            [NameInMap("AiRiskConfirm")]
            [Validation(Required=false)]
            public string AiRiskConfirm { get; set; }

            /// <summary>
            /// <para>The name of the risk detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual device logon check</para>
            /// </summary>
            [NameInMap("CheckName")]
            [Validation(Required=false)]
            public string CheckName { get; set; }

            /// <summary>
            /// <para>The department to which the user associated with the risk event belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Department****</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>The original organizational structure information of the user associated with the risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN=zhang***,OU=Department****</para>
            /// </summary>
            [NameInMap("GroupInfo")]
            [Validation(Required=false)]
            public string GroupInfo { get; set; }

            /// <summary>
            /// <para>The name of the endpoint device associated with the risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>U-2GW2L4M7-****</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The internal IP address of the endpoint associated with the risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("InnerIp")]
            [Validation(Required=false)]
            public string InnerIp { get; set; }

            /// <summary>
            /// <para>The risk detection report or risk evidence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The account logged on from a new device, and the logon location is inconsistent with the usual location</para>
            /// </summary>
            [NameInMap("Report")]
            [Validation(Required=false)]
            public string Report { get; set; }

            /// <summary>
            /// <para>The list of risk analysis policy names that were hit.</para>
            /// </summary>
            [NameInMap("RiskAnalysisPolicyNames")]
            [Validation(Required=false)]
            public List<string> RiskAnalysisPolicyNames { get; set; }

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
            /// <para>The manually confirmed risk conclusion. An empty string is returned if not confirmed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Risk</c>: confirmed as risky.</description></item>
            /// <item><description><c>Ignore</c>: confirmed as not risky.</description></item>
            /// <item><description><c>Invalid</c>: confirmed as a false positive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Risk</para>
            /// </summary>
            [NameInMap("RiskConfirm")]
            [Validation(Required=false)]
            public string RiskConfirm { get; set; }

            /// <summary>
            /// <para>The description of the risk event disposition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>After verification, the logon was not authorized by the user</para>
            /// </summary>
            [NameInMap("RiskConfirmDesc")]
            [Validation(Required=false)]
            public string RiskConfirmDesc { get; set; }

            /// <summary>
            /// <para>The risk description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The account logged on from an unusual device</para>
            /// </summary>
            [NameInMap("RiskDesc")]
            [Validation(Required=false)]
            public string RiskDesc { get; set; }

            /// <summary>
            /// <para>The end time of the risky behavior, in the format of <c>yyyy-MM-dd HH:mm:ss</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-21 05:21:00</para>
            /// </summary>
            [NameInMap("RiskEndTime")]
            [Validation(Required=false)]
            public string RiskEndTime { get; set; }

            /// <summary>
            /// <para>The list of detection feature or detection item identifiers that triggered the risk event. A risk event may hit multiple identifiers. The specific values vary based on the risk scenario and detection rules.</para>
            /// </summary>
            [NameInMap("RiskFeatureIds")]
            [Validation(Required=false)]
            public List<string> RiskFeatureIds { get; set; }

            /// <summary>
            /// <para>The time when the risk was detected, in the format of <c>yyyy-MM-dd HH:mm:ss</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-20 10:30:00</para>
            /// </summary>
            [NameInMap("RiskFoundTime")]
            [Validation(Required=false)]
            public string RiskFoundTime { get; set; }

            /// <summary>
            /// <para>The risk event ID.</para>
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
            /// <para>The start time of the risky behavior, in the format of <c>yyyy-MM-dd HH:mm:ss</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-20 05:20:00</para>
            /// </summary>
            [NameInMap("RiskStartTime")]
            [Validation(Required=false)]
            public string RiskStartTime { get; set; }

            /// <summary>
            /// <para>The SASE user ID associated with the risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("SaseUserId")]
            [Validation(Required=false)]
            public string SaseUserId { get; set; }

            /// <summary>
            /// <para>The name of the Agent Skill that generated the risk event. An empty string is returned for non-Agent risk scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>frontend-design</para>
            /// </summary>
            [NameInMap("SkillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The recommended remediation action for the risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Verify the account user and freeze the account or reset credentials based on the verification result</para>
            /// </summary>
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            /// <summary>
            /// <para>The disposition status of the risk event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Unprocess</c>: unprocessed.</description></item>
            /// <item><description><c>Processing</c>: being processed.</description></item>
            /// <item><description><c>Processed</c>: processed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unprocess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether AI risk analysis results exist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: AI risk analysis results exist.</description></item>
            /// <item><description><c>false</c>: AI risk analysis results do not exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportAnalysis")]
            [Validation(Required=false)]
            public bool? SupportAnalysis { get; set; }

            /// <summary>
            /// <para>The username associated with the risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhang***</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The total number of risk events that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
