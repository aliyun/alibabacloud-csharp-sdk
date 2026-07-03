// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPolicyClassesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the attached resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>route-001</para>
        /// </summary>
        [NameInMap("attachResourceId")]
        [Validation(Required=false)]
        public string AttachResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource to which the policy can be attached. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HttpApi: HttpApi.</description></item>
        /// <item><description>Operation: an operation of an HttpApi.</description></item>
        /// <item><description>GatewayRoute: a gateway route.</description></item>
        /// <item><description>GatewayService: a gateway service.</description></item>
        /// <item><description>GatewayServicePort: a gateway service port.</description></item>
        /// <item><description>Domain: a gateway domain name.</description></item>
        /// <item><description>Gateway: a gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Operation</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <para>The direction of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OutBound: outbound.</description></item>
        /// <item><description>InBound: inbound.</description></item>
        /// <item><description>Both: both directions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InBound</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-001</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The policy templatetype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FlowControl</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
