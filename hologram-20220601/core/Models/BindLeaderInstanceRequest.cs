// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class BindLeaderInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The leader instance ID. The region ID, zone ID, and version of the follower instance must be the same as those of the leader instance. Select the leader instance ID from the list of instances returned by the ListFollowerInstances operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hgpostcn-cn-uqm3316l1004</para>
        /// </summary>
        [NameInMap("leaderInstanceId")]
        [Validation(Required=false)]
        public string LeaderInstanceId { get; set; }

    }

}
