// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the backup files returned.</para>
        /// </summary>
        [NameInMap("BackupFiles")]
        [Validation(Required=false)]
        public List<DescribeBackupFilesResponseBodyBackupFiles> BackupFiles { get; set; }
        public class DescribeBackupFilesResponseBodyBackupFiles : TeaModel {
            /// <summary>
            /// <para>The name of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Group 1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The size of the backup file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The path to the subdirectory of the backup file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Python27\</para>
            /// </summary>
            [NameInMap("Subtree")]
            [Validation(Required=false)]
            public string Subtree { get; set; }

            /// <summary>
            /// <para>The type of the protected file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>file</b>: files</description></item>
            /// <item><description><b>dir</b>: folders</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dir</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeBackupFilesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeBackupFilesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of backup files returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of backup files returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00A60A6D-33E0-5D5A-9B7C-E5D4DCA88148</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
