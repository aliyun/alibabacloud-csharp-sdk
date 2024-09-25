// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayIsolationRuleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateGatewayIsolationRuleResponseBodyData Data { get; set; }
        public class UpdateGatewayIsolationRuleResponseBodyData : TeaModel {
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
            /// <para>358</para>
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
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxConcurrency")]
            [Validation(Required=false)]
            public int? MaxConcurrency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>key=value</para>
            /// </summary>
            [NameInMap("ResponseAdditionalHeaders")]
            [Validation(Required=false)]
            public string ResponseAdditionalHeaders { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text</para>
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
            /// <para>52853</para>
            /// </summary>
            [NameInMap("RouteId")]
            [Validation(Required=false)]
            public long? RouteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>routeName</para>
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>94B12406-E44D-57C9-BF93-A8B35BFF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
