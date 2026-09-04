// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLSample : TeaModel {
        /// <summary>
        /// <para>The detail of the latest event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>actor_parameters_updated</para>
        /// </summary>
        [NameInMap("LatestDetail")]
        [Validation(Required=false)]
        public string LatestDetail { get; set; }

        /// <summary>
        /// <para>The stage of the latest event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TRAIN_UPDATE</para>
        /// </summary>
        [NameInMap("LatestStage")]
        [Validation(Required=false)]
        public string LatestStage { get; set; }

        /// <summary>
        /// <para>The latest sample_status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("LatestStatus")]
        [Validation(Required=false)]
        public string LatestStatus { get; set; }

        /// <summary>
        /// <para>The millisecond timestamp of the latest event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787293215480</para>
        /// </summary>
        [NameInMap("LatestTimestampMs")]
        [Validation(Required=false)]
        public long? LatestTimestampMs { get; set; }

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
        /// <para>The trajectory ordinal number (numeric string).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SampleIndex")]
        [Validation(Required=false)]
        public string SampleIndex { get; set; }

        /// <summary>
        /// <para>The desired state. Valid values: trained (training completed) and empty string (in progress). The current frame does not perform oversampling, so discarded and cancelled do not occur.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trained</para>
        /// </summary>
        [NameInMap("TerminalState")]
        [Validation(Required=false)]
        public string TerminalState { get; set; }

        /// <summary>
        /// <para>The number of trace rows for the trajectory, including B/C type allocations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TraceCount")]
        [Validation(Required=false)]
        public long? TraceCount { get; set; }

    }

}
