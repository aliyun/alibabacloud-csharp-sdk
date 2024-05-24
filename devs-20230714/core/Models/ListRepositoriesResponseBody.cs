// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ListRepositoriesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Repository> Data { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
