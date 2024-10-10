// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetMailTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>38C0FEC8-1510-415C-A9F1-9AE9422BDB65</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetMailTaskStatusResponseBodyResult> Result { get; set; }
        public class GetMailTaskStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-09 17:34:11</para>
            /// </summary>
            [NameInMap("execTime")]
            [Validation(Required=false)]
            public string ExecTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c38f73f4c5xxxxxc808c41b3f4d23b7852</para>
            /// </summary>
            [NameInMap("mailId")]
            [Validation(Required=false)]
            public string MailId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SENT</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1282xxx610816</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
