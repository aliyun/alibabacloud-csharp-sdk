// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UploadLinkeLinkaTaskcoverageRequest : TeaModel {
        [NameInMap("Branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("ClassesFile")]
        [Validation(Required=false)]
        public string ClassesFile { get; set; }

        [NameInMap("CommitId")]
        [Validation(Required=false)]
        public string CommitId { get; set; }

        [NameInMap("CoverageFileRepeatList")]
        [Validation(Required=false)]
        public List<string> CoverageFileRepeatList { get; set; }

        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        [NameInMap("Excludes")]
        [Validation(Required=false)]
        public string Excludes { get; set; }

        [NameInMap("GitUrl")]
        [Validation(Required=false)]
        public string GitUrl { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("StartCommitId")]
        [Validation(Required=false)]
        public string StartCommitId { get; set; }

    }

}
