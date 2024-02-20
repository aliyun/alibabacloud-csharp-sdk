// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aigen20240111.Models
{
    public class InteractiveScribbleSegmentationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public InteractiveScribbleSegmentationResponseBodyData Data { get; set; }
        public class InteractiveScribbleSegmentationResponseBodyData : TeaModel {
            [NameInMap("ResultUrl")]
            [Validation(Required=false)]
            public string ResultUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
