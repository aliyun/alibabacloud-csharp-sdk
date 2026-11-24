// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeResourcesDeleteProtectionRequest : TeaModel {
        /// <summary>
        /// <para>The namespace to which the resource to query belongs.</para>
        /// <para>This parameter is required when ResourceType is set to services. If this parameter is not specified, the default namespace is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The names of the resources to query. Separate multiple resource names with commas (,).</para>
        /// <list type="bullet">
        /// <item><description><para>If ResourceType is set to namespaces, specify the namespace names. If this parameter is left empty, the deletion protection status of all namespaces in the cluster is queried.</para>
        /// </description></item>
        /// <item><description><para>If ResourceType is set to services, this parameter is required. Specify the service names.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test1,test2</para>
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

    }

}
