// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLExecAuditLogResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SQLExecAuditLogList")]
        [Validation(Required=false)]
        public ListSQLExecAuditLogResponseBodySQLExecAuditLogList SQLExecAuditLogList { get; set; }
        public class ListSQLExecAuditLogResponseBodySQLExecAuditLogList : TeaModel {
            [NameInMap("SQLExecAuditLog")]
            [Validation(Required=false)]
            public List<ListSQLExecAuditLogResponseBodySQLExecAuditLogListSQLExecAuditLog> SQLExecAuditLog { get; set; }
            public class ListSQLExecAuditLogResponseBodySQLExecAuditLogListSQLExecAuditLog : TeaModel {
                [NameInMap("AffectRows")]
                [Validation(Required=false)]
                public long? AffectRows { get; set; }

                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public long? ElapsedTime { get; set; }

                [NameInMap("ExecState")]
                [Validation(Required=false)]
                public string ExecState { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("OpTime")]
                [Validation(Required=false)]
                public string OpTime { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("SQL")]
                [Validation(Required=false)]
                public string SQL { get; set; }

                [NameInMap("SQLType")]
                [Validation(Required=false)]
                public string SQLType { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
