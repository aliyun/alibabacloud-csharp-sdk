// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecureSuggestionResponseBody : TeaModel {
        /// <summary>
        /// <para>The timestamp of security score calculation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1755744253000</para>
        /// </summary>
        [NameInMap("CalTime")]
        [Validation(Required=false)]
        public long? CalTime { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676F80E3-4B3F-43DA-9CBB-5FF79F202AA2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The suggestions on how to handle the risks.</para>
        /// </summary>
        [NameInMap("Suggestions")]
        [Validation(Required=false)]
        public List<DescribeSecureSuggestionResponseBodySuggestions> Suggestions { get; set; }
        public class DescribeSecureSuggestionResponseBodySuggestions : TeaModel {
            /// <summary>
            /// <para>The details of the suggestion.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSecureSuggestionResponseBodySuggestionsDetail> Detail { get; set; }
            public class DescribeSecureSuggestionResponseBodySuggestionsDetail : TeaModel {
                /// <summary>
                /// <para>The description of the suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Malicious tampering of Web pages will affect your normal access to web page content, and may also lead to serious economic losses, brand losses, and even political risks. The webpage tamper-proof service can monitor the website directory in real time and restore the tampered files or directories through backup, so as to ensure that the website information of important systems is not tampered with maliciously and prevent the occurrence of horse hanging, black chain, illegal implantation of terrorist threats, pornography and other content.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The sub-type of the unhandled risk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ALARM_HIGH</b>: Unhandled Urgency Alerts</description></item>
                /// <item><description><b>ALARM_MEDIUM</b>: Unhandled Warning Alerts</description></item>
                /// <item><description><b>ALARM_LOW</b>: Unhandled Reminder Alerts</description></item>
                /// <item><description><b>VUL_EMR_UNCHECK</b>: Unchecked Urgent Vulnerabilities</description></item>
                /// <item><description><b>VUL_EMR_UNFIX</b>: Unfixed Urgent Vulnerabilities</description></item>
                /// <item><description><b>VUL_WIN</b>: Unfixed Windows Server Vulnerabilities</description></item>
                /// <item><description><b>VUL_LINUX</b>: Unfixed Linux Server Vulnerabilities</description></item>
                /// <item><description><b>VUL_CMS</b>: Unfixed CMS Vulnerabilities</description></item>
                /// <item><description><b>ACCESSKEY_LEAK</b>: AccessKey Leakage Risks</description></item>
                /// <item><description><b>HC_WARN</b>: Baseline Risks</description></item>
                /// <item><description><b>HC_WEAK_EXPLOIT_WARN</b>: There is a risk of weak passwords exposed by the public network.</description></item>
                /// <item><description><b>HC_WEAK_PASSWORD_WARN</b>: Risk of weak password</description></item>
                /// <item><description><b>HC_HIGH_EXPLOIT_WARN</b>: There is a high risk of invasion</description></item>
                /// <item><description><b>HC_OTHER_WARN</b>: Security Configuration risk</description></item>
                /// <item><description><b>HC_DATABASE_WARN</b>: Database has security risks</description></item>
                /// <item><description><b>CLOUD_HC_SAS_OPEN</b>: Security protection has not been installed on the server</description></item>
                /// <item><description><b>CLOUD_HC_AEGIS_OFFLINE</b>: Server protection status is offline</description></item>
                /// <item><description><b>CLOUD_HC_ACCOUNT_DOUBLE_CHECK</b>: Two-Factor Authentication not Enabled for Primary Account</description></item>
                /// <item><description><b>CLOUD_HC_RDS</b>: RDS-database security policy failed, security risks</description></item>
                /// <item><description><b>CLOUD_HC_DDOS</b>: Risks in Anti-DDoS Pro Back-to-Origin Settings</description></item>
                /// <item><description><b>CLOUD_HC_HIGH_LEVEL</b>: Cloud product configuration has high risk</description></item>
                /// <item><description><b>CLOUD_HC_OTHER_LEVEL</b>: Cloud product configuration has medium and low risk risks</description></item>
                /// <item><description><b>OTHER_ATTACH</b>: Attacks</description></item>
                /// <item><description><b>OTHER_DATABASE_ATTACH</b>: Database has security risks</description></item>
                /// <item><description><b>REINFORCE_BASELINE</b>: Config Assessment</description></item>
                /// <item><description><b>REINFORCE_SUSPICIOUS</b>: Antivirus</description></item>
                /// <item><description><b>REINFORCE_ANALYSIS</b>: Log Analysis</description></item>
                /// <item><description><b>REINFORCE_AK_LEAK</b>: AccessKey Leaked Intelligence Detection</description></item>
                /// <item><description><b>REINFORCE_WEB_LOCK</b>: Website tamper-proofing capability not configured</description></item>
                /// <item><description><b>REINFORCE_BRUTE_FORCE</b>: Anti brute force cracking</description></item>
                /// <item><description><b>REINFORCE_XPRESS_INSTALL</b>: One-click client installation</description></item>
                /// <item><description><b>REINFORCE_RANSOMWARE</b>: Enable anti-extortion strategy</description></item>
                /// <item><description><b>REINFORCE_UNI_RANSOMWARE</b>: Anti-ransomware for Databases</description></item>
                /// <item><description><b>REINFORCE_VIRUS_SCHEDULE_SCAN</b>: Periodic virus scan policies not configured</description></item>
                /// <item><description><b>REINFORCE_IMAGE_REPO_SCAN</b>: No container image scan range configured</description></item>
                /// <item><description><b>REINFORCE_IMAGE_SCAN_TASK</b>: Image security scan</description></item>
                /// <item><description><b>REINFORCE_K8S_LOG_ANALYSIS</b>: Container K8s threat detection is disabled</description></item>
                /// <item><description><b>REINFORCE_CONTAINER_NETWORK</b>: Container Visualization</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>REINFORCE_WEB_LOCK</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// <para>The name of the unhandled risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Website tamper-proofing capability not configured</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The penalty point of a deduction item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public int? Points { get; set; }

            /// <summary>
            /// <para>The type of the unhandled risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SS_REINFORCE</b>: missing configuration of key features, such as malicious behavior defense</description></item>
            /// <item><description><b>SS_ALARM</b>: unhandled alerts</description></item>
            /// <item><description><b>SS_VUL</b>: unfixed vulnerabilities</description></item>
            /// <item><description><b>SS_HC</b>: baseline risks</description></item>
            /// <item><description><b>SS_AK</b>: AccessKey pair leaks</description></item>
            /// <item><description><b>SS_CLOUD_HC</b>: configuration risks of cloud services</description></item>
            /// <item><description><b>OTHER</b>: others</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SS_ALARM</para>
            /// </summary>
            [NameInMap("SuggestType")]
            [Validation(Required=false)]
            public string SuggestType { get; set; }

        }

        /// <summary>
        /// <para>The total number of unhandled security risks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
