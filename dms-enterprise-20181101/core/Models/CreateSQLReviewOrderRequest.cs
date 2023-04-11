// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateSQLReviewOrderRequest : TeaModel {
        /// <summary>
        /// The purpose or objective of the SQL review. This reduces unnecessary communication.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The parameters of the ticket.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateSQLReviewOrderRequestParam Param { get; set; }
        public class CreateSQLReviewOrderRequestParam : TeaModel {
            /// <summary>
            /// The files to be reviewed. Multiple files can be reviewed at a time.
            /// </summary>
            [NameInMap("AttachmentKeyList")]
            [Validation(Required=false)]
            public List<string> AttachmentKeyList { get; set; }

            /// <summary>
            /// The ID of the database. You can call the [SearchDatabases](~~141876~~) operation to query the ID of the database.
            /// 
            /// >  You can call this operation to query only physical databases. This operation is unavailable to query logical databases.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// The name of the project.
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

        }

        /// <summary>
        /// The stakeholders involved in this operation. All the specified stakeholders can view the ticket details and take part in the approval process. Irrelevant users other than DMS administrators and database administrators (DBAs) are not allowed to view the ticket details.
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
