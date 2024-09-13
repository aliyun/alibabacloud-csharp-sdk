// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CopySnapshotResponseBody : TeaModel {
        /// <summary>
        /// The list of created snapshots.
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public List<CopySnapshotResponseBodyAllocationId> AllocationId { get; set; }
        public class CopySnapshotResponseBodyAllocationId : TeaModel {
            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The IDs of the instances.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// The success status code.
        /// 
        /// *   **PartSuccess**: partially succeeded.
        /// *   **AllSuccess**: all succeeded.
        /// </summary>
        [NameInMap("BizStatusCode")]
        [Validation(Required=false)]
        public string BizStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of nodes that are not created.
        /// </summary>
        [NameInMap("UnAllocationId")]
        [Validation(Required=false)]
        public List<CopySnapshotResponseBodyUnAllocationId> UnAllocationId { get; set; }
        public class CopySnapshotResponseBodyUnAllocationId : TeaModel {
            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

        }

    }

}
