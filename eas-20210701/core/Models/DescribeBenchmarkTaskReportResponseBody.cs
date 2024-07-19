// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeBenchmarkTaskReportResponseBody : TeaModel {
        /// <summary>
        /// If the value of ReportType is set to RAW, the details about the stress testing report are returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// If the value of ReportType is set to Report, the URL of the stress testing report is returned.
        /// </summary>
        [NameInMap("ReportUrl")]
        [Validation(Required=false)]
        public string ReportUrl { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
