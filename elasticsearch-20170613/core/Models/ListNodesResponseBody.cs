// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListNodesResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListNodesResponseBodyHeaders Headers { get; set; }
        public class ListNodesResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListNodesResponseBodyResult> Result { get; set; }
        public class ListNodesResponseBodyResult : TeaModel {
            [NameInMap("agentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            [NameInMap("cloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            [NameInMap("ecsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            [NameInMap("ecsInstanceName")]
            [Validation(Required=false)]
            public string EcsInstanceName { get; set; }

            [NameInMap("ipAddress")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyResultIpAddress> IpAddress { get; set; }
            public class ListNodesResponseBodyResultIpAddress : TeaModel {
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("ipType")]
                [Validation(Required=false)]
                public string IpType { get; set; }

            }

            [NameInMap("osType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyResultTags> Tags { get; set; }
            public class ListNodesResponseBodyResultTags : TeaModel {
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
