// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetDnsGtmAccessModeRequest : TeaModel {
        /// <summary>
        /// The primary/secondary switchover policy for address pool groups. Valid values:
        /// 
        /// *   AUTO: performs automatic switchover between the primary and secondary address pool groups upon failures.
        /// *   DEFAULT: uses the primary address pool group.
        /// *   FAILOVER: uses the secondary address pool group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// The language to return some response parameters. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

    }

}
