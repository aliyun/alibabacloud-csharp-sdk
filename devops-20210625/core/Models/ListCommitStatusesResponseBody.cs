// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListCommitStatusesResponseBody : TeaModel {
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
        public List<ListCommitStatusesResponseBodyResult> Result { get; set; }
        public class ListCommitStatusesResponseBodyResult : TeaModel {
            [NameInMap("context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public ListCommitStatusesResponseBodyResultCreator Creator { get; set; }
            public class ListCommitStatusesResponseBodyResultCreator : TeaModel {
                [NameInMap("aliyunPk")]
                [Validation(Required=false)]
                public string AliyunPk { get; set; }

                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("login")]
                [Validation(Required=false)]
                public string Login { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("sha")]
            [Validation(Required=false)]
            public string Sha { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("targetUrl")]
            [Validation(Required=false)]
            public string TargetUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
