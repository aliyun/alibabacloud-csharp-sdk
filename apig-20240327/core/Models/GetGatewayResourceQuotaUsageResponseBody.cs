// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayResourceQuotaUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The quota query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;gatewayId&quot;:&quot;gw-d5be0s9q5z6f1234567g&quot;,&quot;observedAt&quot;:&quot;2026-09-17T08:00:00Z&quot;,&quot;items&quot;:[{&quot;quotaKey&quot;:&quot;Route&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:12,&quot;limit&quot;:800},{&quot;quotaKey&quot;:&quot;ConsumerAuthorizationRule&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:20,&quot;limit&quot;:1000},{&quot;quotaKey&quot;:&quot;McpServer&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:false},{&quot;quotaKey&quot;:&quot;Domain&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:2,&quot;limit&quot;:100},{&quot;quotaKey&quot;:&quot;Service&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:5,&quot;limit&quot;:800},{&quot;quotaKey&quot;:&quot;ConsumerQuotaRule&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:0,&quot;limit&quot;:1000},{&quot;quotaKey&quot;:&quot;K8sServiceSource&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:1,&quot;limit&quot;:3},{&quot;quotaKey&quot;:&quot;InstalledPlugin&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:2,&quot;limit&quot;:5},{&quot;quotaKey&quot;:&quot;CustomPlugin&quot;,&quot;usedScope&quot;:&quot;ACCOUNT_REGION&quot;,&quot;limitScope&quot;:&quot;ACCOUNT_GATEWAY_TYPE&quot;,&quot;applicable&quot;:false}]}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGatewayResourceQuotaUsageResponseBodyData Data { get; set; }
        public class GetGatewayResourceQuotaUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-d5be0s9q5z6f1234567g</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The resource quota items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;quotaKey&quot;:&quot;Route&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:12,&quot;limit&quot;:800},{&quot;quotaKey&quot;:&quot;ConsumerAuthorizationRule&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:20,&quot;limit&quot;:1000},{&quot;quotaKey&quot;:&quot;McpServer&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:false},{&quot;quotaKey&quot;:&quot;Domain&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:2,&quot;limit&quot;:100},{&quot;quotaKey&quot;:&quot;Service&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:5,&quot;limit&quot;:800},{&quot;quotaKey&quot;:&quot;ConsumerQuotaRule&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:0,&quot;limit&quot;:1000},{&quot;quotaKey&quot;:&quot;K8sServiceSource&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:1,&quot;limit&quot;:3},{&quot;quotaKey&quot;:&quot;InstalledPlugin&quot;,&quot;usedScope&quot;:&quot;GATEWAY&quot;,&quot;limitScope&quot;:&quot;GATEWAY&quot;,&quot;applicable&quot;:true,&quot;used&quot;:2,&quot;limit&quot;:5},{&quot;quotaKey&quot;:&quot;CustomPlugin&quot;,&quot;usedScope&quot;:&quot;ACCOUNT_REGION&quot;,&quot;limitScope&quot;:&quot;ACCOUNT_GATEWAY_TYPE&quot;,&quot;applicable&quot;:false}]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetGatewayResourceQuotaUsageResponseBodyDataItems> Items { get; set; }
            public class GetGatewayResourceQuotaUsageResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Indicates whether quota numerical values are provided.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("applicable")]
                [Validation(Required=false)]
                public bool? Applicable { get; set; }

                /// <summary>
                /// <para>The effective limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("limit")]
                [Validation(Required=false)]
                public long? Limit { get; set; }

                /// <summary>
                /// <para>The scope to which the limit applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GATEWAY</para>
                /// </summary>
                [NameInMap("limitScope")]
                [Validation(Required=false)]
                public string LimitScope { get; set; }

                /// <summary>
                /// <para>The quota metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Route</para>
                /// </summary>
                [NameInMap("quotaKey")]
                [Validation(Required=false)]
                public string QuotaKey { get; set; }

                /// <summary>
                /// <para>The current usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

                /// <summary>
                /// <para>The scope for usage statistics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GATEWAY</para>
                /// </summary>
                [NameInMap("usedScope")]
                [Validation(Required=false)]
                public string UsedScope { get; set; }

            }

            /// <summary>
            /// <para>The time when the statistics collection was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-17T08:00:00Z</para>
            /// </summary>
            [NameInMap("observedAt")]
            [Validation(Required=false)]
            public string ObservedAt { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified gateway does not exist.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0A6A1A0-8793-4C10-AB1A-2C03E770A912</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
