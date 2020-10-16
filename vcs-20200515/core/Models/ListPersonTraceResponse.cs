// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListPersonTraceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public string Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<ListPersonTraceResponseData> Data { get; set; }
        public class ListPersonTraceResponseData : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=true)]
            public string Date { get; set; }

            [NameInMap("LastTime")]
            [Validation(Required=true)]
            public string LastTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public string StartTime { get; set; }

            [NameInMap("EndSourceImage")]
            [Validation(Required=true)]
            public string EndSourceImage { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=true)]
            public string DeviceId { get; set; }

            [NameInMap("StartTargetImage")]
            [Validation(Required=true)]
            public string StartTargetImage { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=true)]
            public string GroupId { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=true)]
            public string PersonId { get; set; }

            [NameInMap("StartSourceImage")]
            [Validation(Required=true)]
            public string StartSourceImage { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=true)]
            public string CorpId { get; set; }

            [NameInMap("EndTargetImage")]
            [Validation(Required=true)]
            public string EndTargetImage { get; set; }

        }

    }

}
