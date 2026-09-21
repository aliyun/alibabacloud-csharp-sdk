// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class ContainerConfiguration : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cri-****</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/sandbox-demo/python:3.12</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("registryCredential")]
        [Validation(Required=false)]
        public ContainerConfigurationRegistryCredential RegistryCredential { get; set; }
        public class ContainerConfigurationRegistryCredential : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Passw0rd****</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sandbox-puller</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
