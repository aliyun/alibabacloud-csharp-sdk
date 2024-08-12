// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ReportAppOtaInfoRequest : TeaModel {
        [NameInMap("BaseVersion")]
        [Validation(Required=false)]
        public string BaseVersion { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        [NameInMap("ClientUid")]
        [Validation(Required=false)]
        public string ClientUid { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("TargetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

        [NameInMap("TaskUid")]
        [Validation(Required=false)]
        public string TaskUid { get; set; }

    }

}
