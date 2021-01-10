// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UploadLinkeLinkaInternalsinglecoverageRequest : TeaModel {
        [NameInMap("AciMode")]
        [Validation(Required=false)]
        public bool? AciMode { get; set; }

        [NameInMap("AciTenant")]
        [Validation(Required=false)]
        public string AciTenant { get; set; }

        [NameInMap("Branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("ClassesFileId")]
        [Validation(Required=false)]
        public string ClassesFileId { get; set; }

        [NameInMap("CommitId")]
        [Validation(Required=false)]
        public string CommitId { get; set; }

        [NameInMap("CoverageFileId")]
        [Validation(Required=false)]
        public string CoverageFileId { get; set; }

        [NameInMap("CustomToken")]
        [Validation(Required=false)]
        public string CustomToken { get; set; }

        [NameInMap("CustomUser")]
        [Validation(Required=false)]
        public string CustomUser { get; set; }

        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        [NameInMap("ExcludesRepeatList")]
        [Validation(Required=false)]
        public List<string> ExcludesRepeatList { get; set; }

        [NameInMap("GitUrl")]
        [Validation(Required=false)]
        public string GitUrl { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("SourceKind")]
        [Validation(Required=false)]
        public string SourceKind { get; set; }

        [NameInMap("StartCommitId")]
        [Validation(Required=false)]
        public string StartCommitId { get; set; }

    }

}
