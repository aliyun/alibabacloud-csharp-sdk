// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetVmMetaResponseBody : TeaModel {
        [NameInMap("VmMetaInfo")]
        [Validation(Required=false)]
        public GetVmMetaResponseBodyVmMetaInfo VmMetaInfo { get; set; }
        public class GetVmMetaResponseBodyVmMetaInfo : TeaModel {
            [NameInMap("TokenPath")]
            [Validation(Required=false)]
            public string TokenPath { get; set; }
            [NameInMap("HostsContent")]
            [Validation(Required=false)]
            public string HostsContent { get; set; }
            [NameInMap("EnvoyEnvPath")]
            [Validation(Required=false)]
            public string EnvoyEnvPath { get; set; }
            [NameInMap("TokenContent")]
            [Validation(Required=false)]
            public string TokenContent { get; set; }
            [NameInMap("CertChainPath")]
            [Validation(Required=false)]
            public string CertChainPath { get; set; }
            [NameInMap("RootCertContent")]
            [Validation(Required=false)]
            public string RootCertContent { get; set; }
            [NameInMap("KeyContent")]
            [Validation(Required=false)]
            public string KeyContent { get; set; }
            [NameInMap("RootCertPath")]
            [Validation(Required=false)]
            public string RootCertPath { get; set; }
            [NameInMap("CertChainContent")]
            [Validation(Required=false)]
            public string CertChainContent { get; set; }
            [NameInMap("HostsPath")]
            [Validation(Required=false)]
            public string HostsPath { get; set; }
            [NameInMap("KeyPath")]
            [Validation(Required=false)]
            public string KeyPath { get; set; }
            [NameInMap("EnvoyEnvContent")]
            [Validation(Required=false)]
            public string EnvoyEnvContent { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
