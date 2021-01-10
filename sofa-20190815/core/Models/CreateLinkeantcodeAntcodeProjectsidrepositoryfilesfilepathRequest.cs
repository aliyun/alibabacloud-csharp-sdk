// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeantcodeAntcodeProjectsidrepositoryfilesfilepathRequest : TeaModel {
        [NameInMap("AuthorEmail")]
        [Validation(Required=false)]
        public string AuthorEmail { get; set; }

        [NameInMap("AuthorName")]
        [Validation(Required=false)]
        public string AuthorName { get; set; }

        [NameInMap("Branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        [NameInMap("CommitMessage")]
        [Validation(Required=false)]
        public string CommitMessage { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

        [NameInMap("StartBranch")]
        [Validation(Required=false)]
        public string StartBranch { get; set; }

    }

}
