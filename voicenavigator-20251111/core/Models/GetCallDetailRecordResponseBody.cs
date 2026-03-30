// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetCallDetailRecordResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCallDetailRecordResponseBodyData Data { get; set; }
        public class GetCallDetailRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>15100000001</para>
            /// </summary>
            [NameInMap("Callee")]
            [Validation(Required=false)]
            public string Callee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15929990193</para>
            /// </summary>
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Answered</para>
            /// </summary>
            [NameInMap("DispositionCode")]
            [Validation(Required=false)]
            public string DispositionCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ConcurrentLimitExceeded</para>
            /// </summary>
            [NameInMap("DispositionReason")]
            [Validation(Required=false)]
            public string DispositionReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>160</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1752283603978</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IssueResolved")]
            [Validation(Required=false)]
            public bool? IssueResolved { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Customer</para>
            /// </summary>
            [NameInMap("ReleaseInitiator")]
            [Validation(Required=false)]
            public string ReleaseInitiator { get; set; }

            [NameInMap("ResolutionEvidence")]
            [Validation(Required=false)]
            public string ResolutionEvidence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>07d72ea0-6e38-48d4-8371-14deaaba996f</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1774858849987</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TalkTime")]
            [Validation(Required=false)]
            public int? TalkTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TalkTurns")]
            [Validation(Required=false)]
            public int? TalkTurns { get; set; }

            [NameInMap("Transcripts")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataTranscripts> Transcripts { get; set; }
            public class GetCallDetailRecordResponseBodyDataTranscripts : TeaModel {
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Backchannels")]
                [Validation(Required=false)]
                public bool? Backchannels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1748945414222</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;endSilenceTimeout&quot;:500,&quot;interruptible&quot;:false,&quot;silenceDetectionTimeout&quot;:5,&quot;type&quot;:&quot;Voice&quot;}]</para>
                /// </summary>
                [NameInMap("ControlParamsList")]
                [Validation(Required=false)]
                public string ControlParamsList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1767315903531</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1774859592165</para>
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public string EventTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;dataType&quot;:&quot;Silence&quot;}]</para>
                /// </summary>
                [NameInMap("Extras")]
                [Validation(Required=false)]
                public string Extras { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Interrupted")]
                [Validation(Required=false)]
                public bool? Interrupted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Legacy")]
                [Validation(Required=false)]
                public bool? Legacy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PlayedWords")]
                [Validation(Required=false)]
                public int? PlayedWords { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("StreamEnd")]
                [Validation(Required=false)]
                public bool? StreamEnd { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StreamId")]
                [Validation(Required=false)]
                public string StreamId { get; set; }

                [NameInMap("Utterance")]
                [Validation(Required=false)]
                public string Utterance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;test1&quot;:&quot;1234&quot;}</para>
                /// </summary>
                [NameInMap("VendorParams")]
                [Validation(Required=false)]
                public string VendorParams { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default@testInstance1</para>
            /// </summary>
            [NameInMap("TransferTarget")]
            [Validation(Required=false)]
            public string TransferTarget { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SkillGroup</para>
            /// </summary>
            [NameInMap("TransferType")]
            [Validation(Required=false)]
            public string TransferType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2c26e67-5984-4935-984e-bcee52971993</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
