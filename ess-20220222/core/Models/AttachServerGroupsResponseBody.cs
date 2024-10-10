// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling activity. During the scaling activity, the server group is attached to the scaling group and the existing ECS instances or elastic container instances in the scaling group are added to the server group.</para>
        /// <remarks>
        /// <para> This parameter is returned only if you set ForceAttach to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>asa-bp1c9djwrgxjyk31****</para>
        /// </summary>
        [NameInMap("ScalingActivityId")]
        [Validation(Required=false)]
        public string ScalingActivityId { get; set; }

    }

}
