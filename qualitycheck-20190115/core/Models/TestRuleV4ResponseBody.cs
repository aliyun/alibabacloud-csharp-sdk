// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class TestRuleV4ResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TestRuleV4ResponseBodyData Data { get; set; }
        public class TestRuleV4ResponseBodyData : TeaModel {
            [NameInMap("HitRuleReviewInfoList")]
            [Validation(Required=false)]
            public List<TestRuleV4ResponseBodyDataHitRuleReviewInfoList> HitRuleReviewInfoList { get; set; }
            public class TestRuleV4ResponseBodyDataHitRuleReviewInfoList : TeaModel {
                [NameInMap("BranchHitId")]
                [Validation(Required=false)]
                public long? BranchHitId { get; set; }

                [NameInMap("BranchInfoList")]
                [Validation(Required=false)]
                public List<TestRuleV4ResponseBodyDataHitRuleReviewInfoListBranchInfoList> BranchInfoList { get; set; }
                public class TestRuleV4ResponseBodyDataHitRuleReviewInfoListBranchInfoList : TeaModel {
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

                    [NameInMap("Situation")]
                    [Validation(Required=false)]
                    public NextNodeSituations Situation { get; set; }

                    [NameInMap("Triggers")]
                    [Validation(Required=false)]
                    public List<string> Triggers { get; set; }

                }

                [NameInMap("ConditionHitInfoList")]
                [Validation(Required=false)]
                public List<TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoList> ConditionHitInfoList { get; set; }
                public class TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoList : TeaModel {
                    [NameInMap("Cid")]
                    [Validation(Required=false)]
                    public List<string> Cid { get; set; }

                    [NameInMap("KeyWords")]
                    [Validation(Required=false)]
                    public List<TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoListKeyWords> KeyWords { get; set; }
                    public class TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoListKeyWords : TeaModel {
                        [NameInMap("Cid")]
                        [Validation(Required=false)]
                        public string Cid { get; set; }

                        [NameInMap("CustomizeCode")]
                        [Validation(Required=false)]
                        public string CustomizeCode { get; set; }

                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public int? From { get; set; }

                        [NameInMap("Oid")]
                        [Validation(Required=false)]
                        public string Oid { get; set; }

                        [NameInMap("OperatorKey")]
                        [Validation(Required=false)]
                        public string OperatorKey { get; set; }

                        [NameInMap("Pid")]
                        [Validation(Required=false)]
                        public int? Pid { get; set; }

                        [NameInMap("SimilarPhrase")]
                        [Validation(Required=false)]
                        public string SimilarPhrase { get; set; }

                        [NameInMap("Tid")]
                        [Validation(Required=false)]
                        public string Tid { get; set; }

                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public int? To { get; set; }

                        [NameInMap("Uuid")]
                        [Validation(Required=false)]
                        public string Uuid { get; set; }

                        [NameInMap("Val")]
                        [Validation(Required=false)]
                        public string Val { get; set; }

                    }

                    [NameInMap("Phrase")]
                    [Validation(Required=false)]
                    public TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoListPhrase Phrase { get; set; }
                    public class TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoListPhrase : TeaModel {
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        [NameInMap("BeginTime")]
                        [Validation(Required=false)]
                        public string BeginTime { get; set; }

                        [NameInMap("ChannelId")]
                        [Validation(Required=false)]
                        public int? ChannelId { get; set; }

                        [NameInMap("EmotionFineGrainedValue")]
                        [Validation(Required=false)]
                        public int? EmotionFineGrainedValue { get; set; }

                        [NameInMap("EmotionValue")]
                        [Validation(Required=false)]
                        public int? EmotionValue { get; set; }

                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        [NameInMap("HitStatus")]
                        [Validation(Required=false)]
                        public int? HitStatus { get; set; }

                        [NameInMap("HourMinSec")]
                        [Validation(Required=false)]
                        public string HourMinSec { get; set; }

                        [NameInMap("Identity")]
                        [Validation(Required=false)]
                        public string Identity { get; set; }

                        [NameInMap("Pid")]
                        [Validation(Required=false)]
                        public int? Pid { get; set; }

                        [NameInMap("RenterId")]
                        [Validation(Required=false)]
                        public long? RenterId { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        [NameInMap("Sid")]
                        [Validation(Required=false)]
                        public long? Sid { get; set; }

                        [NameInMap("SilenceDuration")]
                        [Validation(Required=false)]
                        public int? SilenceDuration { get; set; }

                        [NameInMap("SpeechRate")]
                        [Validation(Required=false)]
                        public int? SpeechRate { get; set; }

                        [NameInMap("Uuid")]
                        [Validation(Required=false)]
                        public string Uuid { get; set; }

                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                    }

                }

                [NameInMap("ConditionInfoList")]
                [Validation(Required=false)]
                public List<ConditionBasicInfo> ConditionInfoList { get; set; }

                [NameInMap("JudgeNodeName")]
                [Validation(Required=false)]
                public string JudgeNodeName { get; set; }

                [NameInMap("Lambda")]
                [Validation(Required=false)]
                public string Lambda { get; set; }

                [NameInMap("Matched")]
                [Validation(Required=false)]
                public bool? Matched { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("Rid")]
                [Validation(Required=false)]
                public long? Rid { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("RuleScoreType")]
                [Validation(Required=false)]
                public int? RuleScoreType { get; set; }

                [NameInMap("ScoreNumType")]
                [Validation(Required=false)]
                public int? ScoreNumType { get; set; }

                [NameInMap("TaskFlowId")]
                [Validation(Required=false)]
                public long? TaskFlowId { get; set; }

            }

            [NameInMap("HitTaskFlowList")]
            [Validation(Required=false)]
            public List<TestRuleV4ResponseBodyDataHitTaskFlowList> HitTaskFlowList { get; set; }
            public class TestRuleV4ResponseBodyDataHitTaskFlowList : TeaModel {
                [NameInMap("GraphFlow")]
                [Validation(Required=false)]
                public TaskGraphFlow GraphFlow { get; set; }

                [NameInMap("Rid")]
                [Validation(Required=false)]
                public long? Rid { get; set; }

                [NameInMap("TaskFlowType")]
                [Validation(Required=false)]
                public int? TaskFlowType { get; set; }

            }

            [NameInMap("UnhitRuleReviewInfoList")]
            [Validation(Required=false)]
            public List<TestRuleV4ResponseBodyDataUnhitRuleReviewInfoList> UnhitRuleReviewInfoList { get; set; }
            public class TestRuleV4ResponseBodyDataUnhitRuleReviewInfoList : TeaModel {
                [NameInMap("ConditionInfoList")]
                [Validation(Required=false)]
                public List<ConditionBasicInfo> ConditionInfoList { get; set; }

                [NameInMap("Matched")]
                [Validation(Required=false)]
                public bool? Matched { get; set; }

                [NameInMap("Rid")]
                [Validation(Required=false)]
                public long? Rid { get; set; }

                [NameInMap("TaskFlowType")]
                [Validation(Required=false)]
                public int? TaskFlowType { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
