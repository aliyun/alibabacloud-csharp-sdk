// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CommentListReportRequest : TeaModel {
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
        public CommentListReportRequestTenantContext TenantContext { get; set; }
        public class CommentListReportRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
