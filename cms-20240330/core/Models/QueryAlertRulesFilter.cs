// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesFilter : TeaModel {
        [NameInMap("datasourceType")]
        [Validation(Required=false)]
        public DatasourceTypeFilter DatasourceType { get; set; }

        /// <summary>
        /// <para>Filters alert rules by display name.</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public DisplayNameFilter DisplayName { get; set; }

        /// <summary>
        /// <para>Filters alert rules by enabled status.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public EnabledFilter Enabled { get; set; }

        /// <summary>
        /// <para>Filters alert rules by label.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public LabelsFilter Labels { get; set; }

        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public NotifyStrategyIdFilter NotifyStrategyId { get; set; }

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

        [NameInMap("observeResourceType")]
        [Validation(Required=false)]
        public ObserveResourceTypeFilter ObserveResourceType { get; set; }

        [NameInMap("partitionKey")]
        [Validation(Required=false)]
        public PartitionKeyFilter PartitionKey { get; set; }

        [NameInMap("severityLevels")]
        [Validation(Required=false)]
        public SeverityLevelsFilter SeverityLevels { get; set; }

        /// <summary>
        /// <para>Filters alert rules by status.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public StatusFilter Status { get; set; }

        /// <summary>
        /// <para>Filters alert rules by UUID.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public UuidFilter Uuid { get; set; }

    }

}
