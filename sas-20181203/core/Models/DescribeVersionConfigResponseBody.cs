// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVersionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of agentless detections.</para>
        /// <remarks>
        /// <para>Agentless detection is not currently available for purchase. You do not need to pay attention to this field.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AgentlessCapacity")]
        [Validation(Required=false)]
        public long? AgentlessCapacity { get; set; }

        /// <summary>
        /// <para>Indicates whether pay-as-you-go purchasing is allowed. Valid values:</para>
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
        /// <para>The anti-ransomware managed service. Valid values:</para>
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
        /// <para>Indicates whether the application whitelist is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not enabled.</description></item>
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
        /// <para>One authorization can apply an application whitelist policy to one server. After the application whitelist feature is enabled, the account has 20 authorizations by default.</para>
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
        /// <para>Indicates whether EDR is purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BuySasEdr")]
        [Validation(Required=false)]
        public string BuySasEdr { get; set; }

        /// <summary>
        /// <para>Indicates whether the post-paid trial package can be activated. Valid values:</para>
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
        /// <para>The number of purchased cloud platform configuration check scans. Unit: times/month.</para>
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
        /// <para>The highest purchased Security Center version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free edition.</description></item>
        /// <item><description><b>3</b>: Enterprise edition.</description></item>
        /// <item><description><b>5</b>: Advanced edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus edition.</description></item>
        /// <item><description><b>7</b>: Ultimate edition.</description></item>
        /// <item><description><b>10</b>: Value-added services only.<remarks>
        /// <para>If a single version is purchased, this value indicates the corresponding version. If multiple versions are purchased, this value indicates the highest version among the purchased Security Center versions.</para>
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
        /// <para>The number of purchased honeypot authorizations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("HoneypotCapacity")]
        [Validation(Required=false)]
        public long? HoneypotCapacity { get; set; }

        /// <summary>
        /// <para>The grayscale module for elastic billing.</para>
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
        /// <para>The elastic billing switch status.</para>
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
        /// <para>The number of purchased image scan authorizations.</para>
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
        /// <item><description><b>1</b>: Allocated by multi-account management.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InstanceBuyType")]
        [Validation(Required=false)]
        public int? InstanceBuyType { get; set; }

        /// <summary>
        /// <para>The ID of the purchased Security Center instance.</para>
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
        /// <para>Indicates whether this is the new Ultimate edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The latest version.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Not the latest version.</para>
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
        /// <para>Indicates whether this is the new multi-version edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The latest multi-version edition.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Not the latest multi-version edition.</para>
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
        /// <para>Indicates whether the current number of servers exceeds the maximum number of purchased authorizations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Not exceeded.</description></item>
        /// <item><description><b>true</b>: Exceeded.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated. You do not need to pay attention to it.</para>
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
        /// <para>Indicates whether the current Security Center version is a trial version. Valid values:</para>
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
        /// <para>The end timestamp of the last trial of Security Center. Unit: milliseconds.</para>
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
        /// <para>The higher protection version between the subscription and pay-as-you-go Security Center host and container security services when both are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus edition.</description></item>
        /// <item><description><b>5</b>: Advanced edition.</description></item>
        /// <item><description><b>3</b>: Enterprise edition.</description></item>
        /// <item><description><b>7</b>: Ultimate edition.</description></item>
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
        /// <para>Indicates whether the new threat analysis and response service is enabled. The new threat analysis and response service supports purchasing ingestion traffic and log storage capacity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
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
        /// <para>The highest protection version bound to assets when the host and container security pay-as-you-go service is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free edition.</description></item>
        /// <item><description><b>3</b>: Enterprise edition.</description></item>
        /// <item><description><b>5</b>: Advanced edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus edition.</description></item>
        /// <item><description><b>7</b>: Ultimate edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PostPayHostVersion")]
        [Validation(Required=false)]
        public int? PostPayHostVersion { get; set; }

        /// <summary>
        /// <para>The ID of the pay-as-you-go instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postpay-sas-**</para>
        /// </summary>
        [NameInMap("PostPayInstanceId")]
        [Validation(Required=false)]
        public string PostPayInstanceId { get; set; }

        /// <summary>
        /// <para>The switch status of pay-as-you-go modules in JSON string format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Key:<list type="bullet">
        /// <item><description><b>VUL</b>: Vulnerability fix module.</description></item>
        /// <item><description><b>CSPM</b>: Cloud security posture management module.</description></item>
        /// <item><description><b>AGENTLESS</b>: Agentless detection module.</description></item>
        /// <item><description><b>SERVERLESS</b>: Serverless security module.</description></item>
        /// <item><description><b>CTDR</b>: Threat analysis and response module.</description></item>
        /// <item><description><b>POST_HOST</b>: Host and container security module.</description></item>
        /// <item><description><b>SDK</b>: Malicious file detection SDK module.</description></item>
        /// <item><description><b>RASP</b>: Application protection module.</description></item>
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
        /// <para>The status of the pay-as-you-go instance. Valid values:</para>
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
        /// <para>The number of purchased application protection instances. Unit: instances/month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RaspCapacity")]
        [Validation(Required=false)]
        public long? RaspCapacity { get; set; }

        /// <summary>
        /// <para>The expiration timestamp of the Security Center instance. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>If you do not renew the service within 7 days after it expires, your paid instance is downgraded to the free edition. You can no longer use the features of the paid edition, and your Security Center configuration data and historical alert data (such as DDoS alerts) become inaccessible. In this case, you must repurchase to enable the paid Security Center service. For more information, see <a href="https://help.aliyun.com/document_detail/42308.html">Purchase Security Center</a>.</para>
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
        /// <para>The number of machines purchased for EDR.</para>
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
        /// <para>The EDR subscription instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RELEASED</para>
        /// </summary>
        [NameInMap("SasEdrPrePaidInstanceStatus")]
        [Validation(Required=false)]
        public string SasEdrPrePaidInstanceStatus { get; set; }

        /// <summary>
        /// <para>The purchased EDR version.</para>
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
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SdkAiPostPaidGray")]
        [Validation(Required=false)]
        public int? SdkAiPostPaidGray { get; set; }

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
        /// <para>The purchased threat analysis and response log ingestion traffic. Unit: GB/day.</para>
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
        /// <para>The purchased Security Center version. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free edition. </description></item>
        /// <item><description><b>3</b>: Enterprise edition.</description></item>
        /// <item><description><b>5</b>: Advanced edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus edition.    </description></item>
        /// <item><description><b>7</b>: Ultimate edition.   </description></item>
        /// <item><description><b>8</b>: Multi-version edition.   </description></item>
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
        /// <para>The number of purchased vulnerability fixes. Unit: times/month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("VulFixCapacity")]
        [Validation(Required=false)]
        public long? VulFixCapacity { get; set; }

        /// <summary>
        /// <para>Indicates whether the tamper-proofing service is enabled. Valid values:</para>
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
        /// <para>The number of purchased tamper-proofing authorizations. One authorization can enable tamper-proofing protection for one server. Valid values: 0 to N.</para>
        /// <remarks>
        /// <para>N is the number of servers you own.</para>
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
