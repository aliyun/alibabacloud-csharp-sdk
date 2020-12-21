// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class CreateUserGroupResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateUserGroupResponseBodyData Data { get; set; }
        public class CreateUserGroupResponseBodyData : TeaModel {
            [NameInMap("IsvSubId")]
            [Validation(Required=false)]
            public string IsvSubId { get; set; }
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public long UserGroupId { get; set; }
            [NameInMap("UserGroupName")]
            [Validation(Required=false)]
            public string UserGroupName { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
