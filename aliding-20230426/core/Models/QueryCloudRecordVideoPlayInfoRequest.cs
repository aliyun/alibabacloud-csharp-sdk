// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryCloudRecordVideoPlayInfoRequest : TeaModel {
        [NameInMap("ConferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public QueryCloudRecordVideoPlayInfoRequestTenantContext TenantContext { get; set; }
        public class QueryCloudRecordVideoPlayInfoRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
