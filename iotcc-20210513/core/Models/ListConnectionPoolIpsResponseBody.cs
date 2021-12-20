// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListConnectionPoolIpsResponseBody : TeaModel {
        [NameInMap("ConnectionPoolIps")]
        [Validation(Required=false)]
        public List<ListConnectionPoolIpsResponseBodyConnectionPoolIps> ConnectionPoolIps { get; set; }
        public class ListConnectionPoolIpsResponseBodyConnectionPoolIps : TeaModel {
            [NameInMap("ConnectionPoolId")]
            [Validation(Required=false)]
            public string ConnectionPoolId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
