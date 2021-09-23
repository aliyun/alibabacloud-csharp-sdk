// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetUserGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public GetUserGroupResponseBodyUserGroup UserGroup { get; set; }
        public class GetUserGroupResponseBodyUserGroup : TeaModel {
            [NameInMap("UserGroupName")]
            [Validation(Required=false)]
            public string UserGroupName { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }
        };

    }

}
