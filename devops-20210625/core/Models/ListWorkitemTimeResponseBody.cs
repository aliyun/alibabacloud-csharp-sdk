// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkitemTimeResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("workitemTime")]
        [Validation(Required=false)]
        public List<ListWorkitemTimeResponseBodyWorkitemTime> WorkitemTime { get; set; }
        public class ListWorkitemTimeResponseBodyWorkitemTime : TeaModel {
            [NameInMap("actualTime")]
            [Validation(Required=false)]
            public float? ActualTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public long? GmtEnd { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public long? GmtStart { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("recordUser")]
            [Validation(Required=false)]
            public string RecordUser { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("workitemIdentifier")]
            [Validation(Required=false)]
            public string WorkitemIdentifier { get; set; }

        }

    }

}
