// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class Runtime : TeaModel {
        /// <summary>
        /// <para>Specifies the container runtime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>containerd</c>: Recommended. Supported in version 1.20 and later.</description></item>
        /// <item><description><c>Sandboxed-Container.runv</c>: Sandboxed container that provides higher isolation. Supported in version 1.16 and later.</description></item>
        /// <item><description><c>docker</c>: Supported in clusters of version 1.22 and earlier.</description></item>
        /// </list>
        /// <para>Default value: <c>containerd</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>containerd</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The container runtime version. By default, the latest version is used. For more information about the release notes, see <a href="https://help.aliyun.com/document_detail/207829.html">Container runtime release notes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.6.20</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
