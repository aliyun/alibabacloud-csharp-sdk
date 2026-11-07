// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayRouteShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
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
        /// <para>The route description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a route for xxx</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Single: single service</description></item>
        /// <item><description>Multiple: multiple services</description></item>
        /// <item><description>VersionOriented: tag-based routing</description></item>
        /// <item><description>Mock: mock</description></item>
        /// <item><description>Redirect: redirect</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Multiple</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The mock response configuration.</para>
        /// </summary>
        [NameInMap("DirectResponseJSON")]
        [Validation(Required=false)]
        public string DirectResponseJSONShrink { get; set; }

        /// <summary>
        /// <para>The domain name ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

        /// <summary>
        /// <para>The domain name list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0,94]</para>
        /// </summary>
        [NameInMap("DomainIdListJSON")]
        [Validation(Required=false)]
        public string DomainIdListJSON { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use UpdateGatewayRouteWafStatus to update the WAF status of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? EnableWaf { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the fallback service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Fallback")]
        [Validation(Required=false)]
        public bool? Fallback { get; set; }

        /// <summary>
        /// <para>The fallback service.</para>
        /// </summary>
        [NameInMap("FallbackServices")]
        [Validation(Required=false)]
        public string FallbackServicesShrink { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>526</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-492af9b04bb4474cae9d645be8*****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The route name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The JSON string of the route policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CORS&quot;:&quot;{\&quot;allowMethods\&quot;:\&quot;GET,POST,PUT,DELETE,HEAD,OPTIONS,PATCH\&quot;,\&quot;allowHeaders\&quot;:\&quot;<em>\&quot;,\&quot;exposeHeaders\&quot;:\&quot;</em>\&quot;,\&quot;unitNum\&quot;:12,\&quot;allowCredentials\&quot;:true,\&quot;status\&quot;:\&quot;off\&quot;,\&quot;allowOrigins\&quot;:\&quot;*\&quot;,\&quot;timeUnit\&quot;:\&quot;h\&quot;}&quot;,&quot;Timeout&quot;:&quot;{\&quot;unitNum\&quot;:10,\&quot;timeUnit\&quot;:\&quot;s\&quot;,\&quot;status\&quot;:\&quot;off\&quot;}&quot;,&quot;Retry&quot;:&quot;{\&quot;attempts\&quot;:2,\&quot;retryOn\&quot;:[\&quot;5xx\&quot;],\&quot;status\&quot;:\&quot;off\&quot;}&quot;,&quot;HTTPRewrite&quot;:&quot;{\&quot;pathType\&quot;:\&quot;EQUAL\&quot;,\&quot;path\&quot;:\&quot;/o\&quot;,\&quot;status\&quot;:\&quot;off\&quot;}&quot;,&quot;Waf&quot;:&quot;{\&quot;enabled\&quot;:false}&quot;,&quot;HeaderOp&quot;:&quot;{\&quot;status\&quot;:\&quot;off\&quot;,\&quot;headerOpItems\&quot;:[{\&quot;directionType\&quot;:\&quot;Request\&quot;,\&quot;opType\&quot;:\&quot;Add\&quot;,\&quot;key\&quot;:\&quot;kkk\&quot;,\&quot;value\&quot;:\&quot;ll\&quot;}]}&quot;}</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public string Policies { get; set; }

        /// <summary>
        /// <para>The matching rules.</para>
        /// </summary>
        [NameInMap("Predicates")]
        [Validation(Required=false)]
        public string PredicatesShrink { get; set; }

        /// <summary>
        /// <para>The redirect configuration.</para>
        /// </summary>
        [NameInMap("RedirectJSON")]
        [Validation(Required=false)]
        public string RedirectJSONShrink { get; set; }

        /// <summary>
        /// <para>The route order. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RouteOrder")]
        [Validation(Required=false)]
        public int? RouteOrder { get; set; }

        /// <summary>
        /// <para>The route type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Op: management and control route</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Op</para>
        /// </summary>
        [NameInMap("RouteType")]
        [Validation(Required=false)]
        public string RouteType { get; set; }

        /// <summary>
        /// <para>The service list. This parameter is required when the route points to a single service, multiple services, or tag-based routing.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public string ServicesShrink { get; set; }

    }

}
