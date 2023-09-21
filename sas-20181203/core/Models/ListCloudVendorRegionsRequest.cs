// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCloudVendorRegionsRequest : TeaModel {
        /// <summary>
        /// The language of the content in the request and response messages. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The service provider of cloud assets. Valid values:
        /// 
        /// *   **Tencent**, **HUAWEICLOUD**, **Azure**, and **AWS**: other service providers of cloud assets.
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
