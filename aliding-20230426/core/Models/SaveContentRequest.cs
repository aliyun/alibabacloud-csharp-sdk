// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SaveContentRequest : TeaModel {
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<SaveContentRequestContents> Contents { get; set; }
        public class SaveContentRequestContents : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Sort")]
            [Validation(Required=false)]
            public long? Sort { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

        }

        [NameInMap("DdFrom")]
        [Validation(Required=false)]
        public string DdFrom { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public SaveContentRequestTenantContext TenantContext { get; set; }
        public class SaveContentRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
