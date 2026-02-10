// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPolicyClassesRequest : TeaModel {
        /// <summary>
        /// <para>The resource ID to attach the policy</para>
        /// 
        /// <b>Example:</b>
        /// <para>route-001</para>
        /// </summary>
        [NameInMap("attachResourceId")]
        [Validation(Required=false)]
        public string AttachResourceId { get; set; }

        /// <summary>
        /// <para>The supported mount point type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HttpApi: an HTTP API</description></item>
        /// <item><description>Operation: an operation in an HTTP API</description></item>
        /// <item><description>GatewayRoute: a route</description></item>
        /// <item><description>GatewayService: a service</description></item>
        /// <item><description>GatewayServicePort: a service port</description></item>
        /// <item><description>Domain: a domain name</description></item>
        /// <item><description>Gateway: an instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Operation</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <para>The direction of traffic on which the policy takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OutBound</description></item>
        /// <item><description>InBound</description></item>
        /// <item><description>Both</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InBound</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The gateway ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-001</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: 1.</para>
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
        /// <para>The template type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FlowControl</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
