// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecureSuggestionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The suggestions on how to handle the risks.
        /// </summary>
        [NameInMap("Suggestions")]
        [Validation(Required=false)]
        public List<DescribeSecureSuggestionResponseBodySuggestions> Suggestions { get; set; }
        public class DescribeSecureSuggestionResponseBodySuggestions : TeaModel {
            /// <summary>
            /// The details of the suggestion.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSecureSuggestionResponseBodySuggestionsDetail> Detail { get; set; }
            public class DescribeSecureSuggestionResponseBodySuggestionsDetail : TeaModel {
                /// <summary>
                /// The description of the suggestion.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The sub-type of the unhandled risk. Valid values:
                /// 
                /// *   **ALARM_HIGH**: Unhandled Urgency Alerts
                /// *   **ALARM_MEDIUM**: Unhandled Warning Alerts
                /// *   **ALARM_LOW**: Unhandled Reminder Alerts
                /// *   **VUL_EMR_UNCHECK**: Unchecked Urgent Vulnerabilities
                /// *   **VUL_EMR_UNFIX**: Unfixed Urgent Vulnerabilities
                /// *   **VUL_WIN**: Unfixed Windows Server Vulnerabilities
                /// *   **VUL_LINUX**: Unfixed Linux Server Vulnerabilities
                /// *   **VUL_CMS**: Unfixed CMS Vulnerabilities
                /// *   **ACCESSKEY_LEAK**: AccessKey Leakage Risks
                /// *   **HC_WARN**: Baseline Risks
                /// *   **HC_WEAK_EXPLOIT_WARN**: There is a risk of weak passwords exposed by the public network.
                /// *   **HC_WEAK_PASSWORD_WARN**: Risk of weak password
                /// *   **HC_HIGH_EXPLOIT_WARN**: There is a high risk of invasion
                /// *   **HC_OTHER_WARN**: Security Configuration risk
                /// *   **HC_DATABASE_WARN**: Database has security risks
                /// *   **CLOUD_HC_SAS_OPEN**: Security protection has not been installed on the server
                /// *   **CLOUD_HC_AEGIS_OFFLINE**: Server protection status is offline
                /// *   **CLOUD_HC_ACCOUNT_DOUBLE_CHECK**: Two-Factor Authentication not Enabled for Primary Account
                /// *   **CLOUD_HC_RDS**: RDS-database security policy failed, security risks
                /// *   **CLOUD_HC_DDOS**: Risks in Anti-DDoS Pro Back-to-Origin Settings
                /// *   **CLOUD_HC_HIGH_LEVEL**: Cloud product configuration has high risk
                /// *   **CLOUD_HC_OTHER_LEVEL**: Cloud product configuration has medium and low risk risks
                /// *   **OTHER_ATTACH**: Attacks
                /// *   **OTHER_DATABASE_ATTACH**: Database has security risks
                /// *   **REINFORCE_BASELINE**: Config Assessment
                /// *   **REINFORCE_SUSPICIOUS**: Antivirus
                /// *   **REINFORCE_ANALYSIS**: Log Analysis
                /// *   **REINFORCE_AK_LEAK**: AccessKey Leaked Intelligence Detection
                /// *   **REINFORCE_WEB_LOCK**: Website tamper-proofing capability not configured
                /// *   **REINFORCE_BRUTE_FORCE**: Anti brute force cracking
                /// *   **REINFORCE_XPRESS_INSTALL**: One-click client installation
                /// *   **REINFORCE_RANSOMWARE**: Enable anti-extortion strategy
                /// *   **REINFORCE_UNI_RANSOMWARE**: Anti-ransomware for Databases
                /// *   **REINFORCE_VIRUS_SCHEDULE_SCAN**: Periodic virus scan policies not configured
                /// *   **REINFORCE_IMAGE_REPO_SCAN**: No container image scan range configured
                /// *   **REINFORCE_IMAGE_SCAN_TASK**: Image security scan
                /// *   **REINFORCE_K8S_LOG_ANALYSIS**: Container K8s threat detection is disabled
                /// *   **REINFORCE_CONTAINER_NETWORK**: Container Visualization
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// The name of the unhandled risk.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// The penalty point of a deduction item.
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public int? Points { get; set; }

            /// <summary>
            /// The type of the unhandled risk. Valid values:
            /// 
            /// *   **SS_REINFORCE**: missing configuration of key features, such as malicious behavior defense
            /// *   **SS_ALARM**: unhandled alerts
            /// *   **SS_VUL**: unfixed vulnerabilities
            /// *   **SS_HC**: baseline risks
            /// *   **SS_AK**: AccessKey pair leaks
            /// *   **SS_CLOUD_HC**: configuration risks of cloud services
            /// *   **OTHER**: others
            /// </summary>
            [NameInMap("SuggestType")]
            [Validation(Required=false)]
            public string SuggestType { get; set; }

        }

        /// <summary>
        /// The total number of unhandled security risks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
