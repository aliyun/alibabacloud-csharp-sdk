// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateInstanceRequest : TeaModel {
        [NameInMap("extConfig")]
        [Validation(Required=false)]
        public UpdateInstanceRequestExtConfig ExtConfig { get; set; }
        public class UpdateInstanceRequestExtConfig : TeaModel {
            [NameInMap("autoScaling")]
            [Validation(Required=false)]
            public bool? AutoScaling { get; set; }
            [NameInMap("messageRetentionTime")]
            [Validation(Required=false)]
            public int? MessageRetentionTime { get; set; }
            [NameInMap("sendReceiveRatio")]
            [Validation(Required=false)]
            public float? SendReceiveRatio { get; set; }
        };

        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class UpdateInstanceRequestNetworkInfo : TeaModel {
            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public List<UpdateInstanceRequestNetworkInfoEndpoints> Endpoints { get; set; }
            public class UpdateInstanceRequestNetworkInfoEndpoints : TeaModel {
                public string EndpointType { get; set; }
                public string IpWhitelist { get; set; }
            }
        };

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
