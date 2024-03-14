// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class QueryPromInstallStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryPromInstallStatusResponseBodyData Data { get; set; }
        public class QueryPromInstallStatusResponseBodyData : TeaModel {
            [NameInMap("isControllerInstalled")]
            [Validation(Required=false)]
            public bool? IsControllerInstalled { get; set; }

        }

    }

}
