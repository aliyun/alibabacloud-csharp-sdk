// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class RiskCheckResults : TeaModel {
        /// <summary>
        /// <para>The check time</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890000</para>
        /// </summary>
        [NameInMap("checkTime")]
        [Validation(Required=false)]
        public long? CheckTime { get; set; }

        /// <summary>
        /// <para>The gateway ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-0364f863b1a04474911b48cd6d51d03d</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The instance metadata</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public RiskCheckResultsMetadata Metadata { get; set; }
        public class RiskCheckResultsMetadata : TeaModel {
            /// <summary>
            /// <para>The cluster type</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ingress</para>
            /// </summary>
            [NameInMap("clusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The replica count</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <para>The specification</para>
            /// 
            /// <b>Example:</b>
            /// <para>apigw.small.x1</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The version</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.14</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The risk details list</para>
        /// </summary>
        [NameInMap("riskDetails")]
        [Validation(Required=false)]
        public List<RiskCheckResultsRiskDetails> RiskDetails { get; set; }
        public class RiskCheckResultsRiskDetails : TeaModel {
            /// <summary>
            /// <para>The check module</para>
            /// 
            /// <b>Example:</b>
            /// <para>BaseInfo</para>
            /// </summary>
            [NameInMap("checkModule")]
            [Validation(Required=false)]
            public string CheckModule { get; set; }

            /// <summary>
            /// <para>The risk detailed data</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, string> Data { get; set; }

            /// <summary>
            /// <para>The risk description</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;desc&quot;:&quot;单节点实例存在架构风险，单点故障会导致服务不可用。建议扩容到2节点及以上。&quot;}</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Whether to mute notifications</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isNoticeMute")]
            [Validation(Required=false)]
            public bool? IsNoticeMute { get; set; }

            /// <summary>
            /// <para>The risk code</para>
            /// 
            /// <b>Example:</b>
            /// <para>30010010001</para>
            /// </summary>
            [NameInMap("riskCode")]
            [Validation(Required=false)]
            public string RiskCode { get; set; }

            /// <summary>
            /// <para>The risk level</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("riskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The risk title</para>
            /// 
            /// <b>Example:</b>
            /// <para>单节点架构风险</para>
            /// </summary>
            [NameInMap("riskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// <para>The risk type</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("riskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            /// <summary>
            /// <para>The risk situation</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;desc&quot;:&quot;集群节点数为1，不具备高可用能力&quot;}</para>
            /// </summary>
            [NameInMap("situation")]
            [Validation(Required=false)]
            public string Situation { get; set; }

            /// <summary>
            /// <para>The fix suggestion</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;desc&quot;:&quot;扩容到2节点及以上&quot;,&quot;links&quot;:[{&quot;descEn&quot;:&quot;click to upgrade specification&quot;,&quot;type&quot;:&quot;upgrade&quot;,&quot;desc&quot;:&quot;点击扩容&quot;}]}</para>
            /// </summary>
            [NameInMap("suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

        }

        /// <summary>
        /// <para>The risk level</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("riskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The risk score</para>
        /// 
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("score")]
        [Validation(Required=false)]
        public int? Score { get; set; }

        /// <summary>
        /// <para>The snapshot time</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890000</para>
        /// </summary>
        [NameInMap("snapshotTime")]
        [Validation(Required=false)]
        public long? SnapshotTime { get; set; }

        /// <summary>
        /// <para>The execution status</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of risks</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalRisk")]
        [Validation(Required=false)]
        public int? TotalRisk { get; set; }

    }

}
