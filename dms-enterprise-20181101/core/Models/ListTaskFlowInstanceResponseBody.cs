// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowInstanceResponseBody : TeaModel {
        [NameInMap("DAGInstanceList")]
        [Validation(Required=false)]
        public ListTaskFlowInstanceResponseBodyDAGInstanceList DAGInstanceList { get; set; }
        public class ListTaskFlowInstanceResponseBodyDAGInstanceList : TeaModel {
            [NameInMap("DAGInstance")]
            [Validation(Required=false)]
            public List<ListTaskFlowInstanceResponseBodyDAGInstanceListDAGInstance> DAGInstance { get; set; }
            public class ListTaskFlowInstanceResponseBodyDAGInstanceListDAGInstance : TeaModel {
                public string BusinessTime { get; set; }
                public string DagId { get; set; }
                public string DagName { get; set; }
                public string EndTime { get; set; }
                public long? HistoryDagId { get; set; }
                public long? Id { get; set; }
                public string Message { get; set; }
                public string OwnerName { get; set; }
                public int? Status { get; set; }
                public int? TriggerType { get; set; }
            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
