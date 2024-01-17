// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListVersionsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListVersionsResponseBodyData> Data { get; set; }
        public class ListVersionsResponseBodyData : TeaModel {
            [NameInMap("ConcurrentCount")]
            [Validation(Required=false)]
            public int? ConcurrentCount { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("Quota")]
            [Validation(Required=false)]
            public int? Quota { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("UseQuota")]
            [Validation(Required=false)]
            public int? UseQuota { get; set; }

            [NameInMap("VersionDetail")]
            [Validation(Required=false)]
            public string VersionDetail { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            [NameInMap("VersionStatus")]
            [Validation(Required=false)]
            public int? VersionStatus { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
