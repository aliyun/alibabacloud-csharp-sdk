// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthPermissionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomAuthPermissionResponseBodyData Data { get; set; }
        public class QueryCustomAuthPermissionResponseBodyData : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryCustomAuthPermissionResponseBodyDataResults> Results { get; set; }
            public class QueryCustomAuthPermissionResponseBodyDataResults : TeaModel {
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                [NameInMap("Identity")]
                [Validation(Required=false)]
                public string Identity { get; set; }

                [NameInMap("IdentityType")]
                [Validation(Required=false)]
                public string IdentityType { get; set; }

                [NameInMap("PermitAction")]
                [Validation(Required=false)]
                public string PermitAction { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

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
