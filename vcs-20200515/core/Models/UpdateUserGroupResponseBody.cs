// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class UpdateUserGroupResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateUserGroupResponseBodyData Data { get; set; }
        public class UpdateUserGroupResponseBodyData : TeaModel {
            [NameInMap("IsvSubId")]
            [Validation(Required=false)]
            public string IsvSubId { get; set; }
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public long UserGroupId { get; set; }
            [NameInMap("UserGroupName")]
            [Validation(Required=false)]
            public string UserGroupName { get; set; }
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public long UserCount { get; set; }
            [NameInMap("ParentUserGroupId")]
            [Validation(Required=false)]
            public string ParentUserGroupId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
