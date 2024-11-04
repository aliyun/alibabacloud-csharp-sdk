// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionForModify : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public string NotifyStrategyId { get; set; }

        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public SubscriptionForModifyPushingSetting PushingSetting { get; set; }
        public class SubscriptionForModifyPushingSetting : TeaModel {
            [NameInMap("alertActionIds")]
            [Validation(Required=false)]
            public List<string> AlertActionIds { get; set; }

            [NameInMap("responsePlanId")]
            [Validation(Required=false)]
            public string ResponsePlanId { get; set; }

            [NameInMap("restoreActionIds")]
            [Validation(Required=false)]
            public List<string> RestoreActionIds { get; set; }

            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

    }

}
