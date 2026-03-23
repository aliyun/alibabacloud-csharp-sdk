// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceHAConfigResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("HAMode")]
        [Validation(Required=false)]
        public string HAMode { get; set; }

        [NameInMap("HostInstanceInfos")]
        [Validation(Required=false)]
        public DescribeDBInstanceHAConfigResponseBodyHostInstanceInfos HostInstanceInfos { get; set; }
        public class DescribeDBInstanceHAConfigResponseBodyHostInstanceInfos : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceHAConfigResponseBodyHostInstanceInfosNodeInfo> NodeInfo { get; set; }
            public class DescribeDBInstanceHAConfigResponseBodyHostInstanceInfosNodeInfo : TeaModel {
                [NameInMap("DataSyncTime")]
                [Validation(Required=false)]
                public string DataSyncTime { get; set; }

                [NameInMap("LogSyncTime")]
                [Validation(Required=false)]
                public string LogSyncTime { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SyncStatus")]
                [Validation(Required=false)]
                public string SyncStatus { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SyncMode")]
        [Validation(Required=false)]
        public string SyncMode { get; set; }

    }

}
