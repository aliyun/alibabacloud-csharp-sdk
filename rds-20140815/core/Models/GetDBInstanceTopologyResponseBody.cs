// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GetDBInstanceTopologyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDBInstanceTopologyResponseBodyData Data { get; set; }
        public class GetDBInstanceTopologyResponseBodyData : TeaModel {
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public List<GetDBInstanceTopologyResponseBodyDataConnections> Connections { get; set; }
            public class GetDBInstanceTopologyResponseBodyDataConnections : TeaModel {
                public string ConnectionString { get; set; }
                public string DBInstanceName { get; set; }
                public string NetType { get; set; }
                public string ZoneId { get; set; }
            }
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetDBInstanceTopologyResponseBodyDataNodes> Nodes { get; set; }
            public class GetDBInstanceTopologyResponseBodyDataNodes : TeaModel {
                public string DBInstanceName { get; set; }
                public string DedicatedHostGroupId { get; set; }
                public string DedicatedHostId { get; set; }
                public string NodeId { get; set; }
                public string Role { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
