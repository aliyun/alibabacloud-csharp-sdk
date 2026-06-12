// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactRisksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of artifact risks.</para>
        /// </summary>
        [NameInMap("ArtifactRiskList")]
        [Validation(Required=false)]
        public List<ListArtifactRisksResponseBodyArtifactRiskList> ArtifactRiskList { get; set; }
        public class ListArtifactRisksResponseBodyArtifactRiskList : TeaModel {
            /// <summary>
            /// <para>The CVE ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2023-4911</para>
            /// </summary>
            [NameInMap("CveNos")]
            [Validation(Required=false)]
            public string CveNos { get; set; }

            /// <summary>
            /// <para>The extended information in JSON format. Parse this information based on the risk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;feature&quot;: &quot;ntpdate&quot;, 
            ///   &quot;version&quot;: &quot;4.2.6&quot;, 
            ///   &quot;cveLocation&quot;: &quot;/usr/lib&quot; 
            /// }</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>The risk level.</para>
            /// <list type="bullet">
            /// <item><description>high: High</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The name of the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USN-3686-1: file vulnerabilities</para>
            /// </summary>
            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// <para>The risk type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AcrCve: system vulnerabilities in a container image</para>
            /// </description></item>
            /// <item><description><para>AcrSca: application vulnerabilities in a container image</para>
            /// </description></item>
            /// <item><description><para>EcsVulnerability: ECS image vulnerabilities</para>
            /// </description></item>
            /// <item><description><para>EcsAlarm: ECS image security alerts</para>
            /// </description></item>
            /// <item><description><para>EcsBaseline: ECS image baseline checks</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AcrCve</para>
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            /// <summary>
            /// <para>The name of the risk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Container image system vulnerability</para>
            /// </summary>
            [NameInMap("RiskTypeName")]
            [Validation(Required=false)]
            public string RiskTypeName { get; set; }

            /// <summary>
            /// <para>The solution to the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt-get update &amp;&amp; apt-get install ntpdate --only-upgrade</para>
            /// </summary>
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52919DB1-03A0-55F5-BDD4-DB6DEBB8267A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
