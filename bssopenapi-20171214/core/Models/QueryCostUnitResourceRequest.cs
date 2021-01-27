// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCostUnitResourceRequest : TeaModel {
        [NameInMap("OwnerUid")]
        [Validation(Required=false)]
        public long? OwnerUid { get; set; }

        [NameInMap("UnitId")]
        [Validation(Required=false)]
        public long? UnitId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
