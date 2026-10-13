// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListSipTrunksResponseBody : TeaModel {
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of SIP trunks.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListSipTrunksResponseBodyList> List { get; set; }
        public class ListSipTrunksResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The description of the SIP trunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test environment SIP trunk</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The creation timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727654400000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The list of IP addresses of the SIP trunk.</para>
            /// </summary>
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public List<ListSipTrunksResponseBodyListIps> Ips { get; set; }
            public class ListSipTrunksResponseBodyListIps : TeaModel {
                /// <summary>
                /// <para>The IP address of the SIP trunk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.2.1</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <para>The unique identifier of the SIP trunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6bf8a1d2-3c4e-4f5a-9b8c-7d6e5f4a3b2c</para>
            /// </summary>
            [NameInMap("TrunkId")]
            [Validation(Required=false)]
            public string TrunkId { get; set; }

            /// <summary>
            /// <para>The name of the SIP trunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sip-trunk-demo</para>
            /// </summary>
            [NameInMap("TrunkName")]
            [Validation(Required=false)]
            public string TrunkName { get; set; }

        }

        /// <summary>
        /// <para>The message.</para>
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
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
