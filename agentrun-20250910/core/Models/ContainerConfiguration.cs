// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ContainerConfiguration : TeaModel {
        /// <summary>
        /// <para>阿里云容器镜像服务（ACR）的实例ID或名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xxxxx</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>在容器中运行的命令（例如：[&quot;python3&quot;, &quot;app.py&quot;]）</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3,app.py</para>
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/my-namespace/agent-runtime:latest</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>容器镜像的来源类型，支持ACR（阿里云容器镜像服务）、ACREE（阿里云容器镜像服务企业版）、CUSTOM（自定义镜像仓库）</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACR</para>
        /// </summary>
        [NameInMap("imageRegistryType")]
        [Validation(Required=false)]
        public string ImageRegistryType { get; set; }

        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

    }

}
