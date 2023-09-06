// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListReportShrinkRequest : TeaModel {
        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public long? Cursor { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ModifiedEndTime")]
        [Validation(Required=false)]
        public long? ModifiedEndTime { get; set; }

        [NameInMap("ModifiedStartTime")]
        [Validation(Required=false)]
        public long? ModifiedStartTime { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

    }

}
