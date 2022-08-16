// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotNodeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HoneypotNodeList")]
        [Validation(Required=false)]
        public List<ListHoneypotNodeResponseBodyHoneypotNodeList> HoneypotNodeList { get; set; }
        public class ListHoneypotNodeResponseBodyHoneypotNodeList : TeaModel {
            [NameInMap("AllowHoneypotAccessInternet")]
            [Validation(Required=false)]
            public bool? AllowHoneypotAccessInternet { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DefaultNode")]
            [Validation(Required=false)]
            public bool? DefaultNode { get; set; }

            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            [NameInMap("HoneypotTotalCount")]
            [Validation(Required=false)]
            public int? HoneypotTotalCount { get; set; }

            [NameInMap("HoneypotUsedCount")]
            [Validation(Required=false)]
            public int? HoneypotUsedCount { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("NodeVersion")]
            [Validation(Required=false)]
            public string NodeVersion { get; set; }

            [NameInMap("ProbeTotalCount")]
            [Validation(Required=false)]
            public int? ProbeTotalCount { get; set; }

            [NameInMap("ProbeUsedCount")]
            [Validation(Required=false)]
            public int? ProbeUsedCount { get; set; }

            [NameInMap("SecurityGroupProbeIpList")]
            [Validation(Required=false)]
            public List<string> SecurityGroupProbeIpList { get; set; }

            [NameInMap("TotalStatus")]
            [Validation(Required=false)]
            public int? TotalStatus { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotNodeResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotNodeResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("LastRowKey")]
            [Validation(Required=false)]
            public string LastRowKey { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
