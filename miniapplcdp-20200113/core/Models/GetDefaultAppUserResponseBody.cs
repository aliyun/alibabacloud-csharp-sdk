// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class GetDefaultAppUserResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDefaultAppUserResponseBodyData Data { get; set; }
        public class GetDefaultAppUserResponseBodyData : TeaModel {
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public bool? HasPassword { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
