// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionAndNotifyStrategyForModify : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the subscription. Enabled by default during creation.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Optional. The backend derives the name from notifyStrategy if this parameter is not specified.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("notifyStrategy")]
        [Validation(Required=false)]
        public NotifyStrategyForSNSModify NotifyStrategy { get; set; }

        [NameInMap("responsePlan")]
        [Validation(Required=false)]
        public IncidentResponsePlanForSNSModify ResponsePlan { get; set; }

        [NameInMap("subscription")]
        [Validation(Required=false)]
        public SubscriptionForSNSModify Subscription { get; set; }

        /// <summary>
        /// <para>Used exclusively for Update operations. Performs batch create, update, or remove adjustments on member subscriptions.</para>
        /// </summary>
        [NameInMap("subscriptions")]
        [Validation(Required=false)]
        public List<SubscriptionOp> Subscriptions { get; set; }

        /// <summary>
        /// <para>Required for Update. Can be omitted for Create, in which case the backend generates it.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>Required for Update. The value must match the backend record for the write to succeed. If the values do not match, OPTIMISTIC_LOCK_FAILED is returned.</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
