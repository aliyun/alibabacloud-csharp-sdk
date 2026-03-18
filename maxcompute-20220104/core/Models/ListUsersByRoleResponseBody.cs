// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListUsersByRoleResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListUsersByRoleResponseBodyData Data { get; set; }
        public class ListUsersByRoleResponseBodyData : TeaModel {
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<ListUsersByRoleResponseBodyDataUsers> Users { get; set; }
            public class ListUsersByRoleResponseBodyDataUsers : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
