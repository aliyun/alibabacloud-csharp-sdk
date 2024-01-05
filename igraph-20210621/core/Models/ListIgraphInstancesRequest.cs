// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Igraph20210621.Models
{
    public class ListIgraphInstancesRequest : TeaModel {
        [NameInMap("pageContinue")]
        [Validation(Required=false)]
        public string PageContinue { get; set; }

        [NameInMap("pageLimit")]
        [Validation(Required=false)]
        public string PageLimit { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ListIgraphInstancesRequestTags> Tags { get; set; }
        public class ListIgraphInstancesRequestTags : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
