// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetAllSheetsRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetAllSheetsRequestTenantContext TenantContext { get; set; }
        public class GetAllSheetsRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("WorkbookId")]
        [Validation(Required=false)]
        public string WorkbookId { get; set; }

    }

}
