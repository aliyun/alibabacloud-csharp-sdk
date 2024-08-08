// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class InitMultipartFileUploadRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public InitMultipartFileUploadRequestOption Option { get; set; }
        public class InitMultipartFileUploadRequestOption : TeaModel {
            [NameInMap("PreCheckParam")]
            [Validation(Required=false)]
            public InitMultipartFileUploadRequestOptionPreCheckParam PreCheckParam { get; set; }
            public class InitMultipartFileUploadRequestOptionPreCheckParam : TeaModel {
                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            [NameInMap("PreferRegion")]
            [Validation(Required=false)]
            public string PreferRegion { get; set; }

            [NameInMap("StorageDriver")]
            [Validation(Required=false)]
            public string StorageDriver { get; set; }

        }

        [NameInMap("ParentDentryUuid")]
        [Validation(Required=false)]
        public string ParentDentryUuid { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public InitMultipartFileUploadRequestTenantContext TenantContext { get; set; }
        public class InitMultipartFileUploadRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
