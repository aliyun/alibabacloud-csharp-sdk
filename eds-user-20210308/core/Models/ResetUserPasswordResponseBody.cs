// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ResetUserPasswordResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResetUsersResult")]
        [Validation(Required=false)]
        public ResetUserPasswordResponseBodyResetUsersResult ResetUsersResult { get; set; }
        public class ResetUserPasswordResponseBodyResetUsersResult : TeaModel {
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<ResetUserPasswordResponseBodyResetUsersResultFailedUsers> FailedUsers { get; set; }
            public class ResetUserPasswordResponseBodyResetUsersResultFailedUsers : TeaModel {
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            [NameInMap("ResetUsers")]
            [Validation(Required=false)]
            public List<string> ResetUsers { get; set; }

        }

    }

}
