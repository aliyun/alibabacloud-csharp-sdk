// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductComponentVersionsRequest : TeaModel {
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("releaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

        [NameInMap("sortDirect")]
        [Validation(Required=false)]
        public string SortDirect { get; set; }

        [NameInMap("sortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

    }

}
