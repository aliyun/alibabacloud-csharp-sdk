// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateLiveRequest : TeaModel {
        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        [NameInMap("LiveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        [NameInMap("PreEndTime")]
        [Validation(Required=false)]
        public long? PreEndTime { get; set; }

        [NameInMap("PreStartTime")]
        [Validation(Required=false)]
        public long? PreStartTime { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public UpdateLiveRequestTenantContext TenantContext { get; set; }
        public class UpdateLiveRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
