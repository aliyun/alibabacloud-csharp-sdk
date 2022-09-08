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
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                [NameInMap("IdentifiedPath")]
                [Validation(Required=false)]
                public string IdentifiedPath { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                [NameInMap("ParentUsergroupId")]
                [Validation(Required=false)]
                public string ParentUsergroupId { get; set; }

                [NameInMap("UsergroupDesc")]
                [Validation(Required=false)]
                public string UsergroupDesc { get; set; }

                [NameInMap("UsergroupId")]
                [Validation(Required=false)]
                public string UsergroupId { get; set; }

                [NameInMap("UsergroupName")]
                [Validation(Required=false)]
                public string UsergroupName { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
