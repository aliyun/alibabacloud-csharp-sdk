// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ListBlockSendingResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of data about unsubscribes or spam reports.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBlockSendingResponseBodyData> Data { get; set; }
        public class ListBlockSendingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The recipient email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxx@rcpt.com">xxxx@rcpt.com</a></para>
            /// </summary>
            [NameInMap("BlockEmail")]
            [Validation(Required=false)]
            public string BlockEmail { get; set; }

            /// <summary>
            /// <para>The time the block was initiated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723259364</para>
            /// </summary>
            [NameInMap("BlockTime")]
            [Validation(Required=false)]
            public int? BlockTime { get; set; }

            /// <summary>
            /// <para>The reason for the block. The value is a bitset. The meaning of each bit is as follows:</para>
            /// <list type="bullet">
            /// <item><description><para>0: The reason is not specified.</para>
            /// </description></item>
            /// <item><description><para>1: The recipient is not interested in the content.</para>
            /// </description></item>
            /// <item><description><para>2: The content is repetitive.</para>
            /// </description></item>
            /// <item><description><para>3: The content is sent too frequently.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public int? Reason { get; set; }

            /// <summary>
            /// <para>The time the email was sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723249364</para>
            /// </summary>
            [NameInMap("SendTime")]
            [Validation(Required=false)]
            public int? SendTime { get; set; }

            /// <summary>
            /// <para>The sender email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxx@sender.com">xxxx@sender.com</a></para>
            /// </summary>
            [NameInMap("SenderEmail")]
            [Validation(Required=false)]
            public string SenderEmail { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. An empty string indicates that no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxyyyy</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
