// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSecurityScoreRuleResponseBody : TeaModel {
        /// <summary>
        /// The status of the custom settings of the security score feature.
        /// 
        /// *   true: enabled
        /// *   false: disabled
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public bool? EnableStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of deducted modules that are supported by the security score feature.
        /// </summary>
        [NameInMap("SecurityScoreRuleList")]
        [Validation(Required=false)]
        public List<GetSecurityScoreRuleResponseBodySecurityScoreRuleList> SecurityScoreRuleList { get; set; }
        public class GetSecurityScoreRuleResponseBodySecurityScoreRuleList : TeaModel {
            /// <summary>
            /// The deducted module that is supported by the security score feature. Valid values:
            /// 
            /// *   SS_REINFORCE: issue in key feature configuration
            /// *   SS_ALARM: unhandled alert
            /// *   SS_VUL: unfixed vulnerability
            /// *   SS_HC: baseline risk
            /// *   SS_CLOUD_HC: risk item of configuration assessment
            /// *   SS_AK: risk of AccessKey pair leaks
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// The deduction threshold of the deduction module.
            /// 
            /// >  Valid values: 0 to 100. The sum of the deduction thresholds for all deduction modules must be equal to 100.
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// The deduction items of the deduction module.
            /// </summary>
            [NameInMap("SecurityScoreItemList")]
            [Validation(Required=false)]
            public List<GetSecurityScoreRuleResponseBodySecurityScoreRuleListSecurityScoreItemList> SecurityScoreItemList { get; set; }
            public class GetSecurityScoreRuleResponseBodySecurityScoreRuleListSecurityScoreItemList : TeaModel {
                /// <summary>
                /// The penalty point of the deduction item.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// The threshold for the deduction item.
                /// 
                /// >  Valid values: 0 to the deduction threshold of the deduction module.
                /// </summary>
                [NameInMap("ScoreThreshold")]
                [Validation(Required=false)]
                public int? ScoreThreshold { get; set; }

                /// <summary>
                /// The deduction item of the deduction module. The following list describes the deduction modules and their deduction items:
                /// 
                /// *   SS_REINFORCE: issue in key feature configuration
                /// 
                ///     *   XPRESS_INSTALL: Security Center is not authorized.
                ///     *   REINFORCE_SUSPICIOUS: The antivirus feature is disabled.
                ///     *   RANSOMWARE: The anti-ransomware policy is disabled.
                ///     *   WEB_LOCK: The web tamper proofing feature is disabled.
                ///     *   VIRUS_SCHEDULE_SCAN: The periodic virus scan policy is disabled.
                ///     *   IMAGE_REPO_SCAN: The range of container image scan is not configured.
                ///     *   IMAGE_SCAN_TASK: The feature of one-click scan of container images for security risks is not performed.
                /// 
                /// *   SS_ALARM: unhandled alert.
                /// 
                ///     *   ALARM_SERIOUS: An unhandled high-risk alert event is detected.
                ///     *   ALARM_SUSPICIOUS: An unhandled medium-risk alarm event is detected.
                ///     *   ALARM_REMIND: An unhandled low-risk alarm event is detected.
                /// 
                /// *   SS_VUL: unfixed vulnerability
                /// 
                ///     *   CMS_UNFIX: An unfixed Web-CMS vulnerability is detected.
                ///     *   WIN_UNFIX: An unfixed Windows host vulnerability is detected.
                ///     *   CVE_UNFIX: An unfixed Linux host vulnerability is detected.
                ///     *   ERM_UNFIX: An unfixed urgent vulnerability is detected.
                ///     *   ERM_UNCHECK: An undetected urgent vulnerability exists.
                /// 
                /// *   SS_HC: baseline risks
                /// 
                ///     *   WEAK_EXPLOIT: Weak passwords are exposed to the Internet.
                ///     *   WEAK_PASSWORD: Weak passwords exist.
                ///     *   HC_EXPLOIT: The data source may be hacked.
                ///     *   HC_OTHER_WARNING: Security configuration risks exist.
                /// 
                /// *   SS_CLOUD_HC: Cloud platform configuration check item problem.
                /// 
                ///     *   CSPM_CIEM_NOT_PASS: A CIEM check item failed the check.
                ///     *   CSPM_RISK_NOT_PASS: A security risk check item failed the check.
                ///     *   CSPM_COMPLIANCE_NOT_PASS: A compliance check item failed the check.
                /// 
                /// *   SS_AK: risk of AccessKey pair leaks
                /// </summary>
                [NameInMap("SubRuleType")]
                [Validation(Required=false)]
                public string SubRuleType { get; set; }

                /// <summary>
                /// The description of the deduction item in a deduction module.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// The description of the deduction module.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
