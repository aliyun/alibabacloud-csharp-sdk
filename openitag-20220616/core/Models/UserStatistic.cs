// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class UserStatistic : TeaModel {
        [NameInMap("AcceptedMarkItemsCount")]
        [Validation(Required=false)]
        public float? AcceptedMarkItemsCount { get; set; }

        [NameInMap("CheckCount")]
        [Validation(Required=false)]
        public float? CheckCount { get; set; }

        [NameInMap("CheckedAcceptedCount")]
        [Validation(Required=false)]
        public float? CheckedAcceptedCount { get; set; }

        [NameInMap("CheckedAccuracy")]
        [Validation(Required=false)]
        public float? CheckedAccuracy { get; set; }

        [NameInMap("MarkEfficiency")]
        [Validation(Required=false)]
        public float? MarkEfficiency { get; set; }

        [NameInMap("MarkTime")]
        [Validation(Required=false)]
        public float? MarkTime { get; set; }

        [NameInMap("SamplingAccuracy")]
        [Validation(Required=false)]
        public float? SamplingAccuracy { get; set; }

        [NameInMap("SamplingCount")]
        [Validation(Required=false)]
        public float? SamplingCount { get; set; }

        [NameInMap("SamplingErrorCount")]
        [Validation(Required=false)]
        public float? SamplingErrorCount { get; set; }

        [NameInMap("TotalMarkItemsCount")]
        [Validation(Required=false)]
        public float? TotalMarkItemsCount { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
