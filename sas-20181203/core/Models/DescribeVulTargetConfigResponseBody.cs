// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulTargetConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the configurations.
        /// </summary>
        [NameInMap("TargetConfigs")]
        [Validation(Required=false)]
        public List<DescribeVulTargetConfigResponseBodyTargetConfigs> TargetConfigs { get; set; }
        public class DescribeVulTargetConfigResponseBodyTargetConfigs : TeaModel {
            /// <summary>
            /// Indicates whether the vulnerability scan feature is enabled for the server.
            /// 
            /// *   **off**: disabled
            /// *   **on**: enabled
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// Indicates whether the vulnerability scan feature is enabled for all servers. Valid values:
            /// 
            /// *   **off**: disabled
            /// *   **on**: enabled
            /// </summary>
            [NameInMap("OverAllConfig")]
            [Validation(Required=false)]
            public string OverAllConfig { get; set; }

            /// <summary>
            /// The type of the vulnerability. Valid values:
            /// 
            /// *   **cve**: Linux software vulnerability
            /// *   **sys**: Windows system vulnerability
            /// *   **cms**: Web-CMS vulnerability
            /// *   **emg**: urgent vulnerability
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
