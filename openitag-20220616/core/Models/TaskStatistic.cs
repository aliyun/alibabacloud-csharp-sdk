// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TaskStatistic : TeaModel {
        /// <summary>
        /// <para>Data items that passed</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AcceptItemCount")]
        [Validation(Required=false)]
        public float? AcceptItemCount { get; set; }

        /// <summary>
        /// <para>Quantity abandoned in the check flow</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CheckAbandon")]
        [Validation(Required=false)]
        public float? CheckAbandon { get; set; }

        /// <summary>
        /// <para>Inspection accuracy</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CheckAccuracy")]
        [Validation(Required=false)]
        public float? CheckAccuracy { get; set; }

        /// <summary>
        /// <para>Inspection efficiency (items/hour)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CheckEfficiency")]
        [Validation(Required=false)]
        public float? CheckEfficiency { get; set; }

        /// <summary>
        /// <para>Check accuracy</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CheckedAccuracy")]
        [Validation(Required=false)]
        public float? CheckedAccuracy { get; set; }

        /// <summary>
        /// <para>Number of errors found in the inspection flow</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CheckedError")]
        [Validation(Required=false)]
        public float? CheckedError { get; set; }

        /// <summary>
        /// <para>Number of checks</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CheckedRejectCount")]
        [Validation(Required=false)]
        public float? CheckedRejectCount { get; set; }

        /// <summary>
        /// <para>Discarded data items</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FinalAbandonCount")]
        [Validation(Required=false)]
        public float? FinalAbandonCount { get; set; }

        /// <summary>
        /// <para>Completed data items</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FinishedItemCount")]
        [Validation(Required=false)]
        public long? FinishedItemCount { get; set; }

        /// <summary>
        /// <para>Quantity of completed subtasks</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FinishedSubtaskCount")]
        [Validation(Required=false)]
        public long? FinishedSubtaskCount { get; set; }

        /// <summary>
        /// <para>Annotation efficiency (items/hour)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MarkEfficiency")]
        [Validation(Required=false)]
        public float? MarkEfficiency { get; set; }

        /// <summary>
        /// <para>Quantity of corrections made during pre-annotation</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("PreMarkFixedCount")]
        [Validation(Required=false)]
        public float? PreMarkFixedCount { get; set; }

        /// <summary>
        /// <para>Sampling accuracy</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SampledAccuracy")]
        [Validation(Required=false)]
        public float? SampledAccuracy { get; set; }

        /// <summary>
        /// <para>Number of sampled fault samples</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SampledErrorCount")]
        [Validation(Required=false)]
        public float? SampledErrorCount { get; set; }

        /// <summary>
        /// <para>Number of samples denied</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SampledRejectCount")]
        [Validation(Required=false)]
        public float? SampledRejectCount { get; set; }

        /// <summary>
        /// <para>Sampling accuracy</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SamplingAccuracy")]
        [Validation(Required=false)]
        public float? SamplingAccuracy { get; set; }

        /// <summary>
        /// <para>Total number of check flow steps</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCheckCount")]
        [Validation(Required=false)]
        public float? TotalCheckCount { get; set; }

        /// <summary>
        /// <para>Total check time (hours)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCheckTime")]
        [Validation(Required=false)]
        public float? TotalCheckTime { get; set; }

        /// <summary>
        /// <para>Total number of checks</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCheckedCount")]
        [Validation(Required=false)]
        public float? TotalCheckedCount { get; set; }

        /// <summary>
        /// <para>Total number of data items</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalItemCount")]
        [Validation(Required=false)]
        public long? TotalItemCount { get; set; }

        /// <summary>
        /// <para>Total time spent in the annotation phase (hours)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalMarkTime")]
        [Validation(Required=false)]
        public float? TotalMarkTime { get; set; }

        /// <summary>
        /// <para>Total sampling quantity</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalSampledCount")]
        [Validation(Required=false)]
        public float? TotalSampledCount { get; set; }

        /// <summary>
        /// <para>Total number of sampled validations</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalSamplingCount")]
        [Validation(Required=false)]
        public float? TotalSamplingCount { get; set; }

        /// <summary>
        /// <para>Total number of subtasks</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalSubtaskCount")]
        [Validation(Required=false)]
        public long? TotalSubtaskCount { get; set; }

        /// <summary>
        /// <para>Total work time (hours)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalWorkTime")]
        [Validation(Required=false)]
        public float? TotalWorkTime { get; set; }

    }

}
