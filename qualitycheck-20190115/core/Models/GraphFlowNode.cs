// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GraphFlowNode : TeaModel {
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<ConditionBasicInfo> Conditions { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NextNodes")]
        [Validation(Required=false)]
        public List<GraphFlowNodeNextNodes> NextNodes { get; set; }
        public class GraphFlowNodeNextNodes : TeaModel {
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("Lambda")]
            [Validation(Required=false)]
            public string Lambda { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NextNodeId")]
            [Validation(Required=false)]
            public long? NextNodeId { get; set; }

            [NameInMap("Triggers")]
            [Validation(Required=false)]
            public List<string> Triggers { get; set; }

        }

        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("Properties")]
        [Validation(Required=false)]
        public GraphFlowNodeProperties Properties { get; set; }
        public class GraphFlowNodeProperties : TeaModel {
            [NameInMap("AutoReview")]
            [Validation(Required=false)]
            public int? AutoReview { get; set; }

            [NameInMap("BranchJudge")]
            [Validation(Required=false)]
            public bool? BranchJudge { get; set; }

            [NameInMap("CheckMoreSize")]
            [Validation(Required=false)]
            public int? CheckMoreSize { get; set; }

            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            [NameInMap("Lambda")]
            [Validation(Required=false)]
            public string Lambda { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("RuleScoreType")]
            [Validation(Required=false)]
            public int? RuleScoreType { get; set; }

            [NameInMap("SayType")]
            [Validation(Required=false)]
            public string SayType { get; set; }

            [NameInMap("ScoreNum")]
            [Validation(Required=false)]
            public int? ScoreNum { get; set; }

            [NameInMap("ScoreNumType")]
            [Validation(Required=false)]
            public int? ScoreNumType { get; set; }

            [NameInMap("ScoreRuleHitType")]
            [Validation(Required=false)]
            public int? ScoreRuleHitType { get; set; }

            [NameInMap("ScoreType")]
            [Validation(Required=false)]
            public int? ScoreType { get; set; }

            [NameInMap("Triggers")]
            [Validation(Required=false)]
            public List<string> Triggers { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Rid")]
        [Validation(Required=false)]
        public long? Rid { get; set; }

        [NameInMap("UseConditions")]
        [Validation(Required=false)]
        public bool? UseConditions { get; set; }

    }

}
