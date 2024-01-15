// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCloudDriveGroupsRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud disk in Cloud Drive Service.
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// The workspace ID.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The workspace name.
        /// </summary>
        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

        /// <summary>
        /// The team space status. Valid values:
        /// 
        /// *   enabled
        /// *   disabled
        /// 
        /// Default value: enabled.
        /// </summary>
        [NameInMap("DriveStatus")]
        [Validation(Required=false)]
        public string DriveStatus { get; set; }

        /// <summary>
        /// Specifies whether the space is increased.
        /// 
        /// *   binding: increased
        /// *   unbound: not increased
        /// 
        /// Default value: null. The default value indicates that all spaces are queried.
        /// </summary>
        [NameInMap("DriveType")]
        [Validation(Required=false)]
        public string DriveType { get; set; }

        /// <summary>
        /// The team ID.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public List<string> GroupId { get; set; }

        /// <summary>
        /// The team name for fuzzy search.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The team type.
        /// 
        /// *   org: organizational structure
        /// *   directory: workspace
        /// 
        /// Default value: null. The default value indicates that all types of teams are queried.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// *   Valid values: 1 to 100
        /// *   Default value: 20
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the parent node. If a parent node ID is specified, the subnodes are queried. If you set the value of this parameter to root, the root node is queried.
        /// 
        /// Default value: null. The default value indicates that all nodes are queried.
        /// </summary>
        [NameInMap("ParentGroupId")]
        [Validation(Required=false)]
        public string ParentGroupId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
