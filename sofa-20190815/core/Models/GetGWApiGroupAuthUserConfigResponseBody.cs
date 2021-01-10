// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetGWApiGroupAuthUserConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGWApiGroupAuthUserConfigResponseBodyData Data { get; set; }
        public class GetGWApiGroupAuthUserConfigResponseBodyData : TeaModel {
            [NameInMap("ApiAuthUserSwitch")]
            [Validation(Required=false)]
            public string ApiAuthUserSwitch { get; set; }
            [NameInMap("CheckMaster")]
            [Validation(Required=false)]
            public bool? CheckMaster { get; set; }
            [NameInMap("NeedApiAuthUser")]
            [Validation(Required=false)]
            public bool? NeedApiAuthUser { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }
        };

    }

}
