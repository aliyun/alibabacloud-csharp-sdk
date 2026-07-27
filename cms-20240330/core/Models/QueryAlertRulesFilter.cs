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

        [NameInMap("notificationChannels")]
        [Validation(Required=false)]
        public NotificationChannelsFilter NotificationChannels { get; set; }

        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public NotifyStrategyIdFilter NotifyStrategyId { get; set; }

        [NameInMap("observeResourceConfig")]
        [Validation(Required=false)]
        public ObserveResourceConfigFilter ObserveResourceConfig { get; set; }

        [NameInMap("observeResourceGlobalScope")]
        [Validation(Required=false)]
        public ObserveResourceGlobalScopeFilter ObserveResourceGlobalScope { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
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
