// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CompleteLifecycleActionRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request.</para>
        /// <para>You can generate a parameter value from your client to ensure that the value is unique across different requests. The value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The next action to perform after the wait state of the lifecycle hook ends. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CONTINUE: Continues the scale-out activity and adds the ECS instance to the scaling group, or continues the scale-in activity and removes the ECS instance from the scaling group.</description></item>
        /// <item><description>ABANDON: Terminates the scale-out activity and releases the created ECS instance, or continues the scale-in activity and removes the ECS instance from the scaling group.</description></item>
        /// <item><description>ROLLBACK: Rejects the release of the ECS instance and performs a rollback for a scale-in activity. For a scale-out activity, the effect is the same as ABANDON.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the next action after the wait state of the lifecycle hook ends remains the <c>DefaultResult</c> value configured for the lifecycle hook.</para>
        /// <para>If multiple lifecycle hooks exist in the scaling group and are triggered simultaneously, the final next action is determined as follows:</para>
        /// <list type="bullet">
        /// <item><description>For a scale-in activity, when the wait state triggered by an ABANDON or ROLLBACK lifecycle hook ends, the wait states of subsequent lifecycle hooks are ended in advance.</description></item>
        /// <item><description>If the lifecycle hook that suspends the scale-in activity is of the CONTINUE type, or for a scale-out activity, subsequent lifecycle hooks continue to suspend the scaling activity until the wait state triggered by the last lifecycle hook ends. The final next action is determined by the type of the last lifecycle hook that ends the wait state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CONTINUE</para>
        /// </summary>
        [NameInMap("LifecycleActionResult")]
        [Validation(Required=false)]
        public string LifecycleActionResult { get; set; }

        /// <summary>
        /// <para>The identifier of the wait state for the scaling activity. You can obtain this value from the Message Service (MNS) queue or MNS topic specified by the lifecycle hook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaaa-bbbbb-cccc-ddddd</para>
        /// </summary>
        [NameInMap("LifecycleActionToken")]
        [Validation(Required=false)]
        public string LifecycleActionToken { get; set; }

        /// <summary>
        /// <para>The ID of the lifecycle hook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ash-bp14g3ee6bt3sc98****</para>
        /// </summary>
        [NameInMap("LifecycleHookId")]
        [Validation(Required=false)]
        public string LifecycleHookId { get; set; }

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
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
