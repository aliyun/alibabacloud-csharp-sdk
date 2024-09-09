// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesetsResponseBody : TeaModel {
        /// <summary>
        /// The fileset information.
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public DescribeFilesetsResponseBodyEntries Entries { get; set; }
        public class DescribeFilesetsResponseBodyEntries : TeaModel {
            [NameInMap("Entrie")]
            [Validation(Required=false)]
            public List<DescribeFilesetsResponseBodyEntriesEntrie> Entrie { get; set; }
            public class DescribeFilesetsResponseBodyEntriesEntrie : TeaModel {
                /// <summary>
                /// The time when the fileset was created.
                /// 
                /// The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// Specifies whether to enable deletion protection to allow you to release the fileset by using the console or by calling the [DeleteFileset](https://help.aliyun.com/document_detail/2402263.html) operation. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// >  This parameter can protect filesets only against manual releases, but not against automatic releases.
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// The fileset description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The fileset path.
                /// </summary>
                [NameInMap("FileSystemPath")]
                [Validation(Required=false)]
                public string FileSystemPath { get; set; }

                /// <summary>
                /// The fileset ID.
                /// </summary>
                [NameInMap("FsetId")]
                [Validation(Required=false)]
                public string FsetId { get; set; }

                /// <summary>
                /// The fileset status. Valid values:
                /// 
                /// *   CREATING: The fileset is being created.
                /// *   CREATED: The fileset has been created and is running properly.
                /// *   RELEASING: The fileset is being released.
                /// *   RELEASED: The fileset has been deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the fileset was last updated.
                /// 
                /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The ID of the file system.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
