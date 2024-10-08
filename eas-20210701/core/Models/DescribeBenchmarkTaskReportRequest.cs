// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeBenchmarkTaskReportRequest : TeaModel {
        /// <summary>
        /// <para>The report type of the stress testing task. Valid values: RAW and Report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>report</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

    }

}
