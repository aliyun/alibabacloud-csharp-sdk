// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingActivityStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the statistical interval. The time follows the ISO 8601 standard and uses UTC time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-18T08:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the metric on which the scaling activity is counted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ScalingActivityStatus: collects statistics on the distribution of scaling activities in different states within a time range.</description></item>
        /// <item><description>ScalingActivityErrorCodes: the distribution of error codes in failed scaling activities within a time range.</description></item>
        /// </list>
        /// <para>Default value: ScalingActivityStatus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ScalingActivityStatus</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

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
        /// <para>The ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-8vbje5pofxxxxxxxx</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The start time of the statistical interval. The time follows the ISO 8601 standard and uses UTC time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-15T08:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
