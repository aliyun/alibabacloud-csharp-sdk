// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateOrganizationMemberResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("member")]
        [Validation(Required=false)]
        public UpdateOrganizationMemberResponseBodyMember Member { get; set; }
        public class UpdateOrganizationMemberResponseBodyMember : TeaModel {
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("organizationMemberName")]
            [Validation(Required=false)]
            public string OrganizationMemberName { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
