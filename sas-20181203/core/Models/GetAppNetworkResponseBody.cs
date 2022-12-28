// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAppNetworkResponseBody : TeaModel {
        [NameInMap("AppNetwork")]
        [Validation(Required=false)]
        public GetAppNetworkResponseBodyAppNetwork AppNetwork { get; set; }
        public class GetAppNetworkResponseBodyAppNetwork : TeaModel {
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkEdge> Edge { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkEdge : TeaModel {
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

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkNamespace> Namespace { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkNamespace : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkNode> Node { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkNode : TeaModel {
                [NameInMap("ContainerIds")]
                [Validation(Required=false)]
                public List<string> ContainerIds { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

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
