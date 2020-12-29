// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceStatusResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StrategyNotAvailableNum")]
        [Validation(Required=false)]
        public int? StrategyNotAvailableNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SwitchToFailoverStrategyNum")]
        [Validation(Required=false)]
        public int? SwitchToFailoverStrategyNum { get; set; }

        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        [NameInMap("AddrNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrNotAvailableNum { get; set; }

        [NameInMap("AddrPoolNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrPoolNotAvailableNum { get; set; }

    }

}
