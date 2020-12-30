// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterOperationHostTaskResponseBody : TeaModel {
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

        [NameInMap("ClusterOperationHostTaskList")]
        [Validation(Required=false)]
        public ListClusterOperationHostTaskResponseBodyClusterOperationHostTaskList ClusterOperationHostTaskList { get; set; }
        public class ListClusterOperationHostTaskResponseBodyClusterOperationHostTaskList : TeaModel {
            [NameInMap("ClusterOperationHostTask")]
            [Validation(Required=false)]
            public List<ListClusterOperationHostTaskResponseBodyClusterOperationHostTaskListClusterOperationHostTask> ClusterOperationHostTask { get; set; }
            public class ListClusterOperationHostTaskResponseBodyClusterOperationHostTaskListClusterOperationHostTask : TeaModel {
                public string Status { get; set; }
                public string TaskName { get; set; }
                public string Percentage { get; set; }
                public string TaskId { get; set; }
            }
        };

    }

}
