// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListUserGroupsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUserGroupsResponseBodyData> Data { get; set; }
        public class ListUserGroupsResponseBodyData : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("IsvSubId")]
            [Validation(Required=false)]
            public string IsvSubId { get; set; }

            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public long UserGroupId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("UserGroupName")]
            [Validation(Required=false)]
            public string UserGroupName { get; set; }

            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public long UserCount { get; set; }

            [NameInMap("ParentUserGroupId")]
            [Validation(Required=false)]
            public long ParentUserGroupId { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
