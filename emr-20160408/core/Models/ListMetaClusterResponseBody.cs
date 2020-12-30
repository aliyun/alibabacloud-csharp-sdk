// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListMetaClusterResponseBody : TeaModel {
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
        public ListMetaClusterResponseBodyItems Items { get; set; }
        public class ListMetaClusterResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListMetaClusterResponseBodyItemsItem> Item { get; set; }
            public class ListMetaClusterResponseBodyItemsItem : TeaModel {
                public string Name { get; set; }
                public ListMetaClusterResponseBodyItemsItemSoftwareInfo SoftwareInfo { get; set; }
                public class ListMetaClusterResponseBodyItemsItemSoftwareInfo : TeaModel {
                    [NameInMap("EmrVer")]
                    [Validation(Required=false)]
                    public string EmrVer { get; set; }

                    [NameInMap("ClusterType")]
                    [Validation(Required=false)]
                    public string ClusterType { get; set; }

                }
                public string Id { get; set; }
            }
        };

    }

}
