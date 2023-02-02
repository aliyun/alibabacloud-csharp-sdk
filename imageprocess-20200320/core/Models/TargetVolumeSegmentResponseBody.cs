// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class TargetVolumeSegmentResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TargetVolumeSegmentResponseBodyData Data { get; set; }
        public class TargetVolumeSegmentResponseBodyData : TeaModel {
            [NameInMap("ResultURL")]
            [Validation(Required=false)]
            public string ResultURL { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
