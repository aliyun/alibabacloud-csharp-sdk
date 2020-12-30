// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SaveReceiverDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SaveReceiverDetailResponseBodyData Data { get; set; }
        public class SaveReceiverDetailResponseBodyData : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<SaveReceiverDetailResponseBodyDataDetail> Detail { get; set; }
            public class SaveReceiverDetailResponseBodyDataDetail : TeaModel {
                public string Email { get; set; }
            }
        };

        [NameInMap("ErrorCount")]
        [Validation(Required=false)]
        public int? ErrorCount { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
