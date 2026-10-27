// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetCallDetailRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The call detail record.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCallDetailRecordResponseBodyData Data { get; set; }
        public class GetCallDetailRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The phone number of the callee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15100000001</para>
            /// </summary>
            [NameInMap("Callee")]
            [Validation(Required=false)]
            public string Callee { get; set; }

            /// <summary>
            /// <para>The phone number of the caller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15929990193</para>
            /// </summary>
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

            /// <summary>
            /// <para>The disposition code for the call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Answered</para>
            /// </summary>
            [NameInMap("DispositionCode")]
            [Validation(Required=false)]
            public string DispositionCode { get; set; }

            /// <summary>
            /// <para>The reason for the call\&quot;s disposition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ConcurrentLimitExceeded</para>
            /// </summary>
            [NameInMap("DispositionReason")]
            [Validation(Required=false)]
            public string DispositionReason { get; set; }

            /// <summary>
            /// <para>The session duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752283603978</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the user\&quot;s issue was resolved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IssueResolved")]
            [Validation(Required=false)]
            public bool? IssueResolved { get; set; }

            /// <summary>
            /// <para>The party that ended the call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Customer</para>
            /// </summary>
            [NameInMap("ReleaseInitiator")]
            [Validation(Required=false)]
            public string ReleaseInitiator { get; set; }

            /// <summary>
            /// <para>The basis for the resolution judgment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>unknown</para>
            /// </summary>
            [NameInMap("ResolutionEvidence")]
            [Validation(Required=false)]
            public string ResolutionEvidence { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>07d72ea0-6e38-48d4-8371-14deaaba996f</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774858849987</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The talk time, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TalkTime")]
            [Validation(Required=false)]
            public int? TalkTime { get; set; }

            /// <summary>
            /// <para>The number of conversation turns.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TalkTurns")]
            [Validation(Required=false)]
            public int? TalkTurns { get; set; }

            /// <summary>
            /// <para>The conversation transcripts.</para>
            /// </summary>
            [NameInMap("Transcripts")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataTranscripts> Transcripts { get; set; }
            public class GetCallDetailRecordResponseBodyDataTranscripts : TeaModel {
                /// <summary>
                /// <para>The bot\&quot;s response. This parameter is valid when <c>Role</c> is <c>ASSISTANT</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>不好意思，</para>
                /// </summary>
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <para>Indicates whether the user\&quot;s utterance is a backchannel (for example, &quot;uh-huh&quot; or &quot;okay&quot;). This parameter is valid when <c>Role</c> is <c>USER</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Backchannels")]
                [Validation(Required=false)]
                public bool? Backchannels { get; set; }

                /// <summary>
                /// <para>The start timestamp of the turn, in milliseconds since the Unix epoch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1748945414222</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// <para>A list of control parameters. This parameter is valid when <c>Role</c> is <c>ASSISTANT</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;endSilenceTimeout&quot;:500,&quot;interruptible&quot;:false,&quot;silenceDetectionTimeout&quot;:5,&quot;type&quot;:&quot;Voice&quot;}]</para>
                /// </summary>
                [NameInMap("ControlParamsList")]
                [Validation(Required=false)]
                public string ControlParamsList { get; set; }

                /// <summary>
                /// <para>The end timestamp of the turn, in milliseconds since the Unix epoch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1767315903531</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The event timestamp, in milliseconds since the Unix epoch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774859592165</para>
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public string EventTime { get; set; }

                /// <summary>
                /// <para>Additional input from the user other than speech. This parameter is valid when <c>Role</c> is <c>USER</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;dataType&quot;:&quot;Silence&quot;}]</para>
                /// </summary>
                [NameInMap("Extras")]
                [Validation(Required=false)]
                public string Extras { get; set; }

                /// <summary>
                /// <para>Indicates whether the turn was interrupted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Interrupted")]
                [Validation(Required=false)]
                public bool? Interrupted { get; set; }

                /// <summary>
                /// <para>Indicates whether the bot\&quot;s response is obsolete. This parameter is valid when <c>Role</c> is <c>ASSISTANT</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Legacy")]
                [Validation(Required=false)]
                public bool? Legacy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INTERRUPTED</para>
                /// </summary>
                [NameInMap("PlaybackStatus")]
                [Validation(Required=false)]
                public string PlaybackStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>好的</para>
                /// </summary>
                [NameInMap("PlayedAnswer")]
                [Validation(Required=false)]
                public string PlayedAnswer { get; set; }

                /// <summary>
                /// <para>The number of words played from the bot\&quot;s response. This parameter is valid when <c>Role</c> is <c>USER</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PlayedWords")]
                [Validation(Required=false)]
                public int? PlayedWords { get; set; }

                /// <summary>
                /// <para>The role of the speaker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>Indicates if this is the final part of a streamed response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("StreamEnd")]
                [Validation(Required=false)]
                public bool? StreamEnd { get; set; }

                /// <summary>
                /// <para>The ID of the conversation turn.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StreamId")]
                [Validation(Required=false)]
                public string StreamId { get; set; }

                /// <summary>
                /// <para>The user\&quot;s utterance. This parameter is valid when <c>Role</c> is <c>USER</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你要说你快点说不说，我挂了哈。</para>
                /// </summary>
                [NameInMap("Utterance")]
                [Validation(Required=false)]
                public string Utterance { get; set; }

                /// <summary>
                /// <para>Vendor-specific data sent from the client. This parameter is valid when <c>Role</c> is <c>USER</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;test1&quot;:&quot;1234&quot;}</para>
                /// </summary>
                [NameInMap("VendorParams")]
                [Validation(Required=false)]
                public string VendorParams { get; set; }

            }

            /// <summary>
            /// <para>The transfer target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default@testInstance1</para>
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
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A list of parameters related to the error.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2c26e67-5984-4935-984e-bcee52971993</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
