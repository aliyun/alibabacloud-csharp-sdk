// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateAlertRuleResponseBody : TeaModel {
        /// <summary>
        /// The ID of the alert rule.
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        /// <summary>
        /// The struct returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
