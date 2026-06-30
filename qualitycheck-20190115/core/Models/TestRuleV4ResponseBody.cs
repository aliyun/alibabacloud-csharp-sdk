// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class TestRuleV4ResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code. 200 indicates success. Other values indicate failure. Callers can use this field to identify the cause of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Full response body.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TestRuleV4ResponseBodyData Data { get; set; }
        public class TestRuleV4ResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Information about hit check items.</para>
            /// </summary>
            [NameInMap("HitRuleReviewInfoList")]
            [Validation(Required=false)]
            public List<TestRuleV4ResponseBodyDataHitRuleReviewInfoList> HitRuleReviewInfoList { get; set; }
            public class TestRuleV4ResponseBodyDataHitRuleReviewInfoList : TeaModel {
                /// <summary>
                /// <para>ID of the hit branch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BranchHitId")]
                [Validation(Required=false)]
                public long? BranchHitId { get; set; }

                /// <summary>
                /// <para>List of branch information.</para>
                /// </summary>
                [NameInMap("BranchInfoList")]
                [Validation(Required=false)]
                public List<TestRuleV4ResponseBodyDataHitRuleReviewInfoListBranchInfoList> BranchInfoList { get; set; }
                public class TestRuleV4ResponseBodyDataHitRuleReviewInfoListBranchInfoList : TeaModel {
                    /// <summary>
                    /// <para>Check item type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CheckType")]
                    [Validation(Required=false)]
                    public int? CheckType { get; set; }

                    /// <summary>
                    /// <para>Index number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>Lambda expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a&amp;&amp;b</para>
                    /// </summary>
                    [NameInMap("Lambda")]
                    [Validation(Required=false)]
                    public string Lambda { get; set; }

                    /// <summary>
                    /// <para>Node name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>节点A</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>ID of the next flow node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("NextNodeId")]
                    [Validation(Required=false)]
                    public long? NextNodeId { get; set; }

                    /// <summary>
                    /// <para>Flow node condition.</para>
                    /// </summary>
                    [NameInMap("Situation")]
                    [Validation(Required=false)]
                    public NextNodeSituations Situation { get; set; }

                    /// <summary>
                    /// <para>List of trigger IDs.</para>
                    /// </summary>
                    [NameInMap("Triggers")]
                    [Validation(Required=false)]
                    public List<string> Triggers { get; set; }

                }

                /// <summary>
                /// <para>Information about hit conditions.</para>
                /// </summary>
                [NameInMap("ConditionHitInfoList")]
                [Validation(Required=false)]
                public List<TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoList> ConditionHitInfoList { get; set; }
                public class TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoList : TeaModel {
                    /// <summary>
                    /// <para>Condition ID.</para>
                    /// </summary>
                    [NameInMap("Cid")]
                    [Validation(Required=false)]
                    public List<string> Cid { get; set; }

                    /// <summary>
                    /// <para>Key information that was hit. This information appears highlighted on the review page. Examples include keywords matched by a keyword-check operator or category information matched by an agent-model-check operator.</para>
                    /// </summary>
                    [NameInMap("KeyWords")]
                    [Validation(Required=false)]
                    public List<TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoListKeyWords> KeyWords { get; set; }
                    public class TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoListKeyWords : TeaModel {
                        /// <summary>
                        /// <para>Condition ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Cid")]
                        [Validation(Required=false)]
                        public string Cid { get; set; }

                        /// <summary>
                        /// <para>Internal field. Ignore this field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>无</para>
                        /// </summary>
                        [NameInMap("CustomizeCode")]
                        [Validation(Required=false)]
                        public string CustomizeCode { get; set; }

                        /// <summary>
                        /// <para>Starting character position for highlighting. Index starts at 0. Maximum value is the total number of characters in the sentence minus 1. The character at position from is included in the highlight.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public int? From { get; set; }

                        /// <summary>
                        /// <para>Operator ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("Oid")]
                        [Validation(Required=false)]
                        public string Oid { get; set; }

                        /// <summary>
                        /// <para>Key information matched by the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>无</para>
                        /// </summary>
                        [NameInMap("OperatorKey")]
                        [Validation(Required=false)]
                        public string OperatorKey { get; set; }

                        /// <summary>
                        /// <para>Index of this sentence in the full list of sentences. This is the index of the sentence in the dialogues array of the request parameters, starting from 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>13</para>
                        /// </summary>
                        [NameInMap("Pid")]
                        [Validation(Required=false)]
                        public int? Pid { get; set; }

                        /// <summary>
                        /// <para>Similar phrase.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>您好</para>
                        /// </summary>
                        [NameInMap("SimilarPhrase")]
                        [Validation(Required=false)]
                        public string SimilarPhrase { get; set; }

                        /// <summary>
                        /// <para>Internal use only. Ignore this field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>无</para>
                        /// </summary>
                        [NameInMap("Tid")]
                        [Validation(Required=false)]
                        public string Tid { get; set; }

                        /// <summary>
                        /// <para>The position of the character that follows the highlighted keyword. The character at the \<c>to\\</c> position is not included in the highlight. For example, if \<c>from\\</c> is 0 and \<c>to\\</c> is 3, the highlighted keyword consists of the characters at indices 0, 1, and 2. The maximum value is one less than the total number of characters in the sentence.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public int? To { get; set; }

                        /// <summary>
                        /// <para>Internal use only. Ignore this field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>无</para>
                        /// </summary>
                        [NameInMap("Uuid")]
                        [Validation(Required=false)]
                        public string Uuid { get; set; }

                        /// <summary>
                        /// <para>Key information matched by the operator. For details, see <b>Detailed explanation of Val key information</b> in the response parameter description below.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>你好</para>
                        /// </summary>
                        [NameInMap("Val")]
                        [Validation(Required=false)]
                        public string Val { get; set; }

                    }

                    /// <summary>
                    /// <para>Sentence details for the current hit check item.</para>
                    /// </summary>
                    [NameInMap("Phrase")]
                    [Validation(Required=false)]
                    public TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoListPhrase Phrase { get; set; }
                    public class TestRuleV4ResponseBodyDataHitRuleReviewInfoListConditionHitInfoListPhrase : TeaModel {
                        /// <summary>
                        /// <para>Start time offset of this sentence relative to the start of the full dialogue, in milliseconds. For example, if the total audio duration is 2 minutes and 10 seconds, and a customer starts speaking at 1 minute and 12 seconds and finishes at 1 minute and 20 seconds, then begin equals 72000 and end equals 80000.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>72000</para>
                        /// </summary>
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        /// <summary>
                        /// <para>Start time of this sentence. Example: 2019-11-25 15:37:16.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-11-25 15:37:16</para>
                        /// </summary>
                        [NameInMap("BeginTime")]
                        [Validation(Required=false)]
                        public string BeginTime { get; set; }

                        /// <summary>
                        /// <para>Channel ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ChannelId")]
                        [Validation(Required=false)]
                        public int? ChannelId { get; set; }

                        /// <summary>
                        /// <para>Internal use only. Ignore this field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>忽略</para>
                        /// </summary>
                        [NameInMap("EmotionFineGrainedValue")]
                        [Validation(Required=false)]
                        public int? EmotionFineGrainedValue { get; set; }

                        /// <summary>
                        /// <para>Emotion intensity score. Value equals volume in decibels divided by 10. Valid range: [1, 10]. Higher values indicate stronger emotion.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>7</para>
                        /// </summary>
                        [NameInMap("EmotionValue")]
                        [Validation(Required=false)]
                        public int? EmotionValue { get; set; }

                        /// <summary>
                        /// <para>End time offset of this sentence relative to the start of the full dialogue, in milliseconds. For example, if the total audio duration is 2 minutes and 10 seconds, and a customer starts speaking at 1 minute and 12 seconds and finishes at 1 minute and 20 seconds, then begin equals 72000 and end equals 80000.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80000</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        /// <summary>
                        /// <para>Hit status. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>0</b>: Not hit</para>
                        /// </description></item>
                        /// <item><description><para><b>1</b>: Hit</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("HitStatus")]
                        [Validation(Required=false)]
                        public int? HitStatus { get; set; }

                        /// <summary>
                        /// <para>Start time of this sentence in hh:mm:ss format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10:00:00</para>
                        /// </summary>
                        [NameInMap("HourMinSec")]
                        [Validation(Required=false)]
                        public string HourMinSec { get; set; }

                        /// <summary>
                        /// <para>Role identifier. In offline voice scenarios, roles are limited to agent or customer. In offline text quality check scenarios, this field shows the identity value passed in during upload.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>客服</para>
                        /// </summary>
                        [NameInMap("Identity")]
                        [Validation(Required=false)]
                        public string Identity { get; set; }

                        /// <summary>
                        /// <para>Index of this sentence in the full list of sentences. This is the index of the sentence in the dialogues array of the request parameters, starting from 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Pid")]
                        [Validation(Required=false)]
                        public int? Pid { get; set; }

                        /// <summary>
                        /// <para>Internal use only. Ignore this field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>无</para>
                        /// </summary>
                        [NameInMap("RenterId")]
                        [Validation(Required=false)]
                        public long? RenterId { get; set; }

                        /// <summary>
                        /// <para>Speaker role for this sentence. Valid values: agent and customer.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>客服</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <para>Internal use only. Ignore this field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>无</para>
                        /// </summary>
                        [NameInMap("Sid")]
                        [Validation(Required=false)]
                        public long? Sid { get; set; }

                        /// <summary>
                        /// <para>Silence duration, in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("SilenceDuration")]
                        [Validation(Required=false)]
                        public int? SilenceDuration { get; set; }

                        /// <summary>
                        /// <para>Average speech rate for this sentence, in words per minute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("SpeechRate")]
                        [Validation(Required=false)]
                        public int? SpeechRate { get; set; }

                        /// <summary>
                        /// <para>Internal use only. Ignore this field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>无</para>
                        /// </summary>
                        [NameInMap("Uuid")]
                        [Validation(Required=false)]
                        public string Uuid { get; set; }

                        /// <summary>
                        /// <para>Dialogue content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>你好，请问有什么可以帮您</para>
                        /// </summary>
                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                    }

                }

                /// <summary>
                /// <para>List of conditions.</para>
                /// </summary>
                [NameInMap("ConditionInfoList")]
                [Validation(Required=false)]
                public List<ConditionBasicInfo> ConditionInfoList { get; set; }

                /// <summary>
                /// <para>Judgement node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>判断节点A</para>
                /// </summary>
                [NameInMap("JudgeNodeName")]
                [Validation(Required=false)]
                public string JudgeNodeName { get; set; }

                /// <summary>
                /// <para>Lambda expression. Example: a&amp;\&amp;b.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a&amp;&amp;b</para>
                /// </summary>
                [NameInMap("Lambda")]
                [Validation(Required=false)]
                public string Lambda { get; set; }

                /// <summary>
                /// <para>Whether the rule was hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Matched")]
                [Validation(Required=false)]
                public bool? Matched { get; set; }

                /// <summary>
                /// <para>Node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>Check item ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>451</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public long? Rid { get; set; }

                /// <summary>
                /// <para>Rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>规则A</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>Whether scoring applies. Valid values: 1 (no scoring) and 3 (scoring).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RuleScoreType")]
                [Validation(Required=false)]
                public int? RuleScoreType { get; set; }

                /// <summary>
                /// <para>Scoring type. Valid values: 0 (add or subtract points on hit) and 1 (one-time score on hit).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ScoreNumType")]
                [Validation(Required=false)]
                public int? ScoreNumType { get; set; }

                /// <summary>
                /// <para>Flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskFlowId")]
                [Validation(Required=false)]
                public long? TaskFlowId { get; set; }

            }

            /// <summary>
            /// <para>List of hit advanced flow nodes.</para>
            /// </summary>
            [NameInMap("HitTaskFlowList")]
            [Validation(Required=false)]
            public List<TestRuleV4ResponseBodyDataHitTaskFlowList> HitTaskFlowList { get; set; }
            public class TestRuleV4ResponseBodyDataHitTaskFlowList : TeaModel {
                /// <summary>
                /// <para>Flowchart canvas.</para>
                /// </summary>
                [NameInMap("GraphFlow")]
                [Validation(Required=false)]
                public TaskGraphFlow GraphFlow { get; set; }

                /// <summary>
                /// <para>Rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public long? Rid { get; set; }

                /// <summary>
                /// <para>Flowchart type. Deprecated. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("TaskFlowType")]
                [Validation(Required=false)]
                public int? TaskFlowType { get; set; }

            }

            /// <summary>
            /// <para>Information about rules that were not hit.</para>
            /// </summary>
            [NameInMap("UnhitRuleReviewInfoList")]
            [Validation(Required=false)]
            public List<TestRuleV4ResponseBodyDataUnhitRuleReviewInfoList> UnhitRuleReviewInfoList { get; set; }
            public class TestRuleV4ResponseBodyDataUnhitRuleReviewInfoList : TeaModel {
                /// <summary>
                /// <para>List of conditions.</para>
                /// </summary>
                [NameInMap("ConditionInfoList")]
                [Validation(Required=false)]
                public List<ConditionBasicInfo> ConditionInfoList { get; set; }

                /// <summary>
                /// <para>Whether the rule was hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Matched")]
                [Validation(Required=false)]
                public bool? Matched { get; set; }

                /// <summary>
                /// <para>The ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public long? Rid { get; set; }

                /// <summary>
                /// <para>Flowchart type. Deprecated. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>忽略</para>
                /// </summary>
                [NameInMap("TaskFlowType")]
                [Validation(Required=false)]
                public int? TaskFlowType { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error details when an error occurs. Returns successful when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96138D8D-XXXX-4E41-XXXX-77AED1088BBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Callers can use this field to determine success: true means success; false or null means failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
