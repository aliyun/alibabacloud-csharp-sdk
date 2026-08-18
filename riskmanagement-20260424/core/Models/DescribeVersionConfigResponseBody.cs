// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeVersionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVersionConfigResponseBodyData Data { get; set; }
        public class DescribeVersionConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message body content encoded by the Base64 algorithm.</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public DescribeVersionConfigResponseBodyDataBody Body { get; set; }
            public class DescribeVersionConfigResponseBodyDataBody : TeaModel {
                /// <summary>
                /// <para>The agentless detection quota.</para>
                /// <remarks>
                /// <para>Agentless detection is not available for purchase. You can ignore this field.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AgentlessCapacity")]
                [Validation(Required=false)]
                public long? AgentlessCapacity { get; set; }

                /// <summary>
                /// <para>Indicates whether pay-as-you-go purchase is allowed.</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not allowed.</description></item>
                /// <item><description><b>1</b>: Allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AllowPartialBuy")]
                [Validation(Required=false)]
                public int? AllowPartialBuy { get; set; }

                /// <summary>
                /// <para>The allocated anti-ransomware capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1680</para>
                /// </summary>
                [NameInMap("AntiRansomwareCapacity")]
                [Validation(Required=false)]
                public int? AntiRansomwareCapacity { get; set; }

                /// <summary>
                /// <para>Indicates whether the anti-ransomware managed service is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not enabled.</description></item>
                /// <item><description><b>1</b>: Enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AntiRansomwareService")]
                [Validation(Required=false)]
                public int? AntiRansomwareService { get; set; }

                /// <summary>
                /// <para>Indicates whether the application whitelist feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not enabled.</description></item>
                /// <item><description><b>2</b>: Enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AppWhiteList")]
                [Validation(Required=false)]
                public int? AppWhiteList { get; set; }

                /// <summary>
                /// <para>The number of application whitelist authorizations.</para>
                /// <remarks>
                /// <para>One authorization allows you to apply an application whitelist policy to one server. After the application whitelist feature is enabled, the account has 20 authorizations by default.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("AppWhiteListAuthCount")]
                [Validation(Required=false)]
                public long? AppWhiteListAuthCount { get; set; }

                /// <summary>
                /// <para>The number of purchased server authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AssetLevel")]
                [Validation(Required=false)]
                public int? AssetLevel { get; set; }

                /// <summary>
                /// <para>Indicates whether the pay-as-you-go trial plan can be activated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not supported.</description></item>
                /// <item><description><b>1</b>: Supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CanTryPostPaidPackage")]
                [Validation(Required=false)]
                public int? CanTryPostPaidPackage { get; set; }

                /// <summary>
                /// <para>The allocated Cloud Security Posture Management (CSPM) scan quota. Unit: times/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CspmCapacity")]
                [Validation(Required=false)]
                public long? CspmCapacity { get; set; }

                /// <summary>
                /// <para>The highest purchased edition of Security Center. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition.</description></item>
                /// <item><description><b>3</b>: Enterprise Edition.</description></item>
                /// <item><description><b>5</b>: Premium Edition.</description></item>
                /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
                /// <item><description><b>7</b>: Ultimate Edition.</description></item>
                /// <item><description><b>10</b>: Value-added services only.<remarks>
                /// <para>If a single edition is purchased, this value indicates the corresponding edition. If multiple editions are purchased, this value indicates the highest edition among them.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HighestVersion")]
                [Validation(Required=false)]
                public int? HighestVersion { get; set; }

                /// <summary>
                /// <para>The allocated number of honeypot authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HoneypotCapacity")]
                [Validation(Required=false)]
                public long? HoneypotCapacity { get; set; }

                /// <summary>
                /// <para>The number of purchased image scan authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1900</para>
                /// </summary>
                [NameInMap("ImageScanCapacity")]
                [Validation(Required=false)]
                public long? ImageScanCapacity { get; set; }

                /// <summary>
                /// <para>The instance purchase type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Self-purchased.</description></item>
                /// <item><description><b>1</b>: Allocated by multi-account management.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InstanceBuyType")]
                [Validation(Required=false)]
                public int? InstanceBuyType { get; set; }

                /// <summary>
                /// <para>The AI digital human analysis traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("IntelligentAnalysisFlow")]
                [Validation(Required=false)]
                public int? IntelligentAnalysisFlow { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance is the new Ultimate Edition.</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The instance is the latest edition.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The instance is not the latest edition.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsNewContainerVersion")]
                [Validation(Required=false)]
                public bool? IsNewContainerVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance is the new multi-edition version.</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The instance is the latest multi-edition version.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The instance is not the latest multi-edition version.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsNewMultiVersion")]
                [Validation(Required=false)]
                public bool? IsNewMultiVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the number of existing servers exceeds the maximum purchased authorization quota. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: Not exceeded.</description></item>
                /// <item><description><b>true</b>: Exceeded.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Notice: This parameter is deprecated. You can ignore it.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsOverBalance")]
                [Validation(Required=false)]
                public bool? IsOverBalance { get; set; }

                /// <summary>
                /// <para>Indicates whether pay-as-you-go billing is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: Not enabled.</description></item>
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsPostpay")]
                [Validation(Required=false)]
                public bool? IsPostpay { get; set; }

                /// <summary>
                /// <para>Indicates whether the current Security Center edition is a trial version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not a trial version.</description></item>
                /// <item><description><b>1</b>: A trial version.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsTrialVersion")]
                [Validation(Required=false)]
                public int? IsTrialVersion { get; set; }

                /// <summary>
                /// <para>The end timestamp of the last Security Center trial. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1603934844000</para>
                /// </summary>
                [NameInMap("LastTrailEndTime")]
                [Validation(Required=false)]
                public long? LastTrailEndTime { get; set; }

                /// <summary>
                /// <para>The higher protection edition when both subscription and pay-as-you-go host and container security services are enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition.</description></item>
                /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
                /// <item><description><b>5</b>: Premium Edition.</description></item>
                /// <item><description><b>3</b>: Enterprise Edition.</description></item>
                /// <item><description><b>7</b>: Ultimate Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MergedVersion")]
                [Validation(Required=false)]
                public int? MergedVersion { get; set; }

                /// <summary>
                /// <para>The multi-edition version numbers and authorization usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("MultiVersion")]
                [Validation(Required=false)]
                public string MultiVersion { get; set; }

                /// <summary>
                /// <para>The total number of authorizations when multiple editions are purchased.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MvAuthCount")]
                [Validation(Required=false)]
                public int? MvAuthCount { get; set; }

                /// <summary>
                /// <para>The total number of remaining authorizations when multiple editions are purchased.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MvUnusedAuthCount")]
                [Validation(Required=false)]
                public int? MvUnusedAuthCount { get; set; }

                /// <summary>
                /// <para>Indicates whether the new version of Cloud Threat Detection and Response (CTDR) is enabled. The new version supports purchasing access traffic and log storage capacity for Cloud Threat Detection and Response (CTDR). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: No.</description></item>
                /// <item><description><b>1</b>: Yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NewThreatAnalysis")]
                [Validation(Required=false)]
                public int? NewThreatAnalysis { get; set; }

                /// <summary>
                /// <para>The AI digital human managed instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OnboardedAssets")]
                [Validation(Required=false)]
                public int? OnboardedAssets { get; set; }

                /// <summary>
                /// <para>The timestamp when the service was activated. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1657244824669</para>
                /// </summary>
                [NameInMap("OpenTime")]
                [Validation(Required=false)]
                public long? OpenTime { get; set; }

                /// <summary>
                /// <para>The highest protection edition for bound assets when the pay-as-you-go host and container security service is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition.</description></item>
                /// <item><description><b>3</b>: Enterprise Edition.</description></item>
                /// <item><description><b>5</b>: Premium Edition.</description></item>
                /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
                /// <item><description><b>7</b>: Ultimate Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PostPayHostVersion")]
                [Validation(Required=false)]
                public int? PostPayHostVersion { get; set; }

                /// <summary>
                /// <para>The pay-as-you-go instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>postpay-sas-frme8vjfiw2j</para>
                /// </summary>
                [NameInMap("PostPayInstanceId")]
                [Validation(Required=false)]
                public string PostPayInstanceId { get; set; }

                /// <summary>
                /// <para>The switch status of pay-as-you-go modules in JSON string format. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Key:<list type="bullet">
                /// <item><description><b>VUL</b>: Vulnerability fix module.</description></item>
                /// <item><description><b>CSPM</b>: Cloud Security Posture Management module.</description></item>
                /// <item><description><b>AGENTLESS</b>: Agentless detection module.</description></item>
                /// <item><description><b>SERVERLESS</b>: Serverless security module.</description></item>
                /// <item><description><b>CTDR</b>: Threat detection and response module.</description></item>
                /// <item><description><b>POST_HOST</b>: Host and container security module.</description></item>
                /// <item><description><b>SDK</b>: Malicious file detection SDK module.</description></item>
                /// <item><description><b>RASP</b>: Application protection module.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Value: 0 indicates disabled. 1 indicates enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;BASIC_SERVICE\&quot;:0,\&quot;VUL\&quot;:0}</para>
                /// </summary>
                [NameInMap("PostPayModuleSwitch")]
                [Validation(Required=false)]
                public string PostPayModuleSwitch { get; set; }

                /// <summary>
                /// <para>The time when pay-as-you-go billing was activated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1698915219000</para>
                /// </summary>
                [NameInMap("PostPayOpenTime")]
                [Validation(Required=false)]
                public long? PostPayOpenTime { get; set; }

                /// <summary>
                /// <para>The instance status of the pay-as-you-go instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Normal.</description></item>
                /// <item><description><b>2</b>: Suspended due to overdue payment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PostPayStatus")]
                [Validation(Required=false)]
                public int? PostPayStatus { get; set; }

                /// <summary>
                /// <para>The number of purchased application protection quotas. Unit: count/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("RaspCapacity")]
                [Validation(Required=false)]
                public long? RaspCapacity { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp that indicates when the Security Center instance expires. Unit: milliseconds.</para>
                /// <remarks>
                /// <para>If you do not perform renewal within 7 days after the instance expires, your paid edition instance is downgraded to Free Edition. You can no longer use the features of the paid edition, and your previous Security Center configuration data and historical alerting data (such as DDoS alerts) become inaccessible. In this case, you must repurchase Security Center to re-enable the paid edition. For more information, refer to the Security Center purchase documentation.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1625846400000</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public long? ReleaseTime { get; set; }

                /// <summary>
                /// <para>The request ID of Security Center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A6FB9AC3-4431-538F-BA8A-2A13AEA208A4</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>Indicates whether log analysis has been purchased. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not purchased.</description></item>
                /// <item><description><b>1</b>: Purchased.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SasLog")]
                [Validation(Required=false)]
                public int? SasLog { get; set; }

                /// <summary>
                /// <para>Indicates whether the security dashboard has been purchased. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not purchased.</description></item>
                /// <item><description><b>1</b>: Purchased.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SasScreen")]
                [Validation(Required=false)]
                public int? SasScreen { get; set; }

                /// <summary>
                /// <para>The number of malicious file detection SDK authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SdkCapacity")]
                [Validation(Required=false)]
                public long? SdkCapacity { get; set; }

                /// <summary>
                /// <para>The purchased log storage capacity. Unit: GB. Value range: 0 to 200000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SlsCapacity")]
                [Validation(Required=false)]
                public long? SlsCapacity { get; set; }

                /// <summary>
                /// <para>The purchased threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ThreatAnalysisCapacity")]
                [Validation(Required=false)]
                public long? ThreatAnalysisCapacity { get; set; }

                /// <summary>
                /// <para>The purchased threat detection and response log access traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ThreatAnalysisFlow")]
                [Validation(Required=false)]
                public int? ThreatAnalysisFlow { get; set; }

                /// <summary>
                /// <para>Indicates whether the custom alert feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not enabled.</description></item>
                /// <item><description><b>2</b>: Enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UserDefinedAlarms")]
                [Validation(Required=false)]
                public int? UserDefinedAlarms { get; set; }

                /// <summary>
                /// <para>The purchased edition of Security Center. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition.</description></item>
                /// <item><description><b>3</b>: Enterprise Edition.</description></item>
                /// <item><description><b>5</b>: Premium Edition.</description></item>
                /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
                /// <item><description><b>7</b>: Ultimate Edition.</description></item>
                /// <item><description><b>8</b>: Multi-edition.</description></item>
                /// <item><description><b>10</b>: Value-added services only.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

                /// <summary>
                /// <para>The number of purchased authorized cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("VmCores")]
                [Validation(Required=false)]
                public int? VmCores { get; set; }

                /// <summary>
                /// <para>The number of purchased vulnerability fix quotas. Unit: times/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("VulFixCapacity")]
                [Validation(Required=false)]
                public long? VulFixCapacity { get; set; }

                /// <summary>
                /// <para>Indicates whether the web tamper proofing service is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not enabled.</description></item>
                /// <item><description><b>1</b>: Enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebLock")]
                [Validation(Required=false)]
                public int? WebLock { get; set; }

                /// <summary>
                /// <para>The number of purchased web tamper proofing authorizations. One authorization enables web tamper proofing protection for one server. Value range: 0 to N.</para>
                /// <remarks>
                /// <para>N is the number of servers that you own.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebLockAuthCount")]
                [Validation(Required=false)]
                public long? WebLockAuthCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message. A success message is returned if the request succeeds. An error message is returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D462855-7835-5F91-835E-A62E44EC01CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values: true: The operation is successful. false: The operation failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
