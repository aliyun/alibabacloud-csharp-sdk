// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSupervisonInfoResponseBody : TeaModel {
        /// <summary>
        /// The time of the last system vulnerability scan. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("LatestScanTime")]
        [Validation(Required=false)]
        public long? LatestScanTime { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
