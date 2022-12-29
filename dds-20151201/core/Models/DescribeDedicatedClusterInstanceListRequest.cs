// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDedicatedClusterInstanceListRequest : TeaModel {
        /// <summary>
        /// The ID of the dedicated cluster to which the instance belongs.
        /// 
        /// >  Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the dedicated host.
        /// 
        /// >  Separate multiple names with commas (,).
        /// </summary>
        [NameInMap("DedicatedHostName")]
        [Validation(Required=false)]
        public string DedicatedHostName { get; set; }

        /// <summary>
        /// The database engine. Set the value to MongoDB.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The version number of the database engine. Set the value to **4.2**.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The ID of the ApsaraDB for MongoDB instance.
        /// 
        /// >  Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   0: The instance is connected over the Internet.
        /// *   1: The instance is connected over an internal network.
        /// *   2\. The instance is deployed in a VPC.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("InstanceNetType")]
        [Validation(Required=false)]
        public string InstanceNetType { get; set; }

        /// <summary>
        /// The status of the instance. For information about the valid values of this parameter, see [Valid values of the InstanceStatus parameter for DescribeDedicatedClusterInstanceList](~~190071~~).
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Valid values: any non-zero positive integer. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **30**, **50**, and **100**. Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~61933~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the zone. You can call [DescribeZones](~~61933~~) to query the zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
