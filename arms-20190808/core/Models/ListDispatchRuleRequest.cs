// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListDispatchRuleRequest : TeaModel {
        /// <summary>
        /// The name of the notification policy. Fuzzy match is supported.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// *   The type of notification policies to be queried. Valid values: `false` (default): notification policies created in Application Real-Time Monitoring Service (ARMS).
        /// *   `true`: notification policies created in an external system.
        /// 
        /// >  You cannot use the ARMS console to modify the dispatch rules of a notification policy that is created in an external system.
        /// </summary>
        [NameInMap("System")]
        [Validation(Required=false)]
        public bool? System { get; set; }

    }

}
