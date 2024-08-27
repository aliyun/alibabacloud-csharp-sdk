// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthIdentityResponseBody : TeaModel {
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
        public QueryCustomAuthIdentityResponseBodyData Data { get; set; }
        public class QueryCustomAuthIdentityResponseBodyData : TeaModel {
            /// <summary>
            /// If excess return values exist, this parameter is returned.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The returned results.
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryCustomAuthIdentityResponseBodyDataResults> Results { get; set; }
            public class QueryCustomAuthIdentityResponseBodyDataResults : TeaModel {
                /// <summary>
                /// The client ID if IdentityType is set to CLIENT.
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

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
                /// The AccessKey secret.
                /// </summary>
                [NameInMap("Secret")]
                [Validation(Required=false)]
                public string Secret { get; set; }

                /// <summary>
                /// The signature verification mode. ORIGIN: compares the password and the AccessKey secret. SIGNED: uses the HMAC_SHA1 algorithm to sign the client ID to obtain a password and then compares the password.
                /// </summary>
                [NameInMap("SignMode")]
                [Validation(Required=false)]
                public string SignMode { get; set; }

                /// <summary>
                /// The username.
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

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
