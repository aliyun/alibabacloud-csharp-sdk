// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdateAppResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateAppResponseBodyResult Result { get; set; }
        public class UpdateAppResponseBodyResult : TeaModel {
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
