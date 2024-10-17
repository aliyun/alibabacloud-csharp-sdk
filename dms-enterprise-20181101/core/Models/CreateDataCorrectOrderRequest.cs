// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataCorrectOrderRequest : TeaModel {
        /// <summary>
        /// <para>The key of the attachment that provides more instructions for the ticket. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to obtain the attachment key from the value of the AttachmentKey parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_attachment.txt</para>
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// <para>The purpose or objective of the data change. This parameter is used to help reduce unnecessary communication.</para>
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
        public CreateDataCorrectOrderRequestParam Param { get; set; }
        public class CreateDataCorrectOrderRequestParam : TeaModel {
            /// <summary>
            /// <para>The key of the attachment that contains the SQL statements used to change data. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to obtain the attachment key from the value of the AttachmentKey parameter.</para>
            /// <remarks>
            /// <para> This parameter is required if you set the <b>SqlType</b> parameter to <b>ATTACHMENT</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test.sql</para>
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// <para>The reason for the data change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para>The databases in which you want to change data.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateDataCorrectOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateDataCorrectOrderRequestParamDbItemList : TeaModel {
                /// <summary>
                /// <para>The ID of the database. The database can be a physical database or a logical database.</para>
                /// <list type="bullet">
                /// <item><description>To obtain the ID of a physical database, call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
                /// <item><description>To obtain the ID of a logical database, call the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1860****</para>
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
            /// <para>The estimated number of data rows to be affected by the data change.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EstimateAffectRows")]
            [Validation(Required=false)]
            public long? EstimateAffectRows { get; set; }

            /// <summary>
            /// <para>The execution mode of the ticket after the ticket is approved. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>COMMITOR</b>: The data change is performed by the user who submits the ticket.</description></item>
            /// <item><description><b>AUTO</b>: The data change is automatically performed after the ticket is approved.</description></item>
            /// <item><description><b>LAST_AUDITOR</b>: The data change is performed by the last approver of the ticket.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMMITOR</para>
            /// </summary>
            [NameInMap("ExecMode")]
            [Validation(Required=false)]
            public string ExecMode { get; set; }

            /// <summary>
            /// <para>The SQL statements that you want to execute to change data.</para>
            /// <remarks>
            /// <para> This parameter is required if you set the <b>SqlType</b> parameter to <b>TEXT</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>update base_user set id = 1 where id  = 1;</para>
            /// </summary>
            [NameInMap("ExecSQL")]
            [Validation(Required=false)]
            public string ExecSQL { get; set; }

            /// <summary>
            /// <para>The key of the attachment that contains the SQL statements used to roll back the data change. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to the attachment key from the value of the AttachmentKey parameter.</para>
            /// <remarks>
            /// <para> This parameter is required if you set the <b>RollbackSqlType</b> parameter to <b>ATTACHMENT</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_rollback.sql</para>
            /// </summary>
            [NameInMap("RollbackAttachmentName")]
            [Validation(Required=false)]
            public string RollbackAttachmentName { get; set; }

            /// <summary>
            /// <para>The SQL statements used to roll back the data change.</para>
            /// <remarks>
            /// <para>This parameter is required if you set the <b>RollbackSqlType</b> parameter to <b>TEXT</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>update base_user set id = 1 where id  = 1;</para>
            /// </summary>
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            /// <summary>
            /// <para>The format of the SQL statements used to roll back the data change. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TEXT</b>: text</description></item>
            /// <item><description><b>ATTACHMENT</b>: attachment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("RollbackSqlType")]
            [Validation(Required=false)]
            public string RollbackSqlType { get; set; }

            /// <summary>
            /// <para>The format of the SQL statements used to change data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TEXT</b>: text</description></item>
            /// <item><description><b>ATTACHMENT</b>: attachment</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

        }

        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// <para>The stakeholders of the data change. All stakeholders can view the ticket details and assist in the approval process. Irrelevant users other than DMS administrators and database administrators (DBAs) are not allowed to view the ticket details.</para>
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
