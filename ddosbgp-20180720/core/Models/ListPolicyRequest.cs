// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test**</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: Elastic Compute Service (ECS).</description></item>
        /// <item><description><b>slb</b>: Server Load Balancer (SLB).</description></item>
        /// <item><description><b>eip</b>: Elastic IP Address (EIP).</description></item>
        /// <item><description><b>gf-eip</b>: EIP with Anti-DDoS (Enhanced) enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only if Type is set to <c>default</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The type of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: the default mitigation policy.</description></item>
        /// <item><description><b>l3</b>: IP-specific mitigation policies.</description></item>
        /// <item><description><b>l4</b>: port-specific mitigation policies.</description></item>
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
