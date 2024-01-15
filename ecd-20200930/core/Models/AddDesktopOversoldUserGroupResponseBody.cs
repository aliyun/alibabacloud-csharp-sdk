// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class AddDesktopOversoldUserGroupResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddDesktopOversoldUserGroupResponseBodyData Data { get; set; }
        public class AddDesktopOversoldUserGroupResponseBodyData : TeaModel {
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
