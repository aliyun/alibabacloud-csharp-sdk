// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class DescribeUisConnectionsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("UisConnections")]
        [Validation(Required=false)]
        public DescribeUisConnectionsResponseBodyUisConnections UisConnections { get; set; }
        public class DescribeUisConnectionsResponseBodyUisConnections : TeaModel {
            [NameInMap("UisConnection")]
            [Validation(Required=false)]
            public List<DescribeUisConnectionsResponseBodyUisConnectionsUisConnection> UisConnection { get; set; }
            public class DescribeUisConnectionsResponseBodyUisConnectionsUisConnection : TeaModel {
                public string GreConfig { get; set; }
                public string UisId { get; set; }
                public string UisNodeId { get; set; }
                public string Description { get; set; }
                public string State { get; set; }
                public string UisProtocol { get; set; }
                public string Name { get; set; }
                public string SslConfig { get; set; }
                public string UisConnectionId { get; set; }
            }
        };

    }

}
