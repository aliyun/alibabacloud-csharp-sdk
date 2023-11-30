// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UserLogDetail : TeaModel {
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("expired_at")]
        [Validation(Required=false)]
        public long? ExpiredAt { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("role_id")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        [NameInMap("update_to")]
        [Validation(Required=false)]
        public UserLogDetailUpdateTo UpdateTo { get; set; }
        public class UserLogDetailUpdateTo : TeaModel {
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("expired_at")]
            [Validation(Required=false)]
            public long? ExpiredAt { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("role_id")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

    }

}
