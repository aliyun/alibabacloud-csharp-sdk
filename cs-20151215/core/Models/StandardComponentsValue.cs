// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StandardComponentsValue : TeaModel {
        /// <summary>
        /// <para>The name of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-arena</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The version of the component.</para>
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
        /// <para>Specifies whether the component is required for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The component is required and must be installed when the cluster is created.</para>
        /// </description></item>
        /// <item><description><para>false: The component is not required. You can install it in the Components module after the cluster is created.</para>
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
        /// <para>Specifies whether to disable the default installation of the component. When a cluster is created, components required for the cluster are installed. In addition, some components related to logs or routing, such as Ingress, are installed by default. If you do not want to install these components by default, you can set this parameter to disable the default installation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: disables the default installation.</description></item>
        /// <item><description>false: enables the default installation.</description></item>
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
