// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaTasksRequest : TeaModel {
        /// <summary>
        /// This parameter is not available.
        /// </summary>
        [NameInMap("FotaStatus")]
        [Validation(Required=false)]
        public string FotaStatus { get; set; }

        /// <summary>
        /// The language of the image version to update. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// *   Valid values: 1 to 100
        /// *   Default value: 20
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. If the NextToken parameter is empty, no next page exists.
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
        /// The IDs of the image update tasks. You can call the DescribeFotaTasks operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("TaskUid")]
        [Validation(Required=false)]
        public List<string> TaskUid { get; set; }

        /// <summary>
        /// Specifies whether to automatically push the image update task.
        /// 
        /// Valid values:
        /// 
        /// *   Running
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     automatically pushes the image update task.
        /// 
        ///     <!-- -->
        /// 
        /// *   Pending
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     does not automatically push the image update task.
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public string UserStatus { get; set; }

    }

}
