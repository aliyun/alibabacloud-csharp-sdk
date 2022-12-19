// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the configurations of vulnerability management.
        /// </summary>
        [NameInMap("TargetConfigs")]
        [Validation(Required=false)]
        public List<DescribeVulConfigResponseBodyTargetConfigs> TargetConfigs { get; set; }
        public class DescribeVulConfigResponseBodyTargetConfigs : TeaModel {
            /// <summary>
            /// The configuartion of vulnerability scan.
            /// 
            /// > 
            /// 
            /// Valid values of this parameter if **cve**, **sys**, **cms**, **app**, **emg**, or **yum** is returned for the Type parameter:
            /// 
            /// *   **on**: enabled
            /// *   **off**: disabled
            /// 
            /// > 
            /// 
            /// Valid values of this parameter if **scanMode** is returned for the Type parameter:
            /// 
            /// *   **real**: displays easily exploitable vulnerability
            /// *   **all**: displays all vulnerabilities
            /// 
            /// > 
            /// 
            /// If **imageVulClean** is returned for the Type parameter, the value of this parameter indicates the vulnerability retention duration.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The status of vulnerability management. Valid values:
            /// 
            /// *   **off**: disabled
            /// *   **on**: enabled
            /// </summary>
            [NameInMap("OverAllConfig")]
            [Validation(Required=false)]
            public string OverAllConfig { get; set; }

            /// <summary>
            /// The type of configuration. Valid values:
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

        /// <summary>
        /// The total number of configurations.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
