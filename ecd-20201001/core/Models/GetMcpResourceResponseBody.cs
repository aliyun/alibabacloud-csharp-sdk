// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201001.Models
{
    public class GetMcpResourceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMcpResourceResponseBodyData Data { get; set; }
        public class GetMcpResourceResponseBodyData : TeaModel {
            [NameInMap("DesktopInfo")]
            [Validation(Required=false)]
            public GetMcpResourceResponseBodyDataDesktopInfo DesktopInfo { get; set; }
            public class GetMcpResourceResponseBodyDataDesktopInfo : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AuthCode")]
                [Validation(Required=false)]
                public string AuthCode { get; set; }

                [NameInMap("ConnectionProperties")]
                [Validation(Required=false)]
                public string ConnectionProperties { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("ResourceUrl")]
            [Validation(Required=false)]
            public string ResourceUrl { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

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
