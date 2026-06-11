// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ManageAlertRulesUnifiedActionInput : TeaModel {
        /// <summary>
        /// <para>The action to perform on the alert rule. For example, <c>create</c> or <c>update</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The action integration configuration for triggering automated workflows or actions in external systems.</para>
        /// </summary>
        [NameInMap("actionIntegrationConfig")]
        [Validation(Required=false)]
        public ActionIntegrationConfig ActionIntegrationConfig { get; set; }

        /// <summary>
        /// <para>A collection of key-value pairs attached to the alert as annotations. Use annotations to provide additional, non-identifying information, such as descriptions or runbook links.</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// <para>Configuration for integrating with Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        [NameInMap("armsIntegrationConfig")]
        [Validation(Required=false)]
        public ArmsIntegrationConfig ArmsIntegrationConfig { get; set; }

        /// <summary>
        /// <para>The condition configuration that specifies the trigger criteria for the alert.</para>
        /// </summary>
        [NameInMap("conditionConfig")]
        [Validation(Required=false)]
        public ConditionConfigUnified ConditionConfig { get; set; }

        /// <summary>
        /// <para>The content template for the alert notification. You can use variables to customize the message.</para>
        /// </summary>
        [NameInMap("contentTemplate")]
        [Validation(Required=false)]
        public string ContentTemplate { get; set; }

        /// <summary>
        /// <para>The data source configuration for the alert rule.</para>
        /// </summary>
        [NameInMap("datasourceConfig")]
        [Validation(Required=false)]
        public DatasourceConfigUnified DatasourceConfig { get; set; }

        /// <summary>
        /// <para>The display name of the alert rule, as shown in the console.</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert rule is enabled. A value of <c>true</c> indicates the rule is active, and <c>false</c> indicates it is inactive. Default: <c>true</c>.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>A collection of key-value pairs attached to the alert rule as labels. Use labels for categorization and filtering.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>The notification configuration that specifies how and where to send alert notifications.</para>
        /// </summary>
        [NameInMap("notifyConfig")]
        [Validation(Required=false)]
        public NotifyConfigUnified NotifyConfig { get; set; }

        /// <summary>
        /// <para>The query configuration that defines the data for rule evaluation.</para>
        /// </summary>
        [NameInMap("queryConfig")]
        [Validation(Required=false)]
        public QueryConfigUnified QueryConfig { get; set; }

        /// <summary>
        /// <para>The schedule configuration that determines how often the system evaluates the rule.</para>
        /// </summary>
        [NameInMap("scheduleConfig")]
        [Validation(Required=false)]
        public ScheduleConfigUnified ScheduleConfig { get; set; }

        /// <summary>
        /// <para>The unique identifier (UUID) of the alert rule. This parameter is required when you update or delete an existing rule.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>A list of UUIDs. Use this parameter to perform bulk actions on multiple rules, such as batch deletion.</para>
        /// </summary>
        [NameInMap("uuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that contains the alert rule.</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
