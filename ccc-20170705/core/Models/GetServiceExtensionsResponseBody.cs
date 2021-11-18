// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetServiceExtensionsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceExtensions")]
        [Validation(Required=false)]
        public GetServiceExtensionsResponseBodyServiceExtensions ServiceExtensions { get; set; }
        public class GetServiceExtensionsResponseBodyServiceExtensions : TeaModel {
            [NameInMap("ServiceExtension")]
            [Validation(Required=false)]
            public List<GetServiceExtensionsResponseBodyServiceExtensionsServiceExtension> ServiceExtension { get; set; }
            public class GetServiceExtensionsResponseBodyServiceExtensionsServiceExtension : TeaModel {
                public string Name { get; set; }
                public string Number { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
