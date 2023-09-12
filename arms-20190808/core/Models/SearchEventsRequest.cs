// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchEventsRequest : TeaModel {
        /// <summary>
        /// The ID of the alert rule. You can call the SearchAlertRules operation and view the `Id` parameter in the response. For more information, see [SearchAlertRules](~~175825~~).
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        /// <summary>
        /// The type of the alert rule. Valid values:
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
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public int? AlertType { get; set; }

        /// <summary>
        /// The type of the application that is associated with the alert rule. Valid values:
        /// 
        /// *   `TRACE`: application monitoring
        /// *   `RETCODE`: frontend monitoring
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: `1`.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify a UNIX timestamp of the LONG data type, in milliseconds. The default value is the current time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Specifies whether the alert event is triggered. If you do not set this parameter, all alert events are queried. Valid values:
        /// 
        /// *   `1`: The event is triggered.
        /// *   `0`: The event is not triggered.
        /// </summary>
        [NameInMap("IsTrigger")]
        [Validation(Required=false)]
        public int? IsTrigger { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: `10`.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The process identifier (PID) of the application that is associated with the alert rule.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify a UNIX timestamp of the LONG data type, in milliseconds. The default value is 10 minutes before the current time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
