// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class UpdateTenantStatusRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public UpdateTenantStatusRequestRequest Request { get; set; }
        public class UpdateTenantStatusRequestRequest : TeaModel {
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

    }

}
