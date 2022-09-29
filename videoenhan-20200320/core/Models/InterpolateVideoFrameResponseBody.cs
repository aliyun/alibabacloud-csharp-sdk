// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class InterpolateVideoFrameResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public InterpolateVideoFrameResponseBodyData Data { get; set; }
        public class InterpolateVideoFrameResponseBodyData : TeaModel {
            [NameInMap("VideoURL")]
            [Validation(Required=false)]
            public string VideoURL { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
