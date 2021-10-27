// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRdsReadOnlyResponseBody : TeaModel {
        [NameInMap("DbInstances")]
        [Validation(Required=false)]
        public DescribeRdsReadOnlyResponseBodyDbInstances DbInstances { get; set; }
        public class DescribeRdsReadOnlyResponseBodyDbInstances : TeaModel {
            [NameInMap("DbInstance")]
            [Validation(Required=false)]
            public List<DescribeRdsReadOnlyResponseBodyDbInstancesDbInstance> DbInstance { get; set; }
            public class DescribeRdsReadOnlyResponseBodyDbInstancesDbInstance : TeaModel {
                public string ConnectUrl { get; set; }
                public string DBInstanceCPU { get; set; }
                public string DBInstanceClassType { get; set; }
                public string DBInstanceId { get; set; }
                public long? DBInstanceMemory { get; set; }
                public string DBInstanceStatus { get; set; }
                public long? DBInstanceStorage { get; set; }
                public string DbInstType { get; set; }
                public string DmInstanceId { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string ExpireTime { get; set; }
                public string NetworkType { get; set; }
                public string PayType { get; set; }
                public int? Port { get; set; }
                public string RdsInstType { get; set; }
                public int? ReadWeight { get; set; }
                public int? RemainDays { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
