// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataCorrectOrderRequest : TeaModel {
        /// <summary>
        /// The key of the attachment that provides more instructions for the ticket. You can call the [GetUserUploadFileJob](~~206069~~) operation to obtain the attachment key from the value of the AttachmentKey parameter.
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// The purpose or objective of the data change. This parameter is used to help reduce unnecessary communication.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The parameters of the ticket.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataCorrectOrderRequestParam Param { get; set; }
        public class CreateDataCorrectOrderRequestParam : TeaModel {
            /// <summary>
            /// The key of the attachment that contains the SQL statements used to change data. You can call the [GetUserUploadFileJob](~~206069~~) operation to obtain the attachment key from the value of the AttachmentKey parameter.
            /// 
            /// >  This parameter is required if you set the **SqlType** parameter to **ATTACHMENT**.
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// The reason for the data change.
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// The databases in which you want to change data.
            /// </summary>
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateDataCorrectOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateDataCorrectOrderRequestParamDbItemList : TeaModel {
                /// <summary>
                /// The ID of the database. The database can be a physical database or a logical database.
                /// 
                /// *   To obtain the ID of a physical database, call the [ListDatabases](~~141873~~) or [SearchDatabase](~~141876~~) operation.
                /// *   To obtain the ID of a logical database, call the [ListLogicDatabases](~~141874~~) or [SearchDatabase](~~141876~~) operation.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// Specifies whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: The database is a physical database.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

            /// <summary>
            /// The estimated number of data rows to be affected by the data change.
            /// </summary>
            [NameInMap("EstimateAffectRows")]
            [Validation(Required=false)]
            public long? EstimateAffectRows { get; set; }

            /// <summary>
            /// The execution mode of the ticket after the ticket is approved. Valid values:
            /// 
            /// *   **COMMITOR**: The data change is performed by the user who submits the ticket.
            /// *   **AUTO**: The data change is automatically performed after the ticket is approved.
            /// *   **LAST_AUDITOR**: The data change is performed by the last approver of the ticket.
            /// </summary>
            [NameInMap("ExecMode")]
            [Validation(Required=false)]
            public string ExecMode { get; set; }

            /// <summary>
            /// The SQL statements that you want to execute to change data.
            /// 
            /// >  This parameter is required if you set the **SqlType** parameter to **TEXT**.
            /// </summary>
            [NameInMap("ExecSQL")]
            [Validation(Required=false)]
            public string ExecSQL { get; set; }

            /// <summary>
            /// The key of the attachment that contains the SQL statements used to roll back the data change. You can call the [GetUserUploadFileJob](~~206069~~) operation to the attachment key from the value of the AttachmentKey parameter.
            /// 
            /// >  This parameter is required if you set the **RollbackSqlType** parameter to **ATTACHMENT**.
            /// </summary>
            [NameInMap("RollbackAttachmentName")]
            [Validation(Required=false)]
            public string RollbackAttachmentName { get; set; }

            /// <summary>
            /// The SQL statements used to roll back the data change.
            /// 
            /// > 
            /// *   This parameter is required if you set the **RollbackSqlType** parameter to **TEXT**.
            /// </summary>
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            /// <summary>
            /// The format of the SQL statements used to roll back the data change. Valid values:
            /// 
            /// *   **TEXT**: text
            /// *   **ATTACHMENT**: attachment
            /// </summary>
            [NameInMap("RollbackSqlType")]
            [Validation(Required=false)]
            public string RollbackSqlType { get; set; }

            /// <summary>
            /// The format of the SQL statements used to change data. Valid values:
            /// 
            /// *   **TEXT**: text
            /// *   **ATTACHMENT**: attachment
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

        }

        /// <summary>
        /// The stakeholders of the data change. All stakeholders can view the ticket details and assist in the approval process. Irrelevant users other than DMS administrators and database administrators (DBAs) are not allowed to view the ticket details.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
