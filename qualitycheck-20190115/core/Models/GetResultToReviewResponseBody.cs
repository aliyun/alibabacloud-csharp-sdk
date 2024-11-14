// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetResultToReviewResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResultToReviewResponseBodyData Data { get; set; }
        public class GetResultToReviewResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>https</para>
            /// </summary>
            [NameInMap("AudioScheme")]
            [Validation(Required=false)]
            public string AudioScheme { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sca-ccc-test.oss-cn-beijing.aliyuncs.com/xxxxx</para>
            /// </summary>
            [NameInMap("AudioURL")]
            [Validation(Required=false)]
            public string AudioURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            [NameInMap("Dialogues")]
            [Validation(Required=false)]
            public GetResultToReviewResponseBodyDataDialogues Dialogues { get; set; }
            public class GetResultToReviewResponseBodyDataDialogues : TeaModel {
                [NameInMap("Dialogue")]
                [Validation(Required=false)]
                public List<GetResultToReviewResponseBodyDataDialoguesDialogue> Dialogue { get; set; }
                public class GetResultToReviewResponseBodyDataDialoguesDialogue : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>72000</para>
                    /// </summary>
                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public long? Begin { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2019-10-01 11:12:01</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

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
                    /// <para>00:08</para>
                    /// </summary>
                    [NameInMap("HourMinSec")]
                    [Validation(Required=false)]
                    public string HourMinSec { get; set; }

                    [NameInMap("Identity")]
                    [Validation(Required=false)]
                    public string Identity { get; set; }

                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SilenceDuration")]
                    [Validation(Required=false)]
                    public int? SilenceDuration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
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
            /// <para>e790e6c919d84b82b64ee*****</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx.wav</para>
            /// </summary>
            [NameInMap("FileMergeName")]
            [Validation(Required=false)]
            public string FileMergeName { get; set; }

            [NameInMap("HitRuleReviewInfoList")]
            [Validation(Required=false)]
            public GetResultToReviewResponseBodyDataHitRuleReviewInfoList HitRuleReviewInfoList { get; set; }
            public class GetResultToReviewResponseBodyDataHitRuleReviewInfoList : TeaModel {
                [NameInMap("HitRuleReviewInfo")]
                [Validation(Required=false)]
                public List<GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfo> HitRuleReviewInfo { get; set; }
                public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AutoReview")]
                    [Validation(Required=false)]
                    public int? AutoReview { get; set; }

                    [NameInMap("ComplainHistories")]
                    [Validation(Required=false)]
                    public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoComplainHistories ComplainHistories { get; set; }
                    public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoComplainHistories : TeaModel {
                        [NameInMap("ComplainHistories")]
                        [Validation(Required=false)]
                        public List<GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoComplainHistoriesComplainHistories> ComplainHistories { get; set; }
                        public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoComplainHistoriesComplainHistories : TeaModel {
                            [NameInMap("Comments")]
                            [Validation(Required=false)]
                            public string Comments { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2020-10-16T11:13Z</para>
                            /// </summary>
                            [NameInMap("OperationTime")]
                            [Validation(Required=false)]
                            public string OperationTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>5</para>
                            /// </summary>
                            [NameInMap("OperationType")]
                            [Validation(Required=false)]
                            public int? OperationType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>123456</para>
                            /// </summary>
                            [NameInMap("Operator")]
                            [Validation(Required=false)]
                            public long? Operator { get; set; }

                            [NameInMap("OperatorName")]
                            [Validation(Required=false)]
                            public string OperatorName { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Complainable")]
                    [Validation(Required=false)]
                    public bool? Complainable { get; set; }

                    [NameInMap("ConditionHitInfoList")]
                    [Validation(Required=false)]
                    public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoList ConditionHitInfoList { get; set; }
                    public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoList : TeaModel {
                        [NameInMap("ConditionHitInfo")]
                        [Validation(Required=false)]
                        public List<GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfo> ConditionHitInfo { get; set; }
                        public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfo : TeaModel {
                            [NameInMap("Cid")]
                            [Validation(Required=false)]
                            public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoCid Cid { get; set; }
                            public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoCid : TeaModel {
                                [NameInMap("Cid")]
                                [Validation(Required=false)]
                                public List<string> Cid { get; set; }

                            }

                            [NameInMap("KeyWords")]
                            [Validation(Required=false)]
                            public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWords KeyWords { get; set; }
                            public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWords : TeaModel {
                                [NameInMap("KeyWord")]
                                [Validation(Required=false)]
                                public List<GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWordsKeyWord> KeyWord { get; set; }
                                public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWordsKeyWord : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>2000</para>
                                    /// </summary>
                                    [NameInMap("Cid")]
                                    [Validation(Required=false)]
                                    public string Cid { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xxx</para>
                                    /// </summary>
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
                                    /// <para>2</para>
                                    /// </summary>
                                    [NameInMap("Pid")]
                                    [Validation(Required=false)]
                                    public int? Pid { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>6fa76916-3ce6-45d8-ac64-01b7f31c7295</para>
                                    /// </summary>
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

                                    [NameInMap("Val")]
                                    [Validation(Required=false)]
                                    public string Val { get; set; }

                                }

                            }

                            [NameInMap("Phrase")]
                            [Validation(Required=false)]
                            public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoPhrase Phrase { get; set; }
                            public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoPhrase : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>72000</para>
                                /// </summary>
                                [NameInMap("Begin")]
                                [Validation(Required=false)]
                                public long? Begin { get; set; }

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

                                [NameInMap("Role")]
                                [Validation(Required=false)]
                                public string Role { get; set; }

                                [NameInMap("Words")]
                                [Validation(Required=false)]
                                public string Words { get; set; }

                            }

                        }

                    }

                    [NameInMap("ReviewInfo")]
                    [Validation(Required=false)]
                    public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoReviewInfo ReviewInfo { get; set; }
                    public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoReviewInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>013c68142fec4f0899fa6ee0exxx</para>
                        /// </summary>
                        [NameInMap("HitId")]
                        [Validation(Required=false)]
                        public string HitId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("ReviewResult")]
                        [Validation(Required=false)]
                        public int? ReviewResult { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2019-10-12 17:06:00</para>
                        /// </summary>
                        [NameInMap("ReviewTime")]
                        [Validation(Required=false)]
                        public string ReviewTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("Reviewer")]
                        [Validation(Required=false)]
                        public string Reviewer { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>451</para>
                        /// </summary>
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }

                    }

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
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("ScoreId")]
                    [Validation(Required=false)]
                    public long? ScoreId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-10</para>
                    /// </summary>
                    [NameInMap("ScoreNum")]
                    [Validation(Required=false)]
                    public int? ScoreNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("ScoreSubId")]
                    [Validation(Required=false)]
                    public long? ScoreSubId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("ScoreSubName")]
                    [Validation(Required=false)]
                    public string ScoreSubName { get; set; }

                }

            }

            [NameInMap("ManualScoreInfoList")]
            [Validation(Required=false)]
            public GetResultToReviewResponseBodyDataManualScoreInfoList ManualScoreInfoList { get; set; }
            public class GetResultToReviewResponseBodyDataManualScoreInfoList : TeaModel {
                [NameInMap("ManualScoreInfo")]
                [Validation(Required=false)]
                public List<GetResultToReviewResponseBodyDataManualScoreInfoListManualScoreInfo> ManualScoreInfo { get; set; }
                public class GetResultToReviewResponseBodyDataManualScoreInfoListManualScoreInfo : TeaModel {
                    [NameInMap("ComplainHistories")]
                    [Validation(Required=false)]
                    public GetResultToReviewResponseBodyDataManualScoreInfoListManualScoreInfoComplainHistories ComplainHistories { get; set; }
                    public class GetResultToReviewResponseBodyDataManualScoreInfoListManualScoreInfoComplainHistories : TeaModel {
                        [NameInMap("ComplainHistories")]
                        [Validation(Required=false)]
                        public List<GetResultToReviewResponseBodyDataManualScoreInfoListManualScoreInfoComplainHistoriesComplainHistories> ComplainHistories { get; set; }
                        public class GetResultToReviewResponseBodyDataManualScoreInfoListManualScoreInfoComplainHistoriesComplainHistories : TeaModel {
                            [NameInMap("Comments")]
                            [Validation(Required=false)]
                            public string Comments { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2020-10-16T11:13Z</para>
                            /// </summary>
                            [NameInMap("OperationTime")]
                            [Validation(Required=false)]
                            public string OperationTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>5</para>
                            /// </summary>
                            [NameInMap("OperationType")]
                            [Validation(Required=false)]
                            public int? OperationType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>123456</para>
                            /// </summary>
                            [NameInMap("Operator")]
                            [Validation(Required=false)]
                            public long? Operator { get; set; }

                            [NameInMap("OperatorName")]
                            [Validation(Required=false)]
                            public string OperatorName { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Complainable")]
                    [Validation(Required=false)]
                    public bool? Complainable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("ScoreId")]
                    [Validation(Required=false)]
                    public long? ScoreId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-10</para>
                    /// </summary>
                    [NameInMap("ScoreNum")]
                    [Validation(Required=false)]
                    public int? ScoreNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("ScoreSubId")]
                    [Validation(Required=false)]
                    public long? ScoreSubId { get; set; }

                    [NameInMap("ScoreSubName")]
                    [Validation(Required=false)]
                    public string ScoreSubName { get; set; }

                }

            }

            [NameInMap("ReviewHistoryList")]
            [Validation(Required=false)]
            public GetResultToReviewResponseBodyDataReviewHistoryList ReviewHistoryList { get; set; }
            public class GetResultToReviewResponseBodyDataReviewHistoryList : TeaModel {
                [NameInMap("ReviewHistory")]
                [Validation(Required=false)]
                public List<GetResultToReviewResponseBodyDataReviewHistoryListReviewHistory> ReviewHistory { get; set; }
                public class GetResultToReviewResponseBodyDataReviewHistoryListReviewHistory : TeaModel {
                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public string Comments { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ComplainResult")]
                    [Validation(Required=false)]
                    public int? ComplainResult { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("OldScore")]
                    [Validation(Required=false)]
                    public int? OldScore { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public long? Operator { get; set; }

                    [NameInMap("OperatorName")]
                    [Validation(Required=false)]
                    public string OperatorName { get; set; }

                    [NameInMap("ReviewManagerType")]
                    [Validation(Required=false)]
                    public string ReviewManagerType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ReviewResult")]
                    [Validation(Required=false)]
                    public int? ReviewResult { get; set; }

                    [NameInMap("ReviewRightRule")]
                    [Validation(Required=false)]
                    public GetResultToReviewResponseBodyDataReviewHistoryListReviewHistoryReviewRightRule ReviewRightRule { get; set; }
                    public class GetResultToReviewResponseBodyDataReviewHistoryListReviewHistoryReviewRightRule : TeaModel {
                        [NameInMap("ReviewRightRule")]
                        [Validation(Required=false)]
                        public List<GetResultToReviewResponseBodyDataReviewHistoryListReviewHistoryReviewRightRuleReviewRightRule> ReviewRightRule { get; set; }
                        public class GetResultToReviewResponseBodyDataReviewHistoryListReviewHistoryReviewRightRuleReviewRightRule : TeaModel {
                            [NameInMap("rid")]
                            [Validation(Required=false)]
                            public long? Rid { get; set; }

                            [NameInMap("ruleName")]
                            [Validation(Required=false)]
                            public string RuleName { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>95</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public int? Score { get; set; }

                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public long? Time { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2019-10-28 15:21:00</para>
                    /// </summary>
                    [NameInMap("TimeStr")]
                    [Validation(Required=false)]
                    public string TimeStr { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

            }

            [NameInMap("ReviewTypeIdList")]
            [Validation(Required=false)]
            public GetResultToReviewResponseBodyDataReviewTypeIdList ReviewTypeIdList { get; set; }
            public class GetResultToReviewResponseBodyDataReviewTypeIdList : TeaModel {
                [NameInMap("ReviewTypeIdList")]
                [Validation(Required=false)]
                public List<GetResultToReviewResponseBodyDataReviewTypeIdListReviewTypeIdList> ReviewTypeIdList { get; set; }
                public class GetResultToReviewResponseBodyDataReviewTypeIdListReviewTypeIdList : TeaModel {
                    [NameInMap("ReviewKeyIdList")]
                    [Validation(Required=false)]
                    public GetResultToReviewResponseBodyDataReviewTypeIdListReviewTypeIdListReviewKeyIdList ReviewKeyIdList { get; set; }
                    public class GetResultToReviewResponseBodyDataReviewTypeIdListReviewTypeIdListReviewKeyIdList : TeaModel {
                        [NameInMap("ReviewKeyIdList")]
                        [Validation(Required=false)]
                        public List<long?> ReviewKeyIdList { get; set; }

                    }

                    [NameInMap("ReviewTypeId")]
                    [Validation(Required=false)]
                    public long? ReviewTypeId { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("TotalScore")]
            [Validation(Required=false)]
            public int? TotalScore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6fa76916-3ce6-45d8-ac64-01b7f31***</para>
            /// </summary>
            [NameInMap("Vid")]
            [Validation(Required=false)]
            public string Vid { get; set; }

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
        /// <para>82C91484-B2D5-4D2A-A21F-A6D73F4***</para>
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
