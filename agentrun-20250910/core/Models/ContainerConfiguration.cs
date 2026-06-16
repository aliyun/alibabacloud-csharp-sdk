// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ContainerConfiguration : TeaModel {
        /// <summary>
        /// <para>The instance ID or name of Alibaba Cloud Container Registry (ACR).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xxxxx</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The sandbox entrypoint command. For example: [\&quot;python3\&quot;, \&quot;app.py\&quot;].</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3,app.py</para>
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <para>The container image URI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/my-namespace/agent-runtime:latest</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The source of the container image. Valid values: ACR (Alibaba Cloud Container Registry), ACREE (Alibaba Cloud Container Registry Enterprise Edition), and CUSTOM (a custom image repository).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACR</para>
        /// </summary>
        [NameInMap("imageRegistryType")]
        [Validation(Required=false)]
        public string ImageRegistryType { get; set; }

        /// <summary>
        /// <para>The listening port for the sandbox runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>自定义镜像仓库的配置信息，当imageRegistryType为CUSTOM时使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public RegistryConfig RegistryConfig { get; set; }

    }

}
