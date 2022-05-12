// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeIngressResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeIngressResponseBodyData Data { get; set; }
        public class DescribeIngressResponseBodyData : TeaModel {
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }
            [NameInMap("DefaultRule")]
            [Validation(Required=false)]
            public DescribeIngressResponseBodyDataDefaultRule DefaultRule { get; set; }
            public class DescribeIngressResponseBodyDataDefaultRule : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("ContainerPort")]
                [Validation(Required=false)]
                public int? ContainerPort { get; set; }

            }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }
            [NameInMap("LoadBalanceType")]
            [Validation(Required=false)]
            public string LoadBalanceType { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeIngressResponseBodyDataRules> Rules { get; set; }
            public class DescribeIngressResponseBodyDataRules : TeaModel {
                public string AppId { get; set; }
                public string AppName { get; set; }
                public int? ContainerPort { get; set; }
                public string Domain { get; set; }
                public string Path { get; set; }
            }
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }
            [NameInMap("SlbType")]
            [Validation(Required=false)]
            public string SlbType { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
