// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListSnapshotReposByInstanceIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListSnapshotReposByInstanceIdResponseBodyResult> Result { get; set; }
        public class ListSnapshotReposByInstanceIdResponseBodyResult : TeaModel {
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("repoPath")]
            [Validation(Required=false)]
            public string RepoPath { get; set; }

            [NameInMap("snapWarehouse")]
            [Validation(Required=false)]
            public string SnapWarehouse { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
