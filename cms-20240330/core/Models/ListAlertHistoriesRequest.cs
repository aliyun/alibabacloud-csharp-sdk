// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertHistoriesRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier (transId) of an alert history record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lme6hk5qih5o769m379jjuo5i1</para>
        /// </summary>
        [NameInMap("alertHistoryId")]
        [Validation(Required=false)]
        public string AlertHistoryId { get; set; }

        /// <summary>
        /// <para>Filters the history records by a specific alert rule. Specify the unique identifier (ruleUuid) of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mig_prom_v2_11308451</para>
        /// </summary>
        [NameInMap("alertRuleId")]
        [Validation(Required=false)]
        public string AlertRuleId { get; set; }

        /// <summary>
        /// <para>The business source of the alert history. For example, <c>managed_service_for_prometheus</c> indicates the managed type of the Prometheus integration center. The default value is empty. Leave this parameter empty if you are unsure about the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>managed_service_for_prometheus</para>
        /// </summary>
        [NameInMap("bizSource")]
        [Validation(Required=false)]
        public string BizSource { get; set; }

        /// <summary>
        /// <para>The namespace of CloudMonitor. Examples: acs_rds_dashboard and acs_ecs_dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_rds_dashboard</para>
        /// </summary>
        [NameInMap("cmsNamespace")]
        [Validation(Required=false)]
        public string CmsNamespace { get; set; }

        /// <summary>
        /// <para>The product category of CloudMonitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("cmsProductCategory")]
        [Validation(Required=false)]
        public string CmsProductCategory { get; set; }

        /// <summary>
        /// <para>The keyword used for fuzzy matching and filtering based on the display name of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keyword</para>
        /// </summary>
        [NameInMap("displayNameKeyWord")]
        [Validation(Required=false)]
        public string DisplayNameKeyWord { get; set; }

        /// <summary>
        /// <para>The unique key (instanceKey) used to identify the alert object instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entity/apm/apm.service/6dc9e46fda6d012537b48c3250ff806b</para>
        /// </summary>
        [NameInMap("instanceKey")]
        [Validation(Required=false)]
        public string InstanceKey { get; set; }

        /// <summary>
        /// <para>The filter condition for rule labels. The value is a JSON-formatted string that supports filtering by label key-value pairs.</para>
        /// </summary>
        [NameInMap("labelFilter")]
        [Validation(Required=false)]
        public AlertRuleLabelFilter LabelFilter { get; set; }

        /// <summary>
        /// <para>The level of the most recent alert during the alert duration. Valid values: CRITICAL, WARN, and INFO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRITICAL</para>
        /// </summary>
        [NameInMap("latestLevel")]
        [Validation(Required=false)]
        public string LatestLevel { get; set; }

        /// <summary>
        /// <para>The highest alert level reached during the alert duration. Valid values: CRITICAL, WARN, and INFO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRITICAL</para>
        /// </summary>
        [NameInMap("maxLevel")]
        [Validation(Required=false)]
        public string MaxLevel { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return on each page. This parameter is not supported. Use pageSize and pageNumber for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The migration status of the alert history.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("migrationStatus")]
        [Validation(Required=false)]
        public int? MigrationStatus { get; set; }

        /// <summary>
        /// <para>The pagination token used for the next query. This parameter is not supported. Use pageSize and pageNumber for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2-ba4d-4b9f-aa24-dcb067a30f1c</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Filters alert rules that contain specific notification recipients. Only rules that contain at least one of the notification recipients specified in notifyTargets are returned in the result list.</para>
        /// </summary>
        [NameInMap("notificationFilter")]
        [Validation(Required=false)]
        public AlertRuleNotificationFilter NotificationFilter { get; set; }

        /// <summary>
        /// <para>The relation type of the observed object. Examples: GROUP, INSTANCE, and TAG.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("observeRelationType")]
        [Validation(Required=false)]
        public string ObserveRelationType { get; set; }

        /// <summary>
        /// <para>The dimension column (domain) of the observed object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs</para>
        /// </summary>
        [NameInMap("observeResourceDomain")]
        [Validation(Required=false)]
        public string ObserveResourceDomain { get; set; }

        /// <summary>
        /// <para>Specifies whether the observed object is in the global scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("observeResourceGlobalScope")]
        [Validation(Required=false)]
        public bool? ObserveResourceGlobalScope { get; set; }

        /// <summary>
        /// <para>Filters the alert history by resource instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1234567890abcdef</para>
        /// </summary>
        [NameInMap("observeResourceInstanceId")]
        [Validation(Required=false)]
        public string ObserveResourceInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the observed object. Examples: PROMETHEUS, APM, RUM, and cms_basic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMETHEUS</para>
        /// </summary>
        [NameInMap("observeResourceType")]
        [Validation(Required=false)]
        public string ObserveResourceType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of alert history records to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The key used for data partitioning. Typically, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("partitionKey")]
        [Validation(Required=false)]
        public string PartitionKey { get; set; }

        /// <summary>
        /// <para>The start timestamp of the time range for the alert start time. The value is a UNIX timestamp in milliseconds. If not specified, the default value is the time 30 days ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1739866071668</para>
        /// </summary>
        [NameInMap("startTimeFrom")]
        [Validation(Required=false)]
        public long? StartTimeFrom { get; set; }

        /// <summary>
        /// <para>The end timestamp of the time range for the alert start time. The value is a UNIX timestamp in milliseconds. If not specified, the default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1739866071668</para>
        /// </summary>
        [NameInMap("startTimeTo")]
        [Validation(Required=false)]
        public long? StartTimeTo { get; set; }

        /// <summary>
        /// <para>The current status of the alert history. Valid values: OK and ALARM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALARM</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The identifier of the workspace to which the alert history belongs. If not specified, the default workspace is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-<userId>-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
