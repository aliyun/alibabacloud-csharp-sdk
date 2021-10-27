// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GroupInvokeFlowResponseBody : TeaModel {
        [NameInMap("CurrentCount")]
        [Validation(Required=false)]
        public int? CurrentCount { get; set; }

        [NameInMap("GroupInvocationId")]
        [Validation(Required=false)]
        public string GroupInvocationId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
