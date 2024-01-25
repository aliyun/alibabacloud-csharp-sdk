// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdp20210402.Models
{
    public class ListOperationsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOperationsResponseBodyData> Data { get; set; }
        public class ListOperationsResponseBodyData : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("HasChildOperationNodes")]
            [Validation(Required=false)]
            public bool? HasChildOperationNodes { get; set; }

            [NameInMap("HasOperationTask")]
            [Validation(Required=false)]
            public bool? HasOperationTask { get; set; }

            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            [NameInMap("OperationNodeId")]
            [Validation(Required=false)]
            public string OperationNodeId { get; set; }

            [NameInMap("OperationNodeName")]
            [Validation(Required=false)]
            public int? OperationNodeName { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
