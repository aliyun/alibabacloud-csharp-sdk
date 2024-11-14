// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class TestRuleV4ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BranchHitId")]
                [Validation(Required=false)]
                public long? BranchHitId { get; set; }

                [NameInMap("BranchInfoList")]
                [Validation(Required=false)]
                public List<TestRuleV4ResponseBodyDataHitRuleReviewInfoListBranchInfoList> BranchInfoList { get; set; }
                public class TestRuleV4ResponseBodyDataHitRuleReviewInfoListBranchInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CheckType")]
                    [Validation(Required=false)]
                    public int? CheckType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>a&amp;&amp;b</para>
                    /// </summary>
                    [NameInMap("Lambda")]
                    [Validation(Required=false)]
                    public string Lambda { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Cid")]
                        [Validation(Required=false)]
                        public string Cid { get; set; }

                        [NameInMap("CustomizeCode")]
                        [Validation(Required=false)]
                        public string CustomizeCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public int? From { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("Oid")]
                        [Validation(Required=false)]
                        public string Oid { get; set; }

                        [NameInMap("OperatorKey")]
                        [Validation(Required=false)]
                        public string OperatorKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>13</para>
                        /// </summary>
                        [NameInMap("Pid")]
                        [Validation(Required=false)]
                        public int? Pid { get; set; }

                        [NameInMap("SimilarPhrase")]
                        [Validation(Required=false)]
                        public string SimilarPhrase { get; set; }

                        [NameInMap("Tid")]
                        [Validation(Required=false)]
                        public string Tid { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>72000</para>
                        /// </summary>
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2019-11-25 15:37:16</para>
                        /// </summary>
                        [NameInMap("BeginTime")]
                        [Validation(Required=false)]
                        public string BeginTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ChannelId")]
                        [Validation(Required=false)]
                        public int? ChannelId { get; set; }

                        [NameInMap("EmotionFineGrainedValue")]
                        [Validation(Required=false)]
                        public int? EmotionFineGrainedValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>7</para>
                        /// </summary>
                        [NameInMap("EmotionValue")]
                        [Validation(Required=false)]
                        public int? EmotionValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>80000</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("HitStatus")]
                        [Validation(Required=false)]
                        public int? HitStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10:00:00</para>
                        /// </summary>
                        [NameInMap("HourMinSec")]
                        [Validation(Required=false)]
                        public string HourMinSec { get; set; }

                        [NameInMap("Identity")]
                        [Validation(Required=false)]
                        public string Identity { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("SilenceDuration")]
                        [Validation(Required=false)]
                        public int? SilenceDuration { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>a&amp;&amp;b</para>
                /// </summary>
                [NameInMap("Lambda")]
                [Validation(Required=false)]
                public string Lambda { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Matched")]
                [Validation(Required=false)]
                public bool? Matched { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>451</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public long? Rid { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RuleScoreType")]
                [Validation(Required=false)]
                public int? RuleScoreType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ScoreNumType")]
                [Validation(Required=false)]
                public int? ScoreNumType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Matched")]
                [Validation(Required=false)]
                public bool? Matched { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public long? Rid { get; set; }

                [NameInMap("TaskFlowType")]
                [Validation(Required=false)]
                public int? TaskFlowType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>96138D8D-XXXX-4E41-XXXX-77AED1088BBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
