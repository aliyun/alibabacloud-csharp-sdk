// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDedicatedBlockStorageClustersRequest : TeaModel {
        /// <summary>
        /// The zone ID of the dedicated block storage cluster. You can call the [DescribeZones](https://help.aliyun.com/document_detail/25610.html) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("AzoneId")]
        [Validation(Required=false)]
        public string AzoneId { get; set; }

        /// <summary>
        /// The category of disks that can be created in the dedicated block storage cluster.
        /// 
        /// Set the value to cloud_essd. Only enhanced SSDs (ESSDs) can be created in dedicated block storage clusters.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DedicatedBlockStorageClusterId")]
        [Validation(Required=false)]
        public List<string> DedicatedBlockStorageClusterId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the dedicated block storage cluster. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the dedicated block storage cluster belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The states of dedicated block storage clusters. Valid values:
        /// 
        /// *   Preparing
        /// *   Running
        /// *   Expired
        /// *   Offline
        /// 
        /// Multiple states can be specified. Valid values of N: 1, 2, 3, and 4.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// The tags. Up to 20 tags are supported.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDedicatedBlockStorageClustersRequestTag> Tag { get; set; }
        public class DescribeDedicatedBlockStorageClustersRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the dedicated block storage cluster.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the dedicated block storage cluster.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
