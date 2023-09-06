// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetReportTemplateByNameRequest : TeaModel {
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetReportTemplateByNameRequestTenantContext TenantContext { get; set; }
        public class GetReportTemplateByNameRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
