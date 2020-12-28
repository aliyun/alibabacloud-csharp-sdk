// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListInvocationStatusResponseBody : TeaModel {
        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        [NameInMap("InvokeInstances")]
        [Validation(Required=false)]
        public List<ListInvocationStatusResponseBodyInvokeInstances> InvokeInstances { get; set; }
        public class ListInvocationStatusResponseBodyInvokeInstances : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceInvokeStatus")]
            [Validation(Required=false)]
            public string InstanceInvokeStatus { get; set; }

        }

    }

}
