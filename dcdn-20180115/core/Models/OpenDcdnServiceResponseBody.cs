// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class OpenDcdnServiceResponseBody : TeaModel {
        /// <summary>
        /// The metering method of DCDN. Valid values:
        /// 
        /// *   **PayByTraffic**: pay-by-traffic
        /// *   **PayByBandwidth**: pay-by-bandwidth
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
