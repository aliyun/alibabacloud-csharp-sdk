// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SyncRecordingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster whose aggregation rule you want to synchronize.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc7a37ee31aea4ed1a059eff8034b****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the region. The destination region can be the same as the source region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of clusters to which you want to synchronize the aggregation rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;cn&quot;:[         &quot;c06ca68cd16f14f52bb07772eda***&quot;,         &quot;c33dd70a0ac184c1b879d807ab2***&quot;,         &quot;c384cf7e4dcb543e6ac8c7d4dd3***&quot;     ],     &quot;us&quot;:[         &quot;ce30f833bc4a04a56a06b070319***&quot;     ],     &quot;jp&quot;:[      ],     &quot;ap&quot;:[      ],     &quot;gov&quot;:[      ],     &quot;finance&quot;:[      ] }</para>
        /// </summary>
        [NameInMap("TargetClusters")]
        [Validation(Required=false)]
        public string TargetClusters { get; set; }

    }

}
