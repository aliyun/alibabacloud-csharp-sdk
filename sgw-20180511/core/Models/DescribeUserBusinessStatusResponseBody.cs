// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeUserBusinessStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsEnabled")]
        [Validation(Required=false)]
        public bool? IsEnabled { get; set; }

        [NameInMap("IsIndebted")]
        [Validation(Required=false)]
        public bool? IsIndebted { get; set; }

        [NameInMap("IsIndebtedOverdue")]
        [Validation(Required=false)]
        public bool? IsIndebtedOverdue { get; set; }

        [NameInMap("IsRiskControl")]
        [Validation(Required=false)]
        public bool? IsRiskControl { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
