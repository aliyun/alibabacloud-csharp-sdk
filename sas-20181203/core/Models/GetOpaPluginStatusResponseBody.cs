// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaPluginStatusResponseBody : TeaModel {
        /// <summary>
        /// The installation status of the components that are required for clusters protected by proactive defense for containers.
        /// </summary>
        [NameInMap("InstallStatus")]
        [Validation(Required=false)]
        public List<GetOpaPluginStatusResponseBodyInstallStatus> InstallStatus { get; set; }
        public class GetOpaPluginStatusResponseBodyInstallStatus : TeaModel {
            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// Indicates whether the component is installed. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("InstallStatus")]
            [Validation(Required=false)]
            public bool? InstallStatus { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
