// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowStuckItem : TeaModel {
        /// <summary>
        /// <para>The number of idle seconds since NowMs (the descending sort key for the stuck list).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdleSec")]
        [Validation(Required=false)]
        public long? IdleSec { get; set; }

        /// <summary>
        /// <para>The millisecond timestamp of the last event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787293215480</para>
        /// </summary>
        [NameInMap("LastTsMs")]
        [Validation(Required=false)]
        public long? LastTsMs { get; set; }

        /// <summary>
        /// <para>The current milestone: generated but not dispatched, dispatched but not started, started but pending generation, generating, rollout completed pending scoring, scored pending sampling, or sampled pending training.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Generating</para>
        /// </summary>
        [NameInMap("Milestone")]
        [Validation(Required=false)]
        public string Milestone { get; set; }

        /// <summary>
        /// <para>The number of completed generation turns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NTurns")]
        [Validation(Required=false)]
        public int? NTurns { get; set; }

        /// <summary>
        /// <para>The sample UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>321fa56f-e1e5-4eb3-8047-db7a230c9a75</para>
        /// </summary>
        [NameInMap("PromptUid")]
        [Validation(Required=false)]
        public string PromptUid { get; set; }

        /// <summary>
        /// <para>The trajectory index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SampleIndex")]
        [Validation(Required=false)]
        public string SampleIndex { get; set; }

    }

}
