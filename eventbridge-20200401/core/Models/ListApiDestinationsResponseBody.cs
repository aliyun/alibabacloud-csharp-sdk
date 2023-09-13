// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListApiDestinationsResponseBody : TeaModel {
        /// <summary>
        /// The returned response code. The value Success indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApiDestinationsResponseBodyData Data { get; set; }
        public class ListApiDestinationsResponseBodyData : TeaModel {
            /// <summary>
            /// The API destinations.
            /// </summary>
            [NameInMap("ApiDestinations")]
            [Validation(Required=false)]
            public List<ListApiDestinationsResponseBodyDataApiDestinations> ApiDestinations { get; set; }
            public class ListApiDestinationsResponseBodyDataApiDestinations : TeaModel {
                /// <summary>
                /// The name of the API destination.
                /// </summary>
                [NameInMap("ApiDestinationName")]
                [Validation(Required=false)]
                public string ApiDestinationName { get; set; }

                /// <summary>
                /// The connection name.
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// The description of the connection.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the API destination was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// The request parameters that are configured for the API destination.
                /// </summary>
                [NameInMap("HttpApiParameters")]
                [Validation(Required=false)]
                public ListApiDestinationsResponseBodyDataApiDestinationsHttpApiParameters HttpApiParameters { get; set; }
                public class ListApiDestinationsResponseBodyDataApiDestinationsHttpApiParameters : TeaModel {
                    /// <summary>
                    /// The endpoint of the API destination.
                    /// </summary>
                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// The HTTP request method. Valid values:
                    /// 
                    /// - POST
                    /// 
                    /// - GET
                    /// 
                    /// - DELETE
                    /// 
                    /// - PUT
                    /// 
                    /// - HEAD
                    /// 
                    /// - TRACE
                    /// 
                    /// - PATCH
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                }

            }

            /// <summary>
            /// The maximum number of entries returned per page.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public float? MaxResults { get; set; }

            /// <summary>
            /// If excess return values exist, this parameter is returned.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public float? Total { get; set; }

        }

        /// <summary>
        /// The returned message. If the request is successful, success is returned. If the request failed, an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
