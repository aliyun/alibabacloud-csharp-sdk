// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeBenchmarkTaskReportRequest : TeaModel {
        /// <summary>
        /// The report type of the stress testing task. Valid values: RAW and Report.
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

    }

}
