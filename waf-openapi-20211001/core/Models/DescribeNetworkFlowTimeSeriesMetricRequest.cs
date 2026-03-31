// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTimeSeriesMetricRequest : TeaModel {
        /// <summary>
        /// <para>Specifies filtering conditions. Multiple filter parameters use AND logic.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public DescribeNetworkFlowTimeSeriesMetricRequestFilter Filter { get; set; }
        public class DescribeNetworkFlowTimeSeriesMetricRequestFilter : TeaModel {
            /// <summary>
            /// <para>The list of filter conditions. Each node describes a filter condition.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<DescribeNetworkFlowTimeSeriesMetricRequestFilterConditions> Conditions { get; set; }
            public class DescribeNetworkFlowTimeSeriesMetricRequestFilterConditions : TeaModel {
                /// <summary>
                /// <para>The filter fields. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>matched_host</description></item>
                /// <item><description>cluster</description></item>
                /// </list>
                /// <para>For details, see the <b>Filter fields (Key)</b> section below.</para>
                /// 
                /// <b>Example:</b>
                /// <para>matched_host</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The filter operator. For details, see the <b>Filter operators (OpValue)</b> section below.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("OpValue")]
                [Validation(Required=false)]
                public string OpValue { get; set; }

                /// <summary>
                /// <para>The filter content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.waf-top</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public object Values { get; set; }

            }

            /// <summary>
            /// <para>Specifies the date range for the query.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeNetworkFlowTimeSeriesMetricRequestFilterDateRange DateRange { get; set; }
            public class DescribeNetworkFlowTimeSeriesMetricRequestFilterDateRange : TeaModel {
                /// <summary>
                /// <para>End time of the query range (Unix timestamp, seconds).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>Start time of the query range (Unix timestamp, seconds).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The Web Application Firewall (WAF) instance ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/140857.html">DescribeInstanceInfo</a> operation to retrieve the WAF instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies the data type to be returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>qps: Returns the queries per second (QPS) processed by WAF. This value is calculated using a peak detection method: QPS is measured every 10 seconds, and the highest value within the specified time range is returned.</description></item>
        /// <item><description>total_requests: Returns the total number of requests processed by WAF.</description></item>
        /// <item><description>top5_status: Returns the top 5 HTTP status codes returned by the WAF to clients, along with their corresponding time series statistics.</description></item>
        /// <item><description>top 5_upstream_status: Returns the top 5 HTTP status codes returned by the origin server to clients, along with their corresponding time series data.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>total_requests</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The region ID of WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: The Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: Outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
