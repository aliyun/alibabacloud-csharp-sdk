// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsRdsInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("DbInstances")]
        [Validation(Required=false)]
        public DescribeDrdsRdsInstancesResponseBodyDbInstances DbInstances { get; set; }
        public class DescribeDrdsRdsInstancesResponseBodyDbInstances : TeaModel {
            [NameInMap("DbInstance")]
            [Validation(Required=false)]
            public List<DescribeDrdsRdsInstancesResponseBodyDbInstancesDbInstance> DbInstance { get; set; }
            public class DescribeDrdsRdsInstancesResponseBodyDbInstancesDbInstance : TeaModel {
                public string DBInstanceCPU { get; set; }
                public long? DBInstanceMemory { get; set; }
                public string PayType { get; set; }
                public string DBInstanceStatus { get; set; }
                public string NetworkType { get; set; }
                public int? Port { get; set; }
                public string EngineVersion { get; set; }
                public string DmInstanceId { get; set; }
                public long? DBInstanceStorage { get; set; }
                public string ConnectUrl { get; set; }
                public int? ReadWeight { get; set; }
                public string RdsInstType { get; set; }
                public string DBInstanceClassType { get; set; }
                public string DBInstanceId { get; set; }
                public string Engine { get; set; }
                public string DbInstType { get; set; }
            }
        };

    }

}
