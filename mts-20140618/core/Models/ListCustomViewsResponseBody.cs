// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomViewsResponseBody : TeaModel {
        [NameInMap("CustomViews")]
        [Validation(Required=false)]
        public ListCustomViewsResponseBodyCustomViews CustomViews { get; set; }
        public class ListCustomViewsResponseBodyCustomViews : TeaModel {
            [NameInMap("CustomView")]
            [Validation(Required=false)]
            public List<ListCustomViewsResponseBodyCustomViewsCustomView> CustomView { get; set; }
            public class ListCustomViewsResponseBodyCustomViewsCustomView : TeaModel {
                [NameInMap("CustomViewId")]
                [Validation(Required=false)]
                public string CustomViewId { get; set; }

                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
