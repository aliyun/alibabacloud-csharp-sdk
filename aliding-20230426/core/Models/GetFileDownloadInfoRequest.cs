// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetFileDownloadInfoRequest : TeaModel {
        [NameInMap("DentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public GetFileDownloadInfoRequestOption Option { get; set; }
        public class GetFileDownloadInfoRequestOption : TeaModel {
            [NameInMap("PreferIntranet")]
            [Validation(Required=false)]
            public bool? PreferIntranet { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetFileDownloadInfoRequestTenantContext TenantContext { get; set; }
        public class GetFileDownloadInfoRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
