// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePendingMaintenanceActionsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of pending events.
        /// </summary>
        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public List<DescribePendingMaintenanceActionsResponseBodyTypeList> TypeList { get; set; }
        public class DescribePendingMaintenanceActionsResponseBodyTypeList : TeaModel {
            /// <summary>
            /// The number of pending events.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The task type of pending events. Valid values:
            /// 
            /// *   **DatabaseSoftwareUpgrading**: database software upgrades
            /// *   **DatabaseHardwareMaintenance**: hardware maintenance and upgrades
            /// *   **DatabaseStorageUpgrading**: database storage upgrades
            /// *   **DatabaseProxyUpgrading**: minor version upgrades of the proxy
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
