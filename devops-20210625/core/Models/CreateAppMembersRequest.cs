// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateAppMembersRequest : TeaModel {
        [NameInMap("playerList")]
        [Validation(Required=false)]
        public List<CreateAppMembersRequestPlayerList> PlayerList { get; set; }
        public class CreateAppMembersRequestPlayerList : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("roleNames")]
        [Validation(Required=false)]
        public List<string> RoleNames { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
