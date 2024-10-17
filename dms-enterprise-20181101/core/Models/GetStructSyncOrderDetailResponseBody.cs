// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E1D2B4D-3E53-4ABC-999D-1D2520B3471A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the schema synchronization ticket.</para>
        /// </summary>
        [NameInMap("StructSyncOrderDetail")]
        [Validation(Required=false)]
        public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetail StructSyncOrderDetail { get; set; }
        public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetail : TeaModel {
            /// <summary>
            /// <para>Indicates whether to skip errors. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: skips the error and continues to execute SQL statements.</description></item>
            /// <item><description><b>false</b>: stops executing SQL statements.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IgnoreError")]
            [Validation(Required=false)]
            public bool? IgnoreError { get; set; }

            /// <summary>
            /// <para>The information about the source database.</para>
            /// </summary>
            [NameInMap("SourceDatabaseInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceDatabaseInfo SourceDatabaseInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceDatabaseInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the source database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>432532</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The type of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The type of the environment to which the database instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/163309.html">Change the environment type of an instance</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database.</description></item>
                /// <item><description><b>false</b>: The database is not a logical database</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The name that is used to search for the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// <para>The schema version of the source database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DATASOURCE</b>: the default latest version of the system</description></item>
            /// <item><description><b>VERSION</b>: a previous schema version that you manually specify</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VERSION</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The version information about the source instance.</para>
            /// <remarks>
            /// <para>This parameter is displayed only when the value of the <b>SourceType</b> parameter is <b>VERSION</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SourceVersionInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceVersionInfo SourceVersionInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceVersionInfo : TeaModel {
                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e179bbb8163dcdcfacda24858bedb4d8006ae2b8</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <para>The information about the table whose schema you want to synchronize.</para>
            /// </summary>
            [NameInMap("TableInfoList")]
            [Validation(Required=false)]
            public List<GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTableInfoList> TableInfoList { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTableInfoList : TeaModel {
                /// <summary>
                /// <para>The name of the table whose schema you want to synchronize.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_tbl</para>
                /// </summary>
                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                /// <summary>
                /// <para>The name of the table to which you want to synchronize the schema of a table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_tbl</para>
                /// </summary>
                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

            }

            /// <summary>
            /// <para>The information about the destination database.</para>
            /// </summary>
            [NameInMap("TargetDatabaseInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetDatabaseInfo TargetDatabaseInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetDatabaseInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the destination database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>432543</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The type of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The type of the environment to which the database instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/163309.html">Change the environment type of an instance</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database.</description></item>
                /// <item><description><b>false</b>: The database is not a logical database</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The name that is used to search for the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// <para>The schema version of the destination database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DATASOURCE</b>: the default latest version of the system</description></item>
            /// <item><description><b>VERSION</b>: a previous schema version that you manually specify</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATASOURCE</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The version information about the destination instance.</para>
            /// <remarks>
            /// <para>This parameter is displayed only when the value of the <b>SourceType</b> parameter is <b>VERSION</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TargetVersionInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetVersionInfo TargetVersionInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetVersionInfo : TeaModel {
                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e179bbb8163dcdcfacda24858bedb4d8006ae2b8</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
