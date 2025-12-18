// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class RiskCheckResults : TeaModel {
        [NameInMap("checkTime")]
        [Validation(Required=false)]
        public long? CheckTime { get; set; }

        /// <summary>
        /// <para>网关实例的唯一标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-0364f863b1a04474911b48cd6d51d03d</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>实例的基本信息</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public RiskCheckResultsMetadata Metadata { get; set; }
        public class RiskCheckResultsMetadata : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Ingress</para>
            /// </summary>
            [NameInMap("clusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>apigw.small.x1</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.0.14</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>详细的风险项信息列表</para>
        /// </summary>
        [NameInMap("riskDetails")]
        [Validation(Required=false)]
        public List<RiskCheckResultsRiskDetails> RiskDetails { get; set; }
        public class RiskCheckResultsRiskDetails : TeaModel {
            /// <summary>
            /// <para>执行检测的模块名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>BaseInfo</para>
            /// </summary>
            [NameInMap("checkModule")]
            [Validation(Required=false)]
            public string CheckModule { get; set; }

            /// <summary>
            /// <para>风险相关的详细数据，不同风险类型数据结构不同</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, string> Data { get; set; }

            /// <summary>
            /// <para>风险的详细描述，JSON字符串格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;desc&quot;:&quot;单节点实例存在架构风险，单点故障会导致服务不可用。建议扩容到2节点及以上。&quot;}</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>该风险项的告警通知是否已被屏蔽</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isNoticeMute")]
            [Validation(Required=false)]
            public bool? IsNoticeMute { get; set; }

            /// <summary>
            /// <para>风险项的唯一标识码</para>
            /// 
            /// <b>Example:</b>
            /// <para>30010010001</para>
            /// </summary>
            [NameInMap("riskCode")]
            [Validation(Required=false)]
            public string RiskCode { get; set; }

            /// <summary>
            /// <para>该风险项的等级，可选值：LOW、MEDIUM、HIGH、CRITICAL</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("riskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>风险项的名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>单节点架构风险</para>
            /// </summary>
            [NameInMap("riskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// <para>风险分类，可选值：SYSTEM（系统风险）、VERSION（版本风险）、SAFE（安全风险）、CAPACITY（容量风险）</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("riskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            /// <summary>
            /// <para>当前实例的风险现状，JSON字符串格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;desc&quot;:&quot;集群节点数为1，不具备高可用能力&quot;}</para>
            /// </summary>
            [NameInMap("situation")]
            [Validation(Required=false)]
            public string Situation { get; set; }

            /// <summary>
            /// <para>针对该风险的优化建议，JSON字符串格式，包含描述和操作链接</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;desc&quot;:&quot;扩容到2节点及以上&quot;,&quot;links&quot;:[{&quot;descEn&quot;:&quot;click to upgrade specification&quot;,&quot;type&quot;:&quot;upgrade&quot;,&quot;desc&quot;:&quot;点击扩容&quot;}]}</para>
            /// </summary>
            [NameInMap("suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

        }

        /// <summary>
        /// <para>整体风险等级，可选值：LOW（低风险）、MEDIUM（中风险）、HIGH（高风险）、CRITICAL（严重风险）</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("riskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>风险综合评分，取值范围0-100分，分数越高表示风险越低</para>
        /// 
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("score")]
        [Validation(Required=false)]
        public int? Score { get; set; }

        [NameInMap("snapshotTime")]
        [Validation(Required=false)]
        public long? SnapshotTime { get; set; }

        /// <summary>
        /// <para>风险检测状态，可选值：SUCCESS（成功）、FAIL（失败）、RUNNING（运行中）</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>检测到的风险项总数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalRisk")]
        [Validation(Required=false)]
        public int? TotalRisk { get; set; }

    }

}
