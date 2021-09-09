// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateInstanceResponseBodyResult Result { get; set; }
        public class CreateInstanceResponseBodyResult : TeaModel {
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
        };

    }

}
