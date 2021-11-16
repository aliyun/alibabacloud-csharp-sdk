// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDISyncTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDISyncTaskResponseBodyData Data { get; set; }
        public class CreateDISyncTaskResponseBodyData : TeaModel {
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
