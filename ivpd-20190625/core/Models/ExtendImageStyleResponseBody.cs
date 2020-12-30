// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class ExtendImageStyleResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExtendImageStyleResponseBodyData Data { get; set; }
        public class ExtendImageStyleResponseBodyData : TeaModel {
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
            [NameInMap("MajorUrl")]
            [Validation(Required=false)]
            public string MajorUrl { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
