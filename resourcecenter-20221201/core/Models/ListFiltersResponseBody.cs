// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListFiltersResponseBody : TeaModel {
        [NameInMap("DefaultFilterName")]
        [Validation(Required=false)]
        public string DefaultFilterName { get; set; }

        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListFiltersResponseBodyFilters> Filters { get; set; }
        public class ListFiltersResponseBodyFilters : TeaModel {
            [NameInMap("FilterConfiguration")]
            [Validation(Required=false)]
            public string FilterConfiguration { get; set; }

            [NameInMap("FilterName")]
            [Validation(Required=false)]
            public string FilterName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
