// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RegistryConfig : TeaModel {
        /// <summary>
        /// <para>镜像仓库的认证配置信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public RegistryAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>镜像仓库的证书配置信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public RegistryCertConfig CertConfig { get; set; }

        /// <summary>
        /// <para>镜像仓库的网络配置信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public RegistryNetworkConfig NetworkConfig { get; set; }

    }

}
