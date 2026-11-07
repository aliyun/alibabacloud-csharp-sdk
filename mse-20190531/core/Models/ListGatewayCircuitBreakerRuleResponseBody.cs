// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayCircuitBreakerRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayCircuitBreakerRuleResponseBodyData Data { get; set; }
        public class ListGatewayCircuitBreakerRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the instance list</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of rows per page set during input</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayCircuitBreakerRuleResponseBodyDataResult> Result { get; set; }
            public class ListGatewayCircuitBreakerRuleResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The Web fallback behavior type.</para>
                /// <para>0: Return specified content.</para>
                /// <para>1: Redirect to a specified page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BehaviorType")]
                [Validation(Required=false)]
                public int? BehaviorType { get; set; }

                /// <summary>
                /// <para>The encoding type.</para>
                /// <para>0: Plain text</para>
                /// <para>1: JSON</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BodyEncoding")]
                [Validation(Required=false)]
                public int? BodyEncoding { get; set; }

                /// <summary>
                /// <para>Whether to enable.</para>
                /// <para>0: Not enabled.</para>
                /// <para>1: Enabled.</para>
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
                /// <para>11919</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique ID of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-5017305290e14centbrveca****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The circuit breaker rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>467</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The filter rule id</para>
                /// </summary>
                [NameInMap("IdList")]
                [Validation(Required=false)]
                public List<long?> IdList { get; set; }

                /// <summary>
                /// <para>The threshold conversion mode.</para>
                /// <para>0: Single machine.</para>
                /// <para>1: Cluster.</para>
                /// <para>2: Cluster to single machine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LimitMode")]
                [Validation(Required=false)]
                public int? LimitMode { get; set; }

                /// <summary>
                /// <para>The slow call threshold in slow call pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("MaxAllowedMs")]
                [Validation(Required=false)]
                public int? MaxAllowedMs { get; set; }

                /// <summary>
                /// <para>The minimum number of requests to trigger circuit breaking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MinRequestAmount")]
                [Validation(Required=false)]
                public int? MinRequestAmount { get; set; }

                /// <summary>
                /// <para>The circuit breaking recovery duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("RecoveryTimeoutSec")]
                [Validation(Required=false)]
                public int? RecoveryTimeoutSec { get; set; }

                /// <summary>
                /// <para>The custom header, input as key-value pairs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key=value</para>
                /// </summary>
                [NameInMap("ResponseAdditionalHeaders")]
                [Validation(Required=false)]
                public string ResponseAdditionalHeaders { get; set; }

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
                /// <para>204</para>
                /// </summary>
                [NameInMap("ResponseStatusCode")]
                [Validation(Required=false)]
                public int? ResponseStatusCode { get; set; }

                /// <summary>
                /// <para>The route ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3091</para>
                /// </summary>
                [NameInMap("RouteId")]
                [Validation(Required=false)]
                public long? RouteId { get; set; }

                /// <summary>
                /// <para>The route name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>routeName</para>
                /// </summary>
                [NameInMap("RouteName")]
                [Validation(Required=false)]
                public string RouteName { get; set; }

                /// <summary>
                /// <para>The circuit breaking statistics duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("StatDurationSec")]
                [Validation(Required=false)]
                public int? StatDurationSec { get; set; }

                /// <summary>
                /// <para>The threshold pattern.</para>
                /// <para>0: Slow call pattern.</para>
                /// <para>1: Exception pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public int? Strategy { get; set; }

                /// <summary>
                /// <para>The percentage to trigger circuit breaking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TriggerRatio")]
                [Validation(Required=false)]
                public int? TriggerRatio { get; set; }

            }

            /// <summary>
            /// <para>The returned result collection.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ListGatewayCircuitBreakerRuleResponseBodyDataResults> Results { get; set; }
            public class ListGatewayCircuitBreakerRuleResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The Web fallback behavior type.</para>
                /// <para>0: Return specified content</para>
                /// <para>1: Redirect to a specified page</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BehaviorType")]
                [Validation(Required=false)]
                public int? BehaviorType { get; set; }

                /// <summary>
                /// <para>The encoding type.</para>
                /// <para>0: Plain text</para>
                /// <para>1: JSON</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BodyEncoding")]
                [Validation(Required=false)]
                public int? BodyEncoding { get; set; }

                /// <summary>
                /// <para>Whether to enable.</para>
                /// <para>0: Not enabled.</para>
                /// <para>1: Enabled.</para>
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
                /// <para>11919</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique ID of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-1ee34548c68f4778a25c05abd657****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The circuit breaker rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>467</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The filter rule id</para>
                /// </summary>
                [NameInMap("IdList")]
                [Validation(Required=false)]
                public List<long?> IdList { get; set; }

                /// <summary>
                /// <para>The threshold conversion mode.</para>
                /// <para>0: Single machine.</para>
                /// <para>1: Cluster.</para>
                /// <para>2: Cluster to single machine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LimitMode")]
                [Validation(Required=false)]
                public int? LimitMode { get; set; }

                /// <summary>
                /// <para>The slow call threshold in slow call pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxAllowedMs")]
                [Validation(Required=false)]
                public int? MaxAllowedMs { get; set; }

                /// <summary>
                /// <para>The minimum number of requests to trigger circuit breaking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MinRequestAmount")]
                [Validation(Required=false)]
                public int? MinRequestAmount { get; set; }

                /// <summary>
                /// <para>The circuit breaking recovery duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("RecoveryTimeoutSec")]
                [Validation(Required=false)]
                public int? RecoveryTimeoutSec { get; set; }

                /// <summary>
                /// <para>The custom header, input as key-value pairs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key=value</para>
                /// </summary>
                [NameInMap("ResponseAdditionalHeaders")]
                [Validation(Required=false)]
                public string ResponseAdditionalHeaders { get; set; }

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
                /// <para>204</para>
                /// </summary>
                [NameInMap("ResponseStatusCode")]
                [Validation(Required=false)]
                public int? ResponseStatusCode { get; set; }

                /// <summary>
                /// <para>The route ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3450</para>
                /// </summary>
                [NameInMap("RouteId")]
                [Validation(Required=false)]
                public long? RouteId { get; set; }

                /// <summary>
                /// <para>The route name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>routeName</para>
                /// </summary>
                [NameInMap("RouteName")]
                [Validation(Required=false)]
                public string RouteName { get; set; }

                /// <summary>
                /// <para>The circuit breaking statistics duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("StatDurationSec")]
                [Validation(Required=false)]
                public int? StatDurationSec { get; set; }

                /// <summary>
                /// <para>The threshold pattern.</para>
                /// <para>0: Slow call pattern.</para>
                /// <para>1: Exception pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public int? Strategy { get; set; }

                /// <summary>
                /// <para>The percentage to trigger circuit breaking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TriggerRatio")]
                [Validation(Required=false)]
                public int? TriggerRatio { get; set; }

            }

            /// <summary>
            /// <para>The total number of instances queried</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC34E4A3-5F1C-4E40-86EA-02EDF967****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
