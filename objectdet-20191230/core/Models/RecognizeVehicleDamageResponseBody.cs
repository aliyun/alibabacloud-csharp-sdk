// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class RecognizeVehicleDamageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVehicleDamageResponseBodyData Data { get; set; }
        public class RecognizeVehicleDamageResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeVehicleDamageResponseBodyDataElements> Elements { get; set; }
            public class RecognizeVehicleDamageResponseBodyDataElements : TeaModel {
                public string Type { get; set; }
                public List<string> Scores { get; set; }
                public List<string> Boxes { get; set; }
                public float? Score { get; set; }
            }
        };

    }

}
