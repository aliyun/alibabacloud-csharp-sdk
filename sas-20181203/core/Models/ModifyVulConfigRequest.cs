// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVulConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the vulnerability scan feature. Valid values:
        /// 
        /// *   **on**: enables the feature
        /// *   **off**: disables the feature
        /// 
        /// > Valid values when you set the Type parameter to scanMode:
        /// 
        /// *   **real**: displays only easily exploitable vulnerabilities.
        /// 
        /// *   **all**: displays all vulnerabilities.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The type of the vulnerability. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerability
        /// *   **sys**: Windows system vulnerability
        /// *   **cms**: Web-CMS vulnerability
        /// *   **emg**: urgent vulnerability
        /// *   **app**: application vulnerability
        /// *   **yum**: YUM and APT source configuration
        /// *   **scanMode**: easily exploitable vulnerability
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
