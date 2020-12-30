// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetUserActiveTenantResponseBody : TeaModel {
        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public GetUserActiveTenantResponseBodyTenant Tenant { get; set; }
        public class GetUserActiveTenantResponseBodyTenant : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Tid")]
            [Validation(Required=false)]
            public long? Tid { get; set; }
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
