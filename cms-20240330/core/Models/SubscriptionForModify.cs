// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionForModify : TeaModel {
        [NameInMap("agentConfig")]
        [Validation(Required=false)]
        public SubscriptionForModifyAgentConfig AgentConfig { get; set; }
        public class SubscriptionForModifyAgentConfig : TeaModel {
            [NameInMap("agentUuid")]
            [Validation(Required=false)]
            public string AgentUuid { get; set; }

            [NameInMap("routes")]
            [Validation(Required=false)]
            public List<NotifyRouteForSubscription> Routes { get; set; }

        }

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
        /// <para>The filter settings.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>The UUID of the notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public string NotifyStrategyId { get; set; }

        /// <summary>
        /// <para>The push settings.</para>
        /// </summary>
        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public SubscriptionForModifyPushingSetting PushingSetting { get; set; }
        public class SubscriptionForModifyPushingSetting : TeaModel {
            /// <summary>
            /// <para>The list of action plan IDs for alert pushing.</para>
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
            /// <para>The list of action integration plan IDs for recovery pushing.</para>
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
        /// <para>Specifies whether to subscribe to legacy product events (CMS 1.0, ARMS, or SLS events where workspace is null). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Subscribe.</description></item>
        /// <item><description>false or null: Do not subscribe.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("subscribeLegacyEvent")]
        [Validation(Required=false)]
        public bool? SubscribeLegacyEvent { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试订阅</para>
        /// </summary>
        [NameInMap("subscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        [NameInMap("workspaceFilterSetting")]
        [Validation(Required=false)]
        public WorkspaceFilterSetting WorkspaceFilterSetting { get; set; }

    }

}
