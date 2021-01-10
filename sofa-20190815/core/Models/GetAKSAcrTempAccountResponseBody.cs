// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetAKSAcrTempAccountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("AuthorizationToken")]
        [Validation(Required=false)]
        public string AuthorizationToken { get; set; }

        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public long? ExpireDate { get; set; }

        [NameInMap("TempUserName")]
        [Validation(Required=false)]
        public string TempUserName { get; set; }

    }

}
