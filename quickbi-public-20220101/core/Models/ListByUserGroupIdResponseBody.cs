// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListByUserGroupIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListByUserGroupIdResponseBodyResult Result { get; set; }
        public class ListByUserGroupIdResponseBodyResult : TeaModel {
            [NameInMap("FailedUserGroupIds")]
            [Validation(Required=false)]
            public List<string> FailedUserGroupIds { get; set; }
            [NameInMap("UserGroupModels")]
            [Validation(Required=false)]
            public List<ListByUserGroupIdResponseBodyResultUserGroupModels> UserGroupModels { get; set; }
            public class ListByUserGroupIdResponseBodyResultUserGroupModels : TeaModel {
                public string CreateTime { get; set; }
                public string CreateUser { get; set; }
                public string IdentifiedPath { get; set; }
                public string ModifiedTime { get; set; }
                public string ModifyUser { get; set; }
                public string ParentUsergroupId { get; set; }
                public string UsergroupDesc { get; set; }
                public string UsergroupId { get; set; }
                public string UsergroupName { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
