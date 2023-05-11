// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// The number of unavailable address pool groups.
        /// </summary>
        [NameInMap("AddrAvailableNum")]
        [Validation(Required=false)]
        public int? AddrAvailableNum { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("AddrNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrNotAvailableNum { get; set; }

        /// <summary>
        /// The number of access policies switched to the secondary address pool group.
        /// </summary>
        [NameInMap("AddrPoolGroupNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrPoolGroupNotAvailableNum { get; set; }

        /// <summary>
        /// The number of access policies that are unavailable in the current active address pool group.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of available addresses.
        /// </summary>
        [NameInMap("StrategyNotAvailableNum")]
        [Validation(Required=false)]
        public int? StrategyNotAvailableNum { get; set; }

        [NameInMap("SwitchToFailoverStrategyNum")]
        [Validation(Required=false)]
        public int? SwitchToFailoverStrategyNum { get; set; }

    }

}
