// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class RiskCheckResults : TeaModel {
        /// <summary>
        /// <para>The check timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890000</para>
        /// </summary>
        [NameInMap("checkTime")]
        [Validation(Required=false)]
        public long? CheckTime { get; set; }

        /// <summary>
        /// <para>The unique identifier of the gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-0364f863b1a04474911b48cd6d51d03d</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The basic information of the instance.</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public RiskCheckResultsMetadata Metadata { get; set; }
        public class RiskCheckResultsMetadata : TeaModel {
            /// <summary>
            /// <para>The cluster type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ingress</para>
            /// </summary>
            [NameInMap("clusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The number of replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <para>The instance specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apigw.small.x1</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The instance version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.14</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The list of detailed risk item information.</para>
        /// </summary>
        [NameInMap("riskDetails")]
        [Validation(Required=false)]
        public List<RiskCheckResultsRiskDetails> RiskDetails { get; set; }
        public class RiskCheckResultsRiskDetails : TeaModel {
            /// <summary>
            /// <para>The name of the module that performs the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BaseInfo</para>
            /// </summary>
            [NameInMap("checkModule")]
            [Validation(Required=false)]
            public string CheckModule { get; set; }

            /// <summary>
            /// <para>The detailed data related to the risk. The data structure varies based on the risk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;30010010001&quot;:&quot;[\&quot;\&quot;,\&quot;\&quot;]&quot;}</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, string> Data { get; set; }

            /// <summary>
            /// <para>The detailed description of the risk in JSON string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;desc&quot;:&quot;Single-node instances have architecture risks. A single point of failure causes service unavailability. Scale out to two or more nodes.&quot;}</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether the alert notification for the risk item is muted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isNoticeMute")]
            [Validation(Required=false)]
            public bool? IsNoticeMute { get; set; }

            /// <summary>
            /// <para>The unique identifier of the risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30010010001</para>
            /// </summary>
            [NameInMap("riskCode")]
            [Validation(Required=false)]
            public string RiskCode { get; set; }

            /// <summary>
            /// <para>The level of the risk item. Valid values: LOW, MEDIUM, HIGH, and CRITICAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("riskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The name of the risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Single-node architecture risk</para>
            /// </summary>
            [NameInMap("riskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// <para>The risk categorization. Valid values: SYSTEM (system risk), VERSION (version risk), SAFE (security risk), and CAPACITY (capacity risk).</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("riskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            /// <summary>
            /// <para>The current risk situation of the instance in JSON string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;desc&quot;:&quot;The cluster has only one node and does not support high availability.&quot;}</para>
            /// </summary>
            [NameInMap("situation")]
            [Validation(Required=false)]
            public string Situation { get; set; }

            /// <summary>
            /// <para>The optimization suggestions for the risk in JSON string format, including descriptions and operation links.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;desc&quot;:&quot;Scale out to two or more nodes&quot;,&quot;links&quot;:[{&quot;descEn&quot;:&quot;click to upgrade specification&quot;,&quot;type&quot;:&quot;upgrade&quot;,&quot;desc&quot;:&quot;Click to scale out&quot;}]}</para>
            /// </summary>
            [NameInMap("suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

        }

        /// <summary>
        /// <para>The overall risk level. Valid values: LOW (low risk), MEDIUM (medium risk), HIGH (high risk), and CRITICAL (critical risk).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("riskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The overall risk score. Valid values: 0 to 100. A higher score indicates a lower risk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("score")]
        [Validation(Required=false)]
        public int? Score { get; set; }

        /// <summary>
        /// <para>The snapshot time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890000</para>
        /// </summary>
        [NameInMap("snapshotTime")]
        [Validation(Required=false)]
        public long? SnapshotTime { get; set; }

        /// <summary>
        /// <para>The risk check status. Valid values: SUCCESS, FAIL, and RUNNING.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of detected risk items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalRisk")]
        [Validation(Required=false)]
        public int? TotalRisk { get; set; }

    }

}
