// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthConnectBlackResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request is successful. Other status codes indicate that the request failed. For a list of error codes, see Error codes.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomAuthConnectBlackResponseBodyData Data { get; set; }
        public class QueryCustomAuthConnectBlackResponseBodyData : TeaModel {
            /// <summary>
            /// The pagination token that is used in the next request to retrieve a new page of results.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The returned results.
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryCustomAuthConnectBlackResponseBodyDataResults> Results { get; set; }
            public class QueryCustomAuthConnectBlackResponseBodyDataResults : TeaModel {
                /// <summary>
                /// The client ID.
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// Indicates whether to allow or deny access.
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// The authorized permissions.
                /// </summary>
                [NameInMap("PermitAction")]
                [Validation(Required=false)]
                public string PermitAction { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
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

        /// <summary>
        /// Indicates whether the request is successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
