// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectSpineMRIResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectSpineMRIResponseBodyData Data { get; set; }
        public class DetectSpineMRIResponseBodyData : TeaModel {
            [NameInMap("Discs")]
            [Validation(Required=false)]
            public List<DetectSpineMRIResponseBodyDataDiscs> Discs { get; set; }
            public class DetectSpineMRIResponseBodyDataDiscs : TeaModel {
                [NameInMap("Disease")]
                [Validation(Required=false)]
                public string Disease { get; set; }

                [NameInMap("Identification")]
                [Validation(Required=false)]
                public string Identification { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public List<float?> Location { get; set; }

            }

            [NameInMap("Vertebras")]
            [Validation(Required=false)]
            public List<DetectSpineMRIResponseBodyDataVertebras> Vertebras { get; set; }
            public class DetectSpineMRIResponseBodyDataVertebras : TeaModel {
                [NameInMap("Disease")]
                [Validation(Required=false)]
                public string Disease { get; set; }

                [NameInMap("Identification")]
                [Validation(Required=false)]
                public string Identification { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public List<float?> Location { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
