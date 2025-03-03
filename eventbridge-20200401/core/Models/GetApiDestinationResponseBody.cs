// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetApiDestinationResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned response code. The value Success indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApiDestinationResponseBodyData Data { get; set; }
        public class GetApiDestinationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the API destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("ApiDestinationName")]
            [Validation(Required=false)]
            public string ApiDestinationName { get; set; }

            /// <summary>
            /// <para>The connection name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-basic</para>
            /// </summary>
            [NameInMap("ConnectionName")]
            [Validation(Required=false)]
            public string ConnectionName { get; set; }

            /// <summary>
            /// <para>The description of the API destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the API destination was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649055710565</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The request parameters that are configured for the API destination.</para>
            /// </summary>
            [NameInMap("HttpApiParameters")]
            [Validation(Required=false)]
            public GetApiDestinationResponseBodyDataHttpApiParameters HttpApiParameters { get; set; }
            public class GetApiDestinationResponseBodyDataHttpApiParameters : TeaModel {
                /// <summary>
                /// <para>The endpoint of the API destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://127.0.0.1:8001/api">http://127.0.0.1:8001/api</a></para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The HTTP request method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>POST</description></item>
                /// <item><description>GET</description></item>
                /// <item><description>DELETE</description></item>
                /// <item><description>PUT</description></item>
                /// <item><description>HEAD</description></item>
                /// <item><description>TRACE</description></item>
                /// <item><description>PATCH</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the request is successful, success is returned. If the request failed, an error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B896B484-F16D-59DE-9E23-DD0E5C361108</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
