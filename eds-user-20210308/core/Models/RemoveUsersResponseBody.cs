// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class RemoveUsersResponseBody : TeaModel {
        [NameInMap("RemoveUsersResult")]
        [Validation(Required=false)]
        public RemoveUsersResponseBodyRemoveUsersResult RemoveUsersResult { get; set; }
        public class RemoveUsersResponseBodyRemoveUsersResult : TeaModel {
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<RemoveUsersResponseBodyRemoveUsersResultFailedUsers> FailedUsers { get; set; }
            public class RemoveUsersResponseBodyRemoveUsersResultFailedUsers : TeaModel {
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

            [NameInMap("RemovedUsers")]
            [Validation(Required=false)]
            public List<string> RemovedUsers { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
