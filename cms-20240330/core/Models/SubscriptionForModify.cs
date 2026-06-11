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
        /// <para>Description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Filter settings.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>Notification policy UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public string NotifyStrategyId { get; set; }

        /// <summary>
        /// <para>Push settings.</para>
        /// </summary>
        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public SubscriptionForModifyPushingSetting PushingSetting { get; set; }
        public class SubscriptionForModifyPushingSetting : TeaModel {
            /// <summary>
            /// <para>A list of alert push action plan IDs.</para>
            /// </summary>
            [NameInMap("alertActionIds")]
            [Validation(Required=false)]
            public List<string> AlertActionIds { get; set; }

            /// <summary>
            /// <para>Action plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123123</para>
            /// </summary>
            [NameInMap("responsePlanId")]
            [Validation(Required=false)]
            public string ResponsePlanId { get; set; }

            /// <summary>
            /// <para>A list of action integration plan IDs.</para>
            /// </summary>
            [NameInMap("restoreActionIds")]
            [Validation(Required=false)]
            public List<string> RestoreActionIds { get; set; }

            /// <summary>
            /// <para>Template UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123123</para>
            /// </summary>
            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        /// <summary>
        /// <para>Name.</para>
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
