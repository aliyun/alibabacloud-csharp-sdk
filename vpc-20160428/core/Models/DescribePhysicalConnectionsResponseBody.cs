// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
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
                public string AccessPointId { get; set; }
                public string AccessPointType { get; set; }
                public string AdLocation { get; set; }
                public long? Bandwidth { get; set; }
                public string BusinessStatus { get; set; }
                public string ChargeType { get; set; }
                public string CircuitCode { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string EnabledTime { get; set; }
                public string EndTime { get; set; }
                public string HasReservationData { get; set; }
                public string LineOperator { get; set; }
                public string LoaStatus { get; set; }
                public string Name { get; set; }
                public string OrderMode { get; set; }
                public long? ParentPhysicalConnectionAliUid { get; set; }
                public string ParentPhysicalConnectionId { get; set; }
                public string PeerLocation { get; set; }
                public string PhysicalConnectionId { get; set; }
                public string PortNumber { get; set; }
                public string PortType { get; set; }
                public string ProductType { get; set; }
                public string RedundantPhysicalConnectionId { get; set; }
                public string ReservationActiveTime { get; set; }
                public string ReservationInternetChargeType { get; set; }
                public string ReservationOrderType { get; set; }
                public string Spec { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
                public int? VirtualPhysicalConnectionCount { get; set; }
                public string VlanId { get; set; }
                public string VpconnStatus { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
