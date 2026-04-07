// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListCallDetailRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCallDetailRecordsResponseBodyData Data { get; set; }
        public class ListCallDetailRecordsResponseBodyData : TeaModel {
            [NameInMap("CallDetailRecords")]
            [Validation(Required=false)]
            public List<ListCallDetailRecordsResponseBodyDataCallDetailRecords> CallDetailRecords { get; set; }
            public class ListCallDetailRecordsResponseBodyDataCallDetailRecords : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>15100000001</para>
                /// </summary>
                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4001027277</para>
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
                /// <para>265</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1767315903531</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>unknown</para>
                /// </summary>
                [NameInMap("ResolutionEvidence")]
                [Validation(Required=false)]
                public string ResolutionEvidence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>99eebcba-7f8a-4a54-b0da-603ada79d8e2</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1767315903531</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>245</para>
                /// </summary>
                [NameInMap("TalkTime")]
                [Validation(Required=false)]
                public int? TalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TalkTurns")]
                [Validation(Required=false)]
                public int? TalkTurns { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default@testinstance1</para>
                /// </summary>
                [NameInMap("TransferTarget")]
                [Validation(Required=false)]
                public string TransferTarget { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Agent</para>
                /// </summary>
                [NameInMap("TransferType")]
                [Validation(Required=false)]
                public string TransferType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>362</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>A8AED3C8-F57B-5D71-9A34-4A170287533F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
