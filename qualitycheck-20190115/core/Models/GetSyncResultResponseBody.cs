// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetSyncResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSyncResultResponseBodyData> Data { get; set; }
        public class GetSyncResultResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Reviewer")]
            [Validation(Required=false)]
            public string Reviewer { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ReviewStatus")]
            [Validation(Required=false)]
            public int? ReviewStatus { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("ReviewResult")]
            [Validation(Required=false)]
            public int? ReviewResult { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            [NameInMap("Agent")]
            [Validation(Required=false)]
            public GetSyncResultResponseBodyDataAgent Agent { get; set; }
            public class GetSyncResultResponseBodyDataAgent : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("SkillGroup")]
                [Validation(Required=false)]
                public string SkillGroup { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
            };

            [NameInMap("AsrResult")]
            [Validation(Required=false)]
            public List<GetSyncResultResponseBodyDataAsrResult> AsrResult { get; set; }
            public class GetSyncResultResponseBodyDataAsrResult : TeaModel {
                [NameInMap("Words")]
                [Validation(Required=false)]
                public string Words { get; set; }

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

            [NameInMap("HitResult")]
            [Validation(Required=false)]
            public List<GetSyncResultResponseBodyDataHitResult> HitResult { get; set; }
            public class GetSyncResultResponseBodyDataHitResult : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Hits")]
                [Validation(Required=false)]
                public List<GetSyncResultResponseBodyDataHitResultHits> Hits { get; set; }
                public class GetSyncResultResponseBodyDataHitResultHits : TeaModel {
                    [NameInMap("Phrase")]
                    [Validation(Required=false)]
                    public GetSyncResultResponseBodyDataHitResultHitsPhrase Phrase { get; set; }
                    public class GetSyncResultResponseBodyDataHitResultHitsPhrase : TeaModel {
                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }
                        [NameInMap("EmotionValue")]
                        [Validation(Required=false)]
                        public int? EmotionValue { get; set; }
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public int? End { get; set; }
                        [NameInMap("SpeechRate")]
                        [Validation(Required=false)]
                        public int? SpeechRate { get; set; }
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }
                        [NameInMap("SilenceDuration")]
                        [Validation(Required=false)]
                        public int? SilenceDuration { get; set; }
                    };

                    [NameInMap("KeyWords")]
                    [Validation(Required=false)]
                    public List<GetSyncResultResponseBodyDataHitResultHitsKeyWords> KeyWords { get; set; }
                    public class GetSyncResultResponseBodyDataHitResultHitsKeyWords : TeaModel {
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public int? From { get; set; }

                        [NameInMap("Val")]
                        [Validation(Required=false)]
                        public string Val { get; set; }

                        [NameInMap("Cid")]
                        [Validation(Required=false)]
                        public string Cid { get; set; }

                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public int? To { get; set; }

                    }

                    [NameInMap("Cid")]
                    [Validation(Required=false)]
                    public List<string> Cid { get; set; }

                }

                [NameInMap("ReviewResult")]
                [Validation(Required=false)]
                public int? ReviewResult { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Rid")]
                [Validation(Required=false)]
                public string Rid { get; set; }

            }

            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            [NameInMap("Recording")]
            [Validation(Required=false)]
            public GetSyncResultResponseBodyDataRecording Recording { get; set; }
            public class GetSyncResultResponseBodyDataRecording : TeaModel {
                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }
                [NameInMap("Business")]
                [Validation(Required=false)]
                public string Business { get; set; }
                [NameInMap("Remark3")]
                [Validation(Required=false)]
                public string Remark3 { get; set; }
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }
                [NameInMap("PrimaryId")]
                [Validation(Required=false)]
                public string PrimaryId { get; set; }
                [NameInMap("Remark1")]
                [Validation(Required=false)]
                public string Remark1 { get; set; }
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public int? CallType { get; set; }
                [NameInMap("Remark2")]
                [Validation(Required=false)]
                public string Remark2 { get; set; }
                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }
                [NameInMap("DataSetName")]
                [Validation(Required=false)]
                public string DataSetName { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("CallTime")]
                [Validation(Required=false)]
                public string CallTime { get; set; }
            };

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Resolver")]
            [Validation(Required=false)]
            public string Resolver { get; set; }

        }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

    }

}
