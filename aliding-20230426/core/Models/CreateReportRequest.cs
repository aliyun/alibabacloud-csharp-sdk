// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateReportRequest : TeaModel {
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<CreateReportRequestContents> Contents { get; set; }
        public class CreateReportRequestContents : TeaModel {
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
        public CreateReportRequestTenantContext TenantContext { get; set; }
        public class CreateReportRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("ToChat")]
        [Validation(Required=false)]
        public bool? ToChat { get; set; }

        [NameInMap("ToCids")]
        [Validation(Required=false)]
        public List<string> ToCids { get; set; }

        [NameInMap("ToUserids")]
        [Validation(Required=false)]
        public List<string> ToUserids { get; set; }

    }

}
