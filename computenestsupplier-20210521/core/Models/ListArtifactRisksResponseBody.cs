// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactRisksResponseBody : TeaModel {
        /// <summary>
        /// <para>List of artifact risks</para>
        /// </summary>
        [NameInMap("ArtifactRiskList")]
        [Validation(Required=false)]
        public List<ListArtifactRisksResponseBodyArtifactRiskList> ArtifactRiskList { get; set; }
        public class ListArtifactRisksResponseBodyArtifactRiskList : TeaModel {
            /// <summary>
            /// <para>CVE numbers</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2023-4911</para>
            /// </summary>
            [NameInMap("CveNos")]
            [Validation(Required=false)]
            public string CveNos { get; set; }

            /// <summary>
            /// <para>Extended information, in JSON format, to be parsed according to the risk category</para>
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
            /// <para>Risk level:</para>
            /// <list type="bullet">
            /// <item><description>high represents high</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>Risk name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USN-3686-1: file vulnerabilities</para>
            /// </summary>
            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// <para>Risk type. Values:</para>
            /// <list type="bullet">
            /// <item><description>AcrCve  Container image system vulnerability</description></item>
            /// <item><description>AcrSca  Container image application vulnerability</description></item>
            /// <item><description>EcsVulnerability  ECS image vulnerability information</description></item>
            /// <item><description>EcsAlarm  ECS image security alarm</description></item>
            /// <item><description>EcsBaseline  ECS image baseline check</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AcrCve</para>
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            /// <summary>
            /// <para>Risk Type name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Container System Vulner</para>
            /// </summary>
            [NameInMap("RiskTypeName")]
            [Validation(Required=false)]
            public string RiskTypeName { get; set; }

            /// <summary>
            /// <para>Solution for the risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt-get update &amp;&amp; apt-get install ntpdate --only-upgrade</para>
            /// </summary>
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52919DB1-03A0-55F5-BDD4-DB6DEBB8267A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
