// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class GetCallDetailRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The call detail data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCallDetailRecordResponseBodyData Data { get; set; }
        public class GetCallDetailRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The access channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2957188c-6cb3-42b4-beca-906fc0e752e5</para>
            /// </summary>
            [NameInMap("AccessChannelId")]
            [Validation(Required=false)]
            public string AccessChannelId { get; set; }

            /// <summary>
            /// <para>The access channel type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("AccessChannelType")]
            [Validation(Required=false)]
            public string AccessChannelType { get; set; }

            /// <summary>
            /// <para>The callee number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13612617599</para>
            /// </summary>
            [NameInMap("Callee")]
            [Validation(Required=false)]
            public string Callee { get; set; }

            /// <summary>
            /// <para>The caller number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02867871030</para>
            /// </summary>
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

            /// <summary>
            /// <para>The case ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6fb3a6c4-c3e6-4722-8c71-e5fde4e2253e</para>
            /// </summary>
            [NameInMap("CaseId")]
            [Validation(Required=false)]
            public string CaseId { get; set; }

            /// <summary>
            /// <para>The disposition code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Answered</para>
            /// </summary>
            [NameInMap("DispositionCode")]
            [Validation(Required=false)]
            public string DispositionCode { get; set; }

            /// <summary>
            /// <para>The disposition reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("DispositionReason")]
            [Validation(Required=false)]
            public string DispositionReason { get; set; }

            /// <summary>
            /// <para>Indicates whether this is a draft version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DraftVersion")]
            [Validation(Required=false)]
            public bool? DraftVersion { get; set; }

            /// <summary>
            /// <para>The total duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The end time of the call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786960840667</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The list of labels.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataLabels> Labels { get; set; }
            public class GetCallDetailRecordResponseBodyDataLabels : TeaModel {
                /// <summary>
                /// <para>The set of preset values for the label.</para>
                /// </summary>
                [NameInMap("CandidateValues")]
                [Validation(Required=false)]
                public List<string> CandidateValues { get; set; }

                /// <summary>
                /// <para>Indicates whether the label has been collected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Collected")]
                [Validation(Required=false)]
                public bool? Collected { get; set; }

                /// <summary>
                /// <para>The label description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>batch_install_docker</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The matched value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("MatchedValue")]
                [Validation(Required=false)]
                public string MatchedValue { get; set; }

                /// <summary>
                /// <para>The label name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MemberCollection_20251215_161122_Copy</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the label is a system label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("System")]
                [Validation(Required=false)]
                public bool? System { get; set; }

            }

            /// <summary>
            /// <para>The party that initiated the hang-up.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Customer</para>
            /// </summary>
            [NameInMap("ReleaseInitiator")]
            [Validation(Required=false)]
            public string ReleaseInitiator { get; set; }

            /// <summary>
            /// <para>The call session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-0b84bf6f-73dc-4462-bd8f-916e3a34c419</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The start time of the call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786960840667</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The talk time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TalkTime")]
            [Validation(Required=false)]
            public long? TalkTime { get; set; }

            /// <summary>
            /// <para>The number of conversation turns.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TalkTurns")]
            [Validation(Required=false)]
            public long? TalkTurns { get; set; }

            /// <summary>
            /// <para>Indicates whether the task was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TaskCompleted")]
            [Validation(Required=false)]
            public bool? TaskCompleted { get; set; }

            /// <summary>
            /// <para>The conversation transcripts.</para>
            /// </summary>
            [NameInMap("Transcripts")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataTranscripts> Transcripts { get; set; }
            public class GetCallDetailRecordResponseBodyDataTranscripts : TeaModel {
                /// <summary>
                /// <para>The assistant answer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sorry, I cannot find your phone bill</para>
                /// </summary>
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <para>Indicates whether the transcript is a backchannel response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Backchannels")]
                [Validation(Required=false)]
                public bool? Backchannels { get; set; }

                /// <summary>
                /// <para>The begin time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1760667651655</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// <para>The list of control parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;transferCode&quot;:&quot;Transfer02&quot;,&quot;type&quot;:&quot;Transfer&quot;}]</para>
                /// </summary>
                [NameInMap("ControlParamsList")]
                [Validation(Required=false)]
                public string ControlParamsList { get; set; }

                /// <summary>
                /// <para>The end time of the call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1760667651655</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The event time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1786960840667</para>
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public long? EventTime { get; set; }

                /// <summary>
                /// <para>The extended information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Extras")]
                [Validation(Required=false)]
                public string Extras { get; set; }

                /// <summary>
                /// <para>The number of input tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public int? InputTokens { get; set; }

                /// <summary>
                /// <para>Indicates whether the response was interrupted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Interrupted")]
                [Validation(Required=false)]
                public bool? Interrupted { get; set; }

                /// <summary>
                /// <para>Indicates whether the transcript is from the legacy version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Legacy")]
                [Validation(Required=false)]
                public bool? Legacy { get; set; }

                /// <summary>
                /// <para>The model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>model1</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The number of output tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public int? OutputTokens { get; set; }

                /// <summary>
                /// <para>The played text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sorry, check</para>
                /// </summary>
                [NameInMap("PlayedWords")]
                [Validation(Required=false)]
                public string PlayedWords { get; set; }

                /// <summary>
                /// <para>The role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The call session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-0b84bf6f-73dc-4462-bd8f-916e3a34c419</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The stream ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StreamId")]
                [Validation(Required=false)]
                public string StreamId { get; set; }

                /// <summary>
                /// <para>The total number of tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public int? TotalTokens { get; set; }

                /// <summary>
                /// <para>The user utterance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Can you check my phone bill?</para>
                /// </summary>
                [NameInMap("Utterance")]
                [Validation(Required=false)]
                public string Utterance { get; set; }

                /// <summary>
                /// <para>The vendor parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("VendorParams")]
                [Validation(Required=false)]
                public string VendorParams { get; set; }

            }

            /// <summary>
            /// <para>The transfer target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SkillGroup1</para>
            /// </summary>
            [NameInMap("TransferTarget")]
            [Validation(Required=false)]
            public string TransferTarget { get; set; }

            /// <summary>
            /// <para>The transfer type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SkillGroup</para>
            /// </summary>
            [NameInMap("TransferType")]
            [Validation(Required=false)]
            public string TransferType { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pass-through parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
