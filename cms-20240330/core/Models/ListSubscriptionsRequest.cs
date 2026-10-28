// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListSubscriptionsRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the AI agent. This parameter is used to filter subscriptions of a specified AI agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-rca-001</para>
        /// </summary>
        [NameInMap("agentUuid")]
        [Validation(Required=false)]
        public string AgentUuid { get; set; }

        /// <summary>
        /// <para>The sort order of the returned versions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: Ascending order. </description></item>
        /// <item><description>desc: Descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Specifies whether the subscription is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The maximum number of results per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2-3408-4595-9d80-****</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The UUID of the notification policy. This parameter is used to filter subscriptions that are bound to a specified notification policy. The value is a 32-character string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d</para>
        /// </summary>
        [NameInMap("notifyStrategyUuid")]
        [Validation(Required=false)]
        public string NotifyStrategyUuid { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The ID of the subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123123123</para>
        /// </summary>
        [NameInMap("subscriptionId")]
        [Validation(Required=false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// <para>The name of the subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test subscription</para>
        /// </summary>
        [NameInMap("subscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// <para>The type of the subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: Standard subscription.</description></item>
        /// <item><description>AI_AGENT: AI agent subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("subscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> This is an internal reserved parameter. Do not use it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("unbound")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? Unbound { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
