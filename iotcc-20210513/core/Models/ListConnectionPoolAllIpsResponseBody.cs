// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListConnectionPoolAllIpsResponseBody : TeaModel {
        [NameInMap("ConnectionPoolIps")]
        [Validation(Required=false)]
        public List<ListConnectionPoolAllIpsResponseBodyConnectionPoolIps> ConnectionPoolIps { get; set; }
        public class ListConnectionPoolAllIpsResponseBodyConnectionPoolIps : TeaModel {
            [NameInMap("ConnectionPoolId")]
            [Validation(Required=false)]
            public string ConnectionPoolId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("IpNum")]
            [Validation(Required=false)]
            public long? IpNum { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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

        [NameInMap("TotalIpsCount")]
        [Validation(Required=false)]
        public int? TotalIpsCount { get; set; }

    }

}
