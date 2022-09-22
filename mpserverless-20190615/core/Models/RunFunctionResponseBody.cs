// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class RunFunctionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        [NameInMap("RuntimeMeta")]
        [Validation(Required=false)]
        public RunFunctionResponseBodyRuntimeMeta RuntimeMeta { get; set; }
        public class RunFunctionResponseBodyRuntimeMeta : TeaModel {
            [NameInMap("BillingDuration")]
            [Validation(Required=false)]
            public int? BillingDuration { get; set; }

            [NameInMap("InvocationDuration")]
            [Validation(Required=false)]
            public int? InvocationDuration { get; set; }

            [NameInMap("MaxMemoryUsage")]
            [Validation(Required=false)]
            public int? MaxMemoryUsage { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

    }

}
