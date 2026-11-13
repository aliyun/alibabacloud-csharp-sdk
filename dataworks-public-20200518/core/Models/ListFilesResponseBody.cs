// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of files that meet the specified conditions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFilesResponseBodyData Data { get; set; }
        public class ListFilesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The file details.</para>
            /// </summary>
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<ListFilesResponseBodyDataFiles> Files { get; set; }
            public class ListFilesResponseBodyDataFiles : TeaModel {
                /// <summary>
                /// <para>The path of the folder where the file is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business_process/my_first_business_process/MaxCompute/ods_layer</para>
                /// </summary>
                [NameInMap("AbsoluteFolderPath")]
                [Validation(Required=false)]
                public string AbsoluteFolderPath { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic parsing feature is enabled for the file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The file automatically parses code.</description></item>
                /// <item><description>false: The file does not automatically parse code.</description></item>
                /// </list>
                /// <para>This parameter corresponds to the Code Parsing setting that takes effect when you set Schedule Dependencies to Same Cycle under Schedule Settings for a Data Studio task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoParsing")]
                [Validation(Required=false)]
                public bool? AutoParsing { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The ID of the business flow to which the file belongs. Use the BusinessId field instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// <para>The ID of the business flow to which the file belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000</para>
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// <para>The current commit status of the file. Valid values: 0 (the latest code is not committed) and 1 (the latest code is committed).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CommitStatus")]
                [Validation(Required=false)]
                public int? CommitStatus { get; set; }

                /// <summary>
                /// <para>The name of the data source used when the task corresponding to the file is run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_source</para>
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The content of the file. You can call the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation to query the file content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The time when the file was created. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593950832000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud user ID of the user who created the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>382762****</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The latest committed version number of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public int? CurrentVersion { get; set; }

                /// <summary>
                /// <para>The description of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my test datastudio file</para>
                /// </summary>
                [NameInMap("FileDescription")]
                [Validation(Required=false)]
                public string FileDescription { get; set; }

                /// <summary>
                /// <para>The ID of the folder where the file is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2735c2****</para>
                /// </summary>
                [NameInMap("FileFolderId")]
                [Validation(Required=false)]
                public string FileFolderId { get; set; }

                /// <summary>
                /// <para>The ID of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000001</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ods_user_info_d</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The file type. Different file types correspond to different code types. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks node types</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public int? FileType { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource file needs to be uploaded to MaxCompute. This field is returned only if the current file is a MaxCompute resource file.</para>
                /// <para>This field is valid only when the file is a MaxCompute resource file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsMaxCompute")]
                [Validation(Required=false)]
                public bool? IsMaxCompute { get; set; }

                /// <summary>
                /// <para>The time when the file was last edited. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593950832000</para>
                /// </summary>
                [NameInMap("LastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud user ID of the user who last edited the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38748246285727</para>
                /// </summary>
                [NameInMap("LastEditUser")]
                [Validation(Required=false)]
                public string LastEditUser { get; set; }

                /// <summary>
                /// <para>The ID of the scheduled task generated in the scheduling system after the file is committed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300001</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud user ID of the file owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3872572****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the composite node file to which the current file belongs. This field is returned only if the current file is an internal file of a composite node file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The functional module to which the file belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: Data Studio.</description></item>
                /// <item><description>MANUAL: Manual task.</description></item>
                /// <item><description>MANUAL_BIZ: Manual business flow.</description></item>
                /// <item><description>SKIP: Dry-run scheduling in Data Studio.</description></item>
                /// <item><description>ADHOCQUERY: Ad hoc query.</description></item>
                /// <item><description>COMPONENT: Component management.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries that meet the specified conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to troubleshoot errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
