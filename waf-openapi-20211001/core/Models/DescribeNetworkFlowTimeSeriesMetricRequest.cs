// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTimeSeriesMetricRequest : TeaModel {
        /// <summary>
        /// <para>The query filter conditions. Multiple filter conditions are combined by using the logical AND operator.</para>
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
                /// <para>The name of the field on which the filter operation is performed. The Key parameter of this operation supports only the following two fields:</para>
                /// <list type="bullet">
                /// <item><description>matched_host: the protected object.</description></item>
                /// <item><description>cluster: the protection cluster.</description></item>
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
                /// <para>The filter values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.waf-top</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public object Values { get; set; }

            }

            /// <summary>
            /// <para>The time range for the query.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeNetworkFlowTimeSeriesMetricRequestFilterDateRange DateRange { get; set; }
            public class DescribeNetworkFlowTimeSeriesMetricRequestFilterDateRange : TeaModel {
                /// <summary>
                /// <para>The end time of the query. The value is a UNIX timestamp in seconds.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start time of the query. The time range for the query cannot exceed the past 30 days. The value is a UNIX timestamp in seconds.</para>
                /// <remarks>
                /// <h2>The start time must be later than 30 days before the current time.</h2>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The metric used to distinguish the returned data content. Different metrics correspond to different data content. This operation supports the following metrics:</para>
        /// <list type="bullet">
        /// <item><description>qps: returns the number of requests processed by WAF per second. The peak calculation method is used. A QPS value is calculated every 10 seconds, and the maximum peak value among multiple values is used as the QPS value within the current statistical time granularity.</description></item>
        /// <item><description>total_requests: returns the total number of requests processed by WAF.</description></item>
        /// <item><description>top5_status: returns the top 5 response codes returned by WAF to the client and the corresponding time series statistics.</description></item>
        /// <item><description>top 5_upstream_status: returns the top 5 response codes returned by the origin server to the client and the corresponding time series statistics.</description></item>
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
        /// <item><description><b>cn-hangzhou</b>: the Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland.</description></item>
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
