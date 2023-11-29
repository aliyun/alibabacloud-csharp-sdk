// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListProjectsShrinkRequest : TeaModel {
        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public string LabelIdsShrink { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        [NameInMap("SinkEndpointTypes")]
        [Validation(Required=false)]
        public string SinkEndpointTypesShrink { get; set; }

        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        [NameInMap("SourceEndpointTypes")]
        [Validation(Required=false)]
        public string SourceEndpointTypesShrink { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string StatusShrink { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("VisibleSubProject")]
        [Validation(Required=false)]
        public bool? VisibleSubProject { get; set; }

    }

}
