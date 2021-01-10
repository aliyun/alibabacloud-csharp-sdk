// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteLinkeantcodeAntcodeDeleteexistingfileinrepositoryRequest : TeaModel {
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        [NameInMap("CommitMessage")]
        [Validation(Required=false)]
        public string CommitMessage { get; set; }

        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
