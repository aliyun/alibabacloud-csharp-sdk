// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectPluginStatusResponseBody : TeaModel {
        /// <summary>
        /// The data returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListFileProtectPluginStatusResponseBodyData> Data { get; set; }
        public class ListFileProtectPluginStatusResponseBodyData : TeaModel {
            /// <summary>
            /// The version of the Security Center agent.
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// The returned code after you install the Security Center agent. Valid values:
            /// 
            /// 1.  0: The installation is successful.
            /// 2.  \\-2: The kernel does not support the installation.
            /// </summary>
            [NameInMap("InstallCode")]
            [Validation(Required=false)]
            public string InstallCode { get; set; }

            /// <summary>
            /// The returned message after you install the Security Center agent.
            /// </summary>
            [NameInMap("InstallMessage")]
            [Validation(Required=false)]
            public string InstallMessage { get; set; }

            /// <summary>
            /// Indicates whether the Security Center agent is installed.
            /// </summary>
            [NameInMap("Installed")]
            [Validation(Required=false)]
            public bool? Installed { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address that is associated with the instance.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address that is associated with the instance.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// Indicates whether the Security Center agent is online. Valid value:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// The type of the operating system. Valid values:
            /// 
            /// *   **windows**: Windows
            /// *   **linux**: Linux
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// Indicates whether the core file monitoring file is supported.
            /// </summary>
            [NameInMap("SupportFile")]
            [Validation(Required=false)]
            public bool? SupportFile { get; set; }

            /// <summary>
            /// The UUID of the asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListFileProtectPluginStatusResponseBodyPageInfo PageInfo { get; set; }
        public class ListFileProtectPluginStatusResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
