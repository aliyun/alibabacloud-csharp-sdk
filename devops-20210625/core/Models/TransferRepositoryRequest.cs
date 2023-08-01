// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class TransferRepositoryRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("repositoryId")]
        [Validation(Required=false)]
        public string RepositoryId { get; set; }

    }

}
