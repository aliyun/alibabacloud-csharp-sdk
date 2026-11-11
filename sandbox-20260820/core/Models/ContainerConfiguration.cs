// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class ContainerConfiguration : TeaModel {
        /// <summary>
        /// <para>The ID of the Container Registry Enterprise instance. This parameter is required when registryType is set to acree.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-****</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The address of the sandbox base image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/sandbox-demo/python:3.12</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The repository access credentials used to pull images. You do not need to configure this parameter when you use public images.</para>
        /// </summary>
        [NameInMap("registryCredential")]
        [Validation(Required=false)]
        public ContainerConfigurationRegistryCredential RegistryCredential { get; set; }
        public class ContainerConfigurationRegistryCredential : TeaModel {
            /// <summary>
            /// <para>The logon password or access token for the image repository. The value is encrypted and stored on the server, and plaintext is not returned in query responses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Passw0rd****</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The logon username for the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sandbox-puller</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
