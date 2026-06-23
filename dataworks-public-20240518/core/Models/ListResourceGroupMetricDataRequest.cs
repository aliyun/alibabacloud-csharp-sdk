// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourceGroupMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The start time.</para>
        /// <para>Supported format: Unix timestamp in milliseconds (the number of milliseconds that have elapsed since January 1, 1970).</para>
        /// <para>The interval between BeginTime and EndTime must be less than or equal to 31 days.</para>
        /// <para>Default: The current time minus 2 hours, expressed as a millisecond Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593950832000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// <para>Supported format: Unix timestamp in milliseconds (the number of milliseconds that have elapsed since January 1, 1970).</para>
        /// <para>The interval between BeginTime and EndTime must be less than or equal to 31 days.</para>
        /// <para>Default: The current time, expressed as a millisecond Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750176000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The number of records to display on each page for paginated queries.</para>
        /// <remarks>
        /// <para>The maximum value of Length for a single request is 1440.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>The metric name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CUSpec: Maximum CU capacity of the resource group, in CUs.</para>
        /// </description></item>
        /// <item><description><para>CUUsage: CU usage of the resource group, in CUs.</para>
        /// </description></item>
        /// <item><description><para>CUUtilization: CU utilization of the resource group, in %.</para>
        /// </description></item>
        /// <item><description><para>SlotSpec: Maximum number of concurrent slots for resource group scheduling, in slots.</para>
        /// </description></item>
        /// <item><description><para>SlotUsage: Used concurrency for resource group scheduling, in slots.</para>
        /// </description></item>
        /// <item><description><para>SchedulerCUMaxSpec: Maximum CU quota for data computing, in CUs.</para>
        /// </description></item>
        /// <item><description><para>SchedulerCUUsage: CU usage for data computing, in CUs.</para>
        /// </description></item>
        /// <item><description><para>SchedulerCUMinSpec: Minimum guaranteed CUs for data computing, in CUs.</para>
        /// </description></item>
        /// <item><description><para>DataIntegrationCUMaxSpec: Maximum CU quota for Data Integration, in CUs.</para>
        /// </description></item>
        /// <item><description><para>DataIntegrationCUUsage: CU usage for Data Integration, in CUs.</para>
        /// </description></item>
        /// <item><description><para>DataIntegrationCUMinSpec: Minimum guaranteed CUs for Data Integration, in CUs.</para>
        /// </description></item>
        /// <item><description><para>DataServiceCUMaxSpec: Maximum CU quota for DataService Studio, in CUs.</para>
        /// </description></item>
        /// <item><description><para>DataServiceCUUsage: CU usage for DataService Studio, in CUs.</para>
        /// </description></item>
        /// <item><description><para>DataServiceCUMinSpec: Minimum guaranteed CUs for DataService Studio, in CUs.</para>
        /// </description></item>
        /// <item><description><para>ServerIdeCUMaxSpec: Maximum CU quota for personal development environment, in CUs.</para>
        /// </description></item>
        /// <item><description><para>ServerIdeCUUsage: CU usage for personal development environment, in CUs.</para>
        /// </description></item>
        /// <item><description><para>ServerIdeCUMinSpec: Minimum guaranteed CUs for personal development environment, in CUs.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUSpec</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The pagination cursor.</para>
        /// <remarks>
        /// <para>If this parameter is not set, the first page of data is retrieved. If a value is returned for this parameter, it indicates that there is a next page. You can use the returned NextToken as a parameter to request the next page of data until it returns Null, which means all data has been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FFqBJBxE8I0PE0IUO6K69k7m2FfyWNNc2qQ9ReUkazhz9VA7dWZKlxBcjUwOV0imSM</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The statistical period for monitoring data.</para>
        /// <para>Value: A multiple of 60.</para>
        /// <para>Unit: Seconds.</para>
        /// <para>Default: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The unique identifier for the general-purpose resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Serverless_res_group_524257424564736_6831777003XXXXX</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
