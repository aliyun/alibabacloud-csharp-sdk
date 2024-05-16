// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetWaitingRoomConfigRequest : TeaModel {
        /// <summary>
        /// The percentage of requests that are allowed to be redirected to the origin server. Valid values: **0** to **100**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AllowPct")]
        [Validation(Required=false)]
        public int? AllowPct { get; set; }

        /// <summary>
        /// The accelerated domain name. You can specify only one domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The length of waiting time to skip after an exit from the queue. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GapTime")]
        [Validation(Required=false)]
        public int? GapTime { get; set; }

        /// <summary>
        /// The maximum length of waiting time in the queue. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaxTimeWait")]
        [Validation(Required=false)]
        public int? MaxTimeWait { get; set; }

        /// <summary>
        /// The regular expression that is used to match URI strings for which the virtual waiting room feature is enabled.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WaitUri")]
        [Validation(Required=false)]
        public string WaitUri { get; set; }

        /// <summary>
        /// The URL of the waiting page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WaitUrl")]
        [Validation(Required=false)]
        public string WaitUrl { get; set; }

    }

}
