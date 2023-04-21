// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeNASFileSystemsRequest : TeaModel {
        /// <summary>
        /// The IDs of the NAS file systems.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public List<string> FileSystemId { get; set; }

        /// <summary>
        /// Specifies whether to filter NAS file systems that only support the user profile management (UPM) feature.
        /// </summary>
        [NameInMap("MatchCompatibleProfile")]
        [Validation(Required=false)]
        public bool? MatchCompatibleProfile { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// *   Maximum value: 100.
        /// *   Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Set the value to the NextToken value that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
