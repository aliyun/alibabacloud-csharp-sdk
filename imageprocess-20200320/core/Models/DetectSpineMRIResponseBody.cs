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
                public string Disease { get; set; }
                public string Identification { get; set; }
                public List<string> Location { get; set; }
            }
            [NameInMap("Vertebras")]
            [Validation(Required=false)]
            public List<DetectSpineMRIResponseBodyDataVertebras> Vertebras { get; set; }
            public class DetectSpineMRIResponseBodyDataVertebras : TeaModel {
                public string Disease { get; set; }
                public string Identification { get; set; }
                public List<string> Location { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
