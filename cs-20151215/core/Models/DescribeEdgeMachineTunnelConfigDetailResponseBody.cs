// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineTunnelConfigDetailResponseBody : TeaModel {
        /// <summary>
        /// The device name.
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
        /// Product Key
        /// </summary>
        [NameInMap("product_key")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// Request ID
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
        /// Token
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The tunnel endpoint.
        /// </summary>
        [NameInMap("tunnel_endpoint")]
        [Validation(Required=false)]
        public string TunnelEndpoint { get; set; }

    }

}
