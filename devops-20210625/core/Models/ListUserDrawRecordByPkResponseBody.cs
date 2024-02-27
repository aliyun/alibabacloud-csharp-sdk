// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListUserDrawRecordByPkResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListUserDrawRecordByPkResponseBodyData> Data { get; set; }
        public class ListUserDrawRecordByPkResponseBodyData : TeaModel {
            [NameInMap("aliyunPk")]
            [Validation(Required=false)]
            public string AliyunPk { get; set; }

            [NameInMap("drawGroup")]
            [Validation(Required=false)]
            public string DrawGroup { get; set; }

            [NameInMap("drawPoolName")]
            [Validation(Required=false)]
            public string DrawPoolName { get; set; }

            [NameInMap("drawResult")]
            [Validation(Required=false)]
            public string DrawResult { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("taskGroupId")]
            [Validation(Required=false)]
            public string TaskGroupId { get; set; }

            [NameInMap("uccId")]
            [Validation(Required=false)]
            public string UccId { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
