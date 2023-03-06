// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListSnapshotReposByInstanceIdResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListSnapshotReposByInstanceIdResponseBodyResult> Result { get; set; }
        public class ListSnapshotReposByInstanceIdResponseBodyResult : TeaModel {
            /// <summary>
            /// Reference instance ID.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The address of the repository.
            /// </summary>
            [NameInMap("repoPath")]
            [Validation(Required=false)]
            public string RepoPath { get; set; }

            /// <summary>
            /// Reference warehouse name.
            /// </summary>
            [NameInMap("snapWarehouse")]
            [Validation(Required=false)]
            public string SnapWarehouse { get; set; }

            /// <summary>
            /// Reference warehouse status. available indicates that it is valid. unavailable indicates that it is invalid.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
