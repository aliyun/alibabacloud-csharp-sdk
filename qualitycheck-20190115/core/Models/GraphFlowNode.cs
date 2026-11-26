// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GraphFlowNode : TeaModel {
        /// <summary>
        /// <para>The operator information.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<ConditionBasicInfo> Conditions { get; set; }

        /// <summary>
        /// <para>The content for frontend display.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// <para>The node name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Start node</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The child nodes.</para>
        /// </summary>
        [NameInMap("NextNodes")]
        [Validation(Required=false)]
        public List<GraphFlowNodeNextNodes> NextNodes { get; set; }
        public class GraphFlowNodeNextNodes : TeaModel {
            /// <summary>
            /// <para>The quality check dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The flow branch priority. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The Lambda expression for the next hop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Lambda")]
            [Validation(Required=false)]
            public string Lambda { get; set; }

            /// <summary>
            /// <para>The conditional branch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The subsequent node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31533</para>
            /// </summary>
            [NameInMap("NextNodeId")]
            [Validation(Required=false)]
            public long? NextNodeId { get; set; }

            /// <summary>
            /// <para>The monitored operators.</para>
            /// </summary>
            [NameInMap("Triggers")]
            [Validation(Required=false)]
            public List<string> Triggers { get; set; }

        }

        /// <summary>
        /// <para>The node type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>startNode</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The node properties.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public GraphFlowNodeProperties Properties { get; set; }
        public class GraphFlowNodeProperties : TeaModel {
            /// <summary>
            /// <para>The auto review setting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Disables automatic review.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoReview")]
            [Validation(Required=false)]
            public int? AutoReview { get; set; }

            /// <summary>
            /// <para>Specifies whether branch judgment is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BranchJudge")]
            [Validation(Required=false)]
            public bool? BranchJudge { get; set; }

            /// <summary>
            /// <para>The maximum number of sentences to check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckMoreSize")]
            [Validation(Required=false)]
            public int? CheckMoreSize { get; set; }

            /// <summary>
            /// <para>The quality check dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The common operator logic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Lambda")]
            [Validation(Required=false)]
            public string Lambda { get; set; }

            /// <summary>
            /// <para>The role when the type is single.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Customer</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Specifies whether scoring is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleScoreType")]
            [Validation(Required=false)]
            public int? RuleScoreType { get; set; }

            /// <summary>
            /// <para>Indicates whether expression is enabled when the type is single.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deprecated field</para>
            /// </summary>
            [NameInMap("SayType")]
            [Validation(Required=false)]
            public string SayType { get; set; }

            /// <summary>
            /// <para>The score value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScoreNum")]
            [Validation(Required=false)]
            public int? ScoreNum { get; set; }

            /// <summary>
            /// <para>The score number type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Adds or deducts points after the rule is triggered.</description></item>
            /// <item><description>1: Assigns a one-time score after the rule is triggered.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScoreNumType")]
            [Validation(Required=false)]
            public int? ScoreNumType { get; set; }

            /// <summary>
            /// <para>The score rule hit type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Scores when the node is hit.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScoreRuleHitType")]
            [Validation(Required=false)]
            public int? ScoreRuleHitType { get; set; }

            /// <summary>
            /// <para>The score type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Adds points.</description></item>
            /// <item><description>3: Deducts points.
            /// Default value: 1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScoreType")]
            [Validation(Required=false)]
            public int? ScoreType { get; set; }

            /// <summary>
            /// <para>The monitored operators.</para>
            /// </summary>
            [NameInMap("Triggers")]
            [Validation(Required=false)]
            public List<string> Triggers { get; set; }

            /// <summary>
            /// <para>The property type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deprecated field</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The rule ID. If the rule is not saved to the database, the value is empty. If the rule is saved, the value equals the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Rid")]
        [Validation(Required=false)]
        public long? Rid { get; set; }

        /// <summary>
        /// <para>Specifies whether to use operator matching or legacy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseConditions")]
        [Validation(Required=false)]
        public bool? UseConditions { get; set; }

    }

}
