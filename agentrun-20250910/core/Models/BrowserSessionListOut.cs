// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BrowserSessionListOut : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<BrowserSessionOut> Items { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
