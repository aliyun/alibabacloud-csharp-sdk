// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeChartListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of charts.</para>
        /// </summary>
        [NameInMap("ChartList")]
        [Validation(Required=false)]
        public List<DescribeChartListResponseBodyChartList> ChartList { get; set; }
        public class DescribeChartListResponseBodyChartList : TeaModel {
            /// <summary>
            /// <para>The business type name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Overall operation metrics</description></item>
            /// <item><description>Asset operation metrics</description></item>
            /// <item><description>Security alert operation metrics</description></item>
            /// <item><description>Vulnerability operation metrics</description></item>
            /// <item><description>Baseline operation metrics</description></item>
            /// <item><description>Cloud service operation metrics</description></item>
            /// <item><description>Cloud honeypot operation metrics.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Overall Operation Metrics</para>
            /// </summary>
            [NameInMap("BusinessName")]
            [Validation(Required=false)]
            public string BusinessName { get; set; }

            /// <summary>
            /// <para>The business type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INDEX_SECURITY_OVERALL_OPERATION</description></item>
            /// <item><description>INDEX_ASSET_OPERATION</description></item>
            /// <item><description>INDEX_SUSPICIOUS_OPERATION</description></item>
            /// <item><description>INDEX_VUL_OPERATION</description></item>
            /// <item><description>INDEX_BASELINE_CHECK_OPERATION</description></item>
            /// <item><description>INDEX_CLOUD_ASSET_OPERATION</description></item>
            /// <item><description>INDEX_HONEYPOT_RISK_OPERATION.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INDEX_SECURITY_OVERALL_OPERATION</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The chart ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CID_CLOUD_ASSET_SUMMARY</para>
            /// </summary>
            [NameInMap("ChartId")]
            [Validation(Required=false)]
            public string ChartId { get; set; }

            /// <summary>
            /// <para>The chart name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security Score</para>
            /// </summary>
            [NameInMap("ChartName")]
            [Validation(Required=false)]
            public string ChartName { get; set; }

            /// <summary>
            /// <para>The chart type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b>: text</description></item>
            /// <item><description><b>table</b>: table</description></item>
            /// <item><description><b>gauge</b>: gauge chart</description></item>
            /// <item><description><b>pie</b>: pie chart</description></item>
            /// <item><description><b>line</b>: line chart</description></item>
            /// <item><description><b>bar</b>: bar chart</description></item>
            /// <item><description><b>timeBar</b>: timeline bar chart</description></item>
            /// <item><description><b>timeLine</b>: timeline line chart.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("ChartType")]
            [Validation(Required=false)]
            public string ChartType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35B434CC-1615-5937-A04E-A9BC2868DB45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
