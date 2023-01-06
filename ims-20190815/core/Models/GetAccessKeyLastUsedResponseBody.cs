// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccessKeyLastUsedResponseBody : TeaModel {
        [NameInMap("AccessKeyLastUsed")]
        [Validation(Required=false)]
        public GetAccessKeyLastUsedResponseBodyAccessKeyLastUsed AccessKeyLastUsed { get; set; }
        public class GetAccessKeyLastUsedResponseBodyAccessKeyLastUsed : TeaModel {
            [NameInMap("LastUsedDate")]
            [Validation(Required=false)]
            public string LastUsedDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
