// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class RemoveUsersFromGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<RemoveUsersFromGroupResponseBodyResults> Results { get; set; }
        public class RemoveUsersFromGroupResponseBodyResults : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
