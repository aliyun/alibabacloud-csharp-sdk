// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class StopAppServerResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StopAppServerResponseBodyData Data { get; set; }
        public class StopAppServerResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppServerStatus")]
            [Validation(Required=false)]
            public string AppServerStatus { get; set; }

            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
