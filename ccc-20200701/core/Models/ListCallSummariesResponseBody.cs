// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallSummariesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCallSummariesResponseBodyData> Data { get; set; }
        public class ListCallSummariesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>job-544789******759424</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1723449513735</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>creator@ccc-test</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>editor@ccc-test</para>
            /// </summary>
            [NameInMap("Editor")]
            [Validation(Required=false)]
            public string Editor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ac0dd304-<b><b>-</b></b>-****-4a90010f0d38</para>
            /// </summary>
            [NameInMap("TicketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>932579BC-811A-503D-B322-4C2E57087CAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
