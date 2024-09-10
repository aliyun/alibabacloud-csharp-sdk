// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperationCustomizeReportChartRequest : TeaModel {
        /// <summary>
        /// The ID of the chart that is included in the report. Separate multiple IDs with commas (,).
        /// 
        /// >  You can call the [DescribeChartList](~~DescribeChartList~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChartIds")]
        [Validation(Required=false)]
        public string ChartIds { get; set; }

        /// <summary>
        /// The ID of the report.
        /// 
        /// >  You can call the [DescribeCustomizeReportList](~~DescribeCustomizeReportList~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

    }

}
