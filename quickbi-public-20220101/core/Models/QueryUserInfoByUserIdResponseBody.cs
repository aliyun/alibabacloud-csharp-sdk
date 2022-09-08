// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserInfoByUserIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserInfoByUserIdResponseBodyResult Result { get; set; }
        public class QueryUserInfoByUserIdResponseBodyResult : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("AdminUser")]
            [Validation(Required=false)]
            public bool? AdminUser { get; set; }

            [NameInMap("AuthAdminUser")]
            [Validation(Required=false)]
            public bool? AuthAdminUser { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
