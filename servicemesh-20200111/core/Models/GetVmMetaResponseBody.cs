// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetVmMetaResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The metadata that is required to add a non-containerized application to the ASM instance.
        /// </summary>
        [NameInMap("VmMetaInfo")]
        [Validation(Required=false)]
        public GetVmMetaResponseBodyVmMetaInfo VmMetaInfo { get; set; }
        public class GetVmMetaResponseBodyVmMetaInfo : TeaModel {
            /// <summary>
            /// The content of the EnvoyEnv file.
            /// </summary>
            [NameInMap("EnvoyEnvContent")]
            [Validation(Required=false)]
            public string EnvoyEnvContent { get; set; }

            /// <summary>
            /// The content of the hosts file.
            /// </summary>
            [NameInMap("HostsContent")]
            [Validation(Required=false)]
            public string HostsContent { get; set; }

            /// <summary>
            /// The content of the Token file.
            /// </summary>
            [NameInMap("TokenContent")]
            [Validation(Required=false)]
            public string TokenContent { get; set; }

        }

    }

}
