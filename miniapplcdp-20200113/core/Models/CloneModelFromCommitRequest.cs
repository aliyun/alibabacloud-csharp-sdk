// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class CloneModelFromCommitRequest : TeaModel {
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("SourceCommitId")]
        [Validation(Required=false)]
        public string SourceCommitId { get; set; }

        [NameInMap("SourceModuleId")]
        [Validation(Required=false)]
        public string SourceModuleId { get; set; }

        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        [NameInMap("TargetModuleId")]
        [Validation(Required=false)]
        public string TargetModuleId { get; set; }

        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        [NameInMap("TargetSubType")]
        [Validation(Required=false)]
        public string TargetSubType { get; set; }

    }

}
