// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class StatisticsReportRequest : TeaModel {
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public StatisticsReportRequestTenantContext TenantContext { get; set; }
        public class StatisticsReportRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
