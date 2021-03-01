// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListEcuByRegionResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EcuEntityList")]
        [Validation(Required=false)]
        public ListEcuByRegionResponseBodyEcuEntityList EcuEntityList { get; set; }
        public class ListEcuByRegionResponseBodyEcuEntityList : TeaModel {
            [NameInMap("EcuEntity")]
            [Validation(Required=false)]
            public List<ListEcuByRegionResponseBodyEcuEntityListEcuEntity> EcuEntity { get; set; }
            public class ListEcuByRegionResponseBodyEcuEntityListEcuEntity : TeaModel {
                public string VpcId { get; set; }
                public long? UpdateTime { get; set; }
                public string IpAddr { get; set; }
                public int? AvailableCpu { get; set; }
                public long? CreateTime { get; set; }
                public string UserId { get; set; }
                public string InstanceId { get; set; }
                public int? Mem { get; set; }
                public string RegionId { get; set; }
                public string EcuId { get; set; }
                public int? Cpu { get; set; }
                public bool? DockerEnv { get; set; }
                public bool? Online { get; set; }
                public int? AvailableMem { get; set; }
                public string ZoneId { get; set; }
                public string Name { get; set; }
                public long? HeartbeatTime { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
