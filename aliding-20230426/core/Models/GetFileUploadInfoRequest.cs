// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetFileUploadInfoRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public GetFileUploadInfoRequestOption Option { get; set; }
        public class GetFileUploadInfoRequestOption : TeaModel {
            [NameInMap("PreCheckParam")]
            [Validation(Required=false)]
            public GetFileUploadInfoRequestOptionPreCheckParam PreCheckParam { get; set; }
            public class GetFileUploadInfoRequestOptionPreCheckParam : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            [NameInMap("PreferIntranet")]
            [Validation(Required=false)]
            public bool? PreferIntranet { get; set; }

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

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetFileUploadInfoRequestTenantContext TenantContext { get; set; }
        public class GetFileUploadInfoRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
