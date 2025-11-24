// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetVmMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9522f7c9-63a1-4603-b850-37d12a****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metadata that is required to add a non-containerized application to the ASM instance.</para>
        /// </summary>
        [NameInMap("VmMetaInfo")]
        [Validation(Required=false)]
        public GetVmMetaResponseBodyVmMetaInfo VmMetaInfo { get; set; }
        public class GetVmMetaResponseBodyVmMetaInfo : TeaModel {
            /// <summary>
            /// <para>The content of the EnvoyEnv file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>....</para>
            /// </summary>
            [NameInMap("EnvoyEnvContent")]
            [Validation(Required=false)]
            public string EnvoyEnvContent { get; set; }

            /// <summary>
            /// <para>The content of the hosts file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>....</para>
            /// </summary>
            [NameInMap("HostsContent")]
            [Validation(Required=false)]
            public string HostsContent { get; set; }

            /// <summary>
            /// <para>The content of the Token file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>....</para>
            /// </summary>
            [NameInMap("TokenContent")]
            [Validation(Required=false)]
            public string TokenContent { get; set; }

        }

    }

}
