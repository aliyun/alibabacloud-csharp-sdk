// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateProcCorrectOrderRequest : TeaModel {
        /// <summary>
        /// <para>The key of the attachment for the ticket. The attachment provides more instructions for this operation.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to query the key of the attachment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_attachment.txt</para>
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
        public CreateProcCorrectOrderRequestParam Param { get; set; }
        public class CreateProcCorrectOrderRequestParam : TeaModel {
            /// <summary>
            /// <para>The reason for the programmable object change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para>The information about the database.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateProcCorrectOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateProcCorrectOrderRequestParamDbItemList : TeaModel {
                /// <summary>
                /// <para>The database ID. Databases are divided into physical databases and logical databases.</para>
                /// <list type="bullet">
                /// <item><description>To query the ID of a physical database, call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
                /// <item><description>To query the ID of a logical database, call the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19721978</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>Specifies whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database.</description></item>
                /// <item><description><b>false</b>: The database is a physical database.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

            /// <summary>
            /// <para>The mode in which the data change ticket is executed after the ticket is approved. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>COMMITOR</b>: The ticket is executed by the user who submits the ticket.</description></item>
            /// <item><description><b>AUTO</b>: The ticket is automatically executed after the ticket is approved.</description></item>
            /// <item><description><b>LAST_AUDITOR</b>: The ticket is executed by the last approver of the ticket.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMMITOR</para>
            /// </summary>
            [NameInMap("ExecMode")]
            [Validation(Required=false)]
            public string ExecMode { get; set; }

            /// <summary>
            /// <para>The SQL statements for data change.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELIMITER ///
            /// CREATE PROCEDURE GetAllProducts()
            /// BEGIN
            /// SELECT *  FROM base_user;
            /// END ///</para>
            /// </summary>
            [NameInMap("ExecSQL")]
            [Validation(Required=false)]
            public string ExecSQL { get; set; }

            /// <summary>
            /// <para>The key of the attachment that contains the SQL statements used to roll back the data change. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to obtain the attachment key from the value of AttachmentKey.</para>
            /// <remarks>
            /// <para> This parameter is required if you set <b>RollbackSqlType</b> to <b>ATTACHMENT</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_rollback.sql</para>
            /// </summary>
            [NameInMap("RollbackAttachmentName")]
            [Validation(Required=false)]
            public string RollbackAttachmentName { get; set; }

            /// <summary>
            /// <para>The SQL statements for rolling back the data change.</para>
            /// <remarks>
            /// <para> This parameter is required if you set the <b>RollbackSqlType</b> parameter to <b>TEXT</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>empty</para>
            /// </summary>
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            /// <summary>
            /// <para>The format of the SQL statements used to roll back the data change. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TEXT</b></description></item>
            /// <item><description><b>ATTACHMENT</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("RollbackSqlType")]
            [Validation(Required=false)]
            public string RollbackSqlType { get; set; }

        }

        /// <summary>
        /// <para>The operators that are related to the ticket.</para>
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
