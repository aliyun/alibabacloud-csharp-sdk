// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourceGroupMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>Start Time</para>
        /// <para>Supported format:</para>
        /// <list type="bullet">
        /// <item><description>Unix timestamp, representing the number of milliseconds that have elapsed since January 1, 1970.</description></item>
        /// </list>
        /// <para>The interval between BeginTime and EndTime must be 31 days or less.</para>
        /// <para>Default: The current time minus 2 hours, expressed as a millisecond Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593950832000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>End Time</para>
        /// <para>Supported format:</para>
        /// <list type="bullet">
        /// <item><description>Unix timestamp, representing the number of milliseconds that have elapsed since January 1, 1970.</description></item>
        /// </list>
        /// <para>The interval between BeginTime and EndTime must be 31 days or less.</para>
        /// <para>Default: The current time, expressed as a millisecond Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750176000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>The metric name. Available metrics include:</para>
        /// <list type="bullet">
        /// <item><description>CUSpec: Maximum CU capacity of the resource group, in CUs.</description></item>
        /// <item><description>CUUsage: CU usage of the resource group, in CUs.</description></item>
        /// <item><description>CUUtilization: CU utilization of the resource group, in %.</description></item>
        /// <item><description>SlotSpec: Maximum concurrency for resource group scheduling, in slots.</description></item>
        /// <item><description>SlotUsage: Used concurrency for resource group scheduling, in slots.</description></item>
        /// <item><description>SchedulerCUMaxSpec: Maximum CU quota for data computing, in CUs.</description></item>
        /// <item><description>SchedulerCUUsage: CU usage for data computing, in CUs.</description></item>
        /// <item><description>SchedulerCUMinSpec: Minimum guaranteed CUs for data computing, in CUs.</description></item>
        /// <item><description>DataIntegrationCUMaxSpec: Maximum CU quota for Data Integration, in CUs.</description></item>
        /// <item><description>DataIntegrationCUUsage: CU usage for Data Integration, in CUs.</description></item>
        /// <item><description>DataIntegrationCUMinSpec: Minimum guaranteed CUs for Data Integration, in CUs.</description></item>
        /// <item><description>DataServiceCUMaxSpec: Maximum CU quota for dataservice, in CUs.</description></item>
        /// <item><description>DataServiceCUUsage: CU usage for DataService Studio, in CUs.</description></item>
        /// <item><description>DataServiceCUMinSpec: Minimum guaranteed CUs for DataService Studio, in CUs.</description></item>
        /// <item><description>ServerIdeCUMaxSpec: Maximum CU quota for personal development environment, in CUs.</description></item>
        /// <item><description>ServerIdeCUUsage: CU usage for personal development environment, in CUs.</description></item>
        /// <item><description>ServerIdeCUMinSpec: Minimum guaranteed CUs for personal development environment, in CUs.</description></item>
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
        /// <para>Default: 60</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
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
