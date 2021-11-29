// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterOperationHostResponseBody : TeaModel {
        [NameInMap("ClusterOperationHostList")]
        [Validation(Required=false)]
        public ListClusterOperationHostResponseBodyClusterOperationHostList ClusterOperationHostList { get; set; }
        public class ListClusterOperationHostResponseBodyClusterOperationHostList : TeaModel {
            [NameInMap("ClusterOperationHost")]
            [Validation(Required=false)]
            public List<ListClusterOperationHostResponseBodyClusterOperationHostListClusterOperationHost> ClusterOperationHost { get; set; }
            public class ListClusterOperationHostResponseBodyClusterOperationHostListClusterOperationHost : TeaModel {
                public string HostId { get; set; }
                public string HostName { get; set; }
                public string Percentage { get; set; }
                public string Status { get; set; }
            }
        };

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
        public int? TotalCount { get; set; }

    }

}
