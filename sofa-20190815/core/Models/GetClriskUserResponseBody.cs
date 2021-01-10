// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetClriskUserResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public GetClriskUserResponseBodyUser User { get; set; }
        public class GetClriskUserResponseBodyUser : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }
            [NameInMap("OriginId")]
            [Validation(Required=false)]
            public string OriginId { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

    }

}
