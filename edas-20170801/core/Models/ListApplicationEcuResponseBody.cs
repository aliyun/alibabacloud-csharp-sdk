// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListApplicationEcuResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EcuInfoList")]
        [Validation(Required=false)]
        public ListApplicationEcuResponseBodyEcuInfoList EcuInfoList { get; set; }
        public class ListApplicationEcuResponseBodyEcuInfoList : TeaModel {
            [NameInMap("EcuEntity")]
            [Validation(Required=false)]
            public List<ListApplicationEcuResponseBodyEcuInfoListEcuEntity> EcuEntity { get; set; }
            public class ListApplicationEcuResponseBodyEcuInfoListEcuEntity : TeaModel {
                public string AppId { get; set; }
                public int? AvailableCpu { get; set; }
                public int? AvailableMem { get; set; }
                public int? Cpu { get; set; }
                public long? CreateTime { get; set; }
                public bool? DockerEnv { get; set; }
                public string EcuId { get; set; }
                public long? HeartbeatTime { get; set; }
                public string InstanceId { get; set; }
                public string IpAddr { get; set; }
                public int? Mem { get; set; }
                public string Name { get; set; }
                public bool? Online { get; set; }
                public string RegionId { get; set; }
                public long? UpdateTime { get; set; }
                public string UserId { get; set; }
                public string VpcId { get; set; }
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
