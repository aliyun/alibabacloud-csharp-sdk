// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleV2 : TeaModel {
        [NameInMap("actionIntegrationConfig")]
        [Validation(Required=false)]
        public ActionIntegrationConfig ActionIntegrationConfig { get; set; }

        /// <summary>
        /// <para>The annotations.</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, string> Annotations { get; set; }

        [NameInMap("armsIntegrationConfig")]
        [Validation(Required=false)]
        public ArmsIntegrationConfig ArmsIntegrationConfig { get; set; }

        /// <summary>
        /// <para>The business source. This field is read-only. Example values: managed_service_for_prometheus, umodel, application_insights, cloud_monitoring, and sls.</para>
        /// </summary>
        [NameInMap("bizSource")]
        [Validation(Required=false)]
        public string BizSource { get; set; }

        [NameInMap("conditionConfig")]
        [Validation(Required=false)]
        public ConditionConfigUnified ConditionConfig { get; set; }

        /// <summary>
        /// <para>The content template.</para>
        /// </summary>
        [NameInMap("contentTemplate")]
        [Validation(Required=false)]
        public string ContentTemplate { get; set; }

        /// <summary>
        /// <para>The creation time in ISO 8601 format. This field is read-only.</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("datasourceConfig")]
        [Validation(Required=false)]
        public DatasourceConfigUnified DatasourceConfig { get; set; }

        /// <summary>
        /// <para>The data source type. This field is read-only and derived.</para>
        /// </summary>
        [NameInMap("datasourceType")]
        [Validation(Required=false)]
        public string DatasourceType { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert rule is enabled.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The labels.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        [NameInMap("notifyConfig")]
        [Validation(Required=false)]
        public NotifyConfigUnified NotifyConfig { get; set; }

        /// <summary>
        /// <para>The notification strategy ID. This field is read-only and derived from the first item in the notification strategy list.</para>
        /// </summary>
        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public string NotifyStrategyId { get; set; }

        /// <summary>
        /// <para>The observable resource configuration.</para>
        /// </summary>
        [NameInMap("observeResourceConfig")]
        [Validation(Required=false)]
        public ObserveResourceConfig ObserveResourceConfig { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Indicates whether the rule applies to all resources of this type. This field is read-only and derived. Use observeResourceConfig.relationType set to ALL for equivalent semantics in new integrations.</para>
        /// </summary>
        [NameInMap("observeResourceGlobalScope")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? ObserveResourceGlobalScope { get; set; }

        /// <summary>
        /// <para>The list of observable resource IDs. This field is read-only and derived.</para>
        /// </summary>
        [NameInMap("observeResourceList")]
        [Validation(Required=false)]
        public List<string> ObserveResourceList { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The observable resource type. This field is read-only and derived. Use observeResourceConfig.entityType instead for new integrations.</para>
        /// </summary>
        [NameInMap("observeResourceType")]
        [Validation(Required=false)]
        [Obsolete]
        public string ObserveResourceType { get; set; }

        /// <summary>
        /// <para>The partition key. This field is read-only and maintained by the system for rule routing and sharding.</para>
        /// </summary>
        [NameInMap("partitionKey")]
        [Validation(Required=false)]
        public string PartitionKey { get; set; }

        [NameInMap("queryConfig")]
        [Validation(Required=false)]
        public QueryConfigUnified QueryConfig { get; set; }

        /// <summary>
        /// <para>The RCA (root cause analysis) configuration.</para>
        /// </summary>
        [NameInMap("rcaConfig")]
        [Validation(Required=false)]
        public AlertRuleRcaConfig RcaConfig { get; set; }

        /// <summary>
        /// <para>The region ID. This field is aligned with V1 AlertRule.regionId. Priority: request body regionId &gt; gateway callerRegionId.</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("scheduleConfig")]
        [Validation(Required=false)]
        public ScheduleConfigUnified ScheduleConfig { get; set; }

        /// <summary>
        /// <para>The severity levels covered by this rule, separated by commas. This field is read-only and derived. The format is the same as the filter.severityLevels query parameter.</para>
        /// </summary>
        [NameInMap("severityLevels")]
        [Validation(Required=false)]
        public string SeverityLevels { get; set; }

        /// <summary>
        /// <para>The alert status. This field is read-only.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update time in ISO 8601 format. This field is read-only.</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The rule UUID. This field is system-generated and read-only.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The workspace.</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
