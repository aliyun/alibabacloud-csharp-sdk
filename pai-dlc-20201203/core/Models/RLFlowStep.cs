// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowStep : TeaModel {
        /// <summary>
        /// <para>The P50 duration in seconds from when trajectories of the step enter the buffer to when they are batched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("BufferWaitP50")]
        [Validation(Required=false)]
        public double? BufferWaitP50 { get; set; }

        /// <summary>
        /// <para>The gap duration in seconds, calculated as train started minus rollout finished, representing batching or transfer wait time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GapSec")]
        [Validation(Required=false)]
        public double? GapSec { get; set; }

        /// <summary>
        /// <para>The idle time in seconds between the training phases of adjacent steps. This value only reflects the time interval and cannot be used alone to determine data waiting or other specific causes.</para>
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
        /// <para>The number of trajectories belonging to the current execution of the step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("NTrajs")]
        [Validation(Required=false)]
        public int? NTrajs { get; set; }

        /// <summary>
        /// <para>The latest time a trajectory of the step enters the buffer in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("ProdEndMs")]
        [Validation(Required=false)]
        public long? ProdEndMs { get; set; }

        /// <summary>
        /// <para>The earliest time a trajectory of the step enters the buffer in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("ProdStartMs")]
        [Validation(Required=false)]
        public long? ProdStartMs { get; set; }

        /// <summary>
        /// <para>The P50 duration in seconds from when trajectories of the step start execution to when they enter the buffer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("RolloutP50")]
        [Validation(Required=false)]
        public double? RolloutP50 { get; set; }

        /// <summary>
        /// <para>The rollout duration in seconds, calculated as rollout finished minus rollout started. This value is empty when no markers are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RolloutSec")]
        [Validation(Required=false)]
        public double? RolloutSec { get; set; }

        /// <summary>
        /// <para>The global step number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public long? Step { get; set; }

        /// <summary>
        /// <para>The start time of the forward computation in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TFwdStartMs")]
        [Validation(Required=false)]
        public long? TFwdStartMs { get; set; }

        /// <summary>
        /// <para>The end time of the optimizer in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TOptEndMs")]
        [Validation(Required=false)]
        public long? TOptEndMs { get; set; }

        /// <summary>
        /// <para>The time of the &quot;Step N rollout finished&quot; entry in the node logs in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TRolloutEndMs")]
        [Validation(Required=false)]
        public long? TRolloutEndMs { get; set; }

        /// <summary>
        /// <para>The observed rollout start time for the current step as a millisecond timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TRolloutStartMs")]
        [Validation(Required=false)]
        public long? TRolloutStartMs { get; set; }

        /// <summary>
        /// <para>The time of the &quot;Step N train finished&quot; entry in the node logs in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TTrainEndMs")]
        [Validation(Required=false)]
        public long? TTrainEndMs { get; set; }

        /// <summary>
        /// <para>The time of the &quot;Step N train started&quot; entry in the node logs in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TTrainStartMs")]
        [Validation(Required=false)]
        public long? TTrainStartMs { get; set; }

        /// <summary>
        /// <para>The time of the TRAIN_UPDATE (parameter update) event in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713</para>
        /// </summary>
        [NameInMap("TUpdateMs")]
        [Validation(Required=false)]
        public long? TUpdateMs { get; set; }

        /// <summary>
        /// <para>The duration of the training phase for the step in seconds. This value is not provided when the training start and end times are unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TrainSec")]
        [Validation(Required=false)]
        public double? TrainSec { get; set; }

    }

}
