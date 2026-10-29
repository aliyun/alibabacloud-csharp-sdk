// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListApiDestinationsResponseBody : TeaModel {
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
        public ListApiDestinationsResponseBodyData Data { get; set; }
        public class ListApiDestinationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API destinations.</para>
            /// </summary>
            [NameInMap("ApiDestinations")]
            [Validation(Required=false)]
            public List<ListApiDestinationsResponseBodyDataApiDestinations> ApiDestinations { get; set; }
            public class ListApiDestinationsResponseBodyDataApiDestinations : TeaModel {
                /// <summary>
                /// <para>The name of the API destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-destination-2</para>
                /// </summary>
                [NameInMap("ApiDestinationName")]
                [Validation(Required=false)]
                public string ApiDestinationName { get; set; }

                /// <summary>
                /// <para>The connection name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>connection-name</para>
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// <para>The description of the connection.</para>
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
                /// <para>1665223213000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The request parameters that are configured for the API destination.</para>
                /// </summary>
                [NameInMap("HttpApiParameters")]
                [Validation(Required=false)]
                public ListApiDestinationsResponseBodyDataApiDestinationsHttpApiParameters HttpApiParameters { get; set; }
                public class ListApiDestinationsResponseBodyDataApiDestinationsHttpApiParameters : TeaModel {
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
                    /// <item><description><para>POST</para>
                    /// </description></item>
                    /// <item><description><para>GET</para>
                    /// </description></item>
                    /// <item><description><para>DELETE</para>
                    /// </description></item>
                    /// <item><description><para>PUT</para>
                    /// </description></item>
                    /// <item><description><para>HEAD</para>
                    /// </description></item>
                    /// <item><description><para>TRACE</para>
                    /// </description></item>
                    /// <item><description><para>PATCH</para>
                    /// </description></item>
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
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public float? MaxResults { get; set; }

            /// <summary>
            /// <para>If excess return values exist, this parameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public float? Total { get; set; }

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
        /// <para>96D7C0AB-DCE5-5E82-96B8-4725E1706BB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
