// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeSecurityScoreRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to modify the new version or legacy security score rules. If the value is <b>home_security_score</b>, the new version security score rules are modified. Otherwise, the legacy security score rules are modified by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>home_security_score</para>
        /// </summary>
        [NameInMap("CalType")]
        [Validation(Required=false)]
        public string CalType { get; set; }

        /// <summary>
        /// <para>Specifies whether to reset to the system default rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ResetSecurityScoreRule")]
        [Validation(Required=false)]
        public bool? ResetSecurityScoreRule { get; set; }

        /// <summary>
        /// <para>The ID of the member account in the resource directory.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The list of new version security score rule deductions.</para>
        /// </summary>
        [NameInMap("SecurityScoreCategoryList")]
        [Validation(Required=false)]
        public List<ChangeSecurityScoreRuleRequestSecurityScoreCategoryList> SecurityScoreCategoryList { get; set; }
        public class ChangeSecurityScoreRuleRequestSecurityScoreCategoryList : TeaModel {
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
            /// <para>The deduction threshold for the security score rule category.</para>
            /// <remarks>
            /// <para>The valid range is 0 to 100. The sum of all security score rule category deduction thresholds must equal 100.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ScoreThreshold")]
            [Validation(Required=false)]
            public int? ScoreThreshold { get; set; }

            /// <summary>
            /// <para>The list of deductions by security score rule type.</para>
            /// </summary>
            [NameInMap("SecurityRuleList")]
            [Validation(Required=false)]
            public List<ChangeSecurityScoreRuleRequestSecurityScoreCategoryListSecurityRuleList> SecurityRuleList { get; set; }
            public class ChangeSecurityScoreRuleRequestSecurityScoreCategoryListSecurityRuleList : TeaModel {
                /// <summary>
                /// <para>The type of the security score rule sub-item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SS_SAS_WEAK_PW</b>: Pending weak passwords to fix.</description></item>
                /// <item><description><b>SS_SAS_ALARM</b>: Pending Security Center alerts.</description></item>
                /// <item><description><b>SS_SAS_EMG_VUL</b>: Pending emergency vulnerabilities to fix.</description></item>
                /// <item><description><b>SS_SAS_APP_VUL</b>: Pending application vulnerabilities to fix.</description></item>
                /// <item><description><b>SS_SAS_SYS_VUL</b>: Pending system vulnerabilities to fix.</description></item>
                /// <item><description><b>SS_SAS_CLOUD_HC</b>: Pending Cloud Security Posture Management (CSPM) risks.</description></item>
                /// <item><description><b>SS_SDDP_DATA_RISK</b>: Pending data security risks to address.</description></item>
                /// <item><description><b>SS_WAF_API_RISK</b>: Pending API security risks.</description></item>
                /// <item><description><b>SS_DDOS_BH_ASSET</b>: Assets in DDoS blackhole filtering status.</description></item>
                /// <item><description><b>SS_SAS_AK_LEAK</b>: Unhandled AccessKey/SecretKey leak events.</description></item>
                /// <item><description><b>SS_PRODUCT_CONNECT</b>: Security products not properly connected.</description></item>
                /// <item><description><b>SS_KEY_CONFIG</b>: Key feature configuration.</description></item>
                /// <item><description><b>SS_PRODUCT_EXPIRE</b>: Products about to expire.</description></item>
                /// <item><description><b>SS_AI_RISK</b>: AI application risks.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SS_REINFORCE</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>The deduction threshold for the security score rule type.</para>
                /// <remarks>
                /// <para>The valid range is 0 to the deduction threshold of the security score rule category.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The list of deductions for security score rule sub-items.</para>
                /// </summary>
                [NameInMap("SecurityScoreItemList")]
                [Validation(Required=false)]
                public List<ChangeSecurityScoreRuleRequestSecurityScoreCategoryListSecurityRuleListSecurityScoreItemList> SecurityScoreItemList { get; set; }
                public class ChangeSecurityScoreRuleRequestSecurityScoreCategoryListSecurityRuleListSecurityScoreItemList : TeaModel {
                    /// <summary>
                    /// <para>The deduction value for the individual item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public int? Score { get; set; }

                    /// <summary>
                    /// <para>The deduction threshold for the individual item.</para>
                    /// <remarks>
                    /// <para>The valid range is 0 to the deduction threshold of the security score rule type.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ScoreThreshold")]
                    [Validation(Required=false)]
                    public int? ScoreThreshold { get; set; }

                    /// <summary>
                    /// <para>The security score rule sub-item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SSI_KEY_CONFIG</para>
                    /// </summary>
                    [NameInMap("SubRuleType")]
                    [Validation(Required=false)]
                    public string SubRuleType { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The list of legacy security score rules.</para>
        /// </summary>
        [NameInMap("SecurityScoreRuleList")]
        [Validation(Required=false)]
        public List<ChangeSecurityScoreRuleRequestSecurityScoreRuleList> SecurityScoreRuleList { get; set; }
        public class ChangeSecurityScoreRuleRequestSecurityScoreRuleList : TeaModel {
            /// <summary>
            /// <para>The type of the security score rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SS_REINFORCE: Key feature configuration.</description></item>
            /// <item><description>SS_ALARM: Pending alerts.</description></item>
            /// <item><description>SS_VUL: Pending vulnerabilities.</description></item>
            /// <item><description>SS_HC: Baseline issues.</description></item>
            /// <item><description>SS_CLOUD_HC: Cloud platform configuration check item issues.</description></item>
            /// <item><description>SS_AK: AccessKey pair leak risk.</description></item>
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
            /// <para>The valid range is 0 to 100. The sum of all security score rule deduction thresholds must equal 100.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The list of individual deduction items for the security score rule.</para>
            /// </summary>
            [NameInMap("SecurityScoreItemList")]
            [Validation(Required=false)]
            public List<ChangeSecurityScoreRuleRequestSecurityScoreRuleListSecurityScoreItemList> SecurityScoreItemList { get; set; }
            public class ChangeSecurityScoreRuleRequestSecurityScoreRuleListSecurityScoreItemList : TeaModel {
                /// <summary>
                /// <para>The deduction value for the individual item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The deduction threshold for the individual item.</para>
                /// <remarks>
                /// <para>The valid range is 0 to the deduction threshold of the security score rule.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ScoreThreshold")]
                [Validation(Required=false)]
                public int? ScoreThreshold { get; set; }

                /// <summary>
                /// <para>The sub-rule type of the individual deduction item. The mapping between security score types and sub-rule types is as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>SS_REINFORCE: Key feature configuration.</para>
                /// <list type="bullet">
                /// <item><description>XPRESS_INSTALL: Security Center service authorization is not enabled.</description></item>
                /// <item><description>REINFORCE_SUSPICIOUS: The anti-virus feature is not enabled.</description></item>
                /// <item><description>RANSOMWARE: The anti-ransomware policy is not enabled.</description></item>
                /// <item><description>WEB_LOCK: The web tamper-proofing feature is not enabled.</description></item>
                /// <item><description>VIRUS_SCHEDULE_SCAN: The periodic virus scan policy is not enabled.</description></item>
                /// <item><description>IMAGE_REPO_SCAN: The container image scan scope is not configured.</description></item>
                /// <item><description>IMAGE_SCAN_TASK: The one-click container image security risk scan has not been executed.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_ALARM: Pending alerts.</para>
                /// <list type="bullet">
                /// <item><description>ALARM_SERIOUS: One unhandled high-risk alert event exists.</description></item>
                /// <item><description>ALARM_SUSPICIOUS: One unhandled medium-risk alert event exists.</description></item>
                /// <item><description>ALARM_REMIND: One unhandled low-risk alert event exists.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_VUL: Pending vulnerabilities.</para>
                /// <list type="bullet">
                /// <item><description>CMS_UNFIX: One unfixed CMS vulnerability exists.</description></item>
                /// <item><description>WIN_UNFIX: One unfixed Windows host vulnerability exists.</description></item>
                /// <item><description>CVE_UNFIX: One unfixed Linux host vulnerability exists.</description></item>
                /// <item><description>ERM_UNFIX: One unfixed emergency vulnerability exists.</description></item>
                /// <item><description>ERM_UNCHECK: One unscanned emergency vulnerability exists.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_HC: Baseline issues.</para>
                /// <list type="bullet">
                /// <item><description>WEAK_EXPLOIT: A weak password risk exposed to the Internet exists.</description></item>
                /// <item><description>WEAK_PASSWORD: A weak password risk exists.</description></item>
                /// <item><description>HC_EXPLOIT: A high-risk intrusion vulnerability exists.</description></item>
                /// <item><description>HC_OTHER_WARNING: A security configuration risk exists.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_CLOUD_HC: Cloud platform configuration check item issues.</para>
                /// <list type="bullet">
                /// <item><description>CSPM_CIEM_NOT_PASS: One failed CIEM check item exists.</description></item>
                /// <item><description>CSPM_RISK_NOT_PASS: One failed security risk check item exists.</description></item>
                /// <item><description>CSPM_COMPLIANCE_NOT_PASS: One failed compliance check item exists.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_AK: AccessKey pair leak risk. Categorization not applicable.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALARM_SERIOUS</para>
                /// </summary>
                [NameInMap("SubRuleType")]
                [Validation(Required=false)]
                public string SubRuleType { get; set; }

            }

        }

    }

}
