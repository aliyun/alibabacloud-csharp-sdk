// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class SyncQualityCheckResponseBody : TeaModel {
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
        public SyncQualityCheckResponseBodyData Data { get; set; }
        public class SyncQualityCheckResponseBodyData : TeaModel {
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("Tid")]
            [Validation(Required=false)]
            public string Tid { get; set; }
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<SyncQualityCheckResponseBodyDataRules> Rules { get; set; }
            public class SyncQualityCheckResponseBodyDataRules : TeaModel {
                public string RuleName { get; set; }
                public string Rid { get; set; }
                public List<SyncQualityCheckResponseBodyDataRulesHit> Hit { get; set; }
                public class SyncQualityCheckResponseBodyDataRulesHit : TeaModel {
                    public List<SyncQualityCheckResponseBodyDataRulesHitHitKeyWords> HitKeyWords { get; set; }
                    public class SyncQualityCheckResponseBodyDataRulesHitHitKeyWords : TeaModel {
                        public int? To { get; set; }
                        public int? From { get; set; }
                        public string Val { get; set; }
                        public int? Cid { get; set; }
                        public int? Pid { get; set; }
                    }
                    public SyncQualityCheckResponseBodyDataRulesHitPhrase Phrase { get; set; }
                    public class SyncQualityCheckResponseBodyDataRulesHitPhrase : TeaModel {
                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                        [NameInMap("Identity")]
                        [Validation(Required=false)]
                        public string Identity { get; set; }

                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

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

                    }
                }
            }
        };

    }

}
