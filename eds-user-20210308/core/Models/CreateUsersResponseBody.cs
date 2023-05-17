// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateUsersResponseBody : TeaModel {
        [NameInMap("CreateResult")]
        [Validation(Required=false)]
        public CreateUsersResponseBodyCreateResult CreateResult { get; set; }
        public class CreateUsersResponseBodyCreateResult : TeaModel {
            [NameInMap("CreatedUsers")]
            [Validation(Required=false)]
            public List<CreateUsersResponseBodyCreateResultCreatedUsers> CreatedUsers { get; set; }
            public class CreateUsersResponseBodyCreateResultCreatedUsers : TeaModel {
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<CreateUsersResponseBodyCreateResultFailedUsers> FailedUsers { get; set; }
            public class CreateUsersResponseBodyCreateResultFailedUsers : TeaModel {
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
