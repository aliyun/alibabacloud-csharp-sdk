// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthConnectBlackResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomAuthConnectBlackResponseBodyData Data { get; set; }
        public class QueryCustomAuthConnectBlackResponseBodyData : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryCustomAuthConnectBlackResponseBodyDataResults> Results { get; set; }
            public class QueryCustomAuthConnectBlackResponseBodyDataResults : TeaModel {
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                [NameInMap("PermitAction")]
                [Validation(Required=false)]
                public string PermitAction { get; set; }

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
