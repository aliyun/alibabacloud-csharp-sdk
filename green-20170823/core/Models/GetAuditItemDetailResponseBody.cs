// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class GetAuditItemDetailResponseBody : TeaModel {
        [NameInMap("ApiResult")]
        [Validation(Required=false)]
        public string ApiResult { get; set; }

        [NameInMap("ApiRiskType")]
        [Validation(Required=false)]
        public string ApiRiskType { get; set; }

        [NameInMap("ApiTs")]
        [Validation(Required=false)]
        public string ApiTs { get; set; }

        [NameInMap("NewUrl")]
        [Validation(Required=false)]
        public string NewUrl { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
