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
        /// <item><description>The value can be up to 15 characters in length.</description></item>
        /// <item><description>It can contain digits, uppercase letters, lowercase letters, underscores (_), and dots (.).</description></item>
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
        /// <item><description>You can set a priority in the range of 1 to 99. The default value is 1, which is the lowest priority.</description></item>
        /// <item><description>Jobs submitted to a resource pool with a higher priority level value will be scheduled before pending jobs in a resource pool with a lower priority level value, and the priority level of the resource pool takes precedence over the priority of the job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The quota of resources that users are allowed to concurrently use in a resource pool.</para>
        /// </summary>
        [NameInMap("ResourceLimits")]
        [Validation(Required=false)]
        public UpdatePoolRequestResourceLimits ResourceLimits { get; set; }
        public class UpdatePoolRequestResourceLimits : TeaModel {
            /// <summary>
            /// <para>The maximum number of concurrent execution nodes in a resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("MaxExectorNum")]
            [Validation(Required=false)]
            public int? MaxExectorNum { get; set; }

        }

    }

}
