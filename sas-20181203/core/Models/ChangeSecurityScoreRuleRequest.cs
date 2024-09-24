// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeSecurityScoreRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to reset to the system default rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes</description></item>
        /// <item><description>false: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ResetSecurityScoreRule")]
        [Validation(Required=false)]
        public bool? ResetSecurityScoreRule { get; set; }

        /// <summary>
        /// <para>The list of deduction modules that are supported by the security score feature.</para>
        /// </summary>
        [NameInMap("SecurityScoreRuleList")]
        [Validation(Required=false)]
        public List<ChangeSecurityScoreRuleRequestSecurityScoreRuleList> SecurityScoreRuleList { get; set; }
        public class ChangeSecurityScoreRuleRequestSecurityScoreRuleList : TeaModel {
            /// <summary>
            /// <para>The deduction module that is supported by the security score feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SS_REINFORCE: issue in key feature configuration</description></item>
            /// <item><description>SS_ALARM: unhandled alert</description></item>
            /// <item><description>SS_VUL: unfixed vulnerability</description></item>
            /// <item><description>SS_HC: baseline risk</description></item>
            /// <item><description>SS_CLOUD_HC: Cloud platform configuration check item problem.</description></item>
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
            /// <para>5</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The deduction items of the deduction module.</para>
            /// </summary>
            [NameInMap("SecurityScoreItemList")]
            [Validation(Required=false)]
            public List<ChangeSecurityScoreRuleRequestSecurityScoreRuleListSecurityScoreItemList> SecurityScoreItemList { get; set; }
            public class ChangeSecurityScoreRuleRequestSecurityScoreRuleListSecurityScoreItemList : TeaModel {
                /// <summary>
                /// <para>The penalty point of the deduction item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
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
                /// <para>10</para>
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
                /// <item><description>REINFORCE_SUSPICIOUS: The anti-virus feature is disabled.</description></item>
                /// <item><description>RANSOMWARE: The anti-ransomware policy is disabled.</description></item>
                /// <item><description>WEB_LOCK: The web tamper proofing feature is disabled.</description></item>
                /// <item><description>VIRUS_SCHEDULE_SCAN: The periodic virus scan policy is disabled.</description></item>
                /// <item><description>IMAGE_REPO_SCAN: The container image scan range is not configured.</description></item>
                /// <item><description>IMAGE_SCAN_TASK: The feature of one-click scan of container images for security risks is not performed.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>SS_ALARM: unhandled alert</para>
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
                /// <item><description>ERM_UNFIX: An unfixed emergency vulnerability is detected.</description></item>
                /// <item><description>ERM_UNCHECK: An undetected emergency vulnerability exists.</description></item>
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

            }

        }

    }

}
