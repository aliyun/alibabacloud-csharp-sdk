// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateProjectMemberResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 成员信息
        /// </summary>
        [NameInMap("member")]
        [Validation(Required=false)]
        public UpdateProjectMemberResponseBodyMember Member { get; set; }
        public class UpdateProjectMemberResponseBodyMember : TeaModel {
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("roleIdentifier")]
            [Validation(Required=false)]
            public string RoleIdentifier { get; set; }
            [NameInMap("targetIdentifier")]
            [Validation(Required=false)]
            public string TargetIdentifier { get; set; }
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }
            [NameInMap("userIdentifier")]
            [Validation(Required=false)]
            public string UserIdentifier { get; set; }
            [NameInMap("userType")]
            [Validation(Required=false)]
            public string UserType { get; set; }
        };

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true或者false
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
