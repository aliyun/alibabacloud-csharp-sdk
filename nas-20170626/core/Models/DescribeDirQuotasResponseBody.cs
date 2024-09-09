// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDirQuotasResponseBody : TeaModel {
        /// <summary>
        /// The queried directory quotas.
        /// </summary>
        [NameInMap("DirQuotaInfos")]
        [Validation(Required=false)]
        public List<DescribeDirQuotasResponseBodyDirQuotaInfos> DirQuotaInfos { get; set; }
        public class DescribeDirQuotasResponseBodyDirQuotaInfos : TeaModel {
            /// <summary>
            /// The inode number of the directory.
            /// </summary>
            [NameInMap("DirInode")]
            [Validation(Required=false)]
            public string DirInode { get; set; }

            /// <summary>
            /// The absolute path of a directory.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The status of the quota created for the directory. Valid values: Initializing and Normal. The Initializing state indicates that the quota is being created. The Normal state indicates that the quota is created.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The information about quotas for all users.
            /// </summary>
            [NameInMap("UserQuotaInfos")]
            [Validation(Required=false)]
            public List<DescribeDirQuotasResponseBodyDirQuotaInfosUserQuotaInfos> UserQuotaInfos { get; set; }
            public class DescribeDirQuotasResponseBodyDirQuotaInfosUserQuotaInfos : TeaModel {
                /// <summary>
                /// The maximum number of files that a user can create in the directory.
                /// </summary>
                [NameInMap("FileCountLimit")]
                [Validation(Required=false)]
                public long? FileCountLimit { get; set; }

                /// <summary>
                /// The total number of files that a user has created in the directory.
                /// </summary>
                [NameInMap("FileCountReal")]
                [Validation(Required=false)]
                public long? FileCountReal { get; set; }

                /// <summary>
                /// The type of the quota. Valid values: Accounting and Enforcement.
                /// </summary>
                [NameInMap("QuotaType")]
                [Validation(Required=false)]
                public string QuotaType { get; set; }

                /// <summary>
                /// The maximum size of files that a user can create in the directory. Unit: GiB.
                /// </summary>
                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public long? SizeLimit { get; set; }

                /// <summary>
                /// The total size of files that a user has created in the directory. Unit: GiB.
                /// </summary>
                [NameInMap("SizeReal")]
                [Validation(Required=false)]
                public long? SizeReal { get; set; }

                /// <summary>
                /// The total size of files that a user has created in the directory. Unit: bytes.
                /// </summary>
                [NameInMap("SizeRealInByte")]
                [Validation(Required=false)]
                public long? SizeRealInByte { get; set; }

                /// <summary>
                /// The ID of the user that you specify to create a quota for the directory. The value depends on the value of the UserType parameter. Valid values: Uid and Gid.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The type of user. Valid values: Uid, Gid, and AllUsers.
                /// 
                /// *   If Uid or Gid is returned, a value is returned for UserId.
                /// *   If AllUsers is returned, UserId is empty.
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of directories.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
