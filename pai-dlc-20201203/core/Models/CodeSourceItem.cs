// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CodeSourceItem : TeaModel {
        [NameInMap("CodeBranch")]
        [Validation(Required=false)]
        public string CodeBranch { get; set; }

        [NameInMap("CodeCommit")]
        [Validation(Required=false)]
        public string CodeCommit { get; set; }

        [NameInMap("CodeRepo")]
        [Validation(Required=false)]
        public string CodeRepo { get; set; }

        [NameInMap("CodeRepoAccessToken")]
        [Validation(Required=false)]
        public string CodeRepoAccessToken { get; set; }

        [NameInMap("CodeRepoUserName")]
        [Validation(Required=false)]
        public string CodeRepoUserName { get; set; }

        [NameInMap("CodeSourceId")]
        [Validation(Required=false)]
        public string CodeSourceId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
