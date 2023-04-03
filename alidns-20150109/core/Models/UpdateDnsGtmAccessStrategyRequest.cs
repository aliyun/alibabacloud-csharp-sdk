// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmAccessStrategyRequest : TeaModel {
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        [NameInMap("DefaultAddrPool")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmAccessStrategyRequestDefaultAddrPool> DefaultAddrPool { get; set; }
        public class UpdateDnsGtmAccessStrategyRequestDefaultAddrPool : TeaModel {
            /// <summary>
            /// The ID of the address pool in the primary address pool group.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The weight of the address pool in the primary address pool group.
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

        }

        /// <summary>
        /// The type of the primary address pool. Valid values:
        /// 
        /// *   IPV4
        /// *   IPV6
        /// *   DOMAIN
        /// </summary>
        [NameInMap("DefaultAddrPoolType")]
        [Validation(Required=false)]
        public string DefaultAddrPoolType { get; set; }

        /// <summary>
        /// Specifies whether to enable scheduling optimization for latency resolution for the primary address pool group. Valid values:
        /// 
        /// *   OPEN: enable
        /// *   CLOSE: disable
        /// </summary>
        [NameInMap("DefaultLatencyOptimization")]
        [Validation(Required=false)]
        public string DefaultLatencyOptimization { get; set; }

        /// <summary>
        /// The load balancing policy of the primary address pool group. Valid values:
        /// 
        /// *   ALL_RR: returns all addresses.
        /// *   RATIO: returns addresses by weight.
        /// </summary>
        [NameInMap("DefaultLbaStrategy")]
        [Validation(Required=false)]
        public string DefaultLbaStrategy { get; set; }

        /// <summary>
        /// The maximum number of addresses returned from the primary address pool group.
        /// </summary>
        [NameInMap("DefaultMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMaxReturnAddrNum { get; set; }

        /// <summary>
        /// The minimum number of available addresses in the primary address pool group.
        /// </summary>
        [NameInMap("DefaultMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMinAvailableAddrNum { get; set; }

        [NameInMap("FailoverAddrPool")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmAccessStrategyRequestFailoverAddrPool> FailoverAddrPool { get; set; }
        public class UpdateDnsGtmAccessStrategyRequestFailoverAddrPool : TeaModel {
            /// <summary>
            /// The ID of the address pool in the secondary address pool group.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The weight of the address pool in the secondary address pool group.
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

        }

        /// <summary>
        /// The type of the secondary address pool. Valid values:
        /// 
        /// *   IPV4
        /// *   IPV6
        /// *   DOMAIN
        /// </summary>
        [NameInMap("FailoverAddrPoolType")]
        [Validation(Required=false)]
        public string FailoverAddrPoolType { get; set; }

        /// <summary>
        /// Specifies whether to enable scheduling optimization for latency resolution for the secondary address pool group. Valid values:
        /// 
        /// *   OPEN: enable
        /// *   CLOSE: disable
        /// </summary>
        [NameInMap("FailoverLatencyOptimization")]
        [Validation(Required=false)]
        public string FailoverLatencyOptimization { get; set; }

        /// <summary>
        /// The load balancing policy of the secondary address pool group. Valid values:
        /// 
        /// *   ALL_RR: returns all addresses.
        /// *   RATIO: returns addresses by weight.
        /// </summary>
        [NameInMap("FailoverLbaStrategy")]
        [Validation(Required=false)]
        public string FailoverLbaStrategy { get; set; }

        /// <summary>
        /// The maximum number of addresses returned from the secondary address pool group.
        /// </summary>
        [NameInMap("FailoverMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMaxReturnAddrNum { get; set; }

        /// <summary>
        /// The minimum number of available addresses in the secondary address pool group.
        /// </summary>
        [NameInMap("FailoverMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMinAvailableAddrNum { get; set; }

        /// <summary>
        /// The language to return some response parameters. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The line codes of source regions. For example: `["default", "drpeng"]` indicates Global and Dr. Peng Telecom & Media Group.
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public string Lines { get; set; }

        /// <summary>
        /// The ID of the access policy.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// The name of the access policy.
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
