// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("AddrNotAvailableNum")]
        [Validation(Required=true)]
        public int? AddrNotAvailableNum { get; set; }

        [NameInMap("AddrPoolGroupNotAvailableNum")]
        [Validation(Required=true)]
        public int? AddrPoolGroupNotAvailableNum { get; set; }

        [NameInMap("SwitchToFailoverStrategyNum")]
        [Validation(Required=true)]
        public int? SwitchToFailoverStrategyNum { get; set; }

        [NameInMap("StrategyNotAvailableNum")]
        [Validation(Required=true)]
        public int? StrategyNotAvailableNum { get; set; }

        [NameInMap("AddrAvailableNum")]
        [Validation(Required=true)]
        public int? AddrAvailableNum { get; set; }

    }

}
