// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UploadDataSyncForLLMResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadDataSyncForLLMResponseBodyData Data { get; set; }
        public class UploadDataSyncForLLMResponseBodyData : TeaModel {
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public List<UploadDataSyncForLLMResponseBodyDataResultInfo> ResultInfo { get; set; }
            public class UploadDataSyncForLLMResponseBodyDataResultInfo : TeaModel {
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public UploadDataSyncForLLMResponseBodyDataResultInfoRules Rules { get; set; }
                public class UploadDataSyncForLLMResponseBodyDataResultInfoRules : TeaModel {
                    [NameInMap("RuleHitInfo")]
                    [Validation(Required=false)]
                    public List<UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfo> RuleHitInfo { get; set; }
                    public class UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfo : TeaModel {
                        [NameInMap("ConditionInfo")]
                        [Validation(Required=false)]
                        public UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoConditionInfo ConditionInfo { get; set; }
                        public class UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoConditionInfo : TeaModel {
                            [NameInMap("ConditionBasicInfo")]
                            [Validation(Required=false)]
                            public List<UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoConditionInfoConditionBasicInfo> ConditionBasicInfo { get; set; }
                            public class UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoConditionInfoConditionBasicInfo : TeaModel {
                                [NameInMap("ConditionInfoCid")]
                                [Validation(Required=false)]
                                public string ConditionInfoCid { get; set; }

                            }

                        }

                        [NameInMap("Hit")]
                        [Validation(Required=false)]
                        public UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHit Hit { get; set; }
                        public class UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHit : TeaModel {
                            [NameInMap("ConditionHitInfo")]
                            [Validation(Required=false)]
                            public List<UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfo> ConditionHitInfo { get; set; }
                            public class UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfo : TeaModel {
                                [NameInMap("HitCids")]
                                [Validation(Required=false)]
                                public UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitCids HitCids { get; set; }
                                public class UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitCids : TeaModel {
                                    [NameInMap("CidItem")]
                                    [Validation(Required=false)]
                                    public List<string> CidItem { get; set; }

                                }

                                [NameInMap("HitKeyWords")]
                                [Validation(Required=false)]
                                public UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitKeyWords HitKeyWords { get; set; }
                                public class UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitKeyWords : TeaModel {
                                    [NameInMap("HitKeyWord")]
                                    [Validation(Required=false)]
                                    public List<UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitKeyWordsHitKeyWord> HitKeyWord { get; set; }
                                    public class UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitKeyWordsHitKeyWord : TeaModel {
                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public int? From { get; set; }

                                        [NameInMap("Pid")]
                                        [Validation(Required=false)]
                                        public int? Pid { get; set; }

                                        [NameInMap("Tid")]
                                        [Validation(Required=false)]
                                        public string Tid { get; set; }

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
                                public UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoPhrase Phrase { get; set; }
                                public class UploadDataSyncForLLMResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoPhrase : TeaModel {
                                    [NameInMap("Begin")]
                                    [Validation(Required=false)]
                                    public long? Begin { get; set; }

                                    [NameInMap("BeginTime")]
                                    [Validation(Required=false)]
                                    public string BeginTime { get; set; }

                                    [NameInMap("End")]
                                    [Validation(Required=false)]
                                    public long? End { get; set; }

                                    [NameInMap("Identity")]
                                    [Validation(Required=false)]
                                    public string Identity { get; set; }

                                    [NameInMap("Role")]
                                    [Validation(Required=false)]
                                    public string Role { get; set; }

                                    [NameInMap("Words")]
                                    [Validation(Required=false)]
                                    public string Words { get; set; }

                                }

                            }

                        }

                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public string Rid { get; set; }

                        [NameInMap("Tid")]
                        [Validation(Required=false)]
                        public string Tid { get; set; }

                    }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("TyxmPlusCount")]
                [Validation(Required=false)]
                public string TyxmPlusCount { get; set; }

                [NameInMap("TyxmTurboCount")]
                [Validation(Required=false)]
                public string TyxmTurboCount { get; set; }

            }

        }

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
