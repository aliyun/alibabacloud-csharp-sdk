// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyStartVulScanRequest : TeaModel {
        /// <summary>
        /// The types of vulnerabilities that can be detected. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerabilities
        /// *   **sys**: Windows system vulnerabilities
        /// *   **cms**: Web-CMS vulnerabilities
        /// *   **app**: application vulnerabilities
        /// *   **emg**: urgent vulnerabilities
        /// *   **image**: container image vulnerabilities
        /// 
        /// >  If you leave this parameter empty, all types of vulnerabilities can be detected.
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// The UUIDs of servers.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
