// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowStep : TeaModel {
        /// <summary>
        /// <para>The P50 latency in seconds from when trajectories of the step enter the buffer to when batching occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("BufferWaitP50")]
        [Validation(Required=false)]
        public double? BufferWaitP50 { get; set; }

        /// <summary>
        /// <para>The gap duration in seconds, calculated as train started − rollout finished. This represents batching or transfer wait time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GapSec")]
        [Validation(Required=false)]
        public double? GapSec { get; set; }

        /// <summary>
        /// <para>The training idle time in seconds, calculated as the current step training start − the previous step training end. If no marker is present, the value falls back to the current step forward computation start − the previous step optimizer end. A value greater than 0 indicates that the trainer is waiting for data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdleSec")]
        [Validation(Required=false)]
        public double? IdleSec { get; set; }

        /// <summary>
        /// <para>The number of samples (UIDs) consumed by the step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("NSamples")]
        [Validation(Required=false)]
        public int? NSamples { get; set; }

        /// <summary>
        /// <para>The number of trajectories executed in the step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("NTrajs")]
        [Validation(Required=false)]
        public int? NTrajs { get; set; }

        /// <summary>
        /// <para>The latest time when trajectories of the step enter the buffer, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("ProdEndMs")]
        [Validation(Required=false)]
        public long? ProdEndMs { get; set; }

        /// <summary>
        /// <para>The earliest time when trajectories of the step enter the buffer, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("ProdStartMs")]
        [Validation(Required=false)]
        public long? ProdStartMs { get; set; }

        /// <summary>
        /// <para>The P50 latency in seconds from when trajectories of the step start execution to when they enter the buffer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("RolloutP50")]
        [Validation(Required=false)]
        public double? RolloutP50 { get; set; }

        /// <summary>
        /// <para>The rollout duration in seconds, calculated as rollout finished − rollout started. This value is null if no marker is present.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RolloutSec")]
        [Validation(Required=false)]
        public double? RolloutSec { get; set; }

        /// <summary>
        /// <para>The global step ordinal number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public long? Step { get; set; }

        /// <summary>
        /// <para>The forward computation start time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TFwdStartMs")]
        [Validation(Required=false)]
        public long? TFwdStartMs { get; set; }

        /// <summary>
        /// <para>The optimizer end time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TOptEndMs")]
        [Validation(Required=false)]
        public long? TOptEndMs { get; set; }

        /// <summary>
        /// <para>The node operation log &quot;Step N rollout finished&quot; time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TRolloutEndMs")]
        [Validation(Required=false)]
        public long? TRolloutEndMs { get; set; }

        /// <summary>
        /// <para>The node operation log &quot;Step N rollout started&quot; time, in milliseconds (taken from agent_collect_time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TRolloutStartMs")]
        [Validation(Required=false)]
        public long? TRolloutStartMs { get; set; }

        /// <summary>
        /// <para>The node operation log &quot;Step N train finished&quot; time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TTrainEndMs")]
        [Validation(Required=false)]
        public long? TTrainEndMs { get; set; }

        /// <summary>
        /// <para>The node operation log &quot;Step N train started&quot; time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TTrainStartMs")]
        [Validation(Required=false)]
        public long? TTrainStartMs { get; set; }

        /// <summary>
        /// <para>The TRAIN_UPDATE (parameter update) time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TUpdateMs")]
        [Validation(Required=false)]
        public long? TUpdateMs { get; set; }

        /// <summary>
        /// <para>The training duration in seconds. This value is preferentially calculated as train finished − train started. If no marker is present, the value falls back to the duration from batching to training completion. This value is null if global_step is duplicated because of a job restart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TrainSec")]
        [Validation(Required=false)]
        public double? TrainSec { get; set; }

    }

}
