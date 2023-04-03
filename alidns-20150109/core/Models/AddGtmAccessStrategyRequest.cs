// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddGtmAccessStrategyRequest : TeaModel {
        /// <summary>
        /// The line codes of access regions.
        /// </summary>
        [NameInMap("AccessLines")]
        [Validation(Required=false)]
        public string AccessLines { get; set; }

        /// <summary>
        /// The ID of the default address pool.
        /// </summary>
        [NameInMap("DefaultAddrPoolId")]
        [Validation(Required=false)]
        public string DefaultAddrPoolId { get; set; }

        /// <summary>
        /// The ID of the failover address pool.
        /// 
        /// If the failover address pool is not set, pass the **Empty** value.
        /// </summary>
        [NameInMap("FailoverAddrPoolId")]
        [Validation(Required=false)]
        public string FailoverAddrPoolId { get; set; }

        /// <summary>
        /// The ID of the GTM instance for which you want to create an access policy.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The language used by the user.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The name of the access policy.
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
