// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineTunnelConfigDetailResponseBody : TeaModel {
        [NameInMap("device_name")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("product_key")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("tunnel_endpoint")]
        [Validation(Required=false)]
        public string TunnelEndpoint { get; set; }

    }

}
