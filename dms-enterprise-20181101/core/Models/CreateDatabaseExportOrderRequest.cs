// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDatabaseExportOrderRequest : TeaModel {
        /// <summary>
        /// <para>The key of the attachment that provides more instructions for the ticket. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to obtain the attachment key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_attachment.txt</para>
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// <para>The purpose or objective of the ticket. This parameter helps reduce unnecessary communication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document_test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the parent ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>877****</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// <para>The parameters of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PluginParam")]
        [Validation(Required=false)]
        public CreateDatabaseExportOrderRequestPluginParam PluginParam { get; set; }
        public class CreateDatabaseExportOrderRequestPluginParam : TeaModel {
            /// <summary>
            /// <para>The reason for the database export.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>document_test</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para>The configurations for database export.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public CreateDatabaseExportOrderRequestPluginParamConfig Config { get; set; }
            public class CreateDatabaseExportOrderRequestPluginParamConfig : TeaModel {
                /// <summary>
                /// <para>The export options for big data. The options are used to filter the big data to be exported. You can leave this parameter empty.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("DataOption")]
                [Validation(Required=false)]
                public List<string> DataOption { get; set; }

                /// <summary>
                /// <para>The type of data that you want to export. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DATA</b>: The data of the database is exported.</description></item>
                /// <item><description><b>STRUCT</b>: The schema of the database is exported.</description></item>
                /// <item><description><b>DATA_STRUCT</b>: The data and schema of the database are exported.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA</para>
                /// </summary>
                [NameInMap("ExportContent")]
                [Validation(Required=false)]
                public string ExportContent { get; set; }

                /// <summary>
                /// <para>The types of schemas that you want to export.</para>
                /// </summary>
                [NameInMap("ExportTypes")]
                [Validation(Required=false)]
                public List<string> ExportTypes { get; set; }

                /// <summary>
                /// <para>The extension options of the SQL script. You can leave this parameter empty.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("SQLExtOption")]
                [Validation(Required=false)]
                public List<string> SQLExtOption { get; set; }

                /// <summary>
                /// <para>The tables that you want to export.</para>
                /// </summary>
                [NameInMap("SelectedTables")]
                [Validation(Required=false)]
                public List<string> SelectedTables { get; set; }

                /// <summary>
                /// <para>The conditions used to filter the tables to be exported.</para>
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public Dictionary<string, string> Tables { get; set; }

                /// <summary>
                /// <para>The format in which the database is exported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SQL</b></description></item>
                /// <item><description><b>CSV</b></description></item>
                /// <item><description><b>XLSX</b></description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL</para>
                /// </summary>
                [NameInMap("TargetOption")]
                [Validation(Required=false)]
                public string TargetOption { get; set; }

            }

            /// <summary>
            /// <para>The database ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17****</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>137****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>Specifies whether the database is a logical database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// <para>The name that is used to search for the database.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@xxx.xxx.xxx.xxx">test@xxx.xxx.xxx.xxx</a>:3306</para>
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

        }

        /// <summary>
        /// <para>The stakeholders involved in this operation.</para>
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para>To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
