// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class UpdateChatRoutingProfileRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9cfad875-6260-4a53-ab6e-b13e3fb31f7d</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;RoutingType&quot;: &quot;Automatic&quot;,
        ///     &quot;AgentConcurrencySettings&quot;: {
        ///         &quot;AllowExceedingLimitWhenTransferring&quot;: false,
        ///         &quot;ConcurrencyLimit&quot;: 4,
        ///         &quot;AllowExceedingLimitWhenClaiming&quot;: true,
        ///         &quot;Enabled&quot;: true
        ///     },
        ///     &quot;ChatSettings&quot;: {
        ///         &quot;IdleChatTimeoutSeconds&quot;: 300
        ///     },
        ///     &quot;DistributionSettings&quot;: {
        ///         &quot;Enabled&quot;: true,
        ///         &quot;AgentRingTimeoutSeconds&quot;: 119,
        ///         &quot;MaxNumberOfConversationsAgentCanMiss&quot;: 5,
        ///         &quot;PostAgentMissingConversionsAction&quot;: &quot;Nothing&quot;
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("RoutingProfiles")]
        [Validation(Required=false)]
        public string RoutingProfiles { get; set; }

    }

}
