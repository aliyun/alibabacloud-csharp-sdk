// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateSchedulerxNotificationPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The configuration for the effective time periods of notification channels.</para>
        /// <remarks>
        /// <para> Please see the detailed explanation of this parameter below.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;sendChannel&quot;: &quot;sms,webhook,mail,phone&quot;,
        ///   &quot;timezone&quot;: &quot;UTC+08:00&quot;,
        ///   &quot;webhookIsAtAll&quot;: &quot;false&quot;,
        ///   &quot;timeRanges&quot;: {
        ///     &quot;all&quot;: [
        ///       {
        ///         &quot;startTime&quot;: &quot;08:00&quot;,
        ///         &quot;endTime&quot;: &quot;18:00&quot;,
        ///         &quot;daysOfWeek&quot;: [1, 2, 3, 4, 5]
        ///       }
        ///     ]
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("ChannelTimeRange")]
        [Validation(Required=false)]
        public string ChannelTimeRange { get; set; }

        /// <summary>
        /// <para>The description of the notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monday-Friday only</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the notification policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-weekdays</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

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

    }

}
