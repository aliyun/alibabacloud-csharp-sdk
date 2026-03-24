// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTimeSeriesMetricRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for the query. Multiple filter conditions are combined with a logical AND.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public DescribeNetworkFlowTimeSeriesMetricRequestFilter Filter { get; set; }
        public class DescribeNetworkFlowTimeSeriesMetricRequestFilter : TeaModel {
            /// <summary>
            /// <para>A list of filter conditions. Each item in the list describes a filter condition.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<DescribeNetworkFlowTimeSeriesMetricRequestFilterConditions> Conditions { get; set; }
            public class DescribeNetworkFlowTimeSeriesMetricRequestFilterConditions : TeaModel {
                /// <summary>
                /// <para>The field to use for the filter operation. This API operation supports the following values for Key:</para>
                /// <list type="bullet">
                /// <item><description><para>matched_host</para>
                /// </description></item>
                /// <item><description><para>cluster</para>
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
                /// <para>The query period cannot exceed the last 30 days. The start of the time range to query. This value is a UNIX timestamp. Unit: seconds.</para>
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
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
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
        /// <para>Specifies the type of data to return. Different values for Metric correspond to different data. This API operation supports the following values:</para>
        /// <list type="bullet">
        /// <item><description><para>qps: The number of requests that WAF processes per second. A queries per second (QPS) value is calculated every 10 seconds. The peak QPS value within the specified time granularity is returned.</para>
        /// </description></item>
        /// <item><description><para>total_requests: The total number of requests processed by WAF.</para>
        /// </description></item>
        /// <item><description><para>top5_status: The top five response status codes that WAF returns to the client, and the corresponding time series statistics.</para>
        /// </description></item>
        /// <item><description><para>top 5_upstream_status: The top five response status codes that the origin server returns to the client, and the corresponding time series statistics.</para>
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
        /// <para>The region where the WAF instance resides. Valid values:</para>
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
