// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateSuperResolutionImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateSuperResolutionImageResponseBodyData Data { get; set; }
        public class GenerateSuperResolutionImageResponseBodyData : TeaModel {
            [NameInMap("ResultUrl")]
            [Validation(Required=false)]
            public string ResultUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
