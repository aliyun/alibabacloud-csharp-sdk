// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListVulGlobalConfigRequest : TeaModel {
        /// <summary>
        /// The key of the configuration item. Valid values:
        /// 
        /// *   **vul_scan_ip_list**: The IP addresses that are detected.
        /// </summary>
        [NameInMap("ConfigKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

    }

}
