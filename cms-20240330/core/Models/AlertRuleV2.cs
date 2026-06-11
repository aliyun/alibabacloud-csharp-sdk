// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleV2 : TeaModel {
        /// <summary>
        /// <para>Configuration for action integrations, such as webhooks, that execute when an alert is triggered.</para>
        /// </summary>
        [NameInMap("actionIntegrationConfig")]
        [Validation(Required=false)]
        public ActionIntegrationConfig ActionIntegrationConfig { get; set; }

        /// <summary>
        /// <para>A set of key-value pairs that serve as annotations, providing additional, non-identifying information, such as a description or a runbook link.</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// <para>The configuration for integrating the alert rule with Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        [NameInMap("armsIntegrationConfig")]
        [Validation(Required=false)]
        public ArmsIntegrationConfig ArmsIntegrationConfig { get; set; }

        /// <summary>
        /// <para>The configuration for the conditions that trigger an alert.</para>
        /// </summary>
        [NameInMap("conditionConfig")]
        [Validation(Required=false)]
        public ConditionConfigUnified ConditionConfig { get; set; }

        /// <summary>
        /// <para>The template for the alert notification content.</para>
        /// </summary>
        [NameInMap("contentTemplate")]
        [Validation(Required=false)]
        public string ContentTemplate { get; set; }

        [NameInMap("coveredSeverityLevels")]
        [Validation(Required=false)]
        public string CoveredSeverityLevels { get; set; }

        /// <summary>
        /// <para>The time the alert rule was created.</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The configuration for the data source to be evaluated.</para>
        /// </summary>
        [NameInMap("datasourceConfig")]
        [Validation(Required=false)]
        public DatasourceConfigUnified DatasourceConfig { get; set; }

        /// <summary>
        /// <para>The data source type. Examples: <c>sls</c>, <c>prometheus</c>.</para>
        /// </summary>
        [NameInMap("datasourceType")]
        [Validation(Required=false)]
        public string DatasourceType { get; set; }

        /// <summary>
        /// <para>The user-defined display name for the alert rule.</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Indicates whether the alert rule is active. Set to <c>true</c> to enable the rule, or <c>false</c> to disable it.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>A set of key-value pairs that serve as labels to filter and group alert rules.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>The configuration for sending notifications when an alert is triggered.</para>
        /// </summary>
        [NameInMap("notifyConfig")]
        [Validation(Required=false)]
        public NotifyConfigUnified NotifyConfig { get; set; }

        /// <summary>
        /// <para>Indicates whether the alert rule monitors all resources of the specified type. If <c>true</c>, the rule applies globally within the workspace.</para>
        /// </summary>
        [NameInMap("observeResourceGlobalScope")]
        [Validation(Required=false)]
        public bool? ObserveResourceGlobalScope { get; set; }

        /// <summary>
        /// <para>A list of specific resource IDs to monitor, used only when <c>observeResourceGlobalScope</c> is <c>false</c>.</para>
        /// </summary>
        [NameInMap("observeResourceList")]
        [Validation(Required=false)]
        public string ObserveResourceList { get; set; }

        /// <summary>
        /// <para>The type of resource that the alert rule monitors.</para>
        /// </summary>
        [NameInMap("observeResourceType")]
        [Validation(Required=false)]
        public string ObserveResourceType { get; set; }

        /// <summary>
        /// <para>The configuration for querying and processing data from the data source.</para>
        /// </summary>
        [NameInMap("queryConfig")]
        [Validation(Required=false)]
        public QueryConfigUnified QueryConfig { get; set; }

        /// <summary>
        /// <para>The configuration for how often the alert rule is evaluated.</para>
        /// </summary>
        [NameInMap("scheduleConfig")]
        [Validation(Required=false)]
        public ScheduleConfigUnified ScheduleConfig { get; set; }

        /// <summary>
        /// <para>The current status of the alert rule. Examples: <c>RUNNING</c>, <c>STOPPED</c>.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time the alert rule was last updated.</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The unique identifier for the alert rule.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that contains the alert rule.</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
