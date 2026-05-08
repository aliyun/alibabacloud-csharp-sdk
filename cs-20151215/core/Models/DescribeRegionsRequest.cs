// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The language in which the results are returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN</description></item>
        /// <item><description>en-US</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("acceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The type of the cluster.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ExternalKubernetes: registered clusters.</description></item>
        /// <item><description>ManagedKubernetes: managed clusters.</description></item>
        /// <item><description>Kubernetes: dedicated clusters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ManagedKubernetes</para>
        /// </summary>
        [NameInMap("clusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The subtype of the managed cluster.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Lingjun: ACK Lingjun clusters.</description></item>
        /// <item><description>Serverless: ACK serverless clusters.</description></item>
        /// <item><description>Default: ACK managed clusters.</description></item>
        /// <item><description>Edge: ACK Edge clusters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

    }

}
