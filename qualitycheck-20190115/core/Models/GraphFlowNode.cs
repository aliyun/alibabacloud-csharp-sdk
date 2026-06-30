// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GraphFlowNode : TeaModel {
        /// <summary>
        /// <para>Operator information.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<ConditionBasicInfo> Conditions { get; set; }

        /// <summary>
        /// <para>Used for frontend display.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Index</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// <para>Node name</para>
        /// 
        /// <b>Example:</b>
        /// <para>开始节点</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Child nodes</para>
        /// </summary>
        [NameInMap("NextNodes")]
        [Validation(Required=false)]
        public List<GraphFlowNodeNextNodes> NextNodes { get; set; }
        public class GraphFlowNodeNextNodes : TeaModel {
            /// <summary>
            /// <para>Quality check dimension</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>Flow branch priority. A smaller value indicates higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>Lambda expression for the next hop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Lambda")]
            [Validation(Required=false)]
            public string Lambda { get; set; }

            /// <summary>
            /// <para>Conditional branch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Next node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31533</para>
            /// </summary>
            [NameInMap("NextNodeId")]
            [Validation(Required=false)]
            public long? NextNodeId { get; set; }

            /// <summary>
            /// <para>Operators to follow.</para>
            /// </summary>
            [NameInMap("Triggers")]
            [Validation(Required=false)]
            public List<string> Triggers { get; set; }

        }

        /// <summary>
        /// <para>Node Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>startNode</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>Node properties</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public GraphFlowNodeProperties Properties { get; set; }
        public class GraphFlowNodeProperties : TeaModel {
            /// <summary>
            /// <para>1: Do not auto-review.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoReview")]
            [Validation(Required=false)]
            public int? AutoReview { get; set; }

            /// <summary>
            /// <para>Enable branch judgment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BranchJudge")]
            [Validation(Required=false)]
            public bool? BranchJudge { get; set; }

            /// <summary>
            /// <para>Maximum N sentences to check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckMoreSize")]
            [Validation(Required=false)]
            public int? CheckMoreSize { get; set; }

            /// <summary>
            /// <para>Quality check dimension</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>General operator logic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Lambda")]
            [Validation(Required=false)]
            public string Lambda { get; set; }

            /// <summary>
            /// <para>Role when the type is \<c>single\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Is scored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleScoreType")]
            [Validation(Required=false)]
            public int? RuleScoreType { get; set; }

            /// <summary>
            /// <para>Indicates expression when the type is \<c>single\\</c>.</para>
            /// </summary>
            [NameInMap("SayType")]
            [Validation(Required=false)]
            public string SayType { get; set; }

            /// <summary>
            /// <para>Score value</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScoreNum")]
            [Validation(Required=false)]
            public int? ScoreNum { get; set; }

            /// <summary>
            /// <para>0: Add or deduct points after the rule is triggered; 1: Score once after the rule is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScoreNumType")]
            [Validation(Required=false)]
            public int? ScoreNumType { get; set; }

            /// <summary>
            /// <para>0: Score when the node is hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScoreRuleHitType")]
            [Validation(Required=false)]
            public int? ScoreRuleHitType { get; set; }

            /// <summary>
            /// <para>1: Add points; 3: Deduct points; default is 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScoreType")]
            [Validation(Required=false)]
            public int? ScoreType { get; set; }

            /// <summary>
            /// <para>Operators to follow.</para>
            /// </summary>
            [NameInMap("Triggers")]
            [Validation(Required=false)]
            public List<string> Triggers { get; set; }

            /// <summary>
            /// <para>Property type</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Rule ID. \<c>rid\\</c> is empty if the rule is not persisted. If the rule is persisted, \<c>rid\\</c> equals \<c>ID\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Rid")]
        [Validation(Required=false)]
        public long? Rid { get; set; }

        /// <summary>
        /// <para>Whether to use operator matching or legacy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseConditions")]
        [Validation(Required=false)]
        public bool? UseConditions { get; set; }

    }

}
