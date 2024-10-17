// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeBackupFilesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeBackupFilesResponseBodyData> Data { get; set; }
        public class DescribeBackupFilesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acp-34pqe4r0kd9kn****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            [NameInMap("AndroidInstanceName")]
            [Validation(Required=false)]
            public string AndroidInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bf-b0qbg3pbpjkn7****</para>
            /// </summary>
            [NameInMap("BackupFileId")]
            [Validation(Required=false)]
            public string BackupFileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a-58ftsoo90p0qa****.ab</para>
            /// </summary>
            [NameInMap("BackupFileName")]
            [Validation(Required=false)]
            public string BackupFileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://cloudphone-saved-bucket-cn-shanghai/backup/aic-58ftsoo90p0qa****.ab</para>
            /// </summary>
            [NameInMap("BackupFilePath")]
            [Validation(Required=false)]
            public string BackupFilePath { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10227168</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-15 17:33:59</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-15 17:33:59</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ag-58ftsoo90p0qi****</para>
            /// </summary>
            [NameInMap("InstanceGroupId")]
            [Validation(Required=false)]
            public string InstanceGroupId { get; set; }

            [NameInMap("SourceFilePathList")]
            [Validation(Required=false)]
            public List<string> SourceFilePathList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("UploadEndpoint")]
            [Validation(Required=false)]
            public string UploadEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("UploadType")]
            [Validation(Required=false)]
            public string UploadType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uON****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>91</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
