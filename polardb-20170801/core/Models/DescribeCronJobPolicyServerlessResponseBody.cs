// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCronJobPolicyServerlessResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCronJobPolicyServerlessResponseBodyItems> Items { get; set; }
        public class DescribeCronJobPolicyServerlessResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>A system parameter. Set the value to <b>ModifyDBClusterServerlessConf</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ModifyDBClusterServerlessConf</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable No-activity Suspension. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled (default)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowShutDown")]
            [Validation(Required=false)]
            public string AllowShutDown { get; set; }

            /// <summary>
            /// <para>The Cron expression for the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 8 * * ?</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-*****************</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The end time of the task. The time is in the yyyy-MM-ddTHH:mm:ssZ format and in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-04T02:25:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12eee3eb-60bd-40ac-a403-218e02eb99c7</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>254752088000354</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The maximum number of read-only IMCI nodes. Valid values: 1 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScaleApRoNumMax")]
            [Validation(Required=false)]
            public string ScaleApRoNumMax { get; set; }

            /// <summary>
            /// <para>The minimum number of read-only IMCI nodes. Valid values: 0 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScaleApRoNumMin")]
            [Validation(Required=false)]
            public string ScaleApRoNumMin { get; set; }

            /// <summary>
            /// <para>The maximum capacity. The value must be from 1 to 32. Unit: PCU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public string ScaleMax { get; set; }

            /// <summary>
            /// <para>The minimum capacity. The value must be from 0.25 to 32 and less than or equal to the maximum capacity. Unit: PolarDB Capacity Unit (PCU).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public string ScaleMin { get; set; }

            /// <summary>
            /// <para>The maximum number of read-only nodes. The value must be greater than or equal to the minimum value. Valid values: 0 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ScaleRoNumMax")]
            [Validation(Required=false)]
            public string ScaleRoNumMax { get; set; }

            /// <summary>
            /// <para>The minimum number of read-only nodes. Valid values: 0 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScaleRoNumMin")]
            [Validation(Required=false)]
            public string ScaleRoNumMin { get; set; }

            /// <summary>
            /// <para>The detection period for No-activity Suspension. The value must be a multiple of 5. Valid values: 5 to 1440. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("SecondsUntilAutoPause")]
            [Validation(Required=false)]
            public string SecondsUntilAutoPause { get; set; }

            /// <summary>
            /// <para>The CPU utilization threshold for scaling up. Valid values: 40 to 100. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("ServerlessRuleCpuEnlargeThreshold")]
            [Validation(Required=false)]
            public string ServerlessRuleCpuEnlargeThreshold { get; set; }

            /// <summary>
            /// <para>The CPU utilization threshold for scaling down. Valid values: 10 to 100. Unit: %. The difference between the scale-up threshold and the scale-down threshold must be 30 or greater.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("ServerlessRuleCpuShrinkThreshold")]
            [Validation(Required=false)]
            public string ServerlessRuleCpuShrinkThreshold { get; set; }

            /// <summary>
            /// <para>The elasticity sensitivity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>normal: standard</para>
            /// </description></item>
            /// <item><description><para>flexible: sensitive</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("ServerlessRuleMode")]
            [Validation(Required=false)]
            public string ServerlessRuleMode { get; set; }

            /// <summary>
            /// <para>The start time of the task. The time is in the <c>yyyy-MM-ddTHH:mmZ</c> format and in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T18:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>working</b>: The scheduled task is running.</para>
            /// </description></item>
            /// <item><description><para><b>finish</b>: The scheduled task is complete.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B7BFB11-C077-4FE3-B051-F69CEB******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
