// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class SyncQualityCheckResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SyncQualityCheckResponseBodyData Data { get; set; }
        public class SyncQualityCheckResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1584535485856</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<SyncQualityCheckResponseBodyDataRules> Rules { get; set; }
            public class SyncQualityCheckResponseBodyDataRules : TeaModel {
                [NameInMap("Hit")]
                [Validation(Required=false)]
                public List<SyncQualityCheckResponseBodyDataRulesHit> Hit { get; set; }
                public class SyncQualityCheckResponseBodyDataRulesHit : TeaModel {
                    [NameInMap("HitKeyWords")]
                    [Validation(Required=false)]
                    public List<SyncQualityCheckResponseBodyDataRulesHitHitKeyWords> HitKeyWords { get; set; }
                    public class SyncQualityCheckResponseBodyDataRulesHitHitKeyWords : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2312</para>
                        /// </summary>
                        [NameInMap("Cid")]
                        [Validation(Required=false)]
                        public int? Cid { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public int? From { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Pid")]
                        [Validation(Required=false)]
                        public int? Pid { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public int? To { get; set; }

                        [NameInMap("Val")]
                        [Validation(Required=false)]
                        public string Val { get; set; }

                    }

                    [NameInMap("Phrase")]
                    [Validation(Required=false)]
                    public SyncQualityCheckResponseBodyDataRulesHitPhrase Phrase { get; set; }
                    public class SyncQualityCheckResponseBodyDataRulesHitPhrase : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1230</para>
                        /// </summary>
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>6</para>
                        /// </summary>
                        [NameInMap("EmotionValue")]
                        [Validation(Required=false)]
                        public int? EmotionValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3440</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("Identity")]
                        [Validation(Required=false)]
                        public string Identity { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("SilenceDuration")]
                        [Validation(Required=false)]
                        public int? SilenceDuration { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>233</para>
                        /// </summary>
                        [NameInMap("SpeechRate")]
                        [Validation(Required=false)]
                        public int? SpeechRate { get; set; }

                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>232232</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public string Rid { get; set; }

                [NameInMap("RuleInfoBase")]
                [Validation(Required=false)]
                public SyncQualityCheckResponseBodyDataRulesRuleInfoBase RuleInfoBase { get; set; }
                public class SyncQualityCheckResponseBodyDataRulesRuleInfoBase : TeaModel {
                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public string Comments { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public int? Level { get; set; }

                    [NameInMap("RuleCategoryName")]
                    [Validation(Required=false)]
                    public string RuleCategoryName { get; set; }

                    [NameInMap("ScoreNum")]
                    [Validation(Required=false)]
                    public int? ScoreNum { get; set; }

                    [NameInMap("ScoreNumType")]
                    [Validation(Required=false)]
                    public int? ScoreNumType { get; set; }

                    [NameInMap("ScoreType")]
                    [Validation(Required=false)]
                    public int? ScoreType { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>66E1ACB866E1ACB8</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20200876-66E1ACB8</para>
            /// </summary>
            [NameInMap("Tid")]
            [Validation(Required=false)]
            public string Tid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>66E1ACB8-17B2-4BE8-8581-954A8*****</para>
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
