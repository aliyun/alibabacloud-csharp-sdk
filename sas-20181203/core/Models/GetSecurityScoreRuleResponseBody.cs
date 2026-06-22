// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSecurityScoreRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The enabling status of the custom security scoring rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public bool? EnableStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of new security score rules.</para>
        /// </summary>
        [NameInMap("SecurityScoreCategoryList")]
        [Validation(Required=false)]
        public List<GetSecurityScoreRuleResponseBodySecurityScoreCategoryList> SecurityScoreCategoryList { get; set; }
        public class GetSecurityScoreRuleResponseBodySecurityScoreCategoryList : TeaModel {
            /// <summary>
            /// <para>The category of the security score rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SS_SAS_HANDLE</b>: Security governance.</description></item>
            /// <item><description><b>SS_SAS_RESPOND</b>: Security response.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SS_SAS_HANDLE</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The deduction threshold of the security score rule category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The deduction list of security score rule types.</para>
            /// </summary>
            [NameInMap("SecurityRuleList")]
            [Validation(Required=false)]
            public List<GetSecurityScoreRuleResponseBodySecurityScoreCategoryListSecurityRuleList> SecurityRuleList { get; set; }
            public class GetSecurityScoreRuleResponseBodySecurityScoreCategoryListSecurityRuleList : TeaModel {
                /// <summary>
                /// <para>The type of the security score rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SS_AI_RISK</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>The deduction threshold of the security score rule type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The deduction list of security score rule sub-items.</para>
                /// </summary>
                [NameInMap("SecurityScoreItemList")]
                [Validation(Required=false)]
                public List<GetSecurityScoreRuleResponseBodySecurityScoreCategoryListSecurityRuleListSecurityScoreItemList> SecurityScoreItemList { get; set; }
                public class GetSecurityScoreRuleResponseBodySecurityScoreCategoryListSecurityRuleListSecurityScoreItemList : TeaModel {
                    /// <summary>
                    /// <para>The deduction value of the individual item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public int? Score { get; set; }

                    /// <summary>
                    /// <para>The deduction threshold of the individual item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("ScoreThreshold")]
                    [Validation(Required=false)]
                    public int? ScoreThreshold { get; set; }

                    /// <summary>
                    /// <para>The type of the security score rule sub-item. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>SS_SAS_WEAK_PW</b>: Pending weak passwords to fix.</description></item>
                    /// <item><description><b>SS_SAS_ALARM</b>: Pending Security Center alerts.</description></item>
                    /// <item><description><b>SS_SAS_EMG_VUL</b>: Pending emergency vulnerabilities to fix.</description></item>
                    /// <item><description><b>SS_SAS_APP_VUL</b>: Pending application vulnerabilities to fix.</description></item>
                    /// <item><description><b>SS_SAS_SYS_VUL</b>: Pending system vulnerabilities to fix.</description></item>
                    /// <item><description><b>SS_SAS_CLOUD_HC</b>: Pending Cloud Security Posture Management (CSPM) risks.</description></item>
                    /// <item><description><b>SS_SDDP_DATA_RISK</b>: Pending data security risks to remediate.</description></item>
                    /// <item><description><b>SS_WAF_API_RISK</b>: Pending API security risks.</description></item>
                    /// <item><description><b>SS_DDOS_BH_ASSET</b>: Assets in Black Hole Activated status.</description></item>
                    /// <item><description><b>SS_SAS_AK_LEAK</b>: Unhandled AccessKey/SecretKey leakage events.</description></item>
                    /// <item><description><b>SS_PRODUCT_CONNECT</b>: Security products not in Normal connection status.</description></item>
                    /// <item><description><b>SS_KEY_CONFIG</b>: Key feature configuration.</description></item>
                    /// <item><description><b>SS_PRODUCT_EXPIRE</b>: Products about to expire.</description></item>
                    /// <item><description><b>SS_AI_RISK</b>: AI application risks.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SSI_AI_VUL_RISK</para>
                    /// </summary>
                    [NameInMap("SubRuleType")]
                    [Validation(Required=false)]
                    public string SubRuleType { get; set; }

                    /// <summary>
                    /// <para>The name of the security score rule sub-item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Unhandled application vulnerabilities exist.</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The name of the security score rule type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AI Application Risks</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The name of the security score rule category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security Response</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The list of legacy security score rules.</para>
        /// </summary>
        [NameInMap("SecurityScoreRuleList")]
        [Validation(Required=false)]
        public List<GetSecurityScoreRuleResponseBodySecurityScoreRuleList> SecurityScoreRuleList { get; set; }
        public class GetSecurityScoreRuleResponseBodySecurityScoreRuleList : TeaModel {
            /// <summary>
            /// <para>The type of the security score rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SS_REINFORCE: Key feature configuration.</description></item>
            /// <item><description>SS_ALARM: Pending alerts.</description></item>
            /// <item><description>SS_VUL: Pending vulnerabilities to fix.</description></item>
            /// <item><description>SS_HC: Baseline issues.</description></item>
            /// <item><description>SS_CLOUD_HC: Cloud platform configuration check item issues.</description></item>
            /// <item><description>SS_AK: AccessKey leakage risk exists.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SS_ALARM</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The deduction value of the security score rule.</para>
            /// <remarks>
            /// <para>The configurable range is 0 to 100 points. The sum of all security score rule deduction thresholds must equal 100 points.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The list of individual deduction items for the security score rule.</para>
            /// </summary>
            [NameInMap("SecurityScoreItemList")]
            [Validation(Required=false)]
            public List<GetSecurityScoreRuleResponseBodySecurityScoreRuleListSecurityScoreItemList> SecurityScoreItemList { get; set; }
            public class GetSecurityScoreRuleResponseBodySecurityScoreRuleListSecurityScoreItemList : TeaModel {
                /// <summary>
                /// <para>The deduction value of the individual item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The deduction threshold of the individual item.</para>
                /// <remarks>
                /// <para>The configurable range is 0 to the deduction threshold of the security score rule.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ScoreThreshold")]
                [Validation(Required=false)]
                public int? ScoreThreshold { get; set; }

                /// <summary>
                /// <para>The sub-rule type of the security score deduction item. The relationship between security score categorization types and sub-rule types is as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>SS_REINFORCE: Key feature configuration.</para>
                /// <list type="bullet">
                /// <item><description>XPRESS_INSTALL: Security Center service authorization is not enabled.</description></item>
                /// <item><description>REINFORCE_SUSPICIOUS: Anti-virus feature is not enabled.</description></item>
                /// <item><description>RANSOMWARE: Anti-ransomware policy is not enabled.</description></item>
                /// <item><description>WEB_LOCK: Web tamper-proofing feature is not enabled.</description></item>
                /// <item><description>VIRUS_SCHEDULE_SCAN: Periodic virus scan policy is not enabled.</description></item>
                /// <item><description>IMAGE_REPO_SCAN: Container image scan scope is not configured.</description></item>
                /// <item><description>IMAGE_SCAN_TASK: One-click container image security risk scan has not been executed.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_ALARM: Pending alerts.</para>
                /// <list type="bullet">
                /// <item><description>ALARM_SERIOUS: One unhandled high-risk alert event exists.</description></item>
                /// <item><description>ALARM_SUSPICIOUS: One unhandled medium-risk alert event exists.</description></item>
                /// <item><description>ALARM_REMIND: One unhandled low-risk alert event exists.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_VUL: Pending vulnerabilities to fix.</para>
                /// <list type="bullet">
                /// <item><description>CMS_UNFIX: One unfixed CMS vulnerability exists.</description></item>
                /// <item><description>WIN_UNFIX: One unfixed Windows host vulnerability exists.</description></item>
                /// <item><description>CVE_UNFIX: One unfixed Linux host vulnerability exists.</description></item>
                /// <item><description>ERM_UNFIX: One unfixed emergency vulnerability exists.</description></item>
                /// <item><description>ERM_UNCHECK: One undetected emergency vulnerability exists.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_HC: Baseline issues.</para>
                /// <list type="bullet">
                /// <item><description>WEAK_EXPLOIT: Weak password risk exposed to the Internet exists.</description></item>
                /// <item><description>WEAK_PASSWORD: Weak password risk exists.</description></item>
                /// <item><description>HC_EXPLOIT: High-risk intrusion vulnerability exists.</description></item>
                /// <item><description>HC_OTHER_WARNING: Security configuration risk exists.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_CLOUD_HC: Cloud platform configuration check item issues.</para>
                /// <list type="bullet">
                /// <item><description>CSPM_CIEM_NOT_PASS: One failed CIEM check item exists.</description></item>
                /// <item><description>CSPM_RISK_NOT_PASS: One failed security risk check item exists.</description></item>
                /// <item><description>CSPM_COMPLIANCE_NOT_PASS: One failed compliance check item exists.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_AK: AccessKey leakage risk exists.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALARM_SERIOUS</para>
                /// </summary>
                [NameInMap("SubRuleType")]
                [Validation(Required=false)]
                public string SubRuleType { get; set; }

                /// <summary>
                /// <para>The description of the sub-rule type for the security score deduction item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Unhandled Urgent Alert Event Exists</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The description of the security score rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unhandled Alerts</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
