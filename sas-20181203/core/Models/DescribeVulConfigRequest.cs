// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulConfigRequest : TeaModel {
        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of configuration. By default, all types of configurations are queried. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerability
        /// *   **sys**: Windows system vulnerability
        /// *   **cms**: Web-CMS vulnerability
        /// *   **app**: application vulnerability that is detected by using web scanner
        /// *   **emg**: urgent vulnerability
        /// *   **scanMode**: displays easily exploitable vulnerability
        /// *   **imageVulClean**: vulnerability retention duration
        /// *   **yum**: preferentially uses YUM or APT sources of Alibaba Cloud to fix vulnerabilities
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
