// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAttachRecordsResponseBody : TeaModel {
        /// <summary>
        /// The results of automatically connecting applications on the ECS instance to the application protection feature.
        /// </summary>
        [NameInMap("AccessList")]
        [Validation(Required=false)]
        public List<DescribeAttachRecordsResponseBodyAccessList> AccessList { get; set; }
        public class DescribeAttachRecordsResponseBodyAccessList : TeaModel {
            /// <summary>
            /// The status of connecting applications on the ECS instance to the application protection feature. Valid values:
            /// 
            /// *   **0**: All applications are connected to the application protection feature.
            /// *   **1**: Partial applications are connected to the application protection feature.
            /// *   **2**: Applications failed to be connected to the application protection feature.
            /// *   **3**: Applications are being connected to the application protection feature.
            /// *   **4**: Applications are not connected to the application protection feature.
            /// </summary>
            [NameInMap("AttachState")]
            [Validation(Required=false)]
            public long? AttachState { get; set; }

            /// <summary>
            /// Indicates whether automatic protection is enabled for the applications on the ECS instance. Valid values:
            /// 
            /// *   **ON**: Automatic protection is enabled for the applications on the ECS instance.
            /// *   **OFF**: Automatic protection is disabled for the applications on the ECS instance.
            /// </summary>
            [NameInMap("AttachSwitch")]
            [Validation(Required=false)]
            public string AttachSwitch { get; set; }

            /// <summary>
            /// The UUID of the ECS instance.
            /// </summary>
            [NameInMap("EcsUUID")]
            [Validation(Required=false)]
            public string EcsUUID { get; set; }

            /// <summary>
            /// The message that shows the results of installing the RASP agent on the ECS instance.
            /// </summary>
            [NameInMap("InstallMsg")]
            [Validation(Required=false)]
            public string InstallMsg { get; set; }

            /// <summary>
            /// The status of installing the RASP agent on the ECS instance to enable automatic application connection. Valid values:
            /// 
            /// *   **0**: installed
            /// *   **1**: installing
            /// *   **2**: installation failed
            /// *   **3**: installation timeout
            /// *   **4**: uninstalled
            /// *   **5**: uninstalling
            /// *   **6**: uninstallation failed
            /// *   **7**: uninstallation timeout
            /// </summary>
            [NameInMap("InstallState")]
            [Validation(Required=false)]
            public long? InstallState { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
