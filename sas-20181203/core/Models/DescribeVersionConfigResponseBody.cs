// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVersionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of agentless detection licenses.</para>
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
        /// <para>Indicates whether pay-as-you-go purchases are allowed. Valid values:</para>
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
        /// <para>The anti-ransomware backup capacity. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160</para>
        /// </summary>
        [NameInMap("AntiRansomwareCapacity")]
        [Validation(Required=false)]
        public int? AntiRansomwareCapacity { get; set; }

        /// <summary>
        /// <para>The status of the anti-ransomware managed service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not activated.</description></item>
        /// <item><description><b>1</b>: Activated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AntiRansomwareService")]
        [Validation(Required=false)]
        public int? AntiRansomwareService { get; set; }

        /// <summary>
        /// <para>Indicates whether the application whitelist is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>2</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AppWhiteList")]
        [Validation(Required=false)]
        public int? AppWhiteList { get; set; }

        /// <summary>
        /// <para>The number of application whitelist authorizations.</para>
        /// <remarks>
        /// <para>One authorization allows you to apply a whitelist policy to one server. After the application whitelist feature is enabled, the account has 20 authorizations by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("AppWhiteListAuthCount")]
        [Validation(Required=false)]
        public long? AppWhiteListAuthCount { get; set; }

        /// <summary>
        /// <para>The number of purchased server authorization licenses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("AssetLevel")]
        [Validation(Required=false)]
        public int? AssetLevel { get; set; }

        /// <summary>
        /// <para>Indicates whether Endpoint Detection and Response (EDR) is purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BuySasEdr")]
        [Validation(Required=false)]
        public string BuySasEdr { get; set; }

        /// <summary>
        /// <para>Indicates whether the pay-as-you-go trial plan can be activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not supported.</description></item>
        /// <item><description><b>1</b>: Supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CanTryPostPaidPackage")]
        [Validation(Required=false)]
        public int? CanTryPostPaidPackage { get; set; }

        /// <summary>
        /// <para>The number of purchased Cloud Security Posture Management (CSPM) scans. Unit: times per month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CspmCapacity")]
        [Validation(Required=false)]
        public long? CspmCapacity { get; set; }

        /// <summary>
        /// <para>The AI digital human analysis traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CspmInstanceCapacity")]
        [Validation(Required=false)]
        public int? CspmInstanceCapacity { get; set; }

        /// <summary>
        /// <para>The highest purchased edition of Security Center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition.</description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Advanced Edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// <item><description><b>10</b>: Value-added services only.<remarks>
        /// <para>If a single version is purchased, this value indicates the corresponding version. If multiple versions are purchased, this value indicates the highest version among the purchased versions.</para>
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
        /// <para>The number of purchased honeypot authorization licenses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("HoneypotCapacity")]
        [Validation(Required=false)]
        public long? HoneypotCapacity { get; set; }

        /// <summary>
        /// <para>The canary release module for elastic billing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CSPM_INSTANCE&quot;:1}</para>
        /// </summary>
        [NameInMap("HybridPaidGrayStatus")]
        [Validation(Required=false)]
        public string HybridPaidGrayStatus { get; set; }

        /// <summary>
        /// <para>The AI digital human analysis traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HybridPaidModuleSwitchMap")]
        [Validation(Required=false)]
        public int? HybridPaidModuleSwitchMap { get; set; }

        /// <summary>
        /// <para>The status of the elastic billing switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HybridPaidStatus")]
        [Validation(Required=false)]
        public int? HybridPaidStatus { get; set; }

        /// <summary>
        /// <para>The AI digital human analysis traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HybridSwitch")]
        [Validation(Required=false)]
        public int? HybridSwitch { get; set; }

        /// <summary>
        /// <para>The number of purchased image scan authorization licenses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8954</para>
        /// </summary>
        [NameInMap("ImageScanCapacity")]
        [Validation(Required=false)]
        public long? ImageScanCapacity { get; set; }

        /// <summary>
        /// <para>The instance purchase type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Self-purchased.</description></item>
        /// <item><description><b>1</b>: Allocated through multi-account management.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InstanceBuyType")]
        [Validation(Required=false)]
        public int? InstanceBuyType { get; set; }

        /// <summary>
        /// <para>The instance ID of the purchased Security Center instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-vg6hafdsafs****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>Indicates whether the instance is the new Ultimate Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is the latest version.</description></item>
        /// <item><description><b>false</b>: The instance is not the latest version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsNewContainerVersion")]
        [Validation(Required=false)]
        public bool? IsNewContainerVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is the new multi-version edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is the latest multi-version edition.</description></item>
        /// <item><description><b>false</b>: The instance is not the latest multi-version edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsNewMultiVersion")]
        [Validation(Required=false)]
        public bool? IsNewMultiVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the number of existing servers exceeds the maximum number of purchased authorizations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: The number does not exceed the limit.</description></item>
        /// <item><description><b>true</b>: The number exceeds the limit.</description></item>
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
        /// <item><description><b>false</b>: Disabled.</description></item>
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
        /// <item><description><b>1</b>: Trial version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsTrialVersion")]
        [Validation(Required=false)]
        public int? IsTrialVersion { get; set; }

        /// <summary>
        /// <para>The timestamp when the last trial of Security Center ended. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1603934844000</para>
        /// </summary>
        [NameInMap("LastTrailEndTime")]
        [Validation(Required=false)]
        public long? LastTrailEndTime { get; set; }

        /// <summary>
        /// <para>The total number of authorizations when multiple versions are purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("MVAuthCount")]
        [Validation(Required=false)]
        public int? MVAuthCount { get; set; }

        /// <summary>
        /// <para>The total number of remaining authorizations when multiple versions are purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MVUnusedAuthCount")]
        [Validation(Required=false)]
        public int? MVUnusedAuthCount { get; set; }

        /// <summary>
        /// <para>The higher protection edition between the subscription and pay-as-you-go services when both host protection and container protection of Security Center are activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Basic Edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
        /// <item><description><b>5</b>: Advanced Edition.</description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("MergedVersion")]
        [Validation(Required=false)]
        public int? MergedVersion { get; set; }

        /// <summary>
        /// <para>The multi-version number and authorization usage information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MultiVersion")]
        [Validation(Required=false)]
        public string MultiVersion { get; set; }

        /// <summary>
        /// <para>The AI digital human analysis traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NewPostPaidCspm")]
        [Validation(Required=false)]
        public int? NewPostPaidCspm { get; set; }

        /// <summary>
        /// <para>Indicates whether the new version of Cloud Threat Detection and Response (CTDR) is enabled. The new version of CTDR supports purchasing log ingestion traffic and log storage capacity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewThreatAnalysis")]
        [Validation(Required=false)]
        public int? NewThreatAnalysis { get; set; }

        /// <summary>
        /// <para>The AI digital human managed instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
        /// <para>The highest protection edition bound to assets when the pay-as-you-go host and container security service is activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition.</description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Advanced Edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PostPayHostVersion")]
        [Validation(Required=false)]
        public int? PostPayHostVersion { get; set; }

        /// <summary>
        /// <para>The instance ID of the pay-as-you-go instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postpay-sas-**</para>
        /// </summary>
        [NameInMap("PostPayInstanceId")]
        [Validation(Required=false)]
        public string PostPayInstanceId { get; set; }

        /// <summary>
        /// <para>The status of pay-as-you-go module switches, in JSON string format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Key:<list type="bullet">
        /// <item><description><b>VUL</b>: Vulnerability fix module.</description></item>
        /// <item><description><b>CSPM</b>: Cloud Security Posture Management (CSPM) module.</description></item>
        /// <item><description><b>AGENTLESS</b>: Agentless detection module.</description></item>
        /// <item><description><b>SERVERLESS</b>: Serverless security module.</description></item>
        /// <item><description><b>CTDR</b>: Cloud Threat Detection and Response (CTDR) module.</description></item>
        /// <item><description><b>POST_HOST</b>: Host and container security module.</description></item>
        /// <item><description><b>SDK</b>: Malicious file detection SDK module.</description></item>
        /// <item><description><b>RASP</b>: Runtime application self-protection (RASP) module.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Value: 0 indicates disabled, and 1 indicates enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VUL&quot;:1}</para>
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
        /// <para>The number of purchased runtime application self-protection (RASP) licenses. Unit: licenses per month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RaspCapacity")]
        [Validation(Required=false)]
        public long? RaspCapacity { get; set; }

        /// <summary>
        /// <para>The timestamp when the Security Center instance expires. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>If you do not renew the instance within 7 days after it expires, your paid instance is downgraded to Free Edition. You can no longer use the features of the paid edition, and your Security Center configuration data and historical alert data (such as DDoS alerts) become inaccessible. In this case, you must repurchase Security Center to enable the paid edition. For more information, see <a href="https://help.aliyun.com/document_detail/42308.html">Purchase Security Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1625846400000</para>
        /// </summary>
        [NameInMap("ReleaseTime")]
        [Validation(Required=false)]
        public long? ReleaseTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2DC96D2-DD2E-49D9-A28E-85590475DF55</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of servers purchased for EDR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SasEdrClientAuthCount")]
        [Validation(Required=false)]
        public string SasEdrClientAuthCount { get; set; }

        /// <summary>
        /// <para>The pay-as-you-go instance ID of EDR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-edr-postpaid-fadaf</para>
        /// </summary>
        [NameInMap("SasEdrPostPaidInstanceId")]
        [Validation(Required=false)]
        public string SasEdrPostPaidInstanceId { get; set; }

        /// <summary>
        /// <para>The subscription instance ID of EDR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-edr-sfkhakhk</para>
        /// </summary>
        [NameInMap("SasEdrPrePaidInstanceId")]
        [Validation(Required=false)]
        public string SasEdrPrePaidInstanceId { get; set; }

        /// <summary>
        /// <para>The instance status of the EDR upfront instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RELEASED</para>
        /// </summary>
        [NameInMap("SasEdrPrePaidInstanceStatus")]
        [Validation(Required=false)]
        public string SasEdrPrePaidInstanceStatus { get; set; }

        /// <summary>
        /// <para>The purchased edition of EDR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SasEdrVersion")]
        [Validation(Required=false)]
        public string SasEdrVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether log analysis is purchased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not purchased.</description></item>
        /// <item><description><b>1</b>: Purchased.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SasLog")]
        [Validation(Required=false)]
        public int? SasLog { get; set; }

        /// <summary>
        /// <para>Indicates whether the security dashboard is purchased. Valid values:</para>
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
        /// <para>The canary release status of the pay-as-you-go SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SdkAiPostPaidGray")]
        [Validation(Required=false)]
        public int? SdkAiPostPaidGray { get; set; }

        /// <summary>
        /// <para>The number of malicious file detection SDK authorization licenses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SdkCapacity")]
        [Validation(Required=false)]
        public long? SdkCapacity { get; set; }

        /// <summary>
        /// <para>The purchased log storage capacity. Unit: GB. Valid values: 0 to 200000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("SlsCapacity")]
        [Validation(Required=false)]
        public long? SlsCapacity { get; set; }

        /// <summary>
        /// <para>The purchased threat analysis capacity. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("ThreatAnalysisCapacity")]
        [Validation(Required=false)]
        public long? ThreatAnalysisCapacity { get; set; }

        /// <summary>
        /// <para>The purchased log ingestion traffic for Cloud Threat Detection and Response (CTDR). Unit: GB per day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ThreatAnalysisFlow")]
        [Validation(Required=false)]
        public int? ThreatAnalysisFlow { get; set; }

        /// <summary>
        /// <para>The list of trial sub-modules.</para>
        /// </summary>
        [NameInMap("TrialModuleList")]
        [Validation(Required=false)]
        public List<DescribeVersionConfigResponseBodyTrialModuleList> TrialModuleList { get; set; }
        public class DescribeVersionConfigResponseBodyTrialModuleList : TeaModel {
            /// <summary>
            /// <para>The name of the trial sub-module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EDR</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The trial version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TrialVersion")]
        [Validation(Required=false)]
        public int? TrialVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the custom alert feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
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
        /// <para>The purchased edition of Security Center. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition. </description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Advanced Edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
        /// <item><description><b>7</b>: Ultimate Edition.   </description></item>
        /// <item><description><b>8</b>: Multi-version Edition.   </description></item>
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
        /// <para>The number of purchased vulnerability fixes. Unit: times per month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("VulFixCapacity")]
        [Validation(Required=false)]
        public long? VulFixCapacity { get; set; }

        /// <summary>
        /// <para>Indicates whether web tamper proofing is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
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
        /// <para>The number of purchased web tamper proofing authorizations. One authorization allows you to enable web tamper proofing for one server. Valid values: 0 to N.</para>
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
