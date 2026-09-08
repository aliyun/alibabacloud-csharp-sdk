// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetChatRoutingProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetChatRoutingProfileResponseBodyData Data { get; set; }
        public class GetChatRoutingProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Agent session concurrent configuration.</para>
            /// <list type="bullet">
            /// <item><description><para>AllowExceedingLimitWhenTransferring: Allow exceeding the limit when transferring. When transferring sessions to other agents, exceeding the recipient\&quot;s limit is allowed, but the total cannot exceed 30.</para>
            /// </description></item>
            /// <item><description><para>AllowExceedingLimitWhenClaiming: Allow exceeding the limit when claiming. When an agent actively claims sessions from the queue, exceeding the limit is allowed, but the total cannot exceed 30.</para>
            /// </description></item>
            /// <item><description><para>ConcurrencyLimit: The number of network business sessions an agent can process simultaneously.</para>
            /// </description></item>
            /// <item><description><para>Enabled: Enable this configuration.</para>
            /// </description></item>
            /// </list>
            /// 
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
            /// <para>Session configuration.</para>
            /// <list type="bullet">
            /// <item><description>IdleChatTimeoutSeconds: Automatic session end time. If no customer response is received within a specific period, the system ends the session. Unit: seconds.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;IdleChatTimeoutSeconds&quot;:300}</para>
            /// </summary>
            [NameInMap("ChatSettings")]
            [Validation(Required=false)]
            public string ChatSettings { get; set; }

            /// <summary>
            /// <para>Agent session allocation configuration.</para>
            /// <list type="bullet">
            /// <item><description><para>AgentRingTimeoutSeconds: Agent processing timeout limit.</para>
            /// </description></item>
            /// <item><description><para>MaxNumberOfConversationsAgentCanMiss: The maximum number of consecutive unanswered sessions an agent can miss.</para>
            /// </description></item>
            /// <item><description><para>PostAgentMissingConversionsAction: After an agent misses more than the set number of consecutive responses, the system sets the agent\&quot;s status, such as Break, Invisible, or Nothing (remain unchanged).</para>
            /// </description></item>
            /// <item><description><para>Enabled: Enable.</para>
            /// </description></item>
            /// </list>
            /// 
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
            /// <para>Call distribution type.</para>
            /// <list type="bullet">
            /// <item><description><para>Automatic distribution (Automatic).</para>
            /// </description></item>
            /// <item><description><para>Manual distribution (Manual).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Automatic</para>
            /// </summary>
            [NameInMap("RoutingType")]
            [Validation(Required=false)]
            public string RoutingType { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30C7D235-DDCF-4C7F-A462-5E2598252C2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
