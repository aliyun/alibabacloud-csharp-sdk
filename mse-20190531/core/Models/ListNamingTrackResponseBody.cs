// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListNamingTrackResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<ListNamingTrackResponseBodyTraces> Traces { get; set; }
        public class ListNamingTrackResponseBodyTraces : TeaModel {
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("InstanceSize")]
            [Validation(Required=false)]
            public string InstanceSize { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            [NameInMap("PushTimeAll")]
            [Validation(Required=false)]
            public string PushTimeAll { get; set; }

            [NameInMap("PushTimeNetwork")]
            [Validation(Required=false)]
            public string PushTimeNetwork { get; set; }

            [NameInMap("ServerName")]
            [Validation(Required=false)]
            public string ServerName { get; set; }

            [NameInMap("SlaTime")]
            [Validation(Required=false)]
            public string SlaTime { get; set; }

        }

    }

}
