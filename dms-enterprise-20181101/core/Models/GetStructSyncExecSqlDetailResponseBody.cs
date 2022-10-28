// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncExecSqlDetailResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StructSyncExecSqlDetail")]
        [Validation(Required=false)]
        public GetStructSyncExecSqlDetailResponseBodyStructSyncExecSqlDetail StructSyncExecSqlDetail { get; set; }
        public class GetStructSyncExecSqlDetailResponseBodyStructSyncExecSqlDetail : TeaModel {
            [NameInMap("ExecSql")]
            [Validation(Required=false)]
            public string ExecSql { get; set; }

            [NameInMap("TotalSqlCount")]
            [Validation(Required=false)]
            public long? TotalSqlCount { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
