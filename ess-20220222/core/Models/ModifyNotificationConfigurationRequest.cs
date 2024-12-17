// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyNotificationConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the notification recipient. The following list describes the value formats of this parameter:</para>
        /// <list type="bullet">
        /// <item><description>If you specify CloudMonitor as the notification recipient, specify the value in the <c>acs:ess:{region-id}:{account-id}:cloudmonitor</c> format.</description></item>
        /// <item><description>If you specify a Simple Message Queue (SMQ) queue as the notification recipient, specify the value in the <c>acs:mns:{region-id}:{account-id}:queue/{queuename}</c> format.</description></item>
        /// <item><description>If you specify an SMQ topic as the notification recipient, specify the value in the <c>acs:mns:{region-id}:{account-id}:topic/{topicname}</c> format.</description></item>
        /// </list>
        /// <para>The variables in the preceding value formats have the following meanings:</para>
        /// <list type="bullet">
        /// <item><description>region-id: the region ID of your scaling group.</description></item>
        /// <item><description>account-id: the ID of your Alibaba Cloud account.</description></item>
        /// <item><description>queuename: the name of the SMQ queue.</description></item>
        /// <item><description>topicname: the name of the SMQ topic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ess:cn-beijing:161456884340****:cloudmonitor</para>
        /// </summary>
        [NameInMap("NotificationArn")]
        [Validation(Required=false)]
        public string NotificationArn { get; set; }

        /// <summary>
        /// <para>The event types.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NotificationTypes")]
        [Validation(Required=false)]
        public List<string> NotificationTypes { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1igpak5ft1flyp****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The time zone of the notification. Specify the value in UTC. For example, a value of UTC+8 specifies that the time is 8 hours ahead of Coordinated Universal Time, and a value of UTC-7 specifies that the time is 7 hours behind Coordinated Universal Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTC+8</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
