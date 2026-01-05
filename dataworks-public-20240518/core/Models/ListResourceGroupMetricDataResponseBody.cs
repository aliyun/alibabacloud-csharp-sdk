// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourceGroupMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Monitoring metric data.</para>
        /// </summary>
        [NameInMap("MetricData")]
        [Validation(Required=false)]
        public ListResourceGroupMetricDataResponseBodyMetricData MetricData { get; set; }
        public class ListResourceGroupMetricDataResponseBodyMetricData : TeaModel {
            /// <summary>
            /// <para>The unique identifier for the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Serverless_res_group_524257424564736_6831777003XXXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The metric name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CUSpec: Maximum CU capacity of the resource group, in CUs.</description></item>
            /// <item><description>CUUsage: CU usage of the resource group, in CUs.</description></item>
            /// <item><description>CUUtilization: CU utilization of the resource group, in %.</description></item>
            /// <item><description>SlotSpec: Maximum number of concurrent slots for resource group scheduling, in slots.</description></item>
            /// <item><description>SlotUsage: Used concurrency for resource group scheduling, in slots.</description></item>
            /// <item><description>SchedulerCUMaxSpec: Maximum CU quota for data computing, in CUs.</description></item>
            /// <item><description>SchedulerCUUsage: CU usage for data computing, in CUs.</description></item>
            /// <item><description>SchedulerCUMinSpec: Minimum guaranteed CUs for data computing, in CUs.</description></item>
            /// <item><description>DataIntegrationCUMaxSpec: Maximum CU quota for Data Integration, in CUs.</description></item>
            /// <item><description>DataIntegrationCUUsage: CU usage for Data Integration, in CUs.</description></item>
            /// <item><description>DataIntegrationCUMinSpec: Minimum guaranteed CUs for Data Integration, in CUs.</description></item>
            /// <item><description>DataServiceCUMaxSpec: Maximum CU quota for DataService Studio, in CUs.</description></item>
            /// <item><description>DataServiceCUUsage: CU usage for DataService Studio, in CUs.</description></item>
            /// <item><description>DataServiceCUMinSpec: Minimum guaranteed CUs for DataService Studio, in CUs.</description></item>
            /// <item><description>ServerIdeCUMaxSpec: Maximum CU quota for personal development environment, in CUs.</description></item>
            /// <item><description>ServerIdeCUUsage: CU usage for personal development environment, in CUs.</description></item>
            /// <item><description>ServerIdeCUMinSpec: Minimum guaranteed CUs for personal development environment, in CUs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSpec</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The list of metric data.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<ListResourceGroupMetricDataResponseBodyMetricDataMetrics> Metrics { get; set; }
            public class ListResourceGroupMetricDataResponseBodyMetricDataMetrics : TeaModel {
                /// <summary>
                /// <para>The timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1761184929633</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The value of the metric data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// <para>The pagination cursor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tSBOXZcAmk+akxRkwRuXnGQEsIDODyd5ulPqgytNTbLp4bhb7fuvz13FXtm87Kfl</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The request ID, used for locating logs and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
