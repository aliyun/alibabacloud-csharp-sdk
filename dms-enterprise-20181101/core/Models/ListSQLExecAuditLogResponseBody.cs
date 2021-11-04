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
                public long? AffectRows { get; set; }
                public long? DbId { get; set; }
                public long? ElapsedTime { get; set; }
                public string ExecState { get; set; }
                public long? InstanceId { get; set; }
                public string InstanceName { get; set; }
                public bool? Logic { get; set; }
                public string OpTime { get; set; }
                public string Remark { get; set; }
                public string SQL { get; set; }
                public string SQLType { get; set; }
                public string SchemaName { get; set; }
                public long? UserId { get; set; }
                public string UserName { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
