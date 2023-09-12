// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class StopAlertRequest : TeaModel {
        /// <summary>
        /// The ID of the alert rule.
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public string AlertId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
