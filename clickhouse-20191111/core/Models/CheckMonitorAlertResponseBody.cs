// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckMonitorAlertResponseBody : TeaModel {
        /// <summary>
        /// The parameters that are used to configure the monitoring and alerting feature.
        /// </summary>
        [NameInMap("Parameter")]
        [Validation(Required=false)]
        public string Parameter { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the monitoring and alerting feature is enabled. Valid values:
        /// 
        /// *   **enable**: The monitoring and alerting feature is enabled.
        /// *   **disable**: The monitoring and alerting feature is disabled.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
