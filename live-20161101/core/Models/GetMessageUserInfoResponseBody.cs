// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetMessageUserInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetMessageUserInfoResponseBodyResult Result { get; set; }
        public class GetMessageUserInfoResponseBodyResult : TeaModel {
            [NameInMap("HasOrderedIM")]
            [Validation(Required=false)]
            public bool? HasOrderedIM { get; set; }

            [NameInMap("IsNewIMUser")]
            [Validation(Required=false)]
            public bool? IsNewIMUser { get; set; }

        }

    }

}
