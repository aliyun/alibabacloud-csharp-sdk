// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class ListSnapshotsRequest : TeaModel {
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("repository")]
        [Validation(Required=false)]
        public string Repository { get; set; }

        [NameInMap("snapshot")]
        [Validation(Required=false)]
        public string Snapshot { get; set; }

    }

}
