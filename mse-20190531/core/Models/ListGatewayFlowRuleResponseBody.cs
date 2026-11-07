// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayFlowRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The Meta return information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayFlowRuleResponseBodyData Data { get; set; }
        public class ListGatewayFlowRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the instance list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of rows per page set during input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayFlowRuleResponseBodyDataResult> Result { get; set; }
            public class ListGatewayFlowRuleResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The Web fallback behavior type.</para>
                /// <para>0: Return specified content</para>
                /// <para>1: Redirect to specified page</para>
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
                /// <para>Indicates whether the rule is enabled.</para>
                /// <para>0: Disabled.</para>
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
                /// <para>14407</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique gateway identity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-e2d226bba4b2445c9e29fa7f8216****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The routing throttle rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>549</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

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
                /// <para>The routing ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48811</para>
                /// </summary>
                [NameInMap("RouteId")]
                [Validation(Required=false)]
                public long? RouteId { get; set; }

                /// <summary>
                /// <para>The routing name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>routeA</para>
                /// </summary>
                [NameInMap("RouteName")]
                [Validation(Required=false)]
                public string RouteName { get; set; }

                /// <summary>
                /// <para>The overall QPS threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public int? Threshold { get; set; }

            }

            /// <summary>
            /// <para>The paged data collection.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ListGatewayFlowRuleResponseBodyDataResults> Results { get; set; }
            public class ListGatewayFlowRuleResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The Web fallback behavior type.</para>
                /// <para>0: Return specified content</para>
                /// <para>1: Redirect to specified page</para>
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
                /// <para>Indicates whether the rule is enabled.</para>
                /// <para>0: Disabled.</para>
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
                /// <para>14407</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique gateway identity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-e2d226bba4b2445c9e29fa7f8216****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The routing throttle rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>549</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The filtered rule IDs.</para>
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
                /// <para>The custom headers, entered as key-value pairs.</para>
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
                /// <para>429</para>
                /// </summary>
                [NameInMap("ResponseStatusCode")]
                [Validation(Required=false)]
                public int? ResponseStatusCode { get; set; }

                /// <summary>
                /// <para>The routing ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48811</para>
                /// </summary>
                [NameInMap("RouteId")]
                [Validation(Required=false)]
                public long? RouteId { get; set; }

                /// <summary>
                /// <para>The routing name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>routeA</para>
                /// </summary>
                [NameInMap("RouteName")]
                [Validation(Required=false)]
                public string RouteName { get; set; }

                /// <summary>
                /// <para>The statistics duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("StatDurationMs")]
                [Validation(Required=false)]
                public int? StatDurationMs { get; set; }

                /// <summary>
                /// <para>The overall QPS threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public int? Threshold { get; set; }

            }

            /// <summary>
            /// <para>The total number of instances queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0951EBF0-798E-5E0B-8D38-460A14AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
