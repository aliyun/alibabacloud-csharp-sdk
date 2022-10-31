// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class QuerySnapshotCallbackAuthResponseBody : TeaModel {
        [NameInMap("CallbackAuthKey")]
        [Validation(Required=false)]
        public string CallbackAuthKey { get; set; }

        [NameInMap("CallbackReqAuth")]
        [Validation(Required=false)]
        public string CallbackReqAuth { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
