// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddImageVulWhiteListRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Default value: zh. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The reason why you add the vulnerability to the whitelist.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The source of the whitelist. Valid values:
        /// - **image**
        /// - **agentless**
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The object on which you want to perform the operation. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **type**: the object type. The value is fixed to repo.
        /// *   **target**: the object content. The value is in the Namespace/Image repository format.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The type of the vulnerability. Valid values:
        /// 
        /// *   **cve**: system vulnerability
        /// *   **sca**: application vulnerability
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The whitelist. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **Type**: the vulnerability type. Valid values: cve and sca.
        /// *   **Name**: the name of the vulnerability that is specified in Common Vulnerabilities and Exposures (CVE).
        /// *   **AliasName**: the alias of the vulnerability that is specified in CVE.
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string Whitelist { get; set; }

    }

}
