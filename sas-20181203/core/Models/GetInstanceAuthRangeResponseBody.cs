// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInstanceAuthRangeResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance authorization ranges.</para>
        /// </summary>
        [NameInMap("InstanceAuthRange")]
        [Validation(Required=false)]
        public GetInstanceAuthRangeResponseBodyInstanceAuthRange InstanceAuthRange { get; set; }
        public class GetInstanceAuthRangeResponseBodyInstanceAuthRange : TeaModel {
            /// <summary>
            /// <para>The number of servers for Advanced Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-2000000000</b>: The value range.</description></item>
            /// <item><description><b>1</b>: The step size.</description></item>
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
            /// <item><description><b>1-9000000000</b>: The value range.</description></item>
            /// <item><description><b>10</b>: The step size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-9000000000:10</para>
            /// </summary>
            [NameInMap("AntiRansomwareCapacity")]
            [Validation(Required=false)]
            public string AntiRansomwareCapacity { get; set; }

            /// <summary>
            /// <para>The Anti-ransomware service. Valid values:</para>
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
            /// <item><description><b>1-2000000000</b>: The value range.</description></item>
            /// <item><description><b>1</b>: The step size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1-2000000000:1</para>
            /// </summary>
            [NameInMap("AntiVirusCore")]
            [Validation(Required=false)]
            public string AntiVirusCore { get; set; }

            /// <summary>
            /// <para>The number of cores for Ultimate Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-2000000000</b>: The value range.</description></item>
            /// <item><description><b>1</b>: The step size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1-2000000000:1</para>
            /// </summary>
            [NameInMap("ContainerCore")]
            [Validation(Required=false)]
            public string ContainerCore { get; set; }

            /// <summary>
            /// <para>The number of servers for Ultimate Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-2000000000</b>: The value range.</description></item>
            /// <item><description><b>1</b>: The step size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1-2000000000:1</para>
            /// </summary>
            [NameInMap("ContainerCount")]
            [Validation(Required=false)]
            public string ContainerCount { get; set; }

            /// <summary>
            /// <para>The Cloud Security Posture Management (CSPM) scan quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>15000-9999999999</b>: The value range.</description></item>
            /// <item><description><b>55000</b>: The step size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>15000-9999999999:55000</para>
            /// </summary>
            [NameInMap("CspmCapacity")]
            [Validation(Required=false)]
            public string CspmCapacity { get; set; }

            /// <summary>
            /// <para>The Cloud Security Posture Management (CSPM) instance authorization capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CspmInstanceCapacity")]
            [Validation(Required=false)]
            public string CspmInstanceCapacity { get; set; }

            /// <summary>
            /// <para>The value range for the number of servers for Enterprise Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Value</b>: 1-2000000000</description></item>
            /// <item><description><b>Step size</b>: 1</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1-2000000000:1</para>
            /// </summary>
            [NameInMap("EnterpriseCount")]
            [Validation(Required=false)]
            public string EnterpriseCount { get; set; }

            /// <summary>
            /// <para>The cloud honeypot quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>20-500</b>: The value range.</description></item>
            /// <item><description><b>1</b>: The step size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20-500:1</para>
            /// </summary>
            [NameInMap("HoneypotCapacity")]
            [Validation(Required=false)]
            public string HoneypotCapacity { get; set; }

            /// <summary>
            /// <para>The image scan quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-200000</b>: The value range.</description></item>
            /// <item><description><b>20</b>: The step size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-200000:20</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public string ImageScanCapacity { get; set; }

            /// <summary>
            /// <para>The Application Protection quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-100000000</b>: The value range.</description></item>
            /// <item><description><b>1</b>: The step size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-100000000:1</para>
            /// </summary>
            [NameInMap("RaspCapacity")]
            [Validation(Required=false)]
            public string RaspCapacity { get; set; }

            /// <summary>
            /// <para>The malicious file detection SDK quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>10-9999999999</b>: The value range.</description></item>
            /// <item><description><b>10</b>: The step size.</description></item>
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
            /// <item><description><b>1-600000000</b>: The value range.</description></item>
            /// <item><description><b>10</b>: The step size.</description></item>
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
            /// <item><description><b>1-9999999999</b>: The value range.</description></item>
            /// <item><description><b>1000</b>: The step size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-9999999999:1000</para>
            /// </summary>
            [NameInMap("ThreatAnalysisCapacity")]
            [Validation(Required=false)]
            public string ThreatAnalysisCapacity { get; set; }

            /// <summary>
            /// <para>The log ingestion traffic for Cloud Threat Detection and Response (CTDR). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-9999999999</b>: The value range.</description></item>
            /// <item><description><b>100</b>: The step size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0-9999999999:100</para>
            /// </summary>
            [NameInMap("ThreatAnalysisFlow")]
            [Validation(Required=false)]
            public string ThreatAnalysisFlow { get; set; }

            /// <summary>
            /// <para>The web tamper-proofing authorization quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1-9999</b>: The value range.</description></item>
            /// <item><description><b>1</b>: The step size.</description></item>
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
        /// <para>The ID of the request. This ID is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
