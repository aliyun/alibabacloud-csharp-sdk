// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthIdentityResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomAuthIdentityResponseBodyData Data { get; set; }
        public class QueryCustomAuthIdentityResponseBodyData : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryCustomAuthIdentityResponseBodyDataResults> Results { get; set; }
            public class QueryCustomAuthIdentityResponseBodyDataResults : TeaModel {
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("IdentityType")]
                [Validation(Required=false)]
                public string IdentityType { get; set; }

                [NameInMap("Secret")]
                [Validation(Required=false)]
                public string Secret { get; set; }

                [NameInMap("SignMode")]
                [Validation(Required=false)]
                public string SignMode { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
