// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeLiveSubExperienceMetricDataResponseBody : TeaModel {
        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<DescribeLiveSubExperienceMetricDataResponseBodyMetricList> MetricList { get; set; }
        public class DescribeLiveSubExperienceMetricDataResponseBodyMetricList : TeaModel {
            [NameInMap("AvgScore")]
            [Validation(Required=false)]
            public float? AvgScore { get; set; }

            [NameInMap("MaxScore")]
            [Validation(Required=false)]
            public float? MaxScore { get; set; }

            [NameInMap("MinScore")]
            [Validation(Required=false)]
            public float? MinScore { get; set; }

        }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
