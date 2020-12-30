// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class DescribeUisNodesResponseBody : TeaModel {
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

        [NameInMap("UisNodeList")]
        [Validation(Required=false)]
        public DescribeUisNodesResponseBodyUisNodeList UisNodeList { get; set; }
        public class DescribeUisNodesResponseBodyUisNodeList : TeaModel {
            [NameInMap("UisNode")]
            [Validation(Required=false)]
            public List<DescribeUisNodesResponseBodyUisNodeListUisNode> UisNode { get; set; }
            public class DescribeUisNodesResponseBodyUisNodeListUisNode : TeaModel {
                public string Status { get; set; }
                public string UisId { get; set; }
                public string UisNodeActiveIp { get; set; }
                public long? CreateTime { get; set; }
                public string UisEniIps { get; set; }
                public string UisNodeAreaId { get; set; }
                public string UisNodeId { get; set; }
                public string UisNodeIps { get; set; }
                public string Description { get; set; }
                public int? UisNodeBandwidth { get; set; }
                public int? IpAddrsNum { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
