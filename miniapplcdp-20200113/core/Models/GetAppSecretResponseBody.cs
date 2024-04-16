// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class GetAppSecretResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAppSecretResponseBodyData Data { get; set; }
        public class GetAppSecretResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
