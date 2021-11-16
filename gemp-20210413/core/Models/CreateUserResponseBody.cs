// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateUserResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateUserResponseBodyData Data { get; set; }
        public class CreateUserResponseBodyData : TeaModel {
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
