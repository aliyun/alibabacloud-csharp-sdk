// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListSwimmingLaneGatewayRoutesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The request was successful.</description></item>
        /// <item><description><b>3xx</b>: The request was redirected.</description></item>
        /// <item><description><b>4xx</b>: The request failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Responses.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSwimmingLaneGatewayRoutesResponseBodyData> Data { get; set; }
        public class ListSwimmingLaneGatewayRoutesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16933</para>
            /// </summary>
            [NameInMap("RouteId")]
            [Validation(Required=false)]
            public long? RouteId { get; set; }

            /// <summary>
            /// <para>The name of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-route</para>
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

            /// <summary>
            /// <para>The routing rule.</para>
            /// </summary>
            [NameInMap("RoutePredicate")]
            [Validation(Required=false)]
            public ListSwimmingLaneGatewayRoutesResponseBodyDataRoutePredicate RoutePredicate { get; set; }
            public class ListSwimmingLaneGatewayRoutesResponseBodyDataRoutePredicate : TeaModel {
                /// <summary>
                /// <para>The path matching rule.</para>
                /// </summary>
                [NameInMap("PathPredicate")]
                [Validation(Required=false)]
                public ListSwimmingLaneGatewayRoutesResponseBodyDataRoutePredicatePathPredicate PathPredicate { get; set; }
                public class ListSwimmingLaneGatewayRoutesResponseBodyDataRoutePredicatePathPredicate : TeaModel {
                    /// <summary>
                    /// <para>The route URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/Path</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The type of the protection rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Header</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The status code. Value values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the request failed, <b>ErrorCode</b> is returned. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The error message returned because the request is normal and <b>success</b> is returned.</description></item>
        /// <item><description>If the request is abnormal, the specific exception error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The configurations were obtained.</description></item>
        /// <item><description><b>false</b>: The configurations failed to be queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. This parameter is used to query the exact call information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622246421415014e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
