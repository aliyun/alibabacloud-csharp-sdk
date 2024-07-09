// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateChangeRequestResponseBody : TeaModel {
        [NameInMap("appCodeRepoSn")]
        [Validation(Required=false)]
        public string AppCodeRepoSn { get; set; }

        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("autoDeleteBranchWhenEnd")]
        [Validation(Required=false)]
        public bool? AutoDeleteBranchWhenEnd { get; set; }

        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        [NameInMap("creatorAccountId")]
        [Validation(Required=false)]
        public string CreatorAccountId { get; set; }

        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("originBranch")]
        [Validation(Required=false)]
        public string OriginBranch { get; set; }

        [NameInMap("originBranchRevisionSha")]
        [Validation(Required=false)]
        public string OriginBranchRevisionSha { get; set; }

        [NameInMap("ownerAccountId")]
        [Validation(Required=false)]
        public string OwnerAccountId { get; set; }

        [NameInMap("ownerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
