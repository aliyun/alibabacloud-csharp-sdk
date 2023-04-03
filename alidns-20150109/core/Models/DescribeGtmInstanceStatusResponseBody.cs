// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// The number of unavailable addresses.
        /// </summary>
        [NameInMap("AddrNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrNotAvailableNum { get; set; }

        /// <summary>
        /// The number of unavailable address pools.
        /// </summary>
        [NameInMap("AddrPoolNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrPoolNotAvailableNum { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the instance. Valid values:
        /// 
        /// *   ALLOW: Operations on the instance are allowed.
        /// *   DENY: Operations on the instance are not allowed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// List of reasons for an instance status. Valid values:
        /// 
        /// *   INSTANCE_OPERATE_BLACK_LIST: The instance is in the blacklist.
        /// *   BETA_INSTANCE: The instance is in public preview.
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// The number of access policies that are unavailable in the active address pool.
        /// </summary>
        [NameInMap("StrategyNotAvailableNum")]
        [Validation(Required=false)]
        public int? StrategyNotAvailableNum { get; set; }

        /// <summary>
        /// The number of access policies that fail over to the secondary address pool.
        /// </summary>
        [NameInMap("SwitchToFailoverStrategyNum")]
        [Validation(Required=false)]
        public int? SwitchToFailoverStrategyNum { get; set; }

    }

}
