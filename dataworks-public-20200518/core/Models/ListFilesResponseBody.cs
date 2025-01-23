// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The files returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFilesResponseBodyData Data { get; set; }
        public class ListFilesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the files.</para>
            /// </summary>
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<ListFilesResponseBodyDataFiles> Files { get; set; }
            public class ListFilesResponseBodyDataFiles : TeaModel {
                [NameInMap("AbsoluteFolderPath")]
                [Validation(Required=false)]
                public string AbsoluteFolderPath { get; set; }

                /// <summary>
                /// <para>Specifies whether the automatic parsing feature is enabled for the file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The automatic parsing feature is enabled for the file.</description></item>
                /// <item><description>false: The automatic parsing feature is not enabled for the file.</description></item>
                /// </list>
                /// <para>This parameter is equivalent to the Analyze Code parameter in the Dependencies section of the Properties panel in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoParsing")]
                [Validation(Required=false)]
                public bool? AutoParsing { get; set; }

                /// <summary>
                /// <para>The ID of the workflow to which the file belongs. This parameter is deprecated and replaced by the BusinessId parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// <para>The ID of the workflow to which the file belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000</para>
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// <para>Indicates whether the latest code in the file is committed. Valid values: 0 and 1. The value 0 indicates that the latest code in the file is not committed. The value 1 indicates that the latest code in the file is committed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CommitStatus")]
                [Validation(Required=false)]
                public int? CommitStatus { get; set; }

                /// <summary>
                /// <para>The ID of the compute engine instance that is used to run the node that corresponds to the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_first</para>
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated. You can call the <a href="~~173954#doc-api-dataworks-public-GetFile~~">GetFile</a> operation to query the details of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The time when the file was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593950832000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to create the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>382762****</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The latest version number of the file.</para>
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
                /// <para>The ID of the folder to which the file belongs.</para>
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
                /// <para>The type of the code in the file. Valid values: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), and 1221 (PyODPS 3).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public int? FileType { get; set; }

                /// <summary>
                /// <para>Indicates whether the file needs to be uploaded to MaxCompute if the file is a MaxCompute resource file.</para>
                /// <para>This parameter is returned only if the file is a MaxCompute resource file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsMaxCompute")]
                [Validation(Required=false)]
                public bool? IsMaxCompute { get; set; }

                /// <summary>
                /// <para>The time when the file was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593950832000</para>
                /// </summary>
                [NameInMap("LastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to last modify the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38748246285727</para>
                /// </summary>
                [NameInMap("LastEditUser")]
                [Validation(Required=false)]
                public string LastEditUser { get; set; }

                /// <summary>
                /// <para>The ID of the auto triggered node that is generated in the scheduling system after the file is committed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300001</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the file owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3872572****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the node group file to which the current file belongs. This parameter is returned only if the current file is an inner file of the node group file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The module to which the file belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: The file is used for DataStudio.</description></item>
                /// <item><description>MANUAL: The file is used for a manually triggered node.</description></item>
                /// <item><description>MANUAL_BIZ: The file is used for a manually triggered workflow.</description></item>
                /// <item><description>SKIP: The files is used for a dry-run node in DataStudio.</description></item>
                /// <item><description>ADHOCQUERY: The file is used for an ad hoc query.</description></item>
                /// <item><description>COMPONENT: The file is used for a snippet.</description></item>
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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID. You can troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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
