// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListConnectionPoolsResponseBody : TeaModel {
        [NameInMap("ConnectionPools")]
        [Validation(Required=false)]
        public List<ListConnectionPoolsResponseBodyConnectionPools> ConnectionPools { get; set; }
        public class ListConnectionPoolsResponseBodyConnectionPools : TeaModel {
            [NameInMap("Cidrs")]
            [Validation(Required=false)]
            public List<string> Cidrs { get; set; }

            [NameInMap("ConnectionPoolDescription")]
            [Validation(Required=false)]
            public string ConnectionPoolDescription { get; set; }

            [NameInMap("ConnectionPoolId")]
            [Validation(Required=false)]
            public string ConnectionPoolId { get; set; }

            [NameInMap("ConnectionPoolName")]
            [Validation(Required=false)]
            public string ConnectionPoolName { get; set; }

            [NameInMap("ConnectionPoolStatus")]
            [Validation(Required=false)]
            public string ConnectionPoolStatus { get; set; }

            [NameInMap("OperateResultRequestID")]
            [Validation(Required=false)]
            public string OperateResultRequestID { get; set; }

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
