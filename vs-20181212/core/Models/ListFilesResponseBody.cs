// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of file information.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ListFilesResponseBodyFiles> Files { get; set; }
        public class ListFilesResponseBodyFiles : TeaModel {
            /// <summary>
            /// <para>The description of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My file</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-1671accd4dafdag3er256cvgewt13f7141db2f7</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myfile</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The upload status of the file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created</description></item>
            /// <item><description>Doing</description></item>
            /// <item><description>Success: final state</description></item>
            /// <item><description>Failed: final state</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The description of the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upload success</para>
            /// </summary>
            [NameInMap("StatusDescription")]
            [Validation(Required=false)]
            public string StatusDescription { get; set; }

            /// <summary>
            /// <para>The target path for pushing the file to the cloud application service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data/tmp/test/xxx.tar</para>
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// <para>The time when the status was last updated. The time follows the ISO 8601 standard and includes the time zone offset in the YYYY-MM-DDTHH:mm:ss+HH:mm format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-28T14:15:08+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The time when the upload started. The time follows the ISO 8601 standard and includes the time zone offset in the YYYY-MM-DDTHH:mm:ss+HH:mm format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-28T14:10:12+08:00</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The Settings for the number of entries per page during paging in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matched file records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
