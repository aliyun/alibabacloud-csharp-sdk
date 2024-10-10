// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class RecordLifecycleActionHeartbeatRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
        /// <para>The time window during which the desired ECS instance stays in a Pending state. When the time window ends, Auto Scaling executes the default action. Valid values: 30 to 21600. Unit: seconds.</para>
        /// <para>After you create a lifecycle hook, you can call this operation to extend the time window during which the desired ECS instance stays in a Pending state. You can also call the <a href="https://help.aliyun.com/document_detail/459335.html">CompleteLifecycleAction</a> operation to remove the desired ECS instance from a Pending state ahead of schedule.</para>
        /// <para>Default value: 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("heartbeatTimeout")]
        [Validation(Required=false)]
        public int? HeartbeatTimeout { get; set; }

        /// <summary>
        /// <para>The action token of the lifecycle hook. You can obtain the token from the details page of the Message Service (MNS) queue specified for the lifecycle hook when the desired ECS instance enters a Pending state.\
        /// You can also call the <a href="https://help.aliyun.com/document_detail/459333.html">DescribeLifecycleActions</a> operation to obtain the action token of the lifecycle hook.\
        /// If you specified an MNS topic for the lifecycle hook, you can obtain the token from the MNS topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F324B880-900E-4968-85DD-81691113****</para>
        /// </summary>
        [NameInMap("lifecycleActionToken")]
        [Validation(Required=false)]
        public string LifecycleActionToken { get; set; }

        /// <summary>
        /// <para>The ID of the lifecycle hook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ash-bp1fxuqyi98w0aib****</para>
        /// </summary>
        [NameInMap("lifecycleHookId")]
        [Validation(Required=false)]
        public string LifecycleHookId { get; set; }

    }

}
