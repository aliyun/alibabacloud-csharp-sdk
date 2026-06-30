// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class SyncQualityCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>Result status code. 200 indicates success. Other values indicate failure. The caller can determine the reason for failure using this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned result, including hit information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SyncQualityCheckResponseBodyData Data { get; set; }
        public class SyncQualityCheckResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Time of recording and dialogue occurrence, in milliseconds since January 1, 1970, 00:00:00 UTC (UNIX timestamp in milliseconds, such as 1584535485856).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1584535485856</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>List of hit rules. Each item is a rule. Only hit rule information and hit rule location information are returned.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<SyncQualityCheckResponseBodyDataRules> Rules { get; set; }
            public class SyncQualityCheckResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>List of hit sentences. For this API, if a hit occurs, it is a single data entry.</para>
                /// </summary>
                [NameInMap("Hit")]
                [Validation(Required=false)]
                public List<SyncQualityCheckResponseBodyDataRulesHit> Hit { get; set; }
                public class SyncQualityCheckResponseBodyDataRulesHit : TeaModel {
                    /// <summary>
                    /// <para>Keywords that met the condition.</para>
                    /// </summary>
                    [NameInMap("HitKeyWords")]
                    [Validation(Required=false)]
                    public List<SyncQualityCheckResponseBodyDataRulesHitHitKeyWords> HitKeyWords { get; set; }
                    public class SyncQualityCheckResponseBodyDataRulesHitHitKeyWords : TeaModel {
                        /// <summary>
                        /// <para>Condition ID of the rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2312</para>
                        /// </summary>
                        [NameInMap("Cid")]
                        [Validation(Required=false)]
                        public int? Cid { get; set; }

                        /// <summary>
                        /// <para>Start position of the keyword.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public int? From { get; set; }

                        /// <summary>
                        /// <para>Index value of the hit sentence in the entire conversation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Pid")]
                        [Validation(Required=false)]
                        public int? Pid { get; set; }

                        /// <summary>
                        /// <para>End position of the keyword.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public int? To { get; set; }

                        /// <summary>
                        /// <para>Keyword.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>你好</para>
                        /// </summary>
                        [NameInMap("Val")]
                        [Validation(Required=false)]
                        public string Val { get; set; }

                    }

                    /// <summary>
                    /// <para>Dialogue content that met the condition.</para>
                    /// </summary>
                    [NameInMap("Phrase")]
                    [Validation(Required=false)]
                    public SyncQualityCheckResponseBodyDataRulesHitPhrase Phrase { get; set; }
                    public class SyncQualityCheckResponseBodyDataRulesHitPhrase : TeaModel {
                        /// <summary>
                        /// <para>Start time of this sentence relative to the entire conversation, in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1230</para>
                        /// </summary>
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        /// <summary>
                        /// <para>Emotional value of this sentence, 0-10. Higher values indicate stronger emotions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>6</para>
                        /// </summary>
                        [NameInMap("EmotionValue")]
                        [Validation(Required=false)]
                        public int? EmotionValue { get; set; }

                        /// <summary>
                        /// <para>End time of this sentence relative to the entire conversation, in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3440</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        /// <summary>
                        /// <para>Deprecated field. Ignore it.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("Identity")]
                        [Validation(Required=false)]
                        public string Identity { get; set; }

                        /// <summary>
                        /// <para>Role of this sentence. Valid values: customer service representative, customer.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>客服</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <para>Deprecated field. Ignore it.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("SilenceDuration")]
                        [Validation(Required=false)]
                        public int? SilenceDuration { get; set; }

                        /// <summary>
                        /// <para>Speech rate of this sentence, in characters per minute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>233</para>
                        /// </summary>
                        [NameInMap("SpeechRate")]
                        [Validation(Required=false)]
                        public int? SpeechRate { get; set; }

                        /// <summary>
                        /// <para>Dialogue content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>你好请问有什么可以帮您的</para>
                        /// </summary>
                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                    }

                }

                /// <summary>
                /// <para>ID of the hit rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>232232</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public string Rid { get; set; }

                /// <summary>
                /// <para>Rule basic information</para>
                /// </summary>
                [NameInMap("RuleInfoBase")]
                [Validation(Required=false)]
                public SyncQualityCheckResponseBodyDataRulesRuleInfoBase RuleInfoBase { get; set; }
                public class SyncQualityCheckResponseBodyDataRulesRuleInfoBase : TeaModel {
                    /// <summary>
                    /// <para>Rule remarks</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>邀约客户，客户不同意参加试听</para>
                    /// </summary>
                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public string Comments { get; set; }

                    /// <summary>
                    /// <para>Rule importance level</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public int? Level { get; set; }

                    /// <summary>
                    /// <para>Rule category name</para>
                    /// <remarks>
                    /// <para>Notice: The requiredFields parameter must include &quot;ruleInfoBase.ruleCategoryName&quot;.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>服务规范</para>
                    /// </summary>
                    [NameInMap("RuleCategoryName")]
                    [Validation(Required=false)]
                    public string RuleCategoryName { get; set; }

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
                    /// <para>Scoring type. 0: bonus/penalty points, 1: one-time score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ScoreNumType")]
                    [Validation(Required=false)]
                    public int? ScoreNumType { get; set; }

                    /// <summary>
                    /// <para>1 for bonus points, 3 for penalty points. Default is 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ScoreType")]
                    [Validation(Required=false)]
                    public int? ScoreType { get; set; }

                    /// <summary>
                    /// <para>Rule type ID</para>
                    /// <remarks>
                    /// <para>Notice: The requiredFields parameter must include &quot;ruleInfoBase&quot;.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <para>Name of the hit rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>禁用语</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <para>Final score, with a maximum of 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66E1ACB866E1ACB8</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Unique identifier for the current conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20200876-66E1ACB8</para>
            /// </summary>
            [NameInMap("Tid")]
            [Validation(Required=false)]
            public string Tid { get; set; }

        }

        /// <summary>
        /// <para>Error details if an error occurs. &quot;successful&quot; if successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Unique request identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66E1ACB8-17B2-4BE8-8581-954A8*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. The caller can use this field to determine if the request succeeded: true for success; false/null for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
