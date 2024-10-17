// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateStructSyncOrderRequest : TeaModel {
        /// <summary>
        /// <para>The key of an attachment that is returned after the attachment is uploaded. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to query the key of the attachment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upload_3c7edea3-e4c3-4403-857d-737043036f69_test.sql</para>
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// <para>The remarks of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The parameters of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateStructSyncOrderRequestParam Param { get; set; }
        public class CreateStructSyncOrderRequestParam : TeaModel {
            /// <summary>
            /// <para>Specifies whether to skip an error that occurs in executing an SQL statement. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: continues to execute subsequent SQL statements if an error occurs in executing an SQL statement.</description></item>
            /// <item><description><b>false</b>: stops executing subsequent SQL statements if an error occurs in executing an SQL statement.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IgnoreError")]
            [Validation(Required=false)]
            public bool? IgnoreError { get; set; }

            /// <summary>
            /// <para>The information about the base database.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public CreateStructSyncOrderRequestParamSource Source { get; set; }
            public class CreateStructSyncOrderRequestParamSource : TeaModel {
                /// <summary>
                /// <para>The ID of the database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabases</a> operation to query the ID of the database.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4324532</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The name that is used to search for the database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabases</a> operation to query the name of the database.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DbSearchName")]
                [Validation(Required=false)]
                public string DbSearchName { get; set; }

                /// <summary>
                /// <para>Specifies whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database.</description></item>
                /// <item><description><b>false</b>: The database is not a logical database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The version number of the schema. The default value is the latest schema version number. For more information, see <a href="https://help.aliyun.com/document_detail/202275.html">Manage schema versions</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e179bbb8163dcdcfacda24858bedb4d8006ae2b8</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <para>The information about the table of which you want to synchronize the schema.</para>
            /// </summary>
            [NameInMap("TableInfoList")]
            [Validation(Required=false)]
            public List<CreateStructSyncOrderRequestParamTableInfoList> TableInfoList { get; set; }
            public class CreateStructSyncOrderRequestParamTableInfoList : TeaModel {
                /// <summary>
                /// <para>The name of the source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_tbl</para>
                /// </summary>
                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                /// <summary>
                /// <para>The name of the destination table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_tbl</para>
                /// </summary>
                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

            }

            /// <summary>
            /// <para>The information about the database to which you want to synchronize the schema of a table.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public CreateStructSyncOrderRequestParamTarget Target { get; set; }
            public class CreateStructSyncOrderRequestParamTarget : TeaModel {
                /// <summary>
                /// <para>The ID of the database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabases</a> operation to query the ID of the database.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>432432</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The name that is used to search for the database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabases</a> operation to query the name of the database.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DbSearchName")]
                [Validation(Required=false)]
                public string DbSearchName { get; set; }

                /// <summary>
                /// <para>Specifies whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database.</description></item>
                /// <item><description><b>false</b>: The database is not a logical database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The version number. By default, this parameter is left empty.</para>
                /// <remarks>
                /// <para> If you specify the schema version number of the destination database, Data Management (DMS) only compares the schemas of the two databases.</para>
                /// </remarks>
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
        /// <para>The IDs of the stakeholders.</para>
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
