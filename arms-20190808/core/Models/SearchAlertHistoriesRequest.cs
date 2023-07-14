// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertHistoriesRequest : TeaModel {
        /// <summary>
        /// The ID of the alert rule. You can call the SearchAlertRules operation and view the `Id` parameter in the response. For more information, see [SearchAlertRules](~~175825~~).
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        /// <summary>
        /// The type of the alert rule. Valid values:
        /// 
        /// *   `1`: a custom alert rule that is used to monitor drill-down data sets
        /// *   `3`: a custom alert rule that is used to monitor tiled data sets
        /// *   `4`: an alert rule that is used to monitor web pages, including the default alert rule for browser monitoring
        /// *   `5`: an alert rule that is used to monitor applications, including the default alert rule for application monitoring
        /// *   `6`: the default alert rule for browser monitoring
        /// *   `7`: the default alert rule for application monitoring
        /// *   `8`: a Tracing Analysis alert rule
        /// *   `101`: a Prometheus alert rule
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public int? AlertType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: `1`.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp of the LONG data type. Unit: milliseconds. The default value is the current time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: `10`.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region. Default value: `cn-hangzhou`.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp of the LONG data type. Unit: milliseconds. The default value is 10 minutes before the current time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
