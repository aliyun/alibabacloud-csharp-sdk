// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListNumberBindingsOfInstanceResponseBody : TeaModel {
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
        /// <para>The list of number binding information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListNumberBindingsOfInstanceResponseBodyData> Data { get; set; }
        public class ListNumberBindingsOfInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the number is bound to the instance specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Bound")]
            [Validation(Required=false)]
            public bool? Bound { get; set; }

            /// <summary>
            /// <para>The bound number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02180542230</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// <para>The SIP trunk ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>020ffd7f-e40a-4969-acc3-3e1d80870e3f</para>
            /// </summary>
            [NameInMap("SipTrunkId")]
            [Validation(Required=false)]
            public string SipTrunkId { get; set; }

            /// <summary>
            /// <para>The SIP trunk name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample trunk</para>
            /// </summary>
            [NameInMap("SipTrunkName")]
            [Validation(Required=false)]
            public string SipTrunkName { get; set; }

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
        /// <para>The message returned by the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
