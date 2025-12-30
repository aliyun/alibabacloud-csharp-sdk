// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaQualityAnalysisJobVqaResult : TeaModel {
        [NameInMap("Block")]
        [Validation(Required=false)]
        public MediaQualityAnalysisJobVqaScoreDetail Block { get; set; }

        [NameInMap("Color")]
        [Validation(Required=false)]
        public MediaQualityAnalysisJobVqaScoreDetail Color { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public MediaQualityAnalysisJobVqaScoreDetail Detail { get; set; }

        [NameInMap("Noise")]
        [Validation(Required=false)]
        public MediaQualityAnalysisJobVqaScoreDetail Noise { get; set; }

        [NameInMap("ScoreResult")]
        [Validation(Required=false)]
        public MediaQualityAnalysisJobVqaResultScoreResult ScoreResult { get; set; }
        public class MediaQualityAnalysisJobVqaResultScoreResult : TeaModel {
            [NameInMap("Block")]
            [Validation(Required=false)]
            public MediaQualityAnalysisJobVqaResultScoreResultBlock Block { get; set; }
            public class MediaQualityAnalysisJobVqaResultScoreResultBlock : TeaModel {
                [NameInMap("IntensityValue")]
                [Validation(Required=false)]
                public double? IntensityValue { get; set; }

                [NameInMap("PerceptualScore")]
                [Validation(Required=false)]
                public double? PerceptualScore { get; set; }

            }

            [NameInMap("Color")]
            [Validation(Required=false)]
            public MediaQualityAnalysisJobVqaResultScoreResultColor Color { get; set; }
            public class MediaQualityAnalysisJobVqaResultScoreResultColor : TeaModel {
                [NameInMap("IntensityValue")]
                [Validation(Required=false)]
                public double? IntensityValue { get; set; }

                [NameInMap("PerceptualScore")]
                [Validation(Required=false)]
                public double? PerceptualScore { get; set; }

            }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public MediaQualityAnalysisJobVqaResultScoreResultDetail Detail { get; set; }
            public class MediaQualityAnalysisJobVqaResultScoreResultDetail : TeaModel {
                [NameInMap("IntensityValue")]
                [Validation(Required=false)]
                public double? IntensityValue { get; set; }

                [NameInMap("PerceptualScore")]
                [Validation(Required=false)]
                public double? PerceptualScore { get; set; }

            }

            [NameInMap("Noise")]
            [Validation(Required=false)]
            public MediaQualityAnalysisJobVqaResultScoreResultNoise Noise { get; set; }
            public class MediaQualityAnalysisJobVqaResultScoreResultNoise : TeaModel {
                [NameInMap("IntensityValue")]
                [Validation(Required=false)]
                public double? IntensityValue { get; set; }

                [NameInMap("PerceptualScore")]
                [Validation(Required=false)]
                public double? PerceptualScore { get; set; }

            }

            [NameInMap("Sharp")]
            [Validation(Required=false)]
            public MediaQualityAnalysisJobVqaResultScoreResultSharp Sharp { get; set; }
            public class MediaQualityAnalysisJobVqaResultScoreResultSharp : TeaModel {
                [NameInMap("IntensityValue")]
                [Validation(Required=false)]
                public double? IntensityValue { get; set; }

                [NameInMap("PerceptualScore")]
                [Validation(Required=false)]
                public double? PerceptualScore { get; set; }

            }

        }

        [NameInMap("Sharp")]
        [Validation(Required=false)]
        public MediaQualityAnalysisJobVqaScoreDetail Sharp { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
