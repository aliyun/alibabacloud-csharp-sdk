// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceProvidersPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceProvidersPageResponseBodyData Data { get; set; }
        public class GetServiceProvidersPageResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<GetServiceProvidersPageResponseBodyDataContent> Content { get; set; }
            public class GetServiceProvidersPageResponseBodyDataContent : TeaModel {
                public string Ip { get; set; }
                public string Port { get; set; }
                public string SerializeType { get; set; }
                public string Timeout { get; set; }
            }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public int? TotalElements { get; set; }
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
