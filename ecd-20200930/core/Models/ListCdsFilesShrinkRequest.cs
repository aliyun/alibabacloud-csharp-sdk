// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListCdsFilesShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// The ID of the user to whom the cloud disk is allocated.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The IDs of the files to be queried.
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIdsShrink { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token used for the next query. If this parameter is empty, all results are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The sorting method of the files.
        /// 
        /// Valid values:
        /// 
        /// *   CreateTimeDesc
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts files in descending order based on the time when they are created.
        /// 
        ///     <!-- -->
        /// 
        /// *   ModifiedTimeAsc
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts files in ascending order based on the time when they are modified.
        /// 
        ///     <!-- -->
        /// 
        /// *   NameDesc
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts files in descending order based on their names.
        /// 
        ///     <!-- -->
        /// 
        /// *   SizeAsc
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts files in ascending order based on their sizes.
        /// 
        ///     <!-- -->
        /// 
        /// *   ModifiedTimeDesc
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts files in descending order based on the time when they are modified.
        /// 
        ///     <!-- -->
        /// 
        /// *   CreateTimeAsc
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts files in ascending order based on the time when they are created.
        /// 
        ///     <!-- -->
        /// 
        /// *   SizeDesc
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts files in descending order based on their sizes.
        /// 
        ///     <!-- -->
        /// 
        /// *   NameAsc
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts files in ascending order based on their names.
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The ID of the parent file.
        /// </summary>
        [NameInMap("ParentFileId")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The file status.
        /// 
        /// Valid values:
        /// 
        /// *   available
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     returns only normal files.
        /// 
        ///     <!-- -->
        /// 
        /// *   uploading
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     returns only the files that are being uploaded.
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
