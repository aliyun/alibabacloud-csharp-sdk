// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentForView : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("escalations")]
        [Validation(Required=false)]
        public List<IncidentEscalationPolicyForView> Escalations { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;group-123456&quot;</para>
        /// </summary>
        [NameInMap("groupUuid")]
        [Validation(Required=false)]
        public string GroupUuid { get; set; }

        [NameInMap("groupingKeys")]
        [Validation(Required=false)]
        public Dictionary<string, string> GroupingKeys { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;incident-abc123&quot;</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        [NameInMap("notifyStrategyName")]
        [Validation(Required=false)]
        public string NotifyStrategyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;notify-strategy-789&quot;</para>
        /// </summary>
        [NameInMap("notifyStrategyUuid")]
        [Validation(Required=false)]
        public string NotifyStrategyUuid { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public ContactForIncidentView Operator { get; set; }

        [NameInMap("owners")]
        [Validation(Required=false)]
        public List<ContactForIncidentView> Owners { get; set; }

        [NameInMap("participants")]
        [Validation(Required=false)]
        public List<ContactForIncidentView> Participants { get; set; }

        [NameInMap("plan")]
        [Validation(Required=false)]
        public IncidentResponsePlanForView Plan { get; set; }

        [NameInMap("relatedResources")]
        [Validation(Required=false)]
        public List<EventResourceForIncidentView> RelatedResources { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Network&quot;</para>
        /// </summary>
        [NameInMap("rootCauseCategory")]
        [Validation(Required=false)]
        public string RootCauseCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Critical&quot;</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("solution")]
        [Validation(Required=false)]
        public string Solution { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Open&quot;</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;P1-Alert-Notification&quot;</para>
        /// </summary>
        [NameInMap("subscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;subscription-abc&quot;</para>
        /// </summary>
        [NameInMap("subscriptionUuid")]
        [Validation(Required=false)]
        public string SubscriptionUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743876000000</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;user-abc123&quot;</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;ws-xyz789&quot;</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
