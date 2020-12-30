// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectVehicleResponseBodyData Data { get; set; }
        public class DetectVehicleResponseBodyData : TeaModel {
            [NameInMap("DetectObjectInfoList")]
            [Validation(Required=false)]
            public List<DetectVehicleResponseBodyDataDetectObjectInfoList> DetectObjectInfoList { get; set; }
            public class DetectVehicleResponseBodyDataDetectObjectInfoList : TeaModel {
                public string Type { get; set; }
                public List<string> Boxes { get; set; }
                public float? Score { get; set; }
                public int? Id { get; set; }
            }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }
        };

    }

}
