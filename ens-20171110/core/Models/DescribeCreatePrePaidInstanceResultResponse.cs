// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCreatePrePaidInstanceResultResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceCreateResult")]
        [Validation(Required=true)]
        public DescribeCreatePrePaidInstanceResultResponseInstanceCreateResult InstanceCreateResult { get; set; }
        public class DescribeCreatePrePaidInstanceResultResponseInstanceCreateResult : TeaModel {
            [NameInMap("InstanceCreateStatus")]
            [Validation(Required=true)]
            public string InstanceCreateStatus { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }
        };

    }

}
