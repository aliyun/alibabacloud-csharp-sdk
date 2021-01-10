// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPSqlAuditInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryODPSqlAuditInstancesResponseBodyData Data { get; set; }
        public class QueryODPSqlAuditInstancesResponseBodyData : TeaModel {
            [NameInMap("SlsOpened")]
            [Validation(Required=false)]
            public bool? SlsOpened { get; set; }
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<QueryODPSqlAuditInstancesResponseBodyDataInstances> Instances { get; set; }
            public class QueryODPSqlAuditInstancesResponseBodyDataInstances : TeaModel {
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public long? OpenedCount { get; set; }
                public List<QueryODPSqlAuditInstancesResponseBodyDataInstancesSchemas> Schemas { get; set; }
                public class QueryODPSqlAuditInstancesResponseBodyDataInstancesSchemas : TeaModel {
                    public bool? Opened { get; set; }
                    public string SchemaName { get; set; }
                }
            }
        };

    }

}
