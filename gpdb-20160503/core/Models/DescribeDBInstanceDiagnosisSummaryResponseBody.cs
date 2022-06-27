// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDiagnosisSummaryResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceDiagnosisSummaryResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodyItems : TeaModel {
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("NodeAddress")]
            [Validation(Required=false)]
            public string NodeAddress { get; set; }

            [NameInMap("NodeCID")]
            [Validation(Required=false)]
            public string NodeCID { get; set; }

            [NameInMap("NodeID")]
            [Validation(Required=false)]
            public string NodeID { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("NodePort")]
            [Validation(Required=false)]
            public string NodePort { get; set; }

            [NameInMap("NodePreferredRole")]
            [Validation(Required=false)]
            public string NodePreferredRole { get; set; }

            [NameInMap("NodeReplicationMode")]
            [Validation(Required=false)]
            public string NodeReplicationMode { get; set; }

            [NameInMap("NodeRole")]
            [Validation(Required=false)]
            public string NodeRole { get; set; }

            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

        }

        [NameInMap("MasterStatusInfo")]
        [Validation(Required=false)]
        public DescribeDBInstanceDiagnosisSummaryResponseBodyMasterStatusInfo MasterStatusInfo { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodyMasterStatusInfo : TeaModel {
            [NameInMap("ExceptionNodeNum")]
            [Validation(Required=false)]
            public int? ExceptionNodeNum { get; set; }
            [NameInMap("NormalNodeNum")]
            [Validation(Required=false)]
            public int? NormalNodeNum { get; set; }
            [NameInMap("NotPreferredNodeNum")]
            [Validation(Required=false)]
            public int? NotPreferredNodeNum { get; set; }
            [NameInMap("NotSyncingNodeNum")]
            [Validation(Required=false)]
            public int? NotSyncingNodeNum { get; set; }
            [NameInMap("PreferredNodeNum")]
            [Validation(Required=false)]
            public int? PreferredNodeNum { get; set; }
            [NameInMap("SyncedNodeNum")]
            [Validation(Required=false)]
            public int? SyncedNodeNum { get; set; }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SegmentStatusInfo")]
        [Validation(Required=false)]
        public DescribeDBInstanceDiagnosisSummaryResponseBodySegmentStatusInfo SegmentStatusInfo { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodySegmentStatusInfo : TeaModel {
            [NameInMap("ExceptionNodeNum")]
            [Validation(Required=false)]
            public int? ExceptionNodeNum { get; set; }
            [NameInMap("NormalNodeNum")]
            [Validation(Required=false)]
            public int? NormalNodeNum { get; set; }
            [NameInMap("NotPreferredNodeNum")]
            [Validation(Required=false)]
            public int? NotPreferredNodeNum { get; set; }
            [NameInMap("NotSyncingNodeNum")]
            [Validation(Required=false)]
            public int? NotSyncingNodeNum { get; set; }
            [NameInMap("PreferredNodeNum")]
            [Validation(Required=false)]
            public int? PreferredNodeNum { get; set; }
            [NameInMap("SyncedNodeNum")]
            [Validation(Required=false)]
            public int? SyncedNodeNum { get; set; }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
