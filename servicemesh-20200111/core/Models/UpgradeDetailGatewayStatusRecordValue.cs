// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpgradeDetailGatewayStatusRecordValue : TeaModel {
        /// <summary>
        /// The upgrade status of the ingress gateway. Valid values:
        /// 
        /// *   `upgrading`: The ingress gateway is being upgraded.
        /// *   `pending`: The ingress gateway waits to be upgraded.
        /// *   `finished`: The ingress gateway upgrade is complete.
        /// *   `notStart`: The ingress gateway upgrade does not start.
        /// *   `failed`: The ingress gateway upgrade fails.
        /// *   `unknown`: The upgrade status of the ingress gateway is unknown.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Additional status information of the ingress gateway.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The version of the ingress gateway.
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
