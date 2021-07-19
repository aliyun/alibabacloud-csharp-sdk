// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetReviewInfoResponseBody : TeaModel {
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
        public GetReviewInfoResponseBodyData Data { get; set; }
        public class GetReviewInfoResponseBodyData : TeaModel {
            [NameInMap("AudioURL")]
            [Validation(Required=false)]
            public string AudioURL { get; set; }
            [NameInMap("HitNumber")]
            [Validation(Required=false)]
            public int? HitNumber { get; set; }
            [NameInMap("NextVid")]
            [Validation(Required=false)]
            public string NextVid { get; set; }
            [NameInMap("PreVid")]
            [Validation(Required=false)]
            public string PreVid { get; set; }
            [NameInMap("IsAudio")]
            [Validation(Required=false)]
            public bool? IsAudio { get; set; }
            [NameInMap("AsrWordsCount")]
            [Validation(Required=false)]
            public int? AsrWordsCount { get; set; }
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public bool? Audio { get; set; }
            [NameInMap("TotalScore")]
            [Validation(Required=false)]
            public int? TotalScore { get; set; }
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public int? BusinessType { get; set; }
            [NameInMap("FileMergeName")]
            [Validation(Required=false)]
            public string FileMergeName { get; set; }
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }
            [NameInMap("Vid")]
            [Validation(Required=false)]
            public string Vid { get; set; }
            [NameInMap("ReviewNumber")]
            [Validation(Required=false)]
            public int? ReviewNumber { get; set; }
            [NameInMap("Dialogues")]
            [Validation(Required=false)]
            public GetReviewInfoResponseBodyDataDialogues Dialogues { get; set; }
            public class GetReviewInfoResponseBodyDataDialogues : TeaModel {
                [NameInMap("Dialogue")]
                [Validation(Required=false)]
                public List<GetReviewInfoResponseBodyDataDialoguesDialogue> Dialogue { get; set; }
                public class GetReviewInfoResponseBodyDataDialoguesDialogue : TeaModel {
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
            [NameInMap("HandScoreInfoList")]
            [Validation(Required=false)]
            public GetReviewInfoResponseBodyDataHandScoreInfoList HandScoreInfoList { get; set; }
            public class GetReviewInfoResponseBodyDataHandScoreInfoList : TeaModel {
                [NameInMap("ScorePo")]
                [Validation(Required=false)]
                public List<GetReviewInfoResponseBodyDataHandScoreInfoListScorePo> ScorePo { get; set; }
                public class GetReviewInfoResponseBodyDataHandScoreInfoListScorePo : TeaModel {
                    [NameInMap("ScoreId")]
                    [Validation(Required=false)]
                    public long? ScoreId { get; set; }

                    [NameInMap("ScoreName")]
                    [Validation(Required=false)]
                    public string ScoreName { get; set; }

                    [NameInMap("ScoreInfos")]
                    [Validation(Required=false)]
                    public GetReviewInfoResponseBodyDataHandScoreInfoListScorePoScoreInfos ScoreInfos { get; set; }
                    public class GetReviewInfoResponseBodyDataHandScoreInfoListScorePoScoreInfos : TeaModel {
                        [NameInMap("ScoreParam")]
                        [Validation(Required=false)]
                        public List<GetReviewInfoResponseBodyDataHandScoreInfoListScorePoScoreInfosScoreParam> ScoreParam { get; set; }
                        public class GetReviewInfoResponseBodyDataHandScoreInfoListScorePoScoreInfosScoreParam : TeaModel {
                            public string ScoreSubName { get; set; }
                            public int? ScoreNum { get; set; }
                            public int? Hit { get; set; }
                            public long? ScoreSubId { get; set; }
                            public int? ScoreType { get; set; }
                        }
                    };

                }

            }
            [NameInMap("HitRuleReviewInfoList")]
            [Validation(Required=false)]
            public GetReviewInfoResponseBodyDataHitRuleReviewInfoList HitRuleReviewInfoList { get; set; }
            public class GetReviewInfoResponseBodyDataHitRuleReviewInfoList : TeaModel {
                [NameInMap("HitRuleReviewInfo")]
                [Validation(Required=false)]
                public List<GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfo> HitRuleReviewInfo { get; set; }
                public class GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfo : TeaModel {
                    [NameInMap("RuleScoreType")]
                    [Validation(Required=false)]
                    public int? RuleScoreType { get; set; }

                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public int? RuleType { get; set; }

                    [NameInMap("AutoReview")]
                    [Validation(Required=false)]
                    public int? AutoReview { get; set; }

                    [NameInMap("ScoreSubId")]
                    [Validation(Required=false)]
                    public long? ScoreSubId { get; set; }

                    [NameInMap("TotalNumber")]
                    [Validation(Required=false)]
                    public int? TotalNumber { get; set; }

                    [NameInMap("ScoreId")]
                    [Validation(Required=false)]
                    public long? ScoreId { get; set; }

                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public long? Rid { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("ConditionHitInfoList")]
                    [Validation(Required=false)]
                    public GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoList ConditionHitInfoList { get; set; }
                    public class GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoList : TeaModel {
                        [NameInMap("ConditionHitInfo")]
                        [Validation(Required=false)]
                        public List<GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfo> ConditionHitInfo { get; set; }
                        public class GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfo : TeaModel {
                            public GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWords KeyWords { get; set; }
                            public class GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWords : TeaModel {
                                [NameInMap("KeyWord")]
                                [Validation(Required=false)]
                                public List<GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWordsKeyWord> KeyWord { get; set; }
                                public class GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWordsKeyWord : TeaModel {
                                    [NameInMap("To")]
                                    [Validation(Required=false)]
                                    public int? To { get; set; }

                                    [NameInMap("From")]
                                    [Validation(Required=false)]
                                    public int? From { get; set; }

                                    [NameInMap("Val")]
                                    [Validation(Required=false)]
                                    public string Val { get; set; }

                                    [NameInMap("Tid")]
                                    [Validation(Required=false)]
                                    public string Tid { get; set; }

                                    [NameInMap("Pid")]
                                    [Validation(Required=false)]
                                    public int? Pid { get; set; }

                                }

                            }
                            public GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoCid Cid { get; set; }
                            public class GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoCid : TeaModel {
                                [NameInMap("Cid")]
                                [Validation(Required=false)]
                                public List<string> Cid { get; set; }

                            }
                            public GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoPhrase Phrase { get; set; }
                            public class GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoPhrase : TeaModel {
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

                    [NameInMap("ReviewInfo")]
                    [Validation(Required=false)]
                    public GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoReviewInfo ReviewInfo { get; set; }
                    public class GetReviewInfoResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoReviewInfo : TeaModel {
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }
                        [NameInMap("HitId")]
                        [Validation(Required=false)]
                        public string HitId { get; set; }
                    };

                }

            }
            [NameInMap("ManualScoreMappingList")]
            [Validation(Required=false)]
            public GetReviewInfoResponseBodyDataManualScoreMappingList ManualScoreMappingList { get; set; }
            public class GetReviewInfoResponseBodyDataManualScoreMappingList : TeaModel {
                [NameInMap("ManualScoreMappingList")]
                [Validation(Required=false)]
                public List<string> ManualScoreMappingList { get; set; }

            }
        };

    }

}
