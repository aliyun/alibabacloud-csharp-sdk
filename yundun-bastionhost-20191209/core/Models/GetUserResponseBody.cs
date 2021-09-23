// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetUserResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }
            [NameInMap("MobileCountryCode")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("SourceUserId")]
            [Validation(Required=false)]
            public string SourceUserId { get; set; }
            [NameInMap("UserState")]
            [Validation(Required=false)]
            public List<string> UserState { get; set; }
        };

    }

}
