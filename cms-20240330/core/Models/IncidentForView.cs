// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentForView : TeaModel {
        /// <summary>
        /// <para>The details of the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{&quot;description&quot;:&quot;ECS实例CPU过高&quot;,&quot;impact&quot;:&quot;支付服务延迟&quot;}&quot;</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The list of escalation policies.</para>
        /// </summary>
        [NameInMap("escalations")]
        [Validation(Required=false)]
        public List<IncidentEscalationPolicyForView> Escalations { get; set; }

        /// <summary>
        /// <para>The group identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;group-123456&quot;</para>
        /// </summary>
        [NameInMap("groupUuid")]
        [Validation(Required=false)]
        public string GroupUuid { get; set; }

        /// <summary>
        /// <para>The key-value pairs for grouping.</para>
        /// </summary>
        [NameInMap("groupingKeys")]
        [Validation(Required=false)]
        public Dictionary<string, string> GroupingKeys { get; set; }

        /// <summary>
        /// <para>The unique identifier of the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;incident-abc123&quot;</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>The name of the notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;contactId&quot;: &quot;contact-123&quot;, &quot;name&quot;: &quot;张三&quot; }</para>
        /// </summary>
        [NameInMap("notifyStrategyName")]
        [Validation(Required=false)]
        public string NotifyStrategyName { get; set; }

        /// <summary>
        /// <para>The UUID of the associated notification policy, which is used to trigger notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;notify-strategy-789&quot;</para>
        /// </summary>
        [NameInMap("notifyStrategyUuid")]
        [Validation(Required=false)]
        public string NotifyStrategyUuid { get; set; }

        /// <summary>
        /// <para>The information about the operator.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public ContactForIncidentView Operator { get; set; }

        /// <summary>
        /// <para>The list of owners.</para>
        /// </summary>
        [NameInMap("owners")]
        [Validation(Required=false)]
        public List<ContactForIncidentView> Owners { get; set; }

        /// <summary>
        /// <para>The list of participants.</para>
        /// </summary>
        [NameInMap("participants")]
        [Validation(Required=false)]
        public List<ContactForIncidentView> Participants { get; set; }

        /// <summary>
        /// <para>The response plan.</para>
        /// </summary>
        [NameInMap("plan")]
        [Validation(Required=false)]
        public IncidentResponsePlanForView Plan { get; set; }

        /// <summary>
        /// <para>The list of associated resources.</para>
        /// </summary>
        [NameInMap("relatedResources")]
        [Validation(Required=false)]
        public List<EventResourceForIncidentView> RelatedResources { get; set; }

        /// <summary>
        /// <para>The root cause category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Network&quot;</para>
        /// </summary>
        [NameInMap("rootCauseCategory")]
        [Validation(Required=false)]
        public string RootCauseCategory { get; set; }

        /// <summary>
        /// <para>The severity level of the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Critical&quot;</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The description of the solution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;重启ECS实例后恢复正常&quot;</para>
        /// </summary>
        [NameInMap("solution")]
        [Validation(Required=false)]
        public string Solution { get; set; }

        /// <summary>
        /// <para>The current state of the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Open&quot;</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The name of the subscription policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;P1-Alert-Notification&quot;</para>
        /// </summary>
        [NameInMap("subscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// <para>The UUID of the subscription policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;subscription-abc&quot;</para>
        /// </summary>
        [NameInMap("subscriptionUuid")]
        [Validation(Required=false)]
        public string SubscriptionUuid { get; set; }

        /// <summary>
        /// <para>The timestamp when the incident was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743876000000</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The title of the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;支付服务不可用&quot;</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;user-abc123&quot;</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;ws-xyz789&quot;</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
