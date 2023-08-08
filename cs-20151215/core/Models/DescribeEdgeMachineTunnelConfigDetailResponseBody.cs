// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineTunnelConfigDetailResponseBody : TeaModel {
        /// <summary>
        /// The name of the cloud-native box.
        /// </summary>
        [NameInMap("device_name")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The model of the cloud-native box.
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// The product key.
        /// </summary>
        [NameInMap("product_key")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The serial number of the cloud-native box.
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// The token.
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The backend endpoint of the tunnel.
        /// </summary>
        [NameInMap("tunnel_endpoint")]
        [Validation(Required=false)]
        public string TunnelEndpoint { get; set; }

    }

}
