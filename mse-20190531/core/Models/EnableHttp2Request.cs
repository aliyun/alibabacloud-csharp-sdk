// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class EnableHttp2Request : TeaModel {
        /// <summary>
        /// The language in which you want to display the results. Valid values: zh and en. zh indicates Chinese, which is the default value. en indicates English.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Specifies whether to enable HTTP/2 for negotiation between the server and client. This parameter applies to requests. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnableHttp2")]
        [Validation(Required=false)]
        public bool? EnableHttp2 { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

    }

}
