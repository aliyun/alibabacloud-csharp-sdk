// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthPermissionResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomAuthPermissionResponseBodyData Data { get; set; }
        public class QueryCustomAuthPermissionResponseBodyData : TeaModel {
            /// <summary>
            /// The token that marks the end position of the previous returned page. To obtain the next batch of data, call the operation again by using the value of NextToken returned by the previous request. If you call this operation for the first time or want to query all results, set NextToken to an empty string.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The response results.
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryCustomAuthPermissionResponseBodyDataResults> Results { get; set; }
            public class QueryCustomAuthPermissionResponseBodyDataResults : TeaModel {
                /// <summary>
                /// Indicates whether to allow or deny access.
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// The username or client ID.
                /// </summary>
                [NameInMap("Identity")]
                [Validation(Required=false)]
                public string Identity { get; set; }

                /// <summary>
                /// The identity type. Valid values:
                /// 
                /// *   USER
                /// *   CLIENT
                /// </summary>
                [NameInMap("IdentityType")]
                [Validation(Required=false)]
                public string IdentityType { get; set; }

                /// <summary>
                /// The authorized permissions.
                /// </summary>
                [NameInMap("PermitAction")]
                [Validation(Required=false)]
                public string PermitAction { get; set; }

                /// <summary>
                /// The topic name. Multi-level topics and wildcard characters are supported.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

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
