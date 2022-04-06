// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class TranslateMedResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TranslateMedResponseBodyData Data { get; set; }
        public class TranslateMedResponseBodyData : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }
            [NameInMap("Words")]
            [Validation(Required=false)]
            public long? Words { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
