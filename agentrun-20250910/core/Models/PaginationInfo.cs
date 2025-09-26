// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class PaginationInfo : TeaModel {
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
