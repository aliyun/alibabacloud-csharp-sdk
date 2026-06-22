// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVersionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of agentless detection quotas.</para>
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
        /// <para>Indicates whether pay-as-you-go purchasing is allowed.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: not allowed</description></item>
        /// <item><description><b>1</b>: allowed.</description></item>
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
        /// <item><description><b>0</b>: not activated</description></item>
        /// <item><description><b>1</b>: activated.</description></item>
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
        /// <item><description><b>0</b>: disabled</description></item>
        /// <item><description><b>2</b>: enabled.</description></item>
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
        /// <para>The number of purchased server authorization quotas.</para>
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
        /// <item><description><b>0</b>: not supported</description></item>
        /// <item><description><b>1</b>: supported.</description></item>
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
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CspmInstanceCapacity")]
        [Validation(Required=false)]
        public int? CspmInstanceCapacity { get; set; }

        /// <summary>
        /// <para>The highest purchased edition of Security Center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Pro Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition</description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
        /// <item><description><b>10</b>: Value-added services only<remarks>
        /// <para>If a single edition is purchased, this value indicates the corresponding edition. If multiple editions are purchased, this value indicates the highest edition among the purchased editions.</para>
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
        /// <para>The number of purchased honeypot authorization quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("HoneypotCapacity")]
        [Validation(Required=false)]
        public long? HoneypotCapacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HybridPaidModuleSwitchMap")]
        [Validation(Required=false)]
        public int? HybridPaidModuleSwitchMap { get; set; }

        [NameInMap("HybridPaidStatus")]
        [Validation(Required=false)]
        public int? HybridPaidStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HybridSwitch")]
        [Validation(Required=false)]
        public int? HybridSwitch { get; set; }

        /// <summary>
        /// <para>The number of purchased image scan authorization quotas.</para>
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
        /// <item><description><b>0</b>: self-purchased</description></item>
        /// <item><description><b>1</b>: allocated from a multi-account setup.</description></item>
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
        /// <para>Indicates whether the instance is the new Ultimate Edition.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The instance is the latest version.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The instance is not the latest version.</para>
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
        /// <para>Indicates whether the instance is the new Multi-version Edition.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The instance is the latest multi-version.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The instance is not the latest multi-version.</para>
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
        /// <para>Indicates whether the number of existing servers exceeds the maximum number of purchased authorizations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: The number does not exceed the limit.</description></item>
        /// <item><description><b>true</b>: The number exceeds the limit.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated. You can ignore it..</para>
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
        /// <item><description><b>false</b>: disabled</description></item>
        /// <item><description><b>true</b>: enabled.</description></item>
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
        /// <item><description><b>0</b>: not a trial version</description></item>
        /// <item><description><b>1</b>: trial version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsTrialVersion")]
        [Validation(Required=false)]
        public int? IsTrialVersion { get; set; }

        /// <summary>
        /// <para>The end timestamp of the last trial of Security Center. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1603934844000</para>
        /// </summary>
        [NameInMap("LastTrailEndTime")]
        [Validation(Required=false)]
        public long? LastTrailEndTime { get; set; }

        /// <summary>
        /// <para>The total number of authorizations when multiple editions are purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("MVAuthCount")]
        [Validation(Required=false)]
        public int? MVAuthCount { get; set; }

        /// <summary>
        /// <para>The total number of remaining authorizations when multiple editions are purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MVUnusedAuthCount")]
        [Validation(Required=false)]
        public int? MVUnusedAuthCount { get; set; }

        /// <summary>
        /// <para>The higher protection edition between the subscription and pay-as-you-go host and container security services of Security Center when both are activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition</description></item>
        /// <item><description><b>5</b>: Premium Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
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
        /// <para>The multi-version edition numbers and authorization usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MultiVersion")]
        [Validation(Required=false)]
        public string MultiVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NewPostPaidCspm")]
        [Validation(Required=false)]
        public int? NewPostPaidCspm { get; set; }

        /// <summary>
        /// <para>Indicates whether the new version of Cloud Threat Detection and Response (CTDR) is enabled. The new version supports purchasing ingestion traffic and log storage capacity for Cloud Threat Detection and Response (CTDR). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled</description></item>
        /// <item><description><b>1</b>: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewThreatAnalysis")]
        [Validation(Required=false)]
        public int? NewThreatAnalysis { get; set; }

        /// <summary>
        /// <para>The number of AI digital human managed instances.</para>
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
        /// <para>The highest protection edition for bound assets when the pay-as-you-go host and container security service is activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Pro Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition</description></item>
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
        /// <item><description><b>VUL</b>: vulnerability fix module</description></item>
        /// <item><description><b>CSPM</b>: Cloud Security Posture Management (CSPM) module</description></item>
        /// <item><description><b>AGENTLESS</b>: agentless detection module</description></item>
        /// <item><description><b>SERVERLESS</b>: serverless security module</description></item>
        /// <item><description><b>CTDR</b>: threat detection and response module</description></item>
        /// <item><description><b>POST_HOST</b>: host and container security module</description></item>
        /// <item><description><b>SDK</b>: malicious file detection SDK module</description></item>
        /// <item><description><b>RASP</b>: application protection module</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Value: 0 indicates disabled, 1 indicates enabled.</description></item>
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
        /// <para>The number of purchased application protection quotas. Unit: per month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RaspCapacity")]
        [Validation(Required=false)]
        public long? RaspCapacity { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp when the Security Center instance expires. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>If you do not complete renewal within 7 days after the instance expires, your paid instance is downgraded to Free Edition. You can no longer use the features of the paid edition, and the Security Center configuration data and historical alerting data (such as DDoS alerts) become inaccessible. In this case, you must repurchase Security Center to enable the paid edition. For more information, see <a href="https://help.aliyun.com/document_detail/42308.html">Purchase Security Center</a>.</para>
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
        /// <para>Indicates whether log analysis is purchased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: not purchased</description></item>
        /// <item><description><b>1</b>: purchased.</description></item>
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
        /// <item><description><b>0</b>: not purchased</description></item>
        /// <item><description><b>1</b>: purchased.</description></item>
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
        /// <para>The purchased log ingestion traffic for threat detection and response. Unit: GB per day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ThreatAnalysisFlow")]
        [Validation(Required=false)]
        public int? ThreatAnalysisFlow { get; set; }

        /// <summary>
        /// <para>Indicates whether the custom alerting feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled</description></item>
        /// <item><description><b>2</b>: enabled.</description></item>
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
        /// <item><description><b>1</b>: Free Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Pro Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
        /// <item><description><b>7</b>: Ultimate Edition   </description></item>
        /// <item><description><b>8</b>: Multi-version Edition   </description></item>
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
        /// <para>Indicates whether web tamper-proofing is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled</description></item>
        /// <item><description><b>1</b>: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WebLock")]
        [Validation(Required=false)]
        public int? WebLock { get; set; }

        /// <summary>
        /// <para>The number of purchased web tamper-proofing authorizations. One authorization allows you to enable web tamper-proofing for one server. Valid values: 0 to N.</para>
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
