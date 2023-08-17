// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The states of clusters. Valid values:
        /// 
        /// *   **Preparing**: The cluster is being prepared.
        /// *   **Creating**: The cluster is being created.
        /// *   **Restoring**: The cluster is being restored from a backup.
        /// *   **Running**: The cluster is running.
        /// *   **Deleting**: The cluster is being deleted.
        /// *   **ClassChanging**: The cluster configurations are being changed.
        /// *   **NetAddressCreating**: A network connection is being created.
        /// *   **NetAddressDeleting**: A network connection is being released.
        /// *   **NetAddressModifying**: A network connection is being modified.
        /// *   **EngineVersionUpgrading**: The engine version is being updated.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

    }

}
