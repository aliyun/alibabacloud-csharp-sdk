// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListTimingSyntheticTasksRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Search")]
        [Validation(Required=false)]
        public ListTimingSyntheticTasksRequestSearch Search { get; set; }
        public class ListTimingSyntheticTasksRequestSearch : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            [NameInMap("OrderField")]
            [Validation(Required=false)]
            public string OrderField { get; set; }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<string> TaskIds { get; set; }

            [NameInMap("TaskTypes")]
            [Validation(Required=false)]
            public List<int?> TaskTypes { get; set; }

        }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTimingSyntheticTasksRequestTags> Tags { get; set; }
        public class ListTimingSyntheticTasksRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
