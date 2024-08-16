// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable monthly auto-renewal. The default value is false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// >  If you enable auto-renewal for an instance for which auto-renewal is enabled, an error is reported.
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The renewal duration. Unit: month.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

    }

}
