// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDirQuotasResponseBody : TeaModel {
        /// <summary>
        /// <para>The quota information for each directory.</para>
        /// </summary>
        [NameInMap("DirQuotaInfos")]
        [Validation(Required=false)]
        public List<DescribeDirQuotasResponseBodyDirQuotaInfos> DirQuotaInfos { get; set; }
        public class DescribeDirQuotasResponseBodyDirQuotaInfos : TeaModel {
            /// <summary>
            /// <para>The inode number of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1123</para>
            /// </summary>
            [NameInMap("DirInode")]
            [Validation(Required=false)]
            public string DirInode { get; set; }

            /// <summary>
            /// <para>The absolute path of the directory in the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data/sub1</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The statistical status of the directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Initializing: The directory is being initialized.</description></item>
            /// <item><description>Normal: The directory is in a normal state.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The quota information for each user.</para>
            /// </summary>
            [NameInMap("UserQuotaInfos")]
            [Validation(Required=false)]
            public List<DescribeDirQuotasResponseBodyDirQuotaInfosUserQuotaInfos> UserQuotaInfos { get; set; }
            public class DescribeDirQuotasResponseBodyDirQuotaInfosUserQuotaInfos : TeaModel {
                /// <summary>
                /// <para>The limit on the number of files for the user in the directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("FileCountLimit")]
                [Validation(Required=false)]
                public long? FileCountLimit { get; set; }

                /// <summary>
                /// <para>The actual number of files for the user in the directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5100</para>
                /// </summary>
                [NameInMap("FileCountReal")]
                [Validation(Required=false)]
                public long? FileCountReal { get; set; }

                /// <summary>
                /// <para>The quota type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Accounting: statistical quota.</description></item>
                /// <item><description>Enforcement: restriction quota.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Accounting</para>
                /// </summary>
                [NameInMap("QuotaType")]
                [Validation(Required=false)]
                public string QuotaType { get; set; }

                /// <summary>
                /// <para>The limit on the total size of files for the user in the directory. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public long? SizeLimit { get; set; }

                /// <summary>
                /// <para>The actual total size of files for the user in the directory. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("SizeReal")]
                [Validation(Required=false)]
                public long? SizeReal { get; set; }

                /// <summary>
                /// <para>The actual total size of files for the user in the directory. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>858995833870</para>
                /// </summary>
                [NameInMap("SizeRealInByte")]
                [Validation(Required=false)]
                public long? SizeRealInByte { get; set; }

                /// <summary>
                /// <para>The UID or GID to which the quota applies. The value depends on the UserType parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The type of the user ID. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Uid: The user ID is a UID. If this value is returned, the UserId parameter has a value.</description></item>
                /// <item><description>Gid: The user ID is a GID. If this value is returned, the UserId parameter has a value.</description></item>
                /// <item><description>AllUsers: The quota applies to all users. If this value is returned, the UserId parameter is empty.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Uid</para>
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of directories per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BC5CB97-9F28-42FE-84A4-0CD0DF42****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of directories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
