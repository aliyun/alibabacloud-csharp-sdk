// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceAutoScalerResponseBody : TeaModel {
        [NameInMap("CurrentValues")]
        [Validation(Required=false)]
        public Dictionary<string, object> CurrentValues { get; set; }

        [NameInMap("MaxReplica")]
        [Validation(Required=false)]
        public int? MaxReplica { get; set; }

        [NameInMap("MinReplica")]
        [Validation(Required=false)]
        public int? MinReplica { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public Dictionary<string, object> Strategies { get; set; }

    }

}
