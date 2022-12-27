// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class DeleteGroupMemberRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("aliyunPk")]
        [Validation(Required=false)]
        public string AliyunPk { get; set; }

        [NameInMap("memberType")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
