// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AppendCasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of processing results for appending outbound call cases.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AppendCasesResponseBodyData> Data { get; set; }
        public class AppendCasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The custom variables of the contact, represented as a JSON string.</para>
            /// </summary>
            [NameInMap("CustomVariables")]
            [Validation(Required=false)]
            public string CustomVariables { get; set; }

            /// <summary>
            /// <para>The phone number of the contact.</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The unique identifier of the contact in the customer\&quot;s business system.</para>
            /// </summary>
            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC976D32-AC4C-4E0F-8AA9-F4BC6C4E2B3E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
