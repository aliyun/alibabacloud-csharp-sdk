// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListOrganizationMembersRequest : TeaModel {
        [NameInMap("externUid")]
        [Validation(Required=false)]
        public string ExternUid { get; set; }

        [NameInMap("joinTimeFrom")]
        [Validation(Required=false)]
        public long? JoinTimeFrom { get; set; }

        [NameInMap("joinTimeTo")]
        [Validation(Required=false)]
        public long? JoinTimeTo { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("organizationMemberName")]
        [Validation(Required=false)]
        public string OrganizationMemberName { get; set; }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
