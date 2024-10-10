// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CompleteLifecycleActionRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The action that you want Auto Scaling to perform after the lifecycle hook times out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CONTINUE: Auto Scaling continues to respond to a scale-in or scale-out request.</description></item>
        /// <item><description>ABANDON: Auto Scaling releases Elastic Compute Service (ECS) instances that are created during scale-out activities or removes ECS instances from the scaling group during scale-in activities.</description></item>
        /// <item><description>ROLLBACK: For scale-in activities, Auto Scaling rejects the requests to release ECS instances but rolls back ECS instances. For scale-out activities, the ROLLBACK setting has the same effect as the ABANDON setting.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, Auto Scaling performs the action that is specified by the <c>DefaultResult</c> parameter after the lifecycle hook times out.</para>
        /// <para>If multiple lifecycle hooks exist in a scaling group and the lifecycle hooks are triggered at the same time, the following rules apply:</para>
        /// <list type="bullet">
        /// <item><description>For scale-in activities, when lifecycle hooks whose LifecycleActionResult parameter is set to ABANDON or ROLLBACK time out, other lifecycle hooks time out ahead of schedule.</description></item>
        /// <item><description>For scale-in and scale-out activities, if you set the LifecycleActionResult parameter for all lifecycle hooks to CONTINUE, Auto Scaling performs the next action only after the last lifecycle hook times out. The action that Auto Scaling performs varies based on the value that you specify for the LifecycleActionResult parameter of the lifecycle hook that last times out.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CONTINUE</para>
        /// </summary>
        [NameInMap("LifecycleActionResult")]
        [Validation(Required=false)]
        public string LifecycleActionResult { get; set; }

        /// <summary>
        /// <para>The token of the lifecycle hook. You can obtain this token by using a Message Service (MNS) queue or an MNS topic that is specified for the lifecycle hook.</para>
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
