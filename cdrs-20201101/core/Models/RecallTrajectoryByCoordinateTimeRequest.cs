// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class RecallTrajectoryByCoordinateTimeRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OutputIdCount")]
        [Validation(Required=false)]
        public int? OutputIdCount { get; set; }

        [NameInMap("OutputIdTypeList")]
        [Validation(Required=false)]
        public List<string> OutputIdTypeList { get; set; }

        [NameInMap("PointList")]
        [Validation(Required=false)]
        public List<RecallTrajectoryByCoordinateTimeRequestPointList> PointList { get; set; }
        public class RecallTrajectoryByCoordinateTimeRequestPointList : TeaModel {
            [NameInMap("DeltaDistance")]
            [Validation(Required=false)]
            public float? DeltaDistance { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public float? Latitude { get; set; }

            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public float? Longitude { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
