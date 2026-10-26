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
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enabled&quot;:true,&quot;actions&quot;:[]}</para>
        /// </summary>
        [NameInMap("actionIntegrationConfig")]
        [Validation(Required=false)]
        public ActionIntegrationConfig ActionIntegrationConfig { get; set; }

        /// <summary>
        /// <para>The annotations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;summary&quot;:&quot;CPU usage exceeds 90%&quot;}</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// <para>The ARMS integration configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enabled&quot;:false}</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;PROMETHEUS_SIMPLE_CONDITION&quot;,&quot;durationSecs&quot;:0,&quot;severity&quot;:&quot;CRITICAL&quot;}</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;PROMETHEUS&quot;,&quot;instanceId&quot;:&quot;prom-cn-hangzhou-xxxxx&quot;}</para>
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
        /// <b>Example:</b>
        /// <para>1783728000000</para>
        /// </summary>
        [NameInMap("drillEvalTime")]
        [Validation(Required=false)]
        public long? DrillEvalTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ONE_SHOT</para>
        /// </summary>
        [NameInMap("drillMode")]
        [Validation(Required=false)]
        public string DrillMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;startTime&quot;:1783728000000,&quot;endTime&quot;:1783814400000}</para>
        /// </summary>
        [NameInMap("drillTimeRange")]
        [Validation(Required=false)]
        public ManageAlertRulesUnifiedActionInputDrillTimeRange DrillTimeRange { get; set; }
        public class ManageAlertRulesUnifiedActionInputDrillTimeRange : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1783814400000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1783728000000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

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
        /// <para>{&quot;env&quot;:&quot;production&quot;}</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>The aggregated notification configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;DIRECT_NOTIFY&quot;,&quot;channels&quot;:[{&quot;type&quot;:&quot;GROUP&quot;,&quot;identifiers&quot;:[&quot;<contact-group-id>&quot;]}]}</para>
        /// </summary>
        [NameInMap("notifyConfig")]
        [Validation(Required=false)]
        public NotifyConfigUnified NotifyConfig { get; set; }

        /// <summary>
        /// <para>The observable resource configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;relationType&quot;:&quot;CLOUD_INSTANCE&quot;,&quot;resources&quot;:[]}</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;PROMETHEUS_SINGLE_QUERY&quot;,&quot;expr&quot;:&quot;up &gt; 0&quot;}</para>
        /// </summary>
        [NameInMap("queryConfig")]
        [Validation(Required=false)]
        public QueryConfigUnified QueryConfig { get; set; }

        /// <summary>
        /// <para>The root cause analysis (RCA) configuration (optional). Provide as needed for CREATE/UPDATE/PATCH.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enabled&quot;:false}</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;FIXED&quot;,&quot;intervalSecs&quot;:60}</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cms_v2_81d01768-fee9-459f-af49-ab2704f1db2b&quot;]</para>
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
