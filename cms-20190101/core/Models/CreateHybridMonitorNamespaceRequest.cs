// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateHybridMonitorNamespaceRequest : TeaModel {
        /// <summary>
        /// The description of the namespace.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// The name can contain lowercase letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The region where the metric data is stored.
        /// </summary>
        [NameInMap("NamespaceRegion")]
        [Validation(Required=false)]
        public string NamespaceRegion { get; set; }

        /// <summary>
        /// The storage scheme of metric data. Valid values:
        /// 
        /// *   m_prom_pool: The metric data is stored in Simple Log Service.
        /// *   m_prometheus: The metric data is stored in the storage space provided by CloudMonitor.
        /// 
        /// >  For more information about the storage schemes of metric data, see [Storage schemes of metric data in Hybrid Cloud Monitoring](~~2594921~~).
        /// </summary>
        [NameInMap("NamespaceType")]
        [Validation(Required=false)]
        public string NamespaceType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The data retention period. Valid values:
        /// 
        /// *   cms.s1.large (Retention Period 15 Days)
        /// *   cms.s1.xlarge (Retention Period 32 Days)
        /// *   cms.s1.2xlarge (Retention Period 63 Days)
        /// *   cms.s1.3xlarge (Retention Period 93 Days) (default)
        /// *   cms.s1.6xlarge (Retention Period 185 Days)
        /// *   cms.s1.12xlarge (Retention Period 367 Days)
        /// 
        /// For information about the pricing for different retention periods, see the **Pricing** section in [Billing of the dashboard feature](~~223532~~).
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
