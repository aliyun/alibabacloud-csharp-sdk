// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class Runtime : TeaModel {
        /// <summary>
        /// <para>The name of a container runtime. The following types of runtime are supported by Container Service for Kubernetes (ACK).</para>
        /// <list type="bullet">
        /// <item><description><c>containerd</c>: supports all Kubernetes versions. We recommend that you set the parameter to this value.</description></item>
        /// <item><description><c>Sandboxed-Container.runv</c>: Sandboxed container provides enhanced isolation and supports Kubernetes 1.24 and earlier.</description></item>
        /// <item><description><c>docker</c>: supports Kubernetes 1.22 and earlier.</description></item>
        /// </list>
        /// <para>Default value: <c>containerd</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>docker</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The version of the container runtime. By default, the latest version is used.</para>
        /// <para>For more information about the changes to Sandboxed-Container, see <a href="https://help.aliyun.com/document_detail/160312.html">Sandboxed-Container release notes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19.03.5</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
