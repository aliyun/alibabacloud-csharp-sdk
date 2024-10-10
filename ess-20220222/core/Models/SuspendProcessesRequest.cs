// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class SuspendProcessesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The types of the processes that you want to suspend. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>scalein: the scale-in process.</description></item>
        /// <item><description>scaleout: the scale-out process.</description></item>
        /// <item><description>healthcheck: the health check process.</description></item>
        /// <item><description>alarmnotification: the process of executing an event-triggered task.</description></item>
        /// <item><description>scheduledaction: the process of executing a scheduled task.</description></item>
        /// </list>
        /// <para>Presently, Auto Scaling supports suspending the five mentioned process types. In cases where more than five types are specified, Auto Scaling will automatically disregard duplicates and proceed with suspending the unique process types.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Processes")]
        [Validation(Required=false)]
        public List<string> Processes { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
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

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp15oubotmrq11xe****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
