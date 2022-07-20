// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribePlayExperienceMetricDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribePlayExperienceMetricDataResponseBodyData> Data { get; set; }
        public class DescribePlayExperienceMetricDataResponseBodyData : TeaModel {
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
