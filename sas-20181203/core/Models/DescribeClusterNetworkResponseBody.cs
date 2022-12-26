// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterNetworkResponseBody : TeaModel {
        [NameInMap("ClusterNetwork")]
        [Validation(Required=false)]
        public DescribeClusterNetworkResponseBodyClusterNetwork ClusterNetwork { get; set; }
        public class DescribeClusterNetworkResponseBodyClusterNetwork : TeaModel {
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<DescribeClusterNetworkResponseBodyClusterNetworkEdge> Edge { get; set; }
            public class DescribeClusterNetworkResponseBodyClusterNetworkEdge : TeaModel {
                [NameInMap("DstNodeId")]
                [Validation(Required=false)]
                public string DstNodeId { get; set; }

                [NameInMap("DstNodeType")]
                [Validation(Required=false)]
                public string DstNodeType { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("SrcNodeId")]
                [Validation(Required=false)]
                public string SrcNodeId { get; set; }

                [NameInMap("SrcNodeType")]
                [Validation(Required=false)]
                public string SrcNodeType { get; set; }

            }

            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<DescribeClusterNetworkResponseBodyClusterNetworkNode> Node { get; set; }
            public class DescribeClusterNetworkResponseBodyClusterNetworkNode : TeaModel {
                [NameInMap("CnnfSwitch")]
                [Validation(Required=false)]
                public int? CnnfSwitch { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("InterceptionType")]
                [Validation(Required=false)]
                public int? InterceptionType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NetTopoSwitch")]
                [Validation(Required=false)]
                public string NetTopoSwitch { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
