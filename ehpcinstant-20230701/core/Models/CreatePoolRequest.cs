// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class CreatePoolRequest : TeaModel {
        /// <summary>
        /// <para>The resource pool name.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 15 characters in length.</description></item>
        /// <item><description>The name can contain digits, uppercase letters, lowercase letters, underscores (_), and periods (.).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PoolTest</para>
        /// </summary>
        [NameInMap("PoolName")]
        [Validation(Required=false)]
        public string PoolName { get; set; }

        /// <summary>
        /// <para>The priority of the resource pool.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 99. Default value: 1, which indicates the lowest priority.</description></item>
        /// <item><description>Jobs submitted to a resource pool with a higher priority value are scheduled before pending jobs in a resource pool with a lower priority value. The priority of a resource pool takes precedence over the priority of a job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The resource quota limits for concurrent usage allowed for a user within a resource pool.</para>
        /// </summary>
        [NameInMap("ResourceLimits")]
        [Validation(Required=false)]
        public CreatePoolRequestResourceLimits ResourceLimits { get; set; }
        public class CreatePoolRequestResourceLimits : TeaModel {
            /// <summary>
            /// <para>The maximum number of executor nodes that a user can concurrently run within a resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxExecutorNum")]
            [Validation(Required=false)]
            public int? MaxExecutorNum { get; set; }

        }

        /// <summary>
        /// <para>The scheduling policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-xxx</para>
        /// </summary>
        [NameInMap("SchedulingPolicyId")]
        [Validation(Required=false)]
        public string SchedulingPolicyId { get; set; }

    }

}
