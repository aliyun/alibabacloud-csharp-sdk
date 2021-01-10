// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDWSUsersResponseBodyData Data { get; set; }
        public class GetDWSUsersResponseBodyData : TeaModel {
            [NameInMap("RealName")]
            [Validation(Required=false)]
            public string RealName { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
        };

    }

}
