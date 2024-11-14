// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetSyncResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSyncResultResponseBodyData> Data { get; set; }
        public class GetSyncResultResponseBodyData : TeaModel {
            [NameInMap("Agent")]
            [Validation(Required=false)]
            public GetSyncResultResponseBodyDataAgent Agent { get; set; }
            public class GetSyncResultResponseBodyDataAgent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12221</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SkillGroup")]
                [Validation(Required=false)]
                public string SkillGroup { get; set; }

            }

            [NameInMap("AsrResult")]
            [Validation(Required=false)]
            public List<GetSyncResultResponseBodyDataAsrResult> AsrResult { get; set; }
            public class GetSyncResultResponseBodyDataAsrResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>340</para>
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
                /// <para>3000</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("SilenceDuration")]
                [Validation(Required=false)]
                public int? SilenceDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>221</para>
                /// </summary>
                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public int? SpeechRate { get; set; }

                [NameInMap("Words")]
                [Validation(Required=false)]
                public string Words { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-07-24T19:31Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("HitResult")]
            [Validation(Required=false)]
            public List<GetSyncResultResponseBodyDataHitResult> HitResult { get; set; }
            public class GetSyncResultResponseBodyDataHitResult : TeaModel {
                [NameInMap("Hits")]
                [Validation(Required=false)]
                public List<GetSyncResultResponseBodyDataHitResultHits> Hits { get; set; }
                public class GetSyncResultResponseBodyDataHitResultHits : TeaModel {
                    [NameInMap("Cid")]
                    [Validation(Required=false)]
                    public List<string> Cid { get; set; }

                    [NameInMap("KeyWords")]
                    [Validation(Required=false)]
                    public List<GetSyncResultResponseBodyDataHitResultHitsKeyWords> KeyWords { get; set; }
                    public class GetSyncResultResponseBodyDataHitResultHitsKeyWords : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>66666</para>
                        /// </summary>
                        [NameInMap("Cid")]
                        [Validation(Required=false)]
                        public string Cid { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public int? From { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
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
                    public GetSyncResultResponseBodyDataHitResultHitsPhrase Phrase { get; set; }
                    public class GetSyncResultResponseBodyDataHitResultHitsPhrase : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>440</para>
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
                        /// <para>4000</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public int? End { get; set; }

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
                        /// <para>234</para>
                        /// </summary>
                        [NameInMap("SpeechRate")]
                        [Validation(Required=false)]
                        public int? SpeechRate { get; set; }

                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                    }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReviewResult")]
                [Validation(Required=false)]
                public int? ReviewResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1211</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public string Rid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Recording")]
            [Validation(Required=false)]
            public GetSyncResultResponseBodyDataRecording Recording { get; set; }
            public class GetSyncResultResponseBodyDataRecording : TeaModel {
                [NameInMap("Business")]
                [Validation(Required=false)]
                public string Business { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1563967699000</para>
                /// </summary>
                [NameInMap("CallTime")]
                [Validation(Required=false)]
                public string CallTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public int? CallType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1888888***</para>
                /// </summary>
                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0108888****</para>
                /// </summary>
                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("DataSetName")]
                [Validation(Required=false)]
                public string DataSetName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>232</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("DurationAudio")]
                [Validation(Required=false)]
                public long? DurationAudio { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123123.wav</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("PrimaryId")]
                [Validation(Required=false)]
                public string PrimaryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Remark1")]
                [Validation(Required=false)]
                public string Remark1 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Remark2")]
                [Validation(Required=false)]
                public string Remark2 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Remark3")]
                [Validation(Required=false)]
                public string Remark3 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://aliyun.com/xxx.wav">http://aliyun.com/xxx.wav</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Resolver")]
            [Validation(Required=false)]
            public string Resolver { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ReviewResult")]
            [Validation(Required=false)]
            public int? ReviewResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReviewStatus")]
            [Validation(Required=false)]
            public int? ReviewStatus { get; set; }

            [NameInMap("Reviewer")]
            [Validation(Required=false)]
            public string Reviewer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20201231de3d34ec-40fa-4a55-8d27-76ea*****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>76DB5D8C-5BD9-42A7-B527-5AF3A5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
