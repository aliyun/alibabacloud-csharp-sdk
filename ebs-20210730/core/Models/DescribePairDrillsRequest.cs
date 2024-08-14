// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribePairDrillsRequest : TeaModel {
        /// <summary>
        /// The ID of the drill.
        /// </summary>
        [NameInMap("DrillId")]
        [Validation(Required=false)]
        public string DrillId { get; set; }

        /// <summary>
        /// The maximum number of entries to be returned. You can use this parameter together with NextToken.
        /// 
        /// Valid values: 1 to 500.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Set the value to the NextToken value returned in the previous call to the DescribeDiskReplicaPairs operation. Leave this parameter empty the first time you call this operation. When you specify NextToken, the PageSize and PageNumber request parameters do not take effect and the TotalCount response parameter is invalid.
        /// </summary>
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
        /// The ID of the replication pair. You can call the [DescribeDiskReplicaPairs](https://help.aliyun.com/document_detail/354206.html) operation to query a list of asynchronous replication pairs, including replication pair IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PairId")]
        [Validation(Required=false)]
        public string PairId { get; set; }

        /// <summary>
        /// The region ID of the primary or secondary disk in the async replication pair. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/354276.html) operation to query the most recent list of regions in which async replication is supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
