// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayFlowRuleRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want to display the results. Valid values: zh (default): Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The type of the web fallback behavior.</para>
        /// <para>0: returns the specified text</para>
        /// <para>1: redirects to the specified page</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BehaviorType")]
        [Validation(Required=false)]
        public int? BehaviorType { get; set; }

        /// <summary>
        /// <para>The encoding type.</para>
        /// <para>0: plain text</para>
        /// <para>1: JSON</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BodyEncoding")]
        [Validation(Required=false)]
        public int? BodyEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rule.</para>
        /// <para>0: disables the rule.</para>
        /// <para>1: enables the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14407</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-e2d226bba4b2445c9e29fa7f8216****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The ID of the throttling rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>549</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The returned HTTP text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ResponseContentBody")]
        [Validation(Required=false)]
        public string ResponseContentBody { get; set; }

        /// <summary>
        /// <para>The redirection URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www.******.com</para>
        /// </summary>
        [NameInMap("ResponseRedirectUrl")]
        [Validation(Required=false)]
        public string ResponseRedirectUrl { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>429</para>
        /// </summary>
        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public int? ResponseStatusCode { get; set; }

        /// <summary>
        /// <para>The route ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48811</para>
        /// </summary>
        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public long? RouteId { get; set; }

        /// <summary>
        /// <para>The route name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>routeA</para>
        /// </summary>
        [NameInMap("RouteName")]
        [Validation(Required=false)]
        public string RouteName { get; set; }

        /// <summary>
        /// <para>The overall queries per second (QPS) threshold.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public int? Threshold { get; set; }

    }

}
