// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class SchemeCheckType : TeaModel {
        [NameInMap("CheckName")]
        [Validation(Required=false)]
        public string CheckName { get; set; }

        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public long? CheckType { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        [NameInMap("SchemeId")]
        [Validation(Required=false)]
        public long? SchemeId { get; set; }

        [NameInMap("SchemeScoreInfoList")]
        [Validation(Required=false)]
        public List<SchemeCheckTypeSchemeScoreInfoList> SchemeScoreInfoList { get; set; }
        public class SchemeCheckTypeSchemeScoreInfoList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Rid")]
            [Validation(Required=false)]
            public long? Rid { get; set; }

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

            [NameInMap("TaskFlowId")]
            [Validation(Required=false)]
            public long? TaskFlowId { get; set; }

            [NameInMap("TaskFlowName")]
            [Validation(Required=false)]
            public string TaskFlowName { get; set; }

        }

        [NameInMap("Score")]
        [Validation(Required=false)]
        public int? Score { get; set; }

        [NameInMap("SourceScore")]
        [Validation(Required=false)]
        public int? SourceScore { get; set; }

        [NameInMap("TaskFlowScoreInfoList")]
        [Validation(Required=false)]
        public List<SchemeCheckTypeTaskFlowScoreInfoList> TaskFlowScoreInfoList { get; set; }
        public class SchemeCheckTypeTaskFlowScoreInfoList : TeaModel {
            [NameInMap("SchemeScoreInfoList")]
            [Validation(Required=false)]
            public List<SchemeCheckTypeTaskFlowScoreInfoListSchemeScoreInfoList> SchemeScoreInfoList { get; set; }
            public class SchemeCheckTypeTaskFlowScoreInfoListSchemeScoreInfoList : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Rid")]
                [Validation(Required=false)]
                public long? Rid { get; set; }

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

                [NameInMap("TaskFlowId")]
                [Validation(Required=false)]
                public long? TaskFlowId { get; set; }

                [NameInMap("TaskFlowName")]
                [Validation(Required=false)]
                public string TaskFlowName { get; set; }

            }

            [NameInMap("TaskFlowId")]
            [Validation(Required=false)]
            public long? TaskFlowId { get; set; }

            [NameInMap("TaskFlowName")]
            [Validation(Required=false)]
            public string TaskFlowName { get; set; }

            [NameInMap("TaskFlowType")]
            [Validation(Required=false)]
            public int? TaskFlowType { get; set; }

        }

    }

}
