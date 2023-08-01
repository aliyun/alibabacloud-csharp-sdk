// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class DeleteRepositoryMemberResponseBody : TeaModel {
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
        public DeleteRepositoryMemberResponseBodyResult Result { get; set; }
        public class DeleteRepositoryMemberResponseBodyResult : TeaModel {
            [NameInMap("accessLevel")]
            [Validation(Required=false)]
            public int? AccessLevel { get; set; }

            [NameInMap("createAt")]
            [Validation(Required=false)]
            public string CreateAt { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("updateAt")]
            [Validation(Required=false)]
            public string UpdateAt { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
