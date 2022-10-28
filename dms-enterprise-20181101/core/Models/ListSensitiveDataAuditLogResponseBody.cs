// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveDataAuditLogResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SensitiveDataAuditLogList")]
        [Validation(Required=false)]
        public List<ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogList> SensitiveDataAuditLogList { get; set; }
        public class ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogList : TeaModel {
            [NameInMap("DbDisplayName")]
            [Validation(Required=false)]
            public string DbDisplayName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            [NameInMap("OpTime")]
            [Validation(Required=false)]
            public string OpTime { get; set; }

            [NameInMap("SensitiveDataLog")]
            [Validation(Required=false)]
            public List<ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogListSensitiveDataLog> SensitiveDataLog { get; set; }
            public class ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogListSensitiveDataLog : TeaModel {
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("ColumnPermissionType")]
                [Validation(Required=false)]
                public string ColumnPermissionType { get; set; }

                [NameInMap("DesensitizationRule")]
                [Validation(Required=false)]
                public string DesensitizationRule { get; set; }

                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
