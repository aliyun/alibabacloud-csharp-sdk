// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetTenantStatusResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTenantStatusResponseBodyData Data { get; set; }
        public class GetTenantStatusResponseBodyData : TeaModel {
            [NameInMap("tenantStatus")]
            [Validation(Required=false)]
            public int? TenantStatus { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
