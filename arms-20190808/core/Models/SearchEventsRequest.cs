// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchEventsRequest : TeaModel {
        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public int? AlertType { get; set; }

        /// <summary>
        /// The type of the alert rule. This parameter is not returned. Valid values:
        /// 
        /// *   `1`: custom alert rules to monitor drill-down data sets
        /// *   `3`: custom alert rules to monitor tiled data sets
        /// *   `4`: alert rules to monitor the frontend, including the default frontend alert rules
        /// *   `5`: alert rules to monitor applications, including the default application alert rules
        /// *   `6`: the default frontend alert rules
        /// *   `7`: the default application alert rules
        /// *   `8`: Tracing Analysis alert rules
        /// *   `101`: Prometheus alert rules
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// The ID of the alert rule. You can call the SearchAlertRules operation and view the `Id` parameter in the response. For more information, see [SearchAlertRules](~~175825~~).
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether the alert event is triggered. If you do not set this parameter, all alert events are queried. Valid values:
        /// 
        /// *   `1`: The event is triggered.
        /// *   `0`: The event is not triggered.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The timestamp when the event occurred.
        /// </summary>
        [NameInMap("IsTrigger")]
        [Validation(Required=false)]
        public int? IsTrigger { get; set; }

        /// <summary>
        /// The information about the alert events.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the application that is associated with the alert rule. Valid values:
        /// 
        /// *   `TRACE`: application monitoring
        /// *   `RETCODE`: frontend monitoring
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// Specifies whether the alert event is triggered. If you do not set this parameter, all alert events are queried. Valid values:
        /// 
        /// *   `1`: The event is triggered.
        /// *   `0`: The event is not triggered.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
