// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesFilter : TeaModel {
        [NameInMap("bizSource")]
        [Validation(Required=false)]
        public BizSourceFilter BizSource { get; set; }

        [NameInMap("datasourceType")]
        [Validation(Required=false)]
        public DatasourceTypeFilter DatasourceType { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public DisplayNameFilter DisplayName { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public EnabledFilter Enabled { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public LabelsFilter Labels { get; set; }

        /// <summary>
        /// <para>Filters by migration status. isMigrated=true queries migrated rules (migration_status is not 0 or NULL). isMigrated=false queries native rules (migration_status=0).</para>
        /// </summary>
        [NameInMap("migrationStatus")]
        [Validation(Required=false)]
        public MigrationStatusFilter MigrationStatus { get; set; }

        [NameInMap("notificationChannels")]
        [Validation(Required=false)]
        public NotificationChannelsFilter NotificationChannels { get; set; }

        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public NotifyStrategyIdFilter NotifyStrategyId { get; set; }

        /// <summary>
        /// <para>Filters by the observeResourceConfig structure. This takes priority over the standalone observeResourceType / observeResourceGlobalScope / observeResourceList fields below. If both are specified and their semantics conflict, the request is rejected.</para>
        /// </summary>
        [NameInMap("observeResourceConfig")]
        [Validation(Required=false)]
        public ObserveResourceConfigFilter ObserveResourceConfig { get; set; }

        [NameInMap("observeResourceGlobalScope")]
        [Validation(Required=false)]
        public ObserveResourceGlobalScopeFilter ObserveResourceGlobalScope { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Filters by a single resource entity ID. This field is retained only for backward compatibility with legacy SDKs. For new integrations, use observeResourceList.contains instead. If this field is not empty and observeResourceList is not specified, it is equivalent to observeResourceList.contains=[observeResourceInstanceId].</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1abcxxxxxxxx</para>
        /// </summary>
        [NameInMap("observeResourceInstanceId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ObserveResourceInstanceId { get; set; }

        [NameInMap("observeResourceList")]
        [Validation(Required=false)]
        public ObserveResourceListFilter ObserveResourceList { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Filters by observable resource type. For new integrations, use observeResourceConfig.entityType instead.</para>
        /// </summary>
        [NameInMap("observeResourceType")]
        [Validation(Required=false)]
        [Obsolete]
        public ObserveResourceTypeFilter ObserveResourceType { get; set; }

        [NameInMap("partitionKey")]
        [Validation(Required=false)]
        public PartitionKeyFilter PartitionKey { get; set; }

        [NameInMap("severityLevels")]
        [Validation(Required=false)]
        public SeverityLevelsFilter SeverityLevels { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public StatusFilter Status { get; set; }

        [NameInMap("uuid")]
        [Validation(Required=false)]
        public UuidFilter Uuid { get; set; }

    }

}
