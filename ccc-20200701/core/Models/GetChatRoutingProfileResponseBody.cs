// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetChatRoutingProfileResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetChatRoutingProfileResponseBodyData Data { get; set; }
        public class GetChatRoutingProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;AllowExceedingLimitWhenTransferring&quot;: false,
            ///     &quot;ConcurrencyLimit&quot;: 4,
            ///     &quot;AllowExceedingLimitWhenClaiming&quot;: true,
            ///     &quot;Enabled&quot;: true
            /// }</para>
            /// </summary>
            [NameInMap("AgentConcurrencySettings")]
            [Validation(Required=false)]
            public string AgentConcurrencySettings { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;IdleChatTimeoutSeconds&quot;:300}</para>
            /// </summary>
            [NameInMap("ChatSettings")]
            [Validation(Required=false)]
            public string ChatSettings { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;AgentRingTimeoutSeconds&quot;: 30,
            ///     &quot;Enabled&quot;: true,
            ///     &quot;MaxNumberOfConversationsAgentCanMiss&quot;: 5,
            ///     &quot;PostAgentMissingConversionsAction&quot;: &quot;Nothing&quot;
            /// }</para>
            /// </summary>
            [NameInMap("DistributionSettings")]
            [Validation(Required=false)]
            public string DistributionSettings { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Automatic</para>
            /// </summary>
            [NameInMap("RoutingType")]
            [Validation(Required=false)]
            public string RoutingType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30C7D235-DDCF-4C7F-A462-5E2598252C2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
