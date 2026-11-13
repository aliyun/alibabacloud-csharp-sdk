// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSecurityEventTimeSeriesMetricRequest : TeaModel {
        /// <summary>
        /// <para>The query filter conditions. Multiple filter conditions are connected by the logical AND operator.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public DescribeSecurityEventTimeSeriesMetricRequestFilter Filter { get; set; }
        public class DescribeSecurityEventTimeSeriesMetricRequestFilter : TeaModel {
            /// <summary>
            /// <para>The list of filter conditions. Each node describes a filter condition.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventTimeSeriesMetricRequestFilterConditions> Conditions { get; set; }
            public class DescribeSecurityEventTimeSeriesMetricRequestFilterConditions : TeaModel {
                /// <summary>
                /// <para>The name of the field on which the filter operation is performed. This operation supports all fields.</para>
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
            /// <para>The time range for the query.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeSecurityEventTimeSeriesMetricRequestFilterDateRange DateRange { get; set; }
            public class DescribeSecurityEventTimeSeriesMetricRequestFilterDateRange : TeaModel {
                /// <summary>
                /// <para>The end time of the query. The end time is represented by a UNIX timestamp in seconds.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start time of the query. The data query range cannot exceed the past 30 days. The start time is represented by a UNIX timestamp in seconds.</para>
                /// <remarks>
                /// <h2>The start time must be later than the current time minus 30 days.</h2>
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
        /// <para>Instance ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query instance ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-tl32ast****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The metric used to distinguish the returned data content. Different metrics correspond to different data content. This operation supports the following metrics:</para>
        /// <list type="bullet">
        /// <item><description>mitigated_requests: returns the time series statistics of blocked requests.</description></item>
        /// <item><description>monitored_requests: returns the time series statistics of requests that only hit monitor rules.</description></item>
        /// <item><description>mitigated_requests_group_by_defense_scene: returns data grouped by protection module, recording the time series statistics of hits for each module. A single request may hit multiple modules, so the number of module hits returned by this metric may not match the number of requests.</description></item>
        /// <item><description>mitigated_requests_group_by_block_defense_scene: returns data grouped by protection module, recording the time series statistics of blocked requests for each module. A single request is blocked by only one module, so the statistical count returned by this metric is consistent with the number of requests.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mitigated_requests</para>
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
