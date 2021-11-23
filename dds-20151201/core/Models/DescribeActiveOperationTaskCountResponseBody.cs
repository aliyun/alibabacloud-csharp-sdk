// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTaskCountResponseBody : TeaModel {
        [NameInMap("NeedPop")]
        [Validation(Required=false)]
        public int? NeedPop { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskCount")]
        [Validation(Required=false)]
        public int? TaskCount { get; set; }

    }

}
