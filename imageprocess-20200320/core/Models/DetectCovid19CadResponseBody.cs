// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectCovid19CadResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectCovid19CadResponseBodyData Data { get; set; }
        public class DetectCovid19CadResponseBodyData : TeaModel {
            [NameInMap("LesionRatio")]
            [Validation(Required=false)]
            public string LesionRatio { get; set; }

            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            [NameInMap("NewProbability")]
            [Validation(Required=false)]
            public string NewProbability { get; set; }

            [NameInMap("NormalProbability")]
            [Validation(Required=false)]
            public string NormalProbability { get; set; }

            [NameInMap("OtherProbability")]
            [Validation(Required=false)]
            public string OtherProbability { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
