// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowTotals : TeaModel {
        /// <summary>
        /// <para>The number of in-flight trajectories (no desired state).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Inflight")]
        [Validation(Required=false)]
        public int? Inflight { get; set; }

        /// <summary>
        /// <para>The number of trajectories that have completed reward scoring (hit reward_score_computed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("Rewarded")]
        [Validation(Required=false)]
        public int? Rewarded { get; set; }

        /// <summary>
        /// <para>The number of trajectories sampled into a batch by the trainer (hit sampled_from_replay_buffer).</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("Sampled")]
        [Validation(Required=false)]
        public int? Sampled { get; set; }

        /// <summary>
        /// <para>The number of trajectories that have completed training (hit actor_parameters_updated).</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("Trained")]
        [Validation(Required=false)]
        public int? Trained { get; set; }

        /// <summary>
        /// <para>The total number of trajectories in the window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("Trajs")]
        [Validation(Required=false)]
        public int? Trajs { get; set; }

        /// <summary>
        /// <para>The number of sample UIDs that appear in the window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("Uids")]
        [Validation(Required=false)]
        public int? Uids { get; set; }

    }

}
