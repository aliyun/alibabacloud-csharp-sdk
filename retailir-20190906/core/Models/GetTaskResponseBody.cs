// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailir20190906.Models
{
    public class GetTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTask Task { get; set; }
        public class GetTaskResponseBodyTask : TeaModel {
            [NameInMap("Appkey")]
            [Validation(Required=false)]
            public string Appkey { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            [NameInMap("Request")]
            [Validation(Required=false)]
            public string Request { get; set; }

            [NameInMap("Response")]
            [Validation(Required=false)]
            public string Response { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
