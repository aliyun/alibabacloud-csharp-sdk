// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDTXGlobalEnvResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDTXGlobalEnvResponseBodyData Data { get; set; }
        public class GetDTXGlobalEnvResponseBodyData : TeaModel {
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }
            [NameInMap("IsPublicCloud")]
            [Validation(Required=false)]
            public bool? IsPublicCloud { get; set; }
            [NameInMap("RecoveryMode")]
            [Validation(Required=false)]
            public string RecoveryMode { get; set; }
            [NameInMap("Tenant")]
            [Validation(Required=false)]
            public string Tenant { get; set; }
        };

    }

}
