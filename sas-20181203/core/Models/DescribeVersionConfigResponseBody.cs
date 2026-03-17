// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVersionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Number of agentless detections. </para>
        /// <remarks>
        /// <para>Agentless detection is not yet available for sale, so there\&quot;s no need to pay attention to this field at the moment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AgentlessCapacity")]
        [Validation(Required=false)]
        public long? AgentlessCapacity { get; set; }

        /// <summary>
        /// <para>Whether to allow pay-as-you-go purchases.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not allowed </description></item>
        /// <item><description><b>1</b>: Allowed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowPartialBuy")]
        [Validation(Required=false)]
        public int? AllowPartialBuy { get; set; }

        /// <summary>
        /// <para>Ransomware protection backup capacity, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160</para>
        /// </summary>
        [NameInMap("AntiRansomwareCapacity")]
        [Validation(Required=false)]
        public int? AntiRansomwareCapacity { get; set; }

        /// <summary>
        /// <para>Ransomware Guardian Service. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not activated</description></item>
        /// <item><description><b>1</b>: Activated</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AntiRansomwareService")]
        [Validation(Required=false)]
        public int? AntiRansomwareService { get; set; }

        /// <summary>
        /// <para>Whether to enable the application whitelist. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not enabled </description></item>
        /// <item><description><b>2</b>: Enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AppWhiteList")]
        [Validation(Required=false)]
        public int? AppWhiteList { get; set; }

        /// <summary>
        /// <para>Number of application whitelist authorizations. </para>
        /// <remarks>
        /// <para>One authorization allows the application of a whitelist policy to one server. After enabling the application whitelist function, the account will have 20 authorizations by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("AppWhiteListAuthCount")]
        [Validation(Required=false)]
        public long? AppWhiteListAuthCount { get; set; }

        /// <summary>
        /// <para>Number of purchased server licenses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("AssetLevel")]
        [Validation(Required=false)]
        public int? AssetLevel { get; set; }

        /// <summary>
        /// <para>Whether it supports the activation of a post-paid trial package. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not supported</description></item>
        /// <item><description><b>1</b>: Supported</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CanTryPostPaidPackage")]
        [Validation(Required=false)]
        public int? CanTryPostPaidPackage { get; set; }

        /// <summary>
        /// <para>Purchased cloud platform configuration check scan count. Unit: times/month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CspmCapacity")]
        [Validation(Required=false)]
        public long? CspmCapacity { get; set; }

        /// <summary>
        /// <para>Purchase the highest version of the Security Center. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition </description></item>
        /// <item><description><b>5</b>: Advanced Edition </description></item>
        /// <item><description><b>6</b>: Anti-Virus Edition</description></item>
        /// <item><description><b>7</b>: Flagship Edition </description></item>
        /// <item><description><b>10</b>: Purchase Additional Services Only <remarks>
        /// <para>When purchasing a single version, it indicates the corresponding version. When purchasing multiple versions, this value represents the highest version among the purchased multi-versions of Cloud Security Center.</para>
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
        /// <para>Number of purchased honeypot licenses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("HoneypotCapacity")]
        [Validation(Required=false)]
        public long? HoneypotCapacity { get; set; }

        /// <summary>
        /// <para>Number of purchased image scanning authorizations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8954</para>
        /// </summary>
        [NameInMap("ImageScanCapacity")]
        [Validation(Required=false)]
        public long? ImageScanCapacity { get; set; }

        /// <summary>
        /// <para>Instance purchase type. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Self-purchased</description></item>
        /// <item><description><b>1</b>: Allocated from multiple accounts</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InstanceBuyType")]
        [Validation(Required=false)]
        public int? InstanceBuyType { get; set; }

        /// <summary>
        /// <para>ID of the purchased Cloud Security Center instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-vg6hafdsafs****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>AI digital human analyzes traffic</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("IntelligentAnalysisFlow")]
        [Validation(Required=false)]
        public int? IntelligentAnalysisFlow { get; set; }

        /// <summary>
        /// <para>Whether it is the new flagship version.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: It is the latest version</description></item>
        /// <item><description><b>false</b>: It is not the latest version</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsNewContainerVersion")]
        [Validation(Required=false)]
        public bool? IsNewContainerVersion { get; set; }

        /// <summary>
        /// <para>Whether it is the latest multi-version.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: It is the latest multi-version </description></item>
        /// <item><description><b>false</b>: It is not the latest multi-version</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsNewMultiVersion")]
        [Validation(Required=false)]
        public bool? IsNewMultiVersion { get; set; }

        /// <summary>
        /// <para>Whether the number of existing servers exceeds the maximum authorized purchase quantity. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Not exceeded </description></item>
        /// <item><description><b>true</b>: Exceeded<remarks>
        /// <para>Notice: This parameter is deprecated, and you do not need to pay attention to it.</para>
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
        /// <para>Whether to enable pay-as-you-go. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Not enabled </description></item>
        /// <item><description><b>true</b>: Enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsPostpay")]
        [Validation(Required=false)]
        public bool? IsPostpay { get; set; }

        /// <summary>
        /// <para>Indicates whether the current Cloud Security Center version is a trial version. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not a trial version </description></item>
        /// <item><description><b>1</b>: Trial version</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsTrialVersion")]
        [Validation(Required=false)]
        public int? IsTrialVersion { get; set; }

        /// <summary>
        /// <para>The timestamp of the last trial expiration for Cloud Security Center, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1603934844000</para>
        /// </summary>
        [NameInMap("LastTrailEndTime")]
        [Validation(Required=false)]
        public long? LastTrailEndTime { get; set; }

        /// <summary>
        /// <para>Total number of licenses when purchasing multiple versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("MVAuthCount")]
        [Validation(Required=false)]
        public int? MVAuthCount { get; set; }

        /// <summary>
        /// <para>Total remaining licenses when purchasing multiple versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MVUnusedAuthCount")]
        [Validation(Required=false)]
        public int? MVUnusedAuthCount { get; set; }

        /// <summary>
        /// <para>When both the annual/monthly and pay-as-you-go services for Cloud Security Center\&quot;s host and container security are activated, the higher protection version of the two is selected. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition</description></item>
        /// <item><description><b>6</b>: Anti-Virus Edition </description></item>
        /// <item><description><b>5</b>: Advanced Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition </description></item>
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
        /// <para>Usage of multiple version numbers and license counts</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MultiVersion")]
        [Validation(Required=false)]
        public string MultiVersion { get; set; }

        /// <summary>
        /// <para>Whether to enable the new version of Threat Analysis and Response service. The new version of Threat Analysis and Response service refers to the one that supports purchasing access traffic and log storage capacity. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No </description></item>
        /// <item><description><b>1</b>: Yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewThreatAnalysis")]
        [Validation(Required=false)]
        public int? NewThreatAnalysis { get; set; }

        /// <summary>
        /// <para>AI Digital Human Management Instance</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OnboardedAssets")]
        [Validation(Required=false)]
        public int? OnboardedAssets { get; set; }

        /// <summary>
        /// <para>Service activation timestamp, unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657244824669</para>
        /// </summary>
        [NameInMap("OpenTime")]
        [Validation(Required=false)]
        public long? OpenTime { get; set; }

        /// <summary>
        /// <para>When activating the pay-as-you-go service for host and container security, it represents the highest protection version of the already bound assets. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>6</b>: Anti-Virus Edition </description></item>
        /// <item><description><b>7</b>: Flagship Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PostPayHostVersion")]
        [Validation(Required=false)]
        public int? PostPayHostVersion { get; set; }

        /// <summary>
        /// <para>Pay-As-You-Go instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postpay-sas-**</para>
        /// </summary>
        [NameInMap("PostPayInstanceId")]
        [Validation(Required=false)]
        public string PostPayInstanceId { get; set; }

        /// <summary>
        /// <para>Pay-as-you-go module switch status, in the format of JsonString, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description>Key:<list type="bullet">
        /// <item><description><b>VUL</b>: Vulnerability Repair Module </description></item>
        /// <item><description><b>CSPM</b>: Cloud Security Posture Management Module </description></item>
        /// <item><description><b>AGENTLESS</b>: Agentless Detection Module </description></item>
        /// <item><description><b>SERVERLESS</b>: Serverless Security Module </description></item>
        /// <item><description><b>CTDR</b>: Threat Analysis and Response Module </description></item>
        /// <item><description><b>POST_HOST</b>: Host and Container Security Module </description></item>
        /// <item><description><b>SDK</b>: Malicious File Detection SDK Module </description></item>
        /// <item><description><b>RASP</b>: Application Protection Module</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Value: 0 indicates off, 1 indicates on</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VUL&quot;:1}</para>
        /// </summary>
        [NameInMap("PostPayModuleSwitch")]
        [Validation(Required=false)]
        public string PostPayModuleSwitch { get; set; }

        /// <summary>
        /// <para>Pay-as-you-go activation time</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698915219000</para>
        /// </summary>
        [NameInMap("PostPayOpenTime")]
        [Validation(Required=false)]
        public long? PostPayOpenTime { get; set; }

        /// <summary>
        /// <para>Pay-As-You-Go instance status. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Normal </description></item>
        /// <item><description><b>2</b>: Stopped due to unpaid bills</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PostPayStatus")]
        [Validation(Required=false)]
        public int? PostPayStatus { get; set; }

        /// <summary>
        /// <para>Number of purchased application protections. Unit: per month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RaspCapacity")]
        [Validation(Required=false)]
        public long? RaspCapacity { get; set; }

        /// <summary>
        /// <para>The timestamp of when the Cloud Security Center instance will expire, in milliseconds.</para>
        /// <remarks>
        /// <para>If you do not renew the service within 7 days after it expires, your paid instance will be downgraded to a free version, and you will no longer be able to use the features of the paid version. Your previous Cloud Security Center configuration data and historical alert data (e.g., DDoS alerts) will become inaccessible. At this point, you can only re-enable the paid version of Cloud Security Center by repurchasing it. For more information, see <a href="https://help.aliyun.com/document_detail/42308.html">Purchasing Cloud Security Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1625846400000</para>
        /// </summary>
        [NameInMap("ReleaseTime")]
        [Validation(Required=false)]
        public long? ReleaseTime { get; set; }

        /// <summary>
        /// <para>The unique identifier generated by Alibaba Cloud for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2DC96D2-DD2E-49D9-A28E-85590475DF55</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether log analysis has been purchased. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not purchased </description></item>
        /// <item><description><b>1</b>: Purchased</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SasLog")]
        [Validation(Required=false)]
        public int? SasLog { get; set; }

        /// <summary>
        /// <para>Whether the security dashboard has been purchased. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not purchased </description></item>
        /// <item><description><b>1</b>: Purchased</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SasScreen")]
        [Validation(Required=false)]
        public int? SasScreen { get; set; }

        /// <summary>
        /// <para>Number of SDK authorizations for malicious file detection</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SdkCapacity")]
        [Validation(Required=false)]
        public long? SdkCapacity { get; set; }

        /// <summary>
        /// <para>Purchased log storage capacity in GB. Range: 0 to 200000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("SlsCapacity")]
        [Validation(Required=false)]
        public long? SlsCapacity { get; set; }

        /// <summary>
        /// <para>Purchased threat analysis capacity. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("ThreatAnalysisCapacity")]
        [Validation(Required=false)]
        public long? ThreatAnalysisCapacity { get; set; }

        /// <summary>
        /// <para>Purchased threat analysis and response log access traffic. Unit is GB/day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ThreatAnalysisFlow")]
        [Validation(Required=false)]
        public int? ThreatAnalysisFlow { get; set; }

        /// <summary>
        /// <para>Whether to enable the custom alarm function. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not enabled </description></item>
        /// <item><description><b>2</b>: Enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("UserDefinedAlarms")]
        [Validation(Required=false)]
        public int? UserDefinedAlarms { get; set; }

        /// <summary>
        /// <para>Purchased Cloud Security Center version. Values:   </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition </description></item>
        /// <item><description><b>5</b>: Advanced Edition </description></item>
        /// <item><description><b>6</b>: Anti-Virus Edition     </description></item>
        /// <item><description><b>7</b>: Flagship Edition   </description></item>
        /// <item><description><b>8</b>: Multi-Edition  </description></item>
        /// <item><description><b>10</b>: Value-Added Services Only</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        /// <summary>
        /// <para>Number of authorized cores purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("VmCores")]
        [Validation(Required=false)]
        public int? VmCores { get; set; }

        /// <summary>
        /// <para>Number of purchased vulnerability fixes. Unit: times/month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("VulFixCapacity")]
        [Validation(Required=false)]
        public long? VulFixCapacity { get; set; }

        /// <summary>
        /// <para>Indicates whether the web tamper-proof service is enabled. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not enabled </description></item>
        /// <item><description><b>1</b>: Enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WebLock")]
        [Validation(Required=false)]
        public int? WebLock { get; set; }

        /// <summary>
        /// <para>The number of purchased web tamper-proof licenses. One license can enable web tamper protection for one server. Value range: 0~N.</para>
        /// <remarks>
        /// <para>N is the number of servers you have.</para>
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
