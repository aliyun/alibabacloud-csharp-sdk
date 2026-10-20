// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateResourcesDeleteProtectionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables deletion protection. After deletion protection is enabled, you must manually disable deletion protection before you can delete the specified resource.</para>
        /// </description></item>
        /// <item><description><para>false: Disables deletion protection.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The namespace of the resource.</para>
        /// <para>Default value: default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The type of resource to update. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>namespaces: namespace.</para>
        /// </description></item>
        /// <item><description><para>services: service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>services</para>
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of target resources.</para>
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<string> Resources { get; set; }

    }

}
