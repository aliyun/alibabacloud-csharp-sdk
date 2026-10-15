// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class ContainerConfiguration : TeaModel {
        /// <summary>
        /// <para>The instance ID of the Container Registry Enterprise instance. Required when registryType is set to acree.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-****</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The base image address of the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/sandbox-demo/python:3.12</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The repository access credentials used to pull the image. Not required when using a public image.</para>
        /// </summary>
        [NameInMap("registryCredential")]
        [Validation(Required=false)]
        public ContainerConfigurationRegistryCredential RegistryCredential { get; set; }
        public class ContainerConfigurationRegistryCredential : TeaModel {
            /// <summary>
            /// <para>The logon password or access token for the image repository. Stored with server-side encryption and not returned in plaintext when queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Passw0rd****</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The username for logging on to the image repository.</para>
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
