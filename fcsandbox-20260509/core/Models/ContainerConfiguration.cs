// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class ContainerConfiguration : TeaModel {
        /// <summary>
        /// <para>The ID of the ACR Enterprise instance to which the container image belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-abcd1234efgh</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The container image address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The repository credentials used to pull private images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;username&quot;:&quot;registry-user&quot;,&quot;password&quot;:&quot;******&quot;}</para>
        /// </summary>
        [NameInMap("registryCredential")]
        [Validation(Required=false)]
        public ContainerConfigurationRegistryCredential RegistryCredential { get; set; }
        public class ContainerConfigurationRegistryCredential : TeaModel {
            /// <summary>
            /// <para>The password of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The username of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-user</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
