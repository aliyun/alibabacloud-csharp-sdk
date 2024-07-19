// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ReleaseServiceRequest : TeaModel {
        /// <summary>
        /// The traffic state. Valid values:
        /// 
        /// *   standalone: independent traffic.
        /// *   grouping: grouped traffic.
        /// </summary>
        [NameInMap("TrafficState")]
        [Validation(Required=false)]
        public string TrafficState { get; set; }

        /// <summary>
        /// The weight of the canary release. Valid values: 0 to 100.
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
