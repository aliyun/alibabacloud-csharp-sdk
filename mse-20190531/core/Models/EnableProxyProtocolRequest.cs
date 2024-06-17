// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class EnableProxyProtocolRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnableProxyProtocol")]
        [Validation(Required=false)]
        public bool? EnableProxyProtocol { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

    }

}
