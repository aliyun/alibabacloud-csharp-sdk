// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetProjectMemberRequest : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("repositoryId")]
        [Validation(Required=false)]
        public long? RepositoryId { get; set; }

        [NameInMap("userAliyunPk")]
        [Validation(Required=false)]
        public string UserAliyunPk { get; set; }

    }

}
