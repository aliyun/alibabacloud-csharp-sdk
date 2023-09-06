// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryScheduleConferenceRequest : TeaModel {
        [NameInMap("RequestUnionId")]
        [Validation(Required=false)]
        public string RequestUnionId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public QueryScheduleConferenceRequestTenantContext TenantContext { get; set; }
        public class QueryScheduleConferenceRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
