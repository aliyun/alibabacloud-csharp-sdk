// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceStatusResponseBody : TeaModel {
        [NameInMap("StrategyNotAvailableNum")]
        [Validation(Required=false)]
        public int? StrategyNotAvailableNum { get; set; }

        [NameInMap("AddrAvailableNum")]
        [Validation(Required=false)]
        public int? AddrAvailableNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SwitchToFailoverStrategyNum")]
        [Validation(Required=false)]
        public int? SwitchToFailoverStrategyNum { get; set; }

        [NameInMap("AddrNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrNotAvailableNum { get; set; }

        [NameInMap("AddrPoolGroupNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrPoolGroupNotAvailableNum { get; set; }

    }

}
