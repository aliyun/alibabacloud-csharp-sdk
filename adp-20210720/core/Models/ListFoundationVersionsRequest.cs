// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListFoundationVersionsRequest : TeaModel {
        [NameInMap("onlyDefault")]
        [Validation(Required=false)]
        public bool? OnlyDefault { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("sortDirect")]
        [Validation(Required=false)]
        public string SortDirect { get; set; }

        [NameInMap("sortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
