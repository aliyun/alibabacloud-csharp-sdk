// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeResourcesDeleteProtectionRequest : TeaModel {
        /// <summary>
        /// <para>The namespace in which the resources that you want to query reside.</para>
        /// <para>This parameter is required when you set resource_type to services. Default value: default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The names of the resources that you want to query. Separate multiple resource names with commas (,).</para>
        /// <list type="bullet">
        /// <item><description>When you set resource_type to namespaces, you must specify namespace names. If you leave this parameter empty, all namespaces in the cluster are queried.</description></item>
        /// <item><description>If you set resource_type to services, you must specify Service names.</description></item>
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
