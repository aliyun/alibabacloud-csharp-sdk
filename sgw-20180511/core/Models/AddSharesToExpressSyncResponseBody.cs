// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class AddSharesToExpressSyncResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MnsFullSyncDelay")]
        [Validation(Required=false)]
        public long? MnsFullSyncDelay { get; set; }

        [NameInMap("MnsInnerEndpoint")]
        [Validation(Required=false)]
        public string MnsInnerEndpoint { get; set; }

        [NameInMap("MnsPublicEndpoint")]
        [Validation(Required=false)]
        public string MnsPublicEndpoint { get; set; }

        [NameInMap("MnsQueues")]
        [Validation(Required=false)]
        public string MnsQueues { get; set; }

        [NameInMap("MnsTopic")]
        [Validation(Required=false)]
        public string MnsTopic { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
