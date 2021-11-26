// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class TestRuleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TestRuleResponseBodyData Data { get; set; }
        public class TestRuleResponseBodyData : TeaModel {
            [NameInMap("HitRuleReviewInfoList")]
            [Validation(Required=false)]
            public TestRuleResponseBodyDataHitRuleReviewInfoList HitRuleReviewInfoList { get; set; }
            public class TestRuleResponseBodyDataHitRuleReviewInfoList : TeaModel {
                [NameInMap("HitRuleReviewInfo")]
                [Validation(Required=false)]
                public List<TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfo> HitRuleReviewInfo { get; set; }
                public class TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfo : TeaModel {
                    [NameInMap("ConditionHitInfoList")]
                    [Validation(Required=false)]
                    public TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoList ConditionHitInfoList { get; set; }
                    public class TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoList : TeaModel {
                        [NameInMap("ConditionHitInfo")]
                        [Validation(Required=false)]
                        public List<TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfo> ConditionHitInfo { get; set; }
                        public class TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfo : TeaModel {
                            public TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoCid Cid { get; set; }
                            public class TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoCid : TeaModel {
                                [NameInMap("cid")]
                                [Validation(Required=false)]
                                public List<string> Cid { get; set; }

                            }
                            public TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWords KeyWords { get; set; }
                            public class TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWords : TeaModel {
                                [NameInMap("KeyWord")]
                                [Validation(Required=false)]
                                public List<TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWordsKeyWord> KeyWord { get; set; }
                                public class TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoKeyWordsKeyWord : TeaModel {
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
                            public TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoPhrase Phrase { get; set; }
                            public class TestRuleResponseBodyDataHitRuleReviewInfoListHitRuleReviewInfoConditionHitInfoListConditionHitInfoPhrase : TeaModel {
                                [NameInMap("Begin")]
                                [Validation(Required=false)]
                                public long? Begin { get; set; }

                                [NameInMap("EmotionValue")]
                                [Validation(Required=false)]
                                public int? EmotionValue { get; set; }

                                [NameInMap("End")]
                                [Validation(Required=false)]
                                public long? End { get; set; }

                                [NameInMap("Identity")]
                                [Validation(Required=false)]
                                public string Identity { get; set; }

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
                    };

                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public long? Rid { get; set; }

                }

            }
            [NameInMap("Poc")]
            [Validation(Required=false)]
            public bool? Poc { get; set; }
        };

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
