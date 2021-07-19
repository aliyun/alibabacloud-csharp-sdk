// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetResultToReviewResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResultToReviewResponseBodyData Data { get; set; }
        public class GetResultToReviewResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("AudioScheme")]
            [Validation(Required=false)]
            public string AudioScheme { get; set; }
            [NameInMap("AudioURL")]
            [Validation(Required=false)]
            public string AudioURL { get; set; }
            [NameInMap("TotalScore")]
            [Validation(Required=false)]
            public int? TotalScore { get; set; }
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }
            [NameInMap("FileMergeName")]
            [Validation(Required=false)]
            public string FileMergeName { get; set; }
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }
            [NameInMap("Vid")]
            [Validation(Required=false)]
            public string Vid { get; set; }
            [NameInMap("Dialogues")]
            [Validation(Required=false)]
            public GetResultToReviewResponseBodyDataDialogues Dialogues { get; set; }
            public class GetResultToReviewResponseBodyDataDialogues : TeaModel {
                [NameInMap("Dialogue")]
                [Validation(Required=false)]
                public List<GetResultToReviewResponseBodyDataDialoguesDialogue> Dialogue { get; set; }
                public class GetResultToReviewResponseBodyDataDialoguesDialogue : TeaModel {
                    [NameInMap("Words")]
                    [Validation(Required=false)]
                    public string Words { get; set; }

                    [NameInMap("Identity")]
                    [Validation(Required=false)]
                    public string Identity { get; set; }

                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public long? Begin { get; set; }

                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    [NameInMap("EmotionValue")]
                    [Validation(Required=false)]
                    public int? EmotionValue { get; set; }

                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public long? End { get; set; }

                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    [NameInMap("SilenceDuration")]
                    [Validation(Required=false)]
                    public int? SilenceDuration { get; set; }

                    [NameInMap("HourMinSec")]
                    [Validation(Required=false)]
                    public string HourMinSec { get; set; }

                }

            }
            [NameInMap("HitRuleReviewInfoList")]
            [Validation(Required=false)]
            public GetResultToReviewResponseBodyDataHitRuleReviewInfoList HitRuleReviewInfoList { get; set; }
            public class GetResultToReviewResponseBodyDataHitRuleReviewInfoList : TeaModel {
                [NameInMap("HitRuleReviewInfo")]
                [Validation(Required=false)]
                public List<GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfo> HitRuleReviewInfo { get; set; }
                public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfo : TeaModel {
                    [NameInMap("ScoreSubName")]
                    [Validation(Required=false)]
                    public string ScoreSubName { get; set; }

                    [NameInMap("ScoreNum")]
                    [Validation(Required=false)]
                    public int? ScoreNum { get; set; }

                    [NameInMap("AutoReview")]
                    [Validation(Required=false)]
                    public int? AutoReview { get; set; }

                    [NameInMap("ScoreSubId")]
                    [Validation(Required=false)]
                    public long? ScoreSubId { get; set; }

                    [NameInMap("Complainable")]
                    [Validation(Required=false)]
                    public bool? Complainable { get; set; }

                    [NameInMap("ScoreId")]
                    [Validation(Required=false)]
                    public long? ScoreId { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public long? Rid { get; set; }

                    [NameInMap("ConditionHitInfoList")]
                    [Validation(Required=false)]
                    public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoList ConditionHitInfoList { get; set; }
                    public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoList : TeaModel {
                        [NameInMap("ConditionHitInfo")]
                        [Validation(Required=false)]
                        public List<GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfo> ConditionHitInfo { get; set; }
                        public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfo : TeaModel {
                            public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWords KeyWords { get; set; }
                            public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWords : TeaModel {
                                [NameInMap("KeyWord")]
                                [Validation(Required=false)]
                                public List<GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWordsKeyWord> KeyWord { get; set; }
                                public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWordsKeyWord : TeaModel {
                                    [NameInMap("From")]
                                    [Validation(Required=false)]
                                    public int? From { get; set; }

                                    [NameInMap("Val")]
                                    [Validation(Required=false)]
                                    public string Val { get; set; }

                                    [NameInMap("Pid")]
                                    [Validation(Required=false)]
                                    public int? Pid { get; set; }

                                    [NameInMap("Tid")]
                                    [Validation(Required=false)]
                                    public string Tid { get; set; }

                                    [NameInMap("Cid")]
                                    [Validation(Required=false)]
                                    public string Cid { get; set; }

                                    [NameInMap("To")]
                                    [Validation(Required=false)]
                                    public int? To { get; set; }

                                }

                            }
                            public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoCid Cid { get; set; }
                            public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoCid : TeaModel {
                                [NameInMap("Cid")]
                                [Validation(Required=false)]
                                public List<string> Cid { get; set; }

                            }
                            public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoPhrase Phrase { get; set; }
                            public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoPhrase : TeaModel {
                                [NameInMap("Words")]
                                [Validation(Required=false)]
                                public string Words { get; set; }

                                [NameInMap("Begin")]
                                [Validation(Required=false)]
                                public long? Begin { get; set; }

                                [NameInMap("Identity")]
                                [Validation(Required=false)]
                                public string Identity { get; set; }

                                [NameInMap("Pid")]
                                [Validation(Required=false)]
                                public int? Pid { get; set; }

                                [NameInMap("EmotionValue")]
                                [Validation(Required=false)]
                                public int? EmotionValue { get; set; }

                                [NameInMap("End")]
                                [Validation(Required=false)]
                                public long? End { get; set; }

                                [NameInMap("Role")]
                                [Validation(Required=false)]
                                public string Role { get; set; }

                            }
                        }
                    };

                    [NameInMap("ComplainHistories")]
                    [Validation(Required=false)]
                    public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoComplainHistories ComplainHistories { get; set; }
                    public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoComplainHistories : TeaModel {
                        [NameInMap("ComplainHistories")]
                        [Validation(Required=false)]
                        public List<GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoComplainHistoriesComplainHistories> ComplainHistories { get; set; }
                        public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoComplainHistoriesComplainHistories : TeaModel {
                            public string Comments { get; set; }
                            public long? Operator { get; set; }
                            public string OperationTime { get; set; }
                            public int? OperationType { get; set; }
                            public string OperatorName { get; set; }
                        }
                    };

                    [NameInMap("ReviewInfo")]
                    [Validation(Required=false)]
                    public GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoReviewInfo ReviewInfo { get; set; }
                    public class GetResultToReviewResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoReviewInfo : TeaModel {
                        [NameInMap("ReviewResult")]
                        [Validation(Required=false)]
                        public int? ReviewResult { get; set; }
                        [NameInMap("ReviewTime")]
                        [Validation(Required=false)]
                        public string ReviewTime { get; set; }
                        [NameInMap("HitId")]
                        [Validation(Required=false)]
                        public string HitId { get; set; }
                        [NameInMap("Reviewer")]
                        [Validation(Required=false)]
                        public string Reviewer { get; set; }
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }
                    };

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
                    [NameInMap("ScoreSubName")]
                    [Validation(Required=false)]
                    public string ScoreSubName { get; set; }

                    [NameInMap("Complainable")]
                    [Validation(Required=false)]
                    public bool? Complainable { get; set; }

                    [NameInMap("ScoreNum")]
                    [Validation(Required=false)]
                    public int? ScoreNum { get; set; }

                    [NameInMap("ScoreSubId")]
                    [Validation(Required=false)]
                    public long? ScoreSubId { get; set; }

                    [NameInMap("ScoreId")]
                    [Validation(Required=false)]
                    public long? ScoreId { get; set; }

                    [NameInMap("ComplainHistories")]
                    [Validation(Required=false)]
                    public GetResultToReviewResponseBodyDataManualScoreInfoListManualScoreInfoComplainHistories ComplainHistories { get; set; }
                    public class GetResultToReviewResponseBodyDataManualScoreInfoListManualScoreInfoComplainHistories : TeaModel {
                        [NameInMap("ComplainHistories")]
                        [Validation(Required=false)]
                        public List<GetResultToReviewResponseBodyDataManualScoreInfoListManualScoreInfoComplainHistoriesComplainHistories> ComplainHistories { get; set; }
                        public class GetResultToReviewResponseBodyDataManualScoreInfoListManualScoreInfoComplainHistoriesComplainHistories : TeaModel {
                            public string Comments { get; set; }
                            public long? Operator { get; set; }
                            public string OperationTime { get; set; }
                            public int? OperationType { get; set; }
                            public string OperatorName { get; set; }
                        }
                    };

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
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    [NameInMap("OperatorName")]
                    [Validation(Required=false)]
                    public string OperatorName { get; set; }

                    [NameInMap("TimeStr")]
                    [Validation(Required=false)]
                    public string TimeStr { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public int? Score { get; set; }

                    [NameInMap("ReviewResult")]
                    [Validation(Required=false)]
                    public int? ReviewResult { get; set; }

                    [NameInMap("ComplainResult")]
                    [Validation(Required=false)]
                    public int? ComplainResult { get; set; }

                    [NameInMap("OldScore")]
                    [Validation(Required=false)]
                    public int? OldScore { get; set; }

                }

            }
        };

    }

}
