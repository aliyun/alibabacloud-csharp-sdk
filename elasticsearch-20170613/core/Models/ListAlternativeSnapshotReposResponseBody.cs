// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAlternativeSnapshotReposResponseBody : TeaModel {
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
        public List<ListAlternativeSnapshotReposResponseBodyResult> Result { get; set; }
        public class ListAlternativeSnapshotReposResponseBodyResult : TeaModel {
            /// <summary>
            /// The ID of the instance.
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

        }

    }

}
