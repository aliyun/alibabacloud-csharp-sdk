// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetSyncResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code. A value of 200 indicates success. Any other value indicates failure. The caller can use this field to determine the cause of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSyncResultResponseBodyData> Data { get; set; }
        public class GetSyncResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Agent information</para>
            /// </summary>
            [NameInMap("Agent")]
            [Validation(Required=false)]
            public GetSyncResultResponseBodyDataAgent Agent { get; set; }
            public class GetSyncResultResponseBodyDataAgent : TeaModel {
                /// <summary>
                /// <para>Agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12221</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Agent name</para>
                /// 
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Skill group name</para>
                /// 
                /// <b>Example:</b>
                /// <para>客服组</para>
                /// </summary>
                [NameInMap("SkillGroup")]
                [Validation(Required=false)]
                public string SkillGroup { get; set; }

            }

            /// <summary>
            /// <para>Transcription result (dialogue text)</para>
            /// </summary>
            [NameInMap("AsrResult")]
            [Validation(Required=false)]
            public List<GetSyncResultResponseBodyDataAsrResult> AsrResult { get; set; }
            public class GetSyncResultResponseBodyDataAsrResult : TeaModel {
                /// <summary>
                /// <para>The start time of this sentence, which is the offset from the starting point in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>340</para>
                /// </summary>
                [NameInMap("Begin")]
                [Validation(Required=false)]
                public long? Begin { get; set; }

                /// <summary>
                /// <para>Emotion intensity value ranging from 1 to 10. A higher value indicates stronger emotion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("EmotionValue")]
                [Validation(Required=false)]
                public int? EmotionValue { get; set; }

                /// <summary>
                /// <para>The end time of this sentence, which is the offset from the starting point in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// <para>Role in the dialogue content. Possible values: agent, Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>客服</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>Internal field. Ignore it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("SilenceDuration")]
                [Validation(Required=false)]
                public int? SilenceDuration { get; set; }

                /// <summary>
                /// <para>The average speech rate of this sentence, in characters per minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>221</para>
                /// </summary>
                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public int? SpeechRate { get; set; }

                /// <summary>
                /// <para>Dialogue content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>您好，很高兴为您服务</para>
                /// </summary>
                [NameInMap("Words")]
                [Validation(Required=false)]
                public string Words { get; set; }

            }

            /// <summary>
            /// <para>Review comments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>Job Creation Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-07-24T19:31Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>When status is neither 0 nor 1, this field indicates the Error Details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Rule hit result.</para>
            /// </summary>
            [NameInMap("HitResult")]
            [Validation(Required=false)]
            public List<GetSyncResultResponseBodyDataHitResult> HitResult { get; set; }
            public class GetSyncResultResponseBodyDataHitResult : TeaModel {
                /// <summary>
                /// <para>Specific hit location information. At the sentence dimension, returns which condition in the rule was hit and which specific characters triggered the hit within the sentence.</para>
                /// </summary>
                [NameInMap("Hits")]
                [Validation(Required=false)]
                public List<GetSyncResultResponseBodyDataHitResultHits> Hits { get; set; }
                public class GetSyncResultResponseBodyDataHitResultHits : TeaModel {
                    /// <summary>
                    /// <para>List of hit condition IDs.</para>
                    /// </summary>
                    [NameInMap("Cid")]
                    [Validation(Required=false)]
                    public List<string> Cid { get; set; }

                    /// <summary>
                    /// <para>Returns the specific characters in the current sentence that hit the rule, which are the keywords to be highlighted.</para>
                    /// </summary>
                    [NameInMap("KeyWords")]
                    [Validation(Required=false)]
                    public List<GetSyncResultResponseBodyDataHitResultHitsKeyWords> KeyWords { get; set; }
                    public class GetSyncResultResponseBodyDataHitResultHitsKeyWords : TeaModel {
                        /// <summary>
                        /// <para>The ID of the condition that was hit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>66666</para>
                        /// </summary>
                        [NameInMap("Cid")]
                        [Validation(Required=false)]
                        public string Cid { get; set; }

                        /// <summary>
                        /// <para>The starting character position (inclusive) of the keyword to be highlighted. The value starts from 0 and can be at most the total number of characters in the sentence minus 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public int? From { get; set; }

                        /// <summary>
                        /// <para>The ending character position (exclusive) of the keyword to be highlighted. The maximum value is the total number of characters in the sentence minus 1. For example, in the sentence “不可能给你退货的”, if from=0 and to=3, the highlighted keyword is “不可能”, which consists of three characters.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public int? To { get; set; }

                        /// <summary>
                        /// <para>The exact keyword content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>投诉</para>
                        /// </summary>
                        [NameInMap("Val")]
                        [Validation(Required=false)]
                        public string Val { get; set; }

                    }

                    /// <summary>
                    /// <para>Details of the sentence that hit the current rule.</para>
                    /// </summary>
                    [NameInMap("Phrase")]
                    [Validation(Required=false)]
                    public GetSyncResultResponseBodyDataHitResultHitsPhrase Phrase { get; set; }
                    public class GetSyncResultResponseBodyDataHitResultHitsPhrase : TeaModel {
                        /// <summary>
                        /// <para>The Start Time of this sentence, represented as an offset in milliseconds from the starting point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>440</para>
                        /// </summary>
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        /// <summary>
                        /// <para>Emotion intensity value ranging from 1 to 10. A higher value indicates stronger emotion.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>6</para>
                        /// </summary>
                        [NameInMap("EmotionValue")]
                        [Validation(Required=false)]
                        public int? EmotionValue { get; set; }

                        /// <summary>
                        /// <para>The End Time of this sentence, represented as an offset in milliseconds from the starting point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4000</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public int? End { get; set; }

                        /// <summary>
                        /// <para>The role in the conversation content. Possible values: agent, Customer, System.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>客服</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <para>Internal field. Ignore.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("SilenceDuration")]
                        [Validation(Required=false)]
                        public int? SilenceDuration { get; set; }

                        /// <summary>
                        /// <para>The speech rate of this sentence.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>234</para>
                        /// </summary>
                        [NameInMap("SpeechRate")]
                        [Validation(Required=false)]
                        public int? SpeechRate { get; set; }

                        /// <summary>
                        /// <para>A sentence spoken by this role.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>我要投诉</para>
                        /// </summary>
                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                    }

                }

                /// <summary>
                /// <para>Hit rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试规则</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Review accuracy; possible values: 0 (fault); 1 (correct).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReviewResult")]
                [Validation(Required=false)]
                public int? ReviewResult { get; set; }

                /// <summary>
                /// <para>Hit rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1211</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public string Rid { get; set; }

                /// <summary>
                /// <para>Rule type associated with the hit rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Recording file information</para>
            /// </summary>
            [NameInMap("Recording")]
            [Validation(Required=false)]
            public GetSyncResultResponseBodyDataRecording Recording { get; set; }
            public class GetSyncResultResponseBodyDataRecording : TeaModel {
                /// <summary>
                /// <para>Line-of-business name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>客服部</para>
                /// </summary>
                [NameInMap("Business")]
                [Validation(Required=false)]
                public string Business { get; set; }

                /// <summary>
                /// <para>Call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>Recording generation UNIX timestamp, accurate to milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1563967699000</para>
                /// </summary>
                [NameInMap("CallTime")]
                [Validation(Required=false)]
                public string CallTime { get; set; }

                /// <summary>
                /// <para>Call type:  </para>
                /// <list type="bullet">
                /// <item><description>1: Outgoing call  </description></item>
                /// <item><description>3: Incoming call</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public int? CallType { get; set; }

                /// <summary>
                /// <para>Callee number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1888888***</para>
                /// </summary>
                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }

                /// <summary>
                /// <para>Caller number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0108888****</para>
                /// </summary>
                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                /// <summary>
                /// <para>Internal field. Ignore this.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("DataSetName")]
                [Validation(Required=false)]
                public string DataSetName { get; set; }

                /// <summary>
                /// <para>Total number of words in the conversation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>232</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>Call duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("DurationAudio")]
                [Validation(Required=false)]
                public long? DurationAudio { get; set; }

                /// <summary>
                /// <para>File ID, which is the callId in the request parameters. If not specified, a random ID will be generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Recording file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123.wav</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Internal field. Ignore it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("PrimaryId")]
                [Validation(Required=false)]
                public string PrimaryId { get; set; }

                /// <summary>
                /// <para>Custom data 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Remark1")]
                [Validation(Required=false)]
                public string Remark1 { get; set; }

                /// <summary>
                /// <para>Custom data 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Remark2")]
                [Validation(Required=false)]
                public string Remark2 { get; set; }

                /// <summary>
                /// <para>Custom data 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Remark3")]
                [Validation(Required=false)]
                public string Remark3 { get; set; }

                /// <summary>
                /// <para>Recording file URL, used for playback.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://aliyun.com/xxx.wav">http://aliyun.com/xxx.wav</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The quality inspector who actually reviewed the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("Resolver")]
            [Validation(Required=false)]
            public string Resolver { get; set; }

            /// <summary>
            /// <para>Review accuracy. Possible values: 0 (fault); 1 (correct); 2 (partially correct); 3 (pending review).</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ReviewResult")]
            [Validation(Required=false)]
            public int? ReviewResult { get; set; }

            /// <summary>
            /// <para>Review status; possible values: 0 (not reviewed); 1 (reviewed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReviewStatus")]
            [Validation(Required=false)]
            public int? ReviewStatus { get; set; }

            /// <summary>
            /// <para>Username of the assigned quality inspector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("Reviewer")]
            [Validation(Required=false)]
            public string Reviewer { get; set; }

            /// <summary>
            /// <para>Quality inspection score, with a maximum of 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>Current job status. Possible values: 0 (not completed); 1 (completed). The caller can use this field to determine whether the job is complete. Values other than 0 or 1 indicate an error; see the errorMessage field for Error Details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20201231de3d34ec-40fa-4a55-8d27-76ea*****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Internal field. Ignore it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>Error details when an error occurs; &quot;successful&quot; when the operation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>76DB5D8C-5BD9-42A7-B527-5AF3A5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Internal field. Ignore it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. The caller can use this field to determine the request status: true indicates success; false or null indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
