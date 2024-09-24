// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeChartDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the chart.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeChartList~~">DescribeChartList</a> operation to query the ID. This parameter is required if the report version is 1.0.0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CID_ASSET_RISK_TREND</para>
        /// </summary>
        [NameInMap("CharId")]
        [Validation(Required=false)]
        public string CharId { get; set; }

        /// <summary>
        /// <para>The ID of the chart.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeChartList~~">DescribeChartList</a> operation to query the ID. This parameter is required if the report version is 2.0.0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CID_VUL_SUMMARY</para>
        /// </summary>
        [NameInMap("ChartId")]
        [Validation(Required=false)]
        public string ChartId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the security report.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCustomizeReportList~~">DescribeCustomizeReportList</a> operation to query the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>721734</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683862286000</para>
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public long? TimeEnd { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683603086000</para>
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public long? TimeStart { get; set; }

    }

}
