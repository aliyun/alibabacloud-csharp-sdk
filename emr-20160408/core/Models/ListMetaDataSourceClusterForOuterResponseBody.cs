// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListMetaDataSourceClusterForOuterResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListMetaDataSourceClusterForOuterResponseBodyItems Items { get; set; }
        public class ListMetaDataSourceClusterForOuterResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListMetaDataSourceClusterForOuterResponseBodyItemsItem> Item { get; set; }
            public class ListMetaDataSourceClusterForOuterResponseBodyItemsItem : TeaModel {
                public string DataSourceId { get; set; }
                public string UserId { get; set; }
                public string ClusterId { get; set; }
            }
        };

    }

}
