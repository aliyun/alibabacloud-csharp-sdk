// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSecurityScoreRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the custom settings of the security score feature.</para>
        /// <list type="bullet">
        /// <item><description>true: enabled</description></item>
        /// <item><description>false: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public bool? EnableStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the new version of the security score rule.</para>
        /// </summary>
        [NameInMap("SecurityScoreCategoryList")]
        [Validation(Required=false)]
        public List<GetSecurityScoreRuleResponseBodySecurityScoreCategoryList> SecurityScoreCategoryList { get; set; }
        public class GetSecurityScoreRuleResponseBodySecurityScoreCategoryList : TeaModel {
            /// <summary>
            /// <para>The category of the security score rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SS_SAS_HANDLE</b>: security governance.</description></item>
            /// <item><description><b>SS_SAS_RESPOND</b>: security response.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SS_SAS_HANDLE</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The threshold of deduction for the security score rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The deduction items of the security score rule.</para>
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
                /// <para>The threshold of deduction for the security score rule type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The sub-deduction items of the security score rule.</para>
                /// </summary>
                [NameInMap("SecurityScoreItemList")]
                [Validation(Required=false)]
                public List<GetSecurityScoreRuleResponseBodySecurityScoreCategoryListSecurityRuleListSecurityScoreItemList> SecurityScoreItemList { get; set; }
                public class GetSecurityScoreRuleResponseBodySecurityScoreCategoryListSecurityRuleListSecurityScoreItemList : TeaModel {
                    /// <summary>
                    /// <para>The deduction score for the item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public int? Score { get; set; }

                    /// <summary>
                    /// <para>The threshold of the deduction score for the item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("ScoreThreshold")]
                    [Validation(Required=false)]
                    public int? ScoreThreshold { get; set; }

                    /// <summary>
                    /// <para>The type of the sub-deduction item. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>SS_SAS_WEAK_PW</b>: unhandled weak password risk.</description></item>
                    /// <item><description><b>SS_SAS_ALARM</b>: unhandled alert in Security Center.</description></item>
                    /// <item><description><b>SS_SAS_EMG_VUL</b>: unfixed urgent vulnerability.</description></item>
                    /// <item><description><b>SS_SAS_APP_VUL</b>: unfixed application vulnerability.</description></item>
                    /// <item><description><b>SS_SAS_SYS_VUL</b>: unfixed system vulnerability.</description></item>
                    /// <item><description><b>SS_SAS_CLOUD_HC</b>: unhandled cloud security posture management (CSPM) risk.</description></item>
                    /// <item><description><b>SS_SDDP_DATA_RISK</b>: unhandled data security risk.</description></item>
                    /// <item><description><b>SS_WAF_API_RISK</b>: unhandled API security risk.</description></item>
                    /// <item><description><b>SS_DDOS_BH_ASSET</b>: asset on which blackhole filtering is triggered.</description></item>
                    /// <item><description><b>SS_SAS_AK_LEAK</b>: unhandled AK/SK leak event.</description></item>
                    /// <item><description><b>SS_PRODUCT_CONNECT</b>: security service not integrated.</description></item>
                    /// <item><description><b>SS_KEY_CONFIG</b>: key feature configuration.</description></item>
                    /// <item><description><b>SS_PRODUCT_EXPIRE</b>: service that is about to expire.</description></item>
                    /// <item><description><b>SS_AI_RISK</b>: AI application risk.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SSI_AI_VUL_RISK</para>
                    /// </summary>
                    [NameInMap("SubRuleType")]
                    [Validation(Required=false)]
                    public string SubRuleType { get; set; }

                    /// <summary>
                    /// <para>The name of the sub-deduction item of the security score rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Unfixed application vulnerabilities</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The name of the security score rule type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AI application risks</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The category of the security score rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security governance</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The information about the old version of the security score rule.</para>
        /// </summary>
        [NameInMap("SecurityScoreRuleList")]
        [Validation(Required=false)]
        public List<GetSecurityScoreRuleResponseBodySecurityScoreRuleList> SecurityScoreRuleList { get; set; }
        public class GetSecurityScoreRuleResponseBodySecurityScoreRuleList : TeaModel {
            /// <summary>
            /// <para>The deduction module that is supported by the security score feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SS_REINFORCE: issue in key feature configuration</description></item>
            /// <item><description>SS_ALARM: unhandled alert</description></item>
            /// <item><description>SS_VUL: unfixed vulnerability</description></item>
            /// <item><description>SS_HC: baseline risk</description></item>
            /// <item><description>SS_CLOUD_HC: risk item of configuration assessment</description></item>
            /// <item><description>SS_AK: risk of AccessKey pair leaks</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SS_ALARM</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The deduction threshold of the deduction module.</para>
            /// <remarks>
            /// <para> Valid values: 0 to 100. The sum of the deduction thresholds for all deduction modules must be equal to 100.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The deduction items of the deduction module.</para>
            /// </summary>
            [NameInMap("SecurityScoreItemList")]
            [Validation(Required=false)]
            public List<GetSecurityScoreRuleResponseBodySecurityScoreRuleListSecurityScoreItemList> SecurityScoreItemList { get; set; }
            public class GetSecurityScoreRuleResponseBodySecurityScoreRuleListSecurityScoreItemList : TeaModel {
                /// <summary>
                /// <para>The penalty point of the deduction item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The threshold for the deduction item.</para>
                /// <remarks>
                /// <para> Valid values: 0 to the deduction threshold of the deduction module.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ScoreThreshold")]
                [Validation(Required=false)]
                public int? ScoreThreshold { get; set; }

                /// <summary>
                /// <para>The deduction item of the deduction module. The following list describes the deduction modules and their deduction items:</para>
                /// <list type="bullet">
                /// <item><description><para>SS_REINFORCE: issue in key feature configuration</para>
                /// <list type="bullet">
                /// <item><description>XPRESS_INSTALL: Security Center is not authorized.</description></item>
                /// <item><description>REINFORCE_SUSPICIOUS: The antivirus feature is disabled.</description></item>
                /// <item><description>RANSOMWARE: The anti-ransomware policy is disabled.</description></item>
                /// <item><description>WEB_LOCK: The web tamper proofing feature is disabled.</description></item>
                /// <item><description>VIRUS_SCHEDULE_SCAN: The periodic virus scan policy is disabled.</description></item>
                /// <item><description>IMAGE_REPO_SCAN: The range of container image scan is not configured.</description></item>
                /// <item><description>IMAGE_SCAN_TASK: The feature of one-click scan of container images for security risks is not performed.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_ALARM: unhandled alert.</para>
                /// <list type="bullet">
                /// <item><description>ALARM_SERIOUS: An unhandled high-risk alert event is detected.</description></item>
                /// <item><description>ALARM_SUSPICIOUS: An unhandled medium-risk alarm event is detected.</description></item>
                /// <item><description>ALARM_REMIND: An unhandled low-risk alarm event is detected.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_VUL: unfixed vulnerability</para>
                /// <list type="bullet">
                /// <item><description>CMS_UNFIX: An unfixed Web-CMS vulnerability is detected.</description></item>
                /// <item><description>WIN_UNFIX: An unfixed Windows host vulnerability is detected.</description></item>
                /// <item><description>CVE_UNFIX: An unfixed Linux host vulnerability is detected.</description></item>
                /// <item><description>ERM_UNFIX: An unfixed urgent vulnerability is detected.</description></item>
                /// <item><description>ERM_UNCHECK: An undetected urgent vulnerability exists.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_HC: baseline risks</para>
                /// <list type="bullet">
                /// <item><description>WEAK_EXPLOIT: Weak passwords are exposed to the Internet.</description></item>
                /// <item><description>WEAK_PASSWORD: Weak passwords exist.</description></item>
                /// <item><description>HC_EXPLOIT: The data source may be hacked.</description></item>
                /// <item><description>HC_OTHER_WARNING: Security configuration risks exist.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_CLOUD_HC: Cloud platform configuration check item problem.</para>
                /// <list type="bullet">
                /// <item><description>CSPM_CIEM_NOT_PASS: A CIEM check item failed the check.</description></item>
                /// <item><description>CSPM_RISK_NOT_PASS: A security risk check item failed the check.</description></item>
                /// <item><description>CSPM_COMPLIANCE_NOT_PASS: A compliance check item failed the check.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_AK: risk of AccessKey pair leaks</para>
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
                /// <para>The description of the deduction item in a deduction module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Unhandled Urgent Alert Event Exists</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The description of the deduction module.</para>
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
