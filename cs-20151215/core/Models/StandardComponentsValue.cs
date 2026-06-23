// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StandardComponentsValue : TeaModel {
        /// <summary>
        /// <para>The component name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-arena</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The component version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The description of the component features.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the component is required by the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The component is required and must be installed when the cluster is created.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The component is optional and can be installed through Component Management after the cluster is created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("required")]
        [Validation(Required=false)]
        public string Required { get; set; }

        /// <summary>
        /// <para>Indicates whether default installation is disabled. When a cluster is created, in addition to the components required by the cluster, some logging or routing-related components (such as Ingress) are also installed by default. If you do not want to install them by default, you can set this field to disable default installation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Default installation is disabled.</description></item>
        /// <item><description><c>false</c>: Default installation is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

    }

}
