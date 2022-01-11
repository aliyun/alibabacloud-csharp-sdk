// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CheckCloudResourceAuthorizedResponseBody : TeaModel {
        [NameInMap("AuthorizationState")]
        [Validation(Required=false)]
        public int? AuthorizationState { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
