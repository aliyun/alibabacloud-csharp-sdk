// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVersionConfigResponseBody : TeaModel {
        /// <summary>
        /// The quota for agentless detection.
        /// 
        /// >  The agentless detection feature is unavailable for purchase. You can ignore this parameter.
        /// </summary>
        [NameInMap("AgentlessCapacity")]
        [Validation(Required=false)]
        public long? AgentlessCapacity { get; set; }

        /// <summary>
        /// Indicates whether the pay-as-you-go billing method is supported.
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("AllowPartialBuy")]
        [Validation(Required=false)]
        public int? AllowPartialBuy { get; set; }

        /// <summary>
        /// Switch of anti-ransomware hosting service. Valid values:
        /// 
        /// *   **0**: off
        /// *   **1**: on
        /// </summary>
        [NameInMap("AntiRansomwareService")]
        [Validation(Required=false)]
        public int? AntiRansomwareService { get; set; }

        /// <summary>
        /// Indicates whether the application whitelist feature is enabled. Valid values:
        /// 
        /// *   **0**: no
        /// *   **2**: yes
        /// </summary>
        [NameInMap("AppWhiteList")]
        [Validation(Required=false)]
        public int? AppWhiteList { get; set; }

        /// <summary>
        /// The quota for the application whitelist feature.
        /// 
        /// >  The quantity of servers that are allowed by the quota is deducted by one each time you apply an application whitelist to a server. After you enable the application whitelist feature, the quota is 20 by default.
        /// </summary>
        [NameInMap("AppWhiteListAuthCount")]
        [Validation(Required=false)]
        public long? AppWhiteListAuthCount { get; set; }

        /// <summary>
        /// The quota for servers that can be protected.
        /// </summary>
        [NameInMap("AssetLevel")]
        [Validation(Required=false)]
        public int? AssetLevel { get; set; }

        /// <summary>
        /// The purchased quota for configuration assessment. Unit: times/month.
        /// </summary>
        [NameInMap("CspmCapacity")]
        [Validation(Required=false)]
        public long? CspmCapacity { get; set; }

        /// <summary>
        /// The most advanced edition that is used. Valid values:
        /// 
        /// *   **1**: Basic edition
        /// *   **3**: Enterprise edition
        /// *   **5**: Advanced edition
        /// *   **6**: Anti-virus edition
        /// *   **7**: Ultimate edition
        /// *   **10**: Value-added Plan edition
        /// 
        /// >  If you purchase the Multi-version edition of Security Center, the value indicates the most advanced edition that is used in the Multi-version edition. If you do not purchase the Multi-version edition of Security Center, the value indicates the edition of Security Center.
        /// </summary>
        [NameInMap("HighestVersion")]
        [Validation(Required=false)]
        public int? HighestVersion { get; set; }

        /// <summary>
        /// The purchased quota for the cloud honeypot feature.
        /// </summary>
        [NameInMap("HoneypotCapacity")]
        [Validation(Required=false)]
        public long? HoneypotCapacity { get; set; }

        /// <summary>
        /// The purchased quota for the container image scan feature.
        /// </summary>
        [NameInMap("ImageScanCapacity")]
        [Validation(Required=false)]
        public long? ImageScanCapacity { get; set; }

        /// <summary>
        /// The ID of purchased Security Center.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Indicates whether Security Center runs the latest version of the Ultimate edition.
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("IsNewContainerVersion")]
        [Validation(Required=false)]
        public bool? IsNewContainerVersion { get; set; }

        /// <summary>
        /// Indicates whether Security Center runs the latest version of the Multi-version edition. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("IsNewMultiVersion")]
        [Validation(Required=false)]
        public bool? IsNewMultiVersion { get; set; }

        /// <summary>
        /// Indicates whether the number of existing servers exceeds the purchased quota. Valid values:
        /// 
        /// *   **false**: no
        /// *   **true**: yes
        /// >Notice: This parameter is deprecated. You can ignore it.
        /// </summary>
        [NameInMap("IsOverBalance")]
        [Validation(Required=false)]
        public bool? IsOverBalance { get; set; }

        /// <summary>
        /// Indicates whether the pay-as-you-go billing method is used. Valid values:
        /// 
        /// *   **false**
        /// *   **true**
        /// </summary>
        [NameInMap("IsPostpay")]
        [Validation(Required=false)]
        public bool? IsPostpay { get; set; }

        /// <summary>
        /// Indicates whether Security Center runs the free trial edition. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("IsTrialVersion")]
        [Validation(Required=false)]
        public int? IsTrialVersion { get; set; }

        /// <summary>
        /// The timestamp when the last trial of Security Center ends. Unit: milliseconds.
        /// </summary>
        [NameInMap("LastTrailEndTime")]
        [Validation(Required=false)]
        public long? LastTrailEndTime { get; set; }

        /// <summary>
        /// The total quota in the Multi-version edition of purchased Security Center.
        /// </summary>
        [NameInMap("MVAuthCount")]
        [Validation(Required=false)]
        public int? MVAuthCount { get; set; }

        /// <summary>
        /// The total remaining quota in the Multi-version edition of purchased Security Center.
        /// </summary>
        [NameInMap("MVUnusedAuthCount")]
        [Validation(Required=false)]
        public int? MVUnusedAuthCount { get; set; }

        /// <summary>
        /// Indicates whether the new version of the threat analysis and response feature is enabled. With the new version, you can purchase the amount of log data that you want to add to the feature and log storage capacity. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("NewThreatAnalysis")]
        [Validation(Required=false)]
        public int? NewThreatAnalysis { get; set; }

        /// <summary>
        /// The timestamp when Security Center is purchased. Unit: milliseconds.
        /// </summary>
        [NameInMap("OpenTime")]
        [Validation(Required=false)]
        public long? OpenTime { get; set; }

        /// <summary>
        /// The instance ID of Security Center that uses the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("PostPayInstanceId")]
        [Validation(Required=false)]
        public string PostPayInstanceId { get; set; }

        /// <summary>
        /// The configuration of the pay-as-you-go module. Valid values:
        /// 
        /// *   **VUL**: vulnerability fixing module
        /// </summary>
        [NameInMap("PostPayModuleSwitch")]
        [Validation(Required=false)]
        public string PostPayModuleSwitch { get; set; }

        /// <summary>
        /// The creation time of Security Center that uses the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("PostPayOpenTime")]
        [Validation(Required=false)]
        public long? PostPayOpenTime { get; set; }

        /// <summary>
        /// The status of Security Center that uses the pay-as-you-go billing method. Valid values:
        /// 
        /// *   **1**: The instance runs as expected.
        /// *   **2**: The instance is stopped due to overdue payments.
        /// </summary>
        [NameInMap("PostPayStatus")]
        [Validation(Required=false)]
        public int? PostPayStatus { get; set; }

        /// <summary>
        /// The purchased quota for application protection. Unit: process/month.
        /// </summary>
        [NameInMap("RaspCapacity")]
        [Validation(Required=false)]
        public long? RaspCapacity { get; set; }

        /// <summary>
        /// The timestamp when the Security Center subscription ends. Unit: milliseconds.
        /// 
        /// >  If you do not renew the subscription within seven days after the expiration date, Security Center of a paid edition is automatically downgraded to Security Center Basic. In this case, you can no longer use the features of the paid edition or view the existing configurations or statistics such as DDoS alerts in Security Center. You must purchase Security Center of a paid edition to use relevant features. For more information, see [Purchase Security Center](https://help.aliyun.com/document_detail/42308.html).
        /// </summary>
        [NameInMap("ReleaseTime")]
        [Validation(Required=false)]
        public long? ReleaseTime { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether log analysis is purchased. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("SasLog")]
        [Validation(Required=false)]
        public int? SasLog { get; set; }

        /// <summary>
        /// Indicates whether the security screen feature is purchased. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("SasScreen")]
        [Validation(Required=false)]
        public int? SasScreen { get; set; }

        /// <summary>
        /// The purchased quota for malicious file detection SDK. Unit: process/month.
        /// </summary>
        [NameInMap("SdkCapacity")]
        [Validation(Required=false)]
        public long? SdkCapacity { get; set; }

        /// <summary>
        /// The log storage capacity that you purchase. Unit: GB. Valid values: 0 to 200000.
        /// </summary>
        [NameInMap("SlsCapacity")]
        [Validation(Required=false)]
        public long? SlsCapacity { get; set; }

        /// <summary>
        /// The purchased log storage capacity for threat analysis. Unit: GB.
        /// </summary>
        [NameInMap("ThreatAnalysisCapacity")]
        [Validation(Required=false)]
        public long? ThreatAnalysisCapacity { get; set; }

        /// <summary>
        /// The amount of log data that you purchase for the threat analysis and response feature. Unit: GB-day.
        /// </summary>
        [NameInMap("ThreatAnalysisFlow")]
        [Validation(Required=false)]
        public int? ThreatAnalysisFlow { get; set; }

        /// <summary>
        /// Indicates whether the custom alert feature is enabled. Valid values:
        /// 
        /// *   **0**: no
        /// *   **2**: yes
        /// </summary>
        [NameInMap("UserDefinedAlarms")]
        [Validation(Required=false)]
        public int? UserDefinedAlarms { get; set; }

        /// <summary>
        /// The edition of purchased Security Center. Valid values:
        /// 
        /// *   **1**: Basic edition
        /// *   **3**: Enterprise edition
        /// *   **5**: Advanced edition
        /// *   **6**: Anti-virus edition
        /// *   **7**: Ultimate edition
        /// *   **8**: Multi-version edition
        /// *   **10**: Value-added Plan edition
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        /// <summary>
        /// The quota for the cores of servers that can be protected.
        /// </summary>
        [NameInMap("VmCores")]
        [Validation(Required=false)]
        public int? VmCores { get; set; }

        /// <summary>
        /// The purchased quota for vulnerability fixing. Unit: times/month.
        /// </summary>
        [NameInMap("VulFixCapacity")]
        [Validation(Required=false)]
        public long? VulFixCapacity { get; set; }

        /// <summary>
        /// Indicates whether the web tamper proofing feature is enabled. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("WebLock")]
        [Validation(Required=false)]
        public int? WebLock { get; set; }

        /// <summary>
        /// The quota for the web tamper proofing feature. The quantity of servers that are allowed by the quota is deducted by one each time a server is protected by the web tamper proofing feature. Valid values: 0 to N.
        /// 
        /// >  N indicates the number of servers that you own.
        /// </summary>
        [NameInMap("WebLockAuthCount")]
        [Validation(Required=false)]
        public long? WebLockAuthCount { get; set; }

    }

}
