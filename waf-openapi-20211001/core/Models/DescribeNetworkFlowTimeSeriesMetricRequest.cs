// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTimeSeriesMetricRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for the query. Multiple filter conditions have a logical AND relationship.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public DescribeNetworkFlowTimeSeriesMetricRequestFilter Filter { get; set; }
        public class DescribeNetworkFlowTimeSeriesMetricRequestFilter : TeaModel {
            /// <summary>
            /// <para>A list of filter conditions. Each item describes a filter condition.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<DescribeNetworkFlowTimeSeriesMetricRequestFilterConditions> Conditions { get; set; }
            public class DescribeNetworkFlowTimeSeriesMetricRequestFilterConditions : TeaModel {
                /// <summary>
                /// <para>The field to use for filtering. This parameter supports the following fields:</para>
                /// <list type="bullet">
                /// <item><description><para>matched_host: The protected object.</para>
                /// </description></item>
                /// <item><description><para>cluster: The protection cluster.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>matched_host</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("OpValue")]
                [Validation(Required=false)]
                public string OpValue { get; set; }

                /// <summary>
                /// <para>The filter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.waf-top</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public object Values { get; set; }

            }

            /// <summary>
            /// <para>The time range to query.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeNetworkFlowTimeSeriesMetricRequestFilterDateRange DateRange { get; set; }
            public class DescribeNetworkFlowTimeSeriesMetricRequestFilterDateRange : TeaModel {
                /// <summary>
                /// <para>The end of the time range to query. This value is a UNIX timestamp. Unit: seconds.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start of the time range to query, in UNIX timestamp format. Unit: seconds. The query time range cannot exceed the last 30 days.</para>
                /// <remarks>
                /// <h2>The start time must be within the last 30 days.</h2>
                /// </remarks>
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
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to obtain the instance ID.</para>
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
        /// <para>The metric to query. Different metrics return different data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>qps: The number of requests that WAF processes per second. This is a peak value. WAF calculates a queries per second (QPS) value every 10 seconds and uses the peak value within the specified time granularity as the QPS.</para>
        /// </description></item>
        /// <item><description><para>total_requests: The total number of requests that WAF processes.</para>
        /// </description></item>
        /// <item><description><para>top5_status: The top five response codes that WAF returns to the client and the corresponding time series statistics.</para>
        /// </description></item>
        /// <item><description><para>top5_upstream_status: The top five response codes that the origin server returns to the client and the corresponding time series statistics.</para>
        /// </description></item>
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
        /// <para>The region of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
