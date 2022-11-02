// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeWaitingSQLInfoResponseBody : TeaModel {
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeWaitingSQLInfoResponseBodyItems> Items { get; set; }
        public class DescribeWaitingSQLInfoResponseBodyItems : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=false)]
            public string Application { get; set; }

            [NameInMap("BlockedByApplication")]
            [Validation(Required=false)]
            public string BlockedByApplication { get; set; }

            [NameInMap("BlockedByPID")]
            [Validation(Required=false)]
            public string BlockedByPID { get; set; }

            [NameInMap("BlockedBySQLStmt")]
            [Validation(Required=false)]
            public string BlockedBySQLStmt { get; set; }

            [NameInMap("BlockedByUser")]
            [Validation(Required=false)]
            public string BlockedByUser { get; set; }

            [NameInMap("GrantLocks")]
            [Validation(Required=false)]
            public string GrantLocks { get; set; }

            [NameInMap("NotGrantLocks")]
            [Validation(Required=false)]
            public string NotGrantLocks { get; set; }

            [NameInMap("PID")]
            [Validation(Required=false)]
            public string PID { get; set; }

            [NameInMap("SQLStmt")]
            [Validation(Required=false)]
            public string SQLStmt { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
