// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test**</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The applicable product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ecs</b>: queries the default policy applicable to ECS.</para>
        /// </description></item>
        /// <item><description><para><b>slb</b>: queries the default policy applicable to SLB.</para>
        /// </description></item>
        /// <item><description><para><b>eip</b>: queries the default policy applicable to EIP.</para>
        /// </description></item>
        /// <item><description><para><b>gf-eip</b>: queries the default policy applicable to elastic IP addresses (EIPs) with Anti-DDoS Proxy Enabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when the policy type is <c>default</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>default</b>: the default mitigation policy.</para>
        /// </description></item>
        /// <item><description><para><b>l3</b>: the IP-specific mitigation policy.</para>
        /// </description></item>
        /// <item><description><para><b>l4</b>: the port-specific mitigation policy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>l3</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
