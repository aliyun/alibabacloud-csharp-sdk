// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class BindLeaderInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hgpostcn-cn-uqm3316l1004</para>
        /// </summary>
        [NameInMap("leaderInstanceId")]
        [Validation(Required=false)]
        public string LeaderInstanceId { get; set; }

    }

}
