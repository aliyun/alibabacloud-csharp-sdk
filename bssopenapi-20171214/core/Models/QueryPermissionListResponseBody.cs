// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPermissionListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPermissionListResponseBodyData Data { get; set; }
        public class QueryPermissionListResponseBodyData : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("MasterId")]
            [Validation(Required=false)]
            public long? MasterId { get; set; }

            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }

            [NameInMap("PermissionList")]
            [Validation(Required=false)]
            public List<QueryPermissionListResponseBodyDataPermissionList> PermissionList { get; set; }
            public class QueryPermissionListResponseBodyDataPermissionList : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("PermissionCode")]
                [Validation(Required=false)]
                public string PermissionCode { get; set; }

                [NameInMap("PermissionName")]
                [Validation(Required=false)]
                public string PermissionName { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            [NameInMap("SetupTime")]
            [Validation(Required=false)]
            public string SetupTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
