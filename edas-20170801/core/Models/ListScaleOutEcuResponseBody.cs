// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListScaleOutEcuResponseBody : TeaModel {
        [NameInMap("EcuInfoList")]
        [Validation(Required=false)]
        public ListScaleOutEcuResponseBodyEcuInfoList EcuInfoList { get; set; }
        public class ListScaleOutEcuResponseBodyEcuInfoList : TeaModel {
            [NameInMap("EcuInfo")]
            [Validation(Required=false)]
            public List<ListScaleOutEcuResponseBodyEcuInfoListEcuInfo> EcuInfo { get; set; }
            public class ListScaleOutEcuResponseBodyEcuInfoListEcuInfo : TeaModel {
                public string VpcId { get; set; }
                public long? UpdateTime { get; set; }
                public string IpAddr { get; set; }
                public int? AvailableCpu { get; set; }
                public long? CreateTime { get; set; }
                public string UserId { get; set; }
                public string InstanceId { get; set; }
                public string RegionId { get; set; }
                public string EcuId { get; set; }
                public bool? DockerEnv { get; set; }
                public bool? Online { get; set; }
                public int? AvailableMem { get; set; }
                public string ZoneId { get; set; }
                public string Name { get; set; }
                public long? HeartbeatTime { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
