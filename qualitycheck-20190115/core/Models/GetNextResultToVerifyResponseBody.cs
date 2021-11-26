// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetNextResultToVerifyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNextResultToVerifyResponseBodyData Data { get; set; }
        public class GetNextResultToVerifyResponseBodyData : TeaModel {
            [NameInMap("AudioScheme")]
            [Validation(Required=false)]
            public string AudioScheme { get; set; }
            [NameInMap("AudioURL")]
            [Validation(Required=false)]
            public string AudioURL { get; set; }
            [NameInMap("Dialogues")]
            [Validation(Required=false)]
            public GetNextResultToVerifyResponseBodyDataDialogues Dialogues { get; set; }
            public class GetNextResultToVerifyResponseBodyDataDialogues : TeaModel {
                [NameInMap("Dialogue")]
                [Validation(Required=false)]
                public List<GetNextResultToVerifyResponseBodyDataDialoguesDialogue> Dialogue { get; set; }
                public class GetNextResultToVerifyResponseBodyDataDialoguesDialogue : TeaModel {
                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public long? Begin { get; set; }

                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    [NameInMap("Deltas")]
                    [Validation(Required=false)]
                    public GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltas Deltas { get; set; }
                    public class GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltas : TeaModel {
                        [NameInMap("Delta")]
                        [Validation(Required=false)]
                        public List<GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDelta> Delta { get; set; }
                        public class GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDelta : TeaModel {
                            public GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaSource Source { get; set; }
                            public class GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaSource : TeaModel {
                                [NameInMap("Line")]
                                [Validation(Required=false)]
                                public GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaSourceLine Line { get; set; }
                                public class GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaSourceLine : TeaModel {
                                    [NameInMap("Line")]
                                    [Validation(Required=false)]
                                    public List<string> Line { get; set; }
                                };

                                [NameInMap("Position")]
                                [Validation(Required=false)]
                                public int? Position { get; set; }

                            }
                            public GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaTarget Target { get; set; }
                            public class GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaTarget : TeaModel {
                                [NameInMap("Line")]
                                [Validation(Required=false)]
                                public GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaTargetLine Line { get; set; }
                                public class GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaTargetLine : TeaModel {
                                    [NameInMap("Line")]
                                    [Validation(Required=false)]
                                    public List<string> Line { get; set; }
                                };

                                [NameInMap("Position")]
                                [Validation(Required=false)]
                                public int? Position { get; set; }

                            }
                            public string Type { get; set; }
                        }
                    };

                    [NameInMap("EmotionValue")]
                    [Validation(Required=false)]
                    public int? EmotionValue { get; set; }

                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public long? End { get; set; }

                    [NameInMap("HourMinSec")]
                    [Validation(Required=false)]
                    public string HourMinSec { get; set; }

                    [NameInMap("Identity")]
                    [Validation(Required=false)]
                    public string Identity { get; set; }

                    [NameInMap("IncorrectWords")]
                    [Validation(Required=false)]
                    public int? IncorrectWords { get; set; }

                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    [NameInMap("SilenceDuration")]
                    [Validation(Required=false)]
                    public int? SilenceDuration { get; set; }

                    [NameInMap("SourceRole")]
                    [Validation(Required=false)]
                    public string SourceRole { get; set; }

                    [NameInMap("SourceWords")]
                    [Validation(Required=false)]
                    public string SourceWords { get; set; }

                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    [NameInMap("Words")]
                    [Validation(Required=false)]
                    public string Words { get; set; }

                }

            }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }
            [NameInMap("IncorrectWords")]
            [Validation(Required=false)]
            public int? IncorrectWords { get; set; }
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }
            [NameInMap("Precision")]
            [Validation(Required=false)]
            public float? Precision { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
            [NameInMap("Verified")]
            [Validation(Required=false)]
            public bool? Verified { get; set; }
            [NameInMap("VerifiedCount")]
            [Validation(Required=false)]
            public int? VerifiedCount { get; set; }
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
