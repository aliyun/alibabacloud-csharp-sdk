// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeResourcesDeleteProtectionRequest : TeaModel {
        /// <summary>
        /// <para>The namespace of the resource to query.</para>
        /// <para>This parameter is required when resource_type is set to services. If this parameter is not specified, the namespace defaults to default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The name of the resource to query. Separate multiple resources with commas (,).</para>
        /// <list type="bullet">
        /// <item><description><para>If resource_type is set to namespaces, set this parameter to namespace names. If this parameter is not specified, the deletion protection status of all namespaces in the cluster is queried.</para>
        /// </description></item>
        /// <item><description><para>If resource_type is set to services, this parameter is required. Set this parameter to service names.</para>
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
