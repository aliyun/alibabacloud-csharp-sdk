// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateGatewayCircuitBreakerRuleRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want the results to be displayed. Valid values: zh (default): Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The type of the web fallback behavior.</para>
        /// <para>0: returns the specified content.</para>
        /// <para>1: redirects to the specified page.</para>
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
        /// <para>gw-c9bc5afd61014165bd58f621b491*****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The threshold in slow call proportion mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxAllowedMs")]
        [Validation(Required=false)]
        public int? MaxAllowedMs { get; set; }

        /// <summary>
        /// <para>The minimum number of requests to trigger circuit breaking.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinRequestAmount")]
        [Validation(Required=false)]
        public int? MinRequestAmount { get; set; }

        /// <summary>
        /// <para>The circuit breaking timeout period.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("RecoveryTimeoutSec")]
        [Validation(Required=false)]
        public int? RecoveryTimeoutSec { get; set; }

        /// <summary>
        /// <para>The HTTP text to be returned.</para>
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
        /// <para>645</para>
        /// </summary>
        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public long? RouteId { get; set; }

        /// <summary>
        /// <para>The route name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>routeName</para>
        /// </summary>
        [NameInMap("RouteName")]
        [Validation(Required=false)]
        public string RouteName { get; set; }

        /// <summary>
        /// <para>The statistical duration for triggering circuit breaking.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("StatDurationSec")]
        [Validation(Required=false)]
        public int? StatDurationSec { get; set; }

        /// <summary>
        /// <para>The type of the threshold.</para>
        /// <para>0: slow call proportion</para>
        /// <para>1: failure proportion</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public int? Strategy { get; set; }

        /// <summary>
        /// <para>The request percentage that triggers circuit breaking.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TriggerRatio")]
        [Validation(Required=false)]
        public int? TriggerRatio { get; set; }

    }

}
