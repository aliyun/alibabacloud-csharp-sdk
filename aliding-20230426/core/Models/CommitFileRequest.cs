// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CommitFileRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public CommitFileRequestOption Option { get; set; }
        public class CommitFileRequestOption : TeaModel {
            [NameInMap("AppProperties")]
            [Validation(Required=false)]
            public List<CommitFileRequestOptionAppProperties> AppProperties { get; set; }
            public class CommitFileRequestOptionAppProperties : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

            [NameInMap("ConflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }

            [NameInMap("ConvertToOnlineDoc")]
            [Validation(Required=false)]
            public bool? ConvertToOnlineDoc { get; set; }

            [NameInMap("ConvertToOnlineDocTargetDocumentType")]
            [Validation(Required=false)]
            public string ConvertToOnlineDocTargetDocumentType { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        [NameInMap("ParentDentryUuid")]
        [Validation(Required=false)]
        public string ParentDentryUuid { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CommitFileRequestTenantContext TenantContext { get; set; }
        public class CommitFileRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("UploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

    }

}
