// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListSubscriptionsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>agent-rca-001</para>
        /// </summary>
        [NameInMap("agentUuid")]
        [Validation(Required=false)]
        public string AgentUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2-3408-4595-9d80-****</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1a2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d</para>
        /// </summary>
        [NameInMap("notifyStrategyUuid")]
        [Validation(Required=false)]
        public string NotifyStrategyUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123123123123</para>
        /// </summary>
        [NameInMap("subscriptionId")]
        [Validation(Required=false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试订阅</para>
        /// </summary>
        [NameInMap("subscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("subscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("unbound")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? Unbound { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
