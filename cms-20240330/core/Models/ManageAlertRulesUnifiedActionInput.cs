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
        /// <para>The business source. Valid values include managed_service_for_prometheus, umodel, application_insights, cloud_monitoring, and sls. Pass this field as needed for CREATE, UPDATE, and PATCH actions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("bizSource")]
        [Validation(Required=false)]
        public string BizSource { get; set; }

        /// <summary>
        /// <para>The condition aggregation configuration.</para>
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
        /// <para>实例 {{instance}} CPU 使用率超过 {{threshold}}%</para>
        /// </summary>
        [NameInMap("contentTemplate")]
        [Validation(Required=false)]
        public string ContentTemplate { get; set; }

        /// <summary>
        /// <para>The data source aggregation configuration.</para>
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
        /// <para>The alert drill evaluation time in Unix milliseconds. This field is required by the backend when drillMode is ONE_SHOT. The time cannot be later than the current time or earlier than 90 days ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1783728000000</para>
        /// </summary>
        [NameInMap("drillEvalTime")]
        [Validation(Required=false)]
        public long? DrillEvalTime { get; set; }

        /// <summary>
        /// <para>The alert drill mode. This field is required by the backend when the action is DRILL_ALERT. Valid values: ONE_SHOT specifies a single point in time to simulate a complete lifecycle consisting of three events: OCCURRED, PERSISTENT, and RECOVERED. TIME_TRAVEL specifies a time range to simulate the lifecycle in multiple rounds based on the rule scheduling interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ONE_SHOT</para>
        /// </summary>
        [NameInMap("drillMode")]
        [Validation(Required=false)]
        public string DrillMode { get; set; }

        /// <summary>
        /// <para>The alert drill time range in Unix milliseconds. This field is required by the backend when drillMode is TIME_TRAVEL. The endTime must be later than the startTime and cannot be later than the current time. The lifecycle is simulated in multiple rounds based on the rule scheduling interval. The maximum number of rounds is 500. If the limit is exceeded, the backend returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;startTime&quot;:1783728000000,&quot;endTime&quot;:1783814400000}</para>
        /// </summary>
        [NameInMap("drillTimeRange")]
        [Validation(Required=false)]
        public ManageAlertRulesUnifiedActionInputDrillTimeRange DrillTimeRange { get; set; }
        public class ManageAlertRulesUnifiedActionInputDrillTimeRange : TeaModel {
            /// <summary>
            /// <para>The drill end time in Unix milliseconds. The end time must be later than the start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1783814400000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The drill start time in Unix milliseconds.</para>
            /// 
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
        /// <para>The notification aggregation configuration.</para>
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
        /// <para><b>[Deprecated]</b> The ID of the monitored object instance. For new integrations, use observeResourceConfig.resources instead. This field is retained only for compatibility with legacy SDKs.</para>
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
        /// <para><b>[Deprecated]</b> The resource type of the monitored object. For new integrations, use observeResourceConfig.entityType instead. This field is retained only for compatibility with legacy SDKs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("observeResourceType")]
        [Validation(Required=false)]
        [Obsolete]
        public string ObserveResourceType { get; set; }

        /// <summary>
        /// <para>The query aggregation configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;PROMETHEUS_SINGLE_QUERY&quot;,&quot;expr&quot;:&quot;up &gt; 0&quot;}</para>
        /// </summary>
        [NameInMap("queryConfig")]
        [Validation(Required=false)]
        public QueryConfigUnified QueryConfig { get; set; }

        /// <summary>
        /// <para>The root cause analysis (RCA) configuration. Pass this field as needed for CREATE, UPDATE, and PATCH actions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enabled&quot;:false}</para>
        /// </summary>
        [NameInMap("rcaConfig")]
        [Validation(Required=false)]
        public AlertRuleRcaConfig RcaConfig { get; set; }

        /// <summary>
        /// <para>The region ID. This aligns with V1 AlertRule.regionId. If not provided, the gateway callerRegionId is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The schedule aggregation configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;FIXED&quot;,&quot;intervalSecs&quot;:60}</para>
        /// </summary>
        [NameInMap("scheduleConfig")]
        [Validation(Required=false)]
        public ScheduleConfigUnified ScheduleConfig { get; set; }

        /// <summary>
        /// <para>The UUID of the rule. This field is required for UPDATE and PATCH actions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The list of UUIDs for the rules to be deleted. This is used for the BATCH_DELETE action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cms_v2_81d01768-fee9-459f-af49-ab2704f1db2b&quot;]</para>
        /// </summary>
        [NameInMap("uuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

        /// <summary>
        /// <para>The workspace ID. This field is required for CREATE, UPDATE, PATCH, DELETE, ENABLE, DISABLE, BATCH_DELETE, BATCH_ENABLE, and BATCH_DISABLE actions. It identifies the CloudMonitor workspace to which the rule belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
