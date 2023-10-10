/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Grace20220606.Models
{
    public class AnalysisConfig : TeaModel {
        [NameInMap("badThroughputThreshold")]
        [Validation(Required=false)]
        public double? BadThroughputThreshold { get; set; }

        [NameInMap("fullGCFrequentIntervalThreshold")]
        [Validation(Required=false)]
        public double? FullGCFrequentIntervalThreshold { get; set; }

        [NameInMap("highHeapUsageThreshold")]
        [Validation(Required=false)]
        public double? HighHeapUsageThreshold { get; set; }

        [NameInMap("highHumongousUsageThreshold")]
        [Validation(Required=false)]
        public double? HighHumongousUsageThreshold { get; set; }

        [NameInMap("highMetaspaceUsageThreshold")]
        [Validation(Required=false)]
        public double? HighMetaspaceUsageThreshold { get; set; }

        [NameInMap("highOldUsageThreshold")]
        [Validation(Required=false)]
        public double? HighOldUsageThreshold { get; set; }

        [NameInMap("highPromotionThreshold")]
        [Validation(Required=false)]
        public double? HighPromotionThreshold { get; set; }

        [NameInMap("highSysThreshold")]
        [Validation(Required=false)]
        public double? HighSysThreshold { get; set; }

        [NameInMap("longConcurrentThreshold")]
        [Validation(Required=false)]
        public double? LongConcurrentThreshold { get; set; }

        [NameInMap("longPauseThreshold")]
        [Validation(Required=false)]
        public double? LongPauseThreshold { get; set; }

        [NameInMap("lowUsrThreshold")]
        [Validation(Required=false)]
        public double? LowUsrThreshold { get; set; }

        [NameInMap("oldGCFrequentIntervalThreshold")]
        [Validation(Required=false)]
        public double? OldGCFrequentIntervalThreshold { get; set; }

        [NameInMap("smallGenerationThreshold")]
        [Validation(Required=false)]
        public double? SmallGenerationThreshold { get; set; }

        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public AnalysisConfigTimeRange TimeRange { get; set; }
        public class AnalysisConfigTimeRange : TeaModel {
            [NameInMap("end")]
            [Validation(Required=false)]
            public double? End { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public double? Start { get; set; }

        }

        [NameInMap("tooManyOldGCThreshold")]
        [Validation(Required=false)]
        public double? TooManyOldGCThreshold { get; set; }

        [NameInMap("youngGCFrequentIntervalThreshold")]
        [Validation(Required=false)]
        public double? YoungGCFrequentIntervalThreshold { get; set; }

    }

}
