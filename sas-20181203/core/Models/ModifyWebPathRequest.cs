// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebPathRequest : TeaModel {
        /// <summary>
        /// The configuration of the web directory. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **webPathType**: the type of the web directory
        /// *   **webPath**: the web directory
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The protected asset to which the web directory belongs. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **target**: the protected asset.
        /// *   **targetType**: the type of the asset. Set the value to uuid.
        /// *   **flag**: the type of the operation.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The type of the configuration item. Set the value to **web_path**.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
