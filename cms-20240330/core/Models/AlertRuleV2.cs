// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleV2 : TeaModel {
        /// <summary>
        /// <para>The action integration configuration.</para>
        /// </summary>
        [NameInMap("actionIntegrationConfig")]
        [Validation(Required=false)]
        public ActionIntegrationConfig ActionIntegrationConfig { get; set; }

        /// <summary>
        /// <para>The annotations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;platform&quot;:&quot;github&quot;}</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// <para>The ARMS integration configuration.</para>
        /// </summary>
        [NameInMap("armsIntegrationConfig")]
        [Validation(Required=false)]
        public ArmsIntegrationConfig ArmsIntegrationConfig { get; set; }

        /// <summary>
        /// <para>The business source. This parameter is read-only. Examples include managed_service_for_prometheus, umodel, application_insights, cloud_monitoring, and sls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("bizSource")]
        [Validation(Required=false)]
        public string BizSource { get; set; }

        /// <summary>
        /// <para>The detection condition configuration aggregation, including simple Prometheus, UModel, simple APM, and composite APM.</para>
        /// </summary>
        [NameInMap("conditionConfig")]
        [Validation(Required=false)]
        public ConditionConfigUnified ConditionConfig { get; set; }

        /// <summary>
        /// <para>The content template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>告警触发: ${metricName} 当前值 ${currentValue} 超过阈值 ${threshold}</para>
        /// </summary>
        [NameInMap("contentTemplate")]
        [Validation(Required=false)]
        public string ContentTemplate { get; set; }

        /// <summary>
        /// <para>The creation time in ISO 8601 format. This parameter is read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1751595283143</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The datasource config aggregation. The PROMETHEUS, UMODEL, and APM data sources share the same object, and fields are selected based on the type.</para>
        /// </summary>
        [NameInMap("datasourceConfig")]
        [Validation(Required=false)]
        public DatasourceConfigUnified DatasourceConfig { get; set; }

        /// <summary>
        /// <para>The data source type. This parameter is read-only and derived.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("datasourceType")]
        [Validation(Required=false)]
        public string DatasourceType { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU水位告警95%</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;platform&quot;:&quot;github&quot;}</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>The manager of the rule. This parameter is read-only. An empty value indicates a user-created rule. A non-empty value indicates that the rule is created and managed by the corresponding cloud service logic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>integrationCenter</para>
        /// </summary>
        [NameInMap("managedBy")]
        [Validation(Required=false)]
        public string ManagedBy { get; set; }

        /// <summary>
        /// <para>The notification configuration aggregation. Currently, only DIRECT_NOTIFY is supported, which corresponds to DirectNotifyConfig.</para>
        /// </summary>
        [NameInMap("notifyConfig")]
        [Validation(Required=false)]
        public NotifyConfigUnified NotifyConfig { get; set; }

        /// <summary>
        /// <para>The notification strategy ID. This parameter is read-only and derived from the first item in the notification strategy list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
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
        /// <para><b>[Deprecated]</b> Specifies whether the rule takes effect on all resources of this type. This parameter is read-only and derived. For new integrations, check whether observeResourceConfig.relationType is set to ALL to determine the equivalent semantics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("observeResourceGlobalScope")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? ObserveResourceGlobalScope { get; set; }

        /// <summary>
        /// <para>The list of observable resource IDs. This parameter is read-only and derived.</para>
        /// </summary>
        [NameInMap("observeResourceList")]
        [Validation(Required=false)]
        public List<string> ObserveResourceList { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The observable resource type. This parameter is read-only and derived. For new integrations, use observeResourceConfig.entityType instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("observeResourceType")]
        [Validation(Required=false)]
        [Obsolete]
        public string ObserveResourceType { get; set; }

        /// <summary>
        /// <para>The partition key. This parameter is read-only and maintained by the system for rule routing and sharding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("partitionKey")]
        [Validation(Required=false)]
        public string PartitionKey { get; set; }

        /// <summary>
        /// <para>The query configuration aggregation, including PROMETHEUS_SINGLE_QUERY, UMODEL_METRICSET_QUERY, and APM_MULTI_QUERY.</para>
        /// </summary>
        [NameInMap("queryConfig")]
        [Validation(Required=false)]
        public QueryConfigUnified QueryConfig { get; set; }

        /// <summary>
        /// <para>The root cause analysis (RCA) configuration.</para>
        /// </summary>
        [NameInMap("rcaConfig")]
        [Validation(Required=false)]
        public AlertRuleRcaConfig RcaConfig { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is aligned with V1 AlertRule.regionId. Priority: regionId in the request body &gt; callerRegionId in the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The schedule configuration aggregation. Currently, only FIXED is supported.</para>
        /// </summary>
        [NameInMap("scheduleConfig")]
        [Validation(Required=false)]
        public ScheduleConfigUnified ScheduleConfig { get; set; }

        /// <summary>
        /// <para>The severity levels covered by this rule, separated by commas. This parameter is read-only and derived. The format is consistent with the filter.severityLevels query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("severityLevels")]
        [Validation(Required=false)]
        public string SeverityLevels { get; set; }

        /// <summary>
        /// <para>The alert status. This parameter is read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alarm</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update time in ISO 8601 format. This parameter is read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764556086388</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The UUID of the rule. This parameter is generated by the system and is read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
