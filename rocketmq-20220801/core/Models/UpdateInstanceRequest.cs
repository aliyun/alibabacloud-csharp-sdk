// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateInstanceRequest : TeaModel {
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class UpdateInstanceRequestNetworkInfo : TeaModel {
            [NameInMap("internetInfo")]
            [Validation(Required=false)]
            public UpdateInstanceRequestNetworkInfoInternetInfo InternetInfo { get; set; }
            public class UpdateInstanceRequestNetworkInfoInternetInfo : TeaModel {
                [NameInMap("ipWhitelist")]
                [Validation(Required=false)]
                public List<string> IpWhitelist { get; set; }

            }

        }

        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestProductInfo ProductInfo { get; set; }
        public class UpdateInstanceRequestProductInfo : TeaModel {
            [NameInMap("autoScaling")]
            [Validation(Required=false)]
            public bool? AutoScaling { get; set; }

            [NameInMap("messageRetentionTime")]
            [Validation(Required=false)]
            public int? MessageRetentionTime { get; set; }

            [NameInMap("sendReceiveRatio")]
            [Validation(Required=false)]
            public float? SendReceiveRatio { get; set; }

        }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
