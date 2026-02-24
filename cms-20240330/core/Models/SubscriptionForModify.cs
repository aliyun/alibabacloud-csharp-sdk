// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionForModify : TeaModel {
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
        /// <para>Filtering settings.</para>
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
            /// <para>Alert push action plan ID list.</para>
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
            /// <para>Action integration plan ID list.</para>
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
        /// <para>Test subscription.</para>
        /// </summary>
        [NameInMap("subscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        [NameInMap("workspaceFilterSetting")]
        [Validation(Required=false)]
        public WorkspaceFilterSetting WorkspaceFilterSetting { get; set; }

    }

}
