// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetApiDestinationResponseBody : TeaModel {
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
        public GetApiDestinationResponseBodyData Data { get; set; }
        public class GetApiDestinationResponseBodyData : TeaModel {
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
            /// The description of the API destination.
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
            public GetApiDestinationResponseBodyDataHttpApiParameters HttpApiParameters { get; set; }
            public class GetApiDestinationResponseBodyDataHttpApiParameters : TeaModel {
                /// <summary>
                /// The endpoint of the API destination.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The HTTP request method. Valid values:
                /// 
                /// *   POST
                /// *   GET
                /// *   DELETE
                /// *   PUT
                /// *   HEAD
                /// *   TRACE
                /// *   PATCH
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

            }

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
