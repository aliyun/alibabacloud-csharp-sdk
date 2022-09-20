// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TaskStatistic : TeaModel {
        [NameInMap("AcceptItemCount")]
        [Validation(Required=false)]
        public float? AcceptItemCount { get; set; }

        [NameInMap("CheckAbandon")]
        [Validation(Required=false)]
        public float? CheckAbandon { get; set; }

        [NameInMap("CheckAccuracy")]
        [Validation(Required=false)]
        public float? CheckAccuracy { get; set; }

        [NameInMap("CheckEfficiency")]
        [Validation(Required=false)]
        public float? CheckEfficiency { get; set; }

        [NameInMap("CheckedAccuracy")]
        [Validation(Required=false)]
        public float? CheckedAccuracy { get; set; }

        [NameInMap("CheckedError")]
        [Validation(Required=false)]
        public float? CheckedError { get; set; }

        [NameInMap("CheckedRejectCount")]
        [Validation(Required=false)]
        public float? CheckedRejectCount { get; set; }

        [NameInMap("FinalAbandonCount")]
        [Validation(Required=false)]
        public float? FinalAbandonCount { get; set; }

        [NameInMap("FinishedItemCount")]
        [Validation(Required=false)]
        public long? FinishedItemCount { get; set; }

        [NameInMap("FinishedSubtaskCount")]
        [Validation(Required=false)]
        public long? FinishedSubtaskCount { get; set; }

        [NameInMap("MarkEfficiency")]
        [Validation(Required=false)]
        public float? MarkEfficiency { get; set; }

        [NameInMap("PreMarkFixedCount")]
        [Validation(Required=false)]
        public float? PreMarkFixedCount { get; set; }

        [NameInMap("SampledAccuracy")]
        [Validation(Required=false)]
        public float? SampledAccuracy { get; set; }

        [NameInMap("SampledErrorCount")]
        [Validation(Required=false)]
        public float? SampledErrorCount { get; set; }

        [NameInMap("SampledRejectCount")]
        [Validation(Required=false)]
        public float? SampledRejectCount { get; set; }

        [NameInMap("SamplingAccuracy")]
        [Validation(Required=false)]
        public float? SamplingAccuracy { get; set; }

        [NameInMap("TotalCheckCount")]
        [Validation(Required=false)]
        public float? TotalCheckCount { get; set; }

        [NameInMap("TotalCheckTime")]
        [Validation(Required=false)]
        public float? TotalCheckTime { get; set; }

        [NameInMap("TotalCheckedCount")]
        [Validation(Required=false)]
        public float? TotalCheckedCount { get; set; }

        [NameInMap("TotalItemCount")]
        [Validation(Required=false)]
        public long? TotalItemCount { get; set; }

        [NameInMap("TotalMarkTime")]
        [Validation(Required=false)]
        public float? TotalMarkTime { get; set; }

        [NameInMap("TotalSampledCount")]
        [Validation(Required=false)]
        public float? TotalSampledCount { get; set; }

        [NameInMap("TotalSamplingCount")]
        [Validation(Required=false)]
        public float? TotalSamplingCount { get; set; }

        [NameInMap("TotalSubtaskCount")]
        [Validation(Required=false)]
        public long? TotalSubtaskCount { get; set; }

        [NameInMap("TotalWorkTime")]
        [Validation(Required=false)]
        public float? TotalWorkTime { get; set; }

    }

}
