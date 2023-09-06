// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class StatisticsListByTypeReportShrinkRequest : TeaModel {
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
