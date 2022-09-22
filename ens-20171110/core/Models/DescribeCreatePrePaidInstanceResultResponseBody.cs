// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCreatePrePaidInstanceResultResponseBody : TeaModel {
        [NameInMap("InstanceCreateResult")]
        [Validation(Required=false)]
        public DescribeCreatePrePaidInstanceResultResponseBodyInstanceCreateResult InstanceCreateResult { get; set; }
        public class DescribeCreatePrePaidInstanceResultResponseBodyInstanceCreateResult : TeaModel {
            [NameInMap("InstanceCreateStatus")]
            [Validation(Required=false)]
            public string InstanceCreateStatus { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
