// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeChartDataRequest : TeaModel {
        /// <summary>
        /// The ID of the chart.
        /// 
        /// >  You can call the [DescribeChartList](~~DescribeChartList~~) operation to query the ID. This parameter is required if the report version is 1.0.0.
        /// </summary>
        [NameInMap("CharId")]
        [Validation(Required=false)]
        public string CharId { get; set; }

        /// <summary>
        /// The ID of the chart.
        /// 
        /// >  You can call the [DescribeChartList](~~DescribeChartList~~) operation to query the ID. This parameter is required if the report version is 2.0.0.
        /// </summary>
        [NameInMap("ChartId")]
        [Validation(Required=false)]
        public string ChartId { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the security report.
        /// 
        /// >  You can call the [DescribeCustomizeReportList](~~DescribeCustomizeReportList~~) operation to query the ID.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public long? TimeEnd { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public long? TimeStart { get; set; }

    }

}
