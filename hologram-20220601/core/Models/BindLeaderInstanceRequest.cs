// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class BindLeaderInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the leader instance. The follower and leader instances must be in the same region and zone, and have the same version. Obtain this ID by calling the <c>ListFollowerInstances</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hgpostcn-cn-uqm3316l1004</para>
        /// </summary>
        [NameInMap("leaderInstanceId")]
        [Validation(Required=false)]
        public string LeaderInstanceId { get; set; }

    }

}
