// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListOfficeSiteOverviewRequest : TeaModel {
        /// <summary>
        /// Specifies whether to refresh the cache.
        /// </summary>
        [NameInMap("ForceRefresh")]
        [Validation(Required=false)]
        public bool? ForceRefresh { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// *   Valid values: 1 to 100
        /// *   Default value: 10
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the next query. If this is your first query or no next query is to be sent, skip this parameter. If a next query is to be sent, set the parameter to the value of NextToken that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The office network IDs. You can specify IDs of 1 to 100 office networks.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public List<string> OfficeSiteId { get; set; }

        /// <summary>
        /// The query scope. Cloud computers in a cloud computer pool are pooled cloud computers.
        /// 
        /// Default values:
        /// 
        /// *   1 (default): queries non-pooled cloud computers in the office network.
        /// *   2: queries pooled cloud computers in the office network.
        /// *   3: queries all cloud computers in the office network.
        /// </summary>
        [NameInMap("QueryRange")]
        [Validation(Required=false)]
        public int? QueryRange { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
