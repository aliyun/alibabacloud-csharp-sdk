// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class RemoveInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ignored invalid instance information in the request.</para>
        /// </summary>
        [NameInMap("IgnoredInstances")]
        [Validation(Required=false)]
        public List<RemoveInstancesResponseBodyIgnoredInstances> IgnoredInstances { get; set; }
        public class RemoveInstancesResponseBodyIgnoredInstances : TeaModel {
            /// <summary>
            /// <para>The code of the reason why the instance is ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IncorrectInstanceStatus</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The instance ID of the ignored instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-28wt4****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The description of the reason why the instance is ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The current status of instance &quot;i-28wt4****&quot; does not support this action.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asa-bp175o6f6ego3r2j****</para>
        /// </summary>
        [NameInMap("ScalingActivityId")]
        [Validation(Required=false)]
        public string ScalingActivityId { get; set; }

    }

}
