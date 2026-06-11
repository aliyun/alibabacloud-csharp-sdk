// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionAndNotifyStrategyForModify : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Optional. If omitted, the backend derives the name from <c>notifyStrategy</c>.</para>
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
        /// <para>For update operations only. Use this parameter to batch create, update, and remove member subscriptions.</para>
        /// </summary>
        [NameInMap("subscriptions")]
        [Validation(Required=false)]
        public List<SubscriptionOp> Subscriptions { get; set; }

        /// <summary>
        /// <para>Required for update operations but optional for create operations. If omitted during creation, the backend automatically generates a UUID.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>Required for update operations. The value must match the current version of the record. If the versions do not match, the request fails with an <c>OPTIMISTIC_LOCK_FAILED</c> error.</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
