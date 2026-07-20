// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeVersionConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVersionConfigResponseBodyData Data { get; set; }
        public class DescribeVersionConfigResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public DescribeVersionConfigResponseBodyDataBody Body { get; set; }
            public class DescribeVersionConfigResponseBodyDataBody : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AgentlessCapacity")]
                [Validation(Required=false)]
                public long? AgentlessCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AllowPartialBuy")]
                [Validation(Required=false)]
                public int? AllowPartialBuy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1680</para>
                /// </summary>
                [NameInMap("AntiRansomwareCapacity")]
                [Validation(Required=false)]
                public int? AntiRansomwareCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AntiRansomwareService")]
                [Validation(Required=false)]
                public int? AntiRansomwareService { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AppWhiteList")]
                [Validation(Required=false)]
                public int? AppWhiteList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("AppWhiteListAuthCount")]
                [Validation(Required=false)]
                public long? AppWhiteListAuthCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AssetLevel")]
                [Validation(Required=false)]
                public int? AssetLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CanTryPostPaidPackage")]
                [Validation(Required=false)]
                public int? CanTryPostPaidPackage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CspmCapacity")]
                [Validation(Required=false)]
                public long? CspmCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HighestVersion")]
                [Validation(Required=false)]
                public int? HighestVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HoneypotCapacity")]
                [Validation(Required=false)]
                public long? HoneypotCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1900</para>
                /// </summary>
                [NameInMap("ImageScanCapacity")]
                [Validation(Required=false)]
                public long? ImageScanCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InstanceBuyType")]
                [Validation(Required=false)]
                public int? InstanceBuyType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("IntelligentAnalysisFlow")]
                [Validation(Required=false)]
                public int? IntelligentAnalysisFlow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsNewContainerVersion")]
                [Validation(Required=false)]
                public bool? IsNewContainerVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsNewMultiVersion")]
                [Validation(Required=false)]
                public bool? IsNewMultiVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsOverBalance")]
                [Validation(Required=false)]
                public bool? IsOverBalance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsPostpay")]
                [Validation(Required=false)]
                public bool? IsPostpay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsTrialVersion")]
                [Validation(Required=false)]
                public int? IsTrialVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1603934844000</para>
                /// </summary>
                [NameInMap("LastTrailEndTime")]
                [Validation(Required=false)]
                public long? LastTrailEndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MergedVersion")]
                [Validation(Required=false)]
                public int? MergedVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("MultiVersion")]
                [Validation(Required=false)]
                public string MultiVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MvAuthCount")]
                [Validation(Required=false)]
                public int? MvAuthCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MvUnusedAuthCount")]
                [Validation(Required=false)]
                public int? MvUnusedAuthCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NewThreatAnalysis")]
                [Validation(Required=false)]
                public int? NewThreatAnalysis { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OnboardedAssets")]
                [Validation(Required=false)]
                public int? OnboardedAssets { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1657244824669</para>
                /// </summary>
                [NameInMap("OpenTime")]
                [Validation(Required=false)]
                public long? OpenTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PostPayHostVersion")]
                [Validation(Required=false)]
                public int? PostPayHostVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>postpay-sas-frme8vjfiw2j</para>
                /// </summary>
                [NameInMap("PostPayInstanceId")]
                [Validation(Required=false)]
                public string PostPayInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;BASIC_SERVICE\&quot;:0,\&quot;VUL\&quot;:0}</para>
                /// </summary>
                [NameInMap("PostPayModuleSwitch")]
                [Validation(Required=false)]
                public string PostPayModuleSwitch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1698915219000</para>
                /// </summary>
                [NameInMap("PostPayOpenTime")]
                [Validation(Required=false)]
                public long? PostPayOpenTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PostPayStatus")]
                [Validation(Required=false)]
                public int? PostPayStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("RaspCapacity")]
                [Validation(Required=false)]
                public long? RaspCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1625846400000</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public long? ReleaseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A6FB9AC3-4431-538F-BA8A-2A13AEA208A4</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SasLog")]
                [Validation(Required=false)]
                public int? SasLog { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SasScreen")]
                [Validation(Required=false)]
                public int? SasScreen { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SdkCapacity")]
                [Validation(Required=false)]
                public long? SdkCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SlsCapacity")]
                [Validation(Required=false)]
                public long? SlsCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ThreatAnalysisCapacity")]
                [Validation(Required=false)]
                public long? ThreatAnalysisCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ThreatAnalysisFlow")]
                [Validation(Required=false)]
                public int? ThreatAnalysisFlow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UserDefinedAlarms")]
                [Validation(Required=false)]
                public int? UserDefinedAlarms { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("VmCores")]
                [Validation(Required=false)]
                public int? VmCores { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("VulFixCapacity")]
                [Validation(Required=false)]
                public long? VulFixCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebLock")]
                [Validation(Required=false)]
                public int? WebLock { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebLockAuthCount")]
                [Validation(Required=false)]
                public long? WebLockAuthCount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6D462855-7835-5F91-835E-A62E44EC01CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
