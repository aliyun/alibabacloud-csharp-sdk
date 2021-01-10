// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DiagnosisVersionRequest : TeaModel {
        [NameInMap("OriginalId")]
        [Validation(Required=false)]
        public string OriginalId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("VersionType")]
        [Validation(Required=false)]
        public string VersionType { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("IdType")]
        [Validation(Required=false)]
        public string IdType { get; set; }

        [NameInMap("DiagnoseStyle")]
        [Validation(Required=false)]
        public string DiagnoseStyle { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

    }

}
