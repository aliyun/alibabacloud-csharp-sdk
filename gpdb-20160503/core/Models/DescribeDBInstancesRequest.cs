// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancesRequest : TeaModel {
        /// <summary>
        /// The edition of the instance. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   **basic**: Basic Edition
        /// *   **highavailability**: High-availability Edition
        /// *   **finance**: Enterprise Edition
        /// </summary>
        [NameInMap("DBInstanceCategories")]
        [Validation(Required=false)]
        public List<string> DBInstanceCategories { get; set; }

        /// <summary>
        /// The description of the instance.
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// The ID of the instance. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("DBInstanceIds")]
        [Validation(Required=false)]
        public string DBInstanceIds { get; set; }

        /// <summary>
        /// The resource type of the instance. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   **serverless**: Serverless mode
        /// *   **storageelastic**: elastic storage mode
        /// *   **classic**: reserved storage mode
        /// </summary>
        [NameInMap("DBInstanceModes")]
        [Validation(Required=false)]
        public List<string> DBInstanceModes { get; set; }

        /// <summary>
        /// The state of the instance. Separate multiple values with commas (,). For more information, see [Instance statuses](~~86944~~).
        /// 
        /// >  The value of this parameter must be in lowercase.
        /// </summary>
        [NameInMap("DBInstanceStatuses")]
        [Validation(Required=false)]
        public List<string> DBInstanceStatuses { get; set; }

        /// <summary>
        /// This parameter is no longer used.
        /// </summary>
        [NameInMap("InstanceDeployTypes")]
        [Validation(Required=false)]
        public List<string> InstanceDeployTypes { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **VPC**
        /// *   **Classic**
        /// 
        /// >  If you do not specify this parameter, instances of both network types are returned.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values:
        /// 
        /// *   **30**
        /// *   **50**
        /// *   **100**
        /// 
        /// Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// >  You can call the [DescribeRegions](~~86912~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesRequestTag> Tag { get; set; }
        public class DescribeDBInstancesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
