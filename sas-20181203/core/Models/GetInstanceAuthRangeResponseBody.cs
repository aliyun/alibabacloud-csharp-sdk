// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInstanceAuthRangeResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance authorization range validation.</para>
        /// </summary>
        [NameInMap("InstanceAuthRange")]
        [Validation(Required=false)]
        public GetInstanceAuthRangeResponseBodyInstanceAuthRange InstanceAuthRange { get; set; }
        public class GetInstanceAuthRangeResponseBodyInstanceAuthRange : TeaModel {
            /// <summary>
            /// <para>The number of instances for the Advanced Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-2000000000</b>: range</description></item>
            /// <item><description><b>1</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1-2000000000:1</para>
            /// </summary>
            [NameInMap("AdvancedCount")]
            [Validation(Required=false)]
            public string AdvancedCount { get; set; }

            /// <summary>
            /// <para>The anti-ransomware capacity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-9000000000</b>: range</description></item>
            /// <item><description><b>10</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-9000000000:10</para>
            /// </summary>
            [NameInMap("AntiRansomwareCapacity")]
            [Validation(Required=false)]
            public string AntiRansomwareCapacity { get; set; }

            /// <summary>
            /// <para>The anti-ransomware managed service. Valid values:</para>
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
            /// <para>The number of cores for Anti-virus Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-2000000000</b>: range</description></item>
            /// <item><description><b>1</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1-2000000000:1</para>
            /// </summary>
            [NameInMap("AntiVirusCore")]
            [Validation(Required=false)]
            public string AntiVirusCore { get; set; }

            /// <summary>
            /// <para>The number of cores for the Ultimate Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-2000000000</b>: range</description></item>
            /// <item><description><b>1</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1-2000000000:1</para>
            /// </summary>
            [NameInMap("ContainerCore")]
            [Validation(Required=false)]
            public string ContainerCore { get; set; }

            /// <summary>
            /// <para>The number of instances for the Ultimate Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-2000000000</b>: range</description></item>
            /// <item><description><b>1</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1-2000000000:1</para>
            /// </summary>
            [NameInMap("ContainerCount")]
            [Validation(Required=false)]
            public string ContainerCount { get; set; }

            /// <summary>
            /// <para>The number of cloud platform configuration check scans. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>15000-9999999999</b>: range</description></item>
            /// <item><description><b>55000</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>15000-9999999999:55000</para>
            /// </summary>
            [NameInMap("CspmCapacity")]
            [Validation(Required=false)]
            public string CspmCapacity { get; set; }

            [NameInMap("CspmInstanceCapacity")]
            [Validation(Required=false)]
            public string CspmInstanceCapacity { get; set; }

            /// <summary>
            /// <para>The number of instances for the Enterprise Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Value</b>: 1-2000000000</description></item>
            /// <item><description><b>Step</b>: 1</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1-2000000000:1</para>
            /// </summary>
            [NameInMap("EnterpriseCount")]
            [Validation(Required=false)]
            public string EnterpriseCount { get; set; }

            /// <summary>
            /// <para>The number of honeypot authorizations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>20-500</b>: range</description></item>
            /// <item><description><b>1</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20-500:1</para>
            /// </summary>
            [NameInMap("HoneypotCapacity")]
            [Validation(Required=false)]
            public string HoneypotCapacity { get; set; }

            /// <summary>
            /// <para>The number of image scan authorizations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-200000</b>: range</description></item>
            /// <item><description><b>20</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-200000:20</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public string ImageScanCapacity { get; set; }

            /// <summary>
            /// <para>The number of application protection authorizations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-100000000</b>: range</description></item>
            /// <item><description><b>1</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-100000000:1</para>
            /// </summary>
            [NameInMap("RaspCapacity")]
            [Validation(Required=false)]
            public string RaspCapacity { get; set; }

            /// <summary>
            /// <para>The number of malicious file detection SDK authorizations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>10-9999999999</b>: range</description></item>
            /// <item><description><b>10</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10-9999999999:10</para>
            /// </summary>
            [NameInMap("SdkCapacity")]
            [Validation(Required=false)]
            public string SdkCapacity { get; set; }

            /// <summary>
            /// <para>The log storage capacity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-600000000</b>: range</description></item>
            /// <item><description><b>10</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-600000000:10</para>
            /// </summary>
            [NameInMap("SlsCapacity")]
            [Validation(Required=false)]
            public string SlsCapacity { get; set; }

            /// <summary>
            /// <para>The threat analysis capacity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-9999999999</b>: range</description></item>
            /// <item><description><b>1000</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-9999999999:1000</para>
            /// </summary>
            [NameInMap("ThreatAnalysisCapacity")]
            [Validation(Required=false)]
            public string ThreatAnalysisCapacity { get; set; }

            /// <summary>
            /// <para>The log ingestion traffic for threat detection and response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-9999999999</b>: range</description></item>
            /// <item><description><b>100</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-9999999999:100</para>
            /// </summary>
            [NameInMap("ThreatAnalysisFlow")]
            [Validation(Required=false)]
            public string ThreatAnalysisFlow { get; set; }

            /// <summary>
            /// <para>The number of web tamper-proofing authorizations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-9999</b>: range</description></item>
            /// <item><description><b>1</b>: step</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-9999:1</para>
            /// </summary>
            [NameInMap("WebLockCapacity")]
            [Validation(Required=false)]
            public string WebLockCapacity { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
