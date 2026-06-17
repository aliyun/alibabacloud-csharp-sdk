// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateCronJobPolicyServerlessRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable no-activity suspension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables the feature.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Disables the feature.</para>
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
        /// <para>The Cron expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 13 * * ?</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the task. Use the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-23T01:01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The maximum number of read-only column store nodes. Valid values: 0 to 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleApRoNumMax")]
        [Validation(Required=false)]
        public string ScaleApRoNumMax { get; set; }

        /// <summary>
        /// <para>The minimum number of read-only column store nodes. Valid values: 0 to 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleApRoNumMin")]
        [Validation(Required=false)]
        public string ScaleApRoNumMin { get; set; }

        /// <summary>
        /// <para>The maximum number of PCUs. The value must be from 1 to 32.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum number of PolarDB Capacity Units (PCUs). The value must be from 0.25 to 32 and must be less than or equal to the value of ScaleMax.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public string ScaleMin { get; set; }

        /// <summary>
        /// <para>The maximum number of read-only nodes. Valid values: 0 to 15. The value must be greater than or equal to the value of ScaleRoNumMin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
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
        /// <para>The period of inactivity in minutes before the cluster is automatically paused. The value must be a multiple of 5 and range from 5 to 1440.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SecondsUntilAutoPause")]
        [Validation(Required=false)]
        public string SecondsUntilAutoPause { get; set; }

        /// <summary>
        /// <para>The CPU utilization percentage that triggers a scale-up. Valid values: 40 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ServerlessRuleCpuEnlargeThreshold")]
        [Validation(Required=false)]
        public string ServerlessRuleCpuEnlargeThreshold { get; set; }

        /// <summary>
        /// <para>The CPU utilization percentage that triggers a scale-down. Valid values: 10 to 100. The value of ServerlessRuleCpuEnlargeThreshold minus the value of this parameter must be 30 or greater.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ServerlessRuleCpuShrinkThreshold")]
        [Validation(Required=false)]
        public string ServerlessRuleCpuShrinkThreshold { get; set; }

        /// <summary>
        /// <para>The scaling sensitivity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>normal: standard</para>
        /// </description></item>
        /// <item><description><para>flexible: flexible</para>
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
        /// <para>The start time of the task. Use the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in Coordinated Universal Time (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-14T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
