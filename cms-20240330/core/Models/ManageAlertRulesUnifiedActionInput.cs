// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ManageAlertRulesUnifiedActionInput : TeaModel {
        /// <summary>
        /// <para>The action type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The action integration configuration.</para>
        /// </summary>
        [NameInMap("actionIntegrationConfig")]
        [Validation(Required=false)]
        public ActionIntegrationConfig ActionIntegrationConfig { get; set; }

        /// <summary>
        /// <para>The annotations.</para>
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
        /// <para>The business source (optional). Examples: managed_service_for_prometheus, umodel, application_insights, cloud_monitoring, sls. Provide as needed for CREATE/UPDATE/PATCH.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("bizSource")]
        [Validation(Required=false)]
        public string BizSource { get; set; }

        /// <summary>
        /// <para>The aggregated condition configuration.</para>
        /// </summary>
        [NameInMap("conditionConfig")]
        [Validation(Required=false)]
        public ConditionConfigUnified ConditionConfig { get; set; }

        /// <summary>
        /// <para>The content template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance {{instance}} CPU usage exceeds {{threshold}}%</para>
        /// </summary>
        [NameInMap("contentTemplate")]
        [Validation(Required=false)]
        public string ContentTemplate { get; set; }

        /// <summary>
        /// <para>The aggregated data source configuration.</para>
        /// </summary>
        [NameInMap("datasourceConfig")]
        [Validation(Required=false)]
        public DatasourceConfigUnified DatasourceConfig { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
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
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>The aggregated notification configuration.</para>
        /// </summary>
        [NameInMap("notifyConfig")]
        [Validation(Required=false)]
        public NotifyConfigUnified NotifyConfig { get; set; }

        /// <summary>
        /// <para>The observable resource configuration.</para>
        /// </summary>
        [NameInMap("observeResourceConfig")]
        [Validation(Required=false)]
        public ObserveResourceConfig ObserveResourceConfig { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The monitored object instance ID. Use observeResourceConfig.resources instead. Retained only for backward compatibility with legacy SDKs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("observeResourceInstanceId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ObserveResourceInstanceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The monitored object resource type. Use observeResourceConfig.entityType instead. Retained only for backward compatibility with legacy SDKs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("observeResourceType")]
        [Validation(Required=false)]
        [Obsolete]
        public string ObserveResourceType { get; set; }

        /// <summary>
        /// <para>The aggregated query configuration.</para>
        /// </summary>
        [NameInMap("queryConfig")]
        [Validation(Required=false)]
        public QueryConfigUnified QueryConfig { get; set; }

        /// <summary>
        /// <para>The root cause analysis (RCA) configuration (optional). Provide as needed for CREATE/UPDATE/PATCH.</para>
        /// </summary>
        [NameInMap("rcaConfig")]
        [Validation(Required=false)]
        public AlertRuleRcaConfig RcaConfig { get; set; }

        /// <summary>
        /// <para>The region ID. Aligned with V1 AlertRule.regionId. If not provided, the gateway callerRegionId is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The aggregated schedule configuration.</para>
        /// </summary>
        [NameInMap("scheduleConfig")]
        [Validation(Required=false)]
        public ScheduleConfigUnified ScheduleConfig { get; set; }

        /// <summary>
        /// <para>The UUID of the rule. Required for UPDATE/PATCH.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The list of rule UUIDs to delete (BATCH_DELETE).</para>
        /// </summary>
        [NameInMap("uuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

        /// <summary>
        /// <para>The workspace. Required for CREATE/UPDATE and other actions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
