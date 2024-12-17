// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeNotificationConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The notification settings.</para>
        /// </summary>
        [NameInMap("NotificationConfigurationModels")]
        [Validation(Required=false)]
        public List<DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModels> NotificationConfigurationModels { get; set; }
        public class DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModels : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the notification recipient. The value is in one of the following formats:</para>
            /// <list type="bullet">
            /// <item><description>If you specify CloudMonitor as the notification recipient, the value is in the acs:ess:{region-id}:{account-id}:cloudmonitor format.</description></item>
            /// <item><description>If you specify a Simple Message Queue (SMQ, formerly MNS) as the notification recipient, the value is in the acs:mns:{region-id}:{account-id}:queue/{queuename} format.</description></item>
            /// <item><description>If you specify an SMQ topic as the notification recipient, the value is in the acs:mns:{region-id}:{account-id}:topic/{topicname} format.</description></item>
            /// </list>
            /// <para>The variables in the preceding value formats have the following meanings:</para>
            /// <list type="bullet">
            /// <item><description>region-id: the region ID of your scaling group.</description></item>
            /// <item><description>account-id: the ID of your Alibaba Cloud account.</description></item>
            /// <item><description>queuename: the name of the SMQ queue.</description></item>
            /// <item><description>topicname: the name of the SMQ topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:mns:cn-beijing:161456884340****:topic/modifyLifecycleHo****</para>
            /// </summary>
            [NameInMap("NotificationArn")]
            [Validation(Required=false)]
            public string NotificationArn { get; set; }

            /// <summary>
            /// <para>The types of the notifications.</para>
            /// </summary>
            [NameInMap("NotificationTypes")]
            [Validation(Required=false)]
            public List<string> NotificationTypes { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp1igpak5ft1flyp****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The time zone of the notification. The value must be in UTC. For example, a value of UTC+8 indicates that the time is 8 hours ahead of Coordinated Universal Time, and a value of UTC-7 indicates that the time is 7 hours behind Coordinated Universal Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UTC+8</para>
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
