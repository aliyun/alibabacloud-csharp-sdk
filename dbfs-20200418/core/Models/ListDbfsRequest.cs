// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListDbfsRequest : TeaModel {
        [NameInMap("FilterKey")]
        [Validation(Required=false)]
        public string FilterKey { get; set; }

        [NameInMap("FilterValue")]
        [Validation(Required=false)]
        public string FilterValue { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
