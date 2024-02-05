// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20230701.Models
{
    public class ListJobsShrinkRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortByShrink { get; set; }

    }

}
