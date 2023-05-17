// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UnlockUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UnlockUsersResult")]
        [Validation(Required=false)]
        public UnlockUsersResponseBodyUnlockUsersResult UnlockUsersResult { get; set; }
        public class UnlockUsersResponseBodyUnlockUsersResult : TeaModel {
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<UnlockUsersResponseBodyUnlockUsersResultFailedUsers> FailedUsers { get; set; }
            public class UnlockUsersResponseBodyUnlockUsersResultFailedUsers : TeaModel {
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

            [NameInMap("UnlockedUsers")]
            [Validation(Required=false)]
            public List<string> UnlockedUsers { get; set; }

        }

    }

}
