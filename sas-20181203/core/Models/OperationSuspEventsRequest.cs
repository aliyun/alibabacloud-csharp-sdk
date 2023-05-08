// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperationSuspEventsRequest : TeaModel {
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// WB01014029
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// Handles multiple exceptions at a time.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("SubOperation")]
        [Validation(Required=false)]
        public string SubOperation { get; set; }

        /// <summary>
        /// OperationSuspEvents
        /// </summary>
        [NameInMap("SuspiciousEventIds")]
        [Validation(Required=false)]
        public string SuspiciousEventIds { get; set; }

        [NameInMap("WarnType")]
        [Validation(Required=false)]
        public string WarnType { get; set; }

    }

}
