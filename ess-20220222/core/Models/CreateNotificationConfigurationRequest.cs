// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateNotificationConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The encoding method for the notification content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: no encoding. The content is transmitted in plaintext.</description></item>
        /// <item><description>Base64: Base64 encoding.</description></item>
        /// </list>
        /// <para>Default value: Base64.</para>
        /// <remarks>
        /// <para>The Settings for this parameter are supported only for MNS notification recipients.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("MessageEncoding")]
        [Validation(Required=false)]
        public string MessageEncoding { get; set; }

        /// <summary>
        /// <para>The identifier of the notification recipient. The following notification methods are supported when you configure the Settings for this parameter:</para>
        /// <list type="bullet">
        /// <item><description>Cloud monitoring. Format: <c>acs:ess:{region-id}:{account-id}:cloudmonitor</c>.</description></item>
        /// <item><description>MNS queue. Format: <c>acs:mns:{region-id}:{account-id}:queue/{queuename}</c>.</description></item>
        /// <item><description>MNS topic. Format: <c>acs:mns:{region-id}:{account-id}:topic/{topicname}</c>.</description></item>
        /// </list>
        /// <para>Variables in the formats:</para>
        /// <list type="bullet">
        /// <item><description><c>region-id</c>: the ID of the region where the scaling group resides.</description></item>
        /// <item><description><c>account-id</c>: the Alibaba Cloud account ID. You can invoke the STS GetCallerIdentity operation to obtain the AccountId response parameter, or view it by clicking your profile picture in the upper-right corner of the Alibaba Cloud Management Console.</description></item>
        /// <item><description><c>queuename</c>: the name of the MNS queue.</description></item>
        /// <item><description><c>topicname</c>: the name of the MNS topic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:mns:cn-beijing:161456884340****:queue/modifyLifecycleHo****</para>
        /// </summary>
        [NameInMap("NotificationArn")]
        [Validation(Required=false)]
        public string NotificationArn { get; set; }

        /// <summary>
        /// <para>The types of Auto Scaling events and resource changes for which you want to receive notifications. You can specify multiple values by using a repeated list.</para>
        /// <para>You can invoke the DescribeNotificationTypes operation to query parameter values.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NotificationTypes")]
        [Validation(Required=false)]
        public List<string> NotificationTypes { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the scaling group belongs.</para>
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
        /// <para>The time zone for notifications.
        /// Specify the time zone offset from Coordinated Universal Time (UTC), such as UTC+8 or UTC-7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTC+8</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
