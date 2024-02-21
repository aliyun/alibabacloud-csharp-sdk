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
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("OperationId")]
                [Validation(Required=false)]
                public string OperationId { get; set; }

                [NameInMap("OperationName")]
                [Validation(Required=false)]
                public string OperationName { get; set; }

                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public string Percentage { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
        public int? TotalCount { get; set; }

    }

}
