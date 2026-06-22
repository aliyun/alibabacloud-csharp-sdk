// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperationCustomizeReportChartRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of report chart configurations. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>Call <a href="~~DescribeChartList~~">DescribeChartList</a> to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CID_VUL_SUMMARY,CID_VUL_TREND,CID_VUL_OPERATION_TREND,CID_BASELINE_CHECK_SUMMARY,CID_BASELINE_CHECK_TREND,CID_BASELINE_CHECK_OPERATION_TREND</para>
        /// </summary>
        [NameInMap("ChartIds")]
        [Validation(Required=false)]
        public string ChartIds { get; set; }

        /// <summary>
        /// <para>The report ID.</para>
        /// <remarks>
        /// <para>Call <a href="~~DescribeCustomizeReportList~~">DescribeCustomizeReportList</a> to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

    }

}
