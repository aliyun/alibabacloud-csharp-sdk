// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class PreserveHeaderFormatRequest : TeaModel {
        /// <summary>
        /// The language in which you want to display the results. Valid values: zh and en. zh indicates Chinese, which is the default value. en indicates English.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// Specifies whether the request header is case-sensitive. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PreserveHeaderFormat")]
        [Validation(Required=false)]
        public bool? PreserveHeaderFormat { get; set; }

    }

}
