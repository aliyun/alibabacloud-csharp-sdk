// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetVmMetaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VmMetaInfo")]
        [Validation(Required=false)]
        public GetVmMetaResponseBodyVmMetaInfo VmMetaInfo { get; set; }
        public class GetVmMetaResponseBodyVmMetaInfo : TeaModel {
            [NameInMap("EnvoyEnvContent")]
            [Validation(Required=false)]
            public string EnvoyEnvContent { get; set; }
            [NameInMap("HostsContent")]
            [Validation(Required=false)]
            public string HostsContent { get; set; }
            [NameInMap("TokenContent")]
            [Validation(Required=false)]
            public string TokenContent { get; set; }
        };

    }

}
