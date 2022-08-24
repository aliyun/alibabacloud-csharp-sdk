// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class AnalyzeChestVesselResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AnalyzeChestVesselResponseBodyData Data { get; set; }
        public class AnalyzeChestVesselResponseBodyData : TeaModel {
            [NameInMap("AortaInfo")]
            [Validation(Required=false)]
            public AnalyzeChestVesselResponseBodyDataAortaInfo AortaInfo { get; set; }
            public class AnalyzeChestVesselResponseBodyDataAortaInfo : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public List<float?> Area { get; set; }

                [NameInMap("Coordinates")]
                [Validation(Required=false)]
                public List<List<float?>> Coordinates { get; set; }

                [NameInMap("LabelValue")]
                [Validation(Required=false)]
                public long? LabelValue { get; set; }

                [NameInMap("MaxArea")]
                [Validation(Required=false)]
                public float? MaxArea { get; set; }

                [NameInMap("MaxAreaIndex")]
                [Validation(Required=false)]
                public long? MaxAreaIndex { get; set; }

                [NameInMap("MaxDiameter")]
                [Validation(Required=false)]
                public float? MaxDiameter { get; set; }

            }
            [NameInMap("PulmonaryInfo")]
            [Validation(Required=false)]
            public AnalyzeChestVesselResponseBodyDataPulmonaryInfo PulmonaryInfo { get; set; }
            public class AnalyzeChestVesselResponseBodyDataPulmonaryInfo : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public List<float?> Area { get; set; }

                [NameInMap("Coordinates")]
                [Validation(Required=false)]
                public List<List<float?>> Coordinates { get; set; }

                [NameInMap("LabelValue")]
                [Validation(Required=false)]
                public long? LabelValue { get; set; }

                [NameInMap("MaxArea")]
                [Validation(Required=false)]
                public float? MaxArea { get; set; }

                [NameInMap("MaxAreaIndex")]
                [Validation(Required=false)]
                public long? MaxAreaIndex { get; set; }

                [NameInMap("MaxDiameter")]
                [Validation(Required=false)]
                public float? MaxDiameter { get; set; }

                [NameInMap("NearestAortaArea")]
                [Validation(Required=false)]
                public float? NearestAortaArea { get; set; }

            }
            [NameInMap("ResultURL")]
            [Validation(Required=false)]
            public string ResultURL { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
