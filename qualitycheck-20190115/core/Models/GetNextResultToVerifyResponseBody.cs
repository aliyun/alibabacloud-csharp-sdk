// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetNextResultToVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Other values indicate failure. The caller can determine the cause of failure using this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>File details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNextResultToVerifyResponseBodyData Data { get; set; }
        public class GetNextResultToVerifyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The protocol of the audio URL. Possible values: http, https.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("AudioScheme")]
            [Validation(Required=false)]
            public string AudioScheme { get; set; }

            /// <summary>
            /// <para>The audio URL, excluding http/https.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sca-bucket.oss-cn-hangzhou.aliyuncs.com/upload_1173636551461420/dateset_1584674455133_SzC/%E4%BA%BA%E5%B7%A5%E6%A0%A1%E9%AA%8C%E6%B5%8B%E8%AF%95-%E6%9F%A5%E5%8C%97%E4%BA%AC%E5%A4%A9%E6%B0%94.wav?Expires=1584847372&amp;OSSAccessKeyId=<em><b><b>&amp;Signature=HccAKnLOJwoYvzE</b></b></em>****</para>
            /// </summary>
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
                            [NameInMap("Source")]
                            [Validation(Required=false)]
                            public GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaSource Source { get; set; }
                            public class GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaSource : TeaModel {
                                [NameInMap("Line")]
                                [Validation(Required=false)]
                                public GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaSourceLine Line { get; set; }
                                public class GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaSourceLine : TeaModel {
                                    [NameInMap("Line")]
                                    [Validation(Required=false)]
                                    public List<string> Line { get; set; }

                                }

                                [NameInMap("Position")]
                                [Validation(Required=false)]
                                public int? Position { get; set; }

                            }

                            [NameInMap("Target")]
                            [Validation(Required=false)]
                            public GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaTarget Target { get; set; }
                            public class GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaTarget : TeaModel {
                                [NameInMap("Line")]
                                [Validation(Required=false)]
                                public GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaTargetLine Line { get; set; }
                                public class GetNextResultToVerifyResponseBodyDataDialoguesDialogueDeltasDeltaTargetLine : TeaModel {
                                    [NameInMap("Line")]
                                    [Validation(Required=false)]
                                    public List<string> Line { get; set; }

                                }

                                [NameInMap("Position")]
                                [Validation(Required=false)]
                                public int? Position { get; set; }

                            }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

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

            /// <summary>
            /// <para>The total duration of files in the current task, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23421</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>File ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e790e6c919d84b82b64ee*****</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>File name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx.wav</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The number of incorrect words in the transcription.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("IncorrectWords")]
            [Validation(Required=false)]
            public int? IncorrectWords { get; set; }

            /// <summary>
            /// <para>The index of the current file. Pass this value when manually verifying the next data entry. It starts from 1, so the first entry has a value of 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>Current recognition accuracy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.97079998</para>
            /// </summary>
            [NameInMap("Precision")]
            [Validation(Required=false)]
            public float? Precision { get; set; }

            /// <summary>
            /// <para>File status. Possible values: 0: Not completed; 1: Not completed; 2: Completed; 3: Completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The total number of files for this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>Last update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-03-20T11:26Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether manual verification has been performed. Possible values: \<c>false\\</c>: Not yet verified; \<c>true\\</c>: Already verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Verified")]
            [Validation(Required=false)]
            public bool? Verified { get; set; }

            /// <summary>
            /// <para>The total number of verified files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("VerifiedCount")]
            [Validation(Required=false)]
            public int? VerifiedCount { get; set; }

        }

        /// <summary>
        /// <para>Error details if an error occurs. If successful, the value is \&quot;successful\&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24F4CE647</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. The caller can determine if the request was successful using this field: \<c>true\\</c> indicates success; \<c>false\\</c>/\<c>null\\</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
