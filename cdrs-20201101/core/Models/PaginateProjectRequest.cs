// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class PaginateProjectRequest : TeaModel {
        [NameInMap("CountTotalNum")]
        [Validation(Required=false)]
        public bool? CountTotalNum { get; set; }

        [NameInMap("NameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
