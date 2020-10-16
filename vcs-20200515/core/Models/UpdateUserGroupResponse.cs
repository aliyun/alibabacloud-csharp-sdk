// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class UpdateUserGroupResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public UpdateUserGroupResponseData Data { get; set; }
        public class UpdateUserGroupResponseData : TeaModel {
            [NameInMap("UserGroupId")]
            [Validation(Required=true)]
            public long UserGroupId { get; set; }
            [NameInMap("IsvSubId")]
            [Validation(Required=true)]
            public string IsvSubId { get; set; }
            [NameInMap("UserGroupName")]
            [Validation(Required=true)]
            public string UserGroupName { get; set; }
            [NameInMap("UserCount")]
            [Validation(Required=true)]
            public long UserCount { get; set; }
            [NameInMap("ParentUserGroupId")]
            [Validation(Required=true)]
            public string ParentUserGroupId { get; set; }
        };

    }

}
