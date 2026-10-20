// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StandardComponentsValue : Darabonba.Model {
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
        /// <para>The description of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the component is required for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The component is required and must be installed when the cluster is created.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The component is not required. You can install it through component management after the cluster is created.</para>
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
        /// <para>Specifies whether to disable default installation. When a cluster is created, in addition to the required components, some log-related or routing-related components (such as Ingress) are installed by default. If you do not want these components to be installed by default, set this parameter to disable default installation. Valid values:</para>
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

