// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class DetectVideoShotResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectVideoShotResponseBodyData Data { get; set; }
        public class DetectVideoShotResponseBodyData : TeaModel {
            [NameInMap("ShotFrameIds")]
            [Validation(Required=false)]
            public List<int?> ShotFrameIds { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
