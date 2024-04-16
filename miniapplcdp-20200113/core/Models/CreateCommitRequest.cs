// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class CreateCommitRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CommitLog")]
        [Validation(Required=false)]
        public string CommitLog { get; set; }

        [NameInMap("CommitType")]
        [Validation(Required=false)]
        public string CommitType { get; set; }

        [NameInMap("MainModuleCommitId")]
        [Validation(Required=false)]
        public string MainModuleCommitId { get; set; }

        [NameInMap("ModuleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        [NameInMap("RollbackToCommitId")]
        [Validation(Required=false)]
        public string RollbackToCommitId { get; set; }

        [NameInMap("RollbackType")]
        [Validation(Required=false)]
        public string RollbackType { get; set; }

        [NameInMap("SchemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
