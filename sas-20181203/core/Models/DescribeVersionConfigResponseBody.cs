// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVersionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The agentless detection quota.</para>
        /// <remarks>
        /// <para>Agentless detection is not yet available for sale. You can ignore this field.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AgentlessCapacity")]
        [Validation(Required=false)]
        public long? AgentlessCapacity { get; set; }

        /// <summary>
        /// <para>Indicates whether pay-as-you-go purchase is allowed. Valid values:</para>
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
        /// <para>2</para>
        /// </summary>
        [NameInMap("AppWhiteList")]
        [Validation(Required=false)]
        public int? AppWhiteList { get; set; }

        /// <summary>
        /// <para>The number of application whitelist authorizations.</para>
        /// <remarks>
        /// <para>One authorization allows you to apply a whitelist policy to one server. After you enable the application whitelist feature, your account is granted 20 authorizations by default.</para>
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
        /// <para>Indicates whether Endpoint Detection and Response (EDR) is purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BuySasEdr")]
        [Validation(Required=false)]
        public string BuySasEdr { get; set; }

        /// <summary>
        /// <para>Indicates whether the pay-as-you-go trial plan is supported. Valid values:</para>
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
        /// <para>The number of purchased cloud platform configuration check scans. Unit: scans per month.</para>
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
        /// <item><description><b>1</b>: Free Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition</description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
        /// <item><description><b>10</b>: Value-added services only<remarks>
        /// <para>If a single edition is purchased, this value indicates the corresponding edition. If multiple editions are purchased, this value indicates the highest edition among the purchased editions of Security Center.</para>
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
        /// <item><description><b>1</b>: Multi-account allocation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InstanceBuyType")]
        [Validation(Required=false)]
        public int? InstanceBuyType { get; set; }

        /// <summary>
        /// <para>The instance ID of the purchased Security Center.</para>
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
        /// <para>Indicates whether the instance is the latest Ultimate Edition. Valid values:</para>
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
        /// <para>Indicates whether the instance is the latest multi-edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is the latest multi-edition.</description></item>
        /// <item><description><b>false</b>: The instance is not the latest multi-edition.</description></item>
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
        /// <item><description><b>false</b>: Not exceeded.</description></item>
        /// <item><description><b>true</b>: Exceeded.<remarks>
        /// <para>Notice: <b>[Deprecated]</b> This parameter is deprecated. You can ignore it.</notice></para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsOverBalance")]
        [Validation(Required=false)]
        public bool? IsOverBalance { get; set; }

        /// <summary>
        /// <para>Indicates whether the pay-as-you-go billing method is enabled. Valid values:</para>
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
        /// <para>Indicates whether the current Security Center edition is a trial edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No, it is not a trial edition.</description></item>
        /// <item><description><b>1</b>: Yes, it is a trial edition.</description></item>
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
        /// <para>The total number of authorizations for the multi-edition purchase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("MVAuthCount")]
        [Validation(Required=false)]
        public int? MVAuthCount { get; set; }

        /// <summary>
        /// <para>The total number of remaining authorizations for the multi-edition purchase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MVUnusedAuthCount")]
        [Validation(Required=false)]
        public int? MVUnusedAuthCount { get; set; }

        /// <summary>
        /// <para>The higher protection edition between the subscription and pay-as-you-go services when both are enabled for Security Center host and container security. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
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
        /// <para>The AI digital human analysis traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NewPostPaidCspm")]
        [Validation(Required=false)]
        public int? NewPostPaidCspm { get; set; }

        /// <summary>
        /// <para>Indicates whether the new version of Cloud Threat Detection and Response (CTDR) is enabled. The new version of CTDR supports the purchase of inbound traffic and log storage capacity. Valid values:</para>
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
        /// <para>The timestamp when the service is enabled. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657244824669</para>
        /// </summary>
        [NameInMap("OpenTime")]
        [Validation(Required=false)]
        public long? OpenTime { get; set; }

        /// <summary>
        /// <para>The first trial time for the pay-as-you-go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657244824669</para>
        /// </summary>
        [NameInMap("PostPaidFirstTrialTime")]
        [Validation(Required=false)]
        public long? PostPaidFirstTrialTime { get; set; }

        /// <summary>
        /// <para>The latest trial time for the pay-as-you-go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657244824669</para>
        /// </summary>
        [NameInMap("PostPaidLastTrialTime")]
        [Validation(Required=false)]
        public long? PostPaidLastTrialTime { get; set; }

        /// <summary>
        /// <para>The trial expiration time for the pay-as-you-go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657244824669</para>
        /// </summary>
        [NameInMap("PostPaidTrialExpiredTime")]
        [Validation(Required=false)]
        public long? PostPaidTrialExpiredTime { get; set; }

        /// <summary>
        /// <para>The highest protection edition for bound assets when the pay-as-you-go service for host and container security is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition</description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PostPayHostVersion")]
        [Validation(Required=false)]
        public int? PostPayHostVersion { get; set; }

        /// <summary>
        /// <para>The pay-as-you-go instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postpay-sas-**</para>
        /// </summary>
        [NameInMap("PostPayInstanceId")]
        [Validation(Required=false)]
        public string PostPayInstanceId { get; set; }

        /// <summary>
        /// <para>The switch status of pay-as-you-go modules. The value is a JSON string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Key:<list type="bullet">
        /// <item><description><b>VUL</b>: Vulnerability fixing module</description></item>
        /// <item><description><b>CSPM</b>: Cloud Security Posture Management (CSPM) module</description></item>
        /// <item><description><b>AGENTLESS</b>: Agentless detection module</description></item>
        /// <item><description><b>SERVERLESS</b>: Serverless security module</description></item>
        /// <item><description><b>CTDR</b>: Cloud Threat Detection and Response (CTDR) module</description></item>
        /// <item><description><b>POST_HOST</b>: Host and container security module</description></item>
        /// <item><description><b>SDK</b>: Malicious file detection SDK module</description></item>
        /// <item><description><b>RASP</b>: Application protection module</description></item>
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
        /// <para>The time when the pay-as-you-go billing method is enabled. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698915219000</para>
        /// </summary>
        [NameInMap("PostPayOpenTime")]
        [Validation(Required=false)]
        public long? PostPayOpenTime { get; set; }

        /// <summary>
        /// <para>The pay-as-you-go instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Normal.</description></item>
        /// <item><description><b>2</b>: Stopped due to overdue payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PostPayStatus")]
        [Validation(Required=false)]
        public int? PostPayStatus { get; set; }

        /// <summary>
        /// <para>The number of purchased application protection authorizations. Unit: authorizations per month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RaspCapacity")]
        [Validation(Required=false)]
        public long? RaspCapacity { get; set; }

        /// <summary>
        /// <para>The expiration UNIX timestamp of the Security Center instance. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>If you do not complete the renewal within 7 days after the instance expires, your paid instance is downgraded to the Free Edition. You cannot continue to use the features of the paid edition, and you cannot view your previous Security Center configuration data and historical alerting data, such as DDoS alerting. In this case, you must repurchase the paid edition of Security Center to enable the service. For more information, see <a href="https://help.aliyun.com/document_detail/42308.html">Purchase Security Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1625846400000</para>
        /// </summary>
        [NameInMap("ReleaseTime")]
        [Validation(Required=false)]
        public long? ReleaseTime { get; set; }

        /// <summary>
        /// <para>The unique identifier generated by Alibaba Cloud for the request.</para>
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
        /// <para>The pay-as-you-go EDR instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-edr-postpaid-fadaf</para>
        /// </summary>
        [NameInMap("SasEdrPostPaidInstanceId")]
        [Validation(Required=false)]
        public string SasEdrPostPaidInstanceId { get; set; }

        /// <summary>
        /// <para>The subscription EDR instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-edr-sfkhakhk</para>
        /// </summary>
        [NameInMap("SasEdrPrePaidInstanceId")]
        [Validation(Required=false)]
        public string SasEdrPrePaidInstanceId { get; set; }

        /// <summary>
        /// <para>The upfront EDR instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RELEASED</para>
        /// </summary>
        [NameInMap("SasEdrPrePaidInstanceStatus")]
        [Validation(Required=false)]
        public string SasEdrPrePaidInstanceStatus { get; set; }

        /// <summary>
        /// <para>The purchased EDR edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SasEdrVersion")]
        [Validation(Required=false)]
        public string SasEdrVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the log analysis feature is purchased. Valid values:</para>
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
        /// <para>The canary release status for the pay-as-you-go SDK.</para>
        /// 
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
        /// <para>The purchased log inbound traffic for Cloud Threat Detection and Response (CTDR). Unit: GB per day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ThreatAnalysisFlow")]
        [Validation(Required=false)]
        public int? ThreatAnalysisFlow { get; set; }

        /// <summary>
        /// <para>The list of child trial modules.</para>
        /// </summary>
        [NameInMap("TrialModuleList")]
        [Validation(Required=false)]
        public List<DescribeVersionConfigResponseBodyTrialModuleList> TrialModuleList { get; set; }
        public class DescribeVersionConfigResponseBodyTrialModuleList : TeaModel {
            /// <summary>
            /// <para>The name of the child trial module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EDR</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The trial edition.</para>
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
        /// <para>The purchased Security Center edition. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
        /// <item><description><b>7</b>: Ultimate Edition   </description></item>
        /// <item><description><b>8</b>: Multi-edition   </description></item>
        /// <item><description><b>10</b>: Value-added services only</description></item>
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
        /// <para>The number of purchased vulnerability fixing quotas. Unit: fixes per month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("VulFixCapacity")]
        [Validation(Required=false)]
        public long? VulFixCapacity { get; set; }

        /// <summary>
        /// <para>Indicates whether the web tamper-proofing service is enabled. Valid values:</para>
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
        /// <para>The number of purchased web tamper-proofing authorizations. One authorization enables web tamper-proofing for one server. Valid values: 0 to N.</para>
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
