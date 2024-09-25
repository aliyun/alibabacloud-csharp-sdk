// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayFlowRuleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateGatewayFlowRuleResponseBodyData Data { get; set; }
        public class UpdateGatewayFlowRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BehaviorType")]
            [Validation(Required=false)]
            public int? BehaviorType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BodyEncoding")]
            [Validation(Required=false)]
            public int? BodyEncoding { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>14407</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-e2d226bba4b2445c9e29fa7f8216****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>549</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IdList")]
            [Validation(Required=false)]
            public List<long?> IdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LimitMode")]
            [Validation(Required=false)]
            public int? LimitMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>key=value</para>
            /// </summary>
            [NameInMap("ResponseAdditionalHeaders")]
            [Validation(Required=false)]
            public string ResponseAdditionalHeaders { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Text</para>
            /// </summary>
            [NameInMap("ResponseContentBody")]
            [Validation(Required=false)]
            public string ResponseContentBody { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>www.******.com</para>
            /// </summary>
            [NameInMap("ResponseRedirectUrl")]
            [Validation(Required=false)]
            public string ResponseRedirectUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>429</para>
            /// </summary>
            [NameInMap("ResponseStatusCode")]
            [Validation(Required=false)]
            public int? ResponseStatusCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>48811</para>
            /// </summary>
            [NameInMap("RouteId")]
            [Validation(Required=false)]
            public long? RouteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>routeA</para>
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("StatDurationMs")]
            [Validation(Required=false)]
            public int? StatDurationMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2B74E7F7-DF54-5AB1-B8F2-67391B83****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
