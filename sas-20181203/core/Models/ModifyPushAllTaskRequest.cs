// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPushAllTaskRequest : TeaModel {
        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The check items. Separate multiple check items with commas (,). Valid values:
        /// 
        /// *   **OVAL_ENTITY**: Common Vulnerabilities and Exposures (CVE) vulnerabilities
        /// *   **CMS**: Web-CMS vulnerabilities
        /// *   **SYSVUL**: Windows system vulnerabilities
        /// *   **SCA**: application vulnerabilities
        /// *   **HEALTH_CHECK**: baselines
        /// *   **WEBSHELL**: webshells
        /// *   **PROC_SNAPSHOT**: processes
        /// *   **PORT_SNAPSHOT**: ports
        /// *   **ACCOUNT_SNAPSHOT**: accounts
        /// *   **SOFTWARE_SNAPSHOT**: software assets
        /// *   **SCA_SNAPSHOT**: middleware
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public string Tasks { get; set; }

        /// <summary>
        /// The UUIDs of servers on which you want to perform security check tasks. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
