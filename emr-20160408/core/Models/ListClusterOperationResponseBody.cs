// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterOperationResponseBody : TeaModel {
        [NameInMap("ClusterOperationList")]
        [Validation(Required=false)]
        public ListClusterOperationResponseBodyClusterOperationList ClusterOperationList { get; set; }
        public class ListClusterOperationResponseBodyClusterOperationList : TeaModel {
            [NameInMap("ClusterOperation")]
            [Validation(Required=false)]
            public List<ListClusterOperationResponseBodyClusterOperationListClusterOperation> ClusterOperation { get; set; }
            public class ListClusterOperationResponseBodyClusterOperationListClusterOperation : TeaModel {
                public string Status { get; set; }
                public string StartTime { get; set; }
                public string Comment { get; set; }
                public string OperationName { get; set; }
                public string OperationId { get; set; }
                public string Duration { get; set; }
                public string Percentage { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
