// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListRepositoryMemberWithInheritedResponseBody : TeaModel {
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
        public List<ListRepositoryMemberWithInheritedResponseBodyResult> Result { get; set; }
        public class ListRepositoryMemberWithInheritedResponseBodyResult : TeaModel {
            [NameInMap("accessLevel")]
            [Validation(Required=false)]
            public int? AccessLevel { get; set; }

            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("inherited")]
            [Validation(Required=false)]
            public ListRepositoryMemberWithInheritedResponseBodyResultInherited Inherited { get; set; }
            public class ListRepositoryMemberWithInheritedResponseBodyResultInherited : TeaModel {
                /// <summary>
                /// id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("nameWithNamespace")]
                [Validation(Required=false)]
                public string NameWithNamespace { get; set; }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("pathWithNamespace")]
                [Validation(Required=false)]
                public string PathWithNamespace { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("visibilityLevel")]
                [Validation(Required=false)]
                public string VisibilityLevel { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
