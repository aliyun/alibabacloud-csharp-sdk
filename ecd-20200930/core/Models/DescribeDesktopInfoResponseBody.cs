// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopInfoResponseBody : TeaModel {
        /// <summary>
        /// The details about the cloud desktops.
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopInfoResponseBodyDesktops> Desktops { get; set; }
        public class DescribeDesktopInfoResponseBodyDesktops : TeaModel {
            /// <summary>
            /// The connection status of the end user. Valid values:
            /// 
            /// *   Connected
            /// *   Disconnected
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// The current version of the cloud desktop.
            /// </summary>
            [NameInMap("CurrentAppVersion")]
            [Validation(Required=false)]
            public string CurrentAppVersion { get; set; }

            /// <summary>
            /// The cloud desktop ID.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The status of the cloud desktop. Valid values:
            /// 
            /// *   Pending
            /// *   Starting
            /// *   Running
            /// *   Stopping
            /// *   Stopped
            /// *   Expired
            /// *   Deleted
            /// *   Failed
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// The flag that is used to manage the cloud desktop.
            /// </summary>
            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public List<string> ManagementFlag { get; set; }

            [NameInMap("NewAppSize")]
            [Validation(Required=false)]
            public long? NewAppSize { get; set; }

            [NameInMap("NewAppVersion")]
            [Validation(Required=false)]
            public string NewAppVersion { get; set; }

            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// The first time when the cloud desktop was started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
