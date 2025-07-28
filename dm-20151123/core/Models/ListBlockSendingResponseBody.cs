// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ListBlockSendingResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBlockSendingResponseBodyData> Data { get; set; }
        public class ListBlockSendingResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxx@rcpt.com">xxxx@rcpt.com</a></para>
            /// </summary>
            [NameInMap("BlockEmail")]
            [Validation(Required=false)]
            public string BlockEmail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1723259364</para>
            /// </summary>
            [NameInMap("BlockTime")]
            [Validation(Required=false)]
            public int? BlockTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public int? Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1723249364</para>
            /// </summary>
            [NameInMap("SendTime")]
            [Validation(Required=false)]
            public int? SendTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxx@sender.com">xxxx@sender.com</a></para>
            /// </summary>
            [NameInMap("SenderEmail")]
            [Validation(Required=false)]
            public string SenderEmail { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxyyyy</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
