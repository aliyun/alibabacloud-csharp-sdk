// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class Addon : TeaModel {
        /// <summary>
        /// <para>The configuration of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;IngressSlbNetworkType\&quot;:\&quot;internet\&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable default installation. When a cluster is created, required components and additional components such as log components are installed by default. You can disable this default behavior and install these components later by calling the component installation API or by using the console. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Disables default installation.</description></item>
        /// <item><description><c>false</c>: Allows default installation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>The name of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx-ingress-controller</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The version of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.9.3-aliyun.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
