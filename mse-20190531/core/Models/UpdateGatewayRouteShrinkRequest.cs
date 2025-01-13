// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a route for xxx</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination service type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mock</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The information about service mocking.</para>
        /// </summary>
        [NameInMap("DirectResponseJSON")]
        [Validation(Required=false)]
        public string DirectResponseJSONShrink { get; set; }

        /// <summary>
        /// <para>The associated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[90]</para>
        /// </summary>
        [NameInMap("DomainIdListJSON")]
        [Validation(Required=false)]
        public string DomainIdListJSON { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to activate Web Application Firewall (WAF).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? EnableWaf { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Fallback service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Fallback")]
        [Validation(Required=false)]
        public bool? Fallback { get; set; }

        /// <summary>
        /// <para>The information about the Fallback service.</para>
        /// </summary>
        [NameInMap("FallbackServices")]
        [Validation(Required=false)]
        public string FallbackServicesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>501</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-86575c0bc9f04ecfbacb92b8e392a2c4</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The ID of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The name of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>route-web</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        [Obsolete]
        public string Name { get; set; }

        /// <summary>
        /// <para>The route matching conditions.</para>
        /// </summary>
        [NameInMap("Predicates")]
        [Validation(Required=false)]
        public string PredicatesShrink { get; set; }

        /// <summary>
        /// <para>The information about redirection.</para>
        /// </summary>
        [NameInMap("RedirectJSON")]
        [Validation(Required=false)]
        public string RedirectJSONShrink { get; set; }

        /// <summary>
        /// <para>The sequence number of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RouteOrder")]
        [Validation(Required=false)]
        public int? RouteOrder { get; set; }

        /// <summary>
        /// <para>The information about destination services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public string ServicesShrink { get; set; }

    }

}
