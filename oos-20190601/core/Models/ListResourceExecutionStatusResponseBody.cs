// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListResourceExecutionStatusResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceExecutionStatus")]
        [Validation(Required=false)]
        public List<ListResourceExecutionStatusResponseBodyResourceExecutionStatus> ResourceExecutionStatus { get; set; }
        public class ListResourceExecutionStatusResponseBodyResourceExecutionStatus : TeaModel {
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ExecutionTime")]
            [Validation(Required=false)]
            public string ExecutionTime { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

    }

}
