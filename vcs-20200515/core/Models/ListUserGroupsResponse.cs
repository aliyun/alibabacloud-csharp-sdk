// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListUserGroupsResponse : TeaModel {
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
        public List<ListUserGroupsResponseData> Data { get; set; }
        public class ListUserGroupsResponseData : TeaModel {
            [NameInMap("Creator")]
            [Validation(Required=true)]
            public string Creator { get; set; }

            [NameInMap("UserGroupName")]
            [Validation(Required=true)]
            public string UserGroupName { get; set; }

            [NameInMap("IsvSubId")]
            [Validation(Required=true)]
            public string IsvSubId { get; set; }

            [NameInMap("UserGroupId")]
            [Validation(Required=true)]
            public long UserGroupId { get; set; }

            [NameInMap("UserCount")]
            [Validation(Required=true)]
            public long UserCount { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }

            [NameInMap("ParentUserGroupId")]
            [Validation(Required=true)]
            public long ParentUserGroupId { get; set; }

        }

    }

}
