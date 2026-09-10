// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesFilter : TeaModel {
        /// <summary>
        /// <para>The filter condition for the business source.</para>
        /// </summary>
        [NameInMap("bizSource")]
        [Validation(Required=false)]
        public BizSourceFilter BizSource { get; set; }

        /// <summary>
        /// <para>The filter condition for the data source type.</para>
        /// </summary>
        [NameInMap("datasourceType")]
        [Validation(Required=false)]
        public DatasourceTypeFilter DatasourceType { get; set; }

        /// <summary>
        /// <para>The filter for alert rule names.</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public DisplayNameFilter DisplayName { get; set; }

        /// <summary>
        /// <para>The filter for whether the alert rule is enabled.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public EnabledFilter Enabled { get; set; }

        /// <summary>
        /// <para>The filter for labels.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public LabelsFilter Labels { get; set; }

        /// <summary>
        /// <para>The migration status filter. Set isMigrated to true to query migrated rules (migration_status is not 0 or NULL). Set isMigrated to false to query native rules (migration_status=0).</para>
        /// </summary>
        [NameInMap("migrationStatus")]
        [Validation(Required=false)]
        public MigrationStatusFilter MigrationStatus { get; set; }

        /// <summary>
        /// <para>The filter condition for notification channels.</para>
        /// </summary>
        [NameInMap("notificationChannels")]
        [Validation(Required=false)]
        public NotificationChannelsFilter NotificationChannels { get; set; }

        /// <summary>
        /// <para>The filter condition for the notification policy ID.</para>
        /// </summary>
        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public NotifyStrategyIdFilter NotifyStrategyId { get; set; }

        /// <summary>
        /// <para>The composite filter based on the observeResourceConfig structure. This filter takes priority over the standalone observeResourceType, observeResourceGlobalScope, and observeResourceList fields. If both are specified and their semantics conflict, the request is rejected.</para>
        /// </summary>
        [NameInMap("observeResourceConfig")]
        [Validation(Required=false)]
        public ObserveResourceConfigFilter ObserveResourceConfig { get; set; }

        /// <summary>
        /// <para>The filter condition for the global scope of observable resources.</para>
        /// </summary>
        [NameInMap("observeResourceGlobalScope")]
        [Validation(Required=false)]
        public ObserveResourceGlobalScopeFilter ObserveResourceGlobalScope { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The single-value filter for the resource instance ID. This field is retained only for compatibility with legacy SDKs. Use observeResourceList.contains instead for new integrations. If this field is not empty and observeResourceList is not specified, it is equivalent to observeResourceList.contains=[observeResourceInstanceId].</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1abcxxxxxxxx</para>
        /// </summary>
        [NameInMap("observeResourceInstanceId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ObserveResourceInstanceId { get; set; }

        /// <summary>
        /// <para>The filter condition for the list of observable resources.</para>
        /// </summary>
        [NameInMap("observeResourceList")]
        [Validation(Required=false)]
        public ObserveResourceListFilter ObserveResourceList { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The filter for the observable resource type. Use observeResourceConfig.entityType instead for new integrations.</para>
        /// </summary>
        [NameInMap("observeResourceType")]
        [Validation(Required=false)]
        [Obsolete]
        public ObserveResourceTypeFilter ObserveResourceType { get; set; }

        /// <summary>
        /// <para>The filter condition for the partition key.</para>
        /// </summary>
        [NameInMap("partitionKey")]
        [Validation(Required=false)]
        public PartitionKeyFilter PartitionKey { get; set; }

        /// <summary>
        /// <para>The filter condition for alert severity levels.</para>
        /// </summary>
        [NameInMap("severityLevels")]
        [Validation(Required=false)]
        public SeverityLevelsFilter SeverityLevels { get; set; }

        /// <summary>
        /// <para>The filter for statuses.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public StatusFilter Status { get; set; }

        /// <summary>
        /// <para>The filter for alert rule UUIDs.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public UuidFilter Uuid { get; set; }

    }

}
