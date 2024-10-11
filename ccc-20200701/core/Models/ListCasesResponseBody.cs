// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCasesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCasesResponseBodyData Data { get; set; }
        public class ListCasesResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCasesResponseBodyDataList> List { get; set; }
            public class ListCasesResponseBodyDataList : TeaModel {
                [NameInMap("AbandonPhase")]
                [Validation(Required=false)]
                public string AbandonPhase { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NA</para>
                /// </summary>
                [NameInMap("AbandonType")]
                [Validation(Required=false)]
                public string AbandonType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AttemptCount")]
                [Validation(Required=false)]
                public long? AttemptCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60ecb1a2-4480-4d01-bede-c5b7655bfadf</para>
                /// </summary>
                [NameInMap("CaseId")]
                [Validation(Required=false)]
                public string CaseId { get; set; }

                [NameInMap("CustomVariables")]
                [Validation(Required=false)]
                public string CustomVariables { get; set; }

                [NameInMap("FailureReason")]
                [Validation(Required=false)]
                public string FailureReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1888888****</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Connected</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7CC6523B-0E51-1B62-8DA5-6A9831CAE316</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
