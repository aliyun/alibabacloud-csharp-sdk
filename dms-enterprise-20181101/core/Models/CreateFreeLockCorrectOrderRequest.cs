// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateFreeLockCorrectOrderRequest : TeaModel {
        /// <summary>
        /// The key of the attachment that provides more instructions for the ticket. You can call the [GetUserUploadFileJob](~~206069~~) operation to obtain the attachment key from the value of the AttachmentKey parameter.
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// The stakeholders of the data change. All stakeholders can view the ticket details and assist in the approval process. Irrelevant users other than DMS administrators and database administrators (DBAs) are not allowed to view the ticket details.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The key of the attachment that contains the SQL statements used to roll back the data change.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateFreeLockCorrectOrderRequestParam Param { get; set; }
        public class CreateFreeLockCorrectOrderRequestParam : TeaModel {
            /// <summary>
            /// Specifies whether the database is a logical database. Valid values:
            /// 
            /// *   **true**: The database is a logical database.
            /// *   **false**: The database is a physical database.
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// The error code returned if the request fails.
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// The key of the attachment that contains the SQL statements used to change data. This parameter is not supported.
            /// </summary>
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateFreeLockCorrectOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateFreeLockCorrectOrderRequestParamDbItemList : TeaModel {
                /// <summary>
                /// The purpose or objective of the data change. This parameter is used to help reduce unnecessary communication.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The SQL statements used to roll back the data change.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

            /// <summary>
            /// The ID of the database. The database can be a physical database or a logical database.
            /// 
            /// *   To obtain the ID of a physical database, call the [ListDatabases](~~141873~~) or [SearchDatabase](~~141876~~) operation.
            /// *   To obtain the ID of a logical database, call the [ListLogicDatabases](~~141874~~) or [SearchDatabase](~~141876~~) operation.
            /// </summary>
            [NameInMap("ExecMode")]
            [Validation(Required=false)]
            public string ExecMode { get; set; }

            /// <summary>
            /// The format of the SQL statements used to roll back the data change. Valid values:
            /// 
            /// *   **TEXT**: text
            /// *   **ATTACHMENT**: attachment. This value is not supported.
            /// </summary>
            [NameInMap("ExecSQL")]
            [Validation(Required=false)]
            public string ExecSQL { get; set; }

            /// <summary>
            /// The error message returned if the request fails.
            /// </summary>
            [NameInMap("RollbackAttachmentName")]
            [Validation(Required=false)]
            public string RollbackAttachmentName { get; set; }

            /// <summary>
            /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
            /// </summary>
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            /// <summary>
            /// The databases in which you want to change data.
            /// </summary>
            [NameInMap("RollbackSqlType")]
            [Validation(Required=false)]
            public string RollbackSqlType { get; set; }

            /// <summary>
            /// The operation that you want to perform. Set the value to CreateFreeLockCorrectOrder.
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

        }

        /// <summary>
        /// The parameters of the ticket.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// The ID of the ticket.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
