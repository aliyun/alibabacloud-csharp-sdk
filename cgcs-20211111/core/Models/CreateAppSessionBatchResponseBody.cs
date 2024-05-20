// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class CreateAppSessionBatchResponseBody : TeaModel {
        [NameInMap("CustomTaskId")]
        [Validation(Required=false)]
        public string CustomTaskId { get; set; }

        [NameInMap("PlatformTaskId")]
        [Validation(Required=false)]
        public string PlatformTaskId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
