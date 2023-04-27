// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateStructSyncOrderRequest : TeaModel {
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// Specifies whether to skip an error that occurs in executing an SQL statement. Valid values:
        /// 
        /// *   **true**: continues to execute subsequent SQL statements if an error occurs in executing an SQL statement.
        /// *   **false**: stops executing subsequent SQL statements if an error occurs in executing an SQL statement.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The name of the source table.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateStructSyncOrderRequestParam Param { get; set; }
        public class CreateStructSyncOrderRequestParam : TeaModel {
            [NameInMap("IgnoreError")]
            [Validation(Required=false)]
            public bool? IgnoreError { get; set; }

            /// <summary>
            /// The name of the destination table.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public CreateStructSyncOrderRequestParamSource Source { get; set; }
            public class CreateStructSyncOrderRequestParamSource : TeaModel {
                /// <summary>
                /// The key of an attachment that is returned after the attachment is uploaded. You can call the [GetUserUploadFileJob](~~206069~~) operation to query the key of the attachment.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The ID of the tenant.
                /// 
                /// >  To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see [Manage DMS tenants](~~181330~~).
                /// </summary>
                [NameInMap("DbSearchName")]
                [Validation(Required=false)]
                public string DbSearchName { get; set; }

                /// <summary>
                /// The schema of the response.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            [NameInMap("TableInfoList")]
            [Validation(Required=false)]
            public List<CreateStructSyncOrderRequestParamTableInfoList> TableInfoList { get; set; }
            public class CreateStructSyncOrderRequestParamTableInfoList : TeaModel {
                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

            }

            /// <summary>
            /// Indicates whether the request is successful.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public CreateStructSyncOrderRequestParamTarget Target { get; set; }
            public class CreateStructSyncOrderRequestParamTarget : TeaModel {
                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The error code.
                /// </summary>
                [NameInMap("DbSearchName")]
                [Validation(Required=false)]
                public string DbSearchName { get; set; }

                /// <summary>
                /// The result of creating the ticket.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The ID of the ticket.
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

        }

        /// <summary>
        /// The information about the table of which you want to synchronize the schema.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
