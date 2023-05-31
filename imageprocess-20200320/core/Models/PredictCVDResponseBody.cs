// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class PredictCVDResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PredictCVDResponseBodyData Data { get; set; }
        public class PredictCVDResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public PredictCVDResponseBodyDataLesion Lesion { get; set; }
            public class PredictCVDResponseBodyDataLesion : TeaModel {
                [NameInMap("CVDProbability")]
                [Validation(Required=false)]
                public float? CVDProbability { get; set; }

                [NameInMap("FeatureScore")]
                [Validation(Required=false)]
                public PredictCVDResponseBodyDataLesionFeatureScore FeatureScore { get; set; }
                public class PredictCVDResponseBodyDataLesionFeatureScore : TeaModel {
                    [NameInMap("AortaCalciumScore")]
                    [Validation(Required=false)]
                    public List<double?> AortaCalciumScore { get; set; }

                    [NameInMap("AortaCalciumVolume")]
                    [Validation(Required=false)]
                    public List<double?> AortaCalciumVolume { get; set; }

                    [NameInMap("AscAoMaxDiam")]
                    [Validation(Required=false)]
                    public List<double?> AscAoMaxDiam { get; set; }

                    [NameInMap("AscendAortaLength")]
                    [Validation(Required=false)]
                    public List<double?> AscendAortaLength { get; set; }

                    [NameInMap("CardioThoracicRatio")]
                    [Validation(Required=false)]
                    public List<double?> CardioThoracicRatio { get; set; }

                    [NameInMap("CoronaryCalciumScore")]
                    [Validation(Required=false)]
                    public List<double?> CoronaryCalciumScore { get; set; }

                    [NameInMap("CoronaryCalciumVol")]
                    [Validation(Required=false)]
                    public List<double?> CoronaryCalciumVol { get; set; }

                    [NameInMap("DeepFeature")]
                    [Validation(Required=false)]
                    public List<double?> DeepFeature { get; set; }

                    [NameInMap("EatHUMean")]
                    [Validation(Required=false)]
                    public List<double?> EatHUMean { get; set; }

                    [NameInMap("EatHUSTD")]
                    [Validation(Required=false)]
                    public List<double?> EatHUSTD { get; set; }

                    [NameInMap("EatVolume")]
                    [Validation(Required=false)]
                    public List<double?> EatVolume { get; set; }

                    [NameInMap("LeftLungLowattRatio")]
                    [Validation(Required=false)]
                    public List<double?> LeftLungLowattRatio { get; set; }

                    [NameInMap("MyoEpiRatio")]
                    [Validation(Required=false)]
                    public List<double?> MyoEpiRatio { get; set; }

                    [NameInMap("RightLungLowattRatio")]
                    [Validation(Required=false)]
                    public List<double?> RightLungLowattRatio { get; set; }

                }

                [NameInMap("ResultURL")]
                [Validation(Required=false)]
                public List<string> ResultURL { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
