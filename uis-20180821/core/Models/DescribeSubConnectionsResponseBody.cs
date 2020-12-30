// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class DescribeSubConnectionsResponseBody : TeaModel {
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

        [NameInMap("UisSubConnections")]
        [Validation(Required=false)]
        public DescribeSubConnectionsResponseBodyUisSubConnections UisSubConnections { get; set; }
        public class DescribeSubConnectionsResponseBodyUisSubConnections : TeaModel {
            [NameInMap("UisSubConnection")]
            [Validation(Required=false)]
            public List<DescribeSubConnectionsResponseBodyUisSubConnectionsUisSubConnection> UisSubConnection { get; set; }
            public class DescribeSubConnectionsResponseBodyUisSubConnectionsUisSubConnection : TeaModel {
                public string UisSubConnectionId { get; set; }
                public string Description { get; set; }
                public long? CreateTime { get; set; }
                public string Ip { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
