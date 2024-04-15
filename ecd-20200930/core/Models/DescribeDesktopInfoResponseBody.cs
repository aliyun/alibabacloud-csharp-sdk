// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopInfoResponseBody : TeaModel {
        /// <summary>
        /// Details of the cloud computers.
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopInfoResponseBodyDesktops> Desktops { get; set; }
        public class DescribeDesktopInfoResponseBodyDesktops : TeaModel {
            /// <summary>
            /// The connection status of the user. Valid values:
            /// 
            /// *   Connected
            /// *   Disconnected
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// The version of the image that is used by the cloud computer.
            /// </summary>
            [NameInMap("CurrentAppVersion")]
            [Validation(Required=false)]
            public string CurrentAppVersion { get; set; }

            /// <summary>
            /// The cloud computer ID.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The status of the cloud computer. Valid values:
            /// 
            /// *   Pending: The cloud computer is being created.
            /// *   Starting: The cloud computer is being started.
            /// *   Running: The cloud computer is running.
            /// *   Stopping: The cloud computer is being stopped.
            /// *   Stopped: The cloud computer is stopped.
            /// *   Expired: The cloud computer is expired.
            /// *   Deleted: The cloud computer is deleted.
            /// *   Failed: Failed to create the cloud computer.
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// The information about flags that are used to manage cloud computers.
            /// </summary>
            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public List<string> ManagementFlag { get; set; }

            /// <summary>
            /// The size of the update package. Unit: KB.
            /// </summary>
            [NameInMap("NewAppSize")]
            [Validation(Required=false)]
            public long? NewAppSize { get; set; }

            /// <summary>
            /// The destination version to which the image of the cloud computer can be updated.
            /// </summary>
            [NameInMap("NewAppVersion")]
            [Validation(Required=false)]
            public string NewAppVersion { get; set; }

            /// <summary>
            /// The description of the destination version to which the image of the cloud computer can be updated.
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// The first time when the cloud computer was started.
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
