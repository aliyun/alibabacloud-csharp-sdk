// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGlobalDatabaseNetworksRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// > You can call the [DescribeDBClusters](~~98094~~) operation to query information about all clusters that are deployed in a specified region, such as the cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specify the region in which you want to query GDNs. You can create secondary clusters for the GDNs.
        /// </summary>
        [NameInMap("FilterRegion")]
        [Validation(Required=false)]
        public string FilterRegion { get; set; }

        /// <summary>
        /// The description of the GDN. The description must meet the following requirements:
        /// 
        /// *   It cannot start with `http://` or `https://`.
        /// *   It must start with a letter.
        /// *   It can contain letters, digits, underscores (\_), and hyphens (-).
        /// *   It must be 2 to 126 characters in length.
        /// </summary>
        [NameInMap("GDNDescription")]
        [Validation(Required=false)]
        public string GDNDescription { get; set; }

        /// <summary>
        /// The ID of the GDN.
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Default value: 1. The value must be an integer that is greater than 0.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 30. Valid values:
        /// 
        /// *   30
        /// *   50
        /// *   100
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
