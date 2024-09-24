// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportCustomizeReportRequest : TeaModel {
        /// <summary>
        /// <para>The type of the security report that you want to export. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HTML</b></description></item>
        /// <item><description><b>PDF</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is HTML. PDF is supported only for security reports in version 2.0.0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTML</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>The ID of the security report.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCustomizeReportList~~">DescribeCustomizeReportList</a> operation to query the ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

    }

}
