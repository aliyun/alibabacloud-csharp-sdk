// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListScaleOutEcuResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EcuInfoList")]
        [Validation(Required=false)]
        public ListScaleOutEcuResponseBodyEcuInfoList EcuInfoList { get; set; }
        public class ListScaleOutEcuResponseBodyEcuInfoList : TeaModel {
            [NameInMap("EcuInfo")]
            [Validation(Required=false)]
            public List<ListScaleOutEcuResponseBodyEcuInfoListEcuInfo> EcuInfo { get; set; }
            public class ListScaleOutEcuResponseBodyEcuInfoListEcuInfo : TeaModel {
                public int? AvailableCpu { get; set; }
                public int? AvailableMem { get; set; }
                public long? CreateTime { get; set; }
                public bool? DockerEnv { get; set; }
                public string EcuId { get; set; }
                public long? HeartbeatTime { get; set; }
                public string InstanceId { get; set; }
                public string IpAddr { get; set; }
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
