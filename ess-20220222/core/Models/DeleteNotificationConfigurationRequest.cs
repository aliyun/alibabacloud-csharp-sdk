// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DeleteNotificationConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the notification method. The following list describes the value formats of this parameter:</para>
        /// <list type="bullet">
        /// <item><description>If you use CloudMonitor as the notification party, the value format of this parameter is acs:ess:{region-id}:{account-id}:cloudmonitor.</description></item>
        /// <item><description>If you use an MNS queue as the notification party, the value format of this parameter is acs:mns:{region-id}:{account-id}:queue/{queuename}.</description></item>
        /// <item><description>If you use an MNS topic as the notification party, the value format of this parameter is acs:mns:{region-id}:{account-id}:topic/{topicname}.</description></item>
        /// </list>
        /// <para>The variables in the preceding formats have the following meanings:</para>
        /// <list type="bullet">
        /// <item><description>region-id: the region ID of the scaling group.</description></item>
        /// <item><description>account-id: the ID of the Alibaba Cloud account.</description></item>
        /// <item><description>queuename: the name of the MNS queue.</description></item>
        /// <item><description>topicname: the name of the MNS topic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ess:cn-beijing:161456884340****:cloudmonitor</para>
        /// </summary>
        [NameInMap("NotificationArn")]
        [Validation(Required=false)]
        public string NotificationArn { get; set; }

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
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
