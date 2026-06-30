// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class SchemeCheckType : TeaModel {
        /// <summary>
        /// <para>Check item name</para>
        /// 
        /// <b>Example:</b>
        /// <para>流程规则</para>
        /// </summary>
        [NameInMap("CheckName")]
        [Validation(Required=false)]
        public string CheckName { get; set; }

        /// <summary>
        /// <para>Quality inspection dimension ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public long? CheckType { get; set; }

        /// <summary>
        /// <para>Is enabled</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>Quality inspection scheme ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SchemeId")]
        [Validation(Required=false)]
        public long? SchemeId { get; set; }

        /// <summary>
        /// <para>List of scoring items under the check item. See SchemeScoreInfo.</para>
        /// </summary>
        [NameInMap("SchemeScoreInfoList")]
        [Validation(Required=false)]
        public List<SchemeCheckTypeSchemeScoreInfoList> SchemeScoreInfoList { get; set; }
        public class SchemeCheckTypeSchemeScoreInfoList : TeaModel {
            /// <summary>
            /// <para>Rule Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Rule ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rid")]
            [Validation(Required=false)]
            public long? Rid { get; set; }

            /// <summary>
            /// <para>Agent rating: default 0, [0, 100]</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScoreNum")]
            [Validation(Required=false)]
            public int? ScoreNum { get; set; }

            /// <summary>
            /// <para>0 – Add or subtract points after triggering a rule</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScoreNumType")]
            [Validation(Required=false)]
            public int? ScoreNumType { get; set; }

            /// <summary>
            /// <para>0 – Score when hitting an edge zone</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScoreRuleHitType")]
            [Validation(Required=false)]
            public int? ScoreRuleHitType { get; set; }

            /// <summary>
            /// <para>1 for adding points, 3 for deducting points; default is 1</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScoreType")]
            [Validation(Required=false)]
            public int? ScoreType { get; set; }

            /// <summary>
            /// <para>Flow ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskFlowId")]
            [Validation(Required=false)]
            public long? TaskFlowId { get; set; }

            /// <summary>
            /// <para>Flow name</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("TaskFlowName")]
            [Validation(Required=false)]
            public string TaskFlowName { get; set; }

        }

        /// <summary>
        /// <para>Final score</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public int? Score { get; set; }

        /// <summary>
        /// <para>Original score</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SourceScore")]
        [Validation(Required=false)]
        public int? SourceScore { get; set; }

        /// <summary>
        /// <para>List of scoring items under the check item. See TaskFlowScoreInfo.</para>
        /// </summary>
        [NameInMap("TaskFlowScoreInfoList")]
        [Validation(Required=false)]
        public List<SchemeCheckTypeTaskFlowScoreInfoList> TaskFlowScoreInfoList { get; set; }
        public class SchemeCheckTypeTaskFlowScoreInfoList : TeaModel {
            /// <summary>
            /// <para>list of scoring items</para>
            /// </summary>
            [NameInMap("SchemeScoreInfoList")]
            [Validation(Required=false)]
            public List<SchemeCheckTypeTaskFlowScoreInfoListSchemeScoreInfoList> SchemeScoreInfoList { get; set; }
            public class SchemeCheckTypeTaskFlowScoreInfoListSchemeScoreInfoList : TeaModel {
                /// <summary>
                /// <para>Rule Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Rule ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public long? Rid { get; set; }

                /// <summary>
                /// <para>Agent score: default is 0, range [0, 100]</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("ScoreNum")]
                [Validation(Required=false)]
                public int? ScoreNum { get; set; }

                /// <summary>
                /// <para>0 – Points added or deducted after a rule is triggered</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ScoreNumType")]
                [Validation(Required=false)]
                public int? ScoreNumType { get; set; }

                /// <summary>
                /// <para>0—score when a hit occurs at an edge zone</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ScoreRuleHitType")]
                [Validation(Required=false)]
                public int? ScoreRuleHitType { get; set; }

                /// <summary>
                /// <para>1 for adding points, 3 for deducting points; default is 1</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ScoreType")]
                [Validation(Required=false)]
                public int? ScoreType { get; set; }

                /// <summary>
                /// <para>Flow ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskFlowId")]
                [Validation(Required=false)]
                public long? TaskFlowId { get; set; }

                /// <summary>
                /// <para>flow name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("TaskFlowName")]
                [Validation(Required=false)]
                public string TaskFlowName { get; set; }

            }

            /// <summary>
            /// <para>Flow ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskFlowId")]
            [Validation(Required=false)]
            public long? TaskFlowId { get; set; }

            /// <summary>
            /// <para>flow name</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("TaskFlowName")]
            [Validation(Required=false)]
            public string TaskFlowName { get; set; }

            /// <summary>
            /// <para>\&quot;Flow version: 0: tree, 1: graph\&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskFlowType")]
            [Validation(Required=false)]
            public int? TaskFlowType { get; set; }

        }

    }

}
