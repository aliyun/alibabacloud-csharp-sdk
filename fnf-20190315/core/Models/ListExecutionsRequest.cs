// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListExecutionsRequest : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StartedTimeBegin")]
        [Validation(Required=false)]
        public string StartedTimeBegin { get; set; }

        [NameInMap("StartedTimeEnd")]
        [Validation(Required=false)]
        public string StartedTimeEnd { get; set; }

        [NameInMap("ExecutionNamePrefix")]
        [Validation(Required=false)]
        public string ExecutionNamePrefix { get; set; }

    }

}
