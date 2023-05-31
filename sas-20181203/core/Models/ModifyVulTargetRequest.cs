// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVulTargetRequest : TeaModel {
        /// <summary>
        /// The configurations. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **vulType**: the type of the vulnerabilities to scan. Valid values:
        /// 
        ///     *   **cve**: Linux software vulnerabilities
        ///     *   **sys**: Windows system vulnerabilities
        ///     *   **cms**: Web-CMS vulnerabilities
        ///     *   **emg**: urgent vulnerabilities
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The operation. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **target**: the UUID of the server.
        /// 
        /// *   **targetType**: the application scope of the operation. Set the value to uuid.
        /// 
        /// *   **flag**: the type of the operation. Valid values:
        /// 
        ///     *   **add**: select
        ///     *   **del**: deselect
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
