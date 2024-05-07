// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListDashboardsByNameRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster. If the ClusterType parameter is not set to `cloud-product-prometheus` or `cms-enterprise-prometheus`, you must specify the ClusterId parameter.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The cluster type. Valid values:
        /// 
        /// *   vpc-prometheus
        /// *   cloud-product-prometheus
        /// *   cms-enterprise-prometheus
        /// *   ExternalKubernetes
        /// *   Ask
        /// *   Kubernetes
        /// *   ManagedKubernetes
        /// *   remote-write-prometheus
        /// *   GlobalViewV2
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The name of the dashboard.
        /// </summary>
        [NameInMap("DashBoardName")]
        [Validation(Required=false)]
        public string DashBoardName { get; set; }

        /// <summary>
        /// The version of the dashboard.
        /// </summary>
        [NameInMap("DashBoardVersion")]
        [Validation(Required=false)]
        public string DashBoardVersion { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   loki
        /// *   prometheus
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// The name of the dashboard group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Specifies whether to display the Grafana dashboard only in the Application Real-Time Monitoring Service (ARMS) console.
        /// </summary>
        [NameInMap("OnlyQuery")]
        [Validation(Required=false)]
        public bool? OnlyQuery { get; set; }

        /// <summary>
        /// The abbreviation of the Alibaba Cloud service name.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
