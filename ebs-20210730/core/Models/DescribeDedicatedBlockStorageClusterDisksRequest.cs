// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDedicatedBlockStorageClusterDisksRequest : TeaModel {
        /// <summary>
        /// The ID of the dedicated block storage cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbscId")]
        [Validation(Required=false)]
        public string DbscId { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page. Maximum value: 500.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The query token. Set the value to the NextToken value returned in the previous call to the DescribeDedicatedBlockStorageClusterDisks operation. Leave this parameter empty the first time you call this operation.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region where the dedicated block storage cluster resides. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
