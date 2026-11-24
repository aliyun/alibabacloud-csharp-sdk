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
        /// <para>The wait time configured in the lifecycle hook for the scaling activity. If the wait state times out, the default execution policy is executed. Valid values: 30 to 21600. Unit: seconds.</para>
        /// <para>After you create a lifecycle hook, you can call this operation to extend the wait time of the ECS instance, or call the <a href="https://help.aliyun.com/document_detail/459335.html">CompleteLifecycleAction</a> operation to end the wait state of the scaling activity in advance.</para>
        /// <para>Default value: 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("heartbeatTimeout")]
        [Validation(Required=false)]
        public int? HeartbeatTimeout { get; set; }

        /// <summary>
        /// <para>The wait state token of the scaling activity. When the instance is suspended, you can obtain this token from the details page of the message received from the MNS queue specified by the lifecycle hook.</para>
        /// <para>You can also call the <a href="https://help.aliyun.com/document_detail/459333.html">DescribeLifecycleActions</a> operation to obtain this token.</para>
        /// <para>Alternatively, you can obtain this value from the MNS topic specified by the lifecycle hook.</para>
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
