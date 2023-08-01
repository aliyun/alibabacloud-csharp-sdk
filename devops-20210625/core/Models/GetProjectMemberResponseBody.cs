// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetProjectMemberResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetProjectMemberResponseBodyResult Result { get; set; }
        public class GetProjectMemberResponseBodyResult : TeaModel {
            [NameInMap("accessLevel")]
            [Validation(Required=false)]
            public int? AccessLevel { get; set; }

            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
