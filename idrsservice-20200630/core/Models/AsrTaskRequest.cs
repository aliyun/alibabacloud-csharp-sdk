// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class AsrTaskRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public AsrTaskRequestRequest Request { get; set; }
        public class AsrTaskRequestRequest : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AsrTaskId")]
            [Validation(Required=false)]
            public string AsrTaskId { get; set; }

            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
