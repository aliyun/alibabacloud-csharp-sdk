// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePhysicalConnectionsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PhysicalConnectionSet")]
        [Validation(Required=false)]
        public DescribePhysicalConnectionsResponseBodyPhysicalConnectionSet PhysicalConnectionSet { get; set; }
        public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSet : TeaModel {
            [NameInMap("PhysicalConnectionType")]
            [Validation(Required=false)]
            public List<DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionType> PhysicalConnectionType { get; set; }
            public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionType : TeaModel {
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                [NameInMap("AdLocation")]
                [Validation(Required=false)]
                public string AdLocation { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("CircuitCode")]
                [Validation(Required=false)]
                public string CircuitCode { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

                [NameInMap("LineOperator")]
                [Validation(Required=false)]
                public string LineOperator { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PeerLocation")]
                [Validation(Required=false)]
                public string PeerLocation { get; set; }

                [NameInMap("PhysicalConnectionId")]
                [Validation(Required=false)]
                public string PhysicalConnectionId { get; set; }

                [NameInMap("PortNumber")]
                [Validation(Required=false)]
                public string PortNumber { get; set; }

                [NameInMap("PortType")]
                [Validation(Required=false)]
                public string PortType { get; set; }

                [NameInMap("RedundantPhysicalConnectionId")]
                [Validation(Required=false)]
                public string RedundantPhysicalConnectionId { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
