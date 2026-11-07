// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayCircuitBreakerRuleRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned results. Valid values: zh (default): Chinese, en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The web fallback behavior type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Return specified text.</description></item>
        /// <item><description>1: Redirect to a specified page.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BehaviorType")]
        [Validation(Required=false)]
        public int? BehaviorType { get; set; }

        /// <summary>
        /// <para>The encoding type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Plain text.</description></item>
        /// <item><description>1: JSON.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BodyEncoding")]
        [Validation(Required=false)]
        public int? BodyEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Disabled.</description></item>
        /// <item><description>1: Enabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>The ID of the gateway.</para>
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
        /// <para>gw-c9bc5afd61014165bd58f621b491****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The ID of the circuit breaker rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>369</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The slow call threshold in slow call mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxAllowedMs")]
        [Validation(Required=false)]
        public int? MaxAllowedMs { get; set; }

        /// <summary>
        /// <para>The minimum number of requests that triggers circuit breaking.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinRequestAmount")]
        [Validation(Required=false)]
        public int? MinRequestAmount { get; set; }

        /// <summary>
        /// <para>The recovery duration for circuit breaking.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("RecoveryTimeoutSec")]
        [Validation(Required=false)]
        public int? RecoveryTimeoutSec { get; set; }

        /// <summary>
        /// <para>The HTTP response text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ResponseContentBody")]
        [Validation(Required=false)]
        public string ResponseContentBody { get; set; }

        /// <summary>
        /// <para>The redirect URL.</para>
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
        /// <para>The ID of the route.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>645</para>
        /// </summary>
        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public long? RouteId { get; set; }

        /// <summary>
        /// <para>The name of the route.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>routeName</para>
        /// </summary>
        [NameInMap("RouteName")]
        [Validation(Required=false)]
        public string RouteName { get; set; }

        /// <summary>
        /// <para>The statistical duration for circuit breaking.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("StatDurationSec")]
        [Validation(Required=false)]
        public int? StatDurationSec { get; set; }

        /// <summary>
        /// <para>The threshold type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Slow call.</description></item>
        /// <item><description>1: Exception.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public int? Strategy { get; set; }

        /// <summary>
        /// <para>The percentage that triggers circuit breaking.</para>
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
