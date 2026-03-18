// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRoleAclOnObjectResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRoleAclOnObjectResponseBodyData Data { get; set; }
        public class GetRoleAclOnObjectResponseBodyData : TeaModel {
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<string> Actions { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
