// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ListDedicatedClusterRequest : TeaModel {
        /// <summary>
        /// The basis on which the retrieved entries are sorted if multiple DTS dedicated clusters are returned. Valid values:
        /// 
        /// *   **gmtCreated**: the time when a cluster was created.
        /// *   **orderCount**: the number of nodes in a cluster.
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// The order in which you want to sort the retrieved entries. Valid values:
        /// 
        /// *   asc: sorts the retrieved entries in ascending order. This is the default value.
        /// *   desc: sorts the retrieved entries in descending order.
        /// </summary>
        [NameInMap("OrderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. The value of this parameter must be an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of clusters to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The content of the query condition.
        /// 
        /// >  You must set the **Type parameter** to specify the type of the query condition.
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The status of the cluster. Valid values:
        /// 
        /// *   **init**: The cluster is being initialized.
        /// *   **schedule**: The cluster is pending scheduling.
        /// *   **running**: The cluster is running.
        /// *   **upgrade**: The cluster is being upgraded.
        /// *   **downgrade**: The cluster is being downgraded.
        /// *   **locked**: The cluster is locked.
        /// *   **releasing**: The cluster is being released.
        /// *   **released**: The cluster is released.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The type of the query condition. Valid values:
        /// 
        /// *   **NAME**: the name of the cluster.
        /// *   **INSTANCE**: the ID of a cluster instance.
        /// *   **DEDICAETEDCLUSTERID**: the ID of a dedicated cluster.
        /// 
        /// >  You must specify the query condition by using the **Params** parameter.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
