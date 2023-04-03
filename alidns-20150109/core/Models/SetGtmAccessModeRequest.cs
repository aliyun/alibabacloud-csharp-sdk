// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetGtmAccessModeRequest : TeaModel {
        /// <summary>
        /// The target access policy of the GTM instance. Valid values:
        /// 
        /// *   **AUTO**: Automatic switch
        /// *   **DEFAULT**: Default address pool
        /// *   **FAILOVER**: Failover address pool
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// The language used by the user.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the access policy.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

    }

}
