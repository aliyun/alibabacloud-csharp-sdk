// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDirectoriesRequest : TeaModel {
        /// <summary>
        /// Details of directory IDs. You can specify one or more directory IDs.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public List<string> DirectoryId { get; set; }

        /// <summary>
        /// The directory status. This parameter is equivalent to `Status`.
        /// </summary>
        [NameInMap("DirectoryStatus")]
        [Validation(Required=false)]
        public string DirectoryStatus { get; set; }

        /// <summary>
        /// The directory type.
        /// 
        /// Valid values:
        /// 
        /// *   SIMPLE: a directory of the convenience account type
        /// *   AD_CONNECTOR: an AD directory
        /// *   RAM: a RAM directory
        /// </summary>
        [NameInMap("DirectoryType")]
        [Validation(Required=false)]
        public string DirectoryType { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the next query. If this parameter is empty, all results are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The directory status.
        /// 
        /// Valid values:
        /// 
        /// *   REGISTERING: The directory is being registered.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   DEREGISTERING: The directory is being deregistered.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   REGISTERED: The directory is registered.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   NEEDCONFIGTRUST: A trust relationship needs to be configured for the directory.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   CONFIGTRUSTFAILED: A trust relationship fails to be configured for the directory.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   DEREGISTERED: The directory is deregistered.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   ERROR: One or more configurations of the directory are invalid.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   CONFIGTRUSTING: A trust relationship is being configured.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   NEEDCONFIGUSER: Users need to be configured for the directory.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
