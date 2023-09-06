// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SetRowsVisibilityRequest : TeaModel {
        [NameInMap("Row")]
        [Validation(Required=false)]
        public long? Row { get; set; }

        [NameInMap("RowCount")]
        [Validation(Required=false)]
        public long? RowCount { get; set; }

        [NameInMap("SheetId")]
        [Validation(Required=false)]
        public string SheetId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public SetRowsVisibilityRequestTenantContext TenantContext { get; set; }
        public class SetRowsVisibilityRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("WorkbookId")]
        [Validation(Required=false)]
        public string WorkbookId { get; set; }

    }

}
