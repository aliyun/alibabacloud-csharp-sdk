// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectKneeKeypointXRayResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectKneeKeypointXRayResponseBodyData Data { get; set; }
        public class DetectKneeKeypointXRayResponseBodyData : TeaModel {
            [NameInMap("KeyPoints")]
            [Validation(Required=false)]
            public List<DetectKneeKeypointXRayResponseBodyDataKeyPoints> KeyPoints { get; set; }
            public class DetectKneeKeypointXRayResponseBodyDataKeyPoints : TeaModel {
                public float? Value { get; set; }
                public List<string> Coordinates { get; set; }
                public DetectKneeKeypointXRayResponseBodyDataKeyPointsTag Tag { get; set; }
                public class DetectKneeKeypointXRayResponseBodyDataKeyPointsTag : TeaModel {
                    [NameInMap("Direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }
            }
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }
        };

    }

}
