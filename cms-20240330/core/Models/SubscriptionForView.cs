// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionForView : TeaModel {
        /// <summary>
        /// <para>The Agent configuration information.</para>
        /// </summary>
        [NameInMap("agentConfig")]
        [Validation(Required=false)]
        public SubscriptionForViewAgentConfig AgentConfig { get; set; }
        public class SubscriptionForViewAgentConfig : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the Agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-uuid-001</para>
            /// </summary>
            [NameInMap("agentUuid")]
            [Validation(Required=false)]
            public string AgentUuid { get; set; }

            /// <summary>
            /// <para>The list of Agent routing configurations.</para>
            /// </summary>
            [NameInMap("routes")]
            [Validation(Required=false)]
            public List<NotifyRouteForSubscription> Routes { get; set; }

        }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the subscription is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The filter settings.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>The UUID of the notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23123123</para>
        /// </summary>
        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public string NotifyStrategyId { get; set; }

        /// <summary>
        /// <para>The push settings.</para>
        /// </summary>
        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public SubscriptionForViewPushingSetting PushingSetting { get; set; }
        public class SubscriptionForViewPushingSetting : TeaModel {
            /// <summary>
            /// <para>The list of action integration IDs for alert pushing.</para>
            /// </summary>
            [NameInMap("alertActionIds")]
            [Validation(Required=false)]
            public List<string> AlertActionIds { get; set; }

            /// <summary>
            /// <para>The action plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123123</para>
            /// </summary>
            [NameInMap("responsePlanId")]
            [Validation(Required=false)]
            public string ResponsePlanId { get; set; }

            /// <summary>
            /// <para>The list of action integration IDs for recovery pushing.</para>
            /// </summary>
            [NameInMap("restoreActionIds")]
            [Validation(Required=false)]
            public List<string> RestoreActionIds { get; set; }

            /// <summary>
            /// <para>The UUID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123123</para>
            /// </summary>
            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether to subscribe to legacy product events (CMS 1.0, ARMS, or SLS events where workspace=null). Valid values: true: Subscribed. false or null: Not subscribed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("subscribeLegacyEvent")]
        [Validation(Required=false)]
        public bool? SubscribeLegacyEvent { get; set; }

        /// <summary>
        /// <para>The unique identifier of the subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123123123</para>
        /// </summary>
        [NameInMap("subscriptionId")]
        [Validation(Required=false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SubscriptionTest</para>
        /// </summary>
        [NameInMap("subscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// <para>The subscription type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("subscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

        /// <summary>
        /// <para>The source type of the synchronization policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;ARMS&quot;</para>
        /// </summary>
        [NameInMap("syncFromType")]
        [Validation(Required=false)]
        public string SyncFromType { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-23T02:29:02Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The workspace identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        /// <summary>
        /// <para>The workspace filter settings.</para>
        /// </summary>
        [NameInMap("workspaceFilterSetting")]
        [Validation(Required=false)]
        public WorkspaceFilterSetting WorkspaceFilterSetting { get; set; }

    }

}
