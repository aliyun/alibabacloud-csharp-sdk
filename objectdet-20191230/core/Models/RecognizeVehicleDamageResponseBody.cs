// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class RecognizeVehicleDamageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVehicleDamageResponseBodyData Data { get; set; }
        public class RecognizeVehicleDamageResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeVehicleDamageResponseBodyDataElements> Elements { get; set; }
            public class RecognizeVehicleDamageResponseBodyDataElements : TeaModel {
                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<int?> Boxes { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("Scores")]
                [Validation(Required=false)]
                public List<float?> Scores { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
