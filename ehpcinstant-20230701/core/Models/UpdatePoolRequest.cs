// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class UpdatePoolRequest : TeaModel {
        /// <summary>
        /// <para>The name of the resource pool.</para>
        /// <list type="bullet">
        /// <item><description><para>The name can be up to 15 characters long.</para>
        /// </description></item>
        /// <item><description><para>The name can contain digits, uppercase letters, lowercase letters, underscores (_), and periods (.).</para>
        /// </description></item>
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
        /// <item><description><para>Valid values: 1 to 99. The default value is 1, which specifies the lowest priority.</para>
        /// </description></item>
        /// <item><description><para>Jobs in a higher-priority resource pool are scheduled before pending jobs in lower-priority pools. A resource pool\&quot;s priority overrides a job\&quot;s priority.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The limits on the resources that a user can use concurrently in the resource pool.</para>
        /// </summary>
        [NameInMap("ResourceLimits")]
        [Validation(Required=false)]
        public UpdatePoolRequestResourceLimits ResourceLimits { get; set; }
        public class UpdatePoolRequestResourceLimits : TeaModel {
            /// <summary>
            /// <para>The maximum number of executor nodes that a user can run concurrently in a resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxExecutorNum")]
            [Validation(Required=false)]
            public int? MaxExecutorNum { get; set; }

        }

        /// <summary>
        /// <para>The ID of the scheduling policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-xxxx</para>
        /// </summary>
        [NameInMap("SchedulingPolicyId")]
        [Validation(Required=false)]
        public string SchedulingPolicyId { get; set; }

    }

}
