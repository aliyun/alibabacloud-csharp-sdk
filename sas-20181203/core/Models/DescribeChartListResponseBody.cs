// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeChartListResponseBody : TeaModel {
        /// <summary>
        /// <para>The charts.</para>
        /// </summary>
        [NameInMap("ChartList")]
        [Validation(Required=false)]
        public List<DescribeChartListResponseBodyChartList> ChartList { get; set; }
        public class DescribeChartListResponseBodyChartList : TeaModel {
            /// <summary>
            /// <para>The name of the business type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Overall Operations Metrics</description></item>
            /// <item><description>Asset Operations Metrics</description></item>
            /// <item><description>Security Alert Operations Metrics</description></item>
            /// <item><description>Vulnerability Operations Metrics</description></item>
            /// <item><description>Baseline Operations Metrics</description></item>
            /// <item><description>Cloud Product Operations Metrics</description></item>
            /// <item><description>Honeypot Operations Metrics</description></item>
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
            /// <item><description>INDEX_HONEYPOT_RISK_OPERATION</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INDEX_SECURITY_OVERALL_OPERATION</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The ID of the chart.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CID_CLOUD_ASSET_SUMMARY</para>
            /// </summary>
            [NameInMap("ChartId")]
            [Validation(Required=false)]
            public string ChartId { get; set; }

            /// <summary>
            /// <para>The name of the chart.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security Score</para>
            /// </summary>
            [NameInMap("ChartName")]
            [Validation(Required=false)]
            public string ChartName { get; set; }

            /// <summary>
            /// <para>The type of the chart. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b></description></item>
            /// <item><description><b>table</b></description></item>
            /// <item><description><b>gauge</b></description></item>
            /// <item><description><b>pie</b></description></item>
            /// <item><description><b>line</b></description></item>
            /// <item><description><b>bar</b></description></item>
            /// <item><description><b>timeBar</b></description></item>
            /// <item><description><b>timeLine</b></description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35B434CC-1615-5937-A04E-A9BC2868DB45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
