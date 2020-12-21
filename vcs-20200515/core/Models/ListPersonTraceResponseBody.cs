// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListPersonTraceResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPersonTraceResponseBodyData> Data { get; set; }
        public class ListPersonTraceResponseBodyData : TeaModel {
            [NameInMap("EndTargetImage")]
            [Validation(Required=false)]
            public string EndTargetImage { get; set; }

            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public string LastTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("EndSourceImage")]
            [Validation(Required=false)]
            public string EndSourceImage { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("StartSourceImage")]
            [Validation(Required=false)]
            public string StartSourceImage { get; set; }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=false)]
            public string PersonId { get; set; }

            [NameInMap("StartTargetImage")]
            [Validation(Required=false)]
            public string StartTargetImage { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
